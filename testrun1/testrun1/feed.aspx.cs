using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web;
using System.Xml;
using System.Text;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace testrun1
{
    public partial class feed : System.Web.UI.Page
    {
        public void ProcessRequest(HttpContext context)
        {
            BuildFeedXML(context, 1);
        }

        private void BuildFeedXML(HttpContext context, int channelId)
        {  using (XmlTextWriter writer = new XmlTextWriter(context.Response.OutputStream, Encoding.UTF8))

         //   XmlTextWriter writer = new XmlTextWriter(Server.MapPath("rss.xml"), Encoding.UTF8);
            
            {
                DataTable dt = GetData("SELECT * FROM Channel WHERE Id = @ChannelId", channelId);
                writer.WriteStartDocument();
                writer.WriteStartElement("rss");
                writer.WriteAttributeString("version", "2.0");
                writer.WriteStartElement("channel");
                writer.WriteElementString("title", dt.Rows[0]["Title"].ToString().ToUpper());
                writer.WriteString(" \n ");
                writer.WriteElementString("link", dt.Rows[0]["Link"].ToString());
                writer.WriteString(" \n ");

                writer.WriteElementString("description", dt.Rows[0]["Description"].ToString());
                writer.WriteElementString("copyright", dt.Rows[0]["Copyright"].ToString());

                dt = GetData("SELECT * FROM Feeds WHERE ChannelId = @ChannelId", channelId);
                foreach (DataRow dr in dt.Rows)
                {
                    writer.WriteStartElement("item");
                    writer.WriteElementString("title", dr["Title"].ToString());
                    writer.WriteElementString("description", dr["Description"].ToString());
                    writer.WriteElementString("link", dr["Link"].ToString());
                    writer.WriteElementString("guid", dr["Id"].ToString());
                    writer.WriteElementString("pubDate", Convert.ToDateTime(dr["PublishedDate"]).ToString("R"));
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
           
                writer.WriteEndElement();
                writer.WriteEndDocument();
              
                writer.Flush();
                writer.Close();
            }
        }

        private DataTable GetData(string query, int channelId)
        {
            DataTable dt = new DataTable();
            string DBHost = "127.0.0.1";
            string DBName = "base";
            string DBUserName = "root";
            string DBPassword = "root";
            string gender;

            string Conn_String = "server=" + DBHost + ";uid=" + DBUserName + ";password=" + DBPassword + ";database=" + DBName + ";";


            MySqlConnection Conn = new MySqlConnection(Conn_String);
            Conn.Open(); 
            {
                using (MySqlCommand cmd = new MySqlCommand(query))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@ChannelId", channelId);
                    cmd.Connection = Conn;
                    using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                    {
                        sda.Fill(dt);
                    }
                }
            }
            return dt;
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}

