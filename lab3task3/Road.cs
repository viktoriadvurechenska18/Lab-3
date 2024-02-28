using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3task3
{
    public class Road
    {
        public double Length { get; }
        public double Width { get; }
        public int Lanes { get; }
        public int TrafficLevel { get; }

        public Road(double length, double width, int lanes, int trafficLevel)
        {
            Length = length;
            Width = width;
            Lanes = lanes;
            TrafficLevel = trafficLevel;
        }
    }
}
