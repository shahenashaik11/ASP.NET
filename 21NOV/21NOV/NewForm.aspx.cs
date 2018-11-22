using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _21NOV
{
    public partial class NewForm : System.Web.UI.Page
    {
        protected void Page_PreInit(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                ViewState["value"] = Convert.ToString(ViewState["value"]) + "<br/>" + "PreInit";
                Label1.Text = "";
            }
        }
        protected void Page_Init(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                ViewState["value"] = Convert.ToString(ViewState["value"]) + "<br/>" + "Init";
                Label1.Text = Convert.ToString(ViewState["value"]);
            }
        }
        protected void Page_InitComplete(object sender, EventArgs e)

        {
            if (IsPostBack == false)
            {
                ViewState["value"] = Convert.ToString(ViewState["value"]) + "<br/>" + "InitComplete";

                Label1.Text = Convert.ToString(ViewState["value"]);
            }

        }
        protected override void OnPreLoad(EventArgs e)

        {
            if (IsPostBack != false)
            {

                ViewState["value"] = Convert.ToString(ViewState["value"]) + "<br/>" + "PreLoad";

                Label1.Text = Convert.ToString(ViewState["value"]);
            }

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack != false)
            {
                ViewState["value"] = Convert.ToString(ViewState["value"]) + "<br/>" + "Load";

                Label1.Text = Convert.ToString(ViewState["value"]);
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (IsPostBack != false)
            {
                ViewState["value"] = Convert.ToString(ViewState["value"]) + "<br/>" + "Button1_Click";
                Label1.Text = Convert.ToString(ViewState["value"]);
            }

        }
        protected void Page_LoadComplete(object sender, EventArgs e)

        {
            if (IsPostBack != false)
            {

                ViewState["value"] = Convert.ToString(ViewState["value"]) + "<br/>" + "LoadComplete";
                Label1.Text = Convert.ToString(ViewState["value"]);
            }



        }
        protected override void OnPreRender(EventArgs e)

        {
            if (IsPostBack != false)
            {

                ViewState["value"] = Convert.ToString(ViewState["value"]) + "<br/>" + "PreRender";

                Label1.Text = Convert.ToString(ViewState["value"]);
            }

        }


        protected override void OnSaveStateComplete(EventArgs e)

        {
            if (IsPostBack != false)
            {

                ViewState["value"] = Convert.ToString(ViewState["value"]) + "<br/>" + "SaveStateComplete";

                Label1.Text = Convert.ToString(ViewState["value"]);
            }

        }
        protected void Page_UnLoad(object sender, EventArgs e)

        {
            if (IsPostBack != false)
            {
                ViewState["value"] = Convert.ToString(ViewState["value"]) + "<br/>" + "UnLoad";

                Label1.Text = Convert.ToString(ViewState["value"]);
            }

        }

    }
}