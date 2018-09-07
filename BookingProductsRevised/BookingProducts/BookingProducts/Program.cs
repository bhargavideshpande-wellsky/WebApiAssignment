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
            productFactory obj = new productFactory();
            Repository obj1 = new Repository();
            FareStrategy obj2 = new FareStrategy();
            Console.WriteLine("Enter Product which you want to book or save [eg: car,air,activity,hotel]");
            string productName = Console.ReadLine();
            Iproduct prod = obj.GetProduct(productName);

            string product = prod.GetTypeOfProduct();

            Console.WriteLine("Enter the storage type [eg: file,database]");
            string storageType = Console.ReadLine();
            Irepository storage = obj1.GetStorageType(storageType);

            IFareStrategy fareOfType = obj2.GetFare(productName);
            
            Console.WriteLine("Enter your choice\n1.save "+product+"\n2.Book "+product);
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    prod.Save(prod, storage, fareOfType.CalculateFare(prod.Fare));
                    break;
                case 2:
                    prod.Book(prod,storage, fareOfType.CalculateFare(prod.Fare));
                    break;

            }
           
        }
    }
}
