using RAAMEN.Handler;
using RAAMEN.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAAMEN.View
{
    public partial class LogIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LogInBtn_Click(object sender, EventArgs e)
        {
            string Username = UsernameTxt.Text;
            string Password = PasswordTxt.Text;
            bool rememberMe = false;
            string id = UserHandler.getUserId(Username, Password);
            if (RememberMeCbx.Checked)
            {
                rememberMe = true;
            }

            if(UserHandler.logInUser(Username, Password, rememberMe)){
                if (rememberMe)
                {
                    HttpCookie userInfo = new HttpCookie("userInfo");
                    userInfo["id"] = id;
                    userInfo["Username"] = Username;
                    userInfo["Password"] = Password;
                    userInfo.Expires = DateTime.Now.AddDays(1);
                    Response.Cookies.Add(userInfo);
                }

                Response.Redirect("test.aspx");
            }
            else
            {
                StatusLbl.Text = "User Not Found";
            }
        }

        protected void RegisterBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }
    }
}