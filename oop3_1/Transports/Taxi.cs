using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop3_1.Transports
{
    public class Taxi : Transport, ITransport
    {
        public override string Tipe { get { return "Taxi"; } }
        public override double Revenue { get; set; }
        public double Mileage { get; }
        public double TripCount { get; }
        public Taxi(double mileage, int tripCount)
        {
            this.Mileage = mileage;
            this.TripCount = tripCount;
            this.Revenue = RevenueCalculation();
        }

        public double RevenueCalculation()
        {
            Revenue = 50 * TripCount + 12.5 * Mileage;
            return Revenue;
        }
        public void PrintRevenue()
        {
            Console.WriteLine($"{Tipe} : {Revenue}");
        }
    }
}
