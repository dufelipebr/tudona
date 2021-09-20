using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TudoNaStoreEntity
{
    public class EntityGenericModal
    {
        private string _key;
        private string _name;

        public EntityGenericModal(string key, string name)
        {
            _key = key;
            _name = name; 
        }

        public string Key
        {
            get
            {
                return _key;
            }

            set
            {
                _key = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }
    }
}
