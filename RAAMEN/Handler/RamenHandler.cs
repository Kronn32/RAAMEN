using RAAMEN.Controller;
using RAAMEN.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAAMEN.Handler
{
    public class RamenHandler
    {
        public static string insertRamen(int MeatId, string Name, string Broth, string Price)
        {
            if(RamenController.insertRamen(MeatId, Name, Broth, Price))
            {
                RamenRepository.insertRamen(MeatId, Name, Broth, Price);
                return "Ramen Added";
            }
            return "Invalid input(s)";
        }
    }
}