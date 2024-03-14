using System;
using System.IO;
namespace assesment3
{
    class text
    {
        static void Main()
        {
            string filePath = "sample.txt";
            string textToAppend = "hi this is visual studio sample text file...";

            try
            {
             
                if (!File.Exists(filePath))
                {
                    
                    using (StreamWriter sw = File.CreateText(filePath))
                    {
                        sw.WriteLine(textToAppend);
                    }
                    Console.WriteLine("File created and text appended succesfully.");
                }
                else
                {
                    
                    using (StreamWriter sw = File.AppendText(filePath))
                    {
                        sw.WriteLine(textToAppend);
                    }
                    Console.WriteLine("Text appended to the existing file successfully.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("An error is found: " + e.Message);
            }
            Console.ReadLine();
        }
    }
}