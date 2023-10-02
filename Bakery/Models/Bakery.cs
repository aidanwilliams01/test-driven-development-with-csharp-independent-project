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
      public int Pastrys { get; set; }

      public Pastry(int pastrys)
      {
        Pastrys = pastrys;
      }

      public float CalculateCost()
      {
        int freePastrys = Pastrys / 4;
        int pastrys = Pastrys - freePastrys;
        float result = pastrys * 2;
        return result;
      }
    }
  }