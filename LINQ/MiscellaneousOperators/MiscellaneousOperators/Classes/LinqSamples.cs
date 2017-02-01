using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiscellaneousOperators.Classes
{
    public class LinqSamples
    {
        private Product product;
        private Customer customer;

        public LinqSamples()
        {
            product = new Product();
            customer = new Customer();
        }

        [Category("Miscellaneous Operators")]
        [Description("This sample uses Concat to create one sequence that contains each array's " +
                     "values, one after the other.")]
        public void Linq94()
        {
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };

            var allNumbers = numbersA.Concat(numbersB);

            Console.WriteLine("All numbers from both arrays:");
            foreach (var n in allNumbers)
            {
                Console.WriteLine(n);
            }
        }

        [Category("Miscellaneous Operators")]
        [Description("This sample uses Concat to create one sequence that contains the names of " +
                     "all customers and products, including any duplicates.")]
        public void Linq95()
        {
            List<Customer> customers = customer.GetCustomerList();
            List<Product> products = product.GetProductList();

            var customerNames = from cust in customers
                                select cust.CompanyName;

            var productNames = from prod in products
                               select prod.ProductName;

            var allNames = customerNames.Concat(productNames);

            Console.WriteLine("Customer and product names:");
            foreach (var n in allNames)
            {
                Console.WriteLine(n);
            }
        }

        [Category("Miscellaneous Operators")]
        [Description("This sample uses SequenceEquals to see if two sequences match on all elements " +
                     "in the same order.")]
        public void Linq96()
        {
            var wordsA = new string[] { "cherry", "apple", "blueberry" };
            var wordsB = new string[] { "cherry", "apple", "blueberry" };

            bool match = wordsA.SequenceEqual(wordsB);

            Console.WriteLine("The sequences match: {0}", match);
        }

        [Category("Miscellaneous Operators")]
        [Description("This sample uses SequenceEqual to see if two sequences match on all elements " +
                     "in the same order.")]
        public void Linq97()
        {
            var wordsA = new string[] { "cherry", "apple", "blueberry" };
            var wordsB = new string[] { "apple", "blueberry", "cherry" };

            bool match = wordsA.SequenceEqual(wordsB);

            Console.WriteLine("The sequences match: {0}", match);
        }
    }
}
