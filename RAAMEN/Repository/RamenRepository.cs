﻿using RAAMEN.Factory;
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
        public static List<Ramen> getRamens()
        {
            DatabaseEntities db = new DatabaseEntities();
            List<Ramen> ramens = db.Ramen1.ToList();
            return ramens;
        }
        public static void deleteRamen(int id)
        {
            DatabaseEntities db = new DatabaseEntities();
            Ramen ramen = db.Ramen1.Find(id);
            db.Ramen1.Remove(ramen);
            db.SaveChanges();
        }
    }
}