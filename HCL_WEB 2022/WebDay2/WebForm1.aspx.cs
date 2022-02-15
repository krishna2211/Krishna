using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebDay2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack)
            {
                if(ViewState["count"]!=null)
                {
                    int viewstateval = Convert.ToInt32(ViewState["count"]) + 1;
                    TextBox1.Text = viewstateval.ToString();
                    ViewState["count"]= viewstateval.ToString();
                 }
                else
                {
                    ViewState["count"] = 1;
                }
            }
            if(ViewState["EmployeeData"]!=null)
            {
               TextBox2.Text = ViewState["Empno"].ToString();
               TextBox3.Text = ViewState["ename"].ToString();
            }
          
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox1.Text = ViewState["count"].ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if(TextBox2.Text!="")
            {
                ViewState["empno"] = TextBox2.Text;
            }
            if (TextBox3.Text != "")
            {
                ViewState["ename"] = TextBox3.Text;
            }
        }
    }
}