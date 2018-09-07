using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingProducts
{
    public class productFactory
    {
        public Iproduct GetProduct(string productName)
        {
            switch (productName)
            {
                case "car": return new Car();
                case "activity": return new Activity();
                case "hotel": return new Hotel();
                case "air": return new Air();
                default: return new Default();
            }
                
        }
    }
}
