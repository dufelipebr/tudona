using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TudoNaStoreEntity;
using System.Data.SqlClient;

namespace TudoNaStoreDAO
{
    public static class GenericDAO 
    {
        public static List<EntityGenericModal> GetRegionValues()
        {
            List<EntityGenericModal> vl = new List<EntityGenericModal>();

            SqlDataReader rd;
            using (SqlConnection SqlConn = new SqlConnection(BaseConn.ConnectionString))
            {
                string cmdText = "select regionID, regionName from Region where regionStatus >0";

                SqlConn.Open();
                SqlCommand sql = new SqlCommand(cmdText, SqlConn);
                rd = sql.ExecuteReader();

                while (rd.Read())
                {
                    vl.Add(new EntityGenericModal(rd[0].ToString(), rd[1].ToString()));
                }
                rd.Close();
                SqlConn.Close();
            }
            return vl;
        }

        public static List<EntityGenericModal> GetEntityStatusValues(string entityName)
        {
            List<EntityGenericModal> vl = new List<EntityGenericModal>();

            SqlDataReader rd;
            using (SqlConnection SqlConn = new SqlConnection(BaseConn.ConnectionString))
            {
                string cmdText = "select entityStatusID, entityStatusName from EntityStatus where entityName = @entityName";

                SqlConn.Open();
                SqlCommand sql = new SqlCommand(cmdText, SqlConn);
                sql.Parameters.Add(new SqlParameter("@entityName", entityName));
                rd = sql.ExecuteReader();

                while (rd.Read())
                {
                    vl.Add(new EntityGenericModal(rd[0].ToString(), rd[1].ToString()));
                }
                rd.Close();
                SqlConn.Close();
            }
            return vl;
        }
    }
}
