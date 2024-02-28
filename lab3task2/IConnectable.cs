using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3task2
{
    public interface IConnectable
    {
        void ConnectTo(IConnectable device);
        void DisconnectFrom(IConnectable device);
        void SendData(string data);
        void ReceiveData(string data);
    }
}
