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
            List<string> usedUsernames = UserRepository.GetUsernames();
            if(UserController.createUser(Role, Username, Email, Gender, Password, ConfirmPassword, usedUsernames))
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
        public static User getUser(string Username, string Password)
        {
            return UserRepository.getUser(Username, Password);
        }
        public static bool updateUser(string Username, string Email, string Gender, string Password, string OldUsername, string OldPassword)
        {
            List<string> usedUsernames = UserRepository.GetUsernames();
            if (UserController.updateUser(Username, Email, Gender, Password, OldPassword, usedUsernames))
            {
                UserRepository.updateUser(Username, Email, Gender, OldUsername, OldPassword);
                return true;
            }
            return false;
        }
    }
}