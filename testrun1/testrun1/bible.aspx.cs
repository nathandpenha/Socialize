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
    public partial class bible : System.Web.UI.Page
    {String x="",y="",z="";
        protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["name"] != null)
        {

        }
        else { Response.Redirect("webform1.aspx"); }

            try
            {
                string DBHost = "127.0.0.1";
                string DBName = "bibledb";
                string DBUserName = "root";
                string DBPassword = "root";

                string Conn_String = "server=" + DBHost + ";uid=" + DBUserName + ";password=" + DBPassword + ";database=" + DBName + ";";


                MySqlConnection Conn = new MySqlConnection(Conn_String);
           /*     Conn.Open();

                MySqlCommand cmd;
                cmd = new MySqlCommand("select distinct book from bibledb.nivdb", Conn);
                cmd.CommandType = CommandType.Text;

                MySqlDataReader ddlValues;
                ddlValues = cmd.ExecuteReader();

                DropDownList1.DataSource = ddlValues;
                DropDownList1.DataTextField = "book";
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

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
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
                 x=DropDownList1.SelectedValue.ToString();
                MySqlCommand cmd;
                cmd = new MySqlCommand("select distinct chapternum from bibledb.nivdb where book='"+x+"'", Conn);
                cmd.CommandType = CommandType.Text;
                Label1.Text =DropDownList1.SelectedValue.ToString() ;
                MySqlDataReader ddlValues;
                ddlValues = cmd.ExecuteReader();

                DropDownList2.DataSource = ddlValues;
                DropDownList2.DataTextField = "chapternum";
                //  DropDownList1.DataValueField = "id";
                DropDownList2.DataBind();
                Conn.Close();
            }
            catch (Exception ex) { }
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
                Label1.Text = DropDownList1.SelectedValue.ToString() + ":" + DropDownList2.SelectedValue.ToString(); 
                 x = DropDownList1.SelectedValue.ToString();

                 y = DropDownList2.SelectedValue.ToString();
                MySqlCommand cmd;
                cmd = new MySqlCommand("select distinct versenum from bibledb.nivdb where book='" + x + "'and chapternum='" + y + "'", Conn);
                cmd.CommandType = CommandType.Text;
                //Label1.Text = Label1.Text + ":" + y;
                MySqlDataReader ddlValues;
                ddlValues = cmd.ExecuteReader();

                DropDownList3.DataSource = ddlValues;
                DropDownList3.DataTextField = "versenum";
                //  DropDownList1.DataValueField = "id";
                DropDownList3.DataBind();
                Conn.Close();

            }
            catch (Exception ex) { }
        }

        protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
        {
            z=DropDownList3.SelectedValue.ToString();
            Label1.Text = DropDownList1.SelectedValue.ToString() + ":" + DropDownList2.SelectedValue.ToString() + ":" + DropDownList3.SelectedValue.ToString();


            try
            {
                string DBHost = "127.0.0.1";
                string DBName = "bibledb";
                string DBUserName = "root";
                string DBPassword = "root";

                string Conn_String = "server=" + DBHost + ";uid=" + DBUserName + ";password=" + DBPassword + ";database=" + DBName + ";";


                MySqlConnection Conn = new MySqlConnection(Conn_String);
                
                MySqlCommand cmd;

                Conn.Open();
                cmd = new MySqlCommand("select  verse from bibledb.nivdb where book='" + DropDownList1.SelectedValue.ToString() + "'and chapternum='" + DropDownList2.SelectedValue.ToString() + "'and versenum='" + DropDownList3.SelectedValue.ToString() + "'", Conn);

                string o = (string)cmd.ExecuteScalar();
                Label2.Text = o;
                Conn.Close();
                Conn.Open();
                cmd = new MySqlCommand("select  verse from bibledb.nivdb where book='" + DropDownList1.SelectedValue.ToString() + "'and chapternum='" + DropDownList2.SelectedValue.ToString() + "'", Conn);
                MySqlDataReader r = cmd.ExecuteReader();
                int i = 1;
                Label3.Text="";
                while (r.Read()) {

                    Label3.Text =Label3.Text+" "+i.ToString()+" "+r["verse"].ToString();
                    i++;
                }

            }
            catch (Exception ex)
            {
                Label2.Text = ex.ToString();
            }

        }
            }
    }
