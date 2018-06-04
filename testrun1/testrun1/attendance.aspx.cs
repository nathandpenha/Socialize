using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.IO;

namespace testrun1
{
    public partial class attendance : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
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

                MySqlDataReader r;

                cmd = new MySqlCommand("select * from attendance ", Conn);

                r = cmd.ExecuteReader();
                GridView1.DataSource = r;
                GridView1.DataBind();

                Chart1.DataSource = r;
                Chart1.DataBind();


                Conn.Close();
            }
            catch (Exception eX)
            {

                Label1.Text += eX.ToString();
            }



            TextBox1.Text = "0";       TextBox2.Text = "0";

            TextBox3.Text = "0";

            TextBox4.Text = "0";

            TextBox1.EnableViewState = true;

            TextBox2.EnableViewState = true;

            TextBox3.EnableViewState = true;

            TextBox4.EnableViewState = true;

          //  TextBox4.Enabled = false;
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            int t = Convert.ToInt32(TextBox1.Text)+Convert.ToInt32(TextBox2.Text)+Convert.ToInt32(TextBox3.Text);
        
                                    TextBox4.Text=t.ToString();
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {
            
            int t = Convert.ToInt32(TextBox1.Text)+Convert.ToInt32(TextBox2.Text)+Convert.ToInt32(TextBox3.Text);
        
        TextBox4.Text=t.ToString();
            
        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {
            
            int t = Convert.ToInt32(TextBox1.Text)+Convert.ToInt32(TextBox2.Text)+Convert.ToInt32(TextBox3.Text);
        
        TextBox4.Text=t.ToString();
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


                MySqlCommand cmd;


                cmd = new MySqlCommand("insert into attendance values ('" + DropDownList1.Text + "','" + DropDownList2.Text + "','" + DropDownList3.Text + "','" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "')  ", Conn);
                MySqlDataReader r = cmd.ExecuteReader();

                cmd = new MySqlCommand("select * from users where name='" + TextBox1.Text + "'", Conn);

                 r = cmd.ExecuteReader();
                GridView1.DataSource = r;
                GridView1.DataBind();




                Conn.Close();
            }
            catch (Exception eX)
            {

                Label1.Text += eX.ToString();
            }


        }
        public override void VerifyRenderingInServerForm(Control control)
        {
            //required to avoid the run time error "  
            //Control 'GridView1' of type 'Grid View' must be placed inside a form tag with runat=server."  
        }  

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Clear();
            Response.Buffer = true;
            Response.ClearContent();
            Response.ClearHeaders();
            Response.Charset = "";
            string FileName = "Vithal" + DateTime.Now + ".xls";
            StringWriter strwritter = new StringWriter();
            HtmlTextWriter htmltextwrtter = new HtmlTextWriter(strwritter);
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.ContentType = "application/vnd.ms-excel";
            Response.AddHeader("Content-Disposition", "attachment;filename=" + FileName);
            GridView1.GridLines = GridLines.Both;
            GridView1.HeaderStyle.Font.Bold = true;
            GridView1.RenderControl(htmltextwrtter);
            Response.Write(strwritter.ToString());
            Response.End();  
        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Chart1_Load(object sender, EventArgs e)
        {

        }
    }
}