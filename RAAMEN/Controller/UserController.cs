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
        public static bool createUser(int Role, string Username, string Email, string Gender, string Password, string ConfirmPassword, List<string> usedUsernames)
        {
            bool role = false;
            bool username = false;
            bool email = false;
            bool gender = false;
            bool pass = false;
            bool uniqueName = uniqueUsername(usedUsernames, Username);

            if (Role != 0)
            {
                role = true;
            }
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

            if (role && username && email && gender && pass && uniqueName)
            {
                return true;
            }

            return false;
        }
        public static bool updateUser(string Username, string Email, string Gender, string Password, string OldPassword, List<string> usedUsernames)
        {
            bool username = false;
            bool email = false;
            bool gender = false;
            bool password = false;
            bool uniqueName = uniqueUsername(usedUsernames, Username);

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
                return true;
            }
            return false;
        }
    }
}