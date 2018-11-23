using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _23nov
{
    public partial class UserDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox1.Text = Convert.ToString(Session["USERNAME"]);
            //TextBox1.Text = Convert.ToString(Request.Cookies["USERNAME"].Value);
            TextBox2.Text = Convert.ToString(Request.Cookies["EMAIL"].Value);
            TextBox3.Text = Convert.ToString(Request.Cookies["LASTVISIT"].Value);


        }
        


        

        protected void Button1_Click(object sender, EventArgs e)
        {
            


        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
        protected override void Render(HtmlTextWriter writer)
        {
            base.Render(writer);
            Response.Cookies["LASTVISIT"].Value = Convert.ToString(DateTime.Now);
        }



    }
}