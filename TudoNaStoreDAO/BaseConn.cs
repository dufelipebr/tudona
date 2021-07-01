using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TudoNaStoreDAO
{
    public static class BaseConn
    {
        private static SqlConnection conn;

        //internal static SqlConnection SqlConn
        //{
        //    //get
        //    //{
        //    //    if (conn == null || conn.State == ConnectionState.Closed)
        //    //    {
        //    //        SqlConnection conn = new SqlConnection(");
        //    //    }
        //    //    return conn;
        //    //}
        //}

        internal static string ConnectionString
        {
            get {
                return "Server=tcp:shemitah.database.windows.net,1433;Initial Catalog=azCrmDefault;Persist Security Info=False;User ID=dufelipebr;Password=Shemit@h99;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            }
        }

        public static void ExecuteNonQuery(SqlCommand sql)
        {
            using (SqlConnection SqlConn = new SqlConnection(ConnectionString))
            {
                SqlConn.Open();
                sql.Connection = SqlConn;
                sql.ExecuteNonQuery();
                SqlConn.Close();
            }
        }
    }
}
