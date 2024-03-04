using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign_1
{
    class array1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array:");
            int size = int.Parse(Console.ReadLine());

            // Create an array with the specified size
            int[] numbers = new int[size];

            // Input values into the array
            Console.WriteLine($"Enter {size} integer values:");

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Element {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            // Calculate and print the average value
            double average = CalculateAverage(numbers);
            Console.WriteLine($"Average value: {average}");

            // Calculate and print the minimum value
            int minimum = FindMinimum(numbers);
            Console.WriteLine($"Minimum value: {minimum}");

            // Calculate and print the maximum value
            int maximum = FindMaximum(numbers);
            Console.WriteLine($"Maximum value: {maximum}");
            Console.ReadLine();

        }

        static double CalculateAverage(int[] array)
        {
            int sum = 0;

            foreach (int num in array)
            {
                sum += num;
            }

            return (double)sum / array.Length;
        }

        static int FindMinimum(int[] array)
        {
            int min = array[0];

            foreach (int num in array)
            {
                if (num < min)
                {
                    min = num;
                }
            }

            return min;
        }

        static int FindMaximum(int[] array)
        {
            int max = array[0];

            foreach (int num in array)
            {
                if (num > max)
                {
                    max = num;
                }
            }
            return max;
        }
    }
}

