using System;
using Concession;

namespace Dll_client
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your age:");
            int age = int.Parse(Console.ReadLine());

            Concession.TicketConcession ticket = new Concession.TicketConcession();
            ticket.CalculateConcession(age, name);
            Console.ReadLine();
        }
    }
}
