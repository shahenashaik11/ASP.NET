using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _21NOV
{
    public partial class _Default : Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("<br/>" + "PageLoad");
            //TextBox2.Text = "PageLoad";
            //Response.Write(TextBox2);
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {
            //Response.Write("<br/>" + "textbox");
            //TextBox2.Text = "PageLoad";
            //Response.Write(TextBox2);
        }

        protected override void OnPreLoad(EventArgs e)

        {
            Response.Write("<br/>" + "PreLoad");
           // TextBox2.Text = "Preload";
            //Response.Write(TextBox2);


        }
        protected override void OnPreRender(EventArgs e)

        {

            Response.Write("<br/>" + "PreRerender");

            TextBox4.Text = "PreRender";
            Response.Write(TextBox4);

        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            Response.Write("<br/>" + "Button Click");


            TextBox3.Text = TextBox2.Text;
            

        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {
            TextBox4.Text = "HELLO";
            Response.Write(TextBox4.Text);
        }
    }
}