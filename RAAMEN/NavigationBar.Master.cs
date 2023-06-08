using RAAMEN.Controller;
using RAAMEN.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAAMEN
{
    public partial class NavigationBar : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int Roleid = UserController.getUserRole(Session["Username"].ToString(), Session["Password"].ToString());
            if(Roleid == 1)
            {
                HomeNavbar.Visible = false;
                ManageRamenNavbar.Visible = false;
                OrderQueueNavbar.Visible = false;
                ReportNavbar.Visible = false;
            }
            if(Roleid == 2)
            {
                OrderRamenNavbar.Visible = false;
                HistoryNavbar.Visible = false;
                ReportNavbar.Visible = false;
            }
            if(Roleid == 3)
            {
                HomeNavbar.Visible = false;
                OrderRamenNavbar.Visible = false;
            }
        }
    }
}