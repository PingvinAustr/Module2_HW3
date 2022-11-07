using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_HW3
{
    internal static class Starter
    {
        internal static void Run()
        {
            Device device = new Device("Device1", "Brand1", 120, 150);
            Computer computer = new Computer("Computer2", "Brand2", 140, 275, "Leopard Pro");
            Laptop laptop = new Laptop("Laptop3", "Brand3", 130, 125, "Leopard Pro", 17.6);
            GamingLaptop gamingLaptop = new GamingLaptop("GamingLaptop4", "Brand4", 110, 190, "Leopard Regular", 15.3);
            DesignLaptop designLaptop = new DesignLaptop("DesignLaptop5", "Brand5", 220, 150, "Leopard Omega", 15.3);
            Device[] devicesToOrder = new Device[5] { device, computer, laptop, gamingLaptop, designLaptop };

            Order order = new Order(devicesToOrder);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Order has been created");
            Console.ForegroundColor = ConsoleColor.White;
            OrderProvider.PrintOrderInfo(order);

            // Sorting order items per price ascending
            OrderProvider.SortOrderItemsPriceAsc(order);
            Console.WriteLine("\n\n-------------------------------------------------\nOrder items have been sorted per price ascending:");
            OrderProvider.PrintOrderInfo(order);

            // Search using extension methods
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\n-------------------------------------------------\nThe cheapest device from current order:");
            Console.ForegroundColor = ConsoleColor.White;
            Device cheapestDevice = order.FindOrderItemWithLowestPrice(order.ReturnOrderDevices());
            Console.WriteLine(cheapestDevice.Name + " " + cheapestDevice.Brand + " " + cheapestDevice.Power + " " + cheapestDevice.Price + "$");
        }
    }
}
