using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign_1
{
    class mult_tab
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter the first number:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"multipication table for {number}:");
            for (int i = 1; i <= 10; i++)
            {
                int result = number * i;
                Console.WriteLine($"the {number} * {i} = {result}");

            }
            Console.ReadLine();
        }
    }
}

