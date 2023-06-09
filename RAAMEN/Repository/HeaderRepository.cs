using RAAMEN.Factory;
using RAAMEN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAAMEN.Repository
{
    public class HeaderRepository
    {
        public static int generateHeaderId()
        {
            DatabaseEntities db = new DatabaseEntities();
            Header header = (from h in db.Headers orderby h.Id descending select h).FirstOrDefault();
            if(header == null)
            {
                return 1;
            }
            int id = header.Id;
            return id + 1;
        }
        public static void addHeader(int CustomerId, int StaffId)
        {
            DatabaseEntities db = new DatabaseEntities();
            Header header = HeaderFactory.createHeader(CustomerId, StaffId, DateTime.Today);
            db.Headers.Add(header);
            db.SaveChanges();
        }
    }
}