using System.Collections.Generic;

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

    public void Rest ()
    {
      this.Food -= 2; 
      this.Mood += 2;
      this.Sleep += 2;
    }
    
    public void Feed ()
    {
      this.Food += 2; 
      this.Mood += 2;
      this.Sleep -= 2;
    }

    public void Play ()
    {
      this.Food -= 2; 
      this.Mood += 2;
      this.Sleep -= 2;
    }
  }       
}
