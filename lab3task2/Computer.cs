using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3task2
{
    public class Computer : IConnectable
    {
        public string IPAddress { get; private set; }
        public int Power { get; set; }
        public string OS { get; set; }

        public Computer(string ipAddress, int power, string os)
        {
            IPAddress = ipAddress;
            Power = power;
            OS = os;
        }

        public void ConnectTo(IConnectable device)
        {
            Console.WriteLine($"Computer {IPAddress} is connecting to {device}");
        }

        public void DisconnectFrom(IConnectable device)
        {
            Console.WriteLine($"Computer {IPAddress} is disconnecting from {device}");
        }

        public void SendData(string data)
        {
            Console.WriteLine($"Computer {IPAddress} is sending data: {data}");
        }

        public void ReceiveData(string data)
        {
            Console.WriteLine($"Computer {IPAddress} received data: {data}");
        }

        public override string ToString()
        {
            return $"Computer ({IPAddress})";
        }
    }
}
