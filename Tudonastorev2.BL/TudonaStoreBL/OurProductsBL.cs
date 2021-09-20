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
    public class OurProductBL
    {
  

        public static void SaveOurProduct(OurProductEntity obj, string hash)
        {
            ClientEntity cl = TudonaStoreBL.ClientBL.GetClient(hash);
            OurProductDAO.InsertOurProduct(obj, cl.ClientID);
        }
        public static void Sort(int clientID, int ourProductID, bool flagUp, bool flagDown)
        {
            //OurProductEntity op = OurProductDAO.GetOurProduct(ourProductID);
            //List<OurProductEntity> lst = OurProductDAO.GetOurProductList(clientID);
            //foreach (OurProductEntity op in lst)
            //{
                
            //}
        }

        public static List<OurProductEntity> GetOurProductList(string hash)
        {
            ClientEntity cl = TudonaStoreBL.ClientBL.GetClient(hash);
            return OurProductDAO.GetOurProductList(cl.ClientID);
        }
        
    }
}
