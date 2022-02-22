using System;

namespace Button.Models
{
  public class ButtonValues
  {
    public bool ButtonRest { get; set;}
    public bool ButtonEat { get; set;}

    public ButtonValues(bool buttonRestInput, bool buttonEatInput)
    {
      ButtonRest = buttonRestInput;
      ButtonEat = buttonEatInput;
    }
  }
}

//deleete me later!!