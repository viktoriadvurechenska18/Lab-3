using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3task3
{
    public class Vehicle : IDriveable
    {
        public string Type { get; }
        public int Speed { get; }
        public int Size { get; }

        public Vehicle(string type, int speed, int size)
        {
            Type = type;
            Speed = speed;
            Size = size;
        }

        public void Move()
        {
            Console.WriteLine($"{Type} is moving at a speed of {Speed} km/h.");
        }

        public void Stop()
        {
            Console.WriteLine($"{Type} has stopped.");
        }
    }
}
