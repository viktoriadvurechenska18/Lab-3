using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3task2
{
    public class Server : Computer
    {
        public Server(string ipAddress, int power, string os) : base(ipAddress, power, os)
        {
        }

        public void ServeClient(Client client)
        {
            ConnectTo(client);
            client.ReceiveData("Welcome!");
            DisconnectFrom(client);
        }
    }
}
