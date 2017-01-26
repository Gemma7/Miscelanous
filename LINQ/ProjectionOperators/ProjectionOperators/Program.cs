using ProjectionOperators.Classes;
using System;

namespace ProjectionOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            LinqSamples samples = new LinqSamples();

            samples.DataSetLinq6();// This sample uses select to produce a sequence of ints one higher than those in an existing array of ints.

            Console.WriteLine();
            samples.DataSetLinq7();     // This sample uses select to return a sequence of just the names of a list of products.

            Console.WriteLine();
            samples.DataSetLinq8();     // This sample uses select to produce a sequence of strings representing the text version of a sequence of ints.
            Console.WriteLine();
            samples.DataSetLinq9();     // This sample uses select to produce a sequence of the uppercase and lowercase versions of each word in the original array.
            Console.WriteLine();
            samples.DataSetLinq10();    // This sample uses select to produce a sequence containing text representations of digits and whether their length is even or odd.
            Console.WriteLine();
            samples.DataSetLinq11();    // This sample uses select to produce a sequence containing some properties of Products...
            Console.WriteLine();
            samples.DataSetLinq12();    // This sample uses an indexed Select clause to determine if the value of ints in an array match their position in the array.
            samples.DataSetLinq13();    // This sample combines select and where to make a simple query that returns the text form of each digit less than 5.
            Console.WriteLine();
            samples.DataSetLinq14();    // This sample uses a compound from clause to make a query that returns all pairs of numbers...
            Console.WriteLine();
            samples.DataSetLinq15();    // This sample uses a compound from clause to select all orders where the order total is less than 500.00.
            Console.WriteLine();
            samples.DataSetLinq16();    // This sample uses a compound from clause to select all orders where the order was made in 1998 or later.
            Console.WriteLine();
            samples.DataSetLinq17();    // This sample uses a compound from clause to select all orders where order total is greater than 2000.00...
            Console.WriteLine();
            samples.DataSetLinq18();    // This sample uses multiple from clauses so that filtering on customers can be done before selecting their orders...
            Console.WriteLine();
            samples.DataSetLinq19();    // This sample uses an indexed SelectMany clause to select all orders...

            Console.ReadKey(); 
        }
    }
}
