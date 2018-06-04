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
    public partial class jobsearch : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["name"] != null)
            {

                Label1.Text = "Welcome " + Session["name"].ToString();
            }
            else { Response.Redirect("webform1.aspx"); }

            try{
             string DBHost = "127.0.0.1";
                    string DBName = "base";
                    string DBUserName = "root";
                    string DBPassword = "root";
                    string gender;

                    string Conn_String = "server=" + DBHost + ";uid=" + DBUserName + ";password=" + DBPassword + ";database=" + DBName + ";";


                    MySqlConnection Conn = new MySqlConnection(Conn_String);
                    Conn.Open();


                    MySqlCommand cmd ;


                    cmd = new MySqlCommand("select * from job", Conn);
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

        

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            try{
             string DBHost = "127.0.0.1";
                    string DBName = "base";
                    string DBUserName = "root";
                    string DBPassword = "root";
                    string gender;

                    string Conn_String = "server=" + DBHost + ";uid=" + DBUserName + ";password=" + DBPassword + ";database=" + DBName + ";";


                    MySqlConnection Conn = new MySqlConnection(Conn_String);
                    Conn.Open();


                    MySqlCommand cmd ;


                    cmd = new MySqlCommand("select id, jobtitle from job", Conn);
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

        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            string id = GridView1.SelectedRow.Cells[0].Text;
            string name = GridView1.SelectedRow.Cells[1].Text;
           // string description = (GridView1.SelectedRow.FindControl("lblDescription") as Label).Text;

            DataTable dt = new DataTable();
          //  dt.Columns.AddRange(new DataColumn[3] { new DataColumn("Id", typeof(int)),
            //        new DataColumn("Name", typeof(string)),
              ////      new DataColumn("Description",typeof(string)) });
            //dt.Rows.Add(id, name, description);


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


                cmd = new MySqlCommand("select * from job where id='"+id+"'", Conn);
                MySqlDataReader r = cmd.ExecuteReader();

                DetailsView1.DataSource = r;
                DetailsView1.DataBind();
                DetailsView2.DataSource = r;
                DetailsView2.DataBind();





                Conn.Close();
            }
            catch (Exception eX)
            {

                Label1.Text += eX.ToString();
            }


        }

        protected void OnSelectedIndexChanged(object sender, EventArgs e)
        {
            String id = GridView1.SelectedRow.Cells[0].Text;


            Response.Redirect("job.aspx?Name=" + id);
       
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("addjob.aspx");
        }
    }
}