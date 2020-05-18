using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Shapes.Models;

namespace Shapes.Models
{
  [TestClass]

  public class PyramidTests
  {
    [TestMethod]

    public void Pyramid_GetVolume_Volume()
    {
      Pyramid newPyramid = new Pyramid(new Triangle(3, 5));
      Assert.AreEqual(25.00, newPyramid.Volume());
    }


  }

}

