using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DatabaseLayer;
using BusinessLayer;
using System.Data;

namespace PresentationLayers
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserID"] == null)
                Response.Redirect("index.aspx?msg=Please Login to enter in to system.");

            if (!IsPostBack)
            {
                FillBooks();
                FillDetails();
                if (Request.QueryString["msg"] != null)
                {
                    ltrMessage.Text = Request.QueryString["msg"];
                }
            }
        }



        private void FillDetails()
        {
            List<REGISTER> lst = BAL.GetAllUsers();
            if (lst != null && lst.Count > 0)
            {
                gridStudent.DataSource = lst;
                gridStudent.DataBind();

                for (int i = 0; i < lst.Count; i++)
                {
                    ListItem li = new ListItem(lst[i].FNAME + " " + lst[i].LNAME, lst[i].ID.ToString());
                }
            }
            else
            {
                gridStudent.DataSource = null;
                gridStudent.DataBind();
            }

            List<address> lst1 = BAL.GetAlladdress();
            if (lst1 != null && lst1.Count > 0)
            {
                gridaddress.DataSource = lst1;
                gridaddress.DataBind();
            }
            else
            {
                gridaddress.DataSource = null;
                gridaddress.DataBind();
            }

            List<checkout> lst2 = BAL.GetAllcheckout();
            if (lst2 != null && lst2.Count > 0)
            {
                //DataTable lstcheckout = new DataTable();
                //lstcheckout.Columns.Add("id");
                //lstcheckout.Columns.Add("Book Name");
                //lstcheckout.Columns.Add("Student Name");
                //for (int j = 0; j < lst2.Count; j++)
                //{
                //    lstcheckout.Rows.Add(new Object[] { lst2[j].id, lst2[j].book.title, lst2[j].REGISTER.FNAME });
                //}
                
                gridbookscheckout.DataSource = lst2;
                gridbookscheckout.DataBind();
            }
            else
            {
                gridbookscheckout.DataSource = null;
                gridbookscheckout.DataBind();
            }

        }

        protected void BtnGetData_Click(object sender, EventArgs e)
        {
            FillDetails();
        }

        private void FillBooks()
        {
            List<book> lsdt = BAL.GetAllBooks();
            if (lsdt != null && lsdt.Count > 0)
            {
                gridbooks.DataSource = lsdt;
                gridbooks.DataBind();
            }
            else
            {
                gridbooks.DataSource = null;
                gridbooks.DataBind();
            }
        }

    }
}