using Microsoft.AspNetCore.Mvc;
using Tamagotchi.Models;
using System.Collections.Generic;

namespace Tamagotchi.Controllers
{
    public class TamagotchiController: Controllers
    {
        [HttpGet("/items")]
     
       public ActionResult Index()
       {
           List<Tamagotchi> myTamagotchi = Tamagotchi.CreateTama();
           return View(myTamagotchi);
       }
    }
}