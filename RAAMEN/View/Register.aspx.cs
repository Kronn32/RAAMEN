using RAAMEN.Controller;
using RAAMEN.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAAMEN.View
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RegisterBtn_Click(object sender, EventArgs e)
        {
            string Username = UsernameTxt.Text;
            string Email = EmailTxt.Text;
            string Gender = "";
            string Password = PasswordTxt.Text;
            string ConfirmPassword = ConfirmPasswordTxt.Text;

            if (MaleBtn.Checked)
            {
                Gender = "Male";
            }
            else if (FemaleBtn.Checked)
            {
                Gender = "Female";
            }

            if(UserController.createUser(Username, Email, Gender, Password, ConfirmPassword))
            {
                Response.Redirect("LogIn.aspx");
            }
            else
            {
                StatusLbl.Text = "Invalid input(s)";
            }
        }
    }
}