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
  }
}