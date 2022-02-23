using Microsoft.AspNetCore.Mvc;
using Tama.Models;

namespace Tama.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }
  
  }
}


