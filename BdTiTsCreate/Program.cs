using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.Odbc;


namespace BdTiTsCreate
{
    class Program
    {
        static void Main(string[] args)
        {


            string connectionString = ConfigurationManager.ConnectionStrings["BdTiTsCreate.Properties.Settings.connectionString"].ConnectionString;
            Console.WriteLine(connectionString);
            using (SqlConnection conn = new SqlConnection())
            {
                try
                {
                    conn.Open();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.Data);
                    Console.WriteLine("\tСостояние: {0}", conn.State);

                }
              
            }
                Console.Read();

           /*
            using (SqlConnection conn = new SqlConnection())
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "oic71p-srtv";
                builder.InitialCatalog = "OIKEDIT";
                builder.IntegratedSecurity = true;
                builder.NetworkLibrary = "DBMSSOCN";
                conn.ConnectionString = builder.ConnectionString;
                Console.WriteLine(builder.ConnectionString);

                try
                {
                    conn.Open();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.Data);
                    Console.WriteLine("\tСостояние: {0}", connection.State);

                }*/
           }
        }
    }

