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
    [HttpPost("/")]
      public ActionResult Tamagotchi(string name)
      {
        Tamagotchi myTamagotchi = new Tamagotchi(name);
        return View(myTamagotchi);
      }    
  }
}



    // 
    //[HTTPGET("/tamagotchi")]
    // public ActionResult CreateForm()
    // {
    //   return View();
    // }

  
    // [HttpPost("/tamogotchi")]
    // public ActionResult Create(string description)
    // {
    //   Item myItem = new Item(description);
    //   return RedirectToAction("Index");