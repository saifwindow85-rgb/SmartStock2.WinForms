using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartStock.DataLayer
{
    public class clsCountriesData
    {

        public static ClsCountryDTO FindCountryByID(int CountryID)
        {
           
            using (SqlConnection Connection = new SqlConnection(ClsDataAccessSettings.ConnectionString))
            {
                string Query = "Select * From Countries Where CountryID = @CountryID";
                using (SqlCommand CMD = new SqlCommand(Query, Connection))
                {
                    CMD.Parameters.AddWithValue("@CountryID", CountryID);
                    Connection.Open();
                    using (SqlDataReader Reader = CMD.ExecuteReader())
                    {
                        if (!Reader.Read())
                            return null;

                        return new ClsCountryDTO
                        {
                            CountryID = (int)Reader["CountryID"],
                            CountryName = Reader["CountryName"] as string,
                            CountryCode = Reader["CountryCode"] as string
                        };

                    }
                }
            }
           
        }
        

        public static DataTable GetALlCountries()
        {
            DataTable dtCountries = new DataTable();
            using (SqlConnection Connection = new SqlConnection(ClsDataAccessSettings.ConnectionString))
            {

                string Query = "Select Countries.CountryID,Countries.CountryName,Countries.CountryCode From Countries";
                using (SqlCommand CMD = new SqlCommand(Query, Connection))
                {
                    Connection.Open();
                    using (SqlDataReader Reader = CMD.ExecuteReader())
                    {
                        if (Reader.HasRows)
                        {
                            dtCountries.Load(Reader);
                        }
                    }
                }
                return dtCountries;
            }
        }

        public static DataTable GetCountriesNames()
        {
            DataTable dtCountries = new DataTable();
            using (SqlConnection Connection = new SqlConnection(ClsDataAccessSettings.ConnectionString))
            {

                string Query = "Select Countries.CountryName From Countries";
                using (SqlCommand CMD = new SqlCommand(Query, Connection))
                {
                    Connection.Open();
                    using (SqlDataReader Reader = CMD.ExecuteReader())
                    {
                        if (Reader.HasRows)
                        {
                            dtCountries.Load(Reader);
                        }
                    }
                }
            }
            return dtCountries;
        }
    }
}
