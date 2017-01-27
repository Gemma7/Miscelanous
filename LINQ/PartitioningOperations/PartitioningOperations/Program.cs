using PartitioningOperations.Classes;
using System;

namespace PartitioningOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            LinqSamples samples = new LinqSamples();

            samples.Linq20();// This sample uses Take to get only the first 3 elements of the array
            
            Console.WriteLine();
            samples.Linq21(); // This sample uses Take to get the first 3 orders from customers in Washington
            
            Console.WriteLine();
            samples.Linq22(); // This sample uses Skip to get all but the first four elements of the array
            
            Console.WriteLine();
            samples.Linq23(); // This sample uses Take to get all but the first 2 orders from customers in Washington
            
            Console.WriteLine();
            samples.Linq24(); // This sample uses TakeWhile to return elements starting from the beginning of the array 
            // until a number is read whose value is not less than 6
            
            Console.WriteLine();
            samples.Linq25(); // This sample uses TakeWhile to return elements starting from the beginning of the array 
            // until a number is hit that is less than its position in the array
            
            Console.WriteLine();
            samples.Linq26(); // This sample  uses SkipWhile to get the  elements of the array  starting from the first 
            // element divisible by 3
            
            Console.WriteLine();
            samples.Linq27(); // This sample  uses SkipWhile to get the  elements of the array  starting from the first 
            // element less than its position

            Console.ReadKey();
        }
    }
}
