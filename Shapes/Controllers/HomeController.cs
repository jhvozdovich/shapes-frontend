using Microsoft.AspNetCore.Mvc;
using Shapes.Models;

namespace Shapes.Controllers{
  public class HomeController : Controller{
    [Route("/circleForm")]
    public ActionResult CircleForm(){return View();}
    [Route("/circle")]
    public ActionResult Circle(int radius) {
      Circle myCircle = new Circle(radius);
      return View(myCircle);
    }
  }
}