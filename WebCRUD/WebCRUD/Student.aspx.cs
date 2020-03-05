using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebCRUD
{
    public partial class Student : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {

            }


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            StudentLayer s = new StudentLayer();
            var list = s.Getallrecords();
            GridView1.DataSource = list;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            StudentLayer s = new StudentLayer();
            string id = TextBox1.Text;
            string name = TextBox2.Text;
            string city = TextBox3.Text;
            s.Insert(id, name, city);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            StudentLayer s = new StudentLayer();
            string id = TextBox4.Text;
            var list1=s.selectById(id);
            GridView2.DataSource = list1;
            GridView2.DataBind();
            
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            StudentLayer s = new StudentLayer();
            string id = TextBox5.Text;
            string city = TextBox6.Text;
            s.update(id, city);
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            StudentLayer s = new StudentLayer();
            string id = TextBox7.Text;
            s.DeleteById(id);
        }
    }
}