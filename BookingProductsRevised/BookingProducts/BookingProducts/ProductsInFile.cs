using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingProducts
{
    class ProductsInFile : Irepository
    {
        public void AddProductDetails(Iproduct product,int totalFare)
        {
            string pathString = @"C:\ProductDetails.txt";
            
                using (StreamWriter sw = File.AppendText(pathString))
                {
                    sw.WriteLine("Product Type: " + product.ProductType);
                    sw.WriteLine("Product Name: "+ product.ProductName);
                    sw.WriteLine("Product Price: " + product.ProductPrice);
                    sw.WriteLine("Product Status: " + product.IsBooked);
                    sw.WriteLine("Product Fare: " + totalFare);
                }
          
        }

    }
}

