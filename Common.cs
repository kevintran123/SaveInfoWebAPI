using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyStmt.Models
{
    public class Common
    {
        public static string getMystmtConnString()
        {
            string connString = "";
            string DBName = "AgentDB";
            string DBServer = System.Configuration.ConfigurationManager.AppSettings["sqlServer"];

            connString = "data source=" + DBServer + ";initial catalog=" + DBName + ";user id=sa; password=password@1234; MultipleActiveResultSets=True;App=EntityFramework";

            return connString;
        }

    }
}