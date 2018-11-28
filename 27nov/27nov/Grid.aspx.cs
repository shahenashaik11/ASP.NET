using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _27nov
{
    public partial class Grid : System.Web.UI.Page
    {
        public string con = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
       
        
            SqlConnection conn = new SqlConnection();
            if (!IsPostBack)
            {

                SqlDataAdapter sqlData = new SqlDataAdapter("select * from ProductDetails", con);
                DataSet dataset = new DataSet();

                DataTable Dt = new DataTable();
                sqlData.Fill(Dt);
                GridView1.DataSource = Dt;
                GridView1.DataBind();


            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
