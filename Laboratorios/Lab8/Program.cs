using Lab8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Excel = Microsoft.Office.Interop.Excel;

namespace Lab8
{
    internal class Program
    {
        public static string Dir = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
        public const string File = "test.xls";

        static void Main(string[] args)
        {
            List<Speciality> specialities = new Program().GetSpecialities();
            List<Medic> medics = new Program().GetMedics();
            List<Patient> patients = new Program().GetPatients();
            Excel.Application xlApp = new Excel.Application();
            if (xlApp == null)
            {
                Console.WriteLine("Error");
                return;
            }
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object missValue = System.Reflection.Missing.Value;
            xlWorkBook = xlApp.Workbooks.Add(missValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.Item[1];
            xlWorkSheet.Name = "Medicos";
            for (int i = 0; i < medics.Count; i++)
            {
                xlWorkSheet.Cells[i + 1, 1] = medics[i].Id;
                xlWorkSheet.Cells[i + 1, 2] = medics[i].Name;
                xlWorkSheet.Cells[i + 1, 3] = medics[i].LastName;
                xlWorkSheet.Cells[i + 1, 4] = medics[i].SerialCode;
            }
            xlWorkBook.Worksheets.Add(missValue, xlWorkBook.Worksheets[xlWorkBook.Worksheets.Count], 1, missValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.Item[2];
            xlWorkSheet.Name = "Especialidades";
            for (int i = 0; i < specialities.Count; i++)
            {
                xlWorkSheet.Cells[i + 1, 1] = specialities[i].Id;
                xlWorkSheet.Cells[i + 1, 2] = specialities[i].Name;
            }
            xlWorkBook.Worksheets.Add(missValue, xlWorkBook.Worksheets[xlWorkBook.Worksheets.Count], 1, missValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.Item[3];
            xlWorkSheet.Name = "Pacientes";
            for (int i = 0; i < patients.Count; i++)
            {
                xlWorkSheet.Cells[i + 1, 1] = patients[i].Id;
                xlWorkSheet.Cells[i + 1, 2] = patients[i].Name;
                xlWorkSheet.Cells[i + 1, 3] = patients[i].LastName;
                xlWorkSheet.Cells[i + 1, 4] = patients[i].HistoricalNumber;

            }
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
            Console.WriteLine($"Mi ubicacion esta en {Dir}");
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

        public List<Speciality> GetSpecialities()
        {
            List<Speciality> specialities = new List<Speciality>();
            using (var db = new CSharpCourseEntities())
            {
                specialities = db.Specialities.ToList();
            }
            return specialities;
        }

        public List<Medic> GetMedics()
        {
            List<Medic> medics = new List<Medic>();
            using (var db = new CSharpCourseEntities())
            {
                medics = db.Medics.ToList();
            }
            return medics;
        }

        public List<Patient> GetPatients()
        {
            List<Patient> patients = new List<Patient>();
            using (var db = new CSharpCourseEntities())
            {
                patients = db.Patients.ToList();
            }
            return patients;
        }
    }
}
