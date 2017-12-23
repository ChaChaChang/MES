using Oracle.DataAccess.Client;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace MES
{
    class SQLUtility
    {
        string sMyConnection_String;
        int iMyDB_Source;
        enum DataBase_Sources { Oracle_11g, SQL_Server };

        //constructor
        public SQLUtility()
        {
            //Get Oracle MESDB1 Connection String from the App settins.
            Ini_DBConns(out iMyDB_Source,out sMyConnection_String);
        }

        private static void Ini_DBConns(out int iDb, out string sConn)
        {
            sConn = null;
            iDb = 0;

            iDb = Properties.Settings.Default.DB_SOURCE;

            switch (iDb)
            {
                case (int)DataBase_Sources.Oracle_11g:
                    sConn = Properties.Settings.Default.MESDB1_Conn;
                    break;
                case (int)DataBase_Sources.SQL_Server:
                    break;
                default:
                    break;
            }
        }

        public DataTable GetDataTable_BySQLString(string SQL_Query_String)
        {

            DataTable dtRecord = new DataTable(); ;

            switch (iMyDB_Source)
            {
                case (int)DataBase_Sources.Oracle_11g:

                    OracleConnection oraConn = new OracleConnection(sMyConnection_String);

                    try
                    {
                        oraConn.Open();

                        OracleCommand oraCmd = new OracleCommand(SQL_Query_String, oraConn);
                        oraCmd.CommandType = CommandType.Text;

                        OracleDataReader oraDr = oraCmd.ExecuteReader();
                        dtRecord.Load(oraDr);
                        oraDr.Close();

                        oraCmd.Dispose();
                    }
                    finally { oraConn.Close(); }

                    break;

                   //break;
                case (int)DataBase_Sources.SQL_Server:

                    SqlConnection sqlConn = new SqlConnection(sMyConnection_String);

                    try
                    {
                        sqlConn.Open();

                        SqlCommand sqlCmd = new SqlCommand(SQL_Query_String, sqlConn);

                        SqlDataReader sqlDr = sqlCmd.ExecuteReader();
                        dtRecord.Load(sqlDr);
                        sqlDr.Close();

                        sqlCmd.Dispose();
                    }
                    finally { sqlConn.Close(); }

                    break;

                //break;
                default:
                    break;
            }

            return dtRecord;
        }

        public int ExecSQL(string SQL)
        {
            int iRowAffected = 0;

            switch (iMyDB_Source)
            {
                case (int)DataBase_Sources.Oracle_11g:

                    OracleConnection oraConn = new OracleConnection(sMyConnection_String);

                    try
                    {
                        oraConn.Open();

                        OracleCommand oraCmd = new OracleCommand(SQL, oraConn);
                        iRowAffected = oraCmd.ExecuteNonQuery();

                        oraCmd.Dispose();
                    }
                    finally { oraConn.Close(); }

                    break;
                    
                case (int)DataBase_Sources.SQL_Server:

                    SqlConnection sqlConn = new SqlConnection(sMyConnection_String);

                    try
                    {
                        sqlConn.Open();

                        SqlCommand sqlCmd = new SqlCommand(SQL, sqlConn);
                        iRowAffected = sqlCmd.ExecuteNonQuery();

                        sqlCmd.Dispose();
                    }
                    finally { sqlConn.Close(); }

                    break;

                default:
                    break;
            }//switch the value of iMyDB_Source End

            return iRowAffected;
        }

        //
        public bool CheckDBhasValue(string SQLQuery)
        {
            bool IsCheck = true;
            DataTable dt;

            dt = GetDataTable_BySQLString(SQLQuery);
            IsCheck = (dt.Rows.Count > 0);

            return IsCheck;
        }

        public DataView GetListForPage(int index, int pagesize, string tabname, string key, string condition, string sortindex, ref int count)
        {
            DataTable dt = new DataTable();
            int rscount = 0;
            int maxpage = 0;
            int start = 0;
            int end = 0; 
            StringBuilder strSql = new StringBuilder();
            OracleDataReader sdr = null;

            if (condition.Length>0)
            {
                condition = " and " + condition;
            }

            strSql.Append("select count(1) from " + tabname + " where 1=1" + condition);
            rscount = Convert.ToInt32(GetDataTable_BySQLString(strSql.ToString()).Rows[0][0]);

            maxpage = ((rscount + pagesize) - 1) / pagesize;
            if ((index + 1) >= maxpage)
            {
                index = maxpage - 1;
            }
            if (index < 0)
            {
                index = 0;
            }

            string sql = "SELECT * FROM (SELECT A.*, ROWNUM RN FROM (SELECT * FROM " 
                + tabname + " where 1=1 " 
                + condition + " order by " 
                + sortindex + " desc) A WHERE ROWNUM < " 
                + end.ToString() + ") WHERE RN >= " + start.ToString();
            dt = GetDataTable_BySQLString(sql);

            if (dt.Rows.Count > 0)
            {
                return dt.DefaultView;
            }
            return null;
        }
    }
}
