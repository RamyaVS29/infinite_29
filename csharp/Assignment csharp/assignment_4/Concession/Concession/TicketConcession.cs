using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concession
{
    public class TicketConcession
    {
        public const double TotalFare = 500.0;

        public void CalculateConcession(int age, string name)
        {
            if (age <= 5)
            {
                Console.WriteLine($"Little Champs - Free Ticket for {name}, Age: {age}");
            }
            else if (age > 60)
            {
                double discountedFare = TotalFare * 0.7;
                Console.WriteLine($"Senior Citizen - Fare: {discountedFare:C} for {name}, Age: {age}");
            }
            else
            {
                Console.WriteLine($"Ticket Booked - Fare: {TotalFare:C} for {name}, Age: {age}");
            }
            Console.ReadLine();
        }
    }
    public class TicketConcessionTest
    {
        public static void Main()
        {
            
        }
    }
}







