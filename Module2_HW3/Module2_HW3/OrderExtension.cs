using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_HW3
{
    public static class OrderExtension
    {
        public static Device FindOrderItemWithLowestPrice(this Order order, Device[] devices)
        {
            int minPrice = int.MaxValue;
            Device cheapestDevice = null;

            foreach (Device deviceLoc in devices)
            {
                if (deviceLoc.Price < minPrice)
                {
                    minPrice = deviceLoc.Price;
                    cheapestDevice = deviceLoc;
                }
            }

            return cheapestDevice;
        }
    }
}
