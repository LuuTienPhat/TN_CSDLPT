using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TN_CSDLPT.utils
{
    internal class DatabaseUtils
    {
        public static string BuildQuery(string name, string[] args)
        {
            string query = null;
            if(name != null)
            {
                query = string.Format(query, args);
            }
            return query;
        }
    }
}
