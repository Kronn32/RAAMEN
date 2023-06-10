using RAAMEN.Handler;
using RAAMEN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAAMEN.Controller
{
    public class DetailController
    {
        public static void addDetail()
        {
            DetailHandler.addDetails();
        }
        public static List<Detail> getTrDetail(int HeaderId)
        {
            return DetailHandler.getTrDetail(HeaderId);
        }
    }
}