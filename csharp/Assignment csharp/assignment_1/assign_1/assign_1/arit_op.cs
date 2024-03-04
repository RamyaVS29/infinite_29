using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetday_4
{
    class arit_op
    {
        static void Main(string[] args)
        {

            int Num1, Num2, result;
            char option;
            Console.Write("Enter the First Number : ");
            Num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Second Number : ");
            Num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Main Menu");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.Write("Enter the Operation you want to perform : ");
            option = Convert.ToChar(Console.ReadLine());
            switch (option)
            {
                case '1':
                    result = Num1 + Num2;
                    Console.WriteLine("The result of Addition is : {0}", result);
                    break;
                case '2':
                    result = Num1 - Num2;
                    Console.WriteLine("The result of Subtraction is : {0}", result);
                    break;
                case '3':
                    result = Num1 * Num2;
                    Console.WriteLine("The result of Multiplication is : {0}", result);
                    break;
                case '4':
                    result = Num1 / Num2;
                    Console.WriteLine("The result of Division is : {0}", result);
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }
            Console.ReadLine();
            Console.WriteLine("enter the first number:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double sum = num1 + num2;
            double diffrence = num1 - num2;
            double product = num1 * num2;
            double quotient = num1 / num2;
            Console.WriteLine($"sum: {sum}");
            Console.WriteLine($"diffrence: {diffrence}");
            Console.WriteLine($"product: {product}");
            Console.WriteLine($"quotient: {quotient}");
            Console.ReadLine();
        }
    }
}

