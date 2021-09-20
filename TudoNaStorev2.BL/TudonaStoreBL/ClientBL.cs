using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using TudoNaStoreEntity;
using TudoNaStoreDAO;

namespace TudonaStoreBL
{
    public class ClientBL
    {

        public static void SaveClient(ClientEntity obj)
        {
            if (obj.ClientID != 0)
                ClientDAO.UpdateClient(obj);
            else
                ClientDAO.InsertClient(obj);
        }

        public static List<ClientEntity> GetClientList()
        {
            return ClientDAO.GetClientList();
        }

        public static ClientEntity GetClient(string hash)
        {
            return ClientDAO.GetClient(hash);
        }

        //public static ClientEntity GetClientListbyID(int clientID)
        //{
        //    return ClientDAO.GetClient(clientID);
        //}
        public static ClientEntity GetClientListbyID(string hash, string host)
        {
            return ClientDAO.GetClient(hash, host);
        }
    }
}
