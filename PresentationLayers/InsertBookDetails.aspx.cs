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
    public partial class InsertBookDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserID"] == null)
                Response.Redirect("index.aspx?msg=Please Login to enter in to system.");
        }

        protected void btn_insert_Click(object sender, EventArgs e)
        {
            book insertreg = new book { title = tbx_Title.Text, author = tbx_Author.Text, isbn = tbx_ISBN.Text };
            BAL.InsertBookDetails(insertreg);
            Response.Redirect("default.aspx?msg=Book Details Inserted Successfully.");
        }
    }
}