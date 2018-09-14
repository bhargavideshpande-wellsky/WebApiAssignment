using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductBookingAPI.Fare
{
    public interface IFare
    {
        int GetActualFare(int fare);
    }
}
