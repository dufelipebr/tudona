using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Specialized;
using System.Data.SqlClient;
using TudonaStoreBL;
using TudoNaStoreEntity;
using TudoNaStoreDAO;

namespace TudonaStoreBL
{
    public static class EntityGenericBL
    {
        public static List<EntityGenericModal> GetRegionValues()
        {
            return GenericDAO.GetRegionValues();
        }

        public static List<EntityGenericModal> GetStatusValues(string EntityIdentifier)
        {
            return GenericDAO.GetEntityStatusValues(EntityIdentifier);
        }
    }
}
