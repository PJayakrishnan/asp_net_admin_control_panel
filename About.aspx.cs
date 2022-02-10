using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asp.net_login
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            string UserName = WebConfigurationManager.AppSettings["PFUserName"];
            string Password = WebConfigurationManager.AppSettings["PFPassWord"];
            if(TextBoxEmail.Text == UserName && TextBoxPassword.Text == Password)
            {
                Session.Add("UserID", UserName);
                Response.Redirect("Admin.aspx");
            }
            else
            {
                LabelMessage.Text = " Please enter valid Username and Password ";
            }
        }
    }
}