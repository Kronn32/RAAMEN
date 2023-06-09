using RAAMEN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAAMEN.Factory
{
    public class CartFactory
    {
        public static Cart createCartItem(int HeaderId, int RamenId, int Quantity)
        {
            Cart cart = new Cart();
            cart.HeaderId = HeaderId;
            cart.RamenId = RamenId;
            cart.Quantity = Quantity;
            return cart;
        }
    }
}