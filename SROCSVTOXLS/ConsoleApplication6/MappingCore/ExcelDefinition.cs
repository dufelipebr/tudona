using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SROCSVTOXLS
{
    [XmlType("ExcelMapping")]
    public class ExcelMapping
    {
        public ExcelMapping()
        {
            ExcelDefinitionList = new List<ExcelDefinition>();
        }

        [XmlElement("ExcelDefinition")]
        public List<ExcelDefinition> ExcelDefinitionList { get; set; }
    }

    [XmlType("ExcelDefinition")]
    public class ExcelDefinition
    {
        private string _excelGroupID;
        private string _excelResultFileName;
        private List<CSVDefinition> _csvdef;

        public ExcelDefinition()
        {



        }
        public ExcelDefinition(string excelGroupID, string excelResultFileName)
        {
            _excelGroupID = excelGroupID;
            _excelResultFileName = excelResultFileName;
        }

        [XmlElement("ExcelGroupID")]
        public string ExcelGroupID
        {
            get
            {
                return _excelGroupID;
            }

            set
            {
                _excelGroupID = value;
            }
        }

        [XmlElement("ExcelResultFileName")]
        public string ExcelResultFileName
        {
            get
            {
                return _excelResultFileName;
            }

            set
            {
                _excelResultFileName = value;
            }
        }

        [XmlArray("CSVDefinitions")]
        [XmlArrayItem("CSVDefinition")]
        public List<CSVDefinition> CSVDefinitions
        {
            get
            {
                return _csvdef;
            }

            set
            {
                _csvdef = value;
            }
        }
    }
}
