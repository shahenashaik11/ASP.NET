using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _23nov
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["USERNAME"] == null)
            {
                Label1.Text = "Welcome";
            }
            else
            { 
            
                Label1.Text = Convert.ToString(Session["USERNAME"]);
                }
        }
    }
}