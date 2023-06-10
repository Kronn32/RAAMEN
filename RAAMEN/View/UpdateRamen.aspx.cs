using RAAMEN.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAAMEN.View
{
    public partial class UpdateRamen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void BackBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("ManageRamen.aspx");
        }

        protected void UpdateBtn_Click(object sender, EventArgs e)
        {
            int RamenId = int.Parse(RamenTxt.Text);
            int MeatId = 0;
            MeatId = int.Parse(MeatDDL.SelectedValue);
            string Name = NameTxt.Text;
            string Broth = BrothTxt.Text;
            string Price = PriceTxt.Text;

            bool StatusRamen = RamenController.updateRamen(RamenId, MeatId, Name, Broth, Price);
            if (StatusRamen == true)
            {
                StatusLbl.Text = "Ramen Updated!";
            }
            else
            {
                StatusLbl.Text = "Ramen Failed to be Updated!";
            }
        }
    }
}