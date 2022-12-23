using oop3_1;
using oop3_1.Transports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oop2_3
{
    class Program
    {
        static void Main()
        {
            Taxi taxi = new(94, 12);
            Train train = new(20, 12, 9, 6, 10, 7);
            Bus bus = new(31, 26, 20, 17);

            Flight flight = new(taxi, train, bus);

            taxi.PrintRevenue();
            train.PrintRevenue();
            bus.PrintRevenue();

            flight.PrintRevenue();

            Console.WriteLine(flight.TotalRevenue);
        }
    }
}