using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _27nov
{
    public partial class Product : System.Web.UI.Page
    {
        ProductDal p = new ProductDal();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void insert_Click(object sender, EventArgs e)
        {
            p.Name = txtproductname.Text;
            if (!p.AddRecord())
            {
                Response.Write("Not Added");
            }
            else
            {
                Response.Write("Added Successfully");
            }
            

        }

        protected void delete_Click(object sender, EventArgs e)
        {
            p.Name = txtproductname.Text;
            if (!p.DeleteRecord())
            {
                Response.Write("Not Deleted");
            }
            else
            {
                Response.Write("Deleted successfully");
            }

        }

        protected void display_Click(object sender, EventArgs e)
        {
            //p.Name = txtparam.Text;
            p.SelectRecord();
            //lbldisplay.Text = p.Name;
            
        }

        protected void btnupdate_Click(object sender, EventArgs e)
        {
          //  p.UpdateRecord();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}