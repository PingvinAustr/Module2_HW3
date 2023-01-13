using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_HW3
{
    public interface IMechanism
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public int Power { get; set; }
        public int Price { get; set; }
    }
}
