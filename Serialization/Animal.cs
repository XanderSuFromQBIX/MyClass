using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationExample
{
    public class Animal
    {
        public string AnimalName { get; set; }
        public int NumLegs { get; set; }

        public Animal(string name, int legs)
        {
            AnimalName = name;
            NumLegs = legs;
        }
    }
}
