using System;
using System.Data;
using System.Data.SqlClient;

namespace ADO_Project1
{
    class Program
    {
        public static SqlConnection con = null;
        public static SqlCommand cmd;
        public static SqlDataReader dr;

        static void Main(string[] args)
        {
            //SelectData();

            // InsertData();

            //DeleteData();

            // UpdateData();

            //  StoredProc_WithParameter();
            StoredProc_With_Output();
            Console.Read();
        }
        public static SqlConnection getconnection()
        {
            con = new SqlConnection("Data Source=ICS-LT-9S4R9K3;Initial Catalog=assignmentDB;Integrated Security=true;");

            con.Open();
            return con;
        }
        // method for selecting data from table
        public static void SelectData()
        {
            con = getconnection();
            //  cmd = new SqlCommand("select * from tblEMP", con);
            //or
            cmd = new SqlCommand("select * from tblEMP");
            cmd.Connection = con;

            //we have selected select command so we have to use execute reader

            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                //Console.WriteLine(dr[0]+ " "+dr[1]+ " "+dr[2]+ " " +dr[3]);
                Console.WriteLine("empno: " + dr[0]);
                Console.WriteLine("ename: " + dr[1]);
                Console.WriteLine("job:   " + dr[2]);
                Console.WriteLine("sal:   " + dr[3]);

            }
        }
        //method for inserting a row 
        public static void InsertData()
        {
            con = getconnection();
            int eempno, emgr_id, edeptno;
            decimal esal, ecomm;
            string eename, ejob, ehiredate;

            try
            {
                Console.WriteLine("Enter Employee empno,NAME,JOB,MGR_ID,Hiredate,SALARY,COMM,DEptno: ");
                eempno = Convert.ToInt32(Console.ReadLine());
                eename = Console.ReadLine();
                ejob = Console.ReadLine();
                emgr_id = Convert.ToInt32(Console.ReadLine());
                ehiredate = Console.ReadLine();
                esal = Convert.ToDecimal(Console.ReadLine());
                ecomm = Convert.ToDecimal(Console.ReadLine());
                edeptno = Convert.ToInt32(Console.ReadLine());

                cmd = new SqlCommand("INSERT INTO tblEMP " +
                    "(empno, ename, job, mgr_id, hiredate, sal, comm, deptno) " +
                    "VALUES (@empno, @ename, @job, @mgr_id, @hiredate, @sal, @comm, @deptno)", con);

                cmd.Parameters.AddWithValue("@empno", eempno);
                cmd.Parameters.AddWithValue("@ename", eename);
                cmd.Parameters.AddWithValue("@job", ejob);
                cmd.Parameters.AddWithValue("@mgr_id", emgr_id);
                cmd.Parameters.AddWithValue("@hiredate", ehiredate);
                cmd.Parameters.AddWithValue("@sal", esal);
                cmd.Parameters.AddWithValue("@comm", ecomm);
                cmd.Parameters.AddWithValue("@deptno", edeptno);

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                    Console.WriteLine("Inserted Data..");
                else
                    Console.WriteLine("Ran into some Error..");
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Some SQL error occurred: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        //for deletion------

        public static void DeleteData()
        {
            con = getconnection();
            try
            {
                Console.WriteLine("Enter empno : ");
                int empno = Convert.ToInt32(Console.ReadLine());


                if (dr != null && !dr.IsClosed)
                    dr.Close();

                cmd = new SqlCommand("SELECT COUNT(*) FROM tblEMP WHERE empno = @empno", con);
                cmd.Parameters.AddWithValue("@empno", empno);
                int count = (int)cmd.ExecuteScalar();

                if (count > 0)
                {
                    Console.WriteLine("Are you sure you want to delete this employee? (Y/N)");
                    string answer = Console.ReadLine();

                    if (answer.Equals("Y", StringComparison.OrdinalIgnoreCase))
                    {

                        cmd = new SqlCommand("DELETE FROM tblEMP WHERE empno = @empno", con);
                        cmd.Parameters.AddWithValue("@empno", empno);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                            Console.WriteLine("Record deleted successfully.");
                        else
                            Console.WriteLine("Failed to delete record.");
                    }
                    else
                    {
                        Console.WriteLine("Deletion cancelled.");
                    }
                }
                else
                {
                    Console.WriteLine("Employee with empno {0} does not exist.", empno);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        //to update------ 
        public static void UpdateData()
        {
            con = getconnection();
            try
            {
                Console.WriteLine("Enter the empno of the employee you want to update: ");
                int empnoToUpdate = Convert.ToInt32(Console.ReadLine());


                cmd = new SqlCommand("SELECT COUNT(*) FROM tblEMP WHERE empno = @empno", con);
                cmd.Parameters.AddWithValue("@empno", empnoToUpdate);
                int count = (int)cmd.ExecuteScalar();

                if (count > 0)
                {
                    Console.WriteLine("Enter Employee NAME,JOB,MGR_ID,Hiredate,SALARY,COMM,DEptno: ");

                    string updatedename = Console.ReadLine();
                    string updatedjob = Console.ReadLine();
                    int updatedmgr_id = Convert.ToInt32(Console.ReadLine());
                    string updatedhiredate = Console.ReadLine();
                    decimal updatedsal = Convert.ToDecimal(Console.ReadLine());
                    decimal updatedcomm = Convert.ToDecimal(Console.ReadLine());
                    int updateddeptno = Convert.ToInt32(Console.ReadLine());

                    cmd = new SqlCommand("UPDATE tblEMP SET ename = @ename, job = @job, sal = @sal, mgr_id = @mgr_id, hiredate = @hiredate, comm = @comm, deptno = @deptno WHERE empno = @empno", con);
                    cmd.Parameters.AddWithValue("@empno", empnoToUpdate);
                    cmd.Parameters.AddWithValue("@ename", updatedename);
                    cmd.Parameters.AddWithValue("@job", updatedjob);
                    cmd.Parameters.AddWithValue("@sal", updatedsal);
                    cmd.Parameters.AddWithValue("@mgr_id", updatedmgr_id);
                    cmd.Parameters.AddWithValue("@hiredate", updatedhiredate);
                    cmd.Parameters.AddWithValue("@comm", updatedcomm);
                    cmd.Parameters.AddWithValue("@deptno", updateddeptno);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                        Console.WriteLine("Record updated successfully.");
                    else
                        Console.WriteLine("Failed to update record.");
                }
                else
                {
                    Console.WriteLine("Employee with empno {0} does not exist.", empnoToUpdate);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        //calling procedures with input parameter
        public static void StoredProc_WithParameter()
        {
            con = getconnection();
            try
            {
                Console.WriteLine("Enter The Employee no:");
                int empno = int.Parse(Console.ReadLine());
                cmd = new SqlCommand("getsal", con); //cmdtext here takes only the name of the procedure
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@empno", empno);

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine($"Employee Named {dr[0]} earns Rs. {dr[1]}");
                }
            }
            catch (SqlException )
            {
                Console.WriteLine("Some Sql error occured..");
            }
           
        }
        //calling procedure with output value
        public static void StoredProc_With_Output()
        {
            con = getconnection();
            Console.WriteLine("Enter Employee Name :");
            string ename = Console.ReadLine();
            cmd = new SqlCommand();
            cmd.CommandText = "getempsal";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            //we shall use a class called SqlParameter for input output values
            SqlParameter param1 = new SqlParameter
            {
                ParameterName = "@ename",
                SqlDbType = SqlDbType.NVarChar,
                Value = ename,
                Direction = ParameterDirection.Input
            };
            cmd.Parameters.Add(param1);

            //for output parameter
            SqlParameter outparam = new SqlParameter
            {
                ParameterName = "@sal",
                SqlDbType = SqlDbType.Float,
                Direction = ParameterDirection.Output
            };

            cmd.Parameters.Add(outparam);

            cmd.ExecuteScalar();
            Console.WriteLine("Salary of Employee : {0} is : {1}", ename, outparam.Value);
        }

        //method with scalar info. (one data of any type)
        public static void getScalar()
        {
            con = getconnection();
            cmd = new SqlCommand("Select count(empno) from tblEMP", con);
            int empcount = (int)cmd.ExecuteScalar(); //or

            int ecount = Convert.ToInt32(cmd.ExecuteScalar());
            Console.WriteLine("No. of employees : {0}", empcount);
        }

    }
}

    









