using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        const int LIMIT = 100;
        const int THREE_BASE = 3;
        const int FIVE_BASE = 5;
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
            if (IsMultiple(number, THREE_BASE) && IsMultiple(number, FIVE_BASE))
            {
                return "FizzBuzz";
            }
            else if (IsMultiple(number, THREE_BASE))
            {
                return "Fizz";
            }
            else if (IsMultiple(number, FIVE_BASE))
            {
                return "Buzz";
            }
            else
            {
                return number.ToString();
            }
        }

        private static bool IsMultiple(int number, int baseNumber)
        {
            return number % baseNumber == 0;
        }
    }
}
