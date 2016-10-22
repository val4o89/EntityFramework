using MiniORMProject.Attributes;
using MiniORMProject.Entities;
using MiniORMProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MiniORMProject.Core
{
    public class EntityManager : IDbContext
    {
        private SqlConnection connection;

        private string connectionString;

        private bool isCodeFirst;

        public EntityManager(string connectionString, bool isCodeFirst)
        {
            this.connectionString = connectionString;
            this.isCodeFirst = isCodeFirst;
        }

        //public IEnumerable<T> FindAll()
        //{
        //    throw new NotImplementedException();
        //}

        //public IEnumerable<T> FindAll(string where)
        //{
        //    throw new NotImplementedException();
        //}

        //public T FindById(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //public T FindFirst()
        //{
        //    throw new NotImplementedException();
        //}

        //public T FindFirst(string where)
        //{
        //    throw new NotImplementedException();
        //}

        public bool Persist(object entity)
        {
            if (isCodeFirst && !CheckIfTableExist(entity.GetType()))
            {
                this.CreateTable(entity.GetType());
            }

            Type entityType = entity.GetType();

            FieldInfo idInfo = this.GetId(entity.GetType());

            int id = (int)idInfo.GetValue(entity);

            if (id <= 0)
            {
                return this.Insert(entity);
            }

            return this.Update(entity, idInfo);
        }

        private bool Insert(object entity)
        {

            FieldInfo[] fields = entity.GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
                .Where(x => x.IsDefined(typeof(ColumnAttribute))).ToArray();

            StringBuilder sbColumns = new StringBuilder();
            StringBuilder sbValues = new StringBuilder();

            foreach (var field in fields)
            {
                sbColumns.Append($"{field.GetCustomAttribute<ColumnAttribute>().Name}, ");

                sbValues.Append($"'{field.GetValue(entity)}', ");
            }

            sbColumns.Remove(sbColumns.Length - 2, 2);
            sbValues.Remove(sbValues.Length - 2, 2);

            string insertQuery = $"INSERT INTO {GetTableName(entity.GetType())} ({sbColumns.ToString()}) " +
                $"VALUES({sbValues.ToString()})";


            using (this.connection = new SqlConnection(this.connectionString))
            {
                this.connection.Open();

                SqlCommand command = new SqlCommand(insertQuery, connection);

                command.ExecuteNonQuery();
            }

            int numberOfAffectedRows = 0;

            return numberOfAffectedRows > 0;
        }

        private bool Update(object entity, FieldInfo idInfo)
        {
            FieldInfo[] fields = entity.GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
                .Where(x => x.IsDefined(typeof(ColumnAttribute))).ToArray();

            StringBuilder sbColumnsAndValues = new StringBuilder();

            foreach (var field in fields)
            {
                sbColumnsAndValues.Append($"{field.GetCustomAttribute<ColumnAttribute>().Name} = '{field.GetValue(entity)}', ");
            }
            Console.WriteLine(idInfo.GetValue(entity));
            sbColumnsAndValues.Remove(sbColumnsAndValues.Length - 2, 2);
            string updateQuery = $"UPDATE {GetTableName(entity.GetType())} " +
                $"SET {sbColumnsAndValues.ToString()} " +
                $"WHERE Id = {idInfo.GetValue(entity)}";
            Console.WriteLine(updateQuery);

            using (this.connection = new SqlConnection(this.connectionString))
            {
                this.connection.Open();

                SqlCommand command = new SqlCommand(updateQuery, connection);

                command.ExecuteNonQuery();
            }

            int numberOfAffectedRows = 0;

            return numberOfAffectedRows > 0;
        }

        private bool CheckIfTableExist(Type type)
        {
            string query = $"SELECT COUNT(Name) FROM sys.sysobjects " +
                $"WHERE [Name] = '{this.GetTableName(type)}' AND [xtype] = 'U'";
            int countOfTableNames;
            using (connection = new SqlConnection(this.connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                countOfTableNames = (int)command.ExecuteScalar();
            }
            return countOfTableNames > 0;
        }

        //Task 6
        private FieldInfo GetId (Type entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Cannot get id for null type!");
            }

            FieldInfo field = entity.GetFields(BindingFlags.NonPublic | BindingFlags.Instance)
                .FirstOrDefault(x => x.IsDefined(typeof(IDAttribute)));

            if (field == null)
            {
                throw new ArgumentNullException("Cannot operate with entity without primary key");
            }

            return field;
        }

        private string GetTableName(Type entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Cannot get name for null type!");
            }

            if (!entity.IsDefined(typeof(EntityAttribute)))
            {
                throw new ArgumentException("Cannot get table name of entity!");
            }

            string tableName = entity
                .GetCustomAttribute<EntityAttribute>().TableName;

            if (tableName == null)
            {
                throw new ArgumentNullException("Table name cannot be null!");
            }

            return tableName;
        }

        private string GetColumnName(FieldInfo field)
        {
            if (field == null)
            {
                throw new ArgumentNullException("Field cannot be null!");
            }

            if (!field.IsDefined(typeof(ColumnAttribute)))
            {
                return field.Name;
            }

            string columnName = field.GetCustomAttribute<ColumnAttribute>().Name;

            if (columnName == null)
            {
                throw new ArgumentNullException("Column name cannot be null!");
            }

            return columnName;
        }

        private void CreateTable(Type entity)
        {
            string creationString = PrepareTableCreationString(entity);
            using (connection = new SqlConnection(this.connectionString))
            {
                this.connection.Open();
                SqlCommand command = new SqlCommand(creationString, connection);
                command.ExecuteNonQuery();
            }
        }

        private string PrepareTableCreationString(Type entity)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"CREATE TABLE {this.GetTableName(entity)} (");
            sb.Append($"Id INT PRIMARY KEY IDENTITY, ");
            FieldInfo[] columns = entity.GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
                .Where(x => x.IsDefined(typeof(ColumnAttribute))).ToArray();

            for (int i = 0; i < columns.Length; i++)
            {
                sb.Append($"{GetColumnName(columns[i])} {GetTypeToDb(columns[i])}, ");
            }
            sb.Remove(sb.Length - 2, 2);
            sb.Append(")");

            return sb.ToString();
        }

        private string GetTypeToDb(FieldInfo field)

        {
            switch (field.FieldType.Name)
            {
                case "Int32": return "INT";
                case "String": return "VARCHAR(30)";
                case "DateTime": return "DATETIME";
                case "Boolean": return "BIT";
                default: throw new ArgumentException("Unknown data type!");
            }
        }
    }
}
