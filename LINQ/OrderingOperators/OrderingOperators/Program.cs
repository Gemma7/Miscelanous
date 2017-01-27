using OrderingOperators.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            LinqSamples samples = new LinqSamples();

            //Comment or uncomment the method calls below to run or not

            samples.Linq28(); // This sample uses orderby to sort a list of words alphabetically

            Console.WriteLine();
            samples.Linq29(); // This sample uses orderby to sort a list of words by length

            Console.WriteLine();
            samples.Linq30(); // This sample uses orderby to sort a list of products by name. Use the \"descending\" 
            // keyword at the end of the clause to perform a reverse ordering

            Console.WriteLine();
            samples.Linq31(); // This sample uses an  OrderBy clause with a custom comparer to do a case-insensitive 
            // sort of the words in an array

            Console.WriteLine();
            samples.Linq32(); // This sample uses  orderby and  descending to sort a list of doubles from highest to 
            // lowest

            Console.WriteLine();
            samples.Linq33(); // This sample uses  orderby to sort a list of products by units in stock from highest 
            // to lowest

            Console.WriteLine();
            samples.Linq34(); // This sample uses method syntax to call OrderByDescending  because it enables you to 
            // use a custom comparer

            Console.WriteLine();
            samples.Linq35(); // This sample uses a compound  orderby to  sort a list of digits,  first by length of 
            // their name, and then alphabetically by the name itself

            Console.WriteLine();
            samples.Linq36(); // The first query in this sample uses method syntax to call OrderBy and ThenBy with a 
            // custom comparer to sort first by word length and then by a case-insensitive sort of 
            // the words in an array.  The second two queries show another way to perform the same 
            // task

            Console.WriteLine();
            samples.Linq37(); // This sample uses a compound  orderby to sort a list of products,  first by category, 
            // and then by unit price, from highest to lowest

            Console.WriteLine();
            samples.Linq38(); // This sample uses an OrderBy and a ThenBy clause with a custom comparer to sort first 
            // by word length and  then by a case-insensitive  descending  sort of  the words in an 
            // array

            Console.WriteLine();
            samples.Linq39(); // This sample uses Reverse to  create a list of  all digits in the  array whose second 
            // letter is 'i' that is reversed from the order in the original array

            Console.ReadKey();
        }
    }
}
