using Data;
using Models.Models;
using Repos.Contracts;
using Repos.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repos.UnitsOfWork
{
    public class UnitOfWork
    {
        private ProductsShopContext context;
        private IRepository<User> usersRepo;
        private IRepository<Product> productsRepo;
        private IRepository<Category> categoryRepo;

        public UnitOfWork(ProductsShopContext context)
        {
            this.context = context;

            this.usersRepo = new Repository<User>(context);
            this.productsRepo = new Repository<Product>(context);
            this.categoryRepo = new Repository<Category>(context);
        }

        public IRepository<User> Users
        {
            get { return this.usersRepo; }
            set { this.usersRepo = value; }
        }

        public IRepository<Product> Products
        {
            get { return this.productsRepo; }
            set { this.productsRepo = value; }
        }
        public IRepository<Category> Categories
        {
            get { return this.categoryRepo; }
            set { this.categoryRepo = value; }
        }



    }
}
