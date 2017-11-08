using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.BusinessLogic.Services;

namespace Zoo.BusinessLogic.Models.Animals
{
  public class Lion : Animal, ICanHaveMuckSweptOut
  {
    public Lion(DateTime dateOfBirth) : base(dateOfBirth)
    {
    }

      public void Clean()
      {
          Console.WriteLine("<Clean lion enclosure>");
      }
    }
}
