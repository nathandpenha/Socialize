

namespace testrun1
{
	/// <summary>
	/// Summary description for TheChatScreenWin.
	/// </summary>
	public class TheChatScreenWin : System.Web.UI.Page
	{
		private void Page_Load(object sender, System.EventArgs e)
		{
			string sDealer="";
			if (  Session["ChatChannel"] != null )
				sDealer = Session["ChatChannel"].ToString();

			Response.Write( "<meta http-equiv=\"Refresh\"content=\"4\">" );
			Response.Write(testrun1.PageModule.Chat.GetAllMessages(sDealer));
		}

		#region Web Form Designer generated code
		override protected void OnInit(System.EventArgs e)
		{
			//
			// CODEGEN: This call is required by the ASP.NET Web Form Designer.
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{    
			this.Load += new System.EventHandler(this.Page_Load);
		}
		#endregion
	}
}
