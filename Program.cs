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
            double result = SqrtCalc(3, 2) + SqrtCalc(5, 3) + SqrtCalc(11, 7);
            Console.WriteLine($"Результат: {result:F3}");
            Console.ReadLine();
        }

        static double SqrtCalc(double a, double b)
        {
            return (Math.Sqrt(a) - Math.Sqrt(b)) / (Math.Sqrt(a) + Math.Sqrt(b));
        }
    }
}