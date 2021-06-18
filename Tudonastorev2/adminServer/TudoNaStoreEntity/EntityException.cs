using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TudoNaStoreEntity
{
    public class EntityException : SystemException
    {
        public EntityException(string message) : base (message)
        {
        
        }
    }
}
