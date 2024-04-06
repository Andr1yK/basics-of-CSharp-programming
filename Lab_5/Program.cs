namespace Lab_5
{
  class Program
  {
    static void Main()
    {
      Console.Write("Rows count = ");
      int n = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
      Console.Write("Columns count = ");
      int k = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
      
      int[,] a = new int[n, k];
      
      FillArray(a);
      PrintArray(a);
      
      Console.WriteLine($"Min of max in odd columns: {MinOfMaxInOddColumns(a)}");
    }
    
    static int MinOfMaxInOddColumns(int[,] a)
    {
      int min = int.MaxValue;
      
      int rowsCount = a.GetLength(0);
      int columnsCount = a.GetLength(1);
      
      for (int j = 0; j < columnsCount; j += 2)
      {
        int max = int.MinValue;
        
        for (int i = 0; i < rowsCount; i++)
        {
          int x = a[i, j];
          
          max = x > max
            ? x
            : max;
        }
        
        min = max < min
          ? max
          : min;
      }
      
      return min;
    }
    
    static void FillArray(int[,] a)
    {
      Random random = new Random();
      
      int rowsCount = a.GetLength(0);
      int columnsCount = a.GetLength(1);
      
      for (int i = 0; i < rowsCount; i++)
      {
        for (int j = 0; j < columnsCount; j++)
        {
          a[i, j] = random.Next(-99, 99);
        }
      }
    }
    
    static void PrintArray(int[,] a)
    {
      int rowsCount = a.GetLength(0);
      int columnsCount = a.GetLength(1);

      for (int i = 0; i < rowsCount; i++)
      {
        for (int j = 0; j < columnsCount; j++)
        {
          Console.Write("{0, 4}", a[i, j]);
        }
        
        Console.WriteLine();
      }
    }
  }
}