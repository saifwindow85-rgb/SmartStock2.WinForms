using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartStock.DataLayer.DTO
{
    public class ClsEmployeeDTO
    {
        public int EmployeeID { get; set; }
        public decimal Salary { get; set; }
        public int? CreatedByEmployeeID { get; set; }
        public int ? ManagerID { get; set; }
        public int JobID { get; set; }
        public int PersonID { get; set; }
    }
}
