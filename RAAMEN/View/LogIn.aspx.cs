using RAAMEN.Controller;
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
            if (!IsPostBack)
            {
                if (Request.Cookies["userInfo"] != null)
                {
                    Response.Redirect("Home.aspx");
                }
            }
        }

        protected void LogInBtn_Click(object sender, EventArgs e)
        {
            string Username = UsernameTxt.Text;
            string Password = PasswordTxt.Text;
            bool rememberMe = false;
            if (RememberMeCbx.Checked)
            {
                rememberMe = true;
            }

            if(UserController.logInUser(Username, Password)){
                if (rememberMe)
                {
                    HttpCookie userInfo = new HttpCookie("userInfo");
                    userInfo["Username"] = Username;
                    userInfo["Password"] = Password;
                    userInfo.Expires = DateTime.Now.AddDays(1);
                    Response.Cookies.Add(userInfo);
                }
                Session["Username"] = Username;
                Session["Password"] = Password;
                Response.Redirect("Home.aspx");
            }
            else
            {
                StatusLbl.Text = "Incorrect input";
            }
        }

        protected void RegisterBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }
    }
}