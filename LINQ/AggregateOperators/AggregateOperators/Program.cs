using AggregateOperators.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregateOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            LinqSamples samples = new LinqSamples();

            //Comment or uncomment the method calls below to run or not

            samples.Linq73(); // This sample uses Count to get the number of unique prime factors of 300

            Console.WriteLine();
            samples.Linq74(); // This sample uses Count to get the number of odd ints in the array

            Console.WriteLine();
            samples.Linq76(); // This sample uses Count to return a list of customers and how many orders each has

            Console.WriteLine();
            samples.Linq77(); // This sample uses Count to return a list of categories and how many products each has

            Console.WriteLine();
            samples.Linq78(); // This sample uses Sum to add all the numbers in an array

            Console.WriteLine();
            samples.Linq79(); // This sample uses Sum to get the total number of characters of all words in the array

            Console.WriteLine();
            samples.Linq80(); // This sample uses Sum to get the total units in stock for each product category

            Console.WriteLine();
            samples.Linq81(); // This sample uses Min to get the lowest number in an array

            Console.WriteLine();
            samples.Linq82(); // This sample uses Min to get the length of the shortest word in an array

            Console.WriteLine();
            samples.Linq83(); // This sample uses Min to get the cheapest price among each category's products

            Console.WriteLine();
            samples.Linq84(); // This sample uses Min to get the products with the lowest price in each category

            Console.WriteLine();
            samples.Linq85(); // This sample uses Max to get the highest number in an array. Note that the method 
            // returns a single value

            Console.WriteLine();
            samples.Linq86(); // This sample uses Max to get the length of the longest word in an array

            Console.WriteLine();
            samples.Linq87(); // This sample uses Max to get the most expensive price among each category's products

            Console.WriteLine();
            samples.Linq88(); // This sample uses Max to get the products with the most expensive price in each category

            Console.WriteLine();
            samples.Linq89(); // This sample uses Average to get the average of all numbers in an array

            Console.WriteLine();
            samples.Linq90(); // This sample uses Average to get the average length of the words in the array

            Console.WriteLine();
            samples.Linq91(); // This sample uses Average to get the average price of each category's products

            Console.WriteLine();
            samples.Linq92(); // This sample uses Aggregate to create a running product on the array that calculates 
            // the total product of all elements

            Console.WriteLine();
            samples.Linq93(); // This sample uses Aggregate to create a running account balance that subtracts each 
            // withdrawal from the initial balance of 100, as long as the balance never drops below 0

            Console.ReadKey();
        }
    }
}
