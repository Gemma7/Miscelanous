using Quantifiers.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quantifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            LinqSamples samples = new LinqSamples();

            //Comment or uncomment the method calls below to run or not

            samples.Linq67(); // This sample  uses Any to determine if any of the words in the array contain the 
            // substring 'ei'

            Console.WriteLine();
            samples.Linq69(); // This sample uses Any to return a grouped a list of products only for categories 
            // that have at least one product that is out of stock

            Console.WriteLine();
            samples.Linq70(); // This sample uses All to determine whether an array contains only odd numbers

            Console.WriteLine();
            samples.Linq72(); // This sample uses All to return a grouped a list of products only for categories 
            // that have all of their products in stock

            Console.ReadKey();
        }
    }
}
