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
    public partial class editplan : System.Web.UI.Page
    {

        String x = "", y = "", z = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["name"] != null)
            {

            }
            else { Response.Redirect("webform1.aspx"); }


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
                cmd = new MySqlCommand("select name from newbibleplan", Conn);
                cmd.CommandType = CommandType.Text;

                MySqlDataReader ddlValues;
                ddlValues = cmd.ExecuteReader();

                DropDownList1.DataSource = ddlValues;
                DropDownList1.DataTextField = "name";
                //  DropDownList1.DataValueField = "id";
                DropDownList1.DataBind();
                Conn.Close();
    /*            Conn.Open();
                cmd = new MySqlCommand("select chapternum from nivdb", Conn);
                cmd.CommandType = CommandType.Text;


                ddlValues = cmd.ExecuteReader();

                DropDownList2.DataSource = ddlValues;
                DropDownList2.DataTextField = "chapternum";
                //DropDownList2.DataValueField = "id";
                DropDownList2.DataBind();
                Conn.Close();
                Conn.Open();
                cmd = new MySqlCommand("select verse from nivdb", Conn);
                cmd.CommandType = CommandType.Text;


                ddlValues = cmd.ExecuteReader();


                DropDownList3.DataSource = ddlValues;
                DropDownList3.DataTextField = "verse";
                //DropDownList3.DataValueField = "id";
                DropDownList3.DataBind();
                Conn.Close();*/
            }
            catch (Exception ex) { }
        }



        protected void Button1_Click(object sender, EventArgs e)
        {

            try
            {

                string DBHost1 = "127.0.0.1";
                string DBName1 = "bibledb";
                string DBUserName1 = "root";
                string DBPassword1 = "root";

                string Conn_String1 = "server=" + DBHost1 + ";uid=" + DBUserName1 + ";password=" + DBPassword1 + ";database=" + DBName1 + ";";


                MySqlConnection Conn1 = new MySqlConnection(Conn_String1);

                MySqlCommand cmd1;



                Conn1.Open();
                

                cmd1 = new MySqlCommand("select verseid from bibledb.nivdb where book='" + DropDownList2.SelectedValue.ToString() + "' and chapternum='" + DropDownList3.SelectedValue.ToString() + "' and versenum='" + DropDownList4.SelectedValue.ToString() + "'", Conn1);


                String f = cmd1.ExecuteScalar().ToString();

                Conn1.Close();

                
                Conn1.Open();

               




                cmd1 = new MySqlCommand("select verseid from bibledb.nivdb where book='" + DropDownList5.SelectedValue.ToString() + "' and chapternum='" + DropDownList6.SelectedValue.ToString() + "' and versenum='" + DropDownList7.SelectedValue.ToString() + "'", Conn1);


                String t = cmd1.ExecuteScalar().ToString();

                Conn1.Close();
                Conn1.Open();

cmd1 = new MySqlCommand("select  verse from bibledb.nivdb where verseid between '"+f+"'and '"+t+"'", Conn1);
                MySqlDataReader r = cmd1.ExecuteReader();
                int i = 1;
                String v = "";
                while (r.Read())
                {
                    v = v +" " + r["verse"].ToString();
                    v.Replace("'", " ");
                    v.Replace("\"", " ");
                }     Conn1.Close();

                    string DBHost = "127.0.0.1";
                    string DBName = "base";
                    string DBUserName = "root";
                    string DBPassword = "root";

                    string Conn_String = "server=" + DBHost + ";uid=" + DBUserName + ";password=" + DBPassword + ";database=" + DBName + ";";


                    MySqlConnection Conn = new MySqlConnection(Conn_String);

                    MySqlCommand cmd;

                    Conn.Open();


                   

                    cmd = new MySqlCommand("insert into plan(name,chapter,bookfrom,chapterfrom,versefrom,bookto,chapterto,verseto,verse,devotion,date) values('" + DropDownList1.SelectedValue.ToString() + "','" + TextBox1.Text + "','" + DropDownList2.SelectedValue.ToString() + "','" + DropDownList3.SelectedValue.ToString() + "','" + DropDownList4.SelectedValue.ToString() + "','" + DropDownList5.SelectedValue.ToString() + "','" + DropDownList6.SelectedValue.ToString() + "','" + DropDownList7.SelectedValue.ToString() + "','"+v+"','" + TextBox2.Text + "','" + DateTime.Now.ToString() + "')", Conn);

                    cmd.ExecuteNonQuery();

                    Response.Redirect("editplan.aspx");
                }
            
            catch (Exception ex) { Label1.Text = ex.ToString(); }
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string DBHost = "127.0.0.1";
                string DBName = "bibledb";
                string DBUserName = "root";
                string DBPassword = "root";

                string Conn_String = "server=" + DBHost + ";uid=" + DBUserName + ";password=" + DBPassword + ";database=" + DBName + ";";


                MySqlConnection Conn = new MySqlConnection(Conn_String);
                Conn.Open();
                x = DropDownList2.SelectedValue.ToString();
                MySqlCommand cmd;
                cmd = new MySqlCommand("select distinct chapternum from bibledb.nivdb where book='" + DropDownList2.SelectedValue.ToString() + "'", Conn);
                cmd.CommandType = CommandType.Text;
                Label1.Text = x;
                MySqlDataReader ddlValues;
                ddlValues = cmd.ExecuteReader();

                DropDownList3.DataSource = ddlValues;
                DropDownList3.DataTextField = "chapternum";
                //  DropDownList1.DataValueField = "id";
                DropDownList3.DataBind();
                Conn.Close();
            }
            catch (Exception ex) { }
        
        }

        protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string DBHost = "127.0.0.1";
                string DBName = "bibledb";
                string DBUserName = "root";
                string DBPassword = "root";

                string Conn_String = "server=" + DBHost + ";uid=" + DBUserName + ";password=" + DBPassword + ";database=" + DBName + ";";


                MySqlConnection Conn = new MySqlConnection(Conn_String);
                Conn.Open();

                x = DropDownList2.SelectedValue.ToString();

                y = DropDownList3.SelectedValue.ToString();
                MySqlCommand cmd;
                cmd = new MySqlCommand("select distinct versenum from bibledb.nivdb where book='" + DropDownList2.SelectedValue.ToString()+ "'and chapternum='" + DropDownList3.SelectedValue.ToString() + "'", Conn);
                cmd.CommandType = CommandType.Text;
                Label1.Text = Label1.Text + ":" + y;
                MySqlDataReader ddlValues;
                ddlValues = cmd.ExecuteReader();

                DropDownList4.DataSource = ddlValues;
                DropDownList4.DataTextField = "versenum";
                //  DropDownList1.DataValueField = "id";
                DropDownList4.DataBind();
                Conn.Close();

            }
            catch (Exception ex) {
                Label1.Text = e.ToString();
            }
        }

        protected void DropDownList4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList5_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string DBHost = "127.0.0.1";
                string DBName = "bibledb";
                string DBUserName = "root";
                string DBPassword = "root";

                string Conn_String = "server=" + DBHost + ";uid=" + DBUserName + ";password=" + DBPassword + ";database=" + DBName + ";";


                MySqlConnection Conn = new MySqlConnection(Conn_String);
                Conn.Open();
                x = DropDownList5.SelectedValue.ToString();
                MySqlCommand cmd;
                cmd = new MySqlCommand("select distinct chapternum from bibledb.nivdb where book='" + x + "'", Conn);
                cmd.CommandType = CommandType.Text;
                Label1.Text = x;
                MySqlDataReader ddlValues;
                ddlValues = cmd.ExecuteReader();

                DropDownList6.DataSource = ddlValues;
                DropDownList6.DataTextField = "chapternum";
                //  DropDownList1.DataValueField = "id";
                DropDownList6.DataBind();
                Conn.Close();
            }
            catch (Exception ex) { }
        
        }

        protected void DropDownList6_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string DBHost = "127.0.0.1";
                string DBName = "bibledb";
                string DBUserName = "root";
                string DBPassword = "root";

                string Conn_String = "server=" + DBHost + ";uid=" + DBUserName + ";password=" + DBPassword + ";database=" + DBName + ";";


                MySqlConnection Conn = new MySqlConnection(Conn_String);
                Conn.Open();

                x = DropDownList5.SelectedValue.ToString();

                y = DropDownList6.SelectedValue.ToString();
                MySqlCommand cmd;
                cmd = new MySqlCommand("select distinct versenum from bibledb.nivdb where book='" + x + "'and chapternum='" + y + "'", Conn);
                cmd.CommandType = CommandType.Text;
                Label1.Text = Label1.Text + ":" + y;
                MySqlDataReader ddlValues;
                ddlValues = cmd.ExecuteReader();

                DropDownList7.DataSource = ddlValues;
                DropDownList7.DataTextField = "versenum";
                //  DropDownList1.DataValueField = "id";
                DropDownList7.DataBind();
                Conn.Close();

            }
            catch (Exception ex) { }
        
        }

      
       
    }
}