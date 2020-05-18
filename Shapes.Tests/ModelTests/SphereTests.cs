using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Models;
using System;

namespace Shapes.TestTools
{
  [TestClass]
  public class SphereTests
  {
    [TestMethod]
  
    public void Sphere_GetVolume_VolumeOfSphere()
    {
    
    Sphere newSphere = new Sphere(new Circle(3));

    Assert.AreEqual(113.10, newSphere.GetVolume());
    }
  
  }
}