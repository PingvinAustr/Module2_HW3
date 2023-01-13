using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_HW3
{
    public class Computer : Device
    {
        public Computer(string name, string brand, int power, int price, string series)
            : base(name, brand, power, price)
        {
            Series = series;
        }

        public string Series { get; set; }
        public override void SimulateWork()
        {
            Console.WriteLine("Computer is working");
        }
    }
}
