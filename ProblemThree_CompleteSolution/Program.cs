using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProblemThree_CompleteSolution_BL;
namespace ProblemThree_CompleteSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            //SampleCodeToTestYourClassImplementation
            var organicPriceDict = new Dictionary<int, double>();
            //Key 1 for first product
            organicPriceDict.Add(1, 234.10);
            //Key 2 for second product
            organicPriceDict.Add(2, 100.100);
            var gosObj = new GourmetOrganicShop(1, "Non Polished Tur Dal", organicPriceDict);
            var gosTwoObj = new GourmetOrganicShop(2, "Non Polished Tur Dal", organicPriceDict);
            int quantityToBuy = 2;
            int quantityInGrams = 200;
            Console.WriteLine("The total cost for {0} packets of {1} is {2}/- INR", quantityToBuy,gosObj.ItemName,gosObj.PayPerPiece(quantityToBuy));
            Console.WriteLine("The total cost for {0} grams of {1} is {2}/- INR", quantityInGrams, gosTwoObj.ItemName, gosTwoObj.PayPerPiece(quantityToBuy));

           
            var coffeePriceDict = new Dictionary<int, double>();
            //Key 1 for first product
            coffeePriceDict.Add(1, 400.40);
            //Key 2 for second product
            coffeePriceDict.Add(2, 250.50);
            var coffObj = new GourmetCoffeeShop(1, "Arabica Coffee Powder Pre-Packed Container", coffeePriceDict);
            var coffTwoObj = new GourmetOrganicShop(2, "Arabica Coffee Poweder", organicPriceDict);
            int quantityToBuyCoffee = 2;
            int quantityInGramsCoffee = 200;
            Console.WriteLine("The total cost for {0} packets of {1} is {2}/- INR", quantityToBuyCoffee, coffObj.ItemName, coffObj.PayPerPiece(quantityToBuy));
            Console.WriteLine("The total cost for {0} grams of {1} is {2}/- INR", quantityInGramsCoffee, coffTwoObj.ItemName, coffTwoObj.PayPerPiece(quantityToBuy));

        }
    }
}
