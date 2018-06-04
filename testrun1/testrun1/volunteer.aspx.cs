using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace testrun1
{
    public partial class volunteer : System.Web.UI.Page
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
                string gender;

                string Conn_String = "server=" + DBHost + ";uid=" + DBUserName + ";password=" + DBPassword + ";database=" + DBName + ";";


                MySqlConnection Conn = new MySqlConnection(Conn_String);
                

                MySqlCommand cmd;

                if (CheckBox1.Checked)
                {

                    Conn.Open();

                    cmd = new MySqlCommand("insert into servingteamv values ('" + TextBox1.Text + "','" + TextBox2.Text + "')  ", Conn);
                    MySqlDataReader r = cmd.ExecuteReader();

                    Conn.Close();
                }
                if (CheckBox2.Checked)
                {
                    Conn.Open();

                    cmd = new MySqlCommand("insert into worshipteamv values ('" + TextBox1.Text + "','" + TextBox2.Text + "')  ", Conn);
                    MySqlDataReader r = cmd.ExecuteReader();
                    Conn.Close();
                }
                if (CheckBox3.Checked)
                {
                    Conn.Open();
                    cmd = new MySqlCommand("insert into decorteamv values ('" + TextBox1.Text + "','" + TextBox2.Text + "')  ", Conn);
                    MySqlDataReader r = cmd.ExecuteReader();
                    Conn.Close();
                }
                if (CheckBox4.Checked)
                {
                    Conn.Open();
                    cmd = new MySqlCommand("insert into welcometeamv values ('" + TextBox1.Text + "','" + TextBox2.Text + "')  ", Conn);
                    MySqlDataReader r = cmd.ExecuteReader();
                    Conn.Close();
                }
                if (CheckBox5.Checked)
                {
                    Conn.Open();
                    cmd = new MySqlCommand("insert into hojteamv  values ('" + TextBox1.Text + "','" + TextBox2.Text + "')  ", Conn);
                    MySqlDataReader r = cmd.ExecuteReader();
                    Conn.Close();
                }
            }


            catch (Exception eX)
            {

                Label1.Text += eX.ToString();
            }





        }
    }
}