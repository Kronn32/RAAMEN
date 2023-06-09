using RAAMEN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAAMEN.Factory
{
    public class DetailFactory
    {
        public static Detail createDetail(int HeaderId, int RamenId, int Quantity)
        {
            Detail detail = new Detail();
            detail.HeaderId = HeaderId;
            detail.RamenId = RamenId;
            detail.Quantity = Quantity;
            return detail;
        }
    }
}