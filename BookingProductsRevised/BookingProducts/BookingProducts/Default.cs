using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingProducts
{

    class Default : Iproduct
    {
        string productName = "";
        bool isBooked;
        int actualFare = 0;
        string productType = "";
        int productPrice = 0;
        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }
        public bool IsBooked
        {
            get { return isBooked; }
            set { isBooked = value; }
        }
        public int Fare
        {
            get { return actualFare; }
            set { actualFare = value; }
        }
        public string ProductType
        {
            get { return productType; }
            set { productType = value; }
        }
        public int ProductPrice
        {
            get { return productPrice; }
            set { productPrice = value; }
        }
        public void Save(Iproduct product, Irepository storageType,int fare)
        {
            Console.WriteLine("Wrong Credential");
            Console.ReadKey();
        }

        public void Book(Iproduct product, Irepository storageType,int fare)
        {
            Console.WriteLine("Wrong Credential");
            Console.ReadKey();
        }

        public string GetTypeOfProduct()
        {
            return "Wrong Credential";

        }

        
    }
}
