using Microsoft.AspNetCore.Mvc;
using Tama.Models;
using System.Collections.Generic;

namespace Tama.Controllers
{
    public class TamagotchiController : Controller
    {
        [HttpPost("/tamagotchi")]
        public ActionResult Index(string name)
        {
            Tamagotchi myTamagotchi = new Tamagotchi(name);
            return View(myTamagotchi);
        }
        // [HttpPost("/tamagotchi/sleep")]
        // public ActionResult Rest(Tamagotchi myTamagotchi)
        // {
        //     myTamagotchi.Rest();
        //     return RedirectToAction("Index"); 
        // } 
        // [HttpPost("/tamagotchi/eat")]
        // public ActionResult Feed(Tamagotchi myTamagotchi)
        // {
        //     myTamagotchi.Feed();
        //     return RedirectToAction("Index"); 
        // } 
        // [HttpPost("/tamagotchi/play")]
        // public ActionResult Play(Tamagotchi myTamagotchi)
        // {
        //     myTamagotchi.Play();
        //     return RedirectToAction("Index"); 
        // } 
    }
}