using System;

namespace Shapes.Models
{
  public class Circle
  {
    public int Radius { get; set; }
    public Circle(int radius)
    {
      Radius = radius;
    }
    public double GetArea()
    {
      double pi = Math.PI;
      double squared = Math.Pow(Radius, 2);
      double multiply = pi * squared;
      return Math.Round(multiply, 2);
    }
  }
}