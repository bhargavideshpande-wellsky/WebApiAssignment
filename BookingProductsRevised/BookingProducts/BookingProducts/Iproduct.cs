 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingProducts
{
    public interface Iproduct
    {
        string GetTypeOfProduct();
        void Save(Iproduct product, Irepository storageType, int fare);
        void Book(Iproduct product, Irepository storageType,int fare);
        string ProductType { get; set; }
        string ProductName { get; set; }
        int ProductPrice { get; set; }
        bool IsBooked { get; set; }
        int Fare { get; set; }
    }
}
