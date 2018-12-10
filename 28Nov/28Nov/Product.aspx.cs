using _28Nov.DAL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using _28Nov;

namespace _28Nov
{
    public partial class Product : System.Web.UI.Page
    {
        public string connection = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection connectionn = new SqlConnection();
            if (!IsPostBack)
            {

               BindGridView();
            }
        }

        public void BindGridView()
        {
            ProductDAL product = new ProductDAL();
            GridView1.DataSource = product.GetProducts();
            GridView1.DataBind();
        }

        public void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            BindGridView();
        }


        public void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            Product product = new Product();
            ProductDetails pd = new ProductDetails();
            GridViewRow row = GridView1.Rows[e.RowIndex];
            pd.ID = Convert.ToInt16(GridView1.DataKeys[e.RowIndex].Values[0]);
            pd.Name = (row.FindControl("TextBoxName") as TextBox).Text;

            ProductDAL productdal = new ProductDAL();
            productdal.UpdateProduct(product);

            GridView1.EditIndex = -1;

            BindGridView();
        }
    }





}


