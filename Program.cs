using System;
using System.Collections.Generic;

namespace random_numbers
{
  class Program
  {
    static void Main(string[] args)
    {
      Random random = new Random();
      List<int> numbers = new List<int> {
    random.Next(6),
    random.Next(6),
    random.Next(6),
    random.Next(6),
    random.Next(6),
    random.Next(6),
    };

      Console.WriteLine($"Initial List of Random Numbers: ");
      numbers.ForEach(n => Console.WriteLine(n));

      Console.WriteLine("Conditional Number List Contains: ");
      for (int i = 0; i < numbers.Count; i++)
      {
        string output = numbers.Contains(i) ? $"List does contain {i}" : $"List does not contain {i}";
        Console.WriteLine(output);
      }


    }
  }
}
