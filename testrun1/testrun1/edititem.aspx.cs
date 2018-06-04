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
    public partial class edititem : System.Web.UI.Page
    {
       String id="";
        String email="";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["name"] != null)
            {

                Label1.Text = "Welcome " + Session["name"].ToString();
                email = Session["name"].ToString();
            }
            else { Response.Redirect("webform1.aspx"); }

            id = Request.QueryString["Name"];

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


                cmd = new MySqlCommand("select * from shop where id='" + id + "'", Conn);

                MySqlDataReader d = cmd.ExecuteReader();

                d.Read();
                TextBox1.Text = d[" ame"].ToString();
                d.Read();
                TextBox2.Text = d["cost"].ToString();
                d.Read();

                Image1.ImageUrl = d["image"].ToString();
                d.Read();
     

                Conn.Close();




            }
            catch (Exception ex) { }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            String FileName="";
            if (FileUpload1.PostedFile != null)
            {
                 FileName = Path.GetFileName(FileUpload1.PostedFile.FileName);

                //Save files to disk
                FileUpload1.SaveAs(Server.MapPath("images/" + FileName));
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
                cmd = new MySqlCommand("update shop set name='" + TextBox1.Text + "', cost='" + TextBox2.Text + "',image='" +"images/"+FileName+ "' where id='" + id + "'", Conn);
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
                cmd = new MySqlCommand("delete from shop where id='" + id + "'", Conn);
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