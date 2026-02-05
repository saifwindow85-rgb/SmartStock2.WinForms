using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartStock.BusinessLayer.Global_Objects;
using SmartStock.WinForms.loginScreen;

namespace SmartStock.WinForms
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        public static ClsCurrentUser CurrentUserContext;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            CurrentUserContext = new ClsCurrentUser();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin(CurrentUserContext));
        }
    }
}
