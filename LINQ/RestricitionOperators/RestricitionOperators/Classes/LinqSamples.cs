using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace RestricitionOperators.Classes
{
    public class LinqSamples
    {
        private List<Product> productList;
        private List<Customer> customerList;

        [Description("This sample uses the where clause to find all elements of an array with a value less than 5.")]
        public void Linq1()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var lowNums = from num in numbers
                          where num < 5
                          select num;

            Console.WriteLine("Numbers < 5:");
            foreach (var x in lowNums)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine();

            //Linq dot notation
            Console.WriteLine("Numbers < 5: (with dot notation)");
            numbers.Where(n => n < 5).ToList().ForEach(n => Console.WriteLine(n));
        }

        [Description("This sample uses the where clause to find all products that are out of stock.")]
        public void Linq2()
        {
            Product product = new Product();
            List<Product> products = product.GetProductList();

            var soldOutProducts = from prod in products
                                  where prod.UnitsInStock == 0
                                  select prod;

            Console.WriteLine("Sold out products: ");
            foreach(var p in soldOutProducts)
            {
                Console.WriteLine("{0} in sold out!", p.ProductName);
            }

            Console.WriteLine();

            //Linq dot notation
            Console.WriteLine("Sold out products: (with dot notation)");
            products.Where(p => p.UnitsInStock == 0).ToList().
                     ForEach(p => Console.WriteLine("{0} in sold out!", p.ProductName));
        }

        [Description("This sample uses the where clause to find all products that are in stock and " +
                     "cost more than 3.00 per unit.")]
        public void Linq3()
        {
            Product product = new Product();
            List<Product> products = product.GetProductList();

            var expensiveInStockProducts = from prod in products
                                           where prod.UnitsInStock > 0 && prod.UnitPrice > 3.00M
                                           select prod;

            Console.WriteLine("In-stock product that costs more than 3.00:");
            foreach (var p in expensiveInStockProducts)
            {
                Console.WriteLine("{0}", p.ProductName);
            }

            Console.WriteLine();

            //Linq dot notation
            Console.WriteLine("In-stock product that costs more than 3.00: (with dot notation)");
            products.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3.00M).ToList().
                     ForEach(p => Console.WriteLine("{0}", p.ProductName));
        }


        [Description("This sample uses the where clause to find all customers in Washington " +
                     "and then it uses a foreach loop to iterate over the orders collection that belongs to each customer.")]
        public void Linq4()
        {
            Customer customer = new Customer();
            List<Customer> customers = customer.GetCustomerList();

            var waCustomers = from cust in customers
                              where cust.Region == "WA"
                              select cust;

            Console.WriteLine("Customers from Washington and their orders:");
            foreach (var c in waCustomers)
            {
                Console.WriteLine("Customer {0}: {1}", c.CustomerId, c.CompanyName);
                foreach (var order in c.Orders)
                {
                    Console.WriteLine("  Order {0}: {1}", order.OrderId, order.OrderDate);
                }
            }


            Console.WriteLine();

            //Linq dot notation
            Console.WriteLine("Customers from Washington and their orders: (with dot notation)");
            customers.Where(c => c.Region == "WA").ToList().
                ForEach(c =>
                    {
                        Console.WriteLine("Customer {0}: {1}", c.CustomerId, c.CompanyName);
                        c.Orders.ToList().ForEach(o => Console.WriteLine("  Order {0}: {1}", o.OrderId, o.OrderDate));
                    });
        }

        [Description("This sample demonstrates an indexed where clause that returns digits whose name is " +
                    "shorter than their value.")]
        public void Linq5()
        {
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var shortDigits = digits.Where((digit, index) => digit.Length < index);
            
            Console.WriteLine("Short digits:");
            foreach (var d in shortDigits)
            {
                Console.WriteLine("The word {0} is shorter than its value.", d);
            }

            Console.WriteLine();

            //Linq dot notation
            Console.WriteLine("Short digits: (with dot notation)");
            digits.Where((digit, index) => digit.Length < index).ToList().
                   ForEach(d => Console.WriteLine("The word {0} is shorter than its value.", d));

        }
    }
}
