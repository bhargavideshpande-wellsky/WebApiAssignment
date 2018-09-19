using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingProducts
{
    class Air : Iproduct
    {
        public  void Book()
        {
            Console.WriteLine("Flight Booked");
        }

        public string GetTypeOfProduct()
        {
            return "Air";
        }

        public void Save()
        {
            Console.WriteLine("Flight Saved");
        }
    }
}
