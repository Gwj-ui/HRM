using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBHelper
    {
        public static string connStr = ConfigurationManager.ConnectionStrings["HRMConnStr"].ToString();

        #region 执行SQL语句，返回受影响的行数
        /// <summary>
        /// 执行SQL语句，返回受影响的行数
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="typename"></param>
        /// <param name="para"></param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string sql, CommandType typename, SqlParameter[] para)
        {
            int count = 0;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = typename;

                if (para != null)
                {
                    cmd.Parameters.AddRange(para);
                }

                try
                {
                    conn.Open();
                    count = cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    throw;
                }
            }

            return count;
        }
        #endregion

        #region 执行SQL语句，返回DataTable对象
        /// <summary>
        /// 执行SQL语句，返回DataTable对象
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="typename"></param>
        /// <param name="para"></param>
        /// <returns></returns>
        public static DataTable ExecuteTable(string sql, CommandType typename, SqlParameter[] para)
        {
            DataTable dt;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = typename;

                if (para != null)
                {
                    cmd.Parameters.AddRange(para);
                }

                try
                {
                    dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
                catch (Exception)
                {

                    throw;
                }
            }

            return dt;
        }
        #endregion

        #region 执行SQL语句，返回第一行第一列的值
        /// <summary>
        /// 执行SQL语句，返回第一行第一列的值
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="typename"></param>
        /// <param name="para"></param>
        /// <returns></returns>
        public static object ExecuteScalar(string sql, CommandType typename, SqlParameter[] para)
        {
            object o;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = typename;

                if (para != null)
                {
                    cmd.Parameters.AddRange(para);
                }

                try
                {
                    conn.Open();
                    o = cmd.ExecuteScalar();
                }
                catch (Exception)
                {

                    throw;
                }
            }

            return o;
        }
        #endregion

        #region 执行SQL语句，返回DataReader对象
        /// <summary>
        /// 执行SQL语句，返回DataReader对象
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="typename"></param>
        /// <param name="para"></param>
        /// <returns></returns>
        public static SqlDataReader ExecuteReader(string sql, CommandType typename, SqlParameter[] para)
        {
            SqlDataReader dr = null;
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(sql, conn);
            if (para != null)
            {
                cmd.Parameters.AddRange(para);
            }

            try
            {
                conn.Open();
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception)
            {

                throw;
            }

            return dr;
        }
        #endregion

        #region 执行SQL语句，返回受影响的行数(事务处理)
        /// <summary>
        /// 执行SQL语句，返回受影响的行数(事务处理)
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="typename"></param>
        /// <param name="para"></param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string sql, CommandType typename, SqlParameter[] para, SqlTransaction tran)
        {
            int count = 0;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = tran.Connection;
            cmd.Transaction = tran;
            cmd.CommandText = sql;
            cmd.CommandType = typename;
            if (para != null)
            {
                cmd.Parameters.AddRange(para);
            }
            try
            {
                count = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            return count;
        }
        #endregion

        #region 执行SQL语句，返回第一行第一列的值(事务处理）
        /// <summary>
        /// 执行SQL语句，返回第一行第一列的值(事务处理）
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="typename"></param>
        /// <param name="para"></param>
        /// <returns></returns>
        public static object ExecuteScalar(string sql, CommandType typename, SqlParameter[] para, SqlTransaction tran)
        {
            object o;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = tran.Connection;
            cmd.Transaction = tran;
            cmd.CommandText = sql;
            cmd.CommandType = typename;
            if (para != null)
            {
                cmd.Parameters.AddRange(para);
            }
            try
            {
                o = cmd.ExecuteScalar();
            }
            catch (Exception)
            {
                throw;
            }
            return o;
        }
        #endregion
    }
}
