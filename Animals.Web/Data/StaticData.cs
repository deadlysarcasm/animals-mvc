using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Animals.Web.Models;

namespace Animals.Web.Data
{
    public static class StaticData
    {

        public static List<Animal> animals = new List<Animal>
        {
            new Animal { Id = 1, Name = "Harold", Species = "Giraffe", Gender = Gender.Male },
            new Animal { Id = 2, Name = "Gloria", Species = "Giraffe", Gender = Gender.Female },
            new Animal { Id = 3, Name = "Dumbo", Species = "Elephant", Gender = Gender.Male },
            new Animal { Id = 4, Name = "Walter", Species = "Walrus", Gender = Gender.Male }
        };
    }
}