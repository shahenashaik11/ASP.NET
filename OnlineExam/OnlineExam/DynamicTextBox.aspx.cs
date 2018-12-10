using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace OnlineExam
{
    public partial class DynamicTextBox : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                

            }

        }
        public void createDynamicTextBox(string _TextBoxId)
        {
            System.Web.UI.HtmlControls.HtmlGenericControl tr = new System.Web.UI.HtmlControls.HtmlGenericControl("tr");
            System.Web.UI.HtmlControls.HtmlGenericControl td1 = new System.Web.UI.HtmlControls.HtmlGenericControl("td");
            Label lbl = new Label();
            lbl.ID = "lbl" + _TextBoxId.Replace(" ", " ").ToLower();
            lbl.Text = _TextBoxId;
            td1.Controls.Add(lbl);
            tr.Controls.Add(td1);
            HtmlGenericControl td2=new HtmlGenericControl("td");
            TextBox txtBox = new TextBox();
            txtBox.ID = _TextBoxId.Replace(" ", " ").ToLower();
            td2.Controls.Add(txtBox);
            tr.Controls.Add(td2);
            PlaceHolder1.Controls.Add(tr);
            TextBox txt = (TextBox)PlaceHolder1.FindControl("TextBox");
            lblValue = txt.Text;


        }
     

        public object lblValue { get; private set; }

       
    }
}