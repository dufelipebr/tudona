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
        //Dado um ourProductId, caso seja maior que 1 então diminuir o SortOrder atual e aumentar o anterior.
        public static void SortUp(int ourProductID, string hash)
        {
            OurProductEntity op = OurProductDAO.GetOurProduct(ourProductID);
            IEnumerable<OurProductEntity> lst = OurProductDAO.GetOurProductList(op.ClientID).OrderBy(ourProduct=> ourProduct.SortOrder);

            OurProductEntity atual = op;
            OurProductEntity anterior = null;
            if (atual.SortOrder>1)
            { 
                foreach (OurProductEntity item in lst)
                {
                    if (item.OurProductID == ourProductID) // se encontrou pegar o anterior para modifica-lo e depois sair do loop.
                    {
                        if (anterior != null)
                        {
                            anterior.SortOrder++;
                            //SaveOurProduct(anterior, hash);
                            TudoNaStoreDAO.OurProductDAO.UpdateOurProductSort(anterior);
                            break;
                        }
                    }
                    anterior = item;
                }
                atual.SortOrder--;
                TudoNaStoreDAO.OurProductDAO.UpdateOurProductSort(atual);
            }
        }

        //Dado um ourProduct, caso seja maior que 1 então diminuir o SortOrder atual e aumentar o anterior.
        public static void SortDown(int ourProductID, string hash)
        {
            OurProductEntity op = OurProductDAO.GetOurProduct(ourProductID);
            IEnumerable<OurProductEntity> lst = OurProductDAO.GetOurProductList(op.ClientID).OrderByDescending(ourProduct => ourProduct.SortOrder);

            OurProductEntity atual = op;
            OurProductEntity anterior = null;
            atual.SortOrder++;

            if (atual.SortOrder <= lst.Count())
            { 
                foreach (OurProductEntity item in lst)
                {
                    if (item.OurProductID == ourProductID) // se encontrou pegar o anterior para modifica-lo e depois sair do loop.
                    {
                        if (anterior != null)
                        {
                            anterior.SortOrder--;
                            //SaveOurProduct(anterior, hash);
                            TudoNaStoreDAO.OurProductDAO.UpdateOurProductSort(anterior);
                            break;
                        }
                    }
                    anterior = item;
                }
            
                TudoNaStoreDAO.OurProductDAO.UpdateOurProductSort(atual);
            }
        }

        public static IEnumerable<OurProductEntity> GetOurProductList(string hash)
        {
            ClientEntity cl = TudonaStoreBL.ClientBL.GetClient(hash);
            return OurProductDAO.GetOurProductList(cl.ClientID).OrderBy(ourProduct => ourProduct.SortOrder);
        }

        
    }
}
