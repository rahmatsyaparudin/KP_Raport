using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Collections;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;

namespace Raport
{
    class DataToFile
    {
        MySqlConnection myConn = Function.getKoneksi();
        Function db = new Function();
        
        //object misValue = System.Reflection.Missing.Value;
        //Excel.Range chartRange;

        public string getTahun;

        public string passTahun
        {
            get { return getTahun; }
            set { getTahun = value; }
        }

        public string formattedDate()
        {
            string format;
            string date = DateTime.Now.ToShortDateString();
            DateTime dt = DateTime.ParseExact(date.ToString(), "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            return format = dt.ToString("dd-M-yyyy");
        }

        public void ExportToExcel(DataGridView dg, string filename, SaveFileDialog sfDialog)
        {
            Excel.Application xlsApp = new Excel.Application();
            Excel.Workbook xlsWorkBook;
            Excel.Worksheet xlsWorkSheet;
            sfDialog.InitialDirectory = "D:";
            sfDialog.Title = "Save as Excel File";
            sfDialog.FileName = filename;
            sfDialog.Filter = "Excel Files(2010)|*.xlsx|Excel Files(2007)|*.xls";
            if (sfDialog.ShowDialog() != DialogResult.Cancel)
            {
                xlsApp.Application.Workbooks.Add(Type.Missing);
                xlsWorkSheet = (Excel.Worksheet)xlsApp.Worksheets["Sheet1"];
                ((Excel.Worksheet)xlsApp.ActiveWorkbook.Sheets["Sheet1"]).Select();
                xlsWorkSheet.Name = "Data Guru";
                xlsApp.StandardFont = "Times New Roman";
                xlsApp.StandardFontSize = 12;

                int k = 1;
                for (int i = 1; i < dg.Columns.Count + 1; i++)
                {
                    xlsWorkSheet.Cells[3, i] = dg.Columns[i - 1].HeaderText;
                    xlsWorkSheet.Cells[3, i].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red);
                    xlsWorkSheet.Cells[i + 2, 1] = "No";
                    xlsWorkSheet.Cells[3, i].Font.Bold = true;
                    k++;
                }
                xlsWorkSheet.Range[xlsWorkSheet.Cells[1, 1], xlsWorkSheet.Cells[1, k-1]].Merge(Type.Missing);
                xlsWorkSheet.Range[xlsWorkSheet.Cells[1, 1], xlsWorkSheet.Cells[1, k - 1]] = "DATA GURU SMAN 1 JAMPANGKULON";
                xlsWorkSheet.Range[xlsWorkSheet.Cells[2, 1], xlsWorkSheet.Cells[2, k-1]].Merge(Type.Missing);
                xlsWorkSheet.Range[xlsWorkSheet.Cells[2, 1], xlsWorkSheet.Cells[2, k - 1]] = "TAHUN AJARAN " + passTahun;
                xlsWorkSheet.Range[xlsWorkSheet.Cells[1, 1], xlsWorkSheet.Cells[2, k - 1]].Font.Size = 14;
                xlsWorkSheet.Range[xlsWorkSheet.Cells[1, 1], xlsWorkSheet.Cells[2, k - 1]].Font.Bold = true;
                xlsWorkSheet.Cells[1, 1].Style.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
             
                for (int i = 0; i < dg.Rows.Count; i++)
                {
                    for (int j = 0; j < dg.Columns.Count; j++)
                    {
                        if (dg.Rows[i].Cells[j].Value != null)
                        {
                            xlsWorkSheet.Cells[i + 4, j + 1] = dg.Rows[i].Cells[j].Value.ToString();
                            xlsWorkSheet.Cells[i + 4, 1] = Convert.ToString(i + 1);
                            xlsWorkSheet.Cells[i + 4, j + 1].EntireColumn.NumberFormat = "@";
                            xlsWorkSheet.Columns.AutoFit();
                        }
                    }
                }
                xlsApp.ActiveWorkbook.SaveCopyAs(sfDialog.FileName.ToString());
                MessageBox.Show(sfDialog.FileName + " berhasil tersimpan");
                xlsApp.ActiveWorkbook.Saved = true;
                xlsApp.Quit();
            }
        }

