using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementOperators.Classes
{
    public class LinqSamples
    {
        private Product product;

        public LinqSamples()
        {
            product = new Product();
        }

        [Category("Element Operators")]
        [Description("This sample uses First to return the first matching element " +
                     "as a Product, instead of as a sequence containing a Product.")]
        public void Linq58()
        {
            List<Product> products = product.GetProductList();
            Product product12 = (from prod in products
                                 where prod.ProductId == 12
                                 select prod).First();

            ObjectDumper.Write(product12);
        }

        [Category("Element Operators")]
        [Description("This sample uses First to find the first element in the array that starts with 'o'.")]
        public void Linq59()
        {
            string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var startsWithO = strings.First(s => s[0] == 'o');

            Console.WriteLine("A string starting with 'o': {0}", startsWithO);
        }

        [Category("Element Operators")]
        [Description("This sample uses FirstOrDefault to try to return the first element of the sequence, " +
                     "unless there are no elements, in which case the default value for that type " +
                     "is returned. FirstOrDefault is useful for creating outer joins.")]
        public void Linq61()
        {
            int[] numbers = { };

            int firstNumOrDefault = numbers.FirstOrDefault();

            Console.WriteLine(firstNumOrDefault);
        }


        [Category("Element Operators")]
        [Description("This sample uses FirstOrDefault to return the first product whose ProductID is 789 " +
                     "as a single Product object, unless there is no match, in which case null is returned.")]
        public void Linq62()
        {
            List<Product> products = product.GetProductList();

            Product product789 = products.FirstOrDefault(p => p.ProductId == 789);

            Console.WriteLine("Product 789 exists: {0}", product789 != null);
        }

        [Category("Element Operators")]
        [Description("This sample uses ElementAt to retrieve the second number greater than 5 " +
                     "from an array.")]
        public void Linq64()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            int secondGreaterThanFive = (from num in numbers
                                         where num > 5
                                         select num).ElementAt(1);  // second number is index 1 because sequences use 0-based indexing

            Console.WriteLine("Second number > 5: {0}", secondGreaterThanFive);
        }
    }
}
