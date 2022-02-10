using asp.net_login.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asp.net_login
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LabelCounter.Text="You are Visitor No: "+ Application["Counter"].ToString();
            aspLoginSettings Settings = (aspLoginSettings)Application["Settings"];
            LabelHeaderText.Text = Settings.HeaderText;
            LabelFooterText.Text = Settings.FooterText;
        }

        protected void ButtonLogout_Click(object sender, EventArgs e)
        {
            Session.Remove("UserID");
            Response.Redirect("Default.aspx");
        }
        protected void ButtonLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("About.aspx");
        }
    }
}