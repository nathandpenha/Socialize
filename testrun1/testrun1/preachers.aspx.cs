using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;

namespace testrun1
{
    public partial class preachers : System.Web.UI.Page
    {
        DropDownList[] d = new DropDownList[20];
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["name"] != null)
            {

            }
            else { Response.Redirect("webform1.aspx"); }

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
                cmd = new MySqlCommand("select name from users", Conn);
                cmd.CommandType = CommandType.Text;
                
                MySqlDataReader ddlValues;
                ddlValues = cmd.ExecuteReader();

                DropDownList1.DataSource = ddlValues;
                DropDownList1.DataTextField = "name";
              //  DropDownList1.DataValueField = "id";
                DropDownList1.DataBind();
                Conn.Close();
            }

            catch (Exception ex)
            {
                Label1.Text = ex.ToString();
            }

            if (Session["name"] != null)
            {

                Label1.Text = "Welcome " + Session["name"].ToString();
            }
            //else { Response.Redirect("webform1.aspx"); }

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
                cmd = new MySqlCommand("select * from preacher", Conn);

                MySqlDataReader r = cmd.ExecuteReader();
         //       GridView1.DataSource = r;
           //     GridView1.DataBind();





                Conn.Close();
            }
            catch (Exception eX)
            {
            }
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            TextBox3.Text = Calendar1.SelectedDate.ToShortDateString();
            Calendar1.Visible = false;
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        String name, topic,dat;
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

                name = DropDownList1.Text;
                topic = TextBox2.Text;
                dat = Calendar2.SelectedDate.ToShortDateString();
                MySqlCommand cmd;
                cmd = new MySqlCommand("select name,topic,date from preacher where date='" + dat + "'", Conn);

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
                Conn.Open();

                name = DropDownList1.Text;
                topic = TextBox2.Text;
                dat = TextBox3.ToString();
                MySqlCommand cmd;
                cmd = new MySqlCommand("insert into preacher(name,date,topic) values('" + DropDownList1.Text + "','" + TextBox3.Text + "','" + TextBox2.Text + "')", Conn);
                cmd.ExecuteNonQuery();
                Conn.Close();
            }

            catch (Exception ex)
            {
                Label1.Text = ex.ToString();
            }

        }

        protected void Calendar2_DayRender(object sender, DayRenderEventArgs e)
        {


        }

        protected void Button1_Click1(object sender, EventArgs e)
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

                name = DropDownList1.Text;
                topic = TextBox2.Text;
                dat = TextBox3.ToString();
                MySqlCommand cmd;
                cmd = new MySqlCommand("insert into preacher(name,date,topic) values('" + DropDownList1.Text  + "','" + TextBox3.Text + "','" + TextBox2.Text + "')", Conn);
                cmd.ExecuteNonQuery();
                Conn.Close();
            }

            catch (Exception ex)
            {
                Label1.Text = ex.ToString();
            }
            Calendar1.Visible = false;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox3.Visible = true;
            Calendar1.Visible = true; 
        }
    }
}