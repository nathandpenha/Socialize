using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace testrun1
{
    public partial class addjob : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["name"] != null)
            {

                Label1.Text = "Welcome " + Session["name"].ToString();
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
                string gender;

                string Conn_String = "server=" + DBHost + ";uid=" + DBUserName + ";password=" + DBPassword + ";database=" + DBName + ";";


                MySqlConnection Conn = new MySqlConnection(Conn_String);
                Conn.Open();


                MySqlCommand cmd;

                String poster=Session["name"].ToString();
                //cmd = new MySqlCommand("insert into job(jobtitle,companyname,type,description,location,industry,timings,salary,poster) values ('" + TextBox1.Text + "','" + TextBox2.Text + "','" + DropDownList1.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + TextBox7.Text + "','"+poster+"')  ", Conn);
                //MySqlDataReader r = cmd.ExecuteReader();



                Conn.Close();
            }
            catch (Exception eX)
            {

                Label1.Text += eX.ToString();
            }


        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}