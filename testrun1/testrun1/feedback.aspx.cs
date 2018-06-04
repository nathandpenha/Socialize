using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace testrun1
{
    public partial class feedback : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["name"] != null)
            {

            }
            else { Response.Redirect("webform1.aspx"); }



        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string DBHost = "127.0.0.1";
                string DBName = "base";
                string DBUserName = "root";
                string DBPassword = "root";

                string Conn_String = "server=" + DBHost + ";uid=" + DBUserName + ";password=" + DBPassword + ";database=" + DBName + ";";

                String user = Session["name"].ToString();
                MySqlConnection Conn = new MySqlConnection(Conn_String);
                Conn.Open();
               
                MySqlCommand cmd;

                if (CheckBox1.Checked == true)
                {
                    cmd = new MySqlCommand("insert into feedbackchurch(cause,date) values('" + TextBox1.Text + "','" + DateTime.Now.ToString() + "')", Conn);
                }
                else
                {

                    cmd = new MySqlCommand("insert into feedbackchurch(cause,user,date) values('" + TextBox1.Text + "','" + user + "','" + DateTime.Now.ToString() + "')", Conn);
                } cmd.ExecuteNonQuery();

            }

            catch (Exception ex)
            {

                //Label1.Text = ex.ToString();
            }
        }
    }
}