using Data;
using Models.DTOs;
using Models.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Data.JsonImporters
{
    public class JsonImporter
    {
        private ProductsShopContext context;

        public JsonImporter(ProductsShopContext context)
        {
            this.context = context;
        }

        public void ImportUsers(string path)
        {
            var usersFile = File.ReadAllText(path);

            var json = JsonConvert.DeserializeObject<IEnumerable<UserDTO>>(usersFile);

            foreach (var user in json)
            {
                int? age;

                if (user.Age == 0)
                {
                    age = null;
                }
                else
                {
                    age = user.Age;
                }

                var userEntity = new User
                {
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Age = age
                };

                context.Users.AddOrUpdate(x => new { x.FirstName, x.LastName } , userEntity);
            }

            context.SaveChanges();

            this.SeedFriends();
        }

        public void ImportCategories(string path)
        {
            var categoriesFile = File.ReadAllText(path);

            var json = JsonConvert.DeserializeObject<IEnumerable<CategoryDTO>>(categoriesFile);

            foreach (var category in json)
            {
                var categoryEntity = new Category
                {
                    Name = category.Name
                    
                };
                
                context.Categories.AddOrUpdate(x => x.Name, categoryEntity);
            }

            context.SaveChanges();
        }

        public void ImportProducts(string path)
        {
            var productsFile = File.ReadAllText(path);

            var json = JsonConvert.DeserializeObject<IEnumerable<ProductDTO>>(productsFile);

            var countOfUsers = context.Users.Count();
            var countOfCategories = context.Categories.Count();

            foreach (var product in json)
            {
                var random = new Random();
                int buyerId = random.Next(1, (int)(countOfUsers * 1.25));
                

                int sellerId = random.Next(1, countOfUsers);
                int categoryId = random.Next(1, countOfCategories);
                
                var productEntity = new Product
                {
                    Name = product.Name,
                    Price = product.Price,
                    Buyer = context.Users.FirstOrDefault(u => u.Id == buyerId),
                    Seller = context.Users.FirstOrDefault(u => u.Id == sellerId),

                };
                productEntity.Categories.Add(context.Categories.FirstOrDefault(c => c.Id == categoryId));
                context.Products.AddOrUpdate(x => new { x.Name, x.Price },productEntity);

                Thread.Sleep(2);
            }
            context.SaveChanges();
        }

        public void SeedFriends()
        {
            var random = new Random();
            int countOfUsers = context.Users.Count();
            int maxCountOfFriends = countOfUsers / 3;

            foreach (var user in context.Users)
            {
                int countOfFriendsOfCurrentUser = random.Next(0, maxCountOfFriends);
                for (int i = 0; i < countOfFriendsOfCurrentUser; i++)
                {
                    int idOfFriend = random.Next(1, countOfUsers);
                    User friend = context.Users.FirstOrDefault(f => f.Id == idOfFriend && f.Id != user.Id);
                    if (friend != null)
                    {
                        user.Friends.Add(friend);
                    }
                }
            }
        }

    }
}
