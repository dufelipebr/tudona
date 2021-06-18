using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TudoNaStoreEntity;
using System.Data.SqlClient;

namespace TudoNaStoreDAO
{
    class ClientDAO
    {
        public static void InsertClient(ClientEntity obj)
        {
            SqlCommand sql = new SqlCommand("Insert into Client (clientID, clientHost, clientContactName, ClientPhoneNumber, clientRegion, clientStatus) values (@clientID, @clientHost, @clientContactName, @ClientPhoneNumber, @clientRegion, @clientStatus)");
            sql.Parameters.Add("@clientHost");
            sql.Parameters.Add("@clientContactName");
            sql.Parameters.Add("@ClientPhoneNumber");
            sql.Parameters.Add("@clientRegion");
            sql.Parameters.Add("@clientStatus");

            sql.Parameters["@clientHost"].Value = obj.ClientHost;
            sql.Parameters["@clientContactName"].Value = obj.ClientContactName;
            sql.Parameters["@ClientPhoneNumber"].Value = obj.ClientPhoneNumber;
            sql.Parameters["@clientRegion"].Value = obj.ClientRegionID;
            sql.Parameters["@clientStatus"].Value = obj.ClientStatusID;

            BaseConn.ExecuteNonQuery(sql);
        }
    }
}
