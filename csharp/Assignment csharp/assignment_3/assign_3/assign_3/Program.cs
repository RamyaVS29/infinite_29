using System;

namespace assign_3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter your First Name: ");
            string fName = Console.ReadLine();

            Console.Write("Enter your Last Name: ");
            string lName = Console.ReadLine();

          
            Person p1 = new Person(fName, lName);

           
            Person.Display(p1.FName, p1.LName);
        }
    }

    class Person
    {
        public string FName { get; }
        public string LName { get; }

        public Person(string fName, string lName)
        {
            FName = fName;
            LName = lName;
        }

        public static void Display(string fName, string lName)
        {
            Console.WriteLine(fName.ToUpper());
            Console.WriteLine(lName.ToUpper());
            Console.ReadLine();
        }

    }
}


