using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Configuration;

namespace UserInfo
{
    public class CheckUser
    {
        private string username;		//声明字段变量
        private string userpwd;

        public string UserName		
        {
            get { return username; }
            set { username = value; }
        }
        public string UserPwd
        {
            get { return userpwd; }
            set { userpwd = value; }
        }

        public int IsPass()
        {
            string ConnStr = ConfigurationManager.ConnectionStrings["ConnString"].ToString();
            int userlevel;
            using (OleDbConnection conn = new OleDbConnection(ConnStr))
            {
                conn.Open();
                string StrSQL = "select ulevel from Admin where uname='" + username + "'and upwd='" + userpwd + "'";
                OleDbCommand com = new OleDbCommand(StrSQL, conn);
                OleDbDataReader dr = com.ExecuteReader();	//调用ExecuteReader()方法得到dr对象
                dr.Read();		//调用Read()方法得到返回记录集
                
                if (dr.HasRows)		//如果有返回记录存在
                {
                    userlevel = int.Parse(dr["ulevel"].ToString());		//获取返回记录中“uleverl”字段值
                }
                else			//如果dr中不包含任何记录，即数据库中没有符合条件的记录
                {
                    userlevel = -1;
                }                
            }
            return userlevel;
        }


    }
}
