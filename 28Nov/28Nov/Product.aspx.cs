using _28Nov.DAL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
            GridViewRow Row = GridView1.Rows[e.RowIndex];

            pd.Name = (Row.FindControl("TextBoxName") as TextBox).Text;

            ProductDAL productDAL = new ProductDAL();

            productDAL.UpdateProduct(product);

            GridView1.EditIndex = -1;

            BindGridView();
        }
    }





}


