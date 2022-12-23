using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop3_1.Transports
{
    public class Bus : Transport, ITransport
    {
        public override string Tipe { get { return "Bus"; } }
        public override double Revenue { get; set; }
        public double NumAdults { get; }
        public double NumStudents { get; }
        public double NumPupils { get; }
        public double NumEnjoyBenefits { get; }

        public Bus(int numberAdults, int numberStudents, 
                   int numberPupils, int numberEnjoyBenefits)
        {
            this.NumAdults = numberAdults;
            this.NumStudents = numberStudents;
            this.NumPupils = numberPupils;
            this.NumEnjoyBenefits = numberEnjoyBenefits;

            this.Revenue = RevenueCalculation();
        }
        public double RevenueCalculation()
        {
            Revenue = 25 * NumAdults + 18 * NumStudents +
                      15 * NumPupils + 15 * NumEnjoyBenefits;
            return Revenue;
        }
        public void PrintRevenue()
        {
            Console.WriteLine($"{Tipe} : {Revenue}");
        }
    }
}
