using RAAMEN.Handler;
using RAAMEN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAAMEN.Controller
{
    public class CartController
    {
        public static void addToCart(int RamenId)
        {
            CartHandler.addToCart(RamenId);
        }
        public static List<Cart> getCartItems()
        {
            return CartHandler.getCartItems();
        }
        public static void clearCart()
        {
            CartHandler.clearCart();
        }
    }
}