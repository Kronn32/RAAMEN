using RAAMEN.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAAMEN.Handler
{
    public class HeaderHandler
    {
        public static void addHeader(string Username)
        {
            int CustomerId = UserRepository.getUserId(Username);
            int StaffId = UserRepository.getAStaffId();
            HeaderRepository.addHeader(CustomerId, StaffId);
        }
    }
}