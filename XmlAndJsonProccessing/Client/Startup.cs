
using Data;
using Models.Models;
using Newtonsoft.Json;
using Repos.UnitsOfWork;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class Startup
    {
        public static void Main()
        {
            var context = new ProductsShopContext();

            var unitOfWork = new UnitOfWork(context);


            //3. Query and export data.

            //var products = unitOfWork.Products.FindMany(x => x.Price >= 500 & x.Price <= 1000 && x.Buyer == null)
            //    .Select(x => new
            //    {
            //        Name = x.Name,
            //        Price = x.Price,
            //        Seller = (x.Seller.FirstName + " " + x.Seller.LastName).Trim()
            //    });


            //var jsonProducts = JsonConvert.SerializeObject(products, Formatting.Indented);

            //File.WriteAllText(@"../../../products-in-range.json", jsonProducts);

            //4.

            //var users = unitOfWork.Users.FindMany(u => u.SoldProducts.Where(x => x.Buyer != null).Any())
            //    .Select(x => new
            //    {
            //        firstName = x.FirstName,
            //        lastName = x.LastName,
            //        soldProducts = x.SoldProducts.Where(z => z.Buyer != null).Select(z => new
            //        {
            //            name = z.Name,
            //            price = z.Price,
            //            buyerFirstName = z.Buyer.FirstName,
            //            buyerLastName = z.Buyer.LastName
            //        }),
            //    }).OrderBy(x => x.lastName).ThenBy(x => x.firstName);

            //var jsonProducts = JsonConvert.SerializeObject(users, Formatting.Indented);

            //File.WriteAllText(@"../../../users-sold-products.json", jsonProducts);


            //5. Export categories by product count


            //var caregories = unitOfWork.Categories.FindMany(x => x.Name != null)
            //    .Select(x => new
            //    {
            //        category = x.Name,
            //        productsCount = x.Products.Count,
            //        averagePrice = x.Products.Select(z => (decimal?)z.Price).Average(),
            //        totalRevenue = x.Products.Select(z => (decimal?)z.Price).Sum()
            //    }).OrderByDescending(x => x.productsCount);

            //var jsonCategories = JsonConvert.SerializeObject(caregories, Formatting.Indented);

            //File.WriteAllText(@"../../../categories-by-product-count.json", jsonCategories);


            //6. Users and Products

            //var users = new
            //{
            //    usersCount = context.Users.Count(),
            //    users = context.Users.Select(x => new
            //    {
            //        firstName = x.FirstName,
            //        lastName = x.LastName,
            //        age = x.Age,

            //        soldProducts = new
            //        {
            //            count = x.SoldProducts.Count,
            //            products = x.SoldProducts.Select(z => new
            //            {
            //                z.Name,
            //                z.Price
            //            })
            //        }
            //    })
            //};

            //var jsonUsers = JsonConvert.SerializeObject(users, Formatting.Indented);

            //File.WriteAllText(@"../../../users-with-sold-products.json", jsonUsers);


            //7. 
        }
    }
}
