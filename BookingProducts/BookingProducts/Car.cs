using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingProducts
{
    class Car : Iproduct
    {
        public void Book()
        {
            Console.WriteLine("Car Booked");
        }

        public string GetTypeOfProduct()
        {
            return "car";
        }

        public void Save()
        {
            Console.WriteLine("Car saved");
        }
    }
}
