using RAAMEN.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAAMEN.Controller
{
    public class RamenController
    {
        public static bool insertRamen(int MeatId, string Name, string Broth, string Price)
        {
            bool meatid = false;
            bool name = false;
            bool broth = false;
            bool price = false;

            if(MeatId > 0 && MeatId < 6)
            {
                meatid = true;
            }
            if (Name.Contains("Ramen"))
            {
                name = true;
            }
            if (!Broth.Equals(""))
            {
                broth = true;
            }
            if(int.Parse(Price) >= 3000)
            {
                price = true;
            }

            if(meatid && name && broth && price)
            {
                RamenHandler.insertRamen(MeatId, Name, Broth, Price);
            }
            return false;
        }
    }
}