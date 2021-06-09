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

        public GourmetCoffeeShop(int iCode, string iName, Dictionary<int, double> iPrice)
        {
            ItemCode = iCode;
            ItemName = iName;
            ItemPrice = iPrice;
        }

        public override double PayPerPiece(int quantity)
        {
            TotalBillValue+=TotalBillValue;
            return quantity * ItemPrice[ItemCode];
        }
        public override double PayPerWeight(int weight)
        {
            TotalBillValue+=TotalBillValue;
            return weight * ItemPrice[ItemCode];
        }
        public double TaxOnTotalBill()
        {
            return TotalBillValue*0.1;
        }
    }
}
