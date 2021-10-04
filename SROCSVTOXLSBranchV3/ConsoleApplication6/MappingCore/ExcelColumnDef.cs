using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;
using System.Xml.Serialization;

namespace SROCSVTOXLS.MappingCore
{
    [XmlType("ExcelColumnDef")]
    public class ExcelColumnDef
    {
        private string _excelColumnName;
        private string _excelColumnType;

        [XmlAttribute("ExcelColumnName")]
        public string ExcelColumnName
        {
            get
            {
                return _excelColumnName;
            }

            set
            {
                _excelColumnName = value;
            }
        }

        [XmlAttribute("ExcelColumnType")]
        public string ExcelColumnType
        {
            get
            {
                return _excelColumnType;
            }

            set
            {
                _excelColumnType = value;
            }
        }
    }
}
