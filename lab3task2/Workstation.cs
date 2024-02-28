using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace lab3task2
{
    public class Workstation : Computer
    {
        public Workstation(string ipAddress, int power, string os) : base(ipAddress, power, os)
        {
        }

        public void Work()
        {
            Console.WriteLine($"{IPAddress} is working.");
        }
    }
}
