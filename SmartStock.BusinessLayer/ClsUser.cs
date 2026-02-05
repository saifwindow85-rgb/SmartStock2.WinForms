using SmartStock.DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartStock.BusinessLayer
{
    public  class ClsUser
    {
        public enum enMood { Add = 0 , Update = 1 }
        private enMood _Mood = enMood.Add;
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public byte Permissions { get; set; }
        public int EmployeeID { get; set; }
        ClsEmployee EmployeeInfo { get; set; }

        public ClsUser()
        {
            this.UserID = -1;
            this.UserName = string.Empty;
            this.Password = string.Empty;
            this.IsActive = false;
            this.Permissions = 2;
            this.EmployeeID = -1;
            this.EmployeeInfo = null;
        }

        public ClsUser(int UserID,string UserName,string Password,bool IsActive,byte Permissions,int EmployeeID)
        {
            this.UserID = UserID;
            this.UserName = UserName;
            this.Password = Password;
            this.IsActive = IsActive;
            this.Permissions = Permissions;
            this.EmployeeID = EmployeeID;
            this.EmployeeInfo = ClsEmployee.FindEmployeeByID(EmployeeID);

        }

        private bool _AddNew()
        {
            this.UserID = ClsUsersData.AddNewUser(this.UserName, this.Password, this.IsActive, this.Permissions, this.EmployeeID);
            return (this.UserID != -1);
        }

        private bool _Update()
        {
            return ClsUsersData.UpdateUsers(this.UserID, this.UserName, this.Password, this.IsActive, this.EmployeeID, this.Permissions);
        }

        public bool Save()
        {
            switch(_Mood)
            {
                case enMood.Add:
                    {
                        if (_AddNew())
                        {
                            _Mood = enMood.Update;
                            return true;
                        }
                        else
                            return false;
                    }

                case enMood.Update:
                    return _Update();
            }
            return false;
        }

        public bool Delete()
        {
            if (this.Permissions != 0)
                return false;

            return ClsUsersData.Delete(this.UserID);
        }

        public static ClsUser Find(string UserName,string Password)
        {
            var UserDto = ClsUsersData.FindUserByID(UserName,Password);
                if (UserDto == null)
                return null;


            return new ClsUser(UserDto.UserID,UserDto.UserName,UserDto.Password,UserDto.IsActive,UserDto.Permissions,UserDto.EmployeeID);
        }

        public static DataTable GetAllUsers()
        {
            return ClsUsersData.GetAllUsers();
        }
    }
}
