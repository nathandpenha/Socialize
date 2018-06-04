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
    public partial class sell : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["name"] != null)
            {

                Label1.Text = "Welcome " + Session["name"].ToString();
            }
            else { Response.Redirect("webform1.aspx"); }

           

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            /*     string filename = Path.GetFileName(FileUpload1.PostedFile.FileName);
                 string contentType = FileUpload1.PostedFile.ContentType;
                 using (Stream fs = FileUpload1.PostedFile.InputStream)
                 {
                     using (BinaryReader br = new BinaryReader(fs))
                     {
                         byte[] bytes = br.ReadBytes((Int32)fs.Length);

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
                             cmd = new MySqlCommand("insert into shop(Name,image,cost) values('" + TextBox1.Text + "','" + bytes + "','" + TextBox2.Text + "')", Conn);
                             cmd.ExecuteNonQuery();

                         }

                         catch (Exception ex)
                         {

                             Label1.Text = ex.ToString();
                         }
                     }
                 }*/

            if (FileUpload1.PostedFile != null)
            {
                string FileName = Path.GetFileName(FileUpload1.PostedFile.FileName);

                //Save files to disk
                FileUpload1.SaveAs(Server.MapPath("images/" + FileName));

                //Add Entry to DataBase
                //    String strConnString = System.Configuration.ConfigurationManager
                //      .ConnectionStrings["conString"].ConnectionString;
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
                    cmd = new MySqlCommand("insert into shop(Name,image,cost,email) values('" + TextBox1.Text + "','" +"images/"+FileName + "','" + TextBox2.Text + "','"+Session+"')", Conn);
                    cmd.ExecuteNonQuery();

                }

                catch (Exception ex)
                {

                    Label1.Text = ex.ToString();
                }


            }
        }
    }
}
