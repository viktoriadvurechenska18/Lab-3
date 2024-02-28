using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3task1
{
    public class Animal : LivingOrganism, IReproducible, IPredator
    {
        public Animal(double energy, int age, double size) : base(energy, age, size) { }

        public void Reproduce()
        {
            Console.WriteLine(" The animal reproduces");
        }

        public void Hunt(LivingOrganism prey)
        {
            Console.WriteLine("An animal hunts on another organism.");
        }
    }
}
