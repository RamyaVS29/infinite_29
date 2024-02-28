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
            //Console.WriteLine("Enter a string :");
            //            string inputString = Console.ReadLine();


            //            Console.WriteLine("Enter the pos to remove the chracter  ( from 0 to string length of  - 1):");
            //            int pos = int.Parse(Console.ReadLine());

            //            if (pos < 0 || pos  >= inputString.Length)
            //            {
            //                Console.WriteLine("Invalid position  Position should be in the range 0 (string length - 1).");
            //            }
            //            else
            //            {
            //                string outputString = RemoveCharacterAtPosition(inputString, pos);
            //                Console.WriteLine("String after removing character at pos {0}: {1}", pos, outputString);
            //            }
            //            Console.ReadLine();

            //        }

            //        static string RemoveCharacterAtPosition(string input, int position)
            //        {
            //            return input.Remove(position, 1);
            //        }
            //    }
            //}
            // --------------exchanging two characters program---------------


            //            Console.WriteLine("Enter a string:");
            //            string inputString = Console.ReadLine();

            //            string outputString = ExchangeFirstAndLastCharacters(inputString);

            //            Console.WriteLine("string after exchanging first and last characters is : {0}", outputString);
            //            Console.ReadLine();

            //        }


            //        static string ExchangeFirstAndLastCharacters(string input)
            //        {
            //            if (input.Length <= 1)
            //            {
            //                return input; 
            //            }

            //            char[] charArr = input.ToCharArray();


            //            char temp = charArr[0];
            //            charArr[0] = charArr[input.Length - 1];
            //            charArr[input.Length - 1] = temp;

            //            return new string(charArr);
            //        }
            //    }
            //}

            // --------largest number program---------
            Console.WriteLine("Enter three numbers:");
            string  inputstring = Console.ReadLine();
             

            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Enter the third number : ");
            int num3 = int.Parse(Console.ReadLine());

            int largestamong3 = FindLargestNumber(num1, num2, num3);

            Console.WriteLine("The largest number among {0},{1} and {2} is: {3}", num1, num2, num3, largestamong3);
            Console.ReadLine();

        }

        static int FindLargestNumber(int a, int b, int c)
        {
            int large = a;

            if (b > large)
            {
                large = b;
            }

            if (c > large)
            {
                large = c;
            }

            return large;
        }
    }

}


