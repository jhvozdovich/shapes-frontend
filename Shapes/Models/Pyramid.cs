using System;

namespace Shapes.Models
{

  public class Pyramid
  {
    public Triangle Edge{get;set;}


    public Pyramid(Triangle edge)
    {
      Edge = edge;
    }

    public double Volume()
    {
      return Math.Round(((1.0/3.0)*Edge.TriBase*Edge.TriBase*Edge.Height), 2);
    }
  }
}

