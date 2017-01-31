using ElementOperators.Classes;
using System;

namespace ElementOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            LinqSamples samples = new LinqSamples();

            //Comment or uncomment the method calls below to run or not

            samples.Linq58(); // This sample uses First to return the first matching element as a Product, instead 
            // of as a sequence containing a Product

            Console.WriteLine();
            samples.Linq59(); // This sample uses First to find the first element in the array that starts with 'o'

            Console.WriteLine();
            samples.Linq61(); // This sample uses FirstOrDefault to try to return the first element of the sequence, 
            // unless there are  no elements,  in which case  the default  value for that type is 
            // returned.  FirstOrDefault is useful for creating outer joins

            Console.WriteLine();
            samples.Linq62(); // This sample uses FirstOrDefault to return the first product whose ProductID is 789 
            // as a single Product object, unless there is no match, in which case null is returned

            Console.WriteLine();
            samples.Linq64(); // This sample uses ElementAt to retrieve the second number greater than 5 from an array

            Console.ReadKey();
        }
    }
}
