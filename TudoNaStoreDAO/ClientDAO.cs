using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TudoNaStoreEntity;
using System.Data.SqlClient;

namespace TudoNaStoreDAO
{
    public static class ClientDAO
    {
        public static void InsertClient(ClientEntity obj)
        {
            SqlCommand sql = new SqlCommand(@"INSERT INTO [dbo].[Client] ([clientHost] ,[clientContactName] ,[clientContactNumber] ,[clientPhoneNumber]  ,[clientAddress] ,[clientAddressNum] ,[clientAddressCom] ,[clientAddressNgh] ,[clientAddressSta] ,[clientZipCode] ,[clientGEO] ,[clientRegionID] ,[clientStatusID]) VALUES (@clientHost,  @clientContactName,  @clientContactNumber, @clientPhoneNumber, @clientAddress,  @clientAddressNum, @clientAddressCom, @clientAddressNgh, @clientAddressSta, @clientZipCode, @clientGEO, @clientRegionID, @clientStatusID)");

            sql.Parameters.Add(new SqlParameter("@clientHost", obj.ClientHost));
            sql.Parameters.Add(new SqlParameter("@clientContactName", obj.ClientContactName));
            sql.Parameters.Add(new SqlParameter("@clientContactNumber", obj.ClientContactNumber));
            sql.Parameters.Add(new SqlParameter("@clientPhoneNumber", obj.ClientPhoneNumber));
            sql.Parameters.Add(new SqlParameter("@clientAddress", obj.FullAdress));
            sql.Parameters.Add(new SqlParameter("@clientAddressNum", obj.AddressNum));

            sql.Parameters.Add(new SqlParameter("@clientAddressCom", obj.AddressCom));
            sql.Parameters.Add(new SqlParameter("@clientAddressNgh", obj.AddressNgh));
            sql.Parameters.Add(new SqlParameter("@clientAddressSta", obj.AddressSta));
            sql.Parameters.Add(new SqlParameter("@clientZipCode", obj.Zipcode));
            sql.Parameters.Add(new SqlParameter("@clientGEO", obj.Geolocation));
            //sql.Parameters.Add("@clientLogin");
            //sql.Parameters.Add("@clientPWD");
            sql.Parameters.Add(new SqlParameter("@clientRegionID", obj.ClientRegionID));
            sql.Parameters.Add(new SqlParameter("@clientStatusID", obj.ClientStatusID));

            BaseConn.ExecuteNonQuery(sql);
        }
    }
}
