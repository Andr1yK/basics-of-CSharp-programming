using System; 
using System.Collections.Generic; 
using System.Text;

namespace Lab_1
{
    class Program
    {
        static double k1(double x, double y)
        {
            double firstOperand = Math.Sin(x) / (Math.Pow(x, 2) + Math.Pow(y, 2));
            double secondOperand = Math.Cos(y) / (1 + Math.Abs(x * y));
            
            return firstOperand + secondOperand;
        }
        
        static void k2(double x, double y, ref double r)
        {
            double firstOperand = Math.Sin(x) / (Math.Pow(x, 2) + Math.Pow(y, 2));
            double secondOperand = Math.Cos(y) / (1 + Math.Abs(x * y));
            
            r = firstOperand + secondOperand;
        }
        
        static void k3(double x, double y, out double r)
        {
            double firstOperand = Math.Sin(x) / (Math.Pow(x, 2) + Math.Pow(y, 2));
            double secondOperand = Math.Cos(y) / (1 + Math.Abs(x * y));
            
            r = firstOperand + secondOperand;
        }
        
        static void Main() 
        {
            // Input
            Console.Write("p = ");
            double p = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
          
            Console.Write("q = ");
            double q = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            
            // Solution 1 - using return
            double result1 = (
                Math.Pow(k1(1 + Math.Pow(p, 2), 1 - Math.Pow(q, 2)), 2)
                - Math.Pow(k1(1, p * q), 2)
            ) / (
                1 + k1(p * q, 1)
            );

            Console.WriteLine("Result (using return): " + result1);
            
            // Solution 2 - using ref
            double r1 = 0, r2 = 0, r3 = 0;

            k2(1 + Math.Pow(p, 2), 1 - Math.Pow(q, 2), ref r1);
            k2(1, p * q, ref r2);
            k2(p * q, 1, ref r3);
            
            double result2 = (Math.Pow(r1, 2) - Math.Pow(r2, 2)) / (1 + r3);

            Console.WriteLine("Result (using ref): " + result2);
            
            // Solution 3 - using out
            double t1, t2, t3;
            
            k3(1 + Math.Pow(p, 2), 1 - Math.Pow(q, 2), out t1);
            k3(1, p * q, out t2);
            k3(p * q, 1, out t3);
            
            double result3 = (Math.Pow(t1, 2) - Math.Pow(t2, 2)) / (1 + t3);
            
            Console.WriteLine("Result (using out): " + result3);
        }
    }
}