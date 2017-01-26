using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectionOperators.Classes
{
    public class LinqSamples
    {
        private DataSet testDs;

        public LinqSamples()
        {
            testDs = TestHelper.CreateTestDataset();
        }

        [Category("Projection Operators")]
        [Description("This sample uses select to produce a sequence of ints one higher than " +
                         "those in an existing array of ints.")]
        public void DataSetLinq6()
        {
            var numbers = testDs.Tables["Numbers"].AsEnumerable();

            var numPlusOne = from n in numbers
                             select n.Field<int>(0) + 1;

            Console.WriteLine("Numbers + 1:");
            foreach (var n in numPlusOne)
            {
                Console.WriteLine("Original {0} - Final {1}", n-1 ,n);
            }

            Console.WriteLine();

            //Linq dot notation
            Console.WriteLine("Numbers + 1: (dot notation)");
            numbers.Select(n => n.Field<int>(0) + 1).ToList().
                    ForEach(n => Console.WriteLine("Original {0} - Final {1}", n-1 ,n));
        }

        [Category("Projection Operators")]
        [Description("This sample uses select to return a sequence of just the names of a list of products.")]
        public void DataSetLinq7()
        {
            var products = testDs.Tables["Products"].AsEnumerable();

            var productNames = from p in products
                               select p.Field<string>("ProductName");

            Console.WriteLine("Product Names:");
            foreach(var p in productNames)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine();

            //Linq dot notation
            Console.WriteLine("Product Names: (dot notation)");
            products.Select(s => s.Field<string>("ProductName")).ToList().
                     ForEach(p => Console.WriteLine(p));
        }

        [Category("Projection Operators")]
        [Description("This sample uses select to produce a sequence of strings representing " +
                     "the text version of a sequence of ints.")]
        public void DataSetLinq8()
        {
            var numbers = testDs.Tables["Numbers"].AsEnumerable();
            string[] strings = { "zero", "one", "two", "three", "four", "five", "six", 
                                 "seven", "eight", "nine" };

            var textNums = from n in numbers
                           select strings[n.Field<int>("number")];

            Console.WriteLine("Number strings");
            foreach (var s in textNums)
            {
                Console.WriteLine(s);
            }

            //Linq dot notation
            Console.WriteLine("Number strings: (dot notation)");
            numbers.Select(n => strings[n.Field<int>("number")]).ToList().
                    ForEach(n => Console.WriteLine(n));
        }

        [Category("Projection Operators")]
        [Description("This sample uses select to produce a sequence of the uppercase " +
                     "and lowercase versions of each word in the original array.")]
        public void DataSetLinq9()
        {
            var words = testDs.Tables["Words"].AsEnumerable();

            var upperLowerWords = words.Select(p => new 
            { 
                Upper = (p.Field<string>(0)).ToUpper(),
                Lower = (p.Field<string>(0)).ToLower()
            });

            Console.WriteLine("Uppercase and Lowercase: ");
            foreach(var ul in upperLowerWords)
            {
                Console.WriteLine("Uppercase: " + ul.Upper + ", Lowercase: " + ul.Lower);
            }

            //Linq dot notation
            Console.WriteLine("Uppercase and Lowercase: (dot notation)");
            words.Select(p => new
            {
                Upper = (p.Field<string>(0)).ToUpper(),
                Lower = (p.Field<string>(0)).ToLower()
            }).ToList().ForEach(ul => Console.WriteLine("Uppercase: " + ul.Upper + ", Lowercase: " + ul.Lower));
        }

        [Category("Projection Operators")]
        [Description("This sample uses select to produce a sequence containing text " +
                     "representations of digits and whether their length is even or odd.")]
        public void DataSetLinq10()
        {
            var numbers = testDs.Tables["Numbers"].AsEnumerable();
            var digits = testDs.Tables["Digits"];
            string[] strings = { "zero", "one", "two", "three", "four", "five", "six", 
                                   "seven", "eight", "nine" };

            var digitOddEvens = numbers.Select(n => new
            {
                Digit = digits.Rows[n.Field<int>("number")]["digit"],
                Even = (n.Field<int>("number") % 2 == 0)
            });

            Console.WriteLine("Digit odd or even:");
            foreach (var d in digitOddEvens)
            {
                Console.WriteLine("The digit {0} is {1}.", d.Digit, d.Even ? "even" : "odd");
            }

            //Linq dot notation
            Console.WriteLine("Digit odd or even: (dot notation)");
            numbers.Select(n => new
            {
                Digit = digits.Rows[n.Field<int>("number")]["digit"],
                Even = (n.Field<int>("number") % 2 == 0)
            }).ToList().ForEach(d => Console.WriteLine("The digit {0} is {1}.", 
                                                        d.Digit, d.Even ? "even" : "odd"));
        }

        [Category("Projection Operators")]
        [Description("This sample uses select to produce a sequence containing some properties " +
                     "of Products, including UnitPrice which is renamed to Price " +
                     "in the resulting type.")]
        public void DataSetLinq11()
        {
            var products = testDs.Tables["Products"].AsEnumerable();

            var productInfos = products.Select(p => new
            {
                ProductName = p.Field<string>("ProductName"),
                Category = p.Field<string>("Category"),
                Price = p.Field<decimal>("UnitPrice")
            });

            Console.WriteLine("Product Info:");
            foreach (var p in productInfos)
            {
                Console.WriteLine("{0} is in the category {1} and costs {2} per unit.", 
                                   p.ProductName, p.Category, p.Price);
            }

            //Linq dot notation
            Console.WriteLine("Product Info: (dot notation)");

            products.Select(p => new
            {
                ProductName = p.Field<string>("ProductName"),
                Category = p.Field<string>("Category"),
                Price = p.Field<decimal>("UnitPrice")
            }).ToList().ForEach(p => Console.WriteLine("{0} is in the category {1} and costs {2} per unit.",
                                   p.ProductName, p.Category, p.Price));
        }

        [Category("Projection Operators")]
        [Description("This sample uses an indexed Select clause to determine if the value of ints " +
                     "in an array match their position in the array.")]
        public void DataSetLinq12()
        {
            var numbers = testDs.Tables["Numbers"].AsEnumerable();

            var numsInPlace = numbers.Select((num, index) => new 
            {
                Num = num.Field<int>("number"),
                InPlace = (num.Field<int>("number") == index)
            });

            Console.WriteLine("Number: In place?");
            foreach (var n in numsInPlace)
            {
                Console.WriteLine("{0}: {1}", n.Num, n.InPlace);
            }

            //Linq dot notation
            Console.WriteLine("Number: In place? (dot notation)");
            numbers.Select((num, index) => new
            {
                Num = num.Field<int>("number"),
                InPlace = (num.Field<int>("number") == index)
            }).ToList().ForEach(n => Console.WriteLine("{0}: {1}", n.Num, n.InPlace));
        }

        [Category("Projection Operators")]
        [Description("This sample combines select and where to make a simple query that returns " +
                     "the text form of each digit less than 5.")]
        public void DataSetLinq13()
        {
            var numbers = testDs.Tables["Numbers"].AsEnumerable();
            var digits = testDs.Tables["Digits"];

            var lowNums = from n in numbers
                          where n.Field<int>("number") < 5
                          select digits.Rows[n.Field<int>("number")].Field<string>("digit");

            Console.WriteLine("Numbers < 5:");
            foreach (var n in lowNums)
            {
                Console.WriteLine(n);
            }

            //Linq dot notation
            Console.WriteLine("Numbers < 5: (dot notation)");
            numbers.Where(n => n.Field<int>("number") < 5).
                    Select(n => digits.Rows[n.Field<int>("number")].Field<string>("digit")).ToList().
                    ForEach(n => Console.WriteLine(n));

        }

        [Category("Projection Operators")]
        [Description("This sample uses a compound from clause to make a query that returns all pairs " +
                     "of numbers from both arrays such that the number from numbersA is less than the number " +
                     "from numbersB.")]
        public void DataSetLinq14()
        {
            var numbersA = testDs.Tables["NumbersA"].AsEnumerable();
            var numbersB = testDs.Tables["NumbersB"].AsEnumerable();

            var pairs = from a in numbersA
                        from b in numbersB
                        where a.Field<int>("number") < b.Field<int>("number")
                        select new
                        {
                            a = a.Field<int>("number"),
                            b = b.Field<int>("number")
                        };

            Console.WriteLine("Pairs where a < b:");
            foreach (var p in pairs)
            {
                Console.WriteLine("{0} is less than {1}", p.a, p.b);
            }

            //Linq dot notation
            Console.WriteLine("Pairs where a < b: (dot notation)");
            numbersA.Join(numbersB, a => a.Field<int>("number"), b => b.Field<int>("number"), 
                                   (a, b) => new { a, b })
                    .Where(w => w.a.Field<int>("number") < w.b.Field<int>("number"))
                    .Select(s => new
                    {
                        a = s.a.Field<int>("number"),
                        b = s.b.Field<int>("number")
                    }).ToList().ForEach(p => Console.WriteLine("{0} is less than {1}", p.a, p.b));
        }

        [Category("Projection Operators")]
        [Description("This sample uses a compound from clause to select all orders where the " +
                     "order total is less than 500.00.")]
        public void DataSetLinq15()
        {
            var customers = testDs.Tables["Customers"].AsEnumerable();
            var orders = testDs.Tables["Orders"].AsEnumerable();

            var smallOrders = from c in customers
                              from o in orders
                              where c.Field<string>("CustomerId") == o.Field<string>("CustomerId") &&
                                    o.Field<decimal>("Total") < 500.00M
                              select new 
                              {
                                  CustomerId = c.Field<string>("CustomerId"),
                                  OrderId = o.Field<int>("OrderId"),
                                  Total = o.Field<decimal>("Total")
                              };

            ObjectDumper.Write(smallOrders);
        }

        [Category("Projection Operators")]
        [Description("This sample uses a compound from clause to select all orders where the " +
                     "order was made in 1998 or later.")]
        public void DataSetLinq16()
        {
            var customers = testDs.Tables["Customers"].AsEnumerable();
            var orders = testDs.Tables["Orders"].AsEnumerable();

            var myOrders = from c in customers
                           from o in orders
                           where c.Field<string>("CustomerId") == o.Field<string>("CustomerId") &&
                                 o.Field<DateTime>("OrderDate") >= new DateTime(1998, 1, 1)
                           select new
                           {
                               CustomerId = c.Field<string>("CustomerId"),
                               OrderId = o.Field<int>("OrderId"),
                               OrderDate = o.Field<DateTime>("OrderDate")
                           };

            ObjectDumper.Write(myOrders);
        }

        [Category("Projection Operators")]
        [Description("This sample uses a compound from clause to select all orders where the " +
                     "order total is greater than 2000.00 and uses from assignment to avoid " +
                     "requesting the total twice.")]
        public void DataSetLinq17()
        {
            var customers = testDs.Tables["Customers"].AsEnumerable();
            var orders = testDs.Tables["Orders"].AsEnumerable();

            var myOrders = from c in customers
                           from o in orders
                           let total = o.Field<decimal>("Total")
                           where c.Field<string>("CustomerId") == o.Field<string>("CustomerId") &&
                                 total >= 2000.0M
                           select new
                           {
                               CustomerId = c.Field<string>("CustomerId"),
                               OrderId = o.Field<int>("OrderId"),
                               total
                           };

            ObjectDumper.Write(myOrders);
        }

        [Category("Projection Operators")]
        [Description("This sample uses multiple from clauses so that filtering on customers can " +
                     "be done before selecting their orders.  This makes the query more efficient by " +
                     "not selecting and then discarding orders for customers outside of Washington.")]
        public void DataSetLinq18()
        {
            var customers = testDs.Tables["Customers"].AsEnumerable();
            var orders = testDs.Tables["Orders"].AsEnumerable();
            DateTime custOffDate = new DateTime(1997,1,1);

            var myOrders = from c in customers
                           where c.Field<string>("Region") == "WA"
                           from o in orders
                           where c.Field<string>("CustomerId") == o.Field<string>("CustomerId") &&
                                 (DateTime)o["OrderDate"] >= custOffDate
                           select new
                           {
                               CustomerId = c.Field<string>("CustomerId"),
                               OrderId = o.Field<int>("OrderId")
                           };

            ObjectDumper.Write(myOrders);
        }

        [Category("Projection Operators")]
        [Description("This sample uses an indexed SelectMany clause to select all orders, " +
                     "while referring to customers by the order in which they are returned " +
                     "from the query.")]
        public void DataSetLinq19()
        {
            var customers = testDs.Tables["Customers"].AsEnumerable();
            var orders = testDs.Tables["Orders"].AsEnumerable();

            var customerOrders = customers.SelectMany((cust, custIndex) =>
                                 orders.Where(o => cust.Field<string>("CustomerId") == o.Field<string>("CustomerID")).Select(s => new
                                 {
                                     CustomerIndex = custIndex + 1,
                                     OrderId = s.Field<int>("OrderId")
                                 }));

            foreach(var c in customerOrders)
            {
                Console.WriteLine("Customer Index {0} has an order with OrderId {1}", c.CustomerIndex, c.OrderId);
            }
        }
    }
}
