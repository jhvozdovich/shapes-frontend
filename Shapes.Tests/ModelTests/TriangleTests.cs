using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Models;

namespace Shapes.TestTools
{
  [TestClass]
  public class TriangleTests
  {
    [TestMethod]
    public void Triangle_GetArea_AreaOfTriangle()
    {
      Triangle newTriangle = new Triangle(3, 5);
      double result = newTriangle.GetArea();
      Assert.AreEqual(7.50, result);
    }
  }
}