using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace OOPsAssignment
{
    class DatabaseConnection
    {
        public static OleDbConnection cn;
        public static void GetConnecton()
        {
            // oledb connector with the database resource link
            cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=OOPsAssignmentDB.accdb");
            cn.Open(); // open the connection
        }

    }
}
