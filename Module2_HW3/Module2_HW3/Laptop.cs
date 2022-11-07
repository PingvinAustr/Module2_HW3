using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_HW3
{
    public class Laptop : Computer
    {
        public Laptop(string name, string brand, int power, int price, string series, double screenSize)
            : base(name, brand, power, price, series)
        {
            ScreenSize = screenSize;
        }

        public double ScreenSize { get; set; }

        public override void SimulateWork()
        {
            Console.WriteLine("Laptop is working");
        }
    }
}
