using JoinOperators.Classes;
using System;

namespace JoinOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            LinqSamples samples = new LinqSamples();

            //Comment or uncomment the method calls below to run or not

            samples.Linq102(); // This sample shows how to perform a simple inner equijoin of two sequences to produce 
            // a flat  result set  that consists  of each  element in suppliers that has a matching 
            // element in customers

            Console.WriteLine();
            samples.Linq103(); // A group join produces a hierarchical sequence.  The following query is an inner join 
            // that produces a sequence of objects, each of which has a key and an inner sequence of 
            // all matching elements

            Console.WriteLine();
            samples.Linq104(); // The group join operator is more general than join, as this slightly more verbose 
            // version of the cross join sample shows

            Console.WriteLine();
            samples.Linq105(); // For each customer in the table of customers, this query returns all the suppliers from 
            // that same country,  or else a string  indicating  that no suppliers  from that country 
            // were found

            Console.WriteLine();
            samples.Linq106(); // For each customer in the table of customers, this query returns all the suppliers from 
            // that same country,  or else a string  indicating  that no suppliers  from that country 
            // were found

            Console.WriteLine();
            samples.Linq107(); // For each supplier in the table of suppliers, this query returns all the customers from 
            // the same city and country,  or else a string  indicating  that no customers  from that 
            // city/country were found.  Note the use of anonymous  types to encapsulate the multiple 
            // key values

            Console.ReadKey();
        }
    }
}
