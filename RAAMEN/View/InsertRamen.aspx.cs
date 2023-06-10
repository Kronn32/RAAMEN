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
    public partial class InsertRamen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void InsertBtn_Click(object sender, EventArgs e)
        {
            int MeatId = 0;
            MeatId = int.Parse(MeatDDL.SelectedValue);
            string Name = NameTxt.Text;
            string Broth = BrothTxt.Text;
            string Price = PriceTxt.Text;

            bool StatusRamen = RamenController.insertRamen(MeatId, Name, Broth, Price);
            if(StatusRamen == true)
            {
                StatusLbl.Text = "Ramen Added!";
            }
            else
            {
                StatusLbl.Text = "Ramen Failed to be Added!";
            }
        }

        protected void BackBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("ManageRamen.aspx");
        }
    }
}