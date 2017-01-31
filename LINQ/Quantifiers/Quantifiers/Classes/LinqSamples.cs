using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quantifiers.Classes
{
    public class LinqSamples
    {
        Product product;

        public LinqSamples()
        {
            product = new Product();    
        }

        [Category("Quantifiers")]
        [Description("This sample uses Any to determine if any of the words in the array " +
                     "contain the substring 'ei'.")]
        public void Linq67()
        {
            string[] words = { "believe", "relief", "receipt", "field" };

            bool iAfterE = words.Any(w => w.Contains("ei"));
            Console.WriteLine("There is a word in the list that contains 'ei': {0}", iAfterE);

            if (iAfterE)
                Console.WriteLine("The word is '{0}' ", words.First(w => w.Contains("ei")));
        }

        [Category("Quantifiers")]
        [Description("This sample uses Any to return a grouped a list of products only for categories " +
                     "that have at least one product that is out of stock.")]
        public void Linq69()
        {
            List<Product> products = product.GetProductList();

            var productGroups = from prod in products
                                group prod by prod.Category into prodGroup
                                where prodGroup.Any(p => p.UnitsInStock == 0)
                                select new 
                                {
                                    Category = prodGroup.Key,
                                    Products = prodGroup
                                };

            ObjectDumper.Write(productGroups, 1);
        }

        [Category("Quantifiers")]
        [Description("This sample uses All to determine whether an array contains " +
                     "only odd numbers.")]
        public void Linq70()
        {
            int[] numbers = { 1, 11, 3, 19, 41, 65, 19 };

            bool onlyOdd = numbers.All(n => n % 2 == 0);

            Console.WriteLine("The list contains only odd numbers: {0}", onlyOdd);
        }

        [Category("Quantifiers")]
        [Description("This sample uses All to return a grouped a list of products only for categories " +
                     "that have all of their products in stock.")]
        public void Linq72()
        {
            List<Product> products = product.GetProductList();

            var productGroups =
                from prod in products
                group prod by prod.Category into prodGroup
                where prodGroup.All(p => p.UnitsInStock > 0)
                select new { Category = prodGroup.Key, Products = prodGroup };

            ObjectDumper.Write(productGroups, 1);
        }
    }
}
