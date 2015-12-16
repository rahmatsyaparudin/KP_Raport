using System;
using System.Data;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using GemBox.Spreadsheet;

namespace Raport
{
    class DataToExcel2
    {
        public string getTahun;
        public string field, table, cond;

        public string passTahun
        {
            get { return getTahun; }
            set { getTahun = value; }
        }

        
        public void test()
        {
        SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");
        ExcelFile ef = new ExcelFile();
        ExcelWorksheet ws = ef.Worksheets.Add("Insert DataTable");
        DataTable dt = new DataTable();

            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("FirstName", typeof(string));
            dt.Columns.Add("LastName", typeof(string));

            dt.Rows.Add(new object[] { 100, "John", "Doe" });
            dt.Rows.Add(new object[] { 101, "Fred", "Nurk" });
            dt.Rows.Add(new object[] { 103, "Hans", "Meier" });
            dt.Rows.Add(new object[] { 104, "Ivan", "Horvat" });
            dt.Rows.Add(new object[] { 105, "Jean", "Dupont" });
            dt.Rows.Add(new object[] { 106, "Mario", "Rossi" });
            dt.Rows.Add(new object[] { 100, "John", "Doe" });
            dt.Rows.Add(new object[] { 101, "Fred", "Nurk" });
            dt.Rows.Add(new object[] { 103, "Hans", "Meier" });
            dt.Rows.Add(new object[] { 104, "Ivan", "Horvat" });
            dt.Rows.Add(new object[] { 105, "Jean", "Dupont" });
            dt.Rows.Add(new object[] { 106, "Mario", "Rossi" });
            dt.Rows.Add(new object[] { 100, "John", "Doe" });
            dt.Rows.Add(new object[] { 101, "Fred", "Nurk" });
            dt.Rows.Add(new object[] { 103, "Hans", "Meier" });
            dt.Rows.Add(new object[] { 104, "Ivan", "Horvat" });
            dt.Rows.Add(new object[] { 105, "Jean", "Dupont" });
            dt.Rows.Add(new object[] { 106, "Mario", "Rossi" });
            dt.Rows.Add(new object[] { 100, "John", "Doe" });
            dt.Rows.Add(new object[] { 101, "Fred", "Nurk" });
            dt.Rows.Add(new object[] { 103, "Hans", "Meier" });
            dt.Rows.Add(new object[] { 104, "Ivan", "Horvat" });
            dt.Rows.Add(new object[] { 105, "Jean", "Dupont" });
            dt.Rows.Add(new object[] { 106, "Mario", "Rossi" });

            ws.Cells[0, 0].Value = "DataTable insert example:";

            ws.InsertDataTable(dt,
                new InsertDataTableOptions()
        {
            ColumnHeaders = true,
                    StartRow = 2
                });

            ef.Save("Insert DataTable.xls"); 
        }
        
    }
}
