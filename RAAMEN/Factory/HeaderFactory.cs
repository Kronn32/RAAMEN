using RAAMEN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAAMEN.Factory
{
    public class HeaderFactory
    {
        public static Header createHeader(int CustomerId, int StaffId, DateTime date)
        {
            Header header = new Header();
            header.CustomerId = CustomerId;
            header.StaffId = StaffId;
            header.Date = date;
            return header;
        }
    }
}