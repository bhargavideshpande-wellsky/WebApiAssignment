using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping
{
    interface Icart
    {
        void addItem(Item itemList, int quantityRequire);
        void removeItem(Item itemList, int quantityRequire);
    }
}
