using RAAMEN.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAAMEN.View
{
    public partial class TransactionDetail : System.Web.UI.Page
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
            int headerId = int.Parse(Request.QueryString["ID"]);
            DetailGV.DataSource = DetailController.getTrDetail(headerId);
            DetailGV.DataBind();
        }
    }
}