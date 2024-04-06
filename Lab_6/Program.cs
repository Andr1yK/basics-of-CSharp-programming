namespace Lab_6
{
  class Program
  {
    static void Main()
    {
      Console.Write("Input string: ");
      String input = Console.ReadLine() ?? throw new InvalidOperationException();
      
      Console.WriteLine($"Count of commas: {CountAllCommas(input)}");

      Console.WriteLine($"Replaced commas: {ReplaceAllCommas(input)}");
    }
    
    static int CountAllCommas(String input)
    {
      int count = 0;
      
      foreach (char c in input)
      {
        if (c == ',')
        {
          count++;
        }
      }
      
      return count;
    }
    
    static string ReplaceAllCommas(String input)
    {
      return input.Replace(",", "**");
    }
  }
}