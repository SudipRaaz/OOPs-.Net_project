using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.OleDb;

namespace OOPsAssignment
{
    class logInformation
    {
        public DataTable ViewLog()
        {
            DatabaseConnection.GetConnecton();
            string sql = "SELECT * FROM Log_Details";
            OleDbDataAdapter da = new OleDbDataAdapter(sql, DatabaseConnection.cn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Log_Details");
            return ds.Tables[0];
        }

        public void SaveLog(string action)
        {
            string date = DateTime.Now.ToShortDateString();
            string time = DateTime.Now.ToLongTimeString();
            DatabaseConnection.GetConnecton();
            string sql = "insert into Log_Details values (@date, @time, @action)";
            OleDbCommand cmd = new OleDbCommand(sql, DatabaseConnection.cn);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            //OleDbCommandBuilder odc = new OleDbCommandBuilder(da);

            cmd.Parameters.AddWithValue("@date", date);
            cmd.Parameters.AddWithValue("@time", time);
            cmd.Parameters.AddWithValue("@action", action);

            DataSet ds = new DataSet();
            da.Fill(ds);

            

            DataRow NewDr = ds.Tables[0].NewRow();
            NewDr["Date"] = date;
            NewDr["Time"] = time;
            NewDr["Action"] = action;

            ds.Tables[0].Rows.Add(NewDr);
            DataSet dataSetChanges = ds.GetChanges();
            da.Update(dataSetChanges);
            ds.AcceptChanges();
        }
    }
}
