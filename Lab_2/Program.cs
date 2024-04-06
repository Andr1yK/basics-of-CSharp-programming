using System; 
using System.Collections.Generic; 
using System.Text;

namespace Lab_2
{
  class Program
  {
    static void Main() 
    {
      Console.Write("x = ");
      double x = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
      Console.Write("a = ");
      double a = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
      Console.Write("b = ");
      double b = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
      Console.Write("c = ");
      double c = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
      
      Console.WriteLine("F1 = " + F1(x, a, b, c));
      Console.WriteLine("F2 = " + F2(x, a, b, c));
      
      double r1 = 0;
      double r2 = 0;
      
      G1(x, a, b, c, ref r1);
      G2(x, a, b, c, ref r2);
      
      Console.WriteLine("G1 = " + r1);
      Console.WriteLine("G2 = " + r2);

      double o1;
      double o2;
      
      H1(x, a, b, c, out o1);
      H2(x, a, b, c, out o2);
      
      Console.WriteLine("H1 = " + o1);
      Console.WriteLine("H2 = " + o2);
    }
    
    static double F1(double x, double a, double b, double c)
    {
      if (a < 0 && c != 0)
      {
        return a * Math.Pow(x, 2) + b * x + c;
      } 
      else if (a > 0 && c == 0)
      {
        return (-a) / (x - c);
      }
      else
      {
        return a * (x + c);
      }
    }
    
    static double F2(double x, double a, double b, double c)
    {
      if (a < 0 && c != 0)
      {
        return a * Math.Pow(x, 2) + b * x + c;
      } 

      if (a > 0 && c == 0)
      {
        return (-a) / (x - c);
      }
      
      return a * (x + c);
    }
    
    static void G1(double x, double a, double b, double c, ref double r)
    {
      if (a < 0 && c != 0)
      {
        r = a * Math.Pow(x, 2) + b * x + c;
      }
      else if (a > 0 && c == 0)
      {
        r = (-a) / (x - c);
      }
      else
      {
        r = a * (x + c);
      }
    }
    
    static void G2(double x, double a, double b, double c, ref double r)
    {
      if (a < 0 && c != 0)
      {
        r = a * Math.Pow(x, 2) + b * x + c;
        
        return;
      }
      
      if (a > 0 && c == 0)
      {
        r = (-a) / (x - c);
        
        return;
      }

      r = a * (x + c);
    }
    
    static void H1(double x, double a, double b, double c, out double r)
    {
      if (a < 0 && c != 0)
      {
        r = a * Math.Pow(x, 2) + b * x + c;
      }
      else if (a > 0 && c == 0)
      {
        r = (-a) / (x - c);
      }
      else
      {
        r = a * (x + c);
      }
    }
    
    static void H2(double x, double a, double b, double c, out double r)
    {
      if (a < 0 && c != 0)
      {
        r = a * Math.Pow(x, 2) + b * x + c;
        
        return;
      }
      
      if (a > 0 && c == 0)
      {
        r = (-a) / (x - c);
        
        return;
      }

      r = a * (x + c);
    }
  }
}

