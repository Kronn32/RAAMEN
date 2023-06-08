using RAAMEN.Handler;
using RAAMEN.Model;
using RAAMEN.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAAMEN.Controller
{
    public class UserController
    {
        private static bool between5And15Characters(string s)
        {
            if (s.Length >= 5 && s.Length <= 15)
            {
                return true;
            }
            return false;
        }
        private static bool containLettersAndSpaceOnly(string s)
        {
            if (s.All(c => Char.IsLetter(c) || c == ' '))
            {
                return true;
            }
            return false;
        }

        private static bool uniqueUsername(List<string> a, string s)
        {
            if (!a.Contains(s)){
                return true;
            }
            return false;
        }
        public static bool createUser(string Username, string Email, string Gender, string Password, string ConfirmPassword)
        {
            bool username = false;
            bool email = false;
            bool gender = false;
            bool pass = false;
            bool uniqueName = uniqueUsername(UserHandler.getUsernames(), Username);

            if (containLettersAndSpaceOnly(Username) && between5And15Characters(Username))
            {
                username = true;
            }

            if (Email.EndsWith(".com"))
            {
                email = true;
            }

            if (!Gender.Equals(""))
            {
                gender = true;
            }

            if (Password.Equals(ConfirmPassword))
            {
                pass = true;
            }

            if (username && email && gender && pass && uniqueName)
            {
                UserHandler.createUser(Username, Email, Gender, Password);
                return true;
            }

            return false;
        }
        public static bool logInUser(string Username, string Password)
        {
            if(!Username.Equals("") && !Password.Equals(""))
            {
                return UserHandler.logInUser(Username, Password);
            }
            return false;
        }
        public static bool updateUser(string Username, string Email, string Gender, string Password, string OldUsername, string OldPassword)
        {
            bool username = false;
            bool email = false;
            bool gender = false;
            bool password = false;
            bool uniqueName = uniqueUsername(UserHandler.getUsernames(), Username);

            if (between5And15Characters(Username) && containLettersAndSpaceOnly(Username))
            {
                username = true;
            }
            if (Email.EndsWith(".com"))
            {
                email = true;
            }
            if (!Gender.Equals(""))
            {
                gender = true;
            }
            if (Password.Equals(OldPassword))
            {
                password = true;
            }

            if(username && email && gender && password)
            {
                return UserHandler.updateUser(Username, Email, Gender, OldUsername, OldPassword);
            }
            return false;
        }
        public static User getUser(string Username, string Password)
        {
            return UserHandler.getUser(Username, Password);
        }
        public static int getUserRole(string Username, string Password)
        {
            return UserHandler.getUserRole(Username, Password);
        }
        public static string getUserRoleName(string Username, string Password)
        {
            return UserHandler.getUserRoleName(Username, Password);
        }
        public static List<User> getRoleData(int RoleId)
        {
            return UserHandler.getRoleData(RoleId);
        }
    }
}