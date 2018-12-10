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
    public partial class ExamPage : System.Web.UI.Page
    {
        string QueryString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        public object True { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        { 
            if (!IsPostBack)
            {
                BindGridView();
                
            }
           
        }

        
        protected void GridView3_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            var CheckBox5 = (GridView3.Rows[e.RowIndex].FindControl("CheckBox5") as CheckBox);
            var CheckBox6 = (GridView3.Rows[e.RowIndex].FindControl("CheckBox6") as CheckBox);
            var CheckBox7 = (GridView3.Rows[e.RowIndex].FindControl("CheckBox7") as CheckBox);
            var CheckBox8 = (GridView3.Rows[e.RowIndex].FindControl("CheckBox8") as CheckBox);
         

            SqlConnection connection = new SqlConnection(QueryString);
            connection.Open();
            SqlCommand command = new SqlCommand("GetAnswer", connection);
            command.CommandType = CommandType.StoredProcedure;

            if (CheckBox5.Checked)
            {
                command.Parameters.Add(new SqlParameter("@Option1", CheckBox5.Text)); ;
            }
            if(!CheckBox5.Checked)
            {
                command.Parameters.Add(new SqlParameter("@Option1", ","));
            }
            if (CheckBox6.Checked)
            {
                command.Parameters.Add(new SqlParameter("@Option2", CheckBox6.Text));
            }
            if(!CheckBox6.Checked)
            {
                command.Parameters.Add(new SqlParameter("@Option2", ","));
            }
            if (CheckBox7.Checked)
            {
                command.Parameters.Add(new SqlParameter("@Option3", CheckBox7.Text));
            }
            if(!CheckBox7.Checked)
            {
                command.Parameters.Add(new SqlParameter("@Option3", ","));
            }
            if(!CheckBox8.Checked)
            {
                command.Parameters.Add(new SqlParameter("@Option4", ","));
            }
            if(CheckBox8.Checked)
            {
                command.Parameters.Add(new SqlParameter("@Option4", CheckBox8.Text));
            }

            command.ExecuteNonQuery();
            connection.Close();

            GridView3.EditIndex = -1;
            BindGridView();


        }

        public DataSet BindGridView()
        {

            string Query = "select * from OnlineExam where category ='appti'";

            DataSet data = new DataSet();
            using (SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=OnlineExamination;Integrated Security=True;Connect Timeout=15;Encrypt=False;Packet Size=4096"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SelectCategory", connection);
                command.CommandType = CommandType.StoredProcedure;
                
                    // int p = this.DropDownList1.Items.Count;
                    // for (int i = 0; i<p; i++)
                    //  {
                    //if (DropDownList1.SelectedIndex == i)
                    //{
                    //    command.Parameters.AddWithValue("@Category", DropDownList1.SelectedValue);
                    //}
                    //  }



               SqlDataAdapter adapter = new SqlDataAdapter(Query, connection);
                adapter.Fill(data);
                GridView3.DataSource = data;
                GridView3.DataBind();
              

                return data;
            }
        }
        protected void GridView3_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView3.EditIndex = e.NewEditIndex;
            BindGridView();
           
         }

         protected void GridView4_SelectedIndexChanged(object sender, EventArgs e)
         {
            

         }

         protected void Button1_Click(object sender, EventArgs e)
         {
            
         }
    }
       

    }

    
