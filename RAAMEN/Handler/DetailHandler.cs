using RAAMEN.Model;
using RAAMEN.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAAMEN.Handler
{
    public class DetailHandler
    {
        public static void addDetails()
        {
            List<Cart> c = CartRepository.getCartItems();
            DetailRepository.addDetails(c);
        }
    }
}