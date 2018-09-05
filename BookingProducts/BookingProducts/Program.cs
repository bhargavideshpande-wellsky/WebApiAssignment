using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingProducts
{
    class Program
    {
        
        static void Main(string[] args)
        {
            IproductFactory obj = new IproductFactory();
            Console.WriteLine("Enter Product which you want to book or save:");
            string productName = Console.ReadLine();
            Iproduct prod = obj. GetProduct(productName);
            string product = prod.GetTypeOfProduct();
            Console.WriteLine(product);
            prod.Book();
            prod.Save();
            Console.ReadKey();
        }
    }
}
