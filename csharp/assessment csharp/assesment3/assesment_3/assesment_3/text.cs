using System;
using System.IO;
//namespace assesment3
//{
//    class text
//    {
//        static void Main()
//        {
//            string filePath = "sample.txt";
//            string textToAppend = "hi this is visual studio sample text file...";

//            try
//            {

//                if (!File.Exists(filePath))
//                {

//                    using (StreamWriter sw = File.CreateText(filePath))
//                    {
//                        sw.WriteLine(textToAppend);
//                    }
//                    Console.WriteLine("File created and text appended succesfully.");
//                }
//                else
//                {

//                    using (StreamWriter sw = File.AppendText(filePath))
//                    {
//                        sw.WriteLine(textToAppend);
//                    }
//                    Console.WriteLine("Text appended to the existing file successfully.");
//                }
//            }
//            catch (Exception e)
//            {
//                Console.WriteLine("An error is found: " + e.Message);
//            }
//            Console.ReadLine();
//        }
//    }
//}
namespace prjconsoleApp { class Baseclass { int I; public Baseclass(int ii) { i = ii; Console.Write("Base"); } } class Derived : Baseclass { public Derived(int ii) : base(ii) { Console.Write("Derived"); } } class MyProgram { static void Main() { Derived d = new Derived(10); } } }
(1 Point)

The program will report an error in the statement base(ii).

The program will work correctly if we replace base(ii) with base.Baseclass(ii).

The program will output: Base Derived

The program will work correctly only if we implement zero-argument constructors in Baseclass as well as Derived class.
