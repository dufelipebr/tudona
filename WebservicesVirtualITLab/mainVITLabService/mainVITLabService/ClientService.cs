using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using TudoNaStoreEntity;
using TudonaStoreBL;

namespace mainVITLabService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class ClientService : ClientServiceInterface
    {
        public ClientEntity GetClient(string hashClient, string host)
        {
            //return string.Format("You entered: {0}", value);
           ClientEntity c = ClientBL.GetClientListbyID(hashClient, host);

            if (c == null || c.HashControl != hashClient)
                throw new Exception("invalid or expired customer");
           return c;
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
