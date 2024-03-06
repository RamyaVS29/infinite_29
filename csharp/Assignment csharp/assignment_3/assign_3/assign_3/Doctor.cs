using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign_3
{
    using System;

    class Doctor
    {
        private int RegnNo;
        private string Name;
        private double FeesCharged;


        public void SetValues(int regnNo, string name, double feesCharged)
        {
            RegnNo = regnNo;
            Name = name;
            FeesCharged = feesCharged;
        }


        public void DisplayValues()
        {
            Console.WriteLine($"Registration Number: {RegnNo}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Fees Charged: {FeesCharged}");
        }
    }

    class doc
    {
        static void Main(string[] args)
        {
            Doctor doctor = new Doctor();


            doctor.SetValues(1034, "Dr.Ramya", 500);


            doctor.DisplayValues();

            Console.ReadLine();
        }
    }
}




