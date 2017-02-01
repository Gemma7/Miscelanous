using MiscellaneousOperators.Classes;
using System;

namespace MiscellaneousOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            LinqSamples samples = new LinqSamples();

            //Comment or uncomment the method calls below to run or not
                        
            samples.Linq94(); // This sample  uses Concat  to create one  sequence that  contains each array's 
            // values, one after the other

            Console.WriteLine();
            samples.Linq95(); // This sample uses Concat to create one sequence that contains the names of all 
            // customers and products, including any duplicates

            Console.WriteLine();
            samples.Linq96(); // This sample uses SequenceEquals to see if two sequences match on all elements 
            // in the same order

            Console.WriteLine();
            samples.Linq97(); // This sample  uses SequenceEqual to see if two sequences match on all elements 
            // in the same order

            Console.ReadKey();
        }
    }
}
