using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_5
{
    public interface IStudent
    {
        int StudentId { get; set; }
        string Name { get; set; }

        void Showinfo();
    }

    public class Dayscholar : IStudent
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public void Showinfo()
        {
            Console.WriteLine($"Student ID: {StudentId}, Name: {Name}, Type: Day Scholar, Address: {Address}");
        }
    }

   
    public class Resident : IStudent
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string HostelName { get; set; }

        public void Showinfo()
        {
            Console.WriteLine($"Student ID: {StudentId}, Name: {Name}, Type: Resident, Hostel: {HostelName}");
        }
    }

    class istud
    {
        static void Main()
        {

            Console.WriteLine("Enter info for Day Scholar:");
            Console.Write("Student ID: ");
            int dayScholarId = int.Parse(Console.ReadLine());

            Console.Write("Student Name: ");
            string dayScholarName = Console.ReadLine();

            Console.Write("Address: ");
            string dayScholarAddress = Console.ReadLine();


            Dayscholar dayScholar = new Dayscholar //instance creation 
            {
                StudentId = dayScholarId,
                Name = dayScholarName,
                Address = dayScholarAddress
            };


            Console.WriteLine("\nEnter info for Resident:");
            Console.Write("Student ID: ");
            int residentId = int.Parse(Console.ReadLine());

            Console.Write("Student Name: ");
            string residentName = Console.ReadLine();

            Console.Write("Hostel Name: ");
            string hostelName = Console.ReadLine();


            Resident resident = new Resident //instance creation
            {
                StudentId = residentId,
                Name = residentName,
                HostelName = hostelName
            };

            Console.WriteLine("\nStudent info:");
            dayScholar.Showinfo();

            Console.WriteLine();
            resident.Showinfo();
            Console.ReadLine();
        }
    }
}
