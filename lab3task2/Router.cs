using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace lab3task2
{
    public class Router: Computer
        {
            public List<IConnectable> ConnectedDevices { get; } = new List<IConnectable>();

            public Router(string ipAddress, int power, string os) : base(ipAddress, power, os)
            {
            }

            public void ConnectTo(IConnectable device)
            {
                ConnectedDevices.Add(device);
                Console.WriteLine($"Router {IPAddress} is connecting to {device}");
            }

            public void DisconnectFrom(IConnectable device)
            {
                ConnectedDevices.Remove(device);
                Console.WriteLine($"Router {IPAddress} is disconnecting from {device}");
            }
        }
}
