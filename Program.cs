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
       }
    }
}
