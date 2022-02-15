using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebDay2
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          //  string companyDetails = "";
            if(Session["company"]!=null)
            {
                TextBox1.Text = Session["company"].ToString();
            }
            if (Session["location"] != null)
            {
                TextBox2.Text = Session["location"].ToString();
            }
        }
    }
}