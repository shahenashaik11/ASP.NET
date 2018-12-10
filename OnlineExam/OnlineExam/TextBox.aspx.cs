using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineExam
{
    public partial class TextBox : System.Web.UI.Page
    {
        public object Text { get; internal set; }

        //Panel pnlTextBox;

        //protected void Page_PreInit(object sender, EventArgs e)

        //{



        //    pnlTextBox = new Panel();

        //    pnlTextBox.ID = "pnlTextBox";

        //    pnlTextBox.BorderWidth = 1;

        //    pnlTextBox.Width = 300;

        //    this.Form.Controls.Add(pnlTextBox);





        //    LinkButton btnAddtxt = new LinkButton();

        //    btnAddtxt.ID = "btnAddTxt";

        //    btnAddtxt.Text = "Add TextBox";

        //    btnAddtxt.Click += new System.EventHandler(btnAdd_Click);

        //    this.Form.Controls.Add(btnAddtxt);



        //    //Recreate Controls

        //    RecreateControls("txtDynamic", "TextBox");

        //}
        //protected void btnAdd_Click(object sender, EventArgs e)

        //{

        //    int cnt = FindOccurence("txtDynamic");

        //    CreateTextBox("txtDynamic-" + Convert.ToString(cnt + 1));

        //}
        //private int FindOccurence(string substr)

        //{

        //    string reqstr = Request.Form.ToString();

        //    return ((reqstr.Length - reqstr.Replace(substr, "").Length)

        //                      / substr.Length);

        //}
        //private void CreateTextBox(string ID)

        //{

        //    TextBox txt = new TextBox();

        //    txt.ID = ID;

        //    txt.AutoPostBack = true;

        //    txt.TextChanged += new EventHandler(OnTextChanged);

        //    pnlTextBox.Controls.Add(txt);



        //    Literal lt = new Literal();

        //    lt.Text = "<br />";

        //    pnlTextBox.Controls.Add(lt);

        //}
        //private void RecreateControls(string ctrlPrefix, string ctrlType)

        //{

        //    string[] ctrls = Request.Form.ToString().Split('&');

        //    int cnt = FindOccurence(ctrlPrefix);

        //    if (cnt > 0)

        //    {

        //        for (int k = 1; k <= cnt; k++)

        //        {

        //            for (int i = 0; i < ctrls.Length; i++)

        //            {

        //                if (ctrls[i].Contains(ctrlPrefix + "-" + k.ToString())

        //                    && !ctrls[i].Contains("EVENTTARGET"))

        //                {

        //                    string ctrlID = ctrls[i].Split('=')[0];



        //                    if (ctrlType == "TextBox")

        //                    {

        //                        CreateTextBox(ctrlID);

        //                    }

        //                    break;

        //                }

        //            }

        //        }

        //    }

        //}
        protected void AddTextBox(object sender, EventArgs e)
        {
            int index = pnlTextBoxes.Controls.OfType<TextBox>().ToList().Count + 1;
            this.CreateTextBox("txtDynamic" + index);
        }

        private void CreateTextBox(string id)
        {
            TextBox txt = new TextBox();
            txt.ID = id;
            pnlTextBoxes.Controls.Add(txt);

            Literal lt = new Literal();
            lt.Text = "<br />";
            pnlTextBoxes.Controls.Add(lt);
        }
        protected void Page_PreInit(object sender, EventArgs e)
        {
            List<string> keys = Request.Form.AllKeys.Where(key => key.Contains("txtDynamic")).ToList();
            int i = 1;
            foreach (string key in keys)
            {
                this.CreateTextBox("txtDynamic" + i);
                i++;
            }
        }
        protected void GetTextBoxValues(object sender, EventArgs e)
        {
            string message = "";
            foreach (TextBox textBox in pnlTextBoxes.Controls.OfType<TextBox>())
            {
                message += textBox.ID + ": " + textBox.Context + "\\n";
            }
            ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "alert('" + message + "');", true);
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                

            }

        }
    }
}