using System;
using System.Reflection;
using Excel = Microsoft.Office.Interop.Excel;
namespace InteropPractice
{
    internal class Program
    {
        private static string Dir = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        private const string File = "test.xls";
        static void Main(string[] args)
        {
            Excel.Application xlApp = new Excel.Application();
            if (xlApp == null)
            {
                Console.WriteLine("Error");
                return;
            }
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object missValue = Missing.Value;
            xlWorkBook = xlApp.Workbooks.Add(missValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.Item[1];
            xlWorkSheet.Cells[1, 1] = "Test Test Test";
            xlWorkBook.SaveAs(Dir + File,
                               Excel.XlFileFormat.xlWorkbookNormal,
                               missValue, missValue, missValue, missValue,
                               Excel.XlSaveAsAccessMode.xlExclusive,
                               missValue, missValue, missValue, missValue, missValue);
            xlWorkBook.Close(true, missValue, missValue);
            xlApp.Quit();
            ReleaseObject(xlWorkSheet);
            ReleaseObject(xlWorkBook);
            ReleaseObject(xlApp);
            Console.WriteLine($"Ubicacion esta en {Dir}");
        }

        private static void ReleaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                Console.WriteLine("Una Excepcion ha ocurrido");
                Console.Read();
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}
