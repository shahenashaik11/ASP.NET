using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineExam
{
    public partial class StartTest : System.Web.UI.Page
    {

        string QueryString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;


        protected void Page_Load(object sender, EventArgs e)
        {
            


        }

        protected void btnStart_Click(object sender, EventArgs e)
        {
            string UserName = Context.User.Identity.GetUserName();
            Response.Write(UserName);
        }
    }
}