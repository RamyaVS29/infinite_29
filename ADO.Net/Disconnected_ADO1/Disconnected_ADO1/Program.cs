using System;
using System.Data;
using System.Data.SqlClient;

namespace Disconnected_ADO1
{
    class Program
    {
        public static SqlConnection con;
        public static SqlDataAdapter da;
        static void Main(string[] args)
        {
            // getRegions();
            callprocedure();
            Console.Read();

        }
        public static SqlConnection GetConnection()
        {
            con = new SqlConnection("Data Source=ICS-LT-9S4R9K3; initial catalog=Northwind;trusted_connection =true");
            con.Open();
            return con;
        }
        public static void getRegions()
        {
            con = GetConnection();
            try
            {
                //using only the dataadapter object to execute the command 
                da = new SqlDataAdapter("select * from Region", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "nRegion");
                DataTable dt = ds.Tables["nRegion"];
                // to access the data in the data table 
                foreach (DataRow drow in dt.Rows)
                {
                    foreach (DataColumn dcol in dt.Columns)
                    {
                        Console.Write(drow[dcol]);
                        Console.Write(" ");

                    }
                    Console.WriteLine();

                }


                //let us add one row into the region table 
                //da.Fill(ds, "nRegion"); //refresh the dataset

                //1. create a data row object under aa specific data
                DataRow row = ds.Tables["nRegion"].NewRow();
                //2.give values to the columns of the new row
                Console.WriteLine("enter region id and description : ");
                int rid = Convert.ToInt32(Console.ReadLine());
                string rdesc = Console.ReadLine();

                row["RegionID"] = rid;
                row["RegionDescription"] = rdesc;

                //3. add the newly created row with data to the data table
                ds.Tables["nRegion"].Rows.Add(row);

                //4. now we need to update the database to reflect the new row added 
                SqlCommandBuilder scb = new SqlCommandBuilder(da);
                da.InsertCommand = scb.GetInsertCommand();
                da.Update(ds, "nRegion");
                Console.WriteLine("-------after insertion----");
                //da.Fill (ds,"nregion");
                dt = ds.Tables["nRegion"];

                // reading the data after inserting one row
                foreach (DataRow drow1 in dt.Rows)
                {
                    foreach (DataColumn dcol1 in dt.Columns)
                    {
                        Console.Write(drow1[dcol1]);
                        Console.Write(" ");

                    }
                    Console.WriteLine();

                }


                //adding one more table to the dataset
                Console.WriteLine("--------------");
                da = new SqlDataAdapter("select customerid,companyname,country from customers", con);
                da.Fill(ds, "nCustomers");
                dt = ds.Tables["nCustomers"];

                foreach (DataRow row1 in dt.Rows)
                {
                    foreach (DataColumn col1 in dt.Columns)
                    {
                        Console.Write(row1[col1]);
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }

            catch (Exception se)
            {
                Console.WriteLine("An error occurred: " + se.Message);
            }


           
        }
        public static void callprocedure()
        {
            con = GetConnection();
            da = new SqlDataAdapter("[Ten most expensive products]", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach(DataRow dr in dt.Rows)
            {
                foreach(DataColumn  dc in dt.Columns)
                {
                    Console.Write(dr[dc]);
                    Console.Write(" ");


                }
                Console.WriteLine();

            }

        }

    }
}





