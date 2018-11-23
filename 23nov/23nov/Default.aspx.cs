using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _23nov
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            //Response.Cookies["USERNAME"].Value = Convert.ToString(TextBox1.Text);
            //Response.Cookies["EMAIL"].Value = Convert.ToString(TextBox3.Text);
            Session["USERNAME"] = Convert.ToString(TextBox1.Text);
            //Session["EMAIL"] = Convert.ToString(TextBox3.Text);
            //Response.Cookies["USERNAME"].Expires = DateTime.Now.AddDays(1);

            //HttpCookie aCookie = new HttpCookie("lastVisit");
            //aCookie.Value = DateTime.Now.ToString();
            //aCookie.Expires = DateTime.Now.AddDays(1);
            //Response.Cookies.Add(aCookie);
          //  Response.Cookies["LASTVISIT"].Value=Convert.ToString( DateTime.Now.AddDays(1));
           

            Response.Redirect("UserDetails.aspx");

        }
       


        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}