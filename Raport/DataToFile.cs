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
using System.Diagnostics;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Raport
{
    class DataToFile
    {
        MySqlConnection myConn = Function.getKoneksi();
        Function db = new Function();
        MySqlDataReader myReader;
        
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

        public void closeExcelProcess()
        {
            foreach (Process clsProcess in Process.GetProcesses())
            {
                if (clsProcess.ProcessName.Equals("EXCEL"))
                {
                    clsProcess.Kill();
                    break;
                }
            }
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
                closeExcelProcess();
            }
            else
            {
                closeExcelProcess();
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
                closeExcelProcess();
            }
            else
            {
                closeExcelProcess();
            }
        }
        
        public void RaportToPDF(DataGridView dg, string filename, SaveFileDialog sfDialog)
        {
            BaseFont TimesNW = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, false);

            Document doc = new Document(iTextSharp.text.PageSize.A4, 20, 20, 40, 40);
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("test.pdf", FileMode.Create));
            doc.Open();
            doc.NewPage();
            
            System.Drawing.Image image = Properties.Resources.LogoPendidikan;
            iTextSharp.text.Image pic = iTextSharp.text.Image.GetInstance(image, System.Drawing.Imaging.ImageFormat.Png);
            pic.ScalePercent(13.0f);
            pic.Alignment = Element.ALIGN_CENTER;

            Paragraph paragraf = new Paragraph("\n\n");
            Paragraph paragraf0 = new Paragraph("\n\n\n");
            Paragraph paragraf1 = new Paragraph("\n\n\nLAPORAN \nCAPAIAN KOMPETENSI PESERTA DIDIK"+ 
                                                "\nSEKOLAH MENENGAH ATAS \n(SMA)");
            paragraf1.Alignment = Element.ALIGN_CENTER; paragraf1.Font.SetStyle(Font.BOLD);
            paragraf1.Font.SetFamily("Arial Black"); paragraf1.Font.Size = 14.0f;

            Paragraph paragraf2 = new Paragraph("\n\n\n\n\n\n\n\nNama Peserta Didik");
            paragraf2.Alignment = Element.ALIGN_CENTER; paragraf2.Font.SetStyle(Font.BOLD);
            paragraf2.Font.SetFamily("Arial Black"); paragraf2.Font.Size = 12.0f;

            Paragraph paragraf3 = new Paragraph("Rahmat Syaparudin");
            paragraf3.Alignment = Element.ALIGN_CENTER; paragraf3.Font.SetStyle(Font.NORMAL);
            paragraf3.Font.SetFamily("Times New Roman"); paragraf3.Font.Size = 12.0f;

            Paragraph paragraf4 = new Paragraph("\n\nNISN:");
            paragraf4.Alignment = Element.ALIGN_CENTER; paragraf4.Font.SetStyle(Font.BOLD);
            paragraf4.Font.SetFamily("Arial Black"); paragraf4.Font.Size = 12.0f;

            Paragraph paragraf5 = new Paragraph("0123456789");
            paragraf5.Alignment = Element.ALIGN_CENTER; paragraf5.Font.SetStyle(Font.NORMAL);
            paragraf5.Font.SetFamily("Times New Roman"); paragraf5.Font.Size = 12.0f;

            Paragraph paragraf6 = new Paragraph("\n\n\nKEMENTERIAN PENDIDIKAN DAN KEBUDAYAAN \nREPUBLIK INDONESIA");
            paragraf6.Alignment = Element.ALIGN_CENTER; paragraf6.Font.SetStyle(Font.BOLD);
            paragraf6.Font.SetFamily("Arial Black"); paragraf6.Font.Size = 14.0f;

            Paragraph paragraf7 = new Paragraph("KETERANGAN TENTANG DIRI PESERTA DIDIK");
            paragraf7.Alignment = Element.ALIGN_CENTER; paragraf7.Font.SetStyle(Font.BOLD);
            paragraf7.Font.SetFamily("Arial Black"); paragraf7.Font.Size = 14.0f;
            
            doc.Add(paragraf0);
            doc.Add(pic);
            doc.Add(paragraf1);
            doc.Add(paragraf2);
            doc.Add(paragraf3);
            doc.Add(paragraf4);
            doc.Add(paragraf5);
            doc.Add(paragraf6);
            doc.NewPage();
            doc.Add(paragraf1);
            doc.Add(paragraf0);
            DataProfilSekolah(doc);
            doc.NewPage();
            doc.Add(paragraf7);
            doc.Add(paragraf);
            DataDiriSiswa(doc);
            doc.Close();
        }

        public void DataProfilSekolah(Document doc)
        {
            PdfPTable sekolah_tbl = new PdfPTable(3);
            sekolah_tbl.TotalWidth = 500f; sekolah_tbl.LockedWidth = true;
            sekolah_tbl.DefaultCell.Border = Rectangle.NO_BORDER;
            float[] widths0 = new float[] { 200f, 30f, 770f };
            sekolah_tbl.SetWidths(widths0);

            string profil = "SELECT * from profil_sekolah";
            MySqlCommand getProfil = new MySqlCommand(profil, myConn);
            try
            {
                myConn.Open();
                myReader = getProfil.ExecuteReader();
                while (myReader.Read())
                {
                    sekolah_tbl.AddCell("Nama Sekolah"); sekolah_tbl.AddCell(":"); sekolah_tbl.AddCell(myReader.GetString("nama_sekolah"));
                    sekolah_tbl.AddCell("\n"); sekolah_tbl.AddCell(""); sekolah_tbl.AddCell("");
                    sekolah_tbl.AddCell("NPSN/NSS"); sekolah_tbl.AddCell(":"); sekolah_tbl.AddCell(myReader.GetString("npsn") + " / " + myReader.GetString("nss"));
                    sekolah_tbl.AddCell("\n"); sekolah_tbl.AddCell(""); sekolah_tbl.AddCell("");
                    sekolah_tbl.AddCell("Alamat Sekolah"); sekolah_tbl.AddCell(":"); sekolah_tbl.AddCell(myReader.GetString("alamat_sekolah"));
                    sekolah_tbl.AddCell("\n"); sekolah_tbl.AddCell(""); sekolah_tbl.AddCell("");
                    sekolah_tbl.AddCell("\n\n\n"); sekolah_tbl.AddCell(""); sekolah_tbl.AddCell("Kode Pos " + myReader.GetString("kode_pos") + "Telp. " + myReader.GetString("no_telp"));
                    sekolah_tbl.AddCell("\n"); sekolah_tbl.AddCell(""); sekolah_tbl.AddCell("");
                    sekolah_tbl.AddCell("Kelurahan"); sekolah_tbl.AddCell(":"); sekolah_tbl.AddCell(myReader.GetString("kelurahan"));
                    sekolah_tbl.AddCell("\n"); sekolah_tbl.AddCell(""); sekolah_tbl.AddCell("");
                    sekolah_tbl.AddCell("Kecamatan"); sekolah_tbl.AddCell(":"); sekolah_tbl.AddCell(myReader.GetString("kecamatan"));
                    sekolah_tbl.AddCell("\n"); sekolah_tbl.AddCell(""); sekolah_tbl.AddCell("");
                    sekolah_tbl.AddCell("Kabupaten/Kota"); sekolah_tbl.AddCell(":"); sekolah_tbl.AddCell(myReader.GetString("kota"));
                    sekolah_tbl.AddCell("\n"); sekolah_tbl.AddCell(""); sekolah_tbl.AddCell("");
                    sekolah_tbl.AddCell("Provinsi"); sekolah_tbl.AddCell(":"); sekolah_tbl.AddCell(myReader.GetString("provinsi"));
                    sekolah_tbl.AddCell("\n"); sekolah_tbl.AddCell(""); sekolah_tbl.AddCell("");
                    sekolah_tbl.AddCell("Website"); sekolah_tbl.AddCell(":"); sekolah_tbl.AddCell(myReader.GetString("website"));
                    sekolah_tbl.AddCell("\n"); sekolah_tbl.AddCell(""); sekolah_tbl.AddCell("");
                    sekolah_tbl.AddCell("Email"); sekolah_tbl.AddCell(":"); sekolah_tbl.AddCell(myReader.GetString("email"));
                }
                doc.Add(sekolah_tbl);
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void DataDiriSiswa(Document doc)
        {
            PdfPTable siswa_tbl = new PdfPTable(4);
            siswa_tbl.TotalWidth = 500f; siswa_tbl.LockedWidth = true;
            siswa_tbl.DefaultCell.Border = Rectangle.NO_BORDER;
            float[] widths1 = new float[] { 50f, 350f, 30f, 600f };
            siswa_tbl.SetWidths(widths1);

            string siswa = "SELECT *, orangtua.no_telp as 'Telp Ortu' from siswa INNER JOIN orangtua USING (nis_siswa) WHERE siswa.nis_siswa = '100000'";
            MySqlCommand getSiswa = new MySqlCommand(siswa, myConn);
            try
            {
                myConn.Open();
                myReader = getSiswa.ExecuteReader();
                while (myReader.Read())
                {
                    siswa_tbl.AddCell("1"); siswa_tbl.AddCell("Nama Peserta Didik Lengkap"); siswa_tbl.AddCell(":"); siswa_tbl.AddCell(myReader.GetString("nama_siswa"));
                    siswa_tbl.AddCell("2"); siswa_tbl.AddCell("Nomor Induk Siswa Nasional"); siswa_tbl.AddCell(":"); siswa_tbl.AddCell(myReader.GetString("nisn_siswa"));
                    siswa_tbl.AddCell("3"); siswa_tbl.AddCell("Tempat Tanggal Lahir"); siswa_tbl.AddCell(":"); siswa_tbl.AddCell(myReader.GetString("tempat_lahir") + ", " + myReader.GetString("tanggal_lahir"));
                    siswa_tbl.AddCell("4"); siswa_tbl.AddCell("Jenis Kelamin"); siswa_tbl.AddCell(":"); siswa_tbl.AddCell(myReader.GetString("jenis_kelamin"));
                    siswa_tbl.AddCell("5"); siswa_tbl.AddCell("Agama"); siswa_tbl.AddCell(":"); siswa_tbl.AddCell(myReader.GetString("agama"));
                    siswa_tbl.AddCell("6"); siswa_tbl.AddCell("Status dalam Keluarga"); siswa_tbl.AddCell(":"); siswa_tbl.AddCell(myReader.GetString("status_keluarga"));
                    siswa_tbl.AddCell("7"); siswa_tbl.AddCell("Anak Ke-"); siswa_tbl.AddCell(":"); siswa_tbl.AddCell(myReader.GetString("anak_ke"));
                    siswa_tbl.AddCell("8"); siswa_tbl.AddCell("Alamat Peserta Didik"); siswa_tbl.AddCell(":"); siswa_tbl.AddCell(myReader.GetString("alamat"));
                    siswa_tbl.AddCell("\n"); siswa_tbl.AddCell(""); siswa_tbl.AddCell(""); siswa_tbl.AddCell("");
                    siswa_tbl.AddCell("9"); siswa_tbl.AddCell("Nomor Telepon Rumah"); siswa_tbl.AddCell(":"); siswa_tbl.AddCell(myReader.GetString("no_telp"));
                    siswa_tbl.AddCell("10"); siswa_tbl.AddCell("Sekolah Asal"); siswa_tbl.AddCell(":"); siswa_tbl.AddCell(myReader.GetString("asal_sekolah"));
                    siswa_tbl.AddCell("11"); siswa_tbl.AddCell("Diterima di Sekolah ini"); siswa_tbl.AddCell(""); siswa_tbl.AddCell("");
                    siswa_tbl.AddCell(""); siswa_tbl.AddCell("a. Di Kelas"); siswa_tbl.AddCell(":"); siswa_tbl.AddCell(myReader.GetString("asal_sekolah"));
                    siswa_tbl.AddCell(""); siswa_tbl.AddCell("b. Pada Tanggal"); siswa_tbl.AddCell(":"); siswa_tbl.AddCell(myReader.GetString("tanggal_masuk"));
                    siswa_tbl.AddCell("12"); siswa_tbl.AddCell("Nama Orang Tua"); siswa_tbl.AddCell(""); siswa_tbl.AddCell("");
                    siswa_tbl.AddCell(""); siswa_tbl.AddCell("a. Ayah"); siswa_tbl.AddCell(":"); siswa_tbl.AddCell(myReader.GetString("nama_ayah"));
                    siswa_tbl.AddCell(""); siswa_tbl.AddCell("b. Ibu"); siswa_tbl.AddCell(":"); siswa_tbl.AddCell(myReader.GetString("nama_ibu"));
                    siswa_tbl.AddCell("13"); siswa_tbl.AddCell("Alamat Orang Tua"); siswa_tbl.AddCell(":"); siswa_tbl.AddCell(myReader.GetString("alamat_ortu"));
                    siswa_tbl.AddCell(""); siswa_tbl.AddCell("Nomor Telepon Rumah"); siswa_tbl.AddCell(":"); siswa_tbl.AddCell(myReader.GetString("Telp Ortu"));
                    siswa_tbl.AddCell("14"); siswa_tbl.AddCell("Pekerjaan Orang Tua"); siswa_tbl.AddCell(""); siswa_tbl.AddCell("");
                    siswa_tbl.AddCell(""); siswa_tbl.AddCell("a. Pekerjaan Ayah"); siswa_tbl.AddCell(":"); siswa_tbl.AddCell(myReader.GetString("pekerjaan_ayah"));
                    siswa_tbl.AddCell(""); siswa_tbl.AddCell("b. Pekerjaan Ibu"); siswa_tbl.AddCell(":"); siswa_tbl.AddCell(myReader.GetString("pekerjaan_ibu"));
                    siswa_tbl.AddCell("\n"); siswa_tbl.AddCell(""); siswa_tbl.AddCell(""); siswa_tbl.AddCell("");
                    siswa_tbl.AddCell("15"); siswa_tbl.AddCell("Nama Wali Peserta Didik"); siswa_tbl.AddCell(":"); siswa_tbl.AddCell(myReader.GetString("nama_wali"));
                    siswa_tbl.AddCell("16"); siswa_tbl.AddCell("Pekerjaan Wali Peserta Didik"); siswa_tbl.AddCell(":"); siswa_tbl.AddCell(myReader.GetString("pekerjaan_wali"));
                    siswa_tbl.AddCell("17"); siswa_tbl.AddCell("Alamat Wali Peserta Didik"); siswa_tbl.AddCell(":"); siswa_tbl.AddCell(myReader.GetString("alamat_wali"));
                    siswa_tbl.AddCell("\n"); siswa_tbl.AddCell(""); siswa_tbl.AddCell(""); siswa_tbl.AddCell("");
                    siswa_tbl.AddCell("\n"); siswa_tbl.AddCell(""); siswa_tbl.AddCell(""); siswa_tbl.AddCell("");
                }
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            System.Drawing.Image image = Properties.Resources.foto3x4;
            iTextSharp.text.Image pic2 = iTextSharp.text.Image.GetInstance(image, System.Drawing.Imaging.ImageFormat.Png);
            pic2.ScalePercent(1.0f);
            pic2.Alignment = Element.ALIGN_LEFT;

            string kepsek = "SELECT *, orangtua.no_telp as 'Telp Ortu' from siswa INNER JOIN orangtua USING (nis_siswa) WHERE siswa.nis_siswa = '100000'";
            MySqlCommand getKepsek = new MySqlCommand(kepsek, myConn);
            try
            {
                myConn.Open();
                myReader = getKepsek.ExecuteReader();
                while (myReader.Read())
                {
                    PdfPCell pcell = new PdfPCell(new Paragraph("Jampangkulon, "));
                    pcell.HorizontalAlignment = Element.ALIGN_CENTER;
                    pcell.Border = Rectangle.NO_BORDER;
                    siswa_tbl.AddCell(""); siswa_tbl.AddCell(""); siswa_tbl.AddCell(""); siswa_tbl.AddCell(pcell);
                    siswa_tbl.AddCell(""); siswa_tbl.AddCell(pic2); siswa_tbl.AddCell(""); siswa_tbl.AddCell(myReader.GetString("nisn_siswa"));
                }
                doc.Add(siswa_tbl);
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

//END CLASS
    }
}
