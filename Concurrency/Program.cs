using System;
using System.Collections.Generic;
using System.Threading;

namespace Concurrency
{
    class Program
    {
        static void Main(string[] args)
        {
            var ordersQueue = new Queue<string>();
            PlaceOrders(ordersQueue, "John", 6);
            PlaceOrders(ordersQueue, "Eric", 6);

            foreach (string order in ordersQueue)
                Console.WriteLine("ORDER: " + order);
        }

        static void PlaceOrders(Queue<string> orders, string customerName, int nOrders)
        {
            for (int i = 1; i <= nOrders; i++)
            {
                Thread.Sleep(1);
                string orderName = $"{customerName} wants t-shirt {i}";
                orders.Enqueue(orderName);
            }
        }
    }
}
