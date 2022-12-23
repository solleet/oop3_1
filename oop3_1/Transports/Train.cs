using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop3_1.Transports
{
    public class Train : Transport, ITransport
    {
        public override string Tipe { get { return "Train"; } }
        public override double Revenue { get; set; }
        public double NumAdultZones { get; }
        public double NumAdults { get; }
        public double NumChildrenZones { get; }
        public double NumChildrens { get; }
        public double NumEnjoyBenefitsZones { get; }
        public double NumEnjoyBenefits { get; }

        public Train(int numberAdultZones, int numberAdults,
                     int numberChildrenZones, int numberChildrens,
                     int numberEnjoyBenefitsZones, int numberEnjoyBenefits)
        {
            this.NumAdultZones = numberAdultZones;
            this.NumAdults = numberAdults;
            this.NumChildrenZones = numberChildrenZones;
            this.NumChildrens = numberChildrens;
            this.NumEnjoyBenefitsZones = numberEnjoyBenefitsZones;
            this.NumEnjoyBenefits = numberEnjoyBenefits;

            this.Revenue = RevenueCalculation();
        }

        public double RevenueCalculation()
        {
            Revenue = 19 * NumAdultZones * NumAdults +
                      9.5 * NumChildrenZones * NumChildrens +
                      5 * NumEnjoyBenefitsZones * NumEnjoyBenefits;
            return Revenue;
        }
        public void PrintRevenue()
        {
            Console.WriteLine($"{Tipe} : {Revenue}");
        }
    }
}
