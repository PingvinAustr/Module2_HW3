using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_HW3
{
    internal static class OrderProvider
    {
        internal static void PrintOrderInfo(Order order)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nProducts in order:\nName: Brand: Power: Price:");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (Device device in order.ReturnOrderDevices())
            {
                Console.WriteLine(device.Name + " " + device.Brand + " " + device.Power + " " + device.Price + "$");
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Total price of order: " + order.ReturnOrderPrice() + "$");
            Console.WriteLine("Average power of devices in order: " + order.ReturnOrderPower());
            Console.ForegroundColor = ConsoleColor.White;
        }

        internal static void SortOrderItemsPriceAsc(Order order)
        {
            Device[] devices = new Device[order.ReturnOrderDevices().Length];
            Device[] devicesFilled = order.ReturnOrderDevices();
            int[] devicesPrices = new int[order.ReturnOrderDevices().Length];
            for (int i = 0; i < devicesFilled.Length; i++)
            {
                devicesPrices[i] = devicesFilled[i].Price;
            }

            int len = devicesFilled.Length;
            for (int i = 1; i < len; i++)
            {
                for (int j = 0; j < len - i; j++)
                {
                    if (devicesPrices[j] > devicesPrices[j + 1])
                    {
                        Swap<int>(ref devicesPrices[j], ref devicesPrices[j + 1]);
                        Swap<Device>(ref devicesFilled[j], ref devicesFilled[j + 1]);
                        /* var temp = devicesFilled[j];
                        devicesFilled[j] = devicesFilled[j + 1];
                        devicesFilled[j + 1] = temp;*/
                    }
                }
            }

            order.SetOrderProdcuts(devicesFilled);
        }

        // To swap items while sorting
        internal static void Swap<T>(ref T e1, ref T e2)
        {
            var temp = e1;
            e1 = e2;
            e2 = temp;
        }
    }
}
