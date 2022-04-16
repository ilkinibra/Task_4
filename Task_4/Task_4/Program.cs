using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"MULTIPLY:{Multiply(5, 4, 2)}");
            Console.WriteLine($"DIVIDE: {Divide(30, 4, 5)}");
            Console.WriteLine($"MINUS:{Minus(20, 4, 5)}");
            Console.WriteLine($"SUM:{Sum(2,3,4)}");
            Console.WriteLine($"DIVIDE: {Divide(30, 4)}");
        }
        public static int Sum(int a, int b)
        {
            return a + b;
        }
        public static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }

        public static int Sum(int a, int b, int c, int d)
        {
            return a + b + c + d;
        }
        public static int Sum(int a, int b, int c, int d, int e)
        {
            return a + b + c + d + e;
        }
        public static int Minus(int a, int b)
        {
            return a - b;
        }
        public static int Minus(int a, int b, int c)
        {
            return a - b - c;
        }
        public static int Minus(int a, int b, int c, int d)
        {
            return a - b - c - d;
        }
        public static int Minus(int a, int b, int c, int d, int e)
        {
            return a - b - c - d - e;
        }
        public static int Multiply(int a, int b)
        {
            return a * b;
        }
        public static int Multiply(int a, int b, int c)
        {
            return a * b * c;
        }
        public static int Multiply(int a, int b, int c, int d)
        {
            return a * b * c * d;
        }
        public static int Multiply(int a, int b, int c, int d, int e)
        {
            return a * b * c * d * e;
        }
        public static double Divide(int a, int b)
        {
            return (double)a / b;
        }
        public static double Divide(double a, double b, double c)
        {
            return a / b / c;
        }
        public static double Divide(double a, double b, double c, double d)
        {
            return a / b / c / d;
        }

        public static double Divide(double a, double b, double c, double d, double e)
        {
            return a / b / c / d / e;
        }
    }
}
