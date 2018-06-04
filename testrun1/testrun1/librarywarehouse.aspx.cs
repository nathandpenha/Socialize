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
    public partial class librarywarehouse : System.Web.UI.Page
    {
        protected void checkdata() {



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


                cmd = new MySqlCommand("select * from library", Conn);
                MySqlDataReader r = cmd.ExecuteReader();
                GridView1.DataSource = r;
                GridView1.DataBind();





                Conn.Close();
            }
            catch (Exception eX)
            {

              //  Label1.Text += eX.ToString();
            }
        
        
        
        }





        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["name"] != null)
            {

            }
            else { Response.Redirect("webform1.aspx"); }


            string DBHost = "127.0.0.1";
            string DBName = "base";
            string DBUserName = "root";
            string DBPassword = "root";

            string Conn_String = "server=" + DBHost + ";uid=" + DBUserName + ";password=" + DBPassword + ";database=" + DBName + ";";


            MySqlConnection Conn = new MySqlConnection(Conn_String);
            Conn.Open();

            MySqlCommand cmd;
            cmd = new MySqlCommand("select bookname from library", Conn);
            cmd.CommandType = CommandType.Text;

            MySqlDataReader ddlValues;
            ddlValues = cmd.ExecuteReader();

            DropDownList1.DataSource = ddlValues;
            DropDownList1.DataTextField = "bookname";
            //  DropDownList1.DataValueField = "id";
            DropDownList1.DataBind();
            Conn.Close();
            Conn.Open();

            cmd = new MySqlCommand("select name from users", Conn);
            cmd.CommandType = CommandType.Text;

            ddlValues = cmd.ExecuteReader();

            DropDownList3.DataSource = ddlValues;
            DropDownList3.DataTextField = "name";
            //  DropDownList1.DataValueField = "id";
            DropDownList3.DataBind();
            Conn.Close();
            Conn.Open();

            cmd = new MySqlCommand("select bookid from library", Conn);
            cmd.CommandType = CommandType.Text;

            ddlValues = cmd.ExecuteReader();

            DropDownList4.DataSource = ddlValues;
            DropDownList4.DataTextField = "bookid";
            //  DropDownList1.DataValueField = "id";
            DropDownList4.DataBind();
            Conn.Close();

            checkdata();

        }

        protected void Bt1_Click(object sender, EventArgs e)
        {
            string DBHost = "127.0.0.1";
            string DBName = "base";
            string DBUserName = "root";
            string DBPassword = "root";

            string Conn_String = "server=" + DBHost + ";uid=" + DBUserName + ";password=" + DBPassword + ";database=" + DBName + ";";


            MySqlConnection Conn = new MySqlConnection(Conn_String);

            Conn.Open();

            MySqlCommand cmd;
            cmd = new MySqlCommand("UPDATE library SET bookname='" + DropDownList1.SelectedValue + "' , available='" + DropDownList2.SelectedValue + "' , user='" + DropDownList3.SelectedValue + "' WHERE bookid='" + DropDownList4.SelectedValue + "'", Conn);

            cmd.ExecuteNonQuery();
            Conn.Close();
            checkdata();
        }

        protected void DropDownList4_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}