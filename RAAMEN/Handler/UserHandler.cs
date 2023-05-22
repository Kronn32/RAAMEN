using RAAMEN.Controller;
using RAAMEN.Model;
using RAAMEN.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAAMEN.Handler
{
    public class UserHandler
    {
        public static bool createUser(int Role, string Username, string Email, string Gender, string Password, string ConfirmPassword)
        {
            if(UserController.createUser(Role, Username, Email, Gender, Password, ConfirmPassword))
            {
                UserRepository.createUser(Role, Username, Email, Gender, Password);
                return true;
            }
            return false;
        }

        public static bool logInUser(string Username, string Password, bool rememberMe)
        {
            if ((!Username.Equals("") && !Password.Equals("")) && UserRepository.findUser(Username, Password))
            {
                return true;
            }
            return false;
        }

        public static string getUserId(string Username, string Password)
        {
            return UserRepository.getUserId(Username, Password).ToString();
        }

        public static User getUser(int id)
        {
            return UserRepository.getUser(id);
        }
    }
}