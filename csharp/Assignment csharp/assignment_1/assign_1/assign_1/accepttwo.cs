using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign_1
{
    class accept_two
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the first word: ");
            string firstWord = Console.ReadLine();

            Console.Write("Enter the second word: ");
            string secondWord = Console.ReadLine();

            bool areEqual = String.Equals(firstWord, secondWord, StringComparison.OrdinalIgnoreCase);

            if (areEqual)
            {
                Console.WriteLine("The words are the same.");
            }
            else
            {
                Console.WriteLine("The words are different.");
            }
            Console.ReadLine();
        }
    }
}



