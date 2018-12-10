using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineExam
{
    public partial class StudentAppeared : System.Web.UI.Page
    {
        string QueryString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                //BindGridView();
            }

        }
        public void BindGridView()
        {

            SqlConnection conn = new SqlConnection(QueryString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from UserEntry",conn);
            SqlDataReader reader = cmd.ExecuteReader();
            GridView1.DataSource = reader;
            GridView1.DataBind();
            conn.Close();

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBox1.Text = GridView1.SelectedRow.Cells[0].Text;
            BindGridView();


        }

        protected void btnDate_Click(object sender, EventArgs e)

        {

            var FromDate = txtFromDate.Text;
            var ToDate = txtToDate.Text;
            DataSet data = new DataSet();
            using (SqlConnection connection = new SqlConnection(QueryString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("ExtractDate", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@FromDate", FromDate));
                command.Parameters.Add(new SqlParameter("@ToDate", ToDate));
                command.ExecuteNonQuery();
                connection.Close();
                BindGridView();



            }
        }

        protected void btnReport_Click(object sender, EventArgs e)
        {
            //extBox1.Text = GridView1.SelectedRow.Cells[1].Text;
        }
    }
}