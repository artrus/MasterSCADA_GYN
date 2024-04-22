using OfficeOpenXml;
using RoskosmosHelper.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoskosmosHelper
{
    internal class ReadExcelInputFile
    {
        public string SheetName { get; set; }
        public int[] ParseIds { get; set; }

        private ILogger logger;
        public ReadExcelInputFile(string sheetName, int[] ids)
        {
            SheetName = sheetName;
            ParseIds = ids;
            logger = null;
        }

        public void AddLogger(ILogger logger) => this.logger = logger;

        public List<string[]> OpenFile(string path)
        {
            FileInfo file = new FileInfo(path);
            if (!file.Exists)
            {
                logger.WriteLine("Файл не существует!");
                return null;
            }

            logger.WriteLine($"Открытие файла \"{path}\"");

            ExcelPackage package = new ExcelPackage(file);
            try
            {
                logger.WriteLine($"Парсинг страницы \"{SheetName}\" запущен") ;
                var worksheet = package.Workbook.Worksheets[SheetName];
                var objects = ParseByIds(worksheet);
                logger.WriteLine($"Парсинг закончен, найдено тэгов {objects.Count}");
                return objects;
            }
            catch (Exception ex)
            {
                logger.WriteLine(ex.Message + "    Ошибка парсинга Excel input файла");
                return null;
            }
        }

        private List<string[]> ParseByIds(ExcelWorksheet worksheet)
        {
            var resultList = new List<string[]>();            
            int rowCount = worksheet.Dimension.End.Row;
            for (int i = 2; i <= rowCount; i++)
            {
                string cell = worksheet.Cells[i, 1].Value?.ToString();
                var valuesInCell = cell.Split(',');
                if (valuesInCell.Length <= ParseIds.Max())
                    continue;

                var parseValues = new string[ParseIds.Length];
                int j = 0;
                foreach(var id in ParseIds)
                    parseValues[j++] = valuesInCell[id];
                resultList.Add(parseValues);
            }
            return resultList;
        }

    }
}

