using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.IO;

namespace testrun1
{
    public partial class reimbursement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["name"] != null)
            {

            }
            else { Response.Redirect("webform1.aspx"); }

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {


            try
            {
                string DBHost = "127.0.0.1";
                string DBName = "base";
                string DBUserName = "root";
                string DBPassword = "root";
                string gender;

                string Conn_String = "server=" + DBHost + ";uid=" + DBUserName + ";password=" + DBPassword + ";database=" + DBName + ";";


                MySqlConnection Conn = new MySqlConnection(Conn_String);
                Conn.Open();


                MySqlCommand cmd;


                cmd = new MySqlCommand("insert into reimbursements (name,description,amount,bill) values ('" + TextBox2.Text + "','" + TextBox4.Text + "','" + TextBox3.Text + "','" + DropDownList1.Text + "')  ", Conn);
                MySqlDataReader r = cmd.ExecuteReader();

            }
            catch (Exception eX)
            {

                Label1.Text += eX.ToString();
            }

        }
    }
}