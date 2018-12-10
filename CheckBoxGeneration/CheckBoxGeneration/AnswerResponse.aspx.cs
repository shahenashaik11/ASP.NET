using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CheckBoxGeneration
{
    public partial class AnswerResponse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
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
               
                return data;
            }
        }
    }
}