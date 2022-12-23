using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop3_1
{
    public class Flight : ITransport
    {
        public Transport[] arrTransport;

        public double TotalRevenue;

        public Flight(Transport t1, Transport t2, Transport t3)
        {
            arrTransport = new Transport[] { t1, t2, t3 };
            TotalRevenue = RevenueCalculation();
        }
        public double RevenueCalculation()
        {
            foreach (Transport t in arrTransport)
                TotalRevenue += t.Revenue;
            return TotalRevenue;
        }

        public void PrintRevenue()
        {
            Console.WriteLine("Revenue of all transports: ");
            foreach (Transport t in arrTransport)
                Console.WriteLine($"{t.Tipe} : {t.Revenue}");
        }
    }
}
