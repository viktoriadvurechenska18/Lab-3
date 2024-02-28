using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3task1
{
    public class Ecosystem
    {
        public List<LivingOrganism> Organisms { get; set; }

        public Ecosystem()
        {
            Organisms = new List<LivingOrganism>();
        }

        public void SimulateInteraction()
        {
            foreach (var organism in Organisms)
            {
                if (organism is IReproducible)
                {
                    (organism as IReproducible).Reproduce();
                }

                if (organism is IPredator)
                {
                    foreach (var prey in Organisms)
                    {
                        if (prey != organism)
                        {
                            (organism as IPredator).Hunt(prey);
                        }
                    }
                }
            }
        }
    }
}
