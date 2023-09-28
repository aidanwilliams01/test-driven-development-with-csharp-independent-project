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
        if (Loaves % 3 == 0)
        {
          int loaves = Loaves - 1;
          float result = loaves * 5;
          return result;
        }
        else
        {
          return 0;
        }
      }
    }
  }