using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace WebDay2
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            Application["user"] = 0;
        }
        protected void Session_Start(object sender, EventArgs e)
        {
            //when session in start application variable is increased by 1  
            Application.Lock();
            Application["user"] = (int)Application["user"] + 1;
            Application.UnLock();
        }
        protected void Session_End(object sender, EventArgs e)
        {
            //when session in end application variable is decrease by 1  
            Application.Lock();
            Application["user"] = (int)Application["user"] - 1;
            Application.UnLock();
        }
    }
}