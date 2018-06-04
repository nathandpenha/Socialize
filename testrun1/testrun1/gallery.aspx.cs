using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Data;
using System.IO;
using System.Configuration;

namespace testrun1
{
    public partial class gallery : System.Web.UI.Page
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
        }
    }
}