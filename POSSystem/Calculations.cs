using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace POSSystem
{
    class Calculations
    {
        public static decimal POSCalculation(Dictionary<string, decimal> Products, string selectedProducts)
        {
            decimal total = 0.00m;
            decimal sumA = 0.00m;
            decimal sumB = 0.00m;
            decimal sumC = 0.00m;
            decimal sumD = 0.00m;
            int offerCountA = 0;
            var productAcount = Regex.Matches(selectedProducts, "A").Count;
            var productBcount = Regex.Matches(selectedProducts, "B").Count;
            var productCcount = Regex.Matches(selectedProducts, "C").Count;
            var productDcount = Regex.Matches(selectedProducts, "D").Count;
            
            if (productAcount >= 3)
            {
                offerCountA = productAcount / 3;
                int remainingA = productAcount - (3 * offerCountA);
                sumA = (Products["OfferA"] * offerCountA) + (remainingA * Products["A"]);
            }
            else
            {
                sumA = productAcount * Products["A"];
            }
            sumB = productBcount * Products["B"];
            if (productCcount >= 6)
            {
                int offerCountC = productCcount / 6;
                int remainingC = productCcount - (6 * offerCountC);
                sumC = (Products["OfferC"] * offerCountC) + (remainingC * Products["C"]);

            }
            else
            {
                sumC = productCcount * Products["C"];
            }
            sumD = productDcount * Products["D"];
            total = sumA + sumB + sumC + sumD;
            return total;
        }
    }
}
