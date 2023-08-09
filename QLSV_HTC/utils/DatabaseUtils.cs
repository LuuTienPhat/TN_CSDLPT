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
            if (name != null)
            {
                query = string.Format(name, args);
            }
            return query;
        }

        public static string BuildQuery2(string name, string args)
        {
            string query = null;
            if (name != null)
            {
                query = string.Format(BuildStoreProcedure(name, 1), args);
            }
            return query;
        }

        public static string BuildQuery2(string name, string[] args)
        {
            string query = null;
            if (name != null)
            {
                query = string.Format(BuildStoreProcedure(name, args.Length), args);
            }
            return query;
        }

        public static string BuildQuery(string name, string args)
        {
            string query = null;
            if (name != null)
            {
                query = string.Format(name, args);
            }
            return query;
        }

        public static string BuildStoreProcedure(string storeProcedureName, int paramsCount)
        {
            string sp = null;
            if (storeProcedureName != null && storeProcedureName.Length > 0)
            {
                List<string> args = new List<string>();
                for (int i = 0; i < paramsCount; i++)
                {
                    args.Add($"N'{i}'");
                }

                string param = string.Join(",", args);

                sp = string.Format("EXEC {0} {1}", storeProcedureName, param);
            }
            return sp;
        }
    }
}
