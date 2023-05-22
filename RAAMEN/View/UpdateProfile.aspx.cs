using RAAMEN.Handler;
using RAAMEN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAAMEN.View
{
    public partial class UpdateProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string ids = Request.Cookies["id"].Value;
            int id = int.Parse(ids);
            User user = UserHandler.getUser(id);
            UsernameTxt.Text = user.Username;
            EmailTxt.Text = user.Email;
            PasswordTxt.Text = user.Password;
            if (user.Gender.Equals("Male"))
            {
                MaleBtn.Checked = true; ;
            }
            else
            {
                FemaleBtn.Checked = true;
            }
        }

        protected void UpdateBtn_Click(object sender, EventArgs e)
        {

        }
    }
}