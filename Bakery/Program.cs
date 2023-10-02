using System;
using Bakery.Models;
using System.Collections.Generic;

namespace Bakery
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("Pierre's Bakery");
      Console.WriteLine("Bread is $5/loaf. Buy 2 get 1 free.");
      Console.WriteLine("Pastrys are $2 each. Buy 3 get 1 free.");
      try
      {
        Console.WriteLine("How many loaves of bread?");
        int loaves = int.Parse(Console.ReadLine());
        Console.WriteLine("How many pastrys?");
        int pastrys = int.Parse(Console.ReadLine());
        if (loaves < 0 || pastrys < 0)
        {
          throw new Exception();
        }
        Bread bread = new Bread(loaves);
        Pastry pastry = new Pastry(pastrys);
        float cost = bread.CalculateCost() + pastry.CalculateCost();
        Console.WriteLine($"The total cost is ${cost}.");
        Console.WriteLine("Order again? (yes/no)");
        string rerun = Console.ReadLine().ToLower();
        if (rerun == "yes")
        {
          Main();
        }
        else
        {
          Console.WriteLine("Goodbye.");
        }
      }
      catch
      {
        Console.WriteLine("Input only accepts numbers 0 or greater.");
        Main();
      }
    }
  }
}
