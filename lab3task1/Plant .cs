using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3task1
{
    public class Plant : LivingOrganism, IReproducible
    {
        public Plant(double energy, int age, double size) : base(energy, age, size) { }

        public void Reproduce()
        {
            Console.WriteLine("The plant reproduces");
        }
    }
}
