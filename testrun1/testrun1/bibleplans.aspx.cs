using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;
using System.Collections;

namespace testrun1
{
    public partial class bibleplans : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
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
                               MySqlCommand cmd = new MySqlCommand("select * from newbibleplan", Conn);
                MySqlDataReader r = cmd.ExecuteReader();
                GridView1.DataSource = r;
                GridView1.DataBind();





                Conn.Close();
            }
            catch (Exception eX)
            {


                Label1.Text += eX.ToString();
            }
        }

        protected void bt(object sender, EventArgs e)
        {
        }

        protected void OnSelectedIndexChanged(object sender, EventArgs e)
        {
            string name = GridView1.SelectedRow.Cells[1].Text;


            Response.Redirect("plan.aspx?Name=" +name);
        }
    }
}