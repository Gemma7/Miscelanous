using CustomSequenceOperators.Classes;
using System;

namespace CustomSequenceOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            LinqSamples samples = new LinqSamples();

            // Comment or uncomment the method calls below to run or not
            samples.DataSetLinq98();    // This sample uses a user-created sequence operator, Combine, to calculate the dot product of two vectors.

            Console.ReadKey();
        }
    }
}
