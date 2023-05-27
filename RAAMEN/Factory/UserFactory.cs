using RAAMEN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAAMEN.Factory
{
    public class UserFactory
    {
        public static User createUser(string Username, string Email, string Gender, string Password)
        {
            User user = new User();
            user.RoleId = 1;
            user.Username = Username;
            user.Email = Email;
            user.Gender = Gender;
            user.Password = Password;

            return user;
        }
    }
}