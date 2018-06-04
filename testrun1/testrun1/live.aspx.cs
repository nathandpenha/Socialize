using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Net;
using System.Net.Http;
using MySql.Data.MySqlClient;
//using System.Web;
//using System.Web.Http;  


namespace testrun1
{
    public partial class live : System.Web.UI.Page
    {
        String r;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["name"] != null)
            {

            }
            else { Response.Redirect("webform1.aspx"); }


            if (Session["type"].ToString() == "false")
            {
                TextBox1.Visible = false;
                Button1.Visible = false;
            }
            try
            {
                string DBHost = "127.0.0.1";
                string DBName = "base";
                string DBUserName = "root";
                string DBPassword = "root";

                string Conn_String = "server=" + DBHost + ";uid=" + DBUserName + ";password=" + DBPassword + ";database=" + DBName + ";";


                MySqlConnection Conn = new MySqlConnection(Conn_String);
                Conn.Open();

                MySqlCommand cmd;
                cmd = new MySqlCommand("SELECT link FROM live ORDER BY ID DESC LIMIT 1;", Conn);
                r =(String) cmd.ExecuteScalar();
       //Label1.Text = r;

              //  frame1.Attributes.Add("src", "https://www.youtube.com/embed/JGwWNGJdvx8");   
                System.Web.UI.AttributeCollection aCol = frame1.Attributes;
                aCol.Add("src", r);


                Conn.Close();
            }
            catch (Exception eX)
            {

                //Label1.Text += eX.ToString();
            }
            }

        protected void Button1_Click(object sender, EventArgs e)
        {
          //  frame1.Attributes.Add("src", TextBox1.Text);
        }  
    }  
}   