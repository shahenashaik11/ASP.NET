using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineExam
{
    public partial class Paging : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                LoadGridData();
        }
        private void LoadGridData()
        {
            //I am adding dummy data here. You should bring data from your repository.
            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("Name");
            for (int i = 0; i < 10; i++)
              {
                DataRow dr = dt.NewRow();
                dr["Id"] = i + 1;
                dr["Name"] = "Student " + (i + 1);
                dt.Rows.Add(dr);
              }
            grdData.DataSource = dt;
            grdData.DataBind();
        }
        protected void grdData_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdData.PageIndex = e.NewPageIndex;
            LoadGridData();
        }
    }
}