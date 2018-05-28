using System.Data;
using System.IO;
using System.Threading.Tasks;
using ExcelDataReader;

namespace LTGV
{
    public static class IOUtils
    {
        public static DataSet GetDataSetFromExcelFile(string path)
        {
            using (var fs = File.Open(path, FileMode.Open, FileAccess.Read))
            {
                IExcelDataReader dataReader;

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
                        throw new IOException($"Расширение {ext} не поддерживается.");
                }

                var result = dataReader.AsDataSet(new ExcelDataSetConfiguration
                {
                    ConfigureDataTable = _ => new ExcelDataTableConfiguration
                    {
                        UseHeaderRow = true
                    }
                });

                return result;
            }
        }

        public static async Task<DataSet> GetDataSetFromExcelFileAsync(string path)
        {
            return await Task.FromResult(GetDataSetFromExcelFile(path));
        }
    }
}