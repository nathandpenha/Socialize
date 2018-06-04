using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;
using System.Net.Mail;
using System.Net;

namespace testrun1
{
    public partial class library : System.Web.UI.Page
    {
        String Aname;
        String Rname;
        String Aemail;
        string Remail = " ";
        String id;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["type"].ToString() == "false")
            {
                
                Button2.Visible = false;
            }
            if (Session["name"]!= null)
            {

            }
            else { Response.Redirect("webform1.aspx"); }


            if (Session["name"].ToString() == "libraryadmin")
            {

            }
            else {
                Button1.Visible = false;
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


                //  MySqlCommand cmd;
                DataSet ds = new DataSet();
                DataTable FromTable = new DataTable();


                MySqlCommand cmd = new MySqlCommand("select bookid,bookname,description,available from  library", Conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                MySqlDataReader r = cmd.ExecuteReader();
                GridView1.DataSource = r;
                GridView1.DataBind();





            





                Conn.Close();
            }
            catch (Exception eX)
            {

                Label1.Text += eX.ToString();
            }

        }
        protected void OnSelectedIndexChanged(object sender, EventArgs e)
        {
            string id = GridView1.SelectedRow.Cells[0].Text;


            Response.Redirect("job.aspx?Name=" + id);

        }

        protected void Button1_Click(object sender, EventArgs e)
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


              //  MySqlCommand cmd;
                  DataSet ds = new DataSet();
        DataTable FromTable = new DataTable();


        MySqlCommand cmd = new MySqlCommand("select * from  library where Bookname='"+ TextBox1.Text +"'", Conn);
        MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
        GridView1.DataSource = adp;
        GridView1.DataBind();
        Conn.Close();
            }
            catch (Exception eX)
            {

                Label1.Text += eX.ToString();
            }


        }
        protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
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
                string gender;

                string Conn_String = "server=" + DBHost + ";uid=" + DBUserName + ";password=" + DBPassword + ";database=" + DBName + ";";


                MySqlConnection Conn = new MySqlConnection(Conn_String);
                Conn.Open();


                //  MySqlCommand cmd;
                DataSet ds = new DataSet();
                DataTable FromTable = new DataTable();


                MySqlCommand cmd = new MySqlCommand("select * from  library where Bookname='" + TextBox1.Text + "'", Conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                
                GridView1.DataSource = adp;
                GridView1.DataBind();





                /*   cmd = new MySqlCommand("select * from shop", Conn);
                       MySqlDataReader r = cmd.ExecuteReader();

                       DataList1.DataSource = r;
                       DataList1.DataBind();  */





                Conn.Close();
            }
            catch (Exception eX)
            {

                Label1.Text += eX.ToString();
            }

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            String id = GridView1.SelectedRow.Cells[0].Text;
           // String id = GridView1.SelectedRow.Cells[0].Text;
            try
            {
                string DBHost = "127.0.0.1";
                string DBName = "base";
                string DBUserName = "root";
                string DBPassword = "root";
                string gender;

                string Conn_String = "server=" + DBHost + ";uid=" + DBUserName + ";password=" + DBPassword + ";database=" + DBName + ";";


                MySqlConnection Conn = new MySqlConnection(Conn_String);
               // Conn.Open();


                MySqlCommand cmd;
                Aemail = Session["name"].ToString();
                cmd = new MySqlCommand("select Name from users where email='" + Aemail + "'", Conn);
                Conn.Open();
                Aname = cmd.ExecuteScalar().ToString();
                // Label1.Text = Aname;
                Conn.Close();

          
                    cmd = new MySqlCommand("select name from users where email='" + Remail + "'", Conn);
                Conn.Open();
                Rname = (String)cmd.ExecuteScalar();
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
                Remail = "dpenhanathan@yahoo.in";
                string smtpAddress = "smtp.mail.yahoo.com";
                int portNumber = 587;
                bool enableSSL = true;

                string emailFrom = "dpenhanathan@yahoo.in";
                string password = "password";
                string emailTo = Remail;
                string subject = "Library Request ";
                string body = "Dear " + Rname + "\n" + " You are Received this email on behalf of a the library, " + Aname + " is intrested in the book with id "+id+", you can email him on " + Aemail;

                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress(emailFrom);
                    mail.To.Add(emailTo);
                    mail.Subject = subject;
                    mail.Body = body;
                    mail.IsBodyHtml = true;
                    // Can set to false, if you are sending pure text.

                    //  mail.Attachments.Add(new Attachment("C:\\SomeFile.txt"));
                    //  mail.Attachments.Add(new Attachment("C:\\SomeZip.zip"));

                    using (SmtpClient smtp = new SmtpClient(smtpAddress, portNumber))
                    {
                        smtp.Credentials = new NetworkCredential(emailFrom, password);
                        smtp.EnableSsl = enableSSL;
                        smtp.Send(mail);
                        Label1.Text = "Interest Shown";
                    }
                }
            }
            catch (Exception ex)
            {
                Label1.Text = "Could not send the e-mail - error: " + ex.Message;

            }
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("libraryedit.aspx");
        }
    }
}
    
