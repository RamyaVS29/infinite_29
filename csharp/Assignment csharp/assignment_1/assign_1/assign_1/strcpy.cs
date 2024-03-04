using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign_1
{
    class string_cpy
    {
        static void Main(string[] args)
        {
            int[] sourceArray = { 1, 2, 3, 4, 5 };
            int[] destinationArray = new int[sourceArray.Length];


            for (int i = 0; i < sourceArray.Length; i++)
            {
                destinationArray[i] = sourceArray[i];
            }


            Console.WriteLine("Elements in the destination array:");
            foreach (int element in destinationArray)
            {
                Console.Write($"{element} ");
            }
            Console.ReadLine();

        }
    }
}




