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

        Font TB12 = FontFactory.GetFont(FontFactory.TIMES_BOLD, 12);
        Font TB14 = FontFactory.GetFont(FontFactory.TIMES_BOLD, 14);
        Font TN12 = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 12);

        Font AB12 = FontFactory.GetFont("Arial Black", 12, Font.BOLD, BaseColor.BLACK);
        Font AN12 = FontFactory.GetFont("Arial Black", 12, Font.NORMAL, BaseColor.BLACK);

        public string getTahun;
        public string field, table, cond;
        string nama_bulan, nama_bulan2;

        public string passTahun
        {
            get { return getTahun; }
            set { getTahun = value; }
        }

        public string formattedDate()
        {
            string format;
            DateTime dt = DateTime.Now;
            format = dt.ToString("dd-MMM-yyyy");
            format = string.Format("{0:dd MMM yyyy}", dt);
            return format.ToString();
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

            var paragraf = new Paragraph("\n\n");
            var paragraf0 = new Paragraph("\n\n\n");
            var paragraf1 = new Paragraph(new Chunk("LAPORAN \nCAPAIAN KOMPETENSI PESERTA DIDIK" +
                                                "\nSEKOLAH MENENGAH ATAS \n(SMA)", TB14)); paragraf1.Alignment = Element.ALIGN_CENTER;
            var paragraf2 = new Paragraph(new Chunk("Nama Peserta Didik", TB12)); paragraf2.Alignment = Element.ALIGN_CENTER;
            var paragraf3 = new Paragraph(new Chunk("Nama Siswa Lengkap", TN12)); paragraf3.Alignment = Element.ALIGN_CENTER;
            var paragraf4 = new Paragraph(new Chunk("NISN:", TB12)); paragraf4.Alignment = Element.ALIGN_CENTER;
            var paragraf5 = new Paragraph(new Chunk("0123456789", TN12)); paragraf5.Alignment = Element.ALIGN_CENTER;
            var paragraf6 = new Paragraph(new Chunk("KEMENTERIAN PENDIDIKAN DAN KEBUDAYAAN \nREPUBLIK INDONESIA", TB14));
                                paragraf6.Alignment = Element.ALIGN_CENTER;
            var paragraf7 = new Paragraph(new Chunk("KETERANGAN TENTANG DIRI PESERTA DIDIK", TB14)); paragraf7.Alignment = Element.ALIGN_CENTER;
            
            //Jilid
            doc.Add(paragraf0); doc.Add(pic);
            doc.Add(paragraf0); doc.Add(paragraf1);
            doc.Add(paragraf0); doc.Add(paragraf0);
            doc.Add(paragraf); doc.Add(paragraf2);
            doc.Add(paragraf3); doc.Add(paragraf);
            doc.Add(paragraf4); doc.Add(paragraf5);
            doc.Add(paragraf0); doc.Add(paragraf6);
            //Profil Sekolah
            doc.NewPage();
            doc.Add(paragraf1); doc.Add(paragraf0);
            DataProfilSekolah(doc);
            //Data Diri siswa
            doc.NewPage();
            doc.Add(paragraf7); doc.Add(paragraf);
            DataDiriSiswa(doc);
            //LCK
            doc.NewPage();
            detailLCKSiswa(doc); nilaiLCKSiswa(doc);
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
                    string diterima = myReader.GetString("tanggal_masuk");
                    string hari = diterima.Substring(0, 2);
                    string bulan = diterima.Substring(3, 2);
                    string tahun = diterima.Substring(6, 4);
                    if (bulan == "01") nama_bulan = "Januari";
                    else if (bulan == "02") nama_bulan = "Februari";
                    else if (bulan == "03") nama_bulan = "Maret";
                    else if (bulan == "04") nama_bulan = "April";
                    else if (bulan == "05") nama_bulan = "Mei";
                    else if (bulan == "06") nama_bulan = "Juni";
                    else if (bulan == "07") nama_bulan = "Juli";
                    else if (bulan == "08") nama_bulan = "Agustus";
                    else if (bulan == "09") nama_bulan = "September";
                    else if (bulan == "10") nama_bulan = "Oktober";
                    else if (bulan == "11") nama_bulan = "Nopember";
                    else if (bulan == "12") nama_bulan = "Desember";
                    
                    string lahir = myReader.GetString("tanggal_lahir");
                    string hari2 = lahir.Substring(0, 2);
                    string bulan2 = lahir.Substring(3, 2);
                    string tahun2 = lahir.Substring(6, 4);
                    if (bulan2 == "01") nama_bulan2 = "Januari";
                    else if (bulan2 == "02") nama_bulan2 = "Februari";
                    else if (bulan2 == "03") nama_bulan2 = "Maret";
                    else if (bulan2 == "04") nama_bulan2 = "April";
                    else if (bulan2 == "05") nama_bulan2 = "Mei";
                    else if (bulan2 == "06") nama_bulan2 = "Juni";
                    else if (bulan2 == "07") nama_bulan2 = "Juli";
                    else if (bulan2 == "08") nama_bulan2 = "Agustus";
                    else if (bulan2 == "09") nama_bulan2 = "September";
                    else if (bulan2 == "10") nama_bulan2 = "Oktober";
                    else if (bulan2 == "11") nama_bulan2 = "Nopember";
                    else if (bulan2 == "12") nama_bulan2 = "Desember";


                    siswa_tbl.AddCell("1"); siswa_tbl.AddCell("Nama Peserta Didik Lengkap"); siswa_tbl.AddCell(":"); siswa_tbl.AddCell(myReader.GetString("nama_siswa"));
                    siswa_tbl.AddCell("2"); siswa_tbl.AddCell("Nomor Induk Siswa Nasional"); siswa_tbl.AddCell(":"); siswa_tbl.AddCell(myReader.GetString("nisn_siswa"));
                    siswa_tbl.AddCell("3"); siswa_tbl.AddCell("Tempat Tanggal Lahir"); siswa_tbl.AddCell(":"); siswa_tbl.AddCell(myReader.GetString("tempat_lahir") + ", " + hari2 + " " + nama_bulan2 + " " + tahun2);
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
                    siswa_tbl.AddCell(""); siswa_tbl.AddCell("b. Pada Tanggal"); siswa_tbl.AddCell(":"); siswa_tbl.AddCell(hari + " " + nama_bulan + " " + tahun);
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
                }
                doc.Add(siswa_tbl);
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            PdfPTable kepsek_tbl = new PdfPTable(3);
            kepsek_tbl.TotalWidth = 500f; kepsek_tbl.LockedWidth = true;
            kepsek_tbl.DefaultCell.Border = Rectangle.NO_BORDER;
            float[] widths2 = new float[] { 150f, 100f, 250f };
            kepsek_tbl.SetWidths(widths2);
            string kepsek = "SELECT nama_guru, nip from guru where keterangan LIKE 'Kepala Sekolah%'";
            MySqlCommand getKepsek = new MySqlCommand(kepsek, myConn);
            try
            {
                myConn.Open();
                myReader = getKepsek.ExecuteReader();
                while (myReader.Read())
                {
                    string[] month = { "Januari", "Februari", "Maret", "April", "Mei", "Juni", "Juli", "Agustus", "September", "Oktober", "November", "Desember" };
                    string tanggal = DateTime.Today.Day.ToString();
                    string bulan3 = month[DateTime.Today.Month - 1] + ", " + DateTime.Today.Year.ToString();

                    var phrase1 = new Paragraph(new Chunk("Jampangkulon, " + tanggal + " " + bulan3, AN12)); phrase1.Alignment = Element.ALIGN_LEFT;
                    var phrase2 = new Paragraph(new Chunk("\nPas Foto \n3x4 \n", AN12)); phrase2.Alignment = Element.ALIGN_RIGHT;
                    var phrase3 = new Paragraph(new Chunk("Kepala Sekolah", AN12)); phrase3.Alignment = Element.ALIGN_LEFT;
                    var phrase4 = new Paragraph(new Chunk(myReader.GetString("nama_guru") + "\nNIP. " + myReader.GetString("nip"), AN12)); phrase4.Alignment = Element.ALIGN_LEFT;
                    kepsek_tbl.AddCell(""); kepsek_tbl.AddCell(""); kepsek_tbl.AddCell(phrase1);
                    kepsek_tbl.AddCell(phrase2); kepsek_tbl.AddCell(""); kepsek_tbl.AddCell(phrase3);
                    kepsek_tbl.AddCell("\n\n\n"); kepsek_tbl.AddCell(""); kepsek_tbl.AddCell("");
                    kepsek_tbl.AddCell(""); kepsek_tbl.AddCell(""); kepsek_tbl.AddCell(phrase4);
                }
                doc.Add(kepsek_tbl);
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void detailLCKSiswa(Document doc)
        {
            PdfPTable sekolah_tbl = new PdfPTable(6);
            sekolah_tbl.TotalWidth = 510f; sekolah_tbl.LockedWidth = true;
            sekolah_tbl.DefaultCell.Border = Rectangle.NO_BORDER;
            float[] widths0 = new float[] { 120f, 5f, 210f, 80f, 5f, 90f };
            sekolah_tbl.SetWidths(widths0);

            string profil = "SELECT nama_sekolah, alamat_sekolah, nama_siswa, nis_siswa from profil_sekolah, siswa where siswa.nis_siswa = '100000'";
            MySqlCommand getProfil = new MySqlCommand(profil, myConn);
            try
            {
                myConn.Open();
                myReader = getProfil.ExecuteReader();
                while (myReader.Read())
                {
                    var phrase = new Paragraph();
                    phrase.Add(new Chunk("Nama Sekolah", TN12));
                    var phrase2 = new Paragraph();
                    phrase2.Add(new Chunk(myReader.GetString("nama_sekolah"), TN12));
                    var phrase3 = new Paragraph();
                    phrase3.Add(new Chunk("Kelas", TN12));
                    var phrase4 = new Paragraph();
                    phrase4.Add(new Chunk("XII MIPA 1", TN12));
                    sekolah_tbl.AddCell(phrase); sekolah_tbl.AddCell(":"); sekolah_tbl.AddCell(phrase2);
                    sekolah_tbl.AddCell(phrase3); sekolah_tbl.AddCell(":"); sekolah_tbl.AddCell(phrase4);

                    var phrase5 = new Paragraph();
                    phrase5.Add(new Chunk("Alamat Sekolah", TN12));
                    var phrase6 = new Paragraph();
                    phrase6.Add(new Chunk(myReader.GetString("alamat_sekolah"), TN12));
                    var phrase7 = new Paragraph();
                    phrase7.Add(new Chunk("Semester", TN12));
                    var phrase8 = new Paragraph();
                    phrase8.Add(new Chunk("1 (Satu)", TN12));
                    sekolah_tbl.AddCell(phrase5); sekolah_tbl.AddCell(":"); sekolah_tbl.AddCell(phrase6);
                    sekolah_tbl.AddCell(phrase7); sekolah_tbl.AddCell(":"); sekolah_tbl.AddCell(phrase8);

                    var phrase9 = new Paragraph();
                    phrase9.Add(new Chunk("Nama Peserta Didik", TN12));
                    var phrase10 = new Paragraph();
                    phrase10.Add(new Chunk(myReader.GetString("nama_siswa"), TN12));
                    var phrase11 = new Paragraph();
                    phrase11.Add(new Chunk("Tahun Ajaran", TN12));
                    var phrase12 = new Paragraph();
                    phrase12.Add(new Chunk("2015/2016", TN12));
                    sekolah_tbl.AddCell(phrase9); sekolah_tbl.AddCell(":"); sekolah_tbl.AddCell(phrase10);
                    sekolah_tbl.AddCell(phrase11); sekolah_tbl.AddCell(":"); sekolah_tbl.AddCell(phrase12);

                    var phrase13 = new Paragraph();
                    phrase13.Add(new Chunk("Nomor Induk/NISN", TN12));
                    var phrase14 = new Paragraph();
                    phrase14.Add(new Chunk(myReader.GetString("nis_siswa"), TN12));
                    sekolah_tbl.AddCell(phrase13); sekolah_tbl.AddCell(":"); sekolah_tbl.AddCell(phrase14);
                    sekolah_tbl.AddCell(""); sekolah_tbl.AddCell(":"); sekolah_tbl.AddCell("");

                    var phrase15 = new PdfPCell(new Phrase(new Chunk("CAPAIAN KOMPETENSI", TB12)));
                    phrase15.Colspan = 6; phrase15.HorizontalAlignment = Element.ALIGN_LEFT;
                    phrase15.Border = Rectangle.NO_BORDER;
                    sekolah_tbl.AddCell(phrase15);
                }
                doc.Add(sekolah_tbl);
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void nilaiLCKSiswa(Document doc)
        {
            PdfPTable LCK_tbl = new PdfPTable(8);
            LCK_tbl.TotalWidth = 510f; LCK_tbl.LockedWidth = true;
            LCK_tbl.PaddingTop = 5;
            //LCK_tbl.DefaultCell.Border = Rectangle.NO_BORDER;
            float[] widths = new float[] { 10f, 135f, 45f, 45f, 45f, 45f, 55f, 100f };
            LCK_tbl.SetWidths(widths);

            var col11 = new PdfPCell(new Phrase(new Chunk("\n\nMATA PELAJARAN", TB12)));
            col11.Rowspan = 3; col11.Colspan = 2; col11.HorizontalAlignment = Element.ALIGN_CENTER;
            var col13 = new PdfPCell(new Phrase(new Chunk("\nPengetahuan \n(KI-3)", TB12)));
            col13.Rowspan = 2; col13.Colspan = 2; col13.HorizontalAlignment = Element.ALIGN_CENTER;
            var col15 = new PdfPCell(new Phrase(new Chunk("\nKeterampilan \n(KI-4)", TB12)));
            col15.Rowspan = 2; col15.Colspan = 2; col15.HorizontalAlignment = Element.ALIGN_CENTER;
            var col17 = new PdfPCell(new Phrase(new Chunk("Sikap Sosial dan Spiritual \n(KI-1 & KI-2)", TB12)));
            col17.Colspan = 2; col17.HorizontalAlignment = Element.ALIGN_CENTER;
            LCK_tbl.AddCell(col11); LCK_tbl.AddCell(col13); LCK_tbl.AddCell(col15); LCK_tbl.AddCell(col17);

            var col27 = new PdfPCell(new Phrase(new Chunk("Dalam \nMapel", TN12)));
            col27.Rowspan = 2; col27.HorizontalAlignment = Element.ALIGN_CENTER;
            var col28 = new PdfPCell(new Phrase(new Chunk("\nAntar Mapel", TN12)));
            col28.Rowspan = 2; col28.HorizontalAlignment = Element.ALIGN_CENTER;
            LCK_tbl.AddCell(col27); LCK_tbl.AddCell(col28);

            var col33 = new PdfPCell(new Phrase(new Chunk("Angka", TN12))); col33.HorizontalAlignment = Element.ALIGN_CENTER;
            var col34 = new PdfPCell(new Phrase(new Chunk("Predikat", TN12))); col34.HorizontalAlignment = Element.ALIGN_CENTER;
            var col35 = new PdfPCell(new Phrase(new Chunk("Angka", TN12))); col35.HorizontalAlignment = Element.ALIGN_CENTER;
            var col36 = new PdfPCell(new Phrase(new Chunk("Predikat", TN12))); col36.HorizontalAlignment = Element.ALIGN_CENTER;
            LCK_tbl.AddCell(col33); LCK_tbl.AddCell(col34); LCK_tbl.AddCell(col35); LCK_tbl.AddCell(col36);

            var col41 = new PdfPCell(new Phrase(new Chunk("Kelompok A (Wajib)", TB12))); col41.HorizontalAlignment = Element.ALIGN_CENTER;
            col41.Colspan = 2;
            var col43 = new PdfPCell(new Phrase(new Chunk("1-4", TN12))); col43.HorizontalAlignment = Element.ALIGN_CENTER;
            var col45 = new PdfPCell(new Phrase(new Chunk("1-4", TN12))); col45.HorizontalAlignment = Element.ALIGN_CENTER;
            var col47 = new PdfPCell(new Phrase(new Chunk("SB/B/C/K", TN12))); col47.HorizontalAlignment = Element.ALIGN_CENTER;
            LCK_tbl.AddCell(col41); LCK_tbl.AddCell(col43); LCK_tbl.AddCell(""); LCK_tbl.AddCell(col45); LCK_tbl.AddCell("");
            LCK_tbl.AddCell(col47); LCK_tbl.AddCell(""); 

            doc.Add(LCK_tbl);
        }

        //END CLASS
    }
}
