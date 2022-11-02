using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_HW3
{
    public class Order
    {
        private Device[] _devices = new Device[100];

        private int _totalPrice;
        private double _avgPower;
        public Order(Device[] devices)
        {
            _devices = devices;
            int totalPower = 0;
            foreach (Device device in devices)
            {
                totalPower += device.Power;
                _totalPrice += device.Price;
            }

            _avgPower = (double)totalPower / devices.Length;
        }

        public Device[] ReturnOrderDevices()
        {
            return _devices;
        }

        public int ReturnOrderPrice()
        {
            return _totalPrice;
        }

        public double ReturnOrderPower()
        {
            return _avgPower;
        }

        public void SetOrderProdcuts(Device[] devices)
        {
            _devices = devices;
        }
    }
}
