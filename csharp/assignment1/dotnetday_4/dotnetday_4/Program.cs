using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetday_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("enter the first integer:");
            //int num1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("enter the second integer:");
            //int num2 = int.Parse(Console.ReadLine());

            //if(num1 == num2)
            //{
            //    Console.WriteLine("the two integers are equal");

            //}

            //else
            //{
            //    Console.WriteLine("the two integers are not equal");
            //}
            //Console.ReadKey();

         // check positive or negative 

            //Console.WriteLine("enter a number:");
            //int number = int.Parse(Console.ReadLine());
            //if(number>0)
            //{
            //    Console.WriteLine("the number is positive");

            //}
            //else if (number<0)
            //{
            //    Console.WriteLine("the number is negative ");

            //}
            //else
            //{
            //    Console.WriteLine("the number is zero");

            //}
            //Console.ReadLine();

         //performing arithematic operations 
            //int Num1, Num2, result;
            //char option;
            //Console.Write("Enter the First Number : ");
            //Num1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter the Second Number : ");
            //Num2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Main Menu");
            //Console.WriteLine("1. Addition");
            //Console.WriteLine("2. Subtraction");
            //Console.WriteLine("3. Multiplication");
            //Console.WriteLine("4. Division");
            //Console.Write("Enter the Operation you want to perform : ");
            //option = Convert.ToChar(Console.ReadLine());
            //switch (option)
            //{
            //    case '1':
            //        result = Num1 + Num2;
            //        Console.WriteLine("The result of Addition is : {0}", result);
            //        break;
            //    case '2':
            //        result = Num1 - Num2;
            //        Console.WriteLine("The result of Subtraction is : {0}", result);
            //        break;
            //    case '3':
            //        result = Num1 * Num2;
            //        Console.WriteLine("The result of Multiplication is : {0}", result);
            //        break;
            //    case '4':
            //        result = Num1 / Num2;
            //        Console.WriteLine("The result of Division is : {0}", result);
            //        break;
            //    default:
            //        Console.WriteLine("Invalid Option");
            //        break;
            //}
            //Console.ReadLine();
            //Console.WriteLine("enter the first number:");
            //double num1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("enter the second number:");
            //double num2 = Convert.ToDouble(Console.ReadLine());

            //double sum = num1 + num2;
            //double diffrence = num1 - num2;
            //double product = num1 * num2;
            //double quotient = num1 / num2;
            //Console.WriteLine($"sum: {sum}");
            //Console.WriteLine($"diffrence: {diffrence}");
            //Console.WriteLine($"product: {product}");
            //Console.WriteLine($"quotient: {quotient}");
            //Console.ReadLine();
        // multiplication table 

            //Console.WriteLine("enter the first number:");
            //int number = int.Parse(Console.ReadLine());
            //Console.WriteLine($"multipication table for {number}:");
            //for (int i = 1; i <= 10; i++)
            //{
            //    int result = number * i;
            //    Console.WriteLine($"the {number} * {i} = {result}");

            //}
            //Console.ReadLine();
            // to compute sum of two numbers if they are equal compute triple
            //    Console.WriteLine("enter the first number:");
            //    int num1 = int.Parse(Console.ReadLine());
            //    Console.WriteLine("enter the second number:");
            //    int num2 = int.Parse(Console.ReadLine());
            //    int result = computesum(num1, num2);
            //    Console.WriteLine("result:" + result);
            //    Console.ReadLine();
            //}



            //static int computesum(int a , int b)
            //{
            //    int sum = a + b;
            //    if (a == b)
            //    {
            //        return 3 * sum;

            //    }
            //    return sum;
            //    }
            //            Console.WriteLine("Enter a day number (1-7):");
            //            int dayNumber = int.Parse(Console.ReadLine());

            //            string dayName = GetDayName(dayNumber);

            //            Console.WriteLine("Day of the week: " + dayName);
            //            Console.ReadLine();

            //        }

            //        static string GetDayName(int dayNumber)
            //        {
            //            switch (dayNumber)
            //            {
            //                case 1:
            //                    return "Monday";
            //                case 2:
            //                    return "Tuesday";
            //                case 3:
            //                    return "Wednesday";
            //                case 4:
            //                    return "Thursday";
            //                case 5:
            //                    return "Friday";
            //                case 6:
            //                    return "Saturday";
            //                case 7:
            //                    return "Sunday";
            //                default:
            //                    return "Invalid day number";
            //            }
            //        }
            //    }
            //}
            // array program

            //            Console.WriteLine("Enter the size of the array:");
            //            int size = int.Parse(Console.ReadLine());

            //            // Create an array with the specified size
            //            int[] numbers = new int[size];

            //            // Input values into the array
            //            Console.WriteLine($"Enter {size} integer values:");

            //            for (int i = 0; i < size; i++)
            //            {
            //                Console.Write($"Element {i + 1}: ");
            //                numbers[i] = int.Parse(Console.ReadLine());
            //            }

            //            // Calculate and print the average value
            //            double average = CalculateAverage(numbers);
            //            Console.WriteLine($"Average value: {average}");

            //            // Calculate and print the minimum value
            //            int minimum = FindMinimum(numbers);
            //            Console.WriteLine($"Minimum value: {minimum}");

            //            // Calculate and print the maximum value
            //            int maximum = FindMaximum(numbers);
            //            Console.WriteLine($"Maximum value: {maximum}");
            //            Console.ReadLine();

            //        }

            //        static double CalculateAverage(int[] array)
            //        {
            //            int sum = 0;

            //            foreach (int num in array)
            //            {
            //                sum += num;
            //            }

            //            return (double)sum / array.Length;
            //        }

            //        static int FindMinimum(int[] array)
            //        {
            //            int min = array[0];

            //            foreach (int num in array)
            //            {
            //                if (num < min)
            //                {
            //                    min = num;
            //                }
            //            }

            //            return min;
            //        }

            //        static int FindMaximum(int[] array)
            //        {
            //            int max = array[0];

            //            foreach (int num in array)
            //            {
            //                if (num > max)
            //                {
            //                    max = num;
            //                }
            //            }
            //            return max;
            //        }
            //    }
            //}
            //accepting ten marks 
            //            int[] marks = new int[10];


            //            Console.WriteLine("Enter 10 marks:");
            //            for (int i = 0; i < 10; i++)
            //            {
            //                Console.Write($"Enter mark {i + 1}: ");
            //                marks[i] = Convert.ToInt32(Console.ReadLine());
            //            }

            //            // Displaying total
            //            int total = marks.Sum();
            //            Console.WriteLine($"Total: {total}");

            //            // Displaying average
            //            double average = marks.Average();
            //            Console.WriteLine($"Average: {average}");

            //            // Displaying maximum marks
            //            int maxMarks = marks.Max();
            //            Console.WriteLine($"Maximum Marks: {maxMarks}");

            //            // Displaying minimum marks
            //            int minMarks = marks.Min();
            //            Console.WriteLine($"Minimum Marks: {minMarks}");

            //            // Displaying marks in ascending order
            //            Console.WriteLine("Marks in Ascending Order:");
            //            int[] ascendingOrder = marks.OrderBy(x => x).ToArray();
            //            Console.WriteLine(string.Join(", ", ascendingOrder));

            //            // Displaying marks in descending order
            //            Console.WriteLine("Marks in Descending Order:");
            //            int[] descendingOrder = marks.OrderByDescending(x => x).ToArray();
            //            Console.WriteLine(string.Join(", ", descendingOrder));
            //            Console.ReadLine();

            //        }
            //    }
            //}
            // string copy
            //            int[] sourceArray = { 1, 2, 3, 4, 5 };
            //            int[] destinationArray = new int[sourceArray.Length];


            //            for (int i = 0; i < sourceArray.Length; i++)
            //            {
            //                destinationArray[i] = sourceArray[i];
            //            }


            //            Console.WriteLine("Elements in the destination array:");
            //            foreach (int element in destinationArray)
            //            {
            //                Console.Write($"{element} ");
            //            }
            //            Console.ReadLine();

            //        }
            //    }
            //}
            // string length finder
            //        Console.Write("Enter a word: ");
            //        string rinput = Console.ReadLine();

            //        int wordLength = rinput.Length;

            //        Console.WriteLine($"Length of the word '{rinput}' is: {wordLength}");
            //        Console.ReadLine();

            //}
            //}
            //}
            // reverse of a string 
            //              Console.Write("Enter a String : ");
            //              string originalString = Console.ReadLine();
            //              string reverseString = string.Empty;
            //              for (int i = originalString.Length - 1; i >= 0; i--)
            //              {
            //                    reverseString += originalString[i];
            //              }
            //              Console.Write($"Reverse String is : {reverseString} ");
            //              Console.ReadLine();
            //        }      
            //    }
            //}

            // comparing two words 
            Console.Write("Enter the first word: ");
            string firstWord = Console.ReadLine();

            Console.Write("Enter the second word: ");
            string secondWord = Console.ReadLine();

            bool areEqual = String.Equals(firstWord, secondWord, StringComparison.OrdinalIgnoreCase);

            if (areEqual)
            {
                Console.WriteLine("The words are the same.");
            }
            else
            {
                Console.WriteLine("The words are different.");
            }
            Console.ReadLine();
        }
    }
}














