using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Shopping
{
    class Cart : Icart
    {
        List<Cart> cartDB = new List<Cart>();
        public void addItem(Item itemList, int quantityRequire)
        {
            // item will add into cartDB 
             
        }
        public void removeItem(Item itemList, int quantityRequire)
        {
            // item will removed from cartDB
        }
    }
}
