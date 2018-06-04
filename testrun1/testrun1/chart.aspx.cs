using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;
using System.Web.UI.DataVisualization;
using System.Web.Util;



namespace testrun1
{
    public partial class chart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
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
                cmd = new MySqlCommand("select age from users", Conn);
                //MySqlDataReader dr=cmd.ExecuteReader();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                DataTable dt = new DataTable();
               
                da.Fill(dt);

                //Chart1.DataSource = ds;

                //Chart1.DataBind();
                
                
                Conn.Close();

                string[] x = new string[dt.Rows.Count];
                int[] y = new int[dt.Rows.Count];

                for (int i = 0; i < dt.Rows.Count; i++) {
                    x[i] = dt.Rows[i][0].ToString();
                    y[i] = Convert.ToInt32(dt.Rows[i][1]);
                
                }

                Chart1.Series[0].Points.DataBindXY(x, y);
            }
        

            
            catch (Exception ex) { Label2.Text = ex.ToString(); }
        }

        protected void Chart1_Load(object sender, EventArgs e)
        {

        }


        
    }
}