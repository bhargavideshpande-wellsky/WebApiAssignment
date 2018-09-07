using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingProducts
{
    public interface Irepository
    {
        void AddProductDetails(Iproduct product, int totalFare);
        
    }
}
