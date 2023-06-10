using RAAMEN.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAAMEN.View
{
    public partial class History : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Username"] == null)
                {
                    Response.Redirect("LogIn.aspx");
                }
            }
            string username = Session["Username"].ToString();
            string password = Session["Password"].ToString();
            int roleId = UserController.getUserRole(username, password);
            if (roleId == 1)
            {
                HistoryGV.DataSource = HeaderController.getUserHeader(UserController.getUserId(username));
                HistoryGV.DataBind();
            }
            if(roleId == 3)
            {
                HistoryGV.DataSource = HeaderController.getAllHeaders();
                HistoryGV.DataBind();
            }
        }

        protected void HistoryGV_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            GridViewRow row = HistoryGV.Rows[e.NewSelectedIndex];
            int headerId = int.Parse(row.Cells[0].Text);
            Response.Redirect("TransactionDetail.aspx?ID=" + headerId);
        }
    }
}