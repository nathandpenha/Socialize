using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
namespace testrun1
{
    public partial class user : System.Web.UI.Page
    {
       
protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["name"] != null)
            {

            //    Label1.Text = "Welcome " + Session["name"].ToString();
            }
            else { Response.Redirect("webform1.aspx"); }

            String name = Request.QueryString["Name"];
            
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


               cmd = new MySqlCommand("select image from users where Name='"+ name +"'", Conn);
            
                string imageurl = (string)cmd.ExecuteScalar();

               // cmd = new MySqlCommand("select Name from users where Name='"+Session.ToString()+"'", Conn);

               // string name = (string)cmd.ExecuteScalar();



                Image1.ImageUrl = imageurl;
              //  Label1.Text = name;


                cmd = new MySqlCommand("select Name,Contact,age,Email,profession,dob,address,gender,married from users where name='"+name+"' ", Conn);
                MySqlDataReader d = cmd.ExecuteReader();

                d.Read();
                Label2.Text = d["Name"].ToString();
                d.Read();
                Label3.Text = d["Contact"].ToString();
                d.Read();
                Label4.Text = d["age"].ToString();
                d.Read();
                Label5.Text = d["Email"].ToString();
                d.Read();
                Label6.Text = d["profession"].ToString();
                d.Read();
                Label7.Text = d["dob"].ToString();
                d.Read();
                Label8.Text = d["address"].ToString();
                d.Read();
                Label9.Text = d["gender"].ToString();
                d.Read();
                Label10.Text = d["married"].ToString();



/*                MySqlCommand cmd1 = new MySqlCommand("select count(*) from status ", Conn);
                int count = (int)cmd1.ExecuteScalar();

               Label1.Text = count.ToString();
                */


        }
            catch (Exception eX)
            {

                Label1.Text += eX.ToString();
            }


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
        }
    }
}