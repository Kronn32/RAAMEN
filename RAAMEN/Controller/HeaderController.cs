using RAAMEN.Handler;
using RAAMEN.Model;
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
        public static List<Header> getAllHeaders()
        {
            return HeaderHandler.getAllHeaders();
        }
        public static List<Header> getUserHeader(int CustomerId)
        {
            return HeaderHandler.getUserHeader(CustomerId);
        }
    }
}