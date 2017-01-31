using ConversionOperators.Classes;
using System;

namespace ConversionOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            LinqSamples samples = new LinqSamples();

            //Comment or uncomment the method calls below to run or not

            samples.Linq54(); // This sample uses ToArray to immediately evaluate a sequence into an array

            Console.WriteLine();
            samples.Linq55(); // This sample uses ToList to immediately evaluate a sequence into a List<T>

            Console.WriteLine();
            samples.Linq56(); // This sample uses ToDictionary to immediately  evaluate a  sequence  and a 
            // related key expression into a dictionary

            Console.WriteLine();
            samples.Linq57(); // This sample uses OfType to return only the elements of the array that are 
            // of type double

            Console.ReadKey();
        }
    }
}
