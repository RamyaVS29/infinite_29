using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign_1
{
    class trip_sum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the first number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the second number:");
            int num2 = int.Parse(Console.ReadLine());
            int result = computesum(num1, num2);
            Console.WriteLine("result:" + result);
            Console.ReadLine();
        }



        static int computesum(int a, int b)
        {
            int sum = a + b;
            if (a == b)
            {
                return 3 * sum;

            }
            return sum;
        }

    }
}

