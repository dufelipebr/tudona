using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using OfficeOpenXml;
using System.Collections;
using System.Globalization;
using System.Configuration;
using System.Xml.Serialization;
using System.Xml;
using CsvHelper;
using System.Data;
using SROCSVTOXLS.MappingCore;

namespace SROCSVTOXLS
{
    class Program
    {
        public class ValidationException : Exception
        {
            public ValidationException(string message) : base("validation Exception:" + message)
            {
                
            }
        }

        static void Main(string[] args)
        {

            LogFile(string.Format("Start job at {0}", DateTime.Now));

            #region reading variables
            string csvFilesPath = ConfigurationManager.AppSettings["CSVFilesPath"];
            string csvProccessPath = ConfigurationManager.AppSettings["CSVProccessPath"];
            string csvPathTemplate = ConfigurationManager.AppSettings["CSVPathTemplate"];
            string pathResult = ConfigurationManager.AppSettings["EXCELPath"];
            string startPositionExcel = ConfigurationManager.AppSettings["EXCELLoadStartPosition"];
            bool firstRowIsHeader = Boolean.Parse(ConfigurationManager.AppSettings["flgFirstRowIsHeader"]);
            bool moveFilesEnd = Boolean.Parse(ConfigurationManager.AppSettings["flgMoveFilesEnd"]);

            var format = new ExcelTextFormat();
            format.SkipLinesBeginning = 1;
            format.Culture = new CultureInfo(ConfigurationManager.AppSettings["CSVCulture"], true);

            if (ConfigurationManager.AppSettings["ExcelEnconding"] != null)
                format.Encoding = Encoding.GetEncoding(Int32.Parse(ConfigurationManager.AppSettings["ExcelEnconding"])); //Encoding.UTF8;
            else
                format.Encoding = Encoding.UTF8;
            format.Delimiter = Convert.ToChar(ConfigurationManager.AppSettings["CSVDelimiter"]);
            format.EOL = ConfigurationManager.AppSettings["CSVEndOfLine"];              // DEFAULT IS "\r\n";

            string fileIdentity = DateTime.Now.ToString("yyyyMMddhhmmss");
            #endregion


            #region Load CSV Definition
            List<ExcelDefinition> tempList = new List<ExcelDefinition>();
            string xmldata;
            using (StreamReader sr = new StreamReader(ConfigurationManager.AppSettings["XmlDef"]))
            {
                xmldata = sr.ReadToEnd();
                sr.Close();
            }

            var serializer = new XmlSerializer(typeof(ExcelMapping));
            using (var stream = new StringReader(xmldata))
            using (var reader = XmlReader.Create(stream))
            {
                ExcelMapping result = (ExcelMapping)serializer.Deserialize(reader);
                tempList = result.ExcelDefinitionList;
            }
            #endregion

            foreach (ExcelDefinition def in tempList)
            {
                #region processfiles
                IEnumerable<CSVDefinition> query = def.CSVDefinitions.OrderBy(csvItem => csvItem.Order);
                bool validDef = query.Count() > 0 ? true : false;
                
                foreach (CSVDefinition csvItem in query)// Validar se todos os arquivos existentes do grupo estão na pasta, caso sim processo o grupo de arquivos.
                {
                    if (!File.Exists(csvFilesPath + csvItem.CSVFileName) && validDef == true)
                    {
                        LogFile(string.Format("Skipped! No file {0} to process...", def.ExcelGroupID));
                        validDef = false;
                    }
                }

                if (validDef)
                {
                    try
                    {
                        LogFile(string.Format("Starting! Group {0} process...", def.ExcelGroupID));

                        string excelResult = string.Format("{0}{1}_{2}.xlsx", pathResult, def.ExcelResultFileName, fileIdentity);
                        string templatePath = string.Format("{0}{1}Template.xlsx", csvPathTemplate, def.ExcelGroupID);

                        if (File.Exists(excelResult))
                        {
                            LogFile(string.Format("Removing file XLS: {0}", excelResult));
                            File.Delete(excelResult);
                        }

                        using (ExcelPackage package = new ExcelPackage(new FileInfo(excelResult), new FileInfo(templatePath)))
                        {
                            query = def.CSVDefinitions.OrderBy(csvItem => csvItem.Order);
                            foreach (CSVDefinition csvItem in query)
                            {
                                string csvFileName = string.Format("{0}{1}", csvFilesPath, csvItem.CSVFileName);
                                string csvFileNameUTF = string.Format("{0}{1}utf", csvFilesPath, csvItem.CSVFileName);

                                

                                if (File.Exists(csvFileNameUTF))
                                {
                                    File.Delete(excelResult);
                                }

                                //forçar arquivo para ler em UTF-8 -- criar novo arquivo
                                ////using (StreamReader sr = new StreamReader(csvFileName))
                                ////{
                                ////    Encoding encoding = Encoding.Default;
                                ////    String original = String.Empty;

                                ////    LogFile("File encoding is:" + sr.CurrentEncoding.ToString());

                                ////    original = sr.ReadToEnd();
                                ////    encoding = Encoding.GetEncoding(1252);
                                ////    sr.Close();

                                ////    using (StreamWriter sw = new StreamWriter(csvFileNameUTF, false, UTF8Encoding.UTF8))
                                ////    {
                                ////        byte[] encBytes = encoding.GetBytes(original);
                                ////        byte[] utf8Bytes = Encoding.Convert(encoding, Encoding.UTF8, encBytes);
                                ////        sw.Write(Encoding.UTF8.GetString(utf8Bytes));
                                ////        sw.Close();
                                ////    }
                                ////}

                                

                                WriteXLS(csvItem.CSVName, csvItem.Datatypes.ToArray(), package, startPositionExcel, format, csvFileName, csvItem);

                                LogFile(string.Format("moving files {0} to proccess path... started.", csvItem.CSVFileName));
                                if (moveFilesEnd)
                                    File.Move(csvFileName, string.Format(@"{0}\{1}{2}.csv", csvProccessPath, csvItem.CSVName, fileIdentity));
                                //File.Delete(csvFileNameUTF);
                            }
                            package.Save();
                            
                        }

                        LogFile("Finish generate XLS file: " + excelResult);
                    }
                    catch (Exception ex)
                    {
                        LogFile("EXCEPTION!!! " + ex.Message);
                        Console.WriteLine("EXCEPTION!!! " + ex.Message);
                    }
                }
                #endregion
            }

        }



