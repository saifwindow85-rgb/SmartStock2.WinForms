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
    public class ClsJobsData
    {
        public static ClsJobsDTO FindJobInfoByJobID(int JobID)
        {
            using(SqlConnection Connection = new SqlConnection(ClsDataAccessSettings.ConnectionString))
            {
                string Query = "Select * From Jobs Where JobID = @JobID";
                using(SqlCommand CMD = new SqlCommand(Query, Connection))
                {
                    Connection.Open();
                    CMD.Parameters.AddWithValue("@JobID", JobID);
                    using(SqlDataReader Reader = CMD.ExecuteReader())
                    {
                        if (!Reader.Read())
                            return null;

                        return new ClsJobsDTO
                        {
                            JobID = (int)Reader["JobID"],
                            JobTitle = (string)Reader["JobTitle"],
                            JobDescription = Reader["JobDescription"] as string
                        };
                    }
                }
            }
        }

        public static DataTable GetAllJobs()
        {
            DataTable dtJobs = new DataTable();
            using(SqlConnection Connection = new SqlConnection(ClsDataAccessSettings.ConnectionString))
            {
                string Query = "Select * From Jobs";
                using(SqlCommand CMD = new SqlCommand(Query, Connection))
                {
                    Connection.Open();
                    using(SqlDataReader Reader = CMD.ExecuteReader())
                    {
                        if(Reader.HasRows)
                        {
                            dtJobs.Load(Reader);
                        }
                    }
                }
            }
            return dtJobs;
        }
    }
}
