using RestricitionOperators.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestricitionOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            LinqSamples samples = new LinqSamples();

            samples.Linq1();

            Console.WriteLine();

            samples.Linq2();

            Console.WriteLine();

            samples.Linq3();

            Console.WriteLine();

            samples.Linq4();

            Console.WriteLine();

            samples.Linq5();

            Console.ReadKey();
        }
    }
}
