using ClsHelpperClasses;
using SmartStock.DataLayer.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartStock.DataLayer
{
    public class ClsEmployeesData
    {
        public static ClsEmployeeDTO FindEmployeeByEmployeeID(int EmployeeID)
        {
            using(SqlConnection Connection = new SqlConnection(ClsDataAccessSettings.ConnectionString))
            {
                string Query = "Select EmployeeID,Salary,CreatedByEmployeeID,ManagerID,JobID,PersonID From Employees Where EmployeeID = @EmployeeID";
                using(SqlCommand CMD = new SqlCommand(Query, Connection))
                {
                    Connection.Open();
                    CMD.Parameters.AddWithValue("@EmployeeID", EmployeeID);
                    using(SqlDataReader Reader = CMD.ExecuteReader())
                    {
                        if (!Reader.Read())
                            return null;

                        return new ClsEmployeeDTO
                        {
                            EmployeeID = (int)Reader["EmployeeID"],
                            Salary = (decimal)Reader["Salary"],
                            CreatedByEmployeeID = ClsStaticShortcuts.FromDbInt(Reader["CreatedByEmployeeID"]),
                            ManagerID = ClsStaticShortcuts.FromDbInt(Reader["ManagerID"]),
                            JobID = (int)Reader["JobID"],
                            PersonID = (int)Reader["PersonID"]
                        };
                    }
                }
            }
        }

        public static int AddNewEmployee( decimal Salary,int?CreatedByEmployeeID,int?ManagerID,int JobID,int PersonID)
        {
            int NewEmployeeID = -1;
            using(SqlConnection Connection = new SqlConnection(ClsDataAccessSettings.ConnectionString))
            {
                string Query = "Insert Into Employees (Salary,CreatedByEmployeeID,ManagerID,JobID,PersonID)" +
                    " Values(@Salary,@CreatedByEmployeeID,@ManagerID,@JobID,@PersonID);" +
                    " Select Scope_Identity();";
                using (SqlCommand CMD = new SqlCommand(Query, Connection))
                {
                    Connection.Open();
                    CMD.Parameters.AddWithValue("@Salary", Salary);
                    CMD.Parameters.AddWithValue("@CreatedByEmployeeID", CreatedByEmployeeID);
                    CMD.Parameters.AddWithValue("@ManagerID", ManagerID);
                    CMD.Parameters.AddWithValue("@JobID", JobID);
                    CMD.Parameters.AddWithValue("@PersonID", PersonID);
                    object Result = CMD.ExecuteScalar();
                    if(Result != null && int.TryParse(Result.ToString(),out int NewID))
                    {
                        NewEmployeeID = NewID;
                    }
                }
            }
            return NewEmployeeID;
        }

        public static bool UpDateEmployee(int EmployeeID,decimal Salary,int?CreatedByEmployeeID,int?ManagerID,int JobID,int PersonID)
        {
            int RowEffcted = 0;
            using(SqlConnection Connection = new SqlConnection(ClsDataAccessSettings.ConnectionString))
            {
                string Query = "Update Employees Set Salary = @Salary," +
                    " CreatedByEmployeeID = @CreatedByEmployeeID," +
                    " ManagerID = @ManagerID," +
                    " JobID = @JobID," +
                    " PersonID =@PersonID" +
                    " Where EmployeeID = @EmployeeID";
                using(SqlCommand CMD = new SqlCommand(Query,Connection))
                {
                    Connection.Open();
                    CMD.Parameters.AddWithValue("@EmployeeID", EmployeeID);
                    CMD.Parameters.AddWithValue("@Salary", Salary);
                    CMD.Parameters.AddWithValue("@CreatedByEmployeeID", ClsStaticShortcuts.ToDbValue(CreatedByEmployeeID));
                    CMD.Parameters.AddWithValue("@ManagerID", ClsStaticShortcuts.ToDbValue(ManagerID));
                    CMD.Parameters.AddWithValue("@JobID", JobID);
                    CMD.Parameters.AddWithValue("@PersonID", PersonID);
                    RowEffcted = CMD.ExecuteNonQuery();
                }
            }
            return (RowEffcted > 0);
        }


        public static bool IsEmployeeExist(int EmployeeID)
        {
            using(SqlConnection Connection = new SqlConnection(ClsDataAccessSettings.ConnectionString))
            {
                string Query = "Select 1 From Employees Where EmployeeID = @EmployeeID";
                using(SqlCommand CMD = new SqlCommand(Query , Connection))
                {
                    CMD.Connection.Open();
                    CMD.Parameters.AddWithValue("@EmployeeID", EmployeeID);
                    object Result = CMD.ExecuteScalar();
                    return Result != null;
                }
            }
        }

        public static bool Delete(int EmployeeID)
        {
            int RowEffected = 0;
            using(SqlConnection Connection = new SqlConnection(ClsDataAccessSettings.ConnectionString))
            {
                string Query = "Delete From Employees Where EmployeeID = @EmployeeID";
                using(SqlCommand CMD = new SqlCommand(Query,Connection))
                {
                    Connection.Open();
                    CMD.Parameters.AddWithValue("@EmployeeID", EmployeeID);
                    RowEffected = CMD.ExecuteNonQuery();

                }
            }
            return (RowEffected > 0);
        }

        public static DataTable GetAllEmployeesInfo()
        {
            DataTable dtEmployees = new DataTable();
            using (SqlConnection Connection = new SqlConnection(ClsDataAccessSettings.ConnectionString))
            {
                string Query = "Select * From VW_EmployeesFullInfo";
                using (SqlCommand CMD = new SqlCommand(Query, Connection))
                {
                    Connection.Open();
                    using (SqlDataReader Reader = CMD.ExecuteReader())
                    {
                        if (Reader.HasRows)
                        {
                            dtEmployees.Load(Reader);
                        }
                    }
                }
            }
            return dtEmployees;
        }

    }
}
