using RAAMEN.Factory;
using RAAMEN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAAMEN.Repository
{
    public class CartRepository
    {
        public static void addToCart(int HeaderId, int RamenId)
        {
            DatabaseEntities db = new DatabaseEntities();
            Cart c = CartFactory.createCartItem(HeaderId, RamenId, 1);
            db.Carts.Add(c);
            db.SaveChanges();
        }
        public static void increaseQuantity(int RamenId)
        {
            DatabaseEntities db = new DatabaseEntities();
            Cart c = db.Carts.Find(RamenId);
            c.Quantity++;
            db.SaveChanges();
        }
        public static bool findRamen(int RamenId)
        {
            DatabaseEntities db = new DatabaseEntities();
            Cart c = db.Carts.Find(RamenId);
            if(c != null)
            {
                return true;
            }
            return false;
        }
        public static List<Cart> getCartItems()
        {
            DatabaseEntities db = new DatabaseEntities();
            List<Cart> c = db.Carts.ToList();
            return c;
        }
        public static void clearCart()
        {
            DatabaseEntities db = new DatabaseEntities();
            foreach (Cart items in db.Carts)
            {
                db.Carts.Remove(items);
            }
            db.SaveChanges();
        }
    }
}