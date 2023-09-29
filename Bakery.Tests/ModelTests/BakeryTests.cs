using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {

    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(3);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void GetLoaves_ReturnLoaves_Int()
    {
      int loaves = 3;
      Bread newBread = new Bread(loaves);
      int result = newBread.Loaves;
      Assert.AreEqual(loaves, result);
    }

    [TestMethod]
    public void SetLoaves_SetsValueOfLoaves_Void()
    {
      Bread newBread = new Bread(3);
      int newLoaves = 4;
      newBread.Loaves = newLoaves;
      Assert.AreEqual(newLoaves, newBread.Loaves);
    }

    [TestMethod]
    public void CalculateCost_ReturnsCost_Float()
    {
      Bread newBread = new Bread(3);
      float cost = newBread.CalculateCost();
      Assert.AreEqual(10, cost);
    }
  }

  [TestClass]
  public class PastryTests
  {
    
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry(3);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void GetPastrys_ReturnPastrys_Int()
    {
      int pastrys = 3;
      Pastry newPastry = new Pastry(pastrys);
      int result = newPastry.Pastrys;
      Assert.AreEqual(pastrys, result);
    }

    [TestMethod]
    public void SetPastrys_SetsValueOfPastrys_Void()
    {
      Pastry newPastry = new Pastry(3);
      int newPastrys = 4;
      newPastry.Pastrys = newPastrys;
      Assert.AreEqual(newPastrys, newPastry.Pastrys);
    }
  }
}