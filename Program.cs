using System;

namespace _4
{
    class calc {
        public double a;
        public double b;
        public double c;
        public static void kv(double a, double b, double c )
        {
            double D = Math.Sqrt( b * b - (4 * a * c));
            b *= -1;
            double x = (b + D) / (2 * a);
            if(D > 0) { double x2 = (b - D) / (2 * a); Console.WriteLine("\nОтвет: x1=" + x +" x2=" + x2); }
            else if(D == 0) { Console.WriteLine("\nОтвет: x="+ x); }
            else if(D < 0) { Console.WriteLine("\nРешения, т.е. корней нет."); }
        }
    }
    class calc2 : calc {     }
    class Program
    {
        static void Main(string[] args)
        {
            calc2.kv(2, 30, 5);
        }
    }
}
