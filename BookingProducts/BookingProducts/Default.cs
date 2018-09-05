using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingProducts
{
    class Default : Iproduct
    {
        public void Book()
        {
            Console.WriteLine("Wrong Credential");
        }

        public string GetTypeOfProduct()
        {
            return "Wrong Credential";
        }

        public void Save()
        {
            Console.WriteLine("Wrong Credential");
        }
    }
}
