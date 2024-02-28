using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var server = new Server("192.168.1.1", 1000, "Windows Server");
            var workstation = new Workstation("192.168.1.2", 500, "Windows 10");
            var router = new Router("192.168.1.254", 800, "Embedded OS");

            // Додаю їх до мережі
            var network = new Network();
            network.AddDevice(server);
            network.AddDevice(workstation);
            network.AddDevice(router);

            // З'єдную комп'ютери
            network.ConnectDevices(server, router);
            network.ConnectDevices(workstation, router);

            // Передаємо дані
            server.ServeClient(new Client("192.168.1.3", 300, "Windows 10"));

            // Від'єдную комп'ютери
            network.DisconnectDevices(server, router);
            network.DisconnectDevices(workstation, router);
        }
    }
    
}
