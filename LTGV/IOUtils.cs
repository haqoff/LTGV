using ExcelDataReader;
using System.Data;
using System.IO;

namespace LTGV
{
    public static class IOUtils
    {
        public static DataSet GetDataSetFromExcelFile(string path)
        {
            using (FileStream fs = File.Open(path, FileMode.Open, FileAccess.Read))
            {
                IExcelDataReader dataReader = null;

                var ext = Path.GetExtension(path);
                switch (ext)
                {
                    case ".xls":
                        dataReader = ExcelReaderFactory.CreateBinaryReader(fs);
                        break;
                    case ".xlsx":
                        dataReader = ExcelReaderFactory.CreateOpenXmlReader(fs);
                        break;
                    default:
                        throw new IOException(string.Format("Расширение {0} не поддерживается.", ext));
                }

                var result = dataReader.AsDataSet(new ExcelDataSetConfiguration()
                {
                    ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                    {
                        UseHeaderRow = true
                    }
                });

                return result;
            }
        }

    }
}
