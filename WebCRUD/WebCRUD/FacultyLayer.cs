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
    public class FacultyLayer
    {
        public DataSet ds = new DataSet();
        string constr = "";

        public FacultyLayer()
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
                    cmd.CommandText = "GetDataFaculty";
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

        public void Insert(string Faculty_Id, string Faculty_Name, string Faculty_City)
        {

            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@Faculty_Id", Faculty_Id);
                    cmd.Parameters.AddWithValue("@Faculty_Name", Faculty_Name);
                    cmd.Parameters.AddWithValue("@Faculty_City", Faculty_City);
                    cmd.CommandText = "InsertDataFaculty";
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

        public DataSet selectById(string Faculty_Id)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@Faculty_Id", Faculty_Id);
                    cmd.CommandText = "SelectDataFaculty";
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

        public void update(string Faculty_Id, string Faculty_City)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@Faculty_Id", Faculty_Id);
                    cmd.Parameters.AddWithValue("@Faculty_City", Faculty_City);
                    cmd.CommandText = "UpdateDataFaculty";
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