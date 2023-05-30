using RAAMEN.Factory;
using RAAMEN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAAMEN.Repository
{
    public class RamenRepository
    {
        public static void insertRamen(int MeatId, string Name, string Broth, string Price)
        {
            DatabaseEntities db = new DatabaseEntities();
            Ramen ramen = RamenFactory.createRamen(MeatId, Name, Broth, Price);
            db.Ramen1.Add(ramen);
            db.SaveChanges();
        }
    }
}