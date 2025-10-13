using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace activity_3
{
    class Program
    {

        static Dictionary<char, int> GetCharFrequency(string input)
        {
            Dictionary<char, int> frequency = new Dictionary<char, int>();

            foreach (char c in input)
            {
                if (char.IsWhiteSpace(c) || c == ',')
                    continue;
                if (frequency.ContainsKey(c))
                    frequency[c]++;
                else
                    frequency[c] = 1;
            }

            return frequency;
        }


        static void Main(string[] args)
        {
            Console.Write("Enter string: ");
            string input = Console.ReadLine();
            string[] words = input.Split(',');

            foreach (string word in words)
            {
                string trimmedWord = word.Trim();
                Dictionary<char, int> result = GetCharFrequency(trimmedWord);
                Console.WriteLine($"\nString: {trimmedWord}");

                foreach (KeyValuePair<char, int> item in result)
                {
                    Console.Write($"{item.Key}={item.Value}, ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

