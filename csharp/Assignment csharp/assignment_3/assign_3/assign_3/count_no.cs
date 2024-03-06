using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign_3
{
    class count_no
    {
        static void Main()
        {
            
            Console.Write("Enter a string: ");
            string inputStr = Console.ReadLine();

           
            Console.Write("Enter the letter to be counted: ");
            char letterToCount = Console.ReadLine().ToUpper()[0]; // converts to upper case and takes letter present at zero th pos

            
            int count = CountOccurrences(inputStr, letterToCount);
            Console.WriteLine($"The letter '{letterToCount}' appears {count}  times in the given string  .");
            Console.WriteLine($"check with next letter... ");
            Console.ReadLine();
        }

        static int CountOccurrences(string inputStr, char letterToCount)
        {
            //operation
            int count = 0;
            foreach (char c in inputStr.ToUpper())
            {
                if (c == letterToCount)
                {
                    count++;
                }
            }
            return count;
        }
        
    }
}


