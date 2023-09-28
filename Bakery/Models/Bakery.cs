using System;
using System.Collections.Generic;

namespace Bakery.Models
  {
    public class Bread
    {
      public int Loaves { get; set; }

      public Bread(int loaves)
      {
        Loaves = loaves;
      }
    }
  }