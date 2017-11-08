using System;
using Zoo.BusinessLogic.Services;

namespace Zoo.BusinessLogic.Models.Animals
{
  public class Zebra : AnimalThatCanBeGroomed, ICanHaveMuckSweptOut
  {
    public Zebra(DateTime dateOfBirth) : base(dateOfBirth)
    {
    }
      public void Clean()
      {
          Console.WriteLine("<Clean zebra enclosure>");
      }
  }
}