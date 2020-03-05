using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ADO.Net
{
    class Program
    {
        static void Main(string[] args)
        {
            // geTMyDataSqlVS();
           
            Console.ReadKey();

         private static void geTMyDataSqlVS()
        {
            string constr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=dpDB;Integrated Security=True;  
                            Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;
                            ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            using (SqlConnection con = new SqlConnection(constr))
            {
                try
                {
                    string querystr = "delete  from Student where SId= @id";
                    String q1 = "select *from Student";
                    int pvalue = 101;
                    con.Open();
                    SqlCommand cmd = new SqlCommand(querystr, con);
                    SqlCommand cmd1 = new SqlCommand(q1, con);
                    cmd.Parameters.AddWithValue("@id", pvalue);
                    SqlDataReader reader = cmd1.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine("{0}\t{1}\t{2}\t{3}", reader[0], reader[1], reader[2], reader[3]);

                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.ReadKey();
            }
        }
    }
}
