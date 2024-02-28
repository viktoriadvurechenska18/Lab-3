using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var car = new Vehicle("Car", 90, 2);
            var highway = new Road(100, 4, 2, 5);

            TrafficSimulator simulator = new TrafficSimulator();
            simulator.SimulateTraffic(car, highway);
        }
    }
}
