using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace WebCRUD
{
    public class CourseLayer
    {
        public DataSet ds = new DataSet();
        string constr = "";

        public CourseLayer()
        {
            constr = ConfigurationManager.ConnectionStrings["dp"].ConnectionString;
        }

        public DataSet Getallrecords()
        {


            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "GetDataCourse";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    ada.Fill(ds);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return ds;
        }

        public void Insert(string Course_Id, string Course_Name, decimal Course_Fee)
        {
            
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@Course_Id", Course_Id);
                    cmd.Parameters.AddWithValue("@Course_Name", Course_Name);
                    cmd.Parameters.AddWithValue("@Course_Fee", Course_Fee);
                    cmd.CommandText = "InsertDataCourse";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter sd = new SqlDataAdapter(cmd);
                    sd.Fill(ds);
                    sd.Update(ds);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
           
        }

        public DataSet selectById(string Course_Id)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@Course_Id", Course_Id);
                    cmd.CommandText = "SelectDataCourse";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter sd = new SqlDataAdapter(cmd);
                    sd.Fill(ds);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return ds;
        }

        public void update(string Course_Id, decimal Course_Fee)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@Course_Id", Course_Id);
                    cmd.Parameters.AddWithValue("@Course_Fee", Course_Fee);
                    cmd.CommandText = "UpdateDataCourse";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter sd = new SqlDataAdapter(cmd);
                    sd.Fill(ds);
                    sd.Update(ds);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}