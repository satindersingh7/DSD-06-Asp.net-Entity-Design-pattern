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
    public partial class StudentRegistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserID"] == null)
                Response.Redirect("index.aspx?msg=Please Login to enter in to system.");
            if (!IsPostBack)
            { FillBooks(); }
        }

        protected void Btn_insert_Click(object sender, EventArgs e)
        {
            REGISTER insertreg = new REGISTER { FNAME = tbx_Fname.Text, LNAME = tbx_Lname.Text, EMAILID = tbx_Email.Text, PASSWORD = tbx_Password.Text };
            int id = BAL.InsertRegister(insertreg);

            foreach (ListItem li in chklistbooks.Items)
            {
                if (li.Selected)
                {
                    checkout checkoutdetails = new checkout { user_id = id, book_id = Convert.ToInt32(li.Value) };
                    BAL.InsertBooksCollected(checkoutdetails);
                }
            }
            address insertadd = new address { city = tbx_City.Text, state = tbx_State.Text, street = tbx_Street.Text, user_id = id };
            BAL.InsertAddress(insertadd);
            Response.Redirect("default.aspx?msg=Student Details inserted successfully.");
        }

        private void FillBooks()
        {
            List<book> lsdt = BAL.GetAllBooks();
            if (lsdt != null && lsdt.Count > 0)
            {
                for (int i = 0; i < lsdt.Count; i++)
                {
                    ListItem li = new ListItem(lsdt[i].title + " (" + lsdt[i].isbn + ")", lsdt[i].id.ToString());
                    chklistbooks.Items.Add(li);
                }
            }
            else
            {
                chklistbooks.Items.Clear();
            }
        }
    }
}