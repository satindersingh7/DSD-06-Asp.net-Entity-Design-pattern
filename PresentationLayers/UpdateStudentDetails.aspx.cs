using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DatabaseLayer;
using BusinessLayer;
namespace PresentationLayers
{
    public partial class UpdateStudentDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserID"] == null)
                Response.Redirect("index.aspx?msg=Please Login to enter in to system.");
            if (!IsPostBack)
            { FillDetails(); }
        }

        private void FillDetails()
        {
            List<REGISTER> lst = BAL.GetAllUsers();
            if (lst != null && lst.Count > 0)
            {
                for (int i = 0; i < lst.Count; i++)
                {
                    ListItem li = new ListItem(lst[i].FNAME + " " + lst[i].LNAME, lst[i].ID.ToString());
                    ddlstudents.Items.Add(li);
                }
                ddlstudents.Items.Insert(0, new ListItem("select student", ""));
            }
            else
            {
                ddlstudents.Items.Clear();
            }
        }

        protected void Btnupdate_Click(object sender, EventArgs e)
        {
            REGISTER insertreg = new REGISTER { ID = Convert.ToInt32(ddlstudents.SelectedValue), FNAME = tbx_UFname.Text, LNAME = tbx_ULname.Text, EMAILID = tbx_UEmail.Text, PASSWORD = tbx_UPassword.Text };
            BAL.UpdateStudentDetails(insertreg);
            Response.Redirect("default.aspx?msg=Student details updated successfully.");

        }

        protected void Ddlstudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<REGISTER> lst = BAL.GetUser(ddlstudents.SelectedValue);
            if (lst != null && lst.Count > 0)
            {
                for (int i = 0; i < lst.Count; i++)
                {
                    tbx_UFname.Text = lst[i].FNAME;
                    tbx_ULname.Text = lst[i].LNAME;
                    tbx_UEmail.Text = lst[i].EMAILID;
                    tbx_UPassword.Attributes.Add("Value", lst[i].PASSWORD);
                }
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            BAL.DeleteRecord(ddlstudents.SelectedValue);
        }
    }
}