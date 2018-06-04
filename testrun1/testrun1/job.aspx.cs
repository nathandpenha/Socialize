using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Net.Mail;
using System.Net;

namespace testrun1
{
    public partial class job : System.Web.UI.Page
    {
        String Aname;
        String Rname;
        String Aemail;
        string Remail = " ";
        String id;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["name"] != null)
            {

               // Label1.Text = "Welcome " + Session["name"].ToString();
            }
            else { Response.Redirect("webform1.aspx"); }
            
             id = Request.QueryString["Name"];
             Label1.Text = id;
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
            
                cmd = new MySqlCommand("select * from job where id='"+id+"' ", Conn);
                MySqlDataReader d = cmd.ExecuteReader();

                if (d.Read())
                {
                    Label1.Text = id;
                    d.Read();

                    Label2.Text = d["jobtitle"].ToString();
                    d.Read();
                    Label3.Text = d["companyname"].ToString();
                    d.Read();
                    Label4.Text = d["type"].ToString();
                    d.Read();
                    Label5.Text = d["description"].ToString();
                    d.Read();
                    Label6.Text = d["industry"].ToString();
                    d.Read();
                    Label7.Text = d["location"].ToString();
                    d.Read();
                    Label8.Text = d["timings"].ToString();
                    d.Read();
                    Label9.Text = d["salary"].ToString();
                    d.Read();
                }
                Conn.Close();
                 Aemail = Session["name"].ToString();
                cmd = new MySqlCommand("select Name from users where email='" + Aemail + "'", Conn);
                Conn.Open();   
              Aname = cmd.ExecuteScalar().ToString();
                Label1.Text=Aname;
             Conn.Close();
              
             cmd = new MySqlCommand("select poster from job where id='" + id + "'", Conn);
                Conn.Open();   
              Remail =(String) cmd.ExecuteScalar();
                Conn.Close();
                cmd = new MySqlCommand("select name from users where email='" + Remail + "'", Conn);
                Conn.Open();
              
             Rname =(String) cmd.ExecuteScalar();
             




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
                string smtpAddress = "smtp.mail.yahoo.com";
                int portNumber = 587;
                bool enableSSL = true;

                string emailFrom = "dpenhanathan@yahoo.in";
                string password = "password";
                string emailTo = Remail;
                string subject = "Job Application ";
                string body = "Dear "+Rname+"\n"+" You are Received this email on behalf of a job you posed on the LWC web site, "+Aname+" is intrested in the offer, you can email him on "+Aemail ;

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
                        Label10.Text="Interest Shown";
                    }
                }
            }
            catch (Exception ex)
            {
                Label10.Text="Could not send the e-mail - error: " + ex.Message;

            }
        }
    }
}