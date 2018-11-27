using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _26nov
{
    public partial class Product : System.Web.UI.Page
    {
        ProductDal p1 = new ProductDal();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            p1.Name = txtproduct.Text;
            
            if(!p1.AddRecord())
            {
                Response.Write("Not Added");
            }
            else
            {
                Response.Write("Added successfully");
            }
        }

        protected void Delete_Click(object sender, EventArgs e)
        {
            p1.Name = txtproduct.Text;
            if (!p1.DeleteRecord())
            {
                Response.Write("NOT DELETED");
            }
            else
            {
                Response.Write("Succefully Deleted");
            }
        }
    }
}