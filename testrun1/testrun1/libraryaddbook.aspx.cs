using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.IO;
using System.Configuration;

namespace testrun1
{
    public partial class libraryaddbook : System.Web.UI.Page
    {

        protected void checkdata()
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


            checkdata();
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string DBHost = "127.0.0.1";
            string DBName = "base";
            string DBUserName = "root";
            string DBPassword = "root";

            string Conn_String = "server=" + DBHost + ";uid=" + DBUserName + ";password=" + DBPassword + ";database=" + DBName + ";";


            MySqlConnection Conn = new MySqlConnection(Conn_String);

            String FileName = null;
            if (FileUpload1.PostedFile != null)
            {
                FileName = Path.GetFileName(FileUpload1.PostedFile.FileName);
                FileName = "librarypictures/" + FileName;

            }

            Conn.Open();

            MySqlCommand cmd;
            cmd = new MySqlCommand("insert into library (bookname,description,image)values('"+TextBox1.Text +"','"+TextBox2.Text+"','"+FileName +"')", Conn);
            cmd.ExecuteNonQuery();
            
            Conn.Close();
            checkdata();
        }
    }
}