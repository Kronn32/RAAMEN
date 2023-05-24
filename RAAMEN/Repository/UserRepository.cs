using RAAMEN.Factory;
using RAAMEN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAAMEN.Repository
{
    public class UserRepository
    {
        public static void createUser(int Role, string Username, string Email, string Gender, string Password)
        {
            DatabaseEntities db = new DatabaseEntities();
            User user = UserFactory.createUser(Role, Username, Email, Gender, Password);
            db.Users.Add(user);
            db.SaveChanges();
        }
        public static List<string> GetUsernames()
        {
            DatabaseEntities db = new DatabaseEntities();
            List<string> users = (from x in db.Users select x.Username).ToList();
            return users;
        } 

        public static bool findUser(string Username, string Password)
        {
            DatabaseEntities db = new DatabaseEntities();
            User u = (from x in db.Users where x.Username.Equals(Username) && x.Password.Equals(Password) select x).FirstOrDefault();
            if(u != null)
            {
                return true;
            }
            return false;
        }
        public static User getUser(string Username, string Password)
        {
            DatabaseEntities db = new DatabaseEntities();
            User user = (from x in db.Users where x.Username.Equals(Username) && x.Password.Equals(Password) select x).FirstOrDefault();
            return user;
        }

        public static void updateUser(string Username, string Email, string Gender, string OldUsername, string OldPassword)
        {
            DatabaseEntities db = new DatabaseEntities();
            User user = (from x in db.Users where x.Username.Equals(OldUsername) && x.Password.Equals(OldPassword) select x).FirstOrDefault();
            if(user != null)
            {
                user.Username = Username;
                user.Email = Email;
                user.Gender = Gender;
                db.SaveChanges();
            }
        }
    }
}