using System;
using System.Collections.Generic;

namespace Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            CartOperations obj = new CartOperations();
            List<Products> itemList = new List<Products>();
            itemList.Add(new Products {ItemId=1,ItemName="Shoes",ItemPrice=2000 });
            int i=-1;
            do
            {
                Console.WriteLine("Enter Choice\n1.Add items\n2.Remove items\n3.Show cart\n4.Show Bill\n5.Exit");
                int ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Enter itemId which you want to purchase:");
                        int id = Convert.ToInt32(Console.ReadLine());
                        if (id == itemList[0].ItemId)
                        {
                            obj.addItems(itemList[0]);
                        }
                        else
                        {
                            Console.WriteLine("Please check your input");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter itemNo which you wnat to delete:");
                        int itemNo = Convert.ToInt32(Console.ReadLine());
                        obj.removeItems(itemNo);
                        break;
                    case 3:
                        obj.showCart();
                        break;
                    case 4:
                        obj.payment();
                        break;
                    case 5:
                        i = 0;
                        break;
                }

            } while (i == -1);
           
        }
    }
}
