using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;
using System.Xml;
using System.Xml.Serialization;

namespace SROCSVTOXLS
{
    [XmlType("CSVDefinition")]
    public class CSVDefinition
    {
        private string _csvName; // Sheetname 
        //private eDataTypes[] _datatype;
        private List<eDataTypes> _datatype;
        private string _groupExcelDefinitionCode; //nome do grupo do template
        private int _order;
        private string _csvFileName;


        public CSVDefinition()
        {
            
        }

        public CSVDefinition(string csvName, List<eDataTypes> type, string groupCode, int order, string csvFileName)
        {
            _csvName = csvName;
            _datatype = type;
            _groupExcelDefinitionCode = groupCode;
            _order = order;
            _csvFileName = csvFileName;
        }

        [XmlElement("CSVName")]
        public string CSVName
        {
            get
            {
                return _csvName;
            }

            set
            {
                _csvName = value;
            }
        }

        [XmlArray("Datatypes")]
        [XmlArrayItem("eDataType")]
        public List<eDataTypes> Datatypes
        {
            get
            {
                return _datatype;
            }

            set
            {
                _datatype = value;
            }
        }

        [XmlElement("TemplateID")]
        public string GroupExcelDefinitionCode
        {
            get
            {
                return _groupExcelDefinitionCode;
            }

            set
            {
                _groupExcelDefinitionCode = value;
            }
        }

        [XmlElement("CSVFileName")]
        public string CSVFileName
        {
            get
            {
                return _csvFileName;
            }

            set
            {
                _csvFileName = value;
            }
        }

        [XmlElement("Order")]
        public int Order
        {
            get
            {
                return _order;
            }

            set
            {
                _order = value;
            }
        }
    }
}
