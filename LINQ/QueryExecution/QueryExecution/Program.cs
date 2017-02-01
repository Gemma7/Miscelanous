using QueryExecution.Classes;
using System;

namespace QueryExecution
{
    class Program
    {
        static void Main(string[] args)
        {
            LinqSamples samples = new LinqSamples();

            //Comment or uncomment the method calls below to run or not

            samples.Linq99();  // The following sample shows how query execution is deferred until the query is 
            // enumerated at a foreach statement

            Console.WriteLine();
            samples.Linq100(); // The following sample shows how queries can be executed immediately, and their 
            // results stored in memory, with methods such as ToList

            Console.WriteLine();
            samples.Linq101(); // The following sample shows how, because of deferred execution, queries can be 
            //used again after data changes and will then operate on the new data

            Console.ReadKey();
        }
    }
}
