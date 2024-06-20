using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace BBS.SQLServerDAL
{
    /// <summary>
    /// ��װ�˶����ݿ�Ĳ���
    /// </summary>
    public sealed class SQLServerDALHelper
    {
        private static readonly string _sqlConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        /// <summary>
        /// ִ��SQL���
        /// </summary>
        /// <param name="sql">SQL���</param>
        public static void ExecuteSQLNonQurey(string sql)
        {
            SqlConnection connection = new SqlConnection(_sqlConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(sql, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        /// <summary>
        /// ִ��SQL��䷵��DATAREADER
        /// </summary>
        /// <param name="sql">sql���</param>
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
        /// ִ��SQL���
        /// </summary>
        /// <param name="sql">sql���</param>
        /// <returns>object����</returns>
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
        /// ִ�д洢����
        /// </summary>
        /// <param name="storedProcedureName">�洢������</param>
        /// <param name="parameters">����</param>
        /// <returns>object����</returns>
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
        /// ִ�д洢����
        /// </summary>
        /// <param name="storedProcedureName">�洢������</param>
        /// <param name="parameters">�޷���ֵ</param>
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
        /// ִ�д洢����
        /// </summary>
        /// <param name="storedProcedureName">�洢������</param>
        /// <param name="parameters">����</param>
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
