using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_assesment1
{
    class exchange2char
    {
        static void Main()
        {

            Console.WriteLine("Enter a string:");
            string inputString = Console.ReadLine();

            string outputString = ExchangeFirstAndLastCharacters(inputString);

            Console.WriteLine("string after exchanging first and last characters is : {0}", outputString);
            Console.ReadLine();

        }


        static string ExchangeFirstAndLastCharacters(string input)
        {
            if (input.Length <= 1)
            {
                return input;
            }

            char[] charArr = input.ToCharArray();


            char temp = charArr[0];
            charArr[0] = charArr[input.Length - 1];
            charArr[input.Length - 1] = temp;

            return new string(charArr);
        }
    }
}

