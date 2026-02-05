using SmartStock.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartStock.BusinessLayer
{
    public class ClsJob
    {
        public int JobID { get; set; }
        public string JobDescription { get; set; }
        public string JobTitle { get; set; }

       public ClsJob()
        {
            this.JobID = -1;
            this.JobTitle = string.Empty;
            this.JobDescription = string.Empty;
        }

        public ClsJob(int JobID,string JobTitle,string JobDescription)
        {
            this.JobID =JobID;
            this.JobTitle =JobTitle;
            this.JobDescription =JobDescription;
        }

        public static ClsJob FindJobInfo(int JobID)
        {
            var JobDto = ClsJobsData.FindJobInfoByJobID(JobID);
            if (JobDto == null)
                return null;

            return new ClsJob(JobDto.JobID, JobDto.JobTitle, JobDto.JobDescription);
        }
    }
}
