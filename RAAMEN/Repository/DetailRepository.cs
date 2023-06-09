using RAAMEN.Factory;
using RAAMEN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAAMEN.Repository
{
    public class DetailRepository
    {
        public static void addDetails(List<Cart> carts)
        {
            DatabaseEntities db = new DatabaseEntities();
            foreach(Cart item in carts)
            {
                Detail detail = DetailFactory.createDetail(item.HeaderId, item.RamenId, item.Quantity);
                db.Details.Add(detail);
            }
            db.SaveChanges();
        }
    }
}