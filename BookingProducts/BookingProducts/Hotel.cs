using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingProducts
{
    class Hotel:Iproduct
    {
        public  void Save()
        {
            Console.WriteLine("Hotel Saved");
        }

        public  void Book()
        {
            Console.WriteLine("Booked Hotel");
        }

        public string GetTypeOfProduct()
        {
            return "Hotel";
        }
    }
}
