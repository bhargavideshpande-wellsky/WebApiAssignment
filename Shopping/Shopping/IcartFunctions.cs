using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping
{
    interface IcartFunctions
    {
       
        void showCart();
        void buyNow(CartItems cartDB);

    }
}
