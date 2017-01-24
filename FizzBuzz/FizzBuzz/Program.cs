using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class Program
    {
        private const int LIMIT = 100;

        static void Main(string[] args)
        {
            Program program = new Program();
            program.Init();            

            Console.ReadKey();
        }

        private void Init()
        {
            Console.WriteLine("FizzBuzz Program");

            StringBuilder result = new StringBuilder();
            SetSequence(result);

            Console.WriteLine(result);
            Console.ReadKey();
        }

        private void SetSequence(StringBuilder result)
        {
            for (int number = 1; number <= LIMIT; number++)
            {
                result.Append(GetNumberOrMultiple(number) + Environment.NewLine);
            }
        }

        private string GetNumberOrMultiple(int number)
        {
            if (IsMultiple(number, 3) && IsMultiple(number, 5))
            {
                return "FizzBuzz";
            }
            else if (IsMultiple(number, 3))
            {
                return "Fizz";
            }
            else if (IsMultiple(number, 5))
            {
                return "Buzz";
            }
            else
            {
                return number.ToString();
            }
        }

        private bool IsMultiple(int number, int baseNumber)
        {
            return number % baseNumber == 0;
        }
    }
}
