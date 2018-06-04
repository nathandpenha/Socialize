using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;
using System.IO;
using System.Configuration;

namespace testrun1
{
    public partial class editdetails : System.Web.UI.Page
    {
        String email = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            

            if (Session["name"] != null)
            {

//                Label1.Text = "Welcome " + Session["name"].ToString();
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




                //Image1.ImageUrl = imageurl;
             //   Label1.Text = name;


                cmd = new MySqlCommand("select * from users where email='" + email + "'", Conn);
                MySqlDataReader d = cmd.ExecuteReader();

                d.Read();
                TextBox1.Text = d["Name"].ToString();
                d.Read();
                TextBox2.Text = d["Contact"].ToString();
                d.Read();
                TextBox3.Text = d["age"].ToString();
                d.Read();
                TextBox4.Text = d["Email"].ToString();
                d.Read();
                TextBox5.Text = d["profession"].ToString();
                d.Read();
                TextBox6.Text = d["dob"].ToString();
                d.Read();
                TextBox7.Text = d["address"].ToString();
                d.Read();
                TextBox8.Text = d["gender"].ToString();
                d.Read();
             
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
                String gender = " ", marriage = " ",citizen=" ";

                if (RadioButton1.Checked) { gender = "Male"; }

                if (RadioButton2.Checked) { gender = "Female"; }

                if (RadioButton3.Checked) { marriage = "Single"; }

                if (RadioButton4.Checked) { marriage = "Married"; }
                if (RadioButton5.Checked) { citizen = "Yes"; }
                if (RadioButton6.Checked) { citizen = "No"; }
               
                String FileName = null;
                if (FileUpload1.PostedFile != null)
                {
                    FileName = Path.GetFileName(FileUpload1.PostedFile.FileName);
                    FileName = "profile/" + FileName;

                }

                MySqlCommand cmd;
                cmd = new MySqlCommand("update users set name='" + TextBox1.Text + "', contact='" + TextBox2.Text + "',age='" + TextBox3.Text + "',email='" + TextBox4.Text + "',profession='" + TextBox4.Text + "',dob='" + TextBox6.Text + "',address='" + TextBox7.Text + "',native='" + TextBox8.Text + "',gender=='" + gender + "',married='" + marriage + "',image='" + FileName + "',citizen='" + citizen + "' where email='"+Session["name"].ToString()+"'", Conn);
                cmd.ExecuteNonQuery();

            }

            catch (Exception ex)
            {

                Label1.Text = ex.ToString();
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
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
                cmd = new MySqlCommand(" DELETE FROM USERS WHERE EMAIL='"+email+"'", Conn);
                cmd.ExecuteNonQuery();


                Session["name"] = "";
                Response.Redirect("webform1.aspx");
            }

            catch (Exception ex)
            {

                Label1.Text = ex.ToString();
            }
        }

            
            
            }
    }
