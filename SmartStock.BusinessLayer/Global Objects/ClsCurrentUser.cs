using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartStock.BusinessLayer.Global_Objects
{
    public class ClsCurrentUser
    {
        public ClsUser CurrentUser { get; private set; }

        public bool IsLoggedIn => CurrentUser != null;
        public void LogIn(ClsUser User)
        {
            CurrentUser = User; 
        }

        public void LogOut()
        {
            CurrentUser = null; 
        }
    }
}
