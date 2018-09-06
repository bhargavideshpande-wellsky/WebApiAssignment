using System;
using System.Collections.Generic;
using System.Text;

namespace Shopping
{
    interface IcartOperation
    {
        void addItems(Products itemList);
        void removeItems(int itemNo);
        void showCart();
        void payment();
    }
}
