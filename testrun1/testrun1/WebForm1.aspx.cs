using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Odbc;
using MySql.Data.MySqlClient;
namespace testrun1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
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
                MySqlCommand cmd = new MySqlCommand("select email from users where password ='"+TextBox4.Text +"'", Conn);
                String name = cmd.ExecuteScalar().ToString();
                Conn.Close();
                Session["name"] = name;
                Conn.Close(); Conn.Open();
                cmd = new MySqlCommand("select admin from  users where email='" + name + "'", Conn);
                String type = cmd.ExecuteScalar().ToString();

                Session["type"] = type;
                Conn.Close();
               
                 
                Response.Redirect("home.aspx");


                Conn.Close();
            }
            catch (Exception eX)
            {
                Label1.Text = eX.ToString();

            }
        }
    }
}