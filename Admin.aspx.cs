using asp.net_login.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asp.net_login
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserID"] == null)
            {
                Response.Redirect("Default.aspx");
            }
            if (!IsPostBack)
            {
                aspLoginSettings Settings = (aspLoginSettings)Application["Settings"];

                TextBoxDefaultPageText1.Text = Settings.DefaultPageText1;
                TextBoxDefaultPageText2.Text = Settings.DefaultPageText2;
                TextBoxHeaderText.Text = Settings.HeaderText;
                TextBoxFooterText.Text = Settings.FooterText;
            }
        }

        protected void ButtonSaveAdmin_Click(object sender, EventArgs e)
        {
            aspLoginSettings Settings = (aspLoginSettings)Application["Settings"];
            Settings.DefaultPageText1 = TextBoxDefaultPageText1.Text;
            Settings.DefaultPageText2 = TextBoxDefaultPageText2.Text;
            Settings.HeaderText = TextBoxHeaderText.Text;
            Settings.FooterText = TextBoxFooterText.Text;


            aspLoginManager.SaveSettings(Server.MapPath("~/App_Data/Settings.xml"), Settings);
            Application["Settings"] = Settings;
        }
    }
}
