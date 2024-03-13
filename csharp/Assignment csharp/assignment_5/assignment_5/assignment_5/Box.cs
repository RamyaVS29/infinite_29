using System;
namespace assignemnt_5
{
    public class Box
    {
        public double Length { get; set; }
        public double Breadth { get; set; }

        public Box(double length, double breadth)
        {
            Length = length;
            Breadth = breadth;
        }

        public static Box AddBoxes(Box box1, Box box2)
        {
            double sumLength = box1.Length + box2.Length;
            double sumBreadth = box1.Breadth + box2.Breadth;

            return new Box(sumLength, sumBreadth);
        }

        public void Display()
        {
            Console.WriteLine($"Length: {Length}, Breadth: {Breadth}");
        }
    }

    public class BoxTest
    {
        static void Main()
        {
            //box1 input
            Console.WriteLine("Enter the dimensions for Box 1:");
            Console.Write("Length: ");
            double length1 = double.Parse(Console.ReadLine());

            Console.Write("Breadth: ");
            double breadth1 = double.Parse(Console.ReadLine());

           //box 2 input
            Console.WriteLine("\nEnter the dimensions for Box 2:");
            Console.Write("Length: ");
            double length2 = double.Parse(Console.ReadLine());

            Console.Write("Breadth: ");
            double breadth2 = double.Parse(Console.ReadLine());
            //box obj creation
            Box box1 = new Box(length1, breadth1);
            Box box2 = new Box(length2, breadth2);

          
            Box resultBox = Box.AddBoxes(box1, box2);

        
            Console.WriteLine("\nBox 1:");
            box1.Display();

            Console.WriteLine("\nBox 2:");
            box2.Display();

       
            Console.WriteLine("\nResult Box (Box 1 + Box 2):");
            resultBox.Display();

            
            Console.ReadLine();
        }
    }
}
