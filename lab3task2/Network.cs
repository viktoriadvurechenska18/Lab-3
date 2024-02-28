using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3task2
{
    public class Network
    {
        private List<IConnectable> devices = new List<IConnectable>();

        public void AddDevice(IConnectable device)
        {
            devices.Add(device);
        }

        public void ConnectDevices(IConnectable device1, IConnectable device2)
        {
            device1.ConnectTo(device2);
            device2.ConnectTo(device1);
        }

        public void DisconnectDevices(IConnectable device1, IConnectable device2)
        {
            device1.DisconnectFrom(device2);
            device2.DisconnectFrom(device1);
        }
    }
}
