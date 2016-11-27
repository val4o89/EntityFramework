using CarDealer.Data;
using CarDealer.Models.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer.Client
{
    public class Startup
    {
        static void Main(string[] args)
        {
            var context = new CarDealerContext();

            var json3 = File.ReadAllText(@"C:\Users\VALENTIN\Downloads\08. DB-Advanced-EntityFramework-JSON-Processing-Exercises\08. DB-Advanced-EntityFramework-JSON-Processing-Exercises\suppliers.json");
            var supliersJson = JsonConvert.DeserializeObject<IEnumerable<PartSupplier>>(json3);

            context.Supliers.AddRange(supliersJson);

            context.SaveChanges();

            var json2 = File.ReadAllText(@"C:\Users\VALENTIN\Downloads\08. DB-Advanced-EntityFramework-JSON-Processing-Exercises\08. DB-Advanced-EntityFramework-JSON-Processing-Exercises\parts.json");
            var partsJson = JsonConvert.DeserializeObject<IEnumerable<Part>>(json2);

            context.Parts.AddRange(partsJson);

            context.SaveChanges();

            var json = File.ReadAllText(@"C:\Users\VALENTIN\Downloads\08. DB-Advanced-EntityFramework-JSON-Processing-Exercises\08. DB-Advanced-EntityFramework-JSON-Processing-Exercises\cars.json");
            var carsJson = JsonConvert.DeserializeObject<IEnumerable<Car>>(json);

            context.Cars.AddRange(carsJson);

            context.SaveChanges();


            var json4 = File.ReadAllText(@"C:\Users\VALENTIN\Downloads\08. DB-Advanced-EntityFramework-JSON-Processing-Exercises\08. DB-Advanced-EntityFramework-JSON-Processing-Exercises\customers.json");
            var customersJson = JsonConvert.DeserializeObject<IEnumerable<Customer>>(json4);

            context.Customers.AddRange(customersJson);

            context.SaveChanges();
        }
    }
}
