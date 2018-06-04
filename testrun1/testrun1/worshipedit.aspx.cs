using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
namespace testrun1
{
    public partial class worshipedit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Calendar2_SelectionChanged(object sender, EventArgs e)
        {

            try
            {
                string DBHost = "127.0.0.1";
                string DBName = "base";
                string DBUserName = "root";
                string DBPassword = "root";

                string Conn_String = "server=" + DBHost + ";uid=" + DBUserName + ";password=" + DBPassword + ";database=" + DBName + ";";


                MySqlConnection Conn = new MySqlConnection(Conn_String);
                Conn.Open();

                String dat = Calendar2.SelectedDate.ToShortDateString();
                MySqlCommand cmd;
                cmd = new MySqlCommand("select * from worship where date='" + dat + "'", Conn);

                MySqlDataReader r = cmd.ExecuteReader();
                GridView1.DataSource = r;
                GridView1.DataBind();
                Conn.Close();
            }

            catch (Exception ex)
            {
                Label1.Text = ex.ToString();
            }
       
        }
    }
}