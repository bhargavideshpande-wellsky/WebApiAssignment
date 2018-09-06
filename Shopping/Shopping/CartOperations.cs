using System;
using System.Collections.Generic;
using System.Text;

namespace Shopping
{
    class CartOperations : IcartOperation
    {
        List<CartList> cartDB = new List<CartList>();
        public void addItems(Products itemList)
        {
            cartDB.Add(new CartList {ItemName=itemList.ItemName,ItemPrice=itemList.ItemPrice});
            Console.WriteLine("Item Added Successfully to the cart!");
        }
        public void removeItems(int itemNo)
        {
            cartDB.Remove(cartDB[itemNo - 1]);
            Console.WriteLine("Item removed from the cart!");
        }    
        public void showCart()
        {
            if (cartDB.Count!=1)
            {
                Console.WriteLine("Your cart is empty!");
               
            }
            else
            {
                Console.WriteLine(cartDB[0].ItemName);
            }
        }
        public void payment()
        {
            if (cartDB.Count != 1)
            {
                Console.WriteLine("Your cart is empty!");
            }
            else
            {
                int sum = 0;
                sum = sum + cartDB[0].ItemPrice;
                Console.WriteLine("Your bill is " + sum);
                
            }
        }

    }
}
