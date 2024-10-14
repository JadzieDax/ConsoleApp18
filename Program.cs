using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            double result = SqrtCalculation(3, 2) + SqrtCalculation(5, 3) + SqrtCalculation(11, 7);
            Console.WriteLine($"Результат: {result:F3}");
            Console.ReadLine();
        }

        static double SqrtCalculation(double a, double b)
        {
            return (Math.Sqrt(a) - Math.Sqrt(b)) / (Math.Sqrt(a) + Math.Sqrt(b));
        }
    }
}