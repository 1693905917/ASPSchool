using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;


namespace DAL
{
    public class DALUser
    {
        public void AddUser(string name, string md5pwd, int lever)
        {

            string ConnStr = "Provider=Microsoft.Jet.OleDb.4.0; Data Source=" + System.Web.HttpContext.Current.Server.MapPath("App_Data/manager.mdb");
            OleDbConnection conn = new OleDbConnection(ConnStr);
            conn.Open();
            string InserStr = "Insert Into Admin(uname, upwd, ulevel) Values('" + name + "','" + md5pwd + "','" + lever + "')";
            OleDbCommand cmd = new OleDbCommand(InserStr, conn);
            cmd.ExecuteNonQuery();            
            conn.Close();
        }

        public DataTable ToTab()
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = "Provider=Microsoft.Jet.OleDb.4.0; Data Source=" + System.Web.HttpContext.Current.Server.MapPath("App_Data/manager.mdb");
            string SqlStr = "select * from Admin";
            OleDbDataAdapter da = new OleDbDataAdapter(SqlStr, conn);
            DataTable dt = new DataTable();		//创建DataTable对象
            da.Fill(dt);		//填充DataTable对象
            conn.Close();
            return dt;
        }
    }
}
