using RAAMEN.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAAMEN.View
{
    public partial class ManageRamen : System.Web.UI.Page
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
            RamenGV.DataSource = RamenController.getRamens();
            RamenGV.DataBind();
        }

        protected void InsertBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertRamen.aspx");
        }

        protected void RamenGV_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = RamenGV.Rows[e.RowIndex];
            int id = int.Parse(row.Cells[0].Text);
            RamenController.deleteRamen(id);
            RamenGV.DataSource = RamenController.getRamens();
            RamenGV.DataBind();
        }

        protected void RamenGV_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = RamenGV.Rows[e.NewEditIndex];
            string id = row.Cells[0].Text.ToString();
            Response.Redirect("UpdateRamen.aspx?id=" + id);
        }
    }
}