using RAAMEN.Model;
using RAAMEN.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAAMEN.Handler
{
    public class CartHandler
    {
        public static void addToCart(int RamenId)
        {
            if (CartRepository.findRamen(RamenId))
            {
                CartRepository.increaseQuantity(RamenId);
            }
            else
            {
                int HeaderId = HeaderRepository.generateHeaderId();
                CartRepository.addToCart(HeaderId, RamenId);
            }
        }
        public static List<Cart> getCartItems()
        {
            return CartRepository.getCartItems();
        }
        public static void clearCart()
        {
            CartRepository.clearCart();
        }
    }
}