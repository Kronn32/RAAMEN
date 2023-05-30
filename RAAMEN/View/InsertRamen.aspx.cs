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

            StatusLbl.Text = RamenHandler.insertRamen(MeatId, Name, Broth, Price);
        }
    }
}