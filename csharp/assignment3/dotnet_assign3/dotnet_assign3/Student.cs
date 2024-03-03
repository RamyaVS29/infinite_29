using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_assign3
{
    class Student
    {
       //private Data members by default
        int rollNo;
        string name;
        string className;
        int semester;
        string branch;
        int[] marks = new int[5];

        // Constructor
        public Student(int rollNo, string name, string className, int semester, string branch)
        {
            this.rollNo = rollNo;
            this.name = name;
            this.className = className;
            this.semester = semester;
            this.branch = branch;
        }

        // Method to input marks for 5 subjects
        public void GetMarks()
        {
            Console.WriteLine("Enter marks for 5 subjects:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Subject {i + 1}: ");
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        // Method to display result based on average marks
        public void DisplayResult()
        {
            double average = CalculateAverage();

            Console.WriteLine($"Average Marks: {average}");

            if (marks.Any(m => m < 35) || average < 50)
            {
                Console.WriteLine("Result: Failed");
            }
            else
            {
                Console.WriteLine("Result: Passed");
            }
        }

        // Method to calculate the average of marks
        private double CalculateAverage()
        {
            double sum = 0;
            foreach (int mark in marks)
            {
                sum += mark;
            }

            return sum / marks.Length;
        }

        // Method to display all student data
        public void DisplayData()
        {
            Console.WriteLine($"Roll Number: {rollNo}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Class: {className}");
            Console.WriteLine($"Semester: {semester}");
            Console.WriteLine($"Branch: {branch}");
            Console.WriteLine("Marks:");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Subject {i + 1}: {marks[i]}");
            }
        }

        // Example usage
        static void Main()
        {
            // Create an instance of the Student class
            Student student1 = new Student(341, "ramya", "IT", 1, "Electronicsn computer Science");

            // Input marks for the student
            student1.GetMarks();

            // Display student data
            student1.DisplayData();

            // Display result based on average marks
            student1.DisplayResult();
            Console.ReadLine();
        }
    }
}


  