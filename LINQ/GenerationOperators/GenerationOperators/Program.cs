using GenerationOperators.Classes;
using System;

namespace GenerationOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            LinqSamples samples = new LinqSamples();

            //Comment or uncomment the method calls below to run or not

            samples.Linq65(); // This sample uses Range to generate a sequence of numbers from 100 to 149 
            // that is used to find which numbers in that range are odd and even

            Console.WriteLine();
            samples.Linq66(); // This sample uses Repeat to generate a sequence that contains the number 7 
            // ten times

            Console.ReadKey();
        }
    }
}
