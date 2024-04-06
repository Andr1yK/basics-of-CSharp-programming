namespace Lab_4
{
  class Program
  {
    static void Main()
    {
      Console.Write("n = ");
      int n = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
      
      int[] a = new int[n];
      
      CreateRandomArray(a);
      PrintArray(a);
      
      Console.WriteLine($"Count of odd digits: {CountOfOddDigits(a)}");
    }
    
    static int CountOfOddDigits(int[] a)
    {
      int count = 0;
      
      foreach (int x in a)
      {
        if (x % 2 != 0)
        {
          count++;
        }
      }
      
      return count;
    }
    
    static void CreateRandomArray(int[] a)
    {
      Random random = new Random();
      
      for (int i = 0; i < a.Length; i++)
      {
        a[i] = random.Next(-100, 100);
      }
    }
    
    static void PrintArray(int[] a)
    {
      foreach (var number in a)
      {
        Console.Write("{0, 4}", number);
      }
      
      Console.WriteLine();
    }
  }
}

