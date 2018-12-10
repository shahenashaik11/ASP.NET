using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CheckBoxGeneration
{
    public partial class CheckBox : System.Web.UI.Page
    {
        string QueryString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        public object True { get; private set; }
        public object DropDownList1 { get; private set; }
        public bool Checked { get; private set; }
        public SqlDbType Text { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                BindGridView();
            }
        }
        public DataSet BindGridView()
        {

            string Query = "select * from QuestionBank where ComponentID=1";

            DataSet data = new DataSet();
            using (SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=WebAuthentication;Integrated Security=True;Connect Timeout=15;Encrypt=False;Packet Size=4096"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("", connection);
                command.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(Query, connection);
                adapter.Fill(data);
                GridView1.DataSource = data;
                GridView1.DataBind();
                return data;
            }
        }
        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            BindGridView();

        }
        protected void GridView3_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            var chkOption1 = (GridView1.Rows[e.RowIndex].FindControl("chkOption1") as CheckBox);
            var chkOption2 = (GridView1.Rows[e.RowIndex].FindControl("chkOption2") as CheckBox);
            var chkOption3 = (GridView1.Rows[e.RowIndex].FindControl("chkOption3") as CheckBox);
            var chkOption4= (GridView1.Rows[e.RowIndex].FindControl("chkOption4") as CheckBox);


            SqlConnection connection = new SqlConnection(QueryString);
            connection.Open();
            SqlCommand command = new SqlCommand("GetAnswer", connection);
            command.CommandType = CommandType.StoredProcedure;

            if (chkOption1.Checked)
            {
                command.Parameters.Add(new SqlParameter("@Option1", chkOption1.Text));
            }
            if (!chkOption1.Checked)
            {
                command.Parameters.Add(new SqlParameter("@Option1", ","));
            }
            if (chkOption2.Checked)
            {
                command.Parameters.Add(new SqlParameter("@Option2", chkOption2.Text));
            }
            if (!chkOption2.Checked)
            {
                command.Parameters.Add(new SqlParameter("@Option2", ","));
            }
            if (chkOption3.Checked)
            {
                command.Parameters.Add(new SqlParameter("@Option3", chkOption3.Text));
            }
            if (!chkOption3.Checked)
            {
                command.Parameters.Add(new SqlParameter("@Option3", ","));
            }
            if (!chkOption4.Checked)
            {
                command.Parameters.Add(new SqlParameter("@Option4", ","));
            }
            if (chkOption4.Checked)
            {
                command.Parameters.Add(new SqlParameter("@Option4", chkOption4.Text));
            }

            command.ExecuteNonQuery();
            connection.Close();

            GridView1.EditIndex = -1;
            BindGridView();


        }


    }
}