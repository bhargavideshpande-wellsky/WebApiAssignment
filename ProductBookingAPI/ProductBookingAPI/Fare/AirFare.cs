using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductBookingAPI.Fare
{
    public class AirFare : IFare
    {
        public int GetActualFare(int fare)
        {
            return (fare + 40);
        }
    }
}