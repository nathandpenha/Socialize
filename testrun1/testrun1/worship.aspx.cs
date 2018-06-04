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
    public partial class worship : System.Web.UI.Page
    {
        DropDownList []d=new DropDownList[20];
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["name"] != null)
            {

            }
            else { Response.Redirect("webform1.aspx"); }
            if (Session["type"].ToString() != "true") {

                Label1.Visible = false;
                Label2.Visible = false;
                Label3.Visible = false;
                Label4.Visible = false;
                Label5.Visible = false;
                Label6.Visible = false;
                Label7.Visible = false;

                TextBox1.Visible = false;
                TextBox3.Visible = false;
                TextBox4.Visible = false;

                DropDownList1.Visible = false;
                DropDownList2.Visible = false;
                DropDownList3.Visible = false;
                DropDownList4.Visible = false;
                DropDownList5.Visible = false;
                DropDownList6.Visible = false;
                DropDownList7.Visible = false;

                Calendar1.Visible = false;

                Button1.Visible = false;
                Button2.Visible = false;

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
                cmd = new MySqlCommand("select name from users", Conn);
                cmd.CommandType = CommandType.Text;
                
                MySqlDataReader ddlValues;
                ddlValues = cmd.ExecuteReader();

                DropDownList1.DataSource = ddlValues;
                DropDownList1.DataTextField = "name";
              //  DropDownList1.DataValueField = "id";
                DropDownList1.DataBind();
                Conn.Close();
                Conn.Open();
                cmd = new MySqlCommand("select name,id from users", Conn);
                cmd.CommandType = CommandType.Text;

                
                ddlValues = cmd.ExecuteReader();

                DropDownList2.DataSource = ddlValues;
                DropDownList2.DataTextField = "name";
                //DropDownList2.DataValueField = "id";
                DropDownList2.DataBind();
                Conn.Close();
                Conn.Open();
                cmd = new MySqlCommand("select name,id from users", Conn);
                cmd.CommandType = CommandType.Text;


                ddlValues = cmd.ExecuteReader();

               
                DropDownList3.DataSource = ddlValues;
                DropDownList3.DataTextField = "name";
                //DropDownList3.DataValueField = "id";
                DropDownList3.DataBind();
                Conn.Close();
                Conn.Open();
                cmd = new MySqlCommand("select name,id from users", Conn);
                cmd.CommandType = CommandType.Text;


                ddlValues = cmd.ExecuteReader();

               
                DropDownList4.DataSource = ddlValues;
                DropDownList4.DataTextField = "name";
                //DropDownList4.DataValueField = "id";
                DropDownList4.DataBind();
                Conn.Close();
                Conn.Open();
                cmd = new MySqlCommand("select name,id from users", Conn);
                cmd.CommandType = CommandType.Text;


                ddlValues = cmd.ExecuteReader();

               
                DropDownList5.DataSource = ddlValues;
                DropDownList5.DataTextField = "name";
                //DropDownList5.DataValueField = "id";
                DropDownList5.DataBind();
                Conn.Close();
                Conn.Open();
                cmd = new MySqlCommand("select name,id from users", Conn);
                cmd.CommandType = CommandType.Text;


                ddlValues = cmd.ExecuteReader();

               
                DropDownList6.DataSource = ddlValues;
                DropDownList6.DataTextField = "name";
                //DropDownList6.DataValueField = "id";
                DropDownList6.DataBind();
                Conn.Close();
                Conn.Open();
                cmd = new MySqlCommand("select name,id from users", Conn);
                cmd.CommandType = CommandType.Text;


                ddlValues = cmd.ExecuteReader();

               
                DropDownList7.DataSource = ddlValues;
                DropDownList7.DataTextField = "name";
                //DropDownList7.DataValueField = "id";
                DropDownList7.DataBind();
                Conn.Close();
            }

            catch (Exception ex)
            {
                Label1.Text = ex.ToString();
            }

            TextBox3.Visible = false;
            TextBox3.Visible = false;
            Calendar1.Visible = false;
            TextBox4.Visible = false;
            Button1.Visible = false;
            if (Session["name"] != null)
            {

                //Label1.Text = "Welcome " + Session["name"].ToString();
            }
         //   else { Response.Redirect("webform1.aspx"); }


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
                MySqlCommand cmd = new MySqlCommand("select * from  worship", Conn);
                MySqlDataReader r = cmd.ExecuteReader();
               /// GridView1.DataSource = r;
                //GridView1.DataBind();


                Conn.Close();
            }
            catch (Exception eX)
            {

                //Label1.Text += eX.ToString();
            }
            //String s = Session["edit"].ToString();
            //if (s == "true")
            {
                TextBox3.Visible = true;
                TextBox3.Visible = true;
                Calendar1.Visible = true;
                TextBox4.Visible = true;
                Button1.Visible = true;
            }

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

       /*     int x = Convert.ToInt32(DropDownList1.SelectedValue);

            for (int i = 0; i < x; i++)
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
                    cmd = new MySqlCommand("select * from worship", Conn);


                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);  // fill dataset
                   d[i].DataTextField = ds.Tables[0].Columns["leader"].ToString(); // text field name of table dispalyed in dropdown
                    d[i].DataValueField = ds.Tables[0].Columns["id"].ToString();             // to retrive specific  textfield name 
                    d[i].DataSource = ds.Tables[0];      //assigning datasource to the dropdownlist
                    d[i].DataBind();  //binding dropdownlist
                    d[i].Visible = true;
                }


                catch (Exception ex) { Label1.Text = ex.ToString(); }
            }*/
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox3.Visible = true;
            Calendar1.Visible = true; 
        
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            TextBox3.Text = Calendar1.SelectedDate.ToShortDateString();
            Calendar1.Visible = false;
        
        }

        protected void Button1_Click1(object sender, EventArgs e)
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
                cmd = new MySqlCommand("insert into worship(leader,members,date) values('" + TextBox1.Text + "','" + TextBox4.Text + "','" + TextBox3.Text + "')", Conn);
                cmd.ExecuteNonQuery();
                Conn.Close();

                Conn.Open();
                String m1 = DropDownList1.SelectedValue;
                cmd = new MySqlCommand("select email from users where name='"+m1+"'", Conn);
                String e1 = cmd.ExecuteScalar().ToString();
                Conn.Close();
                Conn.Open();

               String m2 = DropDownList2.SelectedValue.ToString();
               Label1.Text = m2;
                cmd = new MySqlCommand("select email from users where name='" + m2 + "'", Conn);
                String e2 = cmd.ExecuteScalar().ToString();
                Conn.Close();
                Conn.Open();
                String m3 = DropDownList3.SelectedValue.ToString();
                cmd = new MySqlCommand("select email from users where name='" + m3 + "'", Conn);
                String e3 = cmd.ExecuteScalar().ToString();
                Conn.Close();
                Conn.Open();
                String m4 = DropDownList4.SelectedValue.ToString();
                cmd = new MySqlCommand("select email from users where name='" + m4 + "'", Conn);
                String e4 = cmd.ExecuteScalar().ToString();
                Conn.Close();
                Conn.Open();
                String m5 = DropDownList5.SelectedValue.ToString();
                cmd = new MySqlCommand("select email from users where name='" + m5 + "'", Conn);
                String e5 = cmd.ExecuteScalar().ToString();
                Conn.Close();
                Conn.Open();
                String m6 = DropDownList6.SelectedValue.ToString();
                cmd = new MySqlCommand("select email from users where name='" + m6 + "'", Conn);
                String e6 = cmd.ExecuteScalar().ToString();
                Conn.Close();
                Conn.Open();
                String m7 = DropDownList7.SelectedValue.ToString();
                cmd = new MySqlCommand("select email from users where name='" + m7 + "'", Conn);
                String e7 = cmd.ExecuteScalar().ToString();
                Conn.Close();
                try
                {
                    string smtpAddress = "smtp.mail.yahoo.com";
                    int portNumber = 587;
                    bool enableSSL = true;

                    string emailFrom = "dpenhanathan@yahoo.in";
                    string password = "password";
                    string emailTo = m1;
                    string subject = "Job Application ";
                    string body = "Dear " + " You are Received this email since you have chossen  to  play on, "+"  ";

                    using (MailMessage mail = new MailMessage())
                    {
                        mail.From = new MailAddress(emailFrom);
                       // mail.To.Add(new MailAddress (emailTo));
                        mail.To.Add(new MailAddress(e1));
                        mail.To.Add(new MailAddress(e2));
                        mail.To.Add(new MailAddress(e3));
                        mail.To.Add(new MailAddress(e4));
                        mail.To.Add(new MailAddress(e5));
                        mail.To.Add(new MailAddress(e6));
                        mail.To.Add(new MailAddress(e7));
                        
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
                            Label1.Text = "sent";
                        }
                    }
                }
                catch (Exception ex)
                {
                    Label1.Text = "Could not send the e-mail - error: " + ex.Message;
                }
                
            
            
            
            }

            catch (Exception ex)
            {
                Label1.Text =Label1.Text+ ex.ToString();
            }
            Calendar1.Visible = false;
     
        }

        protected void Calendar2_SelectionChanged(object sender, EventArgs e)
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

               String dat = Calendar2.SelectedDate.ToShortDateString();
                MySqlCommand cmd;
                cmd = new MySqlCommand("select * from worship where date='" + dat + "'", Conn);

                MySqlDataReader r = cmd.ExecuteReader();
                GridView1.DataSource = r;
                GridView1.DataBind();
                Conn.Close();
            }

            catch (Exception ex)
            {
                Label1.Text = ex.ToString();
            }
       
        }

        protected void DropDownList1_SelectedIndexChanged1(object sender, EventArgs e)
        {

        }
    
    
    
    
    
    }

}