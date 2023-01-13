using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_HW3
{
    public class Device : IMechanism
    {
        public Device(string name, string brand, int power, int price)
        {
            Name = name;
            Brand = brand;
            Power = power;
            Price = price;
        }

        public string Name { get; set; }
        public string Brand { get; set; }
        public int Power { get; set; }
        public int Price { get; set; }

        public virtual void SimulateWork()
        {
            Console.WriteLine("Device is working");
        }
    }
}