        static void WriteXLS(string sheetName, eDataTypes[] eType, ExcelPackage package, string startPositionExcel, ExcelTextFormat format, string csvFileName, CSVDefinition cItem)
        {
                var sts = new XmlWriterSettings()
            {
                Indent = true,
            };

            string xmlFile = string.Format(@"C:\temp\geracaoarquivos\{0}.xml", sheetName);
            if (File.Exists(xmlFile))
                File.Delete(xmlFile);


            CsvHelper.Configuration.CsvConfiguration cvConfig = new CsvHelper.Configuration.CsvConfiguration(format.Culture);
            cvConfig.Delimiter = ";";
            //cvConfig.

            using (var reader = new StreamReader(csvFileName)) 
            using (var csv = new CsvReader(reader, cvConfig))
            {
                // Do any configuration to `CsvReader` before creating CsvDataReader.
                using (var dr = new CsvDataReader(csv))
                {
                    var dt = new DataTable();
                    
                    dt.TableName = sheetName;
                    foreach(ExcelColumnDef col in cItem.ColDefs)
                    {
                        switch(col.ExcelColumnType)
                        {
                            case "String": dt.Columns.Add(col.ExcelColumnName, typeof(string));break;
                            case "Number": dt.Columns.Add(col.ExcelColumnName, typeof(decimal)); break;
                            case "DateTime": dt.Columns.Add(col.ExcelColumnName, typeof(DateTime)); break;
                            default:  throw new Exception("not mapped type");
                        }
                    }


                    dt.Load(dr, LoadOption.Upsert);

                    using (XmlWriter writer = XmlWriter.Create(string.Format(@"C:\temp\geracaoarquivos\{0}.xml", sheetName), sts))
                    {
                        //worksheet.Workbook.WorkbookXml.WriteContentTo(writer);
                        //worksheet.WorksheetXml.WriteContentTo(dt.);
                        dt.WriteXml(writer);
                        //worksheet.Workbook.WorkbookXml.WriteTo(writer);
                    }

                    #region escrever excel
                    ExcelWorksheet worksheet;
                    worksheet = package.Workbook.Worksheets[sheetName];
                    if (worksheet == null)
                        throw new Exception("sheetName não encontrado, revisar definição do sheetname do arquivo xls.");


                    format.DataTypes = eType;
                    //worksheet.Cells[startPositionExcel].LoadFromText(new FileInfo(csvFileName), format);
                    //worksheet.Cells[startPositionExcel].LoadFromDataTable(dt, false);
                    //worksheet.WorksheetXml.Load()
                    LoadLineRowsDataTable(worksheet, dt);

                    //worksheet.Calculate();
                    //package.Save();
                    #endregion

                }
            }

          
        }

        private static void LoadLineRowsDataTable(ExcelWorksheet worksheet, DataTable dt)
        {

            for (int i = 1; i < dt.Rows.Count; i++)
            {
                object[] a = dt.Rows[i].ItemArray;

                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    if(a[j] != "" && a[j] != null)
                        worksheet.SetValue(i+1, j+1, a[j]);
                }
            }
        }

        static void LogFile(string message)
        {
            string logLocation = ConfigurationManager.AppSettings["logLocation"];
            StreamWriter streamwriter;
            using (FileStream filestream = new FileStream(logLocation, FileMode.Append))
            { 
                streamwriter = new StreamWriter(filestream);
                streamwriter.AutoFlush = true;
                streamwriter.WriteLine("{0}...{1}", DateTime.UtcNow, message);
                streamwriter.Close();
            }
        }

    }
}
