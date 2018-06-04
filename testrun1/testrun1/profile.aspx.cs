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
    public partial class profile : System.Web.UI.Page
    {
        String email;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Session["name"] != null)
            {

                Label1.Text = "Welcome " + Session["name"].ToString();
                email = Session["name"].ToString();
            }
            else { Response.Redirect("webform1.aspx"); }

            
            
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


               cmd = new MySqlCommand("select image from users where email='"+ email +"'", Conn);
            
                string imageurl = (string)cmd.ExecuteScalar();

                cmd = new MySqlCommand("select Name from users where email='" + email + "'", Conn);

                string name = (string)cmd.ExecuteScalar();



                Image1.ImageUrl = imageurl;
                Label1.Text ="Welcome "+ name;


                cmd = new MySqlCommand("select * from users where email='" + email + "'", Conn);
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

                Conn.Close();


                Conn.Open();
                cmd = new MySqlCommand("select * from job where poster='"+Session["name"].ToString()+"'", Conn);
                MySqlDataReader r = cmd.ExecuteReader();
                GridView1.DataSource = r;
                GridView1.DataBind();
                Conn.Close();


                Conn.Open();
                cmd = new MySqlCommand("select * from shop where email='" + Session["name"].ToString() + "'", Conn);
              r = cmd.ExecuteReader();
                GridView2.DataSource = r;
                GridView2.DataBind();
                Conn.Close();

                













/*                MySqlCommand cmd1 = new MySqlCommand("select count(*) from status ", Conn);
                int count = (int)cmd1.ExecuteScalar();

               Label1.Text = count.ToString();
                */


        }
            catch (Exception eX)
            {

                Label1.Text += eX.ToString();
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
                MySqlCommand cmd;
                cmd = new MySqlCommand("select count(*) from status", Conn);
                Int32 c = 0;
                c = (Int32)cmd.ExecuteScalar();
                Label[] labels = new Label[c];

               for (int i = 0; i <= c; i++) {
                   cmd = new MySqlCommand("select * from status where id='"+i+"' and email='"+ Session +"' ", Conn);
                  MySqlDataReader d = cmd.ExecuteReader();

                d.Read();
                labels[i].Text = d["statusupdate"].ToString();
                this.Controls.Add(labels[i]);
               
               }
            }

            catch (Exception ex)
            {

          //      Label1.Text = ex.ToString();
            }





        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("editdetails.aspx");
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String id = GridView1.SelectedRow.Cells[0].Text;


            Response.Redirect("editjob.aspx?Name=" + id);
        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            String id = GridView2.SelectedRow.Cells[0].Text;


            Response.Redirect("edititem.aspx?Name=" + id);
        }
    }
}