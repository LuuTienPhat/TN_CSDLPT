using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TN_CSDLPT.utils
{
    internal class DateTimeHelper
    {
        public static string DateTimeToString(DateTime dateTime, string format)
        {
            string dateTimeString = null;
            try
            {
                dateTime.ToString(format);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return dateTimeString;
        }
    }
}
