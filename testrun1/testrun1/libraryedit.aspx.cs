using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace testrun1
{
    public partial class libraryedit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["name"] != null)
            {

            }
            else { Response.Redirect("webform1.aspx"); }


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("librarywarehouse.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("libraryaddbook.aspx");
        }
    }
}