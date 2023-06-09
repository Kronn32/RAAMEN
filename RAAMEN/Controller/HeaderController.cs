using RAAMEN.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAAMEN.Controller
{
    public class HeaderController
    {
        public static void addHeader(string Username)
        {
            HeaderHandler.addHeader(Username);
        }
    }
}