using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Models;

namespace Shapes.TestTools
{
  [TestClass]
  public class CircleTests
  {
    [TestMethod]
    public void Circle_GetArea_AreaOfCircle()
    {
      Circle newCircle = new Circle(3);
      double result = newCircle.GetArea();
      Assert.AreEqual(28.27, result);
    }
  }
}