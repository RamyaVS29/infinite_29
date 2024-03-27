using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Disconnected_ADO1
{
   
    class connectionpooling
    {
        public static string connectstr = "Data Source=ICS-LT-9S4R9K3; initial catalog=Northwind;integrated security =true";

        public static void Main()
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            for(int i =0; i<1000; i++)
            {
                SqlConnection con = new SqlConnection(connectstr);
                con.Open();
                con.Close();

            }
            stopwatch.Stop();
            Console.WriteLine($"pooling = true, time taken : {stopwatch.ElapsedMilliseconds} ms");
            Transactioneg(connectstr);
            Console.Read();

        }
        public static void Transactioneg(string str)
        {
            using (SqlConnection con = new SqlConnection(str))
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                SqlTransaction tran;

                tran = con.BeginTransaction();
                cmd.Transaction = tran;
                try
                {
                    cmd.CommandText = "insert into Region values(100, 'FirstRegion')";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "update  Region set RegionDescription='LastRegion' where RegionID=5";
                    cmd.ExecuteNonQuery();
                    tran.Commit();
                    Console.WriteLine("2 transaction succesfull");
                }
                catch (Exception)
                {
                    Console.WriteLine("error");
                    try
                    {
                        tran.Rollback();
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("some error");
                    }
                }

            }

            

        }

    }

}
