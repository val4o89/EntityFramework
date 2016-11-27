namespace Data.Migrations
{
    using Data.Globals;
    using JsonImporters;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Data.ProductsShopContext>
    {
        public Configuration()
        {
            AutomaticMigrationDataLossAllowed = true;
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Data.ProductsShopContext context)
        {
            var jsonImporter = new JsonImporter(context);

            jsonImporter.ImportUsers(Constants.JsonUsersPath);
            jsonImporter.ImportCategories(Constants.JsonCategoriesPath);
            jsonImporter.ImportProducts(Constants.JsonProductsPath);
        }
    }
}
