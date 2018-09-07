using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingProducts
{
    class CarFareStrategy : IFareStrategy
    {
        public  int CalculateFare(int totalFare)
        {
            return totalFare + 30;
        }
    }
}
