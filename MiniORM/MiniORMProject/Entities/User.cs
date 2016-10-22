using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniORMProject.Entities
{
    using Attributes;

    [Entity(TableName = "Users")]
    public class User
    {
        [ID]
        private int id;

        [Column(Name = "Username")]
        private string username;

        [Column(Name = "Password")]
        private string password;

        [Column(Name = "Age")]
        private int age;

        [Column(Name = "RegistrationDate")]
        private DateTime registrationDate;

        public int Id
        {
            get
            {
                return this.id;
            }

            private set
            {
                this.id = value;
            }
        }

        public string Username
        {
            get
            {
                return this.username;
            }
            private set
            {
                this.username = value;
            }
        }

        public string Password
        {
            get
            {
                return this.password;
            }
            private set
            {
                this.password = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            private set
            {
                this.age = value;
            }
        }

        public DateTime RegistrationDate
        {
            get
            {
                return this.registrationDate;
            }
            private set
            {
                this.registrationDate = value;
            }
        }

        public User(string username, string password, int age, DateTime registrationDate, int id = 0)
        {
            this.Id = id;
            this.Username = username;
            this.Password = password;
            this.Age = age;
            this.RegistrationDate = registrationDate;
        }
    }
}
