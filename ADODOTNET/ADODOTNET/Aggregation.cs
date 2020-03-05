using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ADODOTNET
{
    class Aggregation
    {
        public string constr = "";


        public Aggregation()
        {
            constr = @"Data Source = BLT1073\SQLEXPRESS2014; Initial Catalog = MyDB; Integrated Security = True";
        }


        public void update()
        {
            Console.Write("\nEnter a Location to update:");
            string res = Console.ReadLine();
            Console.Write("\nEnter a Id to Update via Id:");
            int id = int.Parse(Console.ReadLine());
           
            using (SqlConnection con = new SqlConnection(constr))
            {
                try
                {
                    String q1 = string.Format("update Restaurent set resCity='{0}' where resId={1};", res, id);
                    con.Open();
                    SqlCommand cmd = new SqlCommand(q1, con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            Console.WriteLine("\nUpdate is Successfully over!!!!!!");
        }

        public void Display()
        {
            Console.WriteLine("\nresId\t\tresName\t\tresType\t\tresCity\n");
            using (SqlConnection con = new SqlConnection(constr))
            {
                try
                {
                    String q1 = "select *from Restaurent";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(q1, con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine("\n{0}\t\t{1}\t\t{2}\t\t{3}", reader[0], reader[1], reader[2], reader[3]);

                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            Console.WriteLine("\nTable  is Successfully Retrieved !!!!!!");
        }
        public void Insert()
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                try
                {
                    string resName, resType, resCity;
                    int resId;
                    Console.WriteLine("Enter the Details to insert in Restaurent Table:");
                    Console.Write("\nEnter the Restaurent Id:");
                    resId = int.Parse(Console.ReadLine());
                    Console.Write("\nEnter the Restaurent Name:");
                    resName = Console.ReadLine();
                    Console.Write("\nEnter the Restaurent Type:");
                    resType = Console.ReadLine();
                    Console.Write("\nEnter the Restaurent city:");
                    resCity = Console.ReadLine();
                    string qr = string.Format("insert into Restaurent values ({0},'{1}','{2}','{3}');", resId, resName, resType, resCity);
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand(qr, con);
                    SqlDataReader reader1 = cmd1.ExecuteReader();
                    reader1.Close();

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            Console.WriteLine("\nInsertion is Succeeded!!!!!!");
        }
    }
}
