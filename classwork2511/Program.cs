using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
namespace LessonExcel
{
    class Program
    {
        static void Main(string[] args)
        {
            //IApplication app = excelEngine.Excel;
            //app.DefaultVersion = ExcelVersion.Excel2013;
            Application app = new Application();
            Workbook workbook = app.Workbooks.Open("C:\\Users\\talda\\source\\repos\\laba11\\classwork2511\\bin\\Debug\\Болезни.XLSX");
            Worksheet sheet = workbook.Sheets[1];
            var lastCell = sheet.Cells.SpecialCells(XlCellType.xlCellTypeLastCell);
            string[,] table = new string[lastCell.Cells.Column, lastCell.Cells.Row-1];
            for (int j = 1; j < lastCell.Cells.Row; j++) // по всем строкам
            {
                table[0, j-1] = sheet.Cells[j + 1,1].Text.ToString();
                table[1, j-1] = sheet.Cells[j + 1, 2].Text.ToString();              
            }
            workbook.Close();
            workbook = app.Workbooks.Open("C:\\Users\\talda\\source\\repos\\laba11\\classwork2511\\bin\\Debug\\Общее.XLSX");
            sheet = workbook.Sheets[1];
            lastCell = sheet.Cells.SpecialCells(XlCellType.xlCellTypeLastCell);
            for (int j = 1; j < lastCell.Cells.Row; j++)
            {
                string textcell = sheet.Cells[j + 1, 7].Text.ToString();
                string drugs="";
                for(int v=0;v<table.GetLength(1); v++)
                {
                    int indexOfSubstring = textcell.IndexOf(table[0,v]);
                    if(indexOfSubstring!=-1)
                    {
                        drugs += table[1, v]+" ";
                    }
                }
                sheet.Cells[j + 1, 8] = drugs;
            }
            workbook.Close();
            app.Quit();
        }
    }
}


