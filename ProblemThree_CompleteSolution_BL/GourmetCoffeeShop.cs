using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemThree_CompleteSolution_BL
{
    public class GourmetCoffeeShop : GourmetShop, ITaxCompute
    {
        public double TotalBillValue { get; set; }

        public GourmetCoffeeShop(int iCode, string iName, Dictionary<int, double> iPrice):base(iCode,iName )
        {
            ItemPrice = iPrice;
        }

        public override double PayPerPiece(int quantity)
        {
            double price;
            price = quantity * ItemPrice[ItemCode];
            return price;
        }
        public override double PayPerWeight(int weight)
        {
            double price;
            price = weight * ItemPrice[ItemCode];
            return price;
        }
        public double TaxOnTotalBill()
        {
            return TotalBillValue*0.1;
        }
    }
}
