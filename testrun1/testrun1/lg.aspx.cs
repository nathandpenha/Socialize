using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace testrun1
{
    public partial class lg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["name"] != null)
            {

                //Label1.Text = "Welcome " + Session["name"].ToString();
            }
            else { Response.Redirect("webform1.aspx"); }

            if (Session["type"].ToString() == "false") {

                Label1.Visible = false; Label2.Visible = false; Label3.Visible = false; Label4.Visible = false;
                TextBox1.Visible = false; TextBox2.Visible = false; TextBox3.Visible = false; TextBox4.Visible = false;
                Button2.Visible = false;
            }


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
                cmd = new MySqlCommand("select * from lg ", Conn);

                MySqlDataReader r = cmd.ExecuteReader();
                GridView1.DataSource = r;
                GridView1.DataBind();





                Conn.Close();
            }
            catch (Exception eX)
            {
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
               String x = DropDownList1.SelectedValue.ToString();
                MySqlCommand cmd;
                cmd = new MySqlCommand("select area from lg ", Conn);
                cmd.CommandType = CommandType.Text;
                Label1.Text = x;
                MySqlDataReader ddlValues;
                ddlValues = cmd.ExecuteReader();

                DropDownList1.DataSource = ddlValues;
                DropDownList1.DataTextField = "area";
                //  DropDownList1.DataValueField = "id";
                DropDownList1.DataBind();
                Conn.Close();
            }
            catch (Exception ex) { }
       

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
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
                cmd = new MySqlCommand("select * from lg where area='" + DropDownList1.SelectedValue.ToString() + "'", Conn);

                MySqlDataReader r = cmd.ExecuteReader();
                GridView1.DataSource = r;
                GridView1.DataBind();





                Conn.Close();
            }
            catch (Exception eX)
            {
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
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
                MySqlCommand cmd = new MySqlCommand("insert into lg (area,contact,timings,address)values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "')", Conn);

                cmd.ExecuteNonQuery();
            
            }
            catch (Exception ex) { Label1.Text = ex.ToString(); }
             
        }

        protected void TextBox5_TextChanged(object sender, EventArgs e)
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
                MySqlCommand cmd = new MySqlCommand("select * from lg where area like '"+TextBox1.Text+"' or address like '"+TextBox1.Text+"'", Conn);

                MySqlDataReader r = cmd.ExecuteReader();
                GridView1.DataSource = r;
                GridView1.DataBind();


            }
            catch (Exception ex) { Label1.Text = ex.ToString(); }
         
        }
    }
}