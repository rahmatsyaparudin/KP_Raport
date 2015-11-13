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
        
        public string getTahun;
        public string field, table, cond;

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

        public void saveDataGuru(DataGridView datagrid)
        {
            this.field = "nama_guru as 'Nama Guru', nip as 'NIP', nuptk as 'NUPTK'," +
                    "keterangan as 'Keterangan'";
            this.table = "guru";
            this.cond = "status_guru = 'Aktif' ORDER BY nip, nama_guru ASC";
            DataTable tabel = db.GetDataTable(field, table, cond);
            datagrid.DataSource = tabel;
        }

        public void GuruToExcel(DataGridView datagrid, string filename, SaveFileDialog sfDialog)
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
                for (int i = 1; i < datagrid.Columns.Count + 1; i++)
                {
                    xlsWorkSheet.Cells[3, i + 1] = datagrid.Columns[i - 1].HeaderText;
                    xlsWorkSheet.Cells[3, i+1].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red);
                    xlsWorkSheet.Cells[i + 2, 1] = "No";
                    xlsWorkSheet.Cells[3, i+1].Font.Bold = true;
                    k++;
                }
                xlsWorkSheet.Cells[3, 1].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red);
                xlsWorkSheet.Cells[3, 1].Font.Bold = true;
                xlsWorkSheet.Range[xlsWorkSheet.Cells[1, 1], xlsWorkSheet.Cells[1, k]].Merge(Type.Missing);
                xlsWorkSheet.Range[xlsWorkSheet.Cells[1, 1], xlsWorkSheet.Cells[1, k]] = "DATA GURU SMAN 1 JAMPANGKULON";
                xlsWorkSheet.Range[xlsWorkSheet.Cells[2, 1], xlsWorkSheet.Cells[2, k]].Merge(Type.Missing);
                xlsWorkSheet.Range[xlsWorkSheet.Cells[2, 1], xlsWorkSheet.Cells[2, k]] = "TAHUN AJARAN " + passTahun;
                xlsWorkSheet.Range[xlsWorkSheet.Cells[1, 1], xlsWorkSheet.Cells[2, k]].Font.Size = 14;
                xlsWorkSheet.Range[xlsWorkSheet.Cells[1, 1], xlsWorkSheet.Cells[2, k]].Font.Bold = true;
                
                for (int i = 0; i < datagrid.Rows.Count; i++)
                {
                    for (int j = 0; j < datagrid.Columns.Count; j++)
                    {
                        if (datagrid.Rows[i].Cells[j].Value != null)
                        {
                            xlsWorkSheet.Cells[i + 4, j + 2] = datagrid.Rows[i].Cells[j].Value.ToString();
                            xlsWorkSheet.Cells[i + 4, 1] = Convert.ToString(i + 1);
                            xlsWorkSheet.Cells[i + 4, j + 1].EntireRow.NumberFormat = "@";
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

        public void saveDataSiswa(DataGridView datagrid)
        {
            this.field = "siswa.nis_siswa as 'NIS', nisn_siswa as 'NISN', nama_siswa as 'Nama Siswa', tempat_lahir as 'Tempat Lahir'," +
                         "tanggal_lahir as 'Tanggal Lahir', jenis_kelamin as 'Jenis Kelamin', kelas.nama_kelas as 'Diterima di Kelas', status_keluarga as 'Status Anak'," +
                         "anak_ke as 'Anak Ke-', agama as 'Agama', siswa.no_telp as 'No. Telp. Siswa', alamat as 'Alamat Siswa', asal_sekolah as 'Asal Sekolah'," +
                         "tanggal_masuk as 'Diterima Tanggal', nama_ayah as 'Nama Ayah', nama_ibu as 'Nama Ibu', pekerjaan_ayah as 'Pekerjaan Ayah'," +
                         "pekerjaan_ibu as 'Pekerjaan Ibu', orangtua.no_telp as 'No. Telp. Ortu', alamat_ortu as 'Alamat Ortu'," +
                         "nama_wali as 'Nama Wali', pekerjaan_wali as 'Pekerjaan Wali', alamat_wali as 'Alamat Wali'";
            this.table = "detailkelassiswa INNER JOIN siswa ON siswa.nis_siswa = detailkelassiswa.nis_siswa INNER JOIN orangtua ON siswa.nis_siswa = orangtua.nis_siswa INNER JOIN kelas ON detailkelassiswa.kode_kelas = kelas.kode_kelas";
            this.cond = "detailkelassiswa.keterangan = 'Data Siswa' AND status_siswa = 'Aktif' ORDER BY siswa.nis_siswa";
            DataTable tabel = db.GetDataTable(field, table, cond);
            datagrid.DataSource = tabel;
        }

        public void SiswaToExcel(DataGridView dg, string filename, SaveFileDialog sfDialog)
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
                xlsWorkSheet.Name = "Data Siswa";
                xlsApp.StandardFont = "Times New Roman";
                xlsApp.StandardFontSize = 12;
             
                int k = 1;
                for (int i = 1; i < dg.Columns.Count + 1; i++)
                {
                    xlsWorkSheet.Cells[5, i] = dg.Columns[i - 1].HeaderText;
                    xlsWorkSheet.Cells[5, i].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red);
                    xlsWorkSheet.Cells[5, i].Font.Bold = true;
                    k++;
                }
                xlsWorkSheet.Range[xlsWorkSheet.Cells[1, 1], xlsWorkSheet.Cells[1, k - 1]].Merge(Type.Missing);
                xlsWorkSheet.Range[xlsWorkSheet.Cells[1, 1], xlsWorkSheet.Cells[1, k - 1]] = "DATA SISWA SMAN 1 JAMPANGKULON";
                xlsWorkSheet.Range[xlsWorkSheet.Cells[2, 1], xlsWorkSheet.Cells[2, k - 1]].Merge(Type.Missing);
                xlsWorkSheet.Range[xlsWorkSheet.Cells[2, 1], xlsWorkSheet.Cells[2, k - 1]] = "TAHUN AJARAN " + passTahun;
                xlsWorkSheet.Range[xlsWorkSheet.Cells[1, 1], xlsWorkSheet.Cells[2, k - 1]].Font.Size = 14;
                xlsWorkSheet.Range[xlsWorkSheet.Cells[1, 1], xlsWorkSheet.Cells[2, k - 1]].Font.Bold = true;
                
                for (int i = 0; i < dg.Rows.Count; i++)
                {
                    for (int j = 0; j < dg.Columns.Count; j++)
                    {
                        if (dg.Rows[i].Cells[j].Value != null)
                        {
                            xlsWorkSheet.Cells[i + 6, j + 1].EntireRow.ToString();
                            xlsWorkSheet.Cells[i + 6, j + 1] = dg.Rows[i].Cells[j].Value.ToString();
                            xlsWorkSheet.Cells[i + 6, j + 1].EntireRow.NumberFormat = "@";
                            xlsWorkSheet.Cells[i + 6, j + 1].EntireColumn.NumberFormat = "@";
                            //xlsWorkSheet.Cells[i + 6, 5].EntireColumn.NumberFormat = "@";
                            //xlsWorkSheet.Cells[i + 6, 14].EntireColumn.NumberFormat = "@";
                            xlsWorkSheet.Cells[i + 6, j + 1].EntireColumn.ToString();
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

    }
}
