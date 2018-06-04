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
    public partial class registeration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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
                String gender = " ", marriage = " ",citizen="";

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
                    FileName = "~/profile/" + FileName;
                    FileUpload1.SaveAs(Server.MapPath( FileName));

                }

                MySqlCommand cmd;
                cmd = new MySqlCommand("insert into users(name,contact,age,email,profession,dob,address,native,gender,married,image,citizen,password,date) values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + TextBox7.Text + "','" + TextBox8.Text + "','" + gender + "','" + marriage + "','" + FileName + "','" + citizen + "','"+TextBox10.Text+"','"+DateTime.Now.Date+"')", Conn);
                cmd.ExecuteNonQuery();
                Conn.Close();

                Response.Redirect("WebForm1.aspx");

            }

            catch (Exception ex) {

                Label1.Text = ex.ToString();
            }
        }

        protected void TextBox9_TextChanged(object sender, EventArgs e)
        {

        }
    }
}