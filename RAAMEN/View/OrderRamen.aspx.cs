using RAAMEN.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAAMEN.View
{
    public partial class OrderRamen : System.Web.UI.Page
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
            CartGV.DataSource = CartController.getCartItems();
            CartGV.DataBind();
        }

        protected void BuyCartBtn_Click(object sender, EventArgs e)
        {
            string username = Session["Username"].ToString();
            HeaderController.addHeader(username);
            DetailController.addDetail();
            CartController.clearCart();
            CartGV.DataSource = CartController.getCartItems();
            CartGV.DataBind();
        }

        protected void ClearCartBtn_Click(object sender, EventArgs e)
        {
            CartController.clearCart();
            CartGV.DataSource = CartController.getCartItems();
            CartGV.DataBind();
        }

        protected void RamenGV_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            GridViewRow row = RamenGV.Rows[e.NewSelectedIndex];
            int id = int.Parse(row.Cells[0].Text);
            CartController.addToCart(id);
            CartGV.DataSource = CartController.getCartItems();
            CartGV.DataBind();
        }

    }
}