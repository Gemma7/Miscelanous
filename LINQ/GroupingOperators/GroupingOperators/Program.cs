using GroupingOperators.Classes;
using System;

namespace GroupingOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            LinqSamples samples = new LinqSamples();

            // Comment or uncomment the method calls below to run or not
            samples.DataSetLinq40();    // This sample uses group by to partition a list of numbers by their remainder when divided by 5.

            Console.WriteLine();
            samples.DataSetLinq41();    // This sample uses group by to partition a list of words by their first letter.
            
            Console.WriteLine();
            samples.DataSetLinq42();    // This sample uses group by to partition a list of products by category.

            Console.WriteLine();
            samples.DataSetLinq43();    // This sample uses group by to partition a list of each customer's orders, first by year, and then by month.

            Console.WriteLine();
            samples.DataSetLinq44();    // This sample uses GroupBy to partition trimmed elements of an array using a custom comparer that matches words that are anagrams of each other.

            Console.WriteLine();
            samples.DataSetLinq45();    // This sample uses GroupBy to partition trimmed elements of an array using a custom comparer that matches words that are anagrams of each other, and then converts the results to uppercase.

            Console.ReadKey();
        }
    }
}
