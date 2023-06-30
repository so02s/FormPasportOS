using System.IO;
using System.Collections.Generic;
using OfficeOpenXml;


namespace FormPasportOS.Data
{
    public class PasportInfo
    {
        //read excel file
        public List<PasportInfo> PasportInfo()
        {
            List<PasportInfo> excelInfos = new List<PasportInfo>();
            string filePath = "";

            FileInfo fileInfo = new FileInfo(filePath);

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using(ExcelPackage excelPackage = new ExcelPackage(fileInfo))
            {
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.FirstOrDefault();
                int totalCollumn = worksheet.Dimension.End.Column;
                int totalRow = worksheet.Dimension.End.Row;

                for (int row = 1; row <= totalRow; row++)
                {
                    PasportInfo pasport = new PasportInfo();
                    for(int col = 1; col <= totalCollumn; col++)
                    {
                        //добавить свойства, соответствующие таблице excel
                        //тут они считываются
                        if (col == 1) pasport.PaspID = Convert.ToInt32(worksheet.Cells[row, col].ToString());
                        if (col == 1) pasport.PaspID = Convert.ToInt32(worksheet.Cells[row, col].ToString());
                    }
                }
            }
        }

    }
}
