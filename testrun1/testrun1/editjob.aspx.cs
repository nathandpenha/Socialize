using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;

namespace testrun1
{
    public partial class editjob : System.Web.UI.Page
    {String id="";
        String email="";
        protected void Page_Load(object sender, EventArgs e)
        {
             if (Session["name"] != null)
            {

                Label1.Text = "Welcome " + Session["name"].ToString();
                email = Session["name"].ToString();
            }
            else { Response.Redirect("webform1.aspx"); }

            id=Request.QueryString["Name"];

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
                //      DataSet ds = new DataSet();
                //        DataTable FromTable = new DataTable();


                cmd = new MySqlCommand("select * from job where id='" + id + "'", Conn);

                MySqlDataReader d = cmd.ExecuteReader();

                d.Read();
                TextBox1.Text = d["jobtitle"].ToString();
                d.Read();
                TextBox2.Text = d["companyname"].ToString();
                d.Read();
                TextBox3.Text = d["type"].ToString();
                d.Read();
                TextBox4.Text = d["description"].ToString();
                d.Read();
                TextBox5.Text = d["industry"].ToString();
                d.Read();
                TextBox6.Text = d["location"].ToString();
                d.Read();
                TextBox7.Text = d["timings"].ToString();
                d.Read();
                TextBox8.Text = d["salary"].ToString();
                d.Read();
             

                Conn.Close();




            }
            catch (Exception ex) { }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {   try
            {
                string DBHost = "127.0.0.1";
                string DBName = "base";
                string DBUserName = "root";
                string DBPassword = "root";

                string Conn_String = "server=" + DBHost + ";uid=" + DBUserName + ";password=" + DBPassword + ";database=" + DBName + ";";


                MySqlConnection Conn = new MySqlConnection(Conn_String);
                Conn.Open();
         
            MySqlCommand cmd;
            cmd = new MySqlCommand("update job set jobtitle='" + TextBox1.Text + "', companyname='" + TextBox2.Text + "',type='" + TextBox3.Text + "',description='" + TextBox4.Text + "',industry='" + TextBox4.Text + "',location='" + TextBox6.Text + "',timing='" + TextBox7.Text + "',salary='" + TextBox8.Text + "' where id='" +id+ "'", Conn);
            cmd.ExecuteNonQuery();
            Conn.Close();

            }

        catch (Exception ex)
        {

            Label1.Text = ex.ToString();
        }
        }

        protected void Button3_Click(object sender, EventArgs e)
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

                MySqlCommand cmd;
                cmd = new MySqlCommand("delete from job where id='"+id+"'", Conn);
                cmd.ExecuteNonQuery();
                Conn.Close();
                Response.Redirect("profile.aspx");

            }

            catch (Exception ex)
            {

                Label1.Text = ex.ToString();
            }
        }
    }
}