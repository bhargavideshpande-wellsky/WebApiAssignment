using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingProducts
{
    interface IFareStrategy
    {
         int CalculateFare(int totalFare);
    }
}
