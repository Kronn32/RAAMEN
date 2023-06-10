using RAAMEN.Controller;
using RAAMEN.Model;
using RAAMEN.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAAMEN.Handler
{
    public class RamenHandler
    {
        public static bool insertRamen(int MeatId, string Name, string Broth, string Price)
        {
            RamenRepository.insertRamen(MeatId, Name, Broth, Price);
            return true;
        }
        public static List<Ramen> getRamens()
        {
            return RamenRepository.getRamens();
        }
        public static void deleteRamen(int id)
        {
            RamenRepository.deleteRamen(id);
        }
        public static bool updateRamen(int RamenId, int MeatId, string Name, string Broth, string Price)
        {
            RamenRepository.updateRamen(RamenId, MeatId, Name, Broth, Price);
            return true;
        }
    }
}