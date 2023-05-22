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
            int Role = 0;
            string Username = UsernameTxt.Text;
            string Email = EmailTxt.Text;
            string Gender = "";
            string Password = PasswordTxt.Text;
            string ConfirmPassword = ConfirmPasswordTxt.Text;
            if (BuyerBtn.Checked)
            {
                Role = 1;
            }
            else if (StaffBtn.Checked)
            {
                Role = 2;
            }
            else if (AdminBtn.Checked)
            {
                Role = 3;
            }

            if (MaleBtn.Checked)
            {
                Gender = "Male";
            }
            else if (FemaleBtn.Checked)
            {
                Gender = "Female";
            }

            if(UserHandler.createUser(Role, Username, Email, Gender, Password, ConfirmPassword))
            {
                Response.Redirect("test.aspx");
            }
            else
            {
                StatusLbl.Text = "Invalid input(s)";
            }
        }
    }
}