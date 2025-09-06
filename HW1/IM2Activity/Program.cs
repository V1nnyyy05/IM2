using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter String: ");
                string inp = Console.ReadLine();


                if (inp != "*")
                {
                    int size = inp.Length;
                    char[] rev = new char[size];
                    char[] orig = new char[size];

                    string strRev = "";
                    string strOrig = "";
                    int c = 0;

                    for (int i = size - 1; i >= 0; i--)
                    {
                        rev[c] = inp[i];
                        orig[c] = inp[c];
                        c++;
                    }

                    for (int j = 0; j < size; j++)
                    {
                        strRev += rev[j];
                        strOrig += orig[j];
                    }

                    if (strOrig.ToLower() == strRev.ToLower())
                    {
                        Console.WriteLine($"Original String: {strOrig} \nReversed String: {strRev.ToLower()} \nPalindrome? Yes\n");
                    }
                    else
                    {
                        Console.WriteLine($"Original String: {strOrig} \nReversed String: {strRev.ToLower()} \nPalindrome? No\n");
                    }
                }
                else
                {
                    Console.WriteLine("!!!");
                    break;
                }
            }
        }
    }
}