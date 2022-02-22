using System.Collections.Generic;
using Button.Models;

namespace Tama.Models
{
  public class Tamagotchi
  {
    public string Name { get; set; }
    public int Food { get; set; }
    public int Mood { get; set; }
    public int Sleep { get; set; }

    public Tamagotchi (string inputtedName)
    {
      Food = 10;
      Mood = 10;
      Sleep = 10;
      Name = inputtedName;
    }

    //this is temporary
    ButtonValues newButtonValues = new ButtonValues(true, true);

    public void Care ()
    {
      if (newButtonValues.ButtonRest == true)
      {
        this.Food -= 2; 
        this.Mood += 2;
        this.Sleep += 2;
      }
      else if (newButtonValues.ButtonEat == true)
      {
        this.Food += 2; 
        this.Mood += 2;
        this.Sleep -= 2;
      }
      else
      {
        this.Food -= 2; 
        this.Mood += 2;
        this.Sleep -= 2;
      }
    }
  }       
}
