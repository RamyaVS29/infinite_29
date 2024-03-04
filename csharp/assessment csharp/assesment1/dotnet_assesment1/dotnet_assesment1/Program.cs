using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_assesment2
{

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a string :");
            string inputString = Console.ReadLine();


            Console.WriteLine("Enter the pos to remove the chracter  ( from 0 to string length of  - 1):");
            int pos = int.Parse(Console.ReadLine());

            if (pos < 0 || pos >= inputString.Length)
            {
                Console.WriteLine("Invalid position  Position should be in the range 0 (string length - 1).");
            }
            else
            {
                string outputString = RemoveCharacterAtPosition(inputString, pos);
                Console.WriteLine("String after removing character at pos {0}: {1}", pos, outputString);
            }
            Console.ReadLine();

        }

        static string RemoveCharacterAtPosition(string input, int position)
        {
            return input.Remove(position, 1);
        }
    }
}
