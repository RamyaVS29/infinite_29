using System;


abstract class Student //abstract class 
{
    //members of class ----
    public string Name  { get; set; }
    public int StudentId { get; set; }
    public double Grade { get; set; }

    
    public Student(string name, int studentId, double grade)// constructor to initialize members of class 
    {
        Name = name;
        StudentId = studentId;
        Grade = grade;
    }
    public abstract bool IsPassed(double grade);
}


class   UG : Student // inheriting from class student
{
    
    public UG(string name, int studentId, double grade) : base(name, studentId, grade)
    {

    }

   
    public override bool IsPassed(double grade)
    {
        return grade > 70.0;
    }
}


class Graduate : Student // graduate subclass 
{
   
    public Graduate(string name, int studentId, double grade) : base(name, studentId, grade)
    {

    }

  
    public override bool IsPassed(double grade)
    {
        return grade > 80.0;
    }
}

// teststudent class 
class TestStudent
{
    static void Main()
    {
        // Create an Undergraduate student
      UG undergradStudent = new UG("ramya ", 1034, 77.0);
        Console.WriteLine("UndergraduateStudent:");
        Console.WriteLine($"Name: {undergradStudent.Name}");
        Console.WriteLine($"Student ID: {undergradStudent.StudentId}");
        Console.WriteLine($"Grade: {undergradStudent.Grade}");
        Console.WriteLine($"Passed: {undergradStudent.IsPassed(undergradStudent.Grade)}");
        Console.WriteLine();

        
        Graduate gradStudent = new Graduate("Hema ", 10345, 89.0);
        Console.WriteLine("Graduate Student:");
        Console.WriteLine($"Name: {gradStudent.Name}");
        Console.WriteLine($"Student ID: {gradStudent.StudentId}");
        Console.WriteLine($"Grade: {gradStudent.Grade}");
        Console.WriteLine($"Passed: {gradStudent.IsPassed(gradStudent.Grade)}");
        Console.ReadLine();
    }
}
