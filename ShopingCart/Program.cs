using System;
using System.Collections.Generic;

namespace ShopingCart
{
    class Program
    {

        /*
         * 
         * With Jet Smart Cart the more items you buy, the more you save. The algorithm behind how this works is a bit complicated, and since it's your first day at Jet you decide to ask one of your co-workers for more information. In return, you offer to implement a new cart update algorithm for them. The update algorithm works like this:
            Whenever a new customer visits jet.com, their shopping cart is initially empty. Once the customer starts shopping, the cart can receive any of the following requests:
            add : <item_name>: the <item_name> item was added to the cart;
            remove : <item_name>: all <item_name> items were removed from the cart;
            quantity_upd : <item_name> : <value>: the <item_name> quantity in the cart was changed by <value>, which is an integer in the format +a or -a;
            checkout: the customer has paid and the cart is now empty.
            Given a list of requests in the formats described above, return the state of the cart after they have been processed. Elements in the cart should be returned in the order they were received.
         * 
         * Examp
         * requests = ["add : milk",
            "add : pickles",
            "remove : milk",
            "add : milk",
            "quantity_upd : pickles : +4"]
         * 
         * Result
         * shoppingCart(requests) = ["pickles : 5", "milk : 1"];
         * 
         * 
         * 
         * requests = ["add : rock",
            "add : paper",
            "add : scissors",
            "checkout",
            "add : golden medal"]
         * 
         * 
         * Result
         * shoppingCart(requests) = ["golden medal : 1"].
         * 
         * */
        static void Main(string[] args)
        {
            List<string> requests = new()
            {
                "add : milk",
                "add : pickles",
                "remove : milk",
                "add : milk",
                "quantity_upd : pickles : +4"
            };
            var responses = ShoppingCart(requests);
            Console.WriteLine("[");
            foreach (var res in responses)
            {
                Console.WriteLine(String.Format("\"{0}\"", res));

            }
            Console.WriteLine("]");
            Console.ReadLine();
        }

        private static List<string> ShoppingCart(List<string> requests)
        {
            var lstRes = new List<string>();
            var _arr = requests.ToArray();
            for (int i = 0; i < _arr.Length; i++)
            {

                var arrReq = _arr[i].Split(":");
                var type = arrReq[0];
                if (type.ToLower().Contains("add"))
                {
                    var name = arrReq[1].Trim();
                    lstRes.Add($"{name} : 1");
                    continue;
                }
                if (type.ToLower().Contains("remove"))
                {
                    var existProd = lstRes.Find(x => x.Contains(arrReq[1].Trim()));
                    lstRes.Remove(existProd);
                    continue;
                }
                if (type.ToLower().Contains("checkout"))
                {
                    lstRes.Clear();
                    continue;
                }
                if (type.ToLower().Contains("quantity_upd"))
                {
                    var productName = arrReq[1].Trim();
                    var quantityUpdate = arrReq[2].Trim();

                    var existIndex = lstRes.FindIndex(p => p.Contains(productName));
                    var oldProd = lstRes[existIndex];
                    var quantity = 0;

                    quantity = Convert.ToInt32(quantityUpdate) + Convert.ToInt32(oldProd.Split(" : ")[1]);

                    lstRes[existIndex] = $"{productName} : {quantity}";
                    continue;
                }
            }
            return lstRes;
        }
    }
}
