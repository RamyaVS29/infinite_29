using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda2
{
    class lamprj2
    {
        static void Main(string[] args)
        {

             List<string> words = new List<string> { "amsterdam", "bloom", "orange", "antonym" };

             var result = words
             .Where(word => word.StartsWith("a", StringComparison.OrdinalIgnoreCase) && word.EndsWith("m", StringComparison.OrdinalIgnoreCase));

             foreach (var word in result)
             {
                    Console.WriteLine(word);
                    Console.ReadLine();
             }
        }
    }
}



