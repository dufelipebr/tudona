using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TudoNaStoreEntity;
using System.Data.SqlClient;
using System.Data;

namespace TudoNaStoreDAO
{
    public static class ClientDAO
    {
        public static void InsertClient(ClientEntity obj)
        {
            SqlCommand sql = new SqlCommand(@"INSERT INTO [dbo].[Client] ([clientHost] ,[clientContactName] ,[clientContactNumber] ,
            [clientPhoneNumber]  ,[clientAddress] ,[clientAddressNum] ,[clientAddressCom] ,[clientAddressNgh] ,[clientAddressSta] ,
            [clientZipCode] ,[clientGEO] ,[clientRegionID] ,[clientStatusID], clientType, clientSocialNumber, clientBusinessFullName
            ,FacebookID,InstagramID,Email,WhatsApp) 
            VALUES (@clientHost,  @clientContactName,  @clientContactNumber, @clientPhoneNumber, @clientAddress,  @clientAddressNum, 
            @clientAddressCom, @clientAddressNgh, @clientAddressSta, @clientZipCode, @clientGEO, @clientRegionID, 
            @clientStatusID, @clientType, @clientSocialNumber, @clientBusinessFullName , @FacebookID,  @InstagramID, @Email , @WhatsApp)");

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

            sql.Parameters.Add(new SqlParameter("@clientType", obj.TypeCli));
            sql.Parameters.Add(new SqlParameter("@clientSocialNumber", obj.SocialNumber));
            sql.Parameters.Add(new SqlParameter("@clientBusinessFullName", obj.CustomerFullName));

            sql.Parameters.Add(new SqlParameter("@FacebookID", obj.FacebookID));
            sql.Parameters.Add(new SqlParameter("@InstagramID", obj.InstagramID));
            sql.Parameters.Add(new SqlParameter("@Email", obj.Email));
            sql.Parameters.Add(new SqlParameter("@WhatsApp", obj.WhatsApp));

            BaseConn.ExecuteNonQuery(sql);
        }

