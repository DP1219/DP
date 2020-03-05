using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebCRUD
{
    public partial class Faculty : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            FacultyLayer f = new FacultyLayer();
            string id = TextBox1.Text;
            string name = TextBox2.Text;
            string city = TextBox3.Text;
            f.Insert(id, name, city);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            FacultyLayer f = new FacultyLayer();
            string id = TextBox4.Text;
            var list1 = f.selectById(id);
            GridView2.DataSource = list1;
            GridView2.DataBind();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            FacultyLayer f = new FacultyLayer();
            string id = TextBox5.Text;
            string city = TextBox6.Text;
            f.update(id, city);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            FacultyLayer f = new FacultyLayer();
            var list = f.Getallrecords();
            GridView1.DataSource = list;
            GridView1.DataBind();
        }
    }
}