using RAAMEN.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAAMEN.View
{
    public partial class Update : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void UpdateBtn_Click(object sender, EventArgs e)
        {
            string Username = UsernameTxt.Text;
            string Email = EmailTxt.Text;
            string Gender = "";
            string Password = PasswordTxt.Text;
            string OldUsername = Session["Username"].ToString();
            string OldPassword = Session["Password"].ToString();

            if (MaleBtn.Checked)
            {
                Gender = "Male";
            }
            else if (FemaleBtn.Checked)
            {
                Gender = "Female";
            }

            if (UserHandler.updateUser(Username, Email, Gender, Password, OldUsername, OldPassword))
            {
                StatusLbl.Text = "Profile updated succesfully";
                Session["Username"] = Username;
                Session["Password"] = Password;
            }
            else
            {
                StatusLbl.Text = "Invalid input(s)";
            }
        }
    }
}