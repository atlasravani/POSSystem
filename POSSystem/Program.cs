using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Dictionary<string, decimal> Products = new Dictionary<string, decimal>();
            Products.Add("A", 1.25m);
            Products.Add("B", 4.25m);
            Products.Add("C", 1.00m);
            Products.Add("D", 0.75m);
            Products.Add("OfferA", 3.00m);
            Products.Add("OfferC", 5.00m);
            Console.WriteLine("Enter your Products");
            string productsList = Console.ReadLine().ToString();
            decimal total = 0.00m;
            total = Calculations.POSCalculation(Products, productsList);
            Console.WriteLine("Your Bill for today is $" + total);
            Console.ReadKey();
        }
    }
}
