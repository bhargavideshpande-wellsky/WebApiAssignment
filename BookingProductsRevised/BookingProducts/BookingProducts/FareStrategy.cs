using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingProducts
{
    class FareStrategy
    {
        public IFareStrategy GetFare(string productName)
        {
            switch (productName)
            {
                case "car": return new CarFareStrategy();
                case "activity": return new ActivityFareStrategy() ;
                case "hotel": return new HotelFareStrategy();
                case "air": return new AirFareStrategy();
                default: return new CarFareStrategy();
            }

        }
    }
}
