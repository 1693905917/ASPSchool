using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace BBS.SQLServerDAL
{
    /// <summary>
    /// 封装了对数据库的操作
    /// </summary>
    public sealed class SQLServerDALHelper
    {
        private static readonly string _sqlConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        /// <summary>
        /// 执行SQL语句
        /// </summary>
        /// <param name="sql">SQL语句</param>
        public static void ExecuteSQLNonQurey(string sql)
        {
            SqlConnection connection = new SqlConnection(_sqlConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(sql, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        /// <summary>
        /// 执行SQL语句返回DATAREADER
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <returns>datareader</returns>
        public static SqlDataReader ExecuteSQLReader(string sql)
        {
            SqlConnection connection = new SqlConnection(_sqlConnectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            SqlDataReader sqlReader = command.ExecuteReader();
            return sqlReader;
        }
        /// <summary>
        /// 执行SQL语句
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <returns>object对象</returns>
        public static object ExecuteSQLScalar(string sql)
        {
            SqlConnection connection = new SqlConnection(_sqlConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(sql,connection );
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
            command.Connection = connection;
            return command.ExecuteScalar();
        }
        /// <summary>
        /// 执行存储过程
        /// </summary>
        /// <param name="storedProcedureName">存储过程名</param>
        /// <param name="parameters">参数</param>
        /// <returns>object对象</returns>
        public static object ExecuteProcedureSaclar(string storedProcedureName,IDataParameter [] parameters)
        {
            SqlConnection connection = new SqlConnection(_sqlConnectionString );
            connection.Open();
            SqlCommand command = new SqlCommand(storedProcedureName ,connection );
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = connection;
            return command.ExecuteScalar();
        
        }
        /// <summary>
        /// 执行存储过程
        /// </summary>
        /// <param name="storedProcedureName">存储过程名</param>
        /// <param name="parameters">无返回值</param>
        public static void ExecuteProcedureNonQuery(string storedProcedureName, IDataParameter[] parameters)
        {
            SqlConnection connection = new SqlConnection(_sqlConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(storedProcedureName, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = connection;
            if (parameters != null)
            {
                foreach (SqlParameter parameter in parameters)
                {
                    command.Parameters.Add(parameter);
                }
            }
            command.ExecuteNonQuery();
            connection.Close();  
           
        }
        /// <summary>
        /// 执行存储过程
        /// </summary>
        /// <param name="storedProcedureName">存储过程名</param>
        /// <param name="parameters">参数</param>
        /// <returns>SQLdatareader</returns>
        public static SqlDataReader ExecuteProcedureReader(string storedProcedureName, IDataParameter[] parameters)
        {
            SqlConnection connection = new SqlConnection(_sqlConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(storedProcedureName, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = connection;
            if (parameters != null)
            {
                foreach (SqlParameter parameter in parameters)
                {
                    command.Parameters.Add(parameters);
                }
            }
            SqlDataReader sqlReader = command.ExecuteReader();
            return sqlReader;
        }
    }
}
