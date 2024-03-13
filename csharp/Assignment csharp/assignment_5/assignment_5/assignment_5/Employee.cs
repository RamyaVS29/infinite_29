using System;
namespace assignemnt_5
{

    public class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public float Salary { get; set; }


        public Employee(int empId, string empName, float salary)
        {
            EmpId = empId;
            EmpName = empName;
            Salary = salary;
        }

        public void Display()
        {
            Console.WriteLine($"Employee ID: {EmpId}, Name: {EmpName}, Salary: {Salary:C}");
        }
    }

    public class PartTimeEmployee : Employee
    {
        public float Wages { get; set; }


        public PartTimeEmployee(int empId, string empName, float salary, float wages)
            : base(empId, empName, salary)
        {
            Wages = wages;
        }

        
        public new void Display()
        {
            base.Display();
            Console.WriteLine($"Wages: {Wages:C}");
        }
    }

    class empprj
    {
        static void Main()
        {

            Console.WriteLine("Enter details for Employee:");
            Console.Write("Employee ID: ");
            int empId = int.Parse(Console.ReadLine());

            Console.Write("Employee Name: ");
            string empName = Console.ReadLine();

            Console.Write("Employee Salary: ");
            float salary = float.Parse(Console.ReadLine());

            Employee employee = new Employee(empId, empName, salary);


            Console.WriteLine("\nEnter details for Part-Time Employee:");
            Console.Write("Wages: ");
            float wages = float.Parse(Console.ReadLine());


            PartTimeEmployee partTimeEmployee = new PartTimeEmployee(empId, empName, salary, wages);

            Console.WriteLine("\nEmployee Details:");
            employee.Display();

            Console.WriteLine("\nPart-Time Employee Details:");
            partTimeEmployee.Display();

            Console.ReadLine();
        }
    }
}

