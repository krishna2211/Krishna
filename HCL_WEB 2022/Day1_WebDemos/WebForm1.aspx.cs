using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Day1_WebDemos
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int result;
           result = Convert.ToInt32(TextBox1.Text) + Convert.ToInt32(TextBox2.Text);
            TextBox3.Text = Convert.ToString(result);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int result;
            result = Convert.ToInt32(TextBox1.Text) * Convert.ToInt32(TextBox2.Text);
            TextBox3.Text = Convert.ToString(result);
        }
    }
}