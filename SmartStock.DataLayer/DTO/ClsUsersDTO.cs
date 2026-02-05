using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartStock.DataLayer.DTO
{
    public class ClsUsersDTO
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public int EmployeeID { get; set; }
        public byte Permissions { get; set; }
    }
}
