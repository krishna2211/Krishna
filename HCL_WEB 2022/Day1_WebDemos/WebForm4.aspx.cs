using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
namespace Day1_WebDemos
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ArrayList aobj = new ArrayList();
            aobj.Add("C");
            aobj.Add("C++");
            aobj.Add("JAVA");
            aobj.Add(".NET");

            ListBox1.DataSource = aobj;
            ListBox1.DataBind();

            DropDownList1.DataSource = aobj;
            DropDownList1.DataBind();

            RadioButtonList1.DataSource = aobj;
            RadioButtonList1.DataBind();

            CheckBoxList1.DataSource = aobj;
            CheckBoxList1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Emp eobj = new Emp { empno = 100, ename = "Raj" };
            Emp eobj1 = new Emp { empno = 200, ename = "Amit" };
            List<Emp> lobj = new List<Emp>();
            lobj.Add(eobj);
            lobj.Add(eobj1);
            foreach (Emp a in lobj)
            {
                ListBox2.Items.Add(a.ename+ "   "+ a.empno);
                ListBox2.DataBind();
            }
        }
    }
}