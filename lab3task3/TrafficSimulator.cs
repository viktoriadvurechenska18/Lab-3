using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3task3
{
    public class TrafficSimulator
    {
        public void SimulateTraffic(IDriveable vehicle, Road road)
        {
            Console.WriteLine($"Simulating traffic on a road {road.Length} km long with {road.Lanes} lane(s).");
            Console.WriteLine($"Current traffic level: {road.TrafficLevel}");

            vehicle.Move();

            if (road.TrafficLevel > 5)
            {
                Console.WriteLine("Traffic is heavy. Vehicles are stopping.");
                vehicle.Stop();
            }
            else
            {
                Console.WriteLine("Traffic is flowing smoothly.");
            }
        }
    }

}
