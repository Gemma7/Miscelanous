using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace OrderingOperators.Classes
{
    public class LinqSamples
    {
        [Category("Ordering Operators")]
        [Description("This sample uses orderby to sort a list of words alphabetically.")]
        public void Linq28()
        {
            string[] words = { "cherry", "apple", "blueberry" };

            var sortedWords = from word in words
                              orderby word
                              select word;

            Console.WriteLine("The sorted list of words:");
            foreach(var w in sortedWords)
            {
                Console.WriteLine(w);
            }

            //Linq dot notation
            Console.WriteLine("The sorted list of words: (dot notation)");
            words.OrderBy(w => w).ToList().ForEach(w => Console.WriteLine(w));
        }

        [Category("Ordering Operators")]
        [Description("This sample uses orderby to sort a list of words by length.")]
        public void Linq29()
        {
            string[] words = { "cherry", "apple", "blueberry" };

            var sortedWords = from word in words
                              orderby word.Length
                              select word;

            Console.WriteLine("The sorted list of words (by length):");
            foreach (var w in sortedWords)
            {
                Console.WriteLine(w);
            }

            //Linq dot notation
            Console.WriteLine("The sorted list of words (by length): (dot notation)");
            words.OrderBy(w => w.Length).ToList().ForEach(w => Console.WriteLine(w));
        }

        [Category("Ordering Operators")]
        [Description("This sample uses orderby to sort a list of products by name. " +
                    "Use the \"descending\" keyword at the end of the clause to perform a reverse ordering.")]
        public void Linq30()
        {
            Product product = new Product();
            List<Product> products = product.GetProductList();

            var sortedProducts = from prod in products
                                 orderby prod.ProductName
                                 select prod;

            var reversedSortedProducts = from prod in products
                                         orderby prod.ProductName descending
                                         select prod;

            Console.WriteLine("The sorted list of products:");
            ObjectDumper.Write(sortedProducts);

            Console.WriteLine("The reversed sorted list of products:");
            ObjectDumper.Write(reversedSortedProducts);


            //Linq dot notation
            Console.WriteLine("The sorted list of products: (dot notation)");
            ObjectDumper.Write(products.OrderBy(p => p.ProductName));

            Console.WriteLine("The reversed sorted list of products: (dot notation)");
            ObjectDumper.Write(products.OrderByDescending(p => p.ProductName));
        }

        [Category("Ordering Operators")]
        [Description("This sample uses an OrderBy clause with a custom comparer to " +
                     "do a case-insensitive sort of the words in an array.")]
        public void Linq31()
        {
            string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            var sortedWords = words.OrderBy(w => w, new CaseInsensitiveComparer());

            Console.WriteLine("The sorted list of words:");
            ObjectDumper.Write(sortedWords);
        }

        [Category("Ordering Operators")]
        [Description("This sample uses orderby and descending to sort a list of " +
                     "doubles from highest to lowest.")]
        public void Linq32()
        {
            double[] doubles = { 1.7, 2.3, 1.9, 4.1, 2.9 };

            var sortedDoubles = from d in doubles
                                orderby d descending
                                select d;

            Console.WriteLine("The doubles from highest to lowest:");
            foreach(var d in sortedDoubles)
            {
                Console.WriteLine(d);
            }

            //Linq dot notation
            Console.WriteLine("The doubles from highest to lowest: (dot notation)");
            doubles.OrderByDescending(d => d).ToList().ForEach(d => Console.WriteLine(d));
        }

        [Category("Ordering Operators")]
        [Description("This sample uses orderby to sort a list of products by units in stock " +
                     "from highest to lowest.")]
        public void Linq33()
        {
            Product product = new Product();
            List<Product> products = product.GetProductList();

            var sortedProducts = from p in products
                                 orderby p.UnitsInStock descending
                                 select p;

            Console.WriteLine("The sorted list of products by units in stock descending:");
            ObjectDumper.Write(sortedProducts);

            //Linq dot notation
            Console.WriteLine("The sorted list of products by units in stock descending: (dot notation)");
            ObjectDumper.Write(products.OrderByDescending(p => p.UnitsInStock));
        }

        [Category("Ordering Operators")]
        [Description("This sample uses method syntax to call OrderByDescending because it " +
                    " enables you to use a custom comparer.")]
        public void Linq34()
        {
            string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            var sortedWords = words.OrderByDescending(w => w, new CaseInsensitiveComparer());

            Console.WriteLine("The descending sorted list of words:");
            ObjectDumper.Write(sortedWords);
        }

        [Category("Ordering Operators")]
        [Description("This sample uses a compound orderby to sort a list of digits, " +
                     "first by length of their name, and then alphabetically by the name itself.")]
        public void Linq35()
        {
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var sortedDigits = from dig in digits
                               orderby digits.Length, dig
                               select dig;

            Console.WriteLine("Sorted digits by length and name: ");
            foreach(var d in sortedDigits)
            {
                Console.WriteLine(d);
            }

            //Linq dot notation
            Console.WriteLine("Sorted digits by length and name: (dot notation)");
            //This forms needs an IComparer method because new {} is an anonymous type
            //digits.OrderBy(d => new { d.Length, d }).ToList().ForEach(d => Console.WriteLine(d));
            digits.GroupBy(d => new { d.Length, d }).OrderBy(g => g.Key.Length)
                    .ThenBy(g => g.Key.d, new CaseInsensitiveComparer()).ToList().ForEach(g => Console.WriteLine(g.Key.d));
            //digits.OrderBy(d => d.Length).ThenBy(d => d, new CaseInsensitiveComparer()).ToList().ForEach(d => Console.WriteLine(d));
        }

        [Category("Ordering Operators")]
        [Description("The first query in this sample uses method syntax to call OrderBy and ThenBy with a custom comparer to " +
                     "sort first by word length and then by a case-insensitive sort of the words in an array. " +
                     "The second two queries show another way to perform the same task.")]
        public void Linq36()
        {
            string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            var sortedWords = words.OrderBy(a => a.Length).ThenBy(a => a, new CaseInsensitiveComparer());

            var sortedWords2 = from word in words
                               orderby word.Length
                               select word;

            ObjectDumper.Write(sortedWords);
            ObjectDumper.Write(sortedWords2.ThenBy(a => a, new CaseInsensitiveComparer()));
        }

        [Category("Ordering Operators")]
        [Description("This sample uses a compound orderby to sort a list of products, " +
                     "first by category, and then by unit price, from highest to lowest.")]
        public void Linq37()
        {
            Product product = new Product();
            List<Product> products = product.GetProductList();

            var sortedProducts = from prod in products
                                 orderby prod.Category, prod.UnitPrice descending
                                 select prod;

            Console.WriteLine("Sorted products by category and unit price descending:");
            ObjectDumper.Write(sortedProducts);

            Console.WriteLine("Sorted products by category and unit price descending: (dot notation)");          
            ObjectDumper.Write( products.OrderByDescending(p => p.Category).ThenByDescending(p => p.UnitPrice));
        }

        [Category("Ordering Operators")]
        [Description("This sample uses an OrderBy and a ThenBy clause with a custom comparer to " +
                     "sort first by word length and then by a case-insensitive descending sort " +
                     "of the words in an array.")]
        public void Linq38()
        {
            string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            var sortedWords = words.OrderBy(a => a.Length).ThenByDescending(a => a, new CaseInsensitiveComparer());

            Console.WriteLine("Sorted words by length and by a case-insensitive descending sort:");
            ObjectDumper.Write(sortedWords);
        }

        [Category("Ordering Operators")]
        [Description("This sample uses Reverse to create a list of all digits in the array whose " +
                     "second letter is 'i' that is reversed from the order in the original array.")]
        public void Linq39()
        {
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var reversedIDigits = (from dig in digits
                                   where dig[1] == 'i'
                                   select dig).Reverse();

            Console.WriteLine("A backwards list of the digits with a second character of 'i':");
            foreach (var d in reversedIDigits)
            {
                Console.WriteLine(d);
            }

            Console.WriteLine("A backwards list of the digits with a second character of 'i': (dot notation)");
            digits.Where(d => d[1] == 'i').Reverse().ToList().ForEach(d => Console.WriteLine(d));
        }
    }
}
