namespace Lab_3
{
  class Program
  {
    static void Main()
    {
      Console.Write("N = ");
      int n = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
      
      Console.WriteLine($"S (f1) = {F1(n)}");
      Console.WriteLine($"S (f2) = {F2(n)}");
      Console.WriteLine($"S (f3) = {F3(n)}");
      Console.WriteLine($"S (f4) = {F4(n)}");
      Console.WriteLine();
      
      double r1 = 0;
      double r2 = 0;
      double r3 = 0;
      double r4 = 0;
      
      G1(n, ref r1);
      G2(n, ref r2);
      G3(n, ref r3);
      G4(n, ref r4);
      
      Console.WriteLine($"S (g1) = {r1}");
      Console.WriteLine($"S (g2) = {r2}");
      Console.WriteLine($"S (g3) = {r3}");
      Console.WriteLine($"S (g4) = {r4}");
      Console.WriteLine();
      
      double o1;
      double o2;
      double o3;
      double o4;
      
      H1(n, out o1);
      H2(n, out o2);
      H3(n, out o3);
      H4(n, out o4);
      
      Console.WriteLine($"S (h1) = {o1}");
      Console.WriteLine($"S (h2) = {o2}");
      Console.WriteLine($"S (h3) = {o3}");
      Console.WriteLine($"S (h4) = {o4}");
    }

    // while, return
    private static double F1(int n)
    {
      double result = 0;
      int i = 1;
      
      while (i <= n)
      {
        result += (1.0 / i) + Math.Sqrt(1 + Math.Pow(Math.Sin(i), 2));
        i++;
      }
      
      return result;
    }
    
    // do while, return
    private static double F2(int n)
    {
      double result = 0;
      int i = 1;
      
      do
      {
        result += (1.0 / i) + Math.Sqrt(1 + Math.Pow(Math.Sin(i), 2));
        i++;
      } while (i <= n);
      
      return result;
    }
    
    // for ++, return
    private static double F3(int n)
    {
      double result = 0;
      
      for (int i = 1; i <= n; i++)
      {
        result += (1.0 / i) + Math.Sqrt(1 + Math.Pow(Math.Sin(i), 2));
      }
      
      return result;
    }
    
    // for --, return
    private static double F4(int n)
    {
      double result = 0;
      
      for (int i = n; i >= 1; i--)
      {
        result += (1.0 / i) + Math.Sqrt(1 + Math.Pow(Math.Sin(i), 2));
      }
      
      return result;
    }
    
    // while, ref
    private static void G1(int n, ref double result)
    {
      result = 0;
      int i = 1;
      
      while (i <= n)
      {
        result += (1.0 / i) + Math.Sqrt(1 + Math.Pow(Math.Sin(i), 2));
        i++;
      }
    }
    
    // do while, ref
    private static void G2(int n, ref double result)
    {
      result = 0;
      int i = 1;
      
      do
      {
        result += (1.0 / i) + Math.Sqrt(1 + Math.Pow(Math.Sin(i), 2));
        i++;
      } while (i <= n);
    }
    
    // for ++, ref
    private static void G3(int n, ref double result)
    {
      result = 0;
      
      for (int i = 1; i <= n; i++)
      {
        result += (1.0 / i) + Math.Sqrt(1 + Math.Pow(Math.Sin(i), 2));
      }
    }
    
    // for --, ref
    private static void G4(int n, ref double result)
    {
      result = 0;
      
      for (int i = n; i >= 1; i--)
      {
        result += (1.0 / i) + Math.Sqrt(1 + Math.Pow(Math.Sin(i), 2));
      }
    }
    
    // while, out
    private static void H1(int n, out double result)
    {
      result = 0;
      int i = 1;
      
      while (i <= n)
      {
        result += (1.0 / i) + Math.Sqrt(1 + Math.Pow(Math.Sin(i), 2));
        i++;
      }
    }
    
    // do while, out
    private static void H2(int n, out double result)
    {
      result = 0;
      int i = 1;
      
      do
      {
        result += (1.0 / i) + Math.Sqrt(1 + Math.Pow(Math.Sin(i), 2));
        i++;
      } while (i <= n);
    }
    
    // for ++, out
    private static void H3(int n, out double result)
    {
      result = 0;
      
      for (int i = 1; i <= n; i++)
      {
        result += (1.0 / i) + Math.Sqrt(1 + Math.Pow(Math.Sin(i), 2));
      }
    }
    
    // for --, out
    private static void H4(int n, out double result)
    {
      result = 0;
      
      for (int i = n; i >= 1; i--)
      {
        result += (1.0 / i) + Math.Sqrt(1 + Math.Pow(Math.Sin(i), 2));
      }
    }
  }
}

