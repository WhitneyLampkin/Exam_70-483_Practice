using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft;

namespace Listing2_28_ExportingSomeDataToExcel
{
    class Program
    {
        static void Main(string[] args)
        {
            var entities = new List<dynamic>
            {
                new
                {
                    ColumnA = 1,
                    ColumnB = "Foo"
                },
                new
                {
                    ColumnA = 2,
                    ColumnB = "Bar"
                }
            };
        }

        
        static void DisplayInExcel(IEnumerable<dynamic> entities)
        {
            // Apparently, this namespace no longer exsists.

            var excelApp = new Excel.Application();
            excelApp.Visible = true;

            excelApp.Workbooks.Add();

            dynamic workSheet = excelApp.ActiveSheet;

            workSheet.Cells[1, "A"] = "Header A";
            workSheet.Cells[2, "B"] = "Header B";

            var row = 1;

            foreach(var entity in entities)
            {
                row++;
                workSheet.Cells[row, "A"] = entity.ColumnA;
                workSheet.Cells[row, "B"] = entity.ColumnB;
            }

            workSheet.Columns[1].AutoFit();
            workSheet.Columns[2].AutoFit();
        }
        
    }
}
