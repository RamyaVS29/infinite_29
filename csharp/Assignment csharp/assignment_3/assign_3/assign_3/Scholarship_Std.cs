
using System;

class Scholarship
{
    public double CalculateScholarship(double marks, double fees)
    {
        try
        {
            if (marks >= 70 && marks <= 80)
            {
                
                return 0.2 * fees;
            }
            else if (marks > 80 && marks <= 90)
            {
             
                return 0.3 * fees;
            }
            else if (marks > 90)
            {
                
                return 0.5 * fees;
            }
            else
            {
                
                throw new ArgumentException(" try with other num . Marks should be between 70 and 100.");
            }
        }
        catch (ArgumentException ex)
        {
           
            Console.WriteLine($"Error: {ex.Message}");
            return 0.0; 
        }
    }
}

class Scholarship_Std
{
    static void Main()
    {
        try
        {
            Scholarship scholarship = new Scholarship(); //instance

            Console.Write("Enter marks: ");
            double marks = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter fees: ");
            double fees = Convert.ToDouble(Console.ReadLine());

            
            double scholarshipAmount = scholarship.CalculateScholarship(marks, fees);
            Console.WriteLine($"Scholarship Amount: {scholarshipAmount:C2}");
        }
        catch (FormatException ex)
        {
          
            Console.WriteLine($"Error: {ex.Message}");
        }

       
        Console.ReadLine();
    }
}
