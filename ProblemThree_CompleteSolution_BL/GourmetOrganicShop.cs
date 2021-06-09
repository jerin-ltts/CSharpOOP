using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemThree_CompleteSolution_BL
{
    public class GourmetOrganicShop : GourmetShop,ITaxCompute
    {
        public double TotalBillValue { get; set; }

        public GourmetOrganicShop(int iCode, string iName, Dictionary<int, double> iPrice):base(iCode, iName)
        {
            ItemPrice = iPrice;
        }

        public override double PayPerPiece(int quantity)
        {
            TotalBillValue = quantity * ItemPrice[ItemCode];
            return TotalBillValue;
        }
        public override double PayPerWeight(int weight)
        {
            TotalBillValue = weight * ItemPrice[ItemCode];
            return TotalBillValue;
        }
        public double TaxOnTotalBill()
        {
            return TotalBillValue*0.05;
        }
    }
}
