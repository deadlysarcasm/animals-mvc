using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Animals.Web.Models
{
    public class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
        public Gender Gender { get; set; }

    }
}