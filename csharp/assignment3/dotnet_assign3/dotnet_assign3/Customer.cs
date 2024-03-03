﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_assign3
{
    class Customer
    {
        //data members of class Customer----- default private
        int CustomerId;
        string name;
        int age;
        string phone;
        string city;

        //constructor with same name as class and zero arg
        public Customer()
        {
            Console.WriteLine("Default Constructor: Object created with default values ");
        }

        // Constructor with name same as class (with  information)
        public Customer(int CustomerId, string name, int age, string phone, string city)
        {
            this.CustomerId = CustomerId;
            this.name = name;
            this.age = age;
            this.phone = phone;
            this.city = city;

            Console.WriteLine("Parameterized Constructor: Object created with provided values.");
        }

        // Method to display customer details
        public void DisplayCustomer()
        {
            Console.WriteLine($"Customer ID: {CustomerId}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Phone: {phone}");
            Console.WriteLine($"City: {city}");
        }

        // Destructor
        ~Customer()
        {
            Console.WriteLine("Destructor: Object destroyed ");
        }

        // Example usage
        static void Main()
        {
            // Creating instance of the Customer class using the default constructor
            Customer customer1 = new Customer();

            // Creating instance of the Customer class using the parameterized constructor
            Customer customer2 = new Customer(341, "ramya", 22, "0436291089", "Bengaluru");

            // Display customer details using the DisplayCustomer method
            customer2.DisplayCustomer();
            Console.ReadKey();

            //  Destructor will be called automatically when the program exits or when the objects go out of scope
        }
    }
}
