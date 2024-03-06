using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign_3
{
    class Scholarship
    {
        public double Merit(int marks, double fees)
        {
            double scholarshipAmount = 0;

            if (marks >= 70 && marks <= 80)
            {
                // Calculate scholarship amount as 20% of the fees
                scholarshipAmount = 0.2 * fees;
            }
            else if (marks > 80 && marks <= 90)
            {
                // Calculate scholarship amount as 30% of the fees
                scholarshipAmount = 0.3 * fees;
            }
            else if (marks > 90)
            {
                // Calculate scholarship amount as 50% of the fees
                scholarshipAmount = 0.5 * fees;
            }

            return scholarshipAmount;
        }
    }

    class Program
    {
        static void Main()
        {
            // Example usage
            scholarship = new scholarship();

            // Test cases
            double scholarship1 = scholarship.Merit(75, 1000);  // 20% of 1000 = 200
            double scholarship2 = scholarship.Merit(85, 1500);  // 30% of 1500 = 450
            double scholarship3 = scholarship.Merit(95, 2000);  // 50% of 2000 = 1000

            Console.WriteLine($"Scholarship 1: ${scholarship1}");
            Console.WriteLine($"Scholarship 2: ${scholarship2}");
            Console.WriteLine($"Scholarship 3: ${scholarship3}");
        }
    }
}
