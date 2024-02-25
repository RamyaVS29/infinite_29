using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world...! welcome to csharp ");
            Console.WriteLine("enter your first name:");
            string fname = Console.ReadLine();
            Console.WriteLine("enter your last name:");
            string lname = Console.ReadLine();
            Console.WriteLine("your first name is:" + fname + " and your last name is:" + lname);
            Console.WriteLine("your first name is  :{0}  and your last name is :{1}", fname, lname);
            Console.Read();

        }
    }
}
