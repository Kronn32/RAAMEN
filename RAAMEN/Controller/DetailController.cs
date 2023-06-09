using RAAMEN.Handler;
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
    }
}