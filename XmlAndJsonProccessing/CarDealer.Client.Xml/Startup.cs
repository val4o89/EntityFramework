using CarDealer.Data;
using CarDealer.Models.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.XPath;

namespace CarDealer.Client.Xml
{
    public class Startup
    {
        public static void Main()
        {
            var context = new CarDealerContext();

            //1. Import data from xmls.

            //var xmlDocSuppliers = XDocument.Load(@"../../../Xmls/suppliers.xml");
            //var xmlDocParts = XDocument.Load(@"../../../Xmls/parts.xml");
            //var xmlDocCars = XDocument.Load(@"../../../Xmls/cars.xml");
            //var xmlDocCustomers = XDocument.Load(@"../../../Xmls/customers.xml");

            //var supliers = xmlDocSuppliers.XPathSelectElements("suppliers/supplier");
            //var parts = xmlDocParts.XPathSelectElements("parts/part");
            //var cars = xmlDocCars.XPathSelectElements("cars/car");
            //var customers = xmlDocCustomers.XPathSelectElements("customers/customer");

            //foreach (var suplier in supliers)
            //{
            //    var suplierEntity = new PartSupplier
            //    {
            //        IsImporter = Convert.ToBoolean(suplier.Attribute("is-importer").Value),
            //        Name = suplier.Attribute("name").Value
            //    };
            //    context.Supliers.Add(suplierEntity);
            //}

            //foreach (var part in parts)
            //{
            //    var partEntity = new Part
            //    {
            //        Quantity = Convert.ToInt32(part.Attribute("quantity").Value),
            //        Name = part.Attribute("name").Value,
            //        Price = Convert.ToDecimal(part.Attribute("price").Value)
            //    };
            //    context.Parts.Add(partEntity);
            //}

            //foreach (var car in cars)
            //{
            //    var carEntity = new Car
            //    {
            //        Make = car.XPathSelectElement("make").Value,
            //        Model = car.XPathSelectElement("model").Value,
            //        TravelledDistance = Convert.ToInt64(car.XPathSelectElement("travelled-distance").Value)
            //    };
            //    context.Cars.Add(carEntity);
            //}

            //context.SaveChanges();


            //2. Export to XML

            var cars = context.Cars;

            XElement xml = new XElement("cars");

            foreach (var car in cars)
            {
                XElement element = new XElement("car",
                    new XElement("make", car.Make),
                    new XElement("model", car.Model),
                    new XElement("travelled-distance", car.TravelledDistance));
                xml.Add(element);
            }

            xml.Save(new StreamWriter(@"../../../Xmls/exported-cars.xml"));
       }
    }
}
