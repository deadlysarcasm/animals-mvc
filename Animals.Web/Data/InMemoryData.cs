using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Web;
using Animals.Web.Models;

namespace Animals.Web.Data
{
    public class InMemoryData
    {
        private List<Animal> data;
        public InMemoryData()
        {
            data = new List<Animal>();
            data.Add(new Animal { Id = 1, Name = "Harold", Species = "Giraffe", Gender = Gender.Male });
            data.Add(new Animal { Id = 2, Name = "Gloria", Species = "Giraffe", Gender = Gender.Female });
            data.Add(new Animal { Id = 3, Name = "Dumbo", Species = "Elephant", Gender = Gender.Male });
            data.Add(new Animal { Id = 4, Name = "Walter", Species = "Walrus", Gender = Gender.Male });
        }

        public List<Animal> GetAll()
        {
            return data;
        }

        public Animal Get(int Id)
        {
            return data.FirstOrDefault(x => x.Id == Id);
        }
    }
}