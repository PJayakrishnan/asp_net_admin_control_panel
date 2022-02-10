using asp.net_login.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace asp.net_login
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            aspLoginSettings Settings = aspLoginManager.LoadSettings(Server.MapPath("~/App_Data/Settings.xml"));
            Application.Add("Settings", Settings);
        }
        void Session_Start(Object sender, EventArgs e)
        {
            if (Application["Counter"] == null)
            {
                Application.Add("Counter", 0);
            }
            int icountter = Convert.ToInt32(Application["Counter"]);
            icountter++;
            Application["Counter"]=icountter.ToString();
            
        }
    }
}