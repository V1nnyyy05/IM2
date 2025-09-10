using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumAndAverage
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                try
                {
                    Console.Write("Enter Row: ");
                    int row = int.Parse(Console.ReadLine());

                    Console.Write("Enter Column: ");
                    int col = int.Parse(Console.ReadLine());

                    List<List<double>> list = new List<List<double>>();
                    double sum = 0;

                    for (int i = 0; i < row; i++)
                    {
                        Console.WriteLine($"\nRow {i + 1}");

                        List<double> numList = new List<double>();
                        for (int j = 0; j < col; j++)
                        {
                            Console.Write($"Enter number {j + 1}: ");
                            double num = double.Parse(Console.ReadLine());

                            numList.Add(num);
                            sum += num;
                        }
                        list.Add(numList);
                    }

                    double avg = sum / (row + col);
                    Console.WriteLine("The numbers are:");

                    for (int i = 0; i < list.Count; i++)
                    {
                        for (int j = 0; j < list[i].Count; j++)
                        {
                            Console.Write(list[i][j].ToString("F1") + " ");
                        }
                        Console.WriteLine("");
                    }
                    Console.WriteLine($"\nSum: {sum.ToString("F1")} ; Average: {avg.ToString("F1")}");
                    break;

                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input, please try again.");
                    continue;
                }
            }
            Console.ReadKey();
        }
    }
}
