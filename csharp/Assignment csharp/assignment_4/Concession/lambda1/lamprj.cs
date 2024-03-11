using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda1
{
    class lamprj
    {
        static void Main(string[] args)
        {
        
            List<int> numbers = new List<int> { 29, 09, 21 };

            var result = numbers
            .Select(num => new { Number = num, Square = num * num })
            .Where(entry => entry.Square > 20);

             foreach (var entry in result)
             {
                Console.WriteLine($"{entry.Number} - {entry.Square}");
                Console.ReadLine();
             }

        }

    }

}