        public static void UpdateClient(ClientEntity obj)
        {
            SqlCommand sql = new SqlCommand(@"Update [dbo].[Client]  set 
            [clientHost] = @clientHost ,
            [clientContactName] = @clientContactName,
            [clientContactNumber] = @clientContactNumber ,
            [clientPhoneNumber] = @clientPhoneNumber,
            [clientAddress] = @clientAddress,
            [clientAddressNum] = @clientAddressNum,
            [clientAddressCom] = @clientAddressCom,
            [clientAddressNgh] = @clientAddressNgh,
            [clientAddressSta] = @clientAddressSta,
            [clientZipCode] = @clientZipCode,
            [clientGEO] = @clientGEO,
            [clientRegionID] = @clientRegionID,
            [clientStatusID] = @clientStatusID, 
            clientType = @clientType, 
            clientSocialNumber = @clientSocialNumber, 
            clientBusinessFullName = @clientBusinessFullName,    
            FacebookID = @FacebookID,
            InstagramID = @InstagramID,
            Email = @Email,
            WhatsApp  = @WhatsApp
            where ClientID = @ClientID ");

            sql.Parameters.Add(new SqlParameter("@clientID", obj.ClientID));
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
            sql.Parameters.Add(new SqlParameter("@clientRegionID", obj.ClientRegionID));
            sql.Parameters.Add(new SqlParameter("@clientStatusID", obj.ClientStatusID));

            sql.Parameters.Add(new SqlParameter("@clientType", obj.TypeCli));
            sql.Parameters.Add(new SqlParameter("@clientSocialNumber", obj.SocialNumber));
            sql.Parameters.Add(new SqlParameter("@clientBusinessFullName", obj.CustomerFullName));

            sql.Parameters.Add(new SqlParameter("@FacebookID", obj.FacebookID));
            sql.Parameters.Add(new SqlParameter("@InstagramID", obj.InstagramID));
            sql.Parameters.Add(new SqlParameter("@Email", obj.Email));
            sql.Parameters.Add(new SqlParameter("@WhatsApp", obj.WhatsApp));

            BaseConn.ExecuteNonQuery(sql);
        }

        public static List<ClientEntity> GetClientList()
        {
            List<ClientEntity> lstClient = new List<ClientEntity>();

            SqlCommand sql = new SqlCommand("Select * from [dbo].[Client]");
            DataTable dt = BaseConn.ExecuteQuery(sql);
            foreach(DataRow rd in dt.Rows)
            {
                ClientEntity et = new ClientEntity();
                et.ClientID = Convert.ToInt32(rd["clientID"]);
                et.ClientHost = rd["clientHost"].ToString();
                et.ClientContactName = rd["clientContactName"].ToString();
                et.ClientContactNumber = rd["clientContactNumber"].ToString();
                et.ClientPhoneNumber = rd["clientPhoneNumber"].ToString();
                et.FullAdress = rd["clientAddress"].ToString();
                et.AddressNum = rd["clientAddressNum"].ToString();
                et.AddressCom = rd["clientAddressCom"].ToString();
                et.AddressNgh = rd["clientAddressNgh"].ToString();
                et.AddressSta = rd["clientAddressSta"].ToString();
                et.Zipcode = rd["clientZipCode"].ToString();
                et.Geolocation = rd["clientGEO"].ToString();
                et.ClientRegionID = Convert.ToInt32(rd["clientRegionID"]);
                et.ClientStatusID = Convert.ToInt32(rd["clientStatusID"]);
                et.TypeCli = (rd["clientType"].ToString() == "F" ?  ClientType.F : ClientType.J);
                et.SocialNumber = rd["clientSocialNumber"].ToString();
                et.CustomerFullName = rd["clientBusinessFullName"].ToString();
                et.WhatsApp = rd["WhatsApp"].ToString();
                et.InstagramID = rd["InstagramID"].ToString();
                et.FacebookID = rd["FacebookID"].ToString();
                et.Email = rd["Email"].ToString();

                lstClient.Add(et);
            }
            return lstClient;
        }

        public static ClientEntity GetClient(int clientID)
        {
            ClientEntity et = new ClientEntity();
            SqlCommand sql = new SqlCommand("Select * from [dbo].[Client] where clientID = " + clientID.ToString());
            DataTable dt = BaseConn.ExecuteQuery(sql);
            foreach (DataRow rd in dt.Rows)
            {
                et.ClientID = Convert.ToInt32(rd["clientID"]);
                et.ClientHost = rd["clientHost"].ToString();
                et.ClientContactName = rd["clientContactName"].ToString();
                et.ClientContactNumber = rd["clientContactNumber"].ToString();
                et.ClientPhoneNumber = rd["clientPhoneNumber"].ToString();
                et.FullAdress = rd["clientAddress"].ToString();
                et.AddressNum = rd["clientAddressNum"].ToString();
                et.AddressCom = rd["clientAddressCom"].ToString();
                et.AddressNgh = rd["clientAddressNgh"].ToString();
                et.AddressSta = rd["clientAddressSta"].ToString();
                et.Zipcode = rd["clientZipCode"].ToString();
                et.Geolocation = rd["clientGEO"].ToString();
                et.ClientRegionID = Convert.ToInt32(rd["clientRegionID"]);
                et.ClientStatusID = Convert.ToInt32(rd["clientStatusID"]);
                et.TypeCli = (rd["clientType"].ToString() == "F" ? ClientType.F : ClientType.J);
                et.SocialNumber = rd["clientSocialNumber"].ToString();
                et.CustomerFullName = rd["clientBusinessFullName"].ToString();
                et.WhatsApp = rd["WhatsApp"].ToString();
                et.InstagramID = rd["InstagramID"].ToString();
                et.FacebookID = rd["FacebookID"].ToString();
                et.Email = rd["Email"].ToString();

            }
            return et;
        }
    }

    
}
