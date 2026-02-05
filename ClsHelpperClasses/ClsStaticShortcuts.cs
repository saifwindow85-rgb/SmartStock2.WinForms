using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsHelpperClasses
{
    public class ClsStaticShortcuts
    {
        public static object ToDbValue(string Value)
        {
            return string.IsNullOrEmpty(Value)?DBNull.Value : (object)Value;
        }

        public static int? FromDbInt(object Value)
        {
            return Value == DBNull.Value? (int?)null :Convert.ToInt32(Value);
        }

        public static object ToDbValue(int? Value)
        {
            return Value.HasValue ? (object)Value.Value : DBNull.Value;
        }
    }
}
