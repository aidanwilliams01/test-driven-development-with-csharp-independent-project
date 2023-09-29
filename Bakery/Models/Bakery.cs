using System;
using System.Collections.Generic;
using System.Xml.XPath;

namespace Bakery.Models
  {
    public class Bread
    {
      public int Loaves { get; set; }

      public Bread(int loaves)
      {
        Loaves = loaves;
      }

      public float CalculateCost()
      {
        int freeLoaves = Loaves / 3;
        int loaves = Loaves - freeLoaves;
        float result = loaves * 5;
        return result;
      }
    }
  }