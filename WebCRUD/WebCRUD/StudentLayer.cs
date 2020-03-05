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
    public class StudentLayer
    {
        public DataSet ds = new DataSet();
        string constr = "";

        public StudentLayer()
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
                    cmd.CommandText = "GetDataStu";
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

        public void Insert(string Stu_Id, string Stu_Name, string Stu_City)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@Stu_Id", Stu_Id);
                    cmd.Parameters.AddWithValue("@Stu_Name", Stu_Name);
                    cmd.Parameters.AddWithValue("@Stu_City", Stu_City);
                    cmd.CommandText = "InsertDataStu";
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

        public DataSet selectById(string Stu_Id)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@Stu_Id", Stu_Id);
                    cmd.CommandText = "SelectDataStu";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter sd = new SqlDataAdapter(cmd);
                    sd.Fill(ds);
                }
            }
            catch (Exception e)
            {
               
            }
            return ds;
        }

        public void update(string Stu_Id,string Stu_City)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@Stu_Id", Stu_Id);
                    cmd.Parameters.AddWithValue("@Stu_City", Stu_City);
                    cmd.CommandText = "UpdateDataStu";
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

        public void DeleteById(string Stu_Id)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@Stu_Id", Stu_Id);
                    cmd.CommandText = "DeleteDataStu";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter sd = new SqlDataAdapter(cmd);
                    sd.Fill(ds);
                    sd.Update(ds);
                }
            }
            catch (Exception e)
            {

            }
            
        }

    }
}
