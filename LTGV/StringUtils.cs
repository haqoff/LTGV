using System;

namespace LTGV
{
    public static class StringUtils
    {
        public static string GetExcelColumnName(int columnNumber, int firstColumnNumber = 1)
        {
            var dividend = columnNumber + 1 - firstColumnNumber;
            var columnName = string.Empty;

            while (dividend > 0)
            {
                var modulo = (dividend - 1) % 26;
                columnName = Convert.ToChar(65 + modulo) + columnName;
                dividend = (dividend - modulo) / 26;
            }

            return columnName;
        }
    }
}