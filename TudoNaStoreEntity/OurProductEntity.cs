using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TudoNaStoreEntity
{
    public class OurProductEntity : IEntityModel
    {
        private int _ourProductID;
        private string _productName;
        private string _description;
        private string _thumb;
        private int _sortOrder;
        private int _clientID;
        private string _extension;
        private long _fileLenght;
        private string _relativePath;

        #region properties
        public int OurProductID
        {
            get
            {
                return _ourProductID;
            }

            set
            {
                _ourProductID = value;
            }
        }

        public string ProductName
        {
            get
            {
                return _productName;
            }

            set
            {
                _productName = value;
            }
        }

        public string Description
        {
            get
            {
                return _description;
            }

            set
            {
                _description = value;
            }
        }

        public string Thumb
        {
            get
            {
                return _thumb;
            }

            set
            {
                _thumb = value;
            }
        }

        public int SortOrder
        {
            get
            {
                return _sortOrder;
            }

            set
            {
                _sortOrder = value;
            }
        }

        public int ClientID
        {
            get
            {
                return _clientID;
            }

            set
            {
                _clientID = value;
            }
        }

        public string Extension
        {
            get
            {
                return _extension;
            }

            set
            {
                _extension = value;
            }
        }

        public long FileLenght
        {
            get
            {
                return _fileLenght;
            }

            set
            {
                _fileLenght = value;
            }
        }

        public string RelativePath
        {
            get
            {
                return _relativePath;
            }

            set
            {
                _relativePath = value;
            }
        }

        #endregion

        #region Readonly Properties
        public string FullFileName
        {
            get
            {
                return Thumb + Extension;
            }
        }

        #endregion


        public bool Validate()
        {

            if (ProductName.Trim() == "")
            {
                throw new EntityException("Invalid Product Name. (empty)");
            }

            if (Description.Trim() == "")
            {
                throw new EntityException("Invalid Description. (empty)");
            }

            if (Thumb.Trim() == "")
            {
                throw new EntityException("Invalid Thumb. (empty)");
            }

            return false;
        }
    }
}
