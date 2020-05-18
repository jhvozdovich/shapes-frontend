using System;

namespace Shapes.Models
{
  public class Sphere
  {
    public Circle Template {get; set;}
    public double Radius {get; set;} 
    public Sphere(Circle template)
    {
      Template = template;
      Radius = Template.Radius;
    }

    public double GetVolume()
    {
      double volume = Math.Round((4.0/3.0)*Math.PI*Math.Pow(Radius, 3), 2);
      return volume;
    }
  }
}