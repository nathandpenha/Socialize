using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace testrun1
{
    public partial class addbibleplan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
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

                string Conn_String = "server=" + DBHost + ";uid=" + DBUserName + ";password=" + DBPassword + ";database=" + DBName + ";";

               
                MySqlConnection Conn = new MySqlConnection(Conn_String);

                MySqlCommand cmd;
                Conn.Open();


                

                {
                    cmd = new MySqlCommand("insert into newbibleplan(name,description,chapters,creator,creationdate) values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','username','" + DateTime.Now.ToString() + "')", Conn);
                }
                cmd.ExecuteNonQuery();

                Response.Redirect("editplan.aspx");
            }

            catch (Exception ex)
            {

                Label1.Text = ex.ToString();
            }
        }
    }
}