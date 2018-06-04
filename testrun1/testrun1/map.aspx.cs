using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ASPSnippets.SmsAPI;


namespace testrun1
{
    public partial class map : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["name"] != null)
            {

            }
            else { Response.Redirect("webform1.aspx"); }


        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
/*            SMS.APIType = SMSGateway.Site2SMS;
            SMS.MashapeKey = "<Mashape API Key>";
            SMS.Username = txtNumber.Text.Trim();
            SMS.Password = txtPassword.Text.Trim();
            if (txtRecipientNumber.Text.Trim().IndexOf(",") == -1)
            {
                //Single SMS
                SMS.SendSms(txtRecipientNumber.Text.Trim(), txtMessage.Text.Trim());
            }
            else
            {
                //Multiple SMS
                List<string> numbers = txtRecipientNumber.Text.Trim().Split(',').ToList();
                SMS.SendSms(numbers, txtMessage.Text.Trim());
            }*/
        }

        protected void btnSend_Click1(object sender, EventArgs e)
        {
            
           SMS.APIType = SMSGateway.Site2SMS;
           SMS.MashapeKey = "<LCAu6DoQjzmshVk2bfXhoeFBc97Sp1uPrHpjsnZ2WWP1ClrXyp>";
            SMS.Username = txtNumber.Text.Trim();
            SMS.Password = txtPassword.Text.Trim();
            if (txtRecepientNumber.Text.Trim().IndexOf(",") == -1)
            {
                //Single SMS
                SMS.SendSms(txtRecepientNumber.Text.Trim(), txtMessage.Text.Trim());
            }
            else
            {
                //Multiple SMS
                List<string> numbers = txtRecepientNumber.Text.Trim().Split(',').ToList();
                SMS.SendSms(numbers, txtMessage.Text.Trim());
            }
        }
    }
}