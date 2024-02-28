using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ecosystem = new Ecosystem();
            var animal = new Animal(120, 5, 2);
            var plant = new Plant(50, 2, 1);
            var microorganism = new Microorganism(10, 1, 0.1);

            ecosystem.Organisms.Add(animal);
            ecosystem.Organisms.Add(plant);
            ecosystem.Organisms.Add(microorganism);

            ecosystem.SimulateInteraction();

            Console.ReadKey();
        }
    }
}
