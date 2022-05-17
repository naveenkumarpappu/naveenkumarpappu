using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBasedTest2
{
    public delegate int CalculatorDelegate(int a, int b);
    class Program
    {
        public static int Addition(int a, int b)
        {
            return a + b;
        }
        public static int Substraction(int a, int b)
        {
            return a - b;
        }
        public static int Multiplication(int a, int b)
        {
            return a * b;
        }
        static void Main(string[] args)
        {
            CalculatorDelegate cd = new CalculatorDelegate(Addition);
            int n = cd.Invoke(3, 5);
            Console.WriteLine(n);
            CalculatorDelegate cd2 = new CalculatorDelegate(Substraction);
            int n2 = cd2.Invoke(20, 6);
            Console.WriteLine(n2);
            CalculatorDelegate cd3 = new CalculatorDelegate(Multiplication);
            int n3 = cd3.Invoke(4, 5);
            Console.WriteLine(n3);
            Console.ReadLine();
        }
    }
}