using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seatwork1
{
    class Program
    {
        static bool IsPrime(int num)
        {
            if (num <= 1) return false; 

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                    return false; 
            }
            return true; 
        }
        static void Main(string[] args)
        {
            Console.Write("Enter string: ");
            string input = Console.ReadLine();

            string[] numbers = input.Split(' ');

            int count = 1;
            foreach (string str in numbers)
            {
                if (int.TryParse(str, out int num))
                {
                    if (IsPrime(num))
                        Console.WriteLine($"{count}.  {num}\tPrime");
                    else
                        Console.WriteLine($"{count}.  {num}\tComposite");
                    count++;
                }
            }Console.ReadKey();
        }
        
    }
}
