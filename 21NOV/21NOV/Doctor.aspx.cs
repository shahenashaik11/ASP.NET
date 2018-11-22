﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _21NOV
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_PreInit(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                ViewState["value"] = Convert.ToString(ViewState["value"]) + "<br/>" + "PreInit";
                Label4.Text = "";
            }
        }
        protected void Page_Init(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                ViewState["value"] = Convert.ToString(ViewState["value"]) + "<br/>" + "Init";
                Label4.Text = Convert.ToString(ViewState["value"]);
            }
        }
        protected void Page_InitComplete(object sender, EventArgs e)

        {
            if (IsPostBack == false)
            {
                ViewState["value"] = Convert.ToString(ViewState["value"]) + "<br/>" + "InitComplete";

                Label4.Text = Convert.ToString(ViewState["value"]);
            }

        }
        protected override void OnPreLoad(EventArgs e)

        {
            if (IsPostBack !=false)
            {

                ViewState["value"] = Convert.ToString(ViewState["value"]) + "<br/>" + "PreLoad";

                Label4.Text = Convert.ToString(ViewState["value"]);
            }

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack != false)
            {
                ViewState["value"] = Convert.ToString(ViewState["value"]) + "<br/>" + "Load";

                Label4.Text = Convert.ToString(ViewState["value"]);
            }

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (IsPostBack != false)
            {
                ViewState["value"] = Convert.ToString(ViewState["value"]) + "<br/>" + "Button1_Click";
                Label4.Text = Convert.ToString(ViewState["value"]);
            }
        }
        protected void Page_LoadComplete(object sender, EventArgs e)

        {
            if (IsPostBack != false)
            {
                ViewState["value"] = Convert.ToString(ViewState["value"]) + "<br/>" + "LoadComplete";

                Label4.Text = Convert.ToString(ViewState["value"]);
            }

        }
        protected override void OnPreRender(EventArgs e)

        {


            if (IsPostBack != false)
            {
                ViewState["value"] = Convert.ToString(ViewState["value"]) + "<br/>" + "PreRender";

                Label4.Text = Convert.ToString(ViewState["value"]);
            }
        }


        protected override void OnSaveStateComplete(EventArgs e)

        {
            if (IsPostBack != false)
            {
                ViewState["value"] = Convert.ToString(ViewState["value"]) + "<br/>" + "SaveStateComplete";

                Label4.Text = Convert.ToString(ViewState["value"]);
            }

        }
        protected void Page_UnLoad(object sender, EventArgs e)

        {
            if (IsPostBack != false)
            {
                ViewState["value"] = Convert.ToString(ViewState["value"]) + "<br/>" + "UnLoad";

                Label4.Text = Convert.ToString(ViewState["value"]);
                Label4.Text = Label4.Text + "Unload";
            }

        }




        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
    }
}