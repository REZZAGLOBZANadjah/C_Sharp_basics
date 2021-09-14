using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace ConnectDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------start--------------");

            //string connstring = @"datasource=loclahost;username=root;password=25101991;database=company";
            string connstring = @"server = localhost; user id = root;;password=25101991; database = company";
            Console.WriteLine("------------connstring--------------");

            MySqlConnection conn = null;

            try
            {
                conn = new MySqlConnection(connstring);
                conn.Open();
                Console.WriteLine("------------conn.Open();--------------");
                string query = "SELECT * FROM employee;";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "employee");
                DataTable dt = ds.Tables["employee"];

                foreach (DataRow row in dt.Rows)
                {
                    foreach (DataColumn col in dt.Columns)
                    {
                        Console.Write(row[col] + "\t");
                    }

                    Console.Write("\n");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e.ToString());
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
    }
}