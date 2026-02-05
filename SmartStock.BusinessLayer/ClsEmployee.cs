using SmartStock.DataLayer;
using SmartStock.DataLayer.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartStock.BusinessLayer
{
    
    public class ClsEmployee
    {
    public enum enMood { Add = 0 , Update = 1 }
    private enMood _Mood = enMood.Add;

        public int EmployeeID { get; set; }
        public decimal Salary { get; set; }
        public int ? CreatedByEmployeeID { get; set; }
        public int? ManagerID { get; set; }
        public int JobID { get; set; } 
        ClsJob JobInfo { get; set; }
        public int PersonID { get; set; }
        public ClsPeople PersonInfo;

        public ClsEmployee()
        {
            this.EmployeeID = -1;
            this.Salary = 0;
            this.CreatedByEmployeeID = null;
            this.ManagerID = null;
            this.JobID = -1;
            this.PersonID = -1;
            this.PersonInfo = null;
            this.JobInfo = null;
            _Mood = enMood.Add;
        }

        public ClsEmployee(int EmployeeID,decimal Salary,int?CreatedByEmployeeID,int?ManagerID,int JobID,int PersonID)
        {
            this.EmployeeID =EmployeeID;
            this.Salary =Salary;
            this.CreatedByEmployeeID=CreatedByEmployeeID;
            this.ManagerID =ManagerID;
            this.JobID =JobID;
            this.JobInfo = ClsJob.FindJobInfo(JobID);
            this.PersonID =PersonID;
            this.PersonInfo = ClsPeople.FindPersonByID(PersonID);
            _Mood = enMood.Update;
        }

        private bool _AddNew()
        {
            this.EmployeeID = ClsEmployeesData.AddNewEmployee(this.Salary,this.CreatedByEmployeeID,this.ManagerID,this.JobID,this.PersonID);
            return (this.EmployeeID != -1);
        }

        private bool _Update()
        {
            return ClsEmployeesData.UpDateEmployee(this.EmployeeID, this.Salary, this.CreatedByEmployeeID, this.ManagerID, this.JobID, this.PersonID);
        }

        public bool Delete()
        {
            return ClsEmployeesData.Delete(this.EmployeeID);
        }

        public static bool IsExist(int EmployeeID)
        {
            return ClsEmployeesData.IsEmployeeExist(EmployeeID);
        }

        public static ClsEmployee FindEmployeeByID(int EmployeeID)
        {
            var DtoEmployee = ClsEmployeesData.FindEmployeeByEmployeeID(EmployeeID);
            if (DtoEmployee == null)
                return null;

            return new ClsEmployee(DtoEmployee.EmployeeID, DtoEmployee.Salary,
                DtoEmployee.CreatedByEmployeeID,
                DtoEmployee.ManagerID, DtoEmployee.JobID, DtoEmployee.PersonID);
        }

        public static DataTable GetAllEmployees()
        {
            return ClsEmployeesData.GetAllEmployeesInfo();
        }
    }
}
