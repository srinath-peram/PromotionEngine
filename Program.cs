using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    class Program
    {
        static void Main(string[] args)
        {
           List<Product> products = new List<Product>();

            Console.WriteLine("total number of orders");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("enter the type of product:A,B,C or D");
                string type = Console.ReadLine();
                Product p = new Product(type);
                products.Add(p);
            }

            int totalPrice = GetTotalPrice(products);
            Console.WriteLine(totalPrice);
            Console.ReadLine();
        }
       private static int GetTotalPrice(List<Product> products)
        {
            int counterofA = 0;
            int priceofA = 50;
            int counterofB = 0;
            int priceofB = 30;
            int CounterofC = 0;
            int priceofC = 20;
            int CounterofD = 0;
            int priceofD = 15;
           foreach (Product pr in products)
            {
                switch (pr.Id)
                {
                    case "A":
                    case "a":
                        counterofA += 1;
                        break;
                    case "B":
                    case "b":
                        counterofB += 1;
                        break;
                    case "C":
                    case "c":
                        CounterofC += 1;
                        break;
                    case "D":
                    case "d":
                        CounterofD += 1;
                        break;
                }
           }
            int totalPriceofA = (counterofA / 3) * 130 + (counterofA % 3 * priceofA);
            int totalPriceofB = (counterofB / 2) * 45 + (counterofB % 2 * priceofB);
            int totalPriceofC = (CounterofC * priceofC);
       }
    }
}
