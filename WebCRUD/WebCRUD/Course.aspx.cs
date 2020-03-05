using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebCRUD
{
    public partial class Course : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {

            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            CourseLayer c = new CourseLayer();
            string id = TextBox1.Text;
            string name = TextBox2.Text;
            decimal fee = decimal.Parse(TextBox3.Text);
            c.Insert(id, name, fee);
            
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            CourseLayer c = new CourseLayer();
            string id = TextBox4.Text;
            var list1 = c.selectById(id);
            GridView2.DataSource = list1;
            GridView2.DataBind();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            CourseLayer c = new CourseLayer();
            string id = TextBox5.Text;
            decimal fee = decimal.Parse(TextBox6.Text);
            c.update(id, fee);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            CourseLayer c = new CourseLayer();
            var list = c.Getallrecords();
            GridView1.DataSource = list;
            GridView1.DataBind();
        }
    }
}