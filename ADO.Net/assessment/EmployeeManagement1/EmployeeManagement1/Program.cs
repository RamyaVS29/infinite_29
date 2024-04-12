using System;
using System.Data.SqlClient;

namespace EmployeeManagementApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Server=ICS-LT-9S4R9K3;Database=Employeemanagement;Integrated Security=True;";

            // Loop to get employee details from user input and limiting it  to 5 insertions
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"\nEnter details for Employee {i + 1}:");

                Console.WriteLine("Enter Employee Name:");
                string empName = Console.ReadLine();

                Console.WriteLine("Enter Employee Salary:");
                decimal empsal = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Enter Employee Type (P/C):");
                char emptype = Convert.ToChar(Console.ReadLine());

                //calling stored procedure to addemployeee
                AddEmployee(connectionString, empName, empsal, emptype);
            }

          //displaying employee rows 
            DisplayAllEmployees(connectionString);
            Console.ReadLine();
        }


        static void AddEmployee(string connectionString, string empName, decimal empsal, char emptype)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("AddEmployee", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                   
                    command.Parameters.AddWithValue("@EmpName", empName); //t
                    command.Parameters.AddWithValue("@Empsal", empsal);
                    command.Parameters.AddWithValue("@Emptype", emptype);

                    
                    command.ExecuteNonQuery();
                }
            }
        }

        static void DisplayAllEmployees(string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

               
                string query = "SELECT * FROM Employee_Details"; //selecting all employee rows 

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader dreader = command.ExecuteReader())
                    {
                        Console.WriteLine("Employee Details:");
                        Console.WriteLine("Empno\tEmpName\tEmpsal\tEmptype");
                        while (dreader.Read())
                        {
                            Console.WriteLine($"{dreader["Empno"]}\t{dreader["EmpName"]}\t{dreader["Empsal"]}\t{dreader["Emptype"]}");
                        }
                    }
                }
            }
        }
    }
}

