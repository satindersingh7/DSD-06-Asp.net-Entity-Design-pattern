﻿using BusinessLayer;
using DatabaseLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentationLayers
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["UserID"] != null)
                    Response.Redirect("default.aspx?msg=Successfully Logged in.");
            }
            if (Request.QueryString["msg"] != null)
                ltrmessage.Text = Request.QueryString["msg"];
        }

        protected void btn_Click(object sender, EventArgs e)
        {
            if (tbxUsername.Text != "" && tbxPassword.Text != "")
            {
                List <DatabaseLayer.Login> dt = BAL.GetDataTable(IsSQLInjection(tbxUsername.Text), IsSQLInjection(tbxPassword.Text));
                if (dt != null && dt.Count > 0)
                {
                    Session["UserID"] = dt[0].id.ToString();
                    Response.Redirect("default.aspx?msg=Successfully Logged in.", true);
                }
                else
                {
                    ltrmessage.Text = "<font color='red'>Username or Password may be incorrect!</font>";
                }
            }
        }

        private string IsSQLInjection(string text)
        {
            return text.Replace("'", "").Replace("(", "").Replace(")", "").Replace("\"", "").Replace("*", "").Replace("$", "").Replace("&", "").Replace("-", "").Replace(";", "").Replace("[", "").Replace("]", "").Replace("}", "").Replace("{", "").Replace("<", "").Replace(">", "").Replace("=", "");
        }
    }
}