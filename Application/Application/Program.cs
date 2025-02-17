using System;
using System.Collections.Generic;

namespace ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        ILogger logger = new ConsoleLogger();

        List<ClientsCounter> clients = new List<ClientsCounter>();

        ClientsCounter client1 = new ClientsCounter("Alice", "Regular", logger);
        ClientsCounter client2 = new ClientsCounter("Bobus", "New", logger);
        VipClient vipClient = new VipClient("Daddy", "Premium", "Gold", logger);

        clients.Add(client1);
        clients.Add(client2);
        clients.Add(vipClient);

        Console.WriteLine("\nClients list:");
        foreach (var client in clients)
        {
            client.ShowClientsData(); 
        }

        Console.WriteLine($"Total Users: {ClientsCounter.GetUserCount()}");
    }
}