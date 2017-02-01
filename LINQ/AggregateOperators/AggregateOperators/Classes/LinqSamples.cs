using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregateOperators.Classes
{
    public class LinqSamples
    {
        private Customer customer;
        private Product product;

        public LinqSamples ()
	    {
            customer = new Customer();
            product = new Product();
	    }

        [Category("Aggregate Operators")]
        [Description("This sample uses Count to get the number of unique prime factors of 300.")]
        public void Linq73()
        {
            int[] primeFactorsOf300 = { 2, 2, 3, 5, 5 };

            int uniqueFactors = primeFactorsOf300.Distinct().Count();

            Console.WriteLine("There are {0} unique prime factors of 300.", uniqueFactors);
        }

        [Category("Aggregate Operators")]
        [Description("This sample uses Count to get the number of odd ints in the array.")]
        public void Linq74()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var oddNumbers = numbers.Count(n => n % 2 == 1);
            Console.WriteLine("There are {0} odd numbers in the list.", oddNumbers);

            if(oddNumbers != 0)
            {
                Console.WriteLine("List of odd numbers:");
                numbers.Where(n => n % 2 == 1).ToList().ForEach(n => Console.WriteLine(n));
            }
        }

        [Category("Aggregate Operators")]
        [Description("This sample uses Count to return a list of customers and how many orders " +
                     "each has.")]
        public void Linq76()
        {
            List<Customer> customers = customer.GetCustomerList();

            var orderCounts = from cust in customers
                              select new 
                              {
                                  cust.CustomerId,
                                  OrderCount = cust.Orders.Count()
                              };

            ObjectDumper.Write(orderCounts);
        }

        [Category("Aggregate Operators")]
        [Description("This sample uses Count to return a list of categories and how many products " +
                     "each has.")]
        public void Linq77()
        {
            List<Product> products = product.GetProductList();

            var categoryCounts = from prod in products
                                 group prod by prod.Category into prodGroup
                                 select new
                                 {
                                     Category = prodGroup.Key,
                                     ProductCount = prodGroup.Count()
                                 };

             ObjectDumper.Write(categoryCounts);
        }

        [Category("Aggregate Operators")]
        [Description("This sample uses Sum to add all the numbers in an array.")]
        public void Linq78()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var sumNums = numbers.Sum();

            Console.WriteLine("The sum of the numbers is {0}.", sumNums);
        }

        [Category("Aggregate Operators")]
        [Description("This sample uses Sum to get the total number of characters of all words " +
                     "in the array.")]
        public void Linq79()
        {
            string[] words = { "cherry", "apple", "blueberry" };

            var totalChars = words.Sum(w => w.Length);

            Console.WriteLine("There are a total of {0} characters in these words.", totalChars);
        }

        [Category("Aggregate Operators")]
        [Description("This sample uses Sum to get the total units in stock for each product category.")]
        public void Linq80()
        {
            List<Product> products = product.GetProductList();

            var categories = from prod in products
                             group prod by prod.Category into prodGroup
                             select new
                             {
                                 Category = prodGroup.Key,
                                 TotalUnitStock = prodGroup.Sum(p => p.UnitsInStock)
                             };

            ObjectDumper.Write(categories);
        }

        [Category("Aggregate Operators")]
        [Description("This sample uses Min to get the lowest number in an array.")]
        public void Linq81()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var minNum = numbers.Min();

            Console.WriteLine("The minimum number is {0}.", minNum);
        }

        [Category("Aggregate Operators")]
        [Description("This sample uses Min to get the length of the shortest word in an array.")]
        public void Linq82()
        {
            string[] words = { "cherry", "apple", "blueberry" };

            var shortestWord = words.Min(w => w.Length);
            Console.WriteLine("The shortest word is {0} characters long.", shortestWord);
        }

        [Category("Aggregate Operators")]
        [Description("This sample uses Min to get the cheapest price among each category's products.")]
        public void Linq83()
        {
            List<Product> products = product.GetProductList();

            var categories = from prod in products
                             group prod by prod.Category into prodGroup
                             select new
                             {
                                 Category = prodGroup.Key,
                                 CheapestPrice = prodGroup.Min(p => p.UnitPrice)
                             };

            ObjectDumper.Write(categories);
        }

        [Category("Aggregate Operators")]
        [Description("This sample uses Min to get the products with the lowest price in each category.")]
        public void Linq84()
        {
            List<Product> products = product.GetProductList();

            var categories = from prod in products
                             group prod by prod.Category into prodGroup
                             let minPrice = prodGroup.Min(p => p.UnitPrice)
                             select new
                                 {
                                     Category = prodGroup.Key,
                                     CheapestProducts = prodGroup.Where(p => p.UnitPrice == minPrice)
                                 };

            ObjectDumper.Write(categories, 1);
        }

        [Category("Aggregate Operators")]
        [Description("This sample uses Max to get the highest number in an array. Note that the method returns a single value.")]
        public void Linq85()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var maxNum = numbers.Max();

            Console.WriteLine("The maximum number is {0}.", maxNum);
        }

        [Category("Aggregate Operators")]
        [Description("This sample uses Max to get the length of the longest word in an array.")]
        public void Linq86()
        {
            string[] words = { "cherry", "apple", "blueberry" };

            var longestWord = words.Max(w => w.Length);

            Console.WriteLine("The longest word is {0} characters long.", longestWord);
        }

        [Category("Aggregate Operators")]
        [Description("This sample uses Max to get the most expensive price among each category's products.")]
        public void Linq87()
        {
            List<Product> products = product.GetProductList();

            var categories = from prod in products
                             group prod by prod.Category into prodGroup
                             select new
                             {
                                 Category = prodGroup.Key,
                                 MostExpensiveProduct = prodGroup.Max(p => p.UnitPrice)
                             };

            ObjectDumper.Write(categories);
        }

        [Category("Aggregate Operators")]
        [Description("This sample uses Max to get the products with the most expensive price in each category.")]
        public void Linq88()
        {
            List<Product> products = product.GetProductList();

            var categories = from prod in products
                             group prod by prod.Category into prodGroup
                             let maxPrice = prodGroup.Max(p => p.UnitPrice)
                             select new 
                             {
                                 Category = prodGroup.Key,
                                 MostExpensiveProducts = prodGroup.Where(p => p.UnitPrice == maxPrice)
                             };         

            ObjectDumper.Write(categories, 1);
        }
        [Category("Aggregate Operators")]
        [Description("This sample uses Average to get the average of all numbers in an array.")]
        public void Linq89()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var averageNum = numbers.Average();
            Console.WriteLine("The average number is {0}.", averageNum);
            }

        [Category("Aggregate Operators")]
        [Description("This sample uses Average to get the average length of the words in the array.")]
        public void Linq90()
        {
            string[] words = { "cherry", "apple", "blueberry" };

            var averageWord = words.Average(w => w.Length);
            Console.WriteLine("The average word length is {0} characters.", averageWord);
        }

        [Category("Aggregate Operators")]
        [Description("This sample uses Average to get the average price of each category's products.")]
        public void Linq91()
        {
            List<Product> products = product.GetProductList();

            var categories = from prod in products
                             group prod by prod.Category into prodGroups
                             select new
                             {
                                 Category = prodGroups.Key,
                                 AveragePrice = prodGroups.Average(p => p.UnitPrice)
                             };

            ObjectDumper.Write(categories);
        }

        [Category("Aggregate Operators")]
        [Description("This sample uses Aggregate to create a running product on the array that " +
                     "calculates the total product of all elements.")]
        public void Linq92()
        {
            double[] doubles = { 1.7, 2.3, 1.9, 4.1, 2.9 };

            double product = doubles.Aggregate((runningProduct, nextFactor) => runningProduct * nextFactor);

            Console.WriteLine("Total product of all numbers: {0}", product);
        }

        [Category("Aggregate Operators")]
        [Description("This sample uses Aggregate to create a running account balance that " +
                     "subtracts each withdrawal from the initial balance of 100, as long as " +
                     "the balance never drops below 0.")]
        public void Linq93()
        {
            double startBalance = 100.0;
            int[] attemptedWithdrawals = { 20, 10, 40, 50, 10, 70, 30 };

            var endBalance = attemptedWithdrawals.Aggregate(startBalance, 
                                                            (balance, nextWithdrawal) =>
                                                            (nextWithdrawal <= balance) ? (balance - nextWithdrawal) : balance);

            Console.WriteLine("Ending balance: {0}", endBalance);

        }

    }
}
