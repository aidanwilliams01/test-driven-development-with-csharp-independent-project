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

    public class Pastry
    {
      public int Pastries { get; set; }

      public Pastry(int pastries)
      {
        Pastries = pastries;
      }

      public float CalculateCost()
      {
        int freePastries = Pastries / 4;
        int pastries = Pastries - freePastries;
        float result = pastries * 2;
        return result;
      }
    }
  }