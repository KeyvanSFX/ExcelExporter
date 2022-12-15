using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Data;

using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace KeyvanAddin1
{
    public partial class Ribbon1
    {
        public static ExportSetting exportSetting { get; set; } = new ExportSetting();
        private static Settings settings = null;

        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {

        }
        private static void ExportSettingUpdater()
        {
            exportSetting = settings.exportSetting;
        }

        private void button1_Click(object sender, RibbonControlEventArgs e)
        {
            //Worksheet currentSheet = Globals.ThisAddIn.GetActiveWorkSheet();
            //currentSheet.Range["A1:C1000"].Value = "Exporting Text";
            //currentSheet.Columns.AutoFit();

            //string path = @"E:\names.txt"; //write your own path!
            //System.Data.DataTable table = ReadFile(path);
            //Excel_FromDataTable(table);

            Worksheet currentSheet = Globals.ThisAddIn.GetActiveWorkSheet();
            SaveAsText(currentSheet);
        }

        private static void SaveAsText(Worksheet worksheet)
        {
            settings = new Settings();
            settings.ShowDialog();
            ExportSettingUpdater();

            StreamWriter streamWriter = new StreamWriter($"{exportSetting.FileDirectory}\\"+$"{exportSetting.FileName}");
            Range xlRange = worksheet.UsedRange;
            int rowCount = xlRange.Rows.Count;
            int colCount = xlRange.Columns.Count;


            for (int i = 1; i <= rowCount; i++)
            {
                streamWriter.Write(exportSetting.StartText);
                for (int j = 1; j <= colCount; j++)
                {
                    streamWriter.Write(GetColumnsSeparator(exportSetting.ColumnsSeparator) + 
                                       GetColumnsContainer(exportSetting.ColumnsContainer) + 
                                       ((Excel.Range)xlRange.Cells[i, j]).Value2 +
                                       GetColumnsContainer(exportSetting.ColumnsContainer) 
                                       /*GetColumnsSeparator(exportSetting.ColumnsSeparator)*/);
                }
                streamWriter.Write(exportSetting.EndText);
                streamWriter.WriteLine();
            }
            streamWriter.Close();
            System.Windows.Forms.MessageBox.Show("File Exported SuccessFully.");
        }

        private static string GetColumnsSeparator(string command)
        {
            string result = String.Empty;
            switch (command)
            {
                case "Colon (,)":
                    result = " , ";
                    break;
                case "Semicolon (;)":
                    result = " ; ";
                    break;
                case "Space ( )":
                    result = " ";
                    break;
                case "Tab (	)":
                    result = "  ";
                    break;
                case "Pipeline (|)":
                    result = " | ";
                    break; 
                default:
                    break;
            }
            return result;
        }

        private static string GetColumnsContainer(string command)
        {
            string result = String.Empty;
            switch (command)
            {
                case "\"Sample\"":
                    result = "\"";
                    break;
                case "\'Sample\'":
                    result = "\'";
                    break;
                default:
                    break;
            }
            return result;
        }

        private void button2_Click(object sender, RibbonControlEventArgs e)
        {
            MessageBox.Show("Auther: Ali Keyvannejad\nMobile: 09381169449","About");
        }

        //private static System.Data.DataTable ReadFile(string path)
        //{
        //    System.Data.DataTable table = new System.Data.DataTable("dataFromFile");
        //    table.Columns.AddRange(new DataColumn[]
        //    {
        //        new DataColumn("col1", typeof(string)),
        //        new DataColumn("col2", typeof(string)),
        //        new DataColumn("col3", typeof(string)),
        //        new DataColumn("col4", typeof(string)),
        //        //new DataColumn("col5", typeof(string)),
        //        //new DataColumn("col6", typeof(string)),
        //        //new DataColumn("col7", typeof(string))
        //    });
        //    using (StreamReader sr = new StreamReader(path))
        //    {
        //        string line;
        //        int rowsCount = 0;
        //        while ((line = sr.ReadLine()) != null)
        //        {
        //            string[] data = line.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries); // !!set your own delimiter, I used 3!!

        //            table.Rows.Add();
        //            for (int i = 0; i < data.Length; i++)
        //            {
        //                if (data[i].Contains(" "))
        //                    data[i] = data[i].Replace(" ", "");
        //                if (!data[i].Equals(""))
        //                    table.Rows[rowsCount][i] = data[i];
        //            }
        //            rowsCount++;
        //        }
        //    }
        //    return table;
        //}

        //private static void Excel_FromDataTable(System.Data.DataTable dt)
        //{
        //    // Create an Excel object and add workbook...
        //    ApplicationClass excel = new ApplicationClass();
        //    Workbook workbook = excel.Application.Workbooks.Add(true); // true for object template???

        //    // Add column headings...
        //    int iCol = 0;
        //    foreach (DataColumn c in dt.Columns)
        //    {
        //        iCol++;
        //        excel.Cells[1, iCol] = c.ColumnName;
        //    }
        //    // for each row of data...
        //    int iRow = 0;
        //    foreach (DataRow r in dt.Rows)
        //    {
        //        iRow++;

        //        // add each row's cell data...
        //        iCol = 0;
        //        foreach (DataColumn c in dt.Columns)
        //        {
        //            iCol++;
        //            excel.Cells[iRow + 1, iCol] = r[c.ColumnName];
        //        }
        //    }

        //    // Global missing reference for objects we are not defining...
        //    object missing = System.Reflection.Missing.Value;

        //    // If wanting to Save the workbook...
        //    workbook.SaveAs(@"E:\excelFile02.xls",
        //        XlFileFormat.xlXMLSpreadsheet, missing, missing,
        //        false, false, XlSaveAsAccessMode.xlNoChange,
        //        missing, missing, missing, missing, missing);

        //    // If wanting to make Excel visible and activate the worksheet...
        //    excel.Visible = true;
        //    Worksheet worksheet = (Worksheet)excel.ActiveSheet;
        //    ((_Worksheet)worksheet).Activate();

        //    // If wanting excel to shutdown...
        //    ((_Application)excel).Quit();
        //}
    }
}
