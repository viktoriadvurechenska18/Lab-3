using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3task2
{
    public class Client : Computer
    {
        public Client(string ipAddress, int power, string os) : base(ipAddress, power, os)
        {
        }
    }
}
