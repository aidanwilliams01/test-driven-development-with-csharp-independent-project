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
      Console.WriteLine("How many loaves of bread?");
      int loaves = int.Parse(Console.ReadLine());
      Console.WriteLine("How many pastrys?");
      int pastrys = int.Parse(Console.ReadLine());
      // add edge-case handling
      Bread bread = new Bread(loaves);
      Pastry pastry = new Pastry(pastrys);
      float cost = bread.CalculateCost() + pastry.CalculateCost();
      Console.WriteLine($"The total cost is ${cost}.");
    }
  }
}