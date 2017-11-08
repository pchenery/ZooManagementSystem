using System.Collections.Generic;
using Zoo.BusinessLogic.Models.Animals;
using Zoo.BusinessLogic.Services;

namespace Zoo.BusinessLogic.Models
{
  public class Keeper
  {
    private List<Animal> animals;

    public Keeper(IEnumerable<Animal> animals)
    {
      this.animals = new List<Animal>(animals);
    }

    public IEnumerable<Animal> GetResponsibleAnimals()
    {
      return animals;
    }

    public void FeedAnimal(Animal animalToFeed)
    {
      animalToFeed.Feed();
    }

    public void GroomAnimal(AnimalThatCanBeGroomed animalToGroom)
    {
      animalToGroom.Groom();
    }
    public void CleanAnimal(ICanHaveMuckSweptOut animalToClean)
    {
       animalToClean.Clean();
    }
  }
}