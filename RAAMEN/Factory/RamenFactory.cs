using RAAMEN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAAMEN.Factory
{
    public class RamenFactory
    {
        public static Ramen createRamen(int MeatId, string Name, string Broth, string Price)
        {
            Ramen ramen = new Ramen();
            ramen.MeatId = MeatId;
            ramen.Name = Name;
            ramen.Broth = Broth;
            ramen.Price = Price;
            return ramen;
        }
    }
}