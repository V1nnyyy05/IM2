using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seatwork2
{
    class Program
    {
        const double DollarToPeso = 57.17;
        const double DollarToYen = 146.67;
        static (double peso, double yen) ConvertCurrency(double dollars)
        {
            double peso = dollars * DollarToPeso;
            double yen = dollars * DollarToYen;
            return (peso, yen);
        }
        static void Main(string[] args)
        {
            Console.Write("Enter currency in ($): ");
            string input = Console.ReadLine();

            string[] amounts = input.Split(' ');

            Console.WriteLine("\nDollar($)\tPhil Peso(P)\tJpn Yen(¥)");

            foreach (string str in amounts)
            {
                if (double.TryParse(str.Trim(), out double dollars))
                {
                    var (peso, yen) = ConvertCurrency(dollars);
                    Console.WriteLine($"{dollars}\t\t{peso:F2}\t\t{yen:F2}");
                }
            }

           Console.ReadKey();
        } 
    }
}
