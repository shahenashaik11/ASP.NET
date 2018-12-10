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
    public partial class Report : System.Web.UI.Page
    {
        string con= ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
       
            protected void Page_Load(object sender, EventArgs e)
            {
                if (!IsPostBack)
                {
                    BindGridView();
                }
            }
     

        public void BindGridView()
            {
                SqlConnection conn = new SqlConnection(con);
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * from UserEntry", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                GridView1.DataSource = reader;
                GridView1.DataBind();
                conn.Close();
            }

            protected void btnGetData_Click(object sender, EventArgs e)
            {
                SqlConnection conn = new SqlConnection(con);
                conn.Open();
                var FromDate = txtFromDate.Text;
                var ToDate = txtToDate.Text;
                SqlCommand cmd = new SqlCommand("ExtractDate", conn);
                cmd.Parameters.Add(new SqlParameter("@FromDate", FromDate));
                cmd.Parameters.Add(new SqlParameter("@ToDate", ToDate));
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = cmd.ExecuteReader();
                GridView1.DataSource = reader;
                GridView1.DataBind();
                conn.Close();
            }

            protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
            {
                string GetUserID = (GridView1.SelectedRow.FindControl("lblUserID") as Label).Text;
                txtUserID.Text = GetUserID;
                var UserID = txtUserID.Text;

                SqlConnection conn = new SqlConnection(con);
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("GetEmailID", con);
                SqlCommand cmd = new SqlCommand();
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add(new SqlParameter("@UserID", UserID));
                DataSet ds = new DataSet();
                da.Fill(ds);
                GridView1.DataSource = ds;
                GridView1.DataBind();
                conn.Close();
            }
            protected void grdData_PageIndexChanging(object sender, GridViewPageEventArgs e)
            {
                GridView1.PageIndex = e.NewPageIndex;
                BindGridView();
            }

            protected void Button1_Click(object sender, EventArgs e)
            {
                var UserID = txtUserID.Text;

                SqlConnection conn = new SqlConnection(con);
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("GetEmailID", con);
                SqlCommand cmd = new SqlCommand();
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add(new SqlParameter("@UserID", UserID));
                DataSet ds = new DataSet();
                da.Fill(ds);
                GridView1.DataSource = ds;
                GridView1.DataBind();
                conn.Close();
            }
        }
    }
