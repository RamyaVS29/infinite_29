﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign_1
{
    class posi_nega
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number:");
            int number = int.Parse(Console.ReadLine());
            if (number > 0)
            {
                Console.WriteLine("the number is positive");

            }
            else if (number < 0)
            {
                Console.WriteLine("the number is negative ");

            }
            else
            {
                Console.WriteLine("the number is zero");

            }
            Console.ReadLine();
        }
    }
}
