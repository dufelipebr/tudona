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
        public static void InsertClient(ClientEntity obj)
        {
            ClientDAO.InsertClient(obj);
        }
    }
}
