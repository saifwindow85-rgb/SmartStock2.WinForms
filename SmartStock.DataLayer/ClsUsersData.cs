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
    public  class ClsUsersData
    {
        public static ClsUsersDTO FindUserByID(string UserName,string Password)
        {
            using(SqlConnection Connection = new SqlConnection(ClsDataAccessSettings.ConnectionString))
            {
                string Query = "SELECT * From Users Where (UserName = @UserName) And (UserPassword = @UserPassword)";
                using(SqlCommand CMD = new SqlCommand(Query, Connection))
                {
                    Connection.Open();
                    CMD.Parameters.AddWithValue("@UserName", UserName);
                    CMD.Parameters.AddWithValue("@UserPassword", Password);
                    using(SqlDataReader Reader =  CMD.ExecuteReader())
                    {
                        if (!Reader.Read())
                            return null;

                        return new ClsUsersDTO
                        {
                            UserID = (int)Reader["UserID"],
                            UserName = (string)Reader["UserName"],
                            Password = (string)Reader["UserPassword"],
                            IsActive = (bool)Reader["IsActive"],
                            Permissions = (byte)Reader["Permissions"],
                            EmployeeID = (int)Reader["EmployeeID"]
                        };
                    }
                }
            }
        }

        public static int AddNewUser(string UserName,string Password,bool IsActive,byte Permissions,int EmployeeID)
        {
            int NewUserID = -1;
            using(SqlConnection Connection = new SqlConnection(ClsDataAccessSettings.ConnectionString))
            {
                string Query = "Insert Into Users (UserName,UserPassword,IsActive,Permissions,EmployeeID)" +
                    " Values(@UserName,@UserPassword,@IsActive,@Permissions,@EmployeeID);" +
                    " Select Scope_Identity();";
                using(SqlCommand CMD = new SqlCommand(Query, Connection))
                {
                    Connection.Open();
                    CMD.Parameters.AddWithValue("@UserName", UserName);
                    CMD.Parameters.AddWithValue("@UserPassword", Password);
                    CMD.Parameters.AddWithValue("@IsActive", IsActive);
                    CMD.Parameters.AddWithValue("@Permissions", Permissions);
                    CMD.Parameters.AddWithValue("@EmployeeID", EmployeeID);
                    object Result = CMD.ExecuteScalar();
                    if(Result != null && int.TryParse(Result.ToString(),out int NewID))
                    {
                        NewUserID = NewID;
                    }
                }
            }
            return NewUserID;
        }


        public static bool UpdateUsers(int UserID,string UserName,string Password,bool IsActive,int EmployeeID,byte Permissions)
        {
            int RowEffected = 0;
            using(SqlConnection Connection = new SqlConnection(ClsDataAccessSettings.ConnectionString))
            {
                string Query = "Update Users Set UserName = @UserName,UserPassword = @UserPassword,IsActive = @IsActive," +
                    " EmployeeID = @EmployeeID, Permissions = @Permissions Where UserID = @UserID";
                using(SqlCommand CMD = new SqlCommand(Query, Connection))
                {
                    Connection.Open();
                    CMD.Parameters.AddWithValue("@UserID", UserID);
                    CMD.Parameters.AddWithValue("@UserName", UserName);
                    CMD.Parameters.AddWithValue("@UserPassword", Password);
                    CMD.Parameters.AddWithValue("@IsActive", IsActive);
                    CMD.Parameters.AddWithValue("@EmployeeID", EmployeeID);
                    CMD.Parameters.AddWithValue("@Permissions", Permissions);
                    RowEffected = CMD.ExecuteNonQuery();
                }
            }
            return (RowEffected > 0);
        }


        public static bool Delete(int UserID)
        {
            int RowEffected = 0;
            using(SqlConnection Connection = new SqlConnection(ClsDataAccessSettings.ConnectionString))
            {
                string Query = "Delete From Users Where UserID = @UserID";
                using(SqlCommand CMD = new SqlCommand(Query,Connection))
                {
                    Connection.Open();
                    CMD.Parameters.AddWithValue("@UserID", UserID);
                    RowEffected = CMD.ExecuteNonQuery();
                }
            }
            return (RowEffected > 0);
        }


        public static bool IsUserExist(int UserID)
        {
            using (SqlConnection Connection = new SqlConnection(ClsDataAccessSettings.ConnectionString))
            {
                string Query = "Select 1 From Users Where UserID = @UserID";
                using (SqlCommand CMD = new SqlCommand(Query, Connection))
                {
                    Connection.Open();
                    CMD.Parameters.AddWithValue("@UserID", UserID);
                    object Result = CMD.ExecuteScalar();
                    return Result != null;
                }
            }
        }

        public static DataTable GetAllUsers()
        {
            DataTable dtUsers = new DataTable();
            using(SqlConnection Connection = new SqlConnection(ClsDataAccessSettings.ConnectionString))
            {
                string Query = "Select UserID,UserName,IsActive,Permissions,EmployeeID";
                using(SqlCommand CMD = new SqlCommand(Query,Connection))
                {
                    Connection.Open();
                    using(SqlDataReader Reader = CMD.ExecuteReader())
                    {
                        if(Reader.HasRows)
                        {
                            dtUsers.Load(Reader);
                        }
                    }
                }
            }
            return dtUsers;
        }
    }
}
