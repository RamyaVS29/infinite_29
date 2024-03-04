using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign_1
{
    class daynum
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a day number (1-7):");
            int dayNumber = int.Parse(Console.ReadLine());

            string dayName = GetDayName(dayNumber);

            Console.WriteLine("Day of the week: " + dayName);
            Console.ReadLine();

        }

        static string GetDayName(int dayNumber)
        {
            switch (dayNumber)
            {
                case 1:
                    return "Monday";
                case 2:
                    return "Tuesday";
                case 3:
                    return "Wednesday";
                case 4:
                    return "Thursday";
                case 5:
                    return "Friday";
                case 6:
                    return "Saturday";
                case 7:
                    return "Sunday";
                default:
                    return "Invalid day number";
            }
        }
    }
}


