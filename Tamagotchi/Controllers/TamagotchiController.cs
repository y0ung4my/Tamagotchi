using Microsoft.AspNetCore.Mvc;
using Tama.Models;
using System.Collections.Generic;

namespace Tama.Controllers
{
    public class TamagotchiController : Controller
    {
        [HttpGet("/tamagotchi")]
        public ActionResult Tamagotchi(string name)
        {
            Tamagotchi myTamagotchi = new Tamagotchi(name);
            return View(myTamagotchi);
        }
        //   [HttpGet("/formsforbuttons")]
        // public ActionResult Tamagotchi()
        // {
        //     Button myButton= new Button (); 
        //     return ?? 
        // }
        //    [HttpPost("/updatedforms")]
        // public ActionResult Tamagotchi()
        // {
        //     Button myButton= new Button (); 
        //     return ?? 
        // }
    }
}