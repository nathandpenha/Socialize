using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;

using System.Collections.Generic;

namespace testrun1
{
    public partial class buy : System.Web.UI.Page
    {
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
                string gender;

                string Conn_String = "server=" + DBHost + ";uid=" + DBUserName + ";password=" + DBPassword + ";database=" + DBName + ";";


                MySqlConnection Conn = new MySqlConnection(Conn_String);
                Conn.Open();


                //  MySqlCommand cmd;
                DataSet ds = new DataSet();
                DataTable FromTable = new DataTable();


                MySqlCommand cmd = new MySqlCommand("select * from  shop", Conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                adp.Fill(ds);
                DataList1.DataSource = ds.Tables[0];
                DataList1.DataBind();
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


        MySqlCommand cmd = new MySqlCommand("select * from  shop where Name='"+ TextBox1.Text +"'", Conn);
        MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
        adp.Fill(ds);   
        DataList1.DataSource = ds.Tables[0];
        DataList1.DataBind();  
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
        protected void bt(object sender, EventArgs e)
        {
            Response.Redirect("item.aspx");
        }
        protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //DataListItem Item = DataList1.SelectedItem; 
           // DataList1.SelectedIndex = e.Item.ItemIndex;
          // Label1.Text = "You selected: " + ((Label)DataList1.SelectedItem.FindControl("Label1")).Text;
           // myTempLabel.Visible = true;

            Response.Redirect("item.aspx?Name=");
        }
    }
}