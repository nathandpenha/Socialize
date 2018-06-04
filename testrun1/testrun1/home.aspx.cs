using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace testrun1
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["name"] != null)
            {

                Label1.Text ="Welcome "+ Session["name"].ToString()+Session["type"].ToString();


            }else { Response.Redirect("profile.aspx"); }



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
                    MySqlCommand cmd = new MySqlCommand("select * from  anon", Conn);
                 MySqlDataReader r  = cmd.ExecuteReader();
                    GridView1.DataSource = r;
                    GridView1.DataBind();
                    

                    Conn.Close();
                }
                catch (Exception eX)
                {

                    Label1.Text += eX.ToString();
                }

            
            
        }
    }
}