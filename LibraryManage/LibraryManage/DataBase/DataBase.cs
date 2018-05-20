using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;

namespace LibraryManage
{
    public class DataBase
    {
        OleDbCommand myCommand = new OleDbCommand();

        public static OleDbConnection GetConnection()
        {
            OleDbConnection myConnection;
            //1.连接数据库
            string dbname;
            //获取数据库的位置，其中AppDomain.CurrentDomain.BaseDirectory为自动查找项目所在路径
            dbname = AppDomain.CurrentDomain.BaseDirectory + "\\DataBase\\DataBase.mdb";
            
            myConnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;DATA Source=" + dbname);
            return myConnection;
        }

        /// <summary>
        /// 执行查询语句，返回DataSet
        /// </summary>
        /// <param name="SQLString">查询语句</param>
        /// <returns>DataSet</returns>
        public static DataSet Query(string SQLString)
        {
            DataSet ds = new DataSet();
            OleDbConnection myConnection = new OleDbConnection();
            myConnection = DataBase.GetConnection();
            myConnection.Open();
            OleDbDataAdapter command = null;
            try
            {
                command = new OleDbDataAdapter(SQLString, myConnection);
                command.Fill(ds, "ds");
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                command.Dispose();

                if (myConnection != null)
                {
                    myConnection.Close();
                    myConnection.Dispose();
                }
            }
        }

         
        //运行增删改查查询语句------------
        public static Boolean MyExeQuery(string sqlString)
        {
            OleDbConnection myConnection = new OleDbConnection();
            myConnection = DataBase.GetConnection();
            myConnection.Open();
            OleDbCommand cmd = null;
            try
            {
                cmd = new OleDbCommand(sqlString, myConnection);
                cmd.ExecuteNonQuery();//执行SQLCMMAD
            }
            catch (Exception x)
            {
                return false;
            }
            finally
            {
                myConnection.Close();
                myConnection.Dispose();

            }
            return true;

        }
    }
}
