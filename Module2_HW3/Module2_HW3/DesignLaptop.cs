using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_HW3
{
    public class DesignLaptop : Laptop
    {
        public DesignLaptop(string name, string brand, int power, int price, string series, double screenSize)
            : base(name, brand, power, price, series, screenSize)
        {
        }

        public override void SimulateWork()
        {
            Console.WriteLine("DesignLaptop is working");
        }

        public void SimulateGaming()
        {
            Console.WriteLine("DesignLaptop is designing");
        }
    }
}
