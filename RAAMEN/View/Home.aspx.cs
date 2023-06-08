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
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if(Session["Username"] == null)
                {
                    Response.Redirect("LogIn.aspx");
                }
            }
            string RoleName = UserController.getUserRoleName(Session["Username"].ToString(), Session["Password"].ToString());
            RoleLbl.Text = RoleName;
            CustomerGV.DataSource = UserController.getRoleData(1);
            CustomerGV.DataBind();
            StaffGV.DataSource = UserController.getRoleData(2);
            StaffGV.DataBind();
            if (RoleName.Equals("Buyer"))
            {
                CustomerLbl.Visible = false;
                CustomerGV.Visible = false;
                StaffLbl.Visible = false;
                StaffGV.Visible = false;
            }
            if (RoleName.Equals("Staff"))
            {
                StaffLbl.Visible = false;
                StaffGV.Visible = false;
            }
        }
    }
}