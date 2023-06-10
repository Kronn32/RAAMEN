using RAAMEN.Model;
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
        public static List<Header> getAllHeaders()
        {
            return HeaderRepository.getAllHeaders();
        }
        public static List<Header> getUserHeader(int CustomerId)
        {
            return HeaderRepository.getUserHeader(CustomerId);
        }
    }
}