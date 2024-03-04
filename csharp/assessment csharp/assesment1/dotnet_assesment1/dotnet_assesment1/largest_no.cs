using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_assesment1
{
    class largest_no
    {
        static void Main()
        {

            Console.Write("Enter three numbers: ");

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

    

