using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assesment_3
{
    public delegate int MathOper(int a, int b);

    class math
    {
        static void Main()
        {
           
            MathOper addition = (a, b) => a + b;
            MathOper subtraction = (a, b) => a - b;
            MathOper multiplication = (a, b) => a * b;

            
            Console.WriteLine("Choose the operation to be performed :"); // get inputs from useer
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.Write("Enter the operation number (1/2/3): ");
            int operationChoice = int.Parse(Console.ReadLine());

            
            Console.Write("Enter the first integer: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second integer: ");
            int num2 = int.Parse(Console.ReadLine());

           
            int result = 0;
            string operationchose= "";
            switch (operationChoice)
            {
                case 1:
                    result = addition(num1, num2);
                    operationchose = "Addition";
                    break;
                case 2:
                    result = subtraction(num1, num2);
                    operationchose = "Subtraction";
                    break;
                case 3:
                    result = multiplication(num1, num2);
                    operationchose = "Multiplication";
                    break;
                default:
                    Console.WriteLine("Invalid operation selected try again...");
                    return;
            }

            Console.WriteLine($"{operationchose}: {num1} {GetOperationSymbol(operationChoice)} {num2} = {result}");
            Console.ReadLine();
        }

        // Helper method to get the symbol for the selected operation
        static string GetOperationSymbol(int operationChoice)
        {
            switch (operationChoice)
            {
                case 1:
                    return "+";
                case 2:
                    return "-";
                case 3:
                    return "*";
                default:
                    return "";
            }
        }
    }
}
  