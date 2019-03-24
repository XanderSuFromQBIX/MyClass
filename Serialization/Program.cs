using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SerializationExample
{
    class Program
    {
        static void Main(string[] args)
        {            
        //    var bob = new Animal("Bob", 100);
        //    PrintStats(bob);
        //    string sBob = JsonConvert.SerializeObject(bob);
        //    Console.WriteLine(sBob);
            string iBob = "{\"AnimalName\":\"Fred\",\"NumLegs\":120}";
            Animal fred = JsonConvert.DeserializeObject<Animal>(iBob);
            PrintStats(fred);
            Console.ReadLine();
        }

        public static void PrintStats(Animal animal)
        {
            Console.WriteLine($"Creature: {animal.AnimalName} has {animal.NumLegs} legs.");
        }
    }
}
