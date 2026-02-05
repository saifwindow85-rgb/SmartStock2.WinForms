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
    public  class ClsPeopleData
    {
        public static ClsPeopleDTO FindPersonByID(int PersonID)
        {
           using(SqlConnection Connection = new SqlConnection(ClsDataAccessSettings.ConnectionString))
            {
                string Query = "Select PersonID,FirstName,SecondName,ThirdName,LastName,DateOfBirth,Email,Phone,CountryID,Gender From People Where PersonID = @PersonID";

                using(SqlCommand CMD = new SqlCommand(Query, Connection))
                {
                    Connection.Open();
                    CMD.Parameters.AddWithValue("@PersonID", PersonID);
                    using(SqlDataReader Reader = CMD.ExecuteReader())
                    {
                        if (!Reader.Read())
                            return null;

                        return new ClsPeopleDTO
                        {
                            PersonID = (int)Reader["PersonID"],
                            FirstName = (string)Reader["FirstName"],
                            SecondName = (string)Reader["SecondName"],
                            ThirdName = (string)Reader["ThirdName"],
                            LastName = Reader["LastName"] as string,
                            DateOfBirth = (DateTime)Reader["DateOfBirth"],
                            Email = Reader["Email"] as string,
                            Phone = (string)Reader["Phone"],
                            CountryID = (int)Reader["CountryID"],
                            Gender = (byte)Reader["Gender"]
                        };
                    }
                }
            }
        }

        public static int AddNewPerson(string FirstName,string SecondName,string ThirdName,
            string LastName,DateTime DateOfBirth,string Email,string Phone,int CountryID,byte?Gender)
        {
            int NewPersonID = -1;
            using(SqlConnection Connection = new SqlConnection(ClsDataAccessSettings.ConnectionString))
            {
                string Query = "Insert Into People(FirstName,SecondName,ThirdName,LastName,DateOfBirth,Email,Phone,CountryID,Gender)" +
                    "  Values(@FirstName,@SecondName,@ThirdName,@LastName,@DateOfBirth,@Email,@Phone,@CountryID,Gender);" +
                    " Select Scope_Identity();";
                using(SqlCommand CMD = new SqlCommand(Query, Connection))
                {
                    Connection.Open();
                    CMD.Parameters.AddWithValue("@FirstName", FirstName);
                    CMD.Parameters.AddWithValue("@SecondName", SecondName);
                    CMD.Parameters.AddWithValue("@ThirdName", ThirdName);
                    CMD.Parameters.AddWithValue("@LastName", ClsStaticShortcuts.ToDbValue(LastName));
                    CMD.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                    CMD.Parameters.AddWithValue("@Email",ClsStaticShortcuts.ToDbValue(Email));
                    CMD.Parameters.AddWithValue("@Phone", Phone);
                    CMD.Parameters.AddWithValue("@CountryID", CountryID);
                    CMD.Parameters.AddWithValue("@Gender", Gender == null ? DBNull.Value : (object)Gender);
                    object Result = CMD.ExecuteScalar();
                    if(Result != null && int.TryParse(Result.ToString(),out int NewID))
                    {
                        NewPersonID = NewID;
                    }
                }
            }
            return NewPersonID;
        }


        public static bool UpDatePerson(int PersonID,string FirstName,string SecondName,
            string ThirdName,string LastName,DateTime DateOfBirth,string Email,string Phone,int CountryID,byte?Gender)
        {
            int RowEffected = 0;
            using(SqlConnection Connection = new SqlConnection(ClsDataAccessSettings.ConnectionString))
            {
                string Query = "Update People Set FirstName =@FirstName," +
                    "  SecondName =@SecondName,ThirdName =@ThirdName,LastName =@LastName," +
                    "   DateOfBirth =@DateOfBirth,Email =@Email,Phone =@Phone,CountryID =@CountryID , Gender =@Gender" +
                    " Where PersonID =@PersonID";

                using (SqlCommand CMD = new SqlCommand(Query, Connection))
                {
                    Connection.Open();
                    CMD.Parameters.AddWithValue("@PersonID", PersonID);
                    CMD.Parameters.AddWithValue("@FirstName", FirstName);
                    CMD.Parameters.AddWithValue("@SecondName", SecondName);
                    CMD.Parameters.AddWithValue("@ThirdName", ThirdName);
                    CMD.Parameters.AddWithValue("@LastName", ClsStaticShortcuts.ToDbValue(LastName));
                    CMD.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                    CMD.Parameters.AddWithValue("@Email", ClsStaticShortcuts.ToDbValue(Email));
                    CMD.Parameters.AddWithValue("@Phone", Phone);
                    CMD.Parameters.AddWithValue("@CountryID", CountryID);
                    CMD.Parameters.AddWithValue("@Gender", Gender == null ? DBNull.Value : (object)Gender);
                    RowEffected = CMD.ExecuteNonQuery();
                }

            }
            return (RowEffected > 0);
        }

        public static bool IsPersonExist(int PersonID)
        {
            using(SqlConnection Connection = new SqlConnection(ClsDataAccessSettings.ConnectionString))
            {
                string Query = "Select 1 From People Where PersonID = @PersonID";
                using(SqlCommand CMD = new SqlCommand(Query, Connection))
                {
                    Connection.Open();
                    CMD.Parameters.AddWithValue("@PersonID", PersonID);
                    object Result = CMD.ExecuteScalar();
                    return Result != null;
                }
            }
           
        }

        public static bool Delete(int PersonID)
        {
            int RowEffected = 0;
            using(SqlConnection Connection = new SqlConnection(ClsDataAccessSettings.ConnectionString))
            {
                string Query = "Delete From People Where PersonID = @PersonID";
                using(SqlCommand CMD = new SqlCommand(Query,Connection))
                {
                    Connection.Open();
                    CMD.Parameters.AddWithValue("@PersonID", PersonID);
                    RowEffected = CMD.ExecuteNonQuery();
                }
            }
            return (RowEffected > 0);
        }


        public static DataTable GetAllpeople()
        {
            DataTable dtPeople = new DataTable();
            using (SqlConnection Connection = new SqlConnection(ClsDataAccessSettings.ConnectionString))
            {

                string Query = "Select PersonID,FirstName,SecondName,ThirdName,LastName,DateOfBirth,Email,Phone,CountryID From People";
                using (SqlCommand CMD = new SqlCommand(Query, Connection))
                {
                    Connection.Open();
                    using (SqlDataReader Reader = CMD.ExecuteReader())
                    {
                        if (Reader.HasRows)
                        {
                            dtPeople.Load(Reader);
                        }
                    }
                }
                return dtPeople;
            }
        }
    }
}
