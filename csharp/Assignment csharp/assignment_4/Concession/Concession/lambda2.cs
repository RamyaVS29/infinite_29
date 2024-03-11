using System;
using System.Collections.Generic;
using System.Linq;

class lambda2

{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of words separated by commas:");
        string input = Console.ReadLine();
        string[] words = input.Split(',');

        List<string> filteredWords = new List<string>();
        foreach (string word in words)
        {
            if (word.StartsWith("a", StringComparison.OrdinalIgnoreCase) &&
                word.EndsWith("m", StringComparison.OrdinalIgnoreCase))
            {
                filteredWords.Add(word);
            }
        }

        Console.WriteLine("Words starting with 'a' and ending with 'm':");
        foreach (string filteredWord in filteredWords)
        {
            Console.WriteLine(filteredWord);
            Console.ReadLine();
        }
    }
}