        //public string writeData(DataGridView dg)
        //{
        //    for (int i = 1; i < dg.Columns.Count + 1; i++)
        //    {
        //        xlsApp.Cells[2, i] = dg.Columns[i - 1].HeaderText;
        //        xlsApp.Cells[2, i].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red);
        //        xlsApp.Cells[i + 1, 1] = "No";
        //    }

        //    for (int i = 0; i < dg.Rows.Count; i++)
        //    {
        //        for (int j = 0; j < dg.Columns.Count; j++)
        //        {
        //            if (dg.Rows[i].Cells[j].Value != null)
        //            {
        //                xlsApp.Cells[i + 3, j + 1] = dg.Rows[i].Cells[j].Value.ToString();
        //                xlsApp.Cells[i + 3, 1] = Convert.ToString(i + 1);
        //                xlsApp.Cells[i + 3, j + 1].EntireColumn.NumberFormat = "@";
        //                xlsApp.Columns.AutoFit();
        //            }
        //        }
        //    }
        //    return dg.ToString();
        //}
        
        //public void Guru(DataGridView dg, string filename, SaveFileDialog sfDialog)
        //{
        //    xlsWorkSheet = (Excel.Worksheet)xlsWorkBook.Worksheets.get_Item(1);

        //    //add data 
        //    for (int i = 1; i < dg.Columns.Count + 1; i++)
        //    {
        //        xlsApp.Cells[1, i] = dg.Columns[i - 1].HeaderText;
        //        xlsApp.Cells[1, i].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red);
        //    }

        //    for (int i = 0; i < dg.Rows.Count; i++)
        //    {
        //        for (int j = 0; j < dg.Columns.Count; j++)
        //        {
        //            if (dg.Rows[i].Cells[j].Value != null)
        //            {
        //                xlsApp.Cells[i + 2, j + 1] = dg.Rows[i].Cells[j].Value.ToString();
        //            }
        //        }
        //    }

        //    xlsWorkSheet.get_Range("b2", "e3").Merge(false);

        //    chartRange = xlsWorkSheet.get_Range("b2", "e3");
        //    chartRange.FormulaR1C1 = "MARK LIST";
        //    chartRange.HorizontalAlignment = 3;
        //    chartRange.VerticalAlignment = 3;
        //    chartRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow);
        //    chartRange.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red);
        //    chartRange.Font.Size = 20;

        //    chartRange = xlsWorkSheet.get_Range("b4", "e4");
        //    chartRange.Font.Bold = true;
        //    chartRange = xlsWorkSheet.get_Range("b9", "e9");
        //    chartRange.Font.Bold = true;

        //    chartRange = xlsWorkSheet.get_Range("b2", "e9");
        //    chartRange.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium, Excel.XlColorIndex.xlColorIndexAutomatic, Excel.XlColorIndex.xlColorIndexAutomatic);

        //    xlsWorkBook.SaveAs("d:\\csharp.net-informations.xls");
        //    xlsWorkBook.Close(true, misValue, misValue);
        //    xlsApp.Quit();

        //    releaseObject(xlsApp);
        //    releaseObject(xlsWorkBook);
        //    releaseObject(xlsWorkSheet);

        //    MessageBox.Show("File created !");
        //}

        //private void releaseObject(object obj)
        //{
        //    try
        //    {
        //        System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
        //        obj = null;
        //    }
        //    catch (Exception ex)
        //    {
        //        obj = null;
        //        MessageBox.Show("Unable to release the Object " + ex.ToString());
        //    }
        //    finally
        //    {
        //        GC.Collect();
        //    }
        //}
    }
}
