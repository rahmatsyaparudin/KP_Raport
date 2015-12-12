using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Collections;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Security.Permissions;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Raport
{
    class DataToPDF
    {
        MySqlConnection myConn = Function.getKoneksi();
        Function db = new Function();
        MySqlDataReader myReader;
        MySqlCommand myComm;
        Font TB12 = FontFactory.GetFont(FontFactory.TIMES_BOLD, 12);
        Font TB11 = FontFactory.GetFont(FontFactory.TIMES_BOLD, 11);
        Font TB14 = FontFactory.GetFont(FontFactory.TIMES_BOLD, 14);
        Font TN12 = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 12);
        Font TN11 = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 11);
        Font TN10 = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10);
        Font TN8 = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 8);
        Font AB12 = FontFactory.GetFont("Arial Black", 12, Font.BOLD, BaseColor.BLACK);
        Font AN12 = FontFactory.GetFont("Arial Black", 12, Font.NORMAL, BaseColor.BLACK);
        BaseFont TimesNW = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, false);
        Document doc = new Document(iTextSharp.text.PageSize.A4, 20, 20, 10, 40);
        PdfWriter writer;
        PdfPTable raport_tbl;
        PdfPCell cell = new PdfPCell();
        FileStream fs = null;

        public string nama_siswa, nisn_siswa;
        public string nama_guru, nip_guru;
        public string nama_bulan;
        public string getTahun;
        string fullPath;
        float[] widths;

        string[] month = { "Januari", "Februari", "Maret", "April", "Mei", "Juni", "Juli", "Agustus", "September",
                           "Oktober", "November", "Desember" };
        string tanggal = DateTime.Today.Day.ToString();
        
        //Queries
        public string profil_siswa = "SELECT nama_siswa, nisn_siswa FROM siswa WHERE nis_siswa = '1314.10.006'";
        public string profil_sekolah = "SELECT * FROM profil_sekolah";
        public string siswa_ortu = "SELECT *, orangtua.no_telp as 'Telp Ortu' FROM siswa INNER JOIN orangtua " +
                                   "USING (nis_siswa) WHERE siswa.nis_siswa = '1314.10.006'";
        public string kepala_sekolah = "SELECT nama_guru, nip FROM guru WHERE keterangan LIKE 'Kepala Sekolah%'";
        public string wali_kelas = "SELECT nama_guru, nip FROM kelas INNER JOIN guru USING (id_guru) " +
                                   "WHERE kode_kelas = '3'";
        public string profil_LCK = "SELECT nama_sekolah, alamat_sekolah, nama_siswa, nis_siswa, nama_kelas " +
                               "FROM profil_sekolah, siswa, kelas WHERE siswa.nis_siswa = '1314.10.006' AND kelas.kode_kelas = '3'";
        public string kategoriA = "SELECT mata_pelajaran, nama_guru, p_ang, p_pred, k_ang, k_pred, s_sikap " +
                           "FROM nilai INNER JOIN mapel USING (kode_mapel) INNER JOIN detailmapelkelas USING (kode_mapel) " +
                           "INNER JOIN guru USING (id_guru) WHERE nis_siswa = '1314.10.006' AND kode_semester= 'SMT1' " +
                           "AND nilai.kode_kelas = '3' AND detailmapelkelas.kode_kelas = '3' AND kategori_mapel = 'Kelompok A'";
        public string kategoriB = "SELECT mata_pelajaran, nama_guru, p_ang, p_pred, k_ang, k_pred, s_sikap " +
                           "FROM nilai INNER JOIN mapel USING (kode_mapel) INNER JOIN detailmapelkelas USING (kode_mapel) " +
                           "INNER JOIN guru USING (id_guru) WHERE nis_siswa = '1314.10.006' AND kode_semester= 'SMT1' " +
                           "AND nilai.kode_kelas = '3' AND detailmapelkelas.kode_kelas = '3' AND kategori_mapel = 'Kelompok B'";
        public string kategoriC = "SELECT mata_pelajaran, nama_guru, p_ang, p_pred, k_ang, k_pred, s_sikap " +
                           "FROM nilai INNER JOIN mapel USING (kode_mapel) INNER JOIN detailmapelkelas USING (kode_mapel) " +
                           "INNER JOIN guru USING (id_guru) WHERE nis_siswa = '1314.10.006' AND kode_semester= 'SMT1' " +
                           "AND nilai.kode_kelas = '3' AND detailmapelkelas.kode_kelas = '3' AND kategori_mapel = 'Kelompok C'";


        public string passTahun
        {
            get { return getTahun; }
            set { getTahun = value; }
        }

        public string getBulan(string bulan)
        {
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
            else if (bulan == "11") nama_bulan = "Nopember"; else if (bulan == "12") nama_bulan = "Desember";

            return nama_bulan;
        }

        public async Task SaveFileContentsAsync(string filePath, Stream stream)
        {
            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                await stream.CopyToAsync(fileStream);
            }
        }

        public void killPDFProcess()
        {
            foreach (Process clsProcess in Process.GetProcesses())
            {
                if (clsProcess.ProcessName.Equals("AcroRd32"))
                {
                    clsProcess.Kill();
                    break;
                }
            }
        }

        public void RaportToPDF2()
        {
            killPDFProcess();
            string path = "Nilai Siswa (PDF)";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            string appRootDir = new DirectoryInfo(Environment.CurrentDirectory).FullName;
            try
            {
                using (FileStream fs = new FileStream(appRootDir + "\\Nilai Siswa (PDF)\\" + "Chapter1_Example8"+db.randomIdGuru()+".pdf", FileMode.Create, FileAccess.Write, FileShare.None))
                using (Document docs = new Document())
                using (PdfWriter writer = PdfWriter.GetInstance(docs, fs))
                {
                    writer.SetEncryption(PdfWriter.STRENGTH40BITS, null, null, PdfWriter.ALLOW_COPY);
                    System.Drawing.Image image = Properties.Resources.LogoPendidikan;
                    iTextSharp.text.Image pic = iTextSharp.text.Image.GetInstance(image, System.Drawing.Imaging.ImageFormat.Png);
                    pic.ScalePercent(13.0f);
                    pic.Alignment = Element.ALIGN_CENTER;

                    myComm = new MySqlCommand(profil_siswa, myConn);
                    try
                    {
                        myConn.Open();
                        myReader = myComm.ExecuteReader();
                        while (myReader.Read())
                        {
                            nama_siswa = myReader.GetString("nama_siswa");
                            nisn_siswa = myReader.GetString("nisn_siswa");
                        }
                        myConn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    var paragraf = new Paragraph("\n\n");
                    var paragraf0 = new Paragraph("\n\n\n");
                    var paragraf1 = new Paragraph(new Chunk("LAPORAN \nCAPAIAN KOMPETENSI PESERTA DIDIK" +
                                                        "\nSEKOLAH MENENGAH ATAS \n(SMA)", TB14)); paragraf1.Alignment = Element.ALIGN_CENTER;
                    var paragraf2 = new Paragraph(new Chunk("Nama Peserta Didik", TB12)); paragraf2.Alignment = Element.ALIGN_CENTER;
                    var paragraf3 = new Paragraph(new Chunk(nama_siswa, TN12)); paragraf3.Alignment = Element.ALIGN_CENTER;
                    var paragraf4 = new Paragraph(new Chunk("NISN:", TB12)); paragraf4.Alignment = Element.ALIGN_CENTER;
                    var paragraf5 = new Paragraph(new Chunk(nisn_siswa, TN12)); paragraf5.Alignment = Element.ALIGN_CENTER;
                    var paragraf6 = new Paragraph(new Chunk("KEMENTERIAN PENDIDIKAN DAN KEBUDAYAAN \nREPUBLIK INDONESIA", TB14));
                    paragraf6.Alignment = Element.ALIGN_CENTER;
                    var paragraf7 = new Paragraph(new Chunk("KETERANGAN TENTANG DIRI PESERTA DIDIK", TB14)); paragraf7.Alignment = Element.ALIGN_CENTER;
                    var paragraf8 = new Paragraph("\n");

                    //Jilid
                    docs.Open();
                    docs.NewPage();
                    docs.Add(paragraf0); docs.Add(pic);
                    docs.Add(paragraf0); docs.Add(paragraf1);
                    docs.Add(paragraf0); docs.Add(paragraf0);
                    docs.Add(paragraf); docs.Add(paragraf2);
                    docs.Add(paragraf3); docs.Add(paragraf);
                    docs.Add(paragraf4); docs.Add(paragraf5);
                    docs.Add(paragraf0); docs.Add(paragraf6);
                    //Profil Sekolah
                    docs.NewPage();
                    docs.Add(paragraf1); docs.Add(paragraf0);
                    ProfilSekolah(docs);
                    //Data Diri siswa
                    docs.NewPage();
                    docs.Add(paragraf7); docs.Add(paragraf8);
                    DataSiswa(docs);
                    KepalaSekolah(docs);
                    //LCK
                    docs.NewPage();
                    detailLCKSiswa(docs); kriteriaLCK(docs);
                    nilaiLCK_A(docs); nilaiLCK_B(docs); nilaiLCK_C(docs);
                    ekskul_siswa(docs); absensi_siswa(docs);
                    walikelas_ortu(docs);
                    docs.Close();
                    writer.Close();
                    fs.Close();
                }
            }
			catch (DocumentException de)
			{
				throw de;
			}
			catch (IOException ioe)
			{
				throw ioe;
			}
        }

        public void RaportToPDF(string filename, SaveFileDialog sfDialog)
        {
            sfDialog.InitialDirectory = "D:";
            sfDialog.Title = "Save as PDF File";
            sfDialog.FileName = filename;
            sfDialog.Filter = "PDF Files|*.pdf";
            if (sfDialog.ShowDialog() != DialogResult.Cancel)
            {
                
                //foreach (FileInfo fi in sourceinfo.GetFiles())
                string dir = sfDialog.FileName.ToString();
                DirectoryInfo sourceinfo = new DirectoryInfo(dir);
                foreach (Process proc in Process.GetProcessesByName(filename + ".pdf"))
                {
                    proc.Kill();
                }
                    FileStream fs = new FileStream(sfDialog.FileName, FileMode.OpenOrCreate);
                    PdfWriter wri  = PdfWriter.GetInstance(doc, fs);
                    System.Drawing.Image image = Properties.Resources.LogoPendidikan;
                    iTextSharp.text.Image pic = iTextSharp.text.Image.GetInstance(image, System.Drawing.Imaging.ImageFormat.Png);
                    pic.ScalePercent(13.0f);
                    pic.Alignment = Element.ALIGN_CENTER;

                    myComm = new MySqlCommand(profil_siswa, myConn);
                    try
                    {
                        myConn.Open();
                        myReader = myComm.ExecuteReader();
                        while (myReader.Read())
                        {
                            nama_siswa = myReader.GetString("nama_siswa");
                            nisn_siswa = myReader.GetString("nisn_siswa");
                        }
                        myConn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    var paragraf = new Paragraph("\n\n");
                    var paragraf0 = new Paragraph("\n\n\n");
                    var paragraf1 = new Paragraph(new Chunk("LAPORAN \nCAPAIAN KOMPETENSI PESERTA DIDIK" +
                                                        "\nSEKOLAH MENENGAH ATAS \n(SMA)", TB14)); paragraf1.Alignment = Element.ALIGN_CENTER;
                    var paragraf2 = new Paragraph(new Chunk("Nama Peserta Didik", TB12)); paragraf2.Alignment = Element.ALIGN_CENTER;
                    var paragraf3 = new Paragraph(new Chunk(nama_siswa, TN12)); paragraf3.Alignment = Element.ALIGN_CENTER;
                    var paragraf4 = new Paragraph(new Chunk("NISN:", TB12)); paragraf4.Alignment = Element.ALIGN_CENTER;
                    var paragraf5 = new Paragraph(new Chunk(nisn_siswa, TN12)); paragraf5.Alignment = Element.ALIGN_CENTER;
                    var paragraf6 = new Paragraph(new Chunk("KEMENTERIAN PENDIDIKAN DAN KEBUDAYAAN \nREPUBLIK INDONESIA", TB14));
                    paragraf6.Alignment = Element.ALIGN_CENTER;
                    var paragraf7 = new Paragraph(new Chunk("KETERANGAN TENTANG DIRI PESERTA DIDIK", TB14)); paragraf7.Alignment = Element.ALIGN_CENTER;
                    var paragraf8 = new Paragraph("\n");

                    //Jilid
                    doc.Open();
                    doc.NewPage();
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
                    ProfilSekolah(doc);
                    //Data Diri siswa
                    doc.NewPage();
                    doc.Add(paragraf7); doc.Add(paragraf8);
                    DataSiswa(doc);
                    KepalaSekolah(doc);
                    //LCK
                    doc.NewPage();
                    detailLCKSiswa(doc); kriteriaLCK(doc);
                    nilaiLCK_A(doc); nilaiLCK_B(doc); nilaiLCK_C(doc);
                    ekskul_siswa(doc); absensi_siswa(doc);
                    walikelas_ortu(doc);
                    doc.Close();
                    fs.Dispose();
                    fs.Close();
            }
        }

        public void ProfilSekolah(Document doc)
        {
            raport_tbl = new PdfPTable(3);
            raport_tbl.TotalWidth = 500f; raport_tbl.LockedWidth = true;
            raport_tbl.DefaultCell.Border = Rectangle.NO_BORDER;
            widths = new float[] { 200f, 30f, 770f };
            raport_tbl.SetWidths(widths);

            myComm = new MySqlCommand(profil_sekolah, myConn);
            try
            {
                myConn.Open();
                myReader = myComm.ExecuteReader();
                while (myReader.Read())
                {
                    cell.Colspan = 2; cell.BorderWidth = 0f;
                    raport_tbl.AddCell("Nama Sekolah"); raport_tbl.AddCell(":"); raport_tbl.AddCell(myReader.GetString("nama_sekolah"));
                    raport_tbl.AddCell("\n"); raport_tbl.AddCell(cell);
                    raport_tbl.AddCell("NPSN/NSS"); raport_tbl.AddCell(":"); raport_tbl.AddCell(myReader.GetString("npsn") + " / " + myReader.GetString("nss"));
                    raport_tbl.AddCell("\n"); raport_tbl.AddCell(cell);
                    raport_tbl.AddCell("Alamat Sekolah"); raport_tbl.AddCell(":"); raport_tbl.AddCell(myReader.GetString("alamat_sekolah"));
                    raport_tbl.AddCell("\n"); raport_tbl.AddCell(cell);
                    raport_tbl.AddCell("\n\n\n"); raport_tbl.AddCell(""); raport_tbl.AddCell("Kode Pos " + myReader.GetString("kode_pos") + "Telp. " + myReader.GetString("no_telp"));
                    raport_tbl.AddCell("\n"); raport_tbl.AddCell(cell);
                    raport_tbl.AddCell("Kelurahan"); raport_tbl.AddCell(":"); raport_tbl.AddCell(myReader.GetString("kelurahan"));
                    raport_tbl.AddCell("\n"); raport_tbl.AddCell(cell);
                    raport_tbl.AddCell("Kecamatan"); raport_tbl.AddCell(":"); raport_tbl.AddCell(myReader.GetString("kecamatan"));
                    raport_tbl.AddCell("\n"); raport_tbl.AddCell(cell);
                    raport_tbl.AddCell("Kabupaten/Kota"); raport_tbl.AddCell(":"); raport_tbl.AddCell(myReader.GetString("kota"));
                    raport_tbl.AddCell("\n"); raport_tbl.AddCell(cell);
                    raport_tbl.AddCell("Provinsi"); raport_tbl.AddCell(":"); raport_tbl.AddCell(myReader.GetString("provinsi"));
                    raport_tbl.AddCell("\n"); raport_tbl.AddCell(cell);
                    raport_tbl.AddCell("Website"); raport_tbl.AddCell(":"); raport_tbl.AddCell(myReader.GetString("website"));
                    raport_tbl.AddCell("\n"); raport_tbl.AddCell(cell);
                    raport_tbl.AddCell("Email"); raport_tbl.AddCell(":"); raport_tbl.AddCell(myReader.GetString("email"));
                }
                myConn.Close();
                doc.Add(raport_tbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DataSiswa(Document doc)
        {
            raport_tbl = new PdfPTable(4);
            raport_tbl.TotalWidth = 500f; raport_tbl.LockedWidth = true;
            raport_tbl.DefaultCell.Border = Rectangle.NO_BORDER;
            widths = new float[] { 50f, 350f, 30f, 600f };
            raport_tbl.SetWidths(widths);

            myComm = new MySqlCommand(siswa_ortu, myConn);
            try
            {
                myConn.Open();
                myReader = myComm.ExecuteReader();
                while (myReader.Read())
                {
                    string diterima = myReader.GetString("tanggal_masuk"); string tanggal_diterima = diterima.Substring(0, 2);
                    string bulan_diterima = diterima.Substring(3, 2); string tahun_diterima = diterima.Substring(6, 4);
                    string diterima_bulan = getBulan(bulan_diterima);
                    string lahir = myReader.GetString("tanggal_lahir"); string tanggal_lahir = lahir.Substring(0, 2);
                    string bulan_lahir = lahir.Substring(3, 2); string tahun_lahir = lahir.Substring(6, 4);
                    string lahir_bulan = getBulan(bulan_lahir);

                    raport_tbl.AddCell("1"); raport_tbl.AddCell("Nama Peserta Didik Lengkap"); raport_tbl.AddCell(":"); raport_tbl.AddCell(myReader.GetString("nama_siswa"));
                    raport_tbl.AddCell("2"); raport_tbl.AddCell("Nomor Induk Siswa Nasional"); raport_tbl.AddCell(":"); raport_tbl.AddCell(myReader.GetString("nisn_siswa"));
                    raport_tbl.AddCell("3"); raport_tbl.AddCell("Tempat Tanggal Lahir"); raport_tbl.AddCell(":"); raport_tbl.AddCell(myReader.GetString("tempat_lahir") + ", " + tanggal_lahir + " " + lahir_bulan + " " + tahun_lahir);
                    raport_tbl.AddCell("4"); raport_tbl.AddCell("Jenis Kelamin"); raport_tbl.AddCell(":"); raport_tbl.AddCell(myReader.GetString("jenis_kelamin"));
                    raport_tbl.AddCell("5"); raport_tbl.AddCell("Agama"); raport_tbl.AddCell(":"); raport_tbl.AddCell(myReader.GetString("agama"));
                    raport_tbl.AddCell("6"); raport_tbl.AddCell("Status dalam Keluarga"); raport_tbl.AddCell(":"); raport_tbl.AddCell(myReader.GetString("status_keluarga"));
                    raport_tbl.AddCell("7"); raport_tbl.AddCell("Anak Ke-"); raport_tbl.AddCell(":"); raport_tbl.AddCell(myReader.GetString("anak_ke"));
                    raport_tbl.AddCell("8"); raport_tbl.AddCell("Alamat Peserta Didik"); raport_tbl.AddCell(":"); raport_tbl.AddCell(myReader.GetString("alamat"));
                    raport_tbl.AddCell("\n"); raport_tbl.AddCell(""); raport_tbl.AddCell(""); raport_tbl.AddCell("");
                    raport_tbl.AddCell("9"); raport_tbl.AddCell("Nomor Telepon Rumah"); raport_tbl.AddCell(":"); raport_tbl.AddCell(myReader.GetString("no_telp"));
                    raport_tbl.AddCell("10"); raport_tbl.AddCell("Sekolah Asal"); raport_tbl.AddCell(":"); raport_tbl.AddCell(myReader.GetString("asal_sekolah"));
                    raport_tbl.AddCell("11"); raport_tbl.AddCell("Diterima di Sekolah ini"); raport_tbl.AddCell(""); raport_tbl.AddCell("");
                    raport_tbl.AddCell(""); raport_tbl.AddCell("a. Di Kelas"); raport_tbl.AddCell(":"); raport_tbl.AddCell(myReader.GetString("asal_sekolah"));
                    raport_tbl.AddCell(""); raport_tbl.AddCell("b. Pada Tanggal"); raport_tbl.AddCell(":"); raport_tbl.AddCell(tanggal_diterima + " " + diterima_bulan + " " + tahun_diterima);
                    raport_tbl.AddCell("12"); raport_tbl.AddCell("Nama Orang Tua"); raport_tbl.AddCell(""); raport_tbl.AddCell("");
                    raport_tbl.AddCell(""); raport_tbl.AddCell("a. Ayah"); raport_tbl.AddCell(":"); raport_tbl.AddCell(myReader.GetString("nama_ayah"));
                    raport_tbl.AddCell(""); raport_tbl.AddCell("b. Ibu"); raport_tbl.AddCell(":"); raport_tbl.AddCell(myReader.GetString("nama_ibu"));
                    raport_tbl.AddCell("13"); raport_tbl.AddCell("Alamat Orang Tua"); raport_tbl.AddCell(":"); raport_tbl.AddCell(myReader.GetString("alamat_ortu"));
                    raport_tbl.AddCell(""); raport_tbl.AddCell("Nomor Telepon Rumah"); raport_tbl.AddCell(":"); raport_tbl.AddCell(myReader.GetString("Telp Ortu"));
                    raport_tbl.AddCell("14"); raport_tbl.AddCell("Pekerjaan Orang Tua"); raport_tbl.AddCell(""); raport_tbl.AddCell("");
                    raport_tbl.AddCell(""); raport_tbl.AddCell("a. Pekerjaan Ayah"); raport_tbl.AddCell(":"); raport_tbl.AddCell(myReader.GetString("pekerjaan_ayah"));
                    raport_tbl.AddCell(""); raport_tbl.AddCell("b. Pekerjaan Ibu"); raport_tbl.AddCell(":"); raport_tbl.AddCell(myReader.GetString("pekerjaan_ibu"));
                    raport_tbl.AddCell("\n"); raport_tbl.AddCell(""); raport_tbl.AddCell(""); raport_tbl.AddCell("");
                    raport_tbl.AddCell("15"); raport_tbl.AddCell("Nama Wali Peserta Didik"); raport_tbl.AddCell(":"); raport_tbl.AddCell(myReader.GetString("nama_wali"));
                    raport_tbl.AddCell("16"); raport_tbl.AddCell("Pekerjaan Wali Peserta Didik"); raport_tbl.AddCell(":"); raport_tbl.AddCell(myReader.GetString("pekerjaan_wali"));
                    raport_tbl.AddCell("17"); raport_tbl.AddCell("Alamat Wali Peserta Didik"); raport_tbl.AddCell(":"); raport_tbl.AddCell(myReader.GetString("alamat_wali"));
                    raport_tbl.AddCell("\n"); raport_tbl.AddCell(""); raport_tbl.AddCell(""); raport_tbl.AddCell("");
                }
                myConn.Close();
                doc.Add(raport_tbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void KepalaSekolah(Document doc)
        {
            raport_tbl = new PdfPTable(3);
            raport_tbl.TotalWidth = 500f; raport_tbl.LockedWidth = true;
            raport_tbl.DefaultCell.Border = Rectangle.NO_BORDER;
            widths = new float[] { 150f, 100f, 250f };
            raport_tbl.SetWidths(widths);
            
            myComm = new MySqlCommand(kepala_sekolah, myConn);
            try
            {
                myConn.Open();
                myReader = myComm.ExecuteReader();
                while (myReader.Read())
                {
                    string bulan = month[DateTime.Today.Month - 1] + " " + DateTime.Today.Year.ToString();
                    var phrase1 = new Paragraph(new Chunk("Jampangkulon, " + tanggal + " " + bulan, AN12));
                    var phrase2 = new Paragraph(new Chunk("\n          Pas Foto \n          3x4 \n", AN12));
                    var phrase3 = new Paragraph(new Chunk("Kepala Sekolah", AN12));
                    var phrase4 = new Paragraph(new Chunk(myReader.GetString("nama_guru") + "\nNIP. " + 
                                                          myReader.GetString("nip"), AN12)); 
                    phrase1.Alignment = Element.ALIGN_LEFT; phrase2.Alignment = Element.ALIGN_RIGHT;
                    phrase3.Alignment = Element.ALIGN_LEFT; phrase4.Alignment = Element.ALIGN_LEFT;
                    cell.Colspan = 2; cell.BorderWidth = 0f;

                    raport_tbl.AddCell(cell); raport_tbl.AddCell(phrase1);
                    raport_tbl.AddCell(phrase2); raport_tbl.AddCell(""); raport_tbl.AddCell(phrase3);
                    raport_tbl.AddCell(cell); raport_tbl.AddCell("\n\n\n");
                    raport_tbl.AddCell(cell); raport_tbl.AddCell(phrase4);
                }
                myConn.Close();
                doc.Add(raport_tbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void detailLCKSiswa(Document doc)
        {
            PdfPTable raport_tbl = new PdfPTable(6);
            raport_tbl.TotalWidth = 510f; raport_tbl.LockedWidth = true;
            raport_tbl.DefaultCell.Border = Rectangle.NO_BORDER;
            float[] widths0 = new float[] { 120f, 10f, 205f, 80f, 10f, 85f };
            raport_tbl.SetWidths(widths0);
            
            myComm = new MySqlCommand(profil_LCK, myConn);
            try
            {
                myConn.Open();
                myReader = myComm.ExecuteReader();
                while (myReader.Read())
                {
                    var phrase1 = new Paragraph(new Chunk("Nama Sekolah", TN11));
                    var phrase2 = new Paragraph(new Chunk(myReader.GetString("nama_sekolah"), TN11));
                    var phrase3 = new Paragraph(new Chunk("Kelas", TN11));
                    var phrase4 = new Paragraph(new Chunk(myReader.GetString("nama_kelas"), TN11));
                    raport_tbl.AddCell(phrase1); raport_tbl.AddCell(":"); raport_tbl.AddCell(phrase2);
                    raport_tbl.AddCell(phrase3); raport_tbl.AddCell(":"); raport_tbl.AddCell(phrase4);

                    var phrase5 = new Paragraph(new Chunk("Alamat Sekolah", TN11));
                    var phrase6 = new Paragraph(new Chunk(myReader.GetString("alamat_sekolah"), TN11));
                    var phrase7 = new Paragraph(new Chunk("Semester", TN11));
                    //SEMESTER BELUM DITENTUKAN JANGAN SAMPE LUPA BISA GAWAT
                    var phrase8 = new Paragraph(new Chunk("1 (Satu)", TN11));
                    raport_tbl.AddCell(phrase5); raport_tbl.AddCell(":"); raport_tbl.AddCell(phrase6);
                    raport_tbl.AddCell(phrase7); raport_tbl.AddCell(":"); raport_tbl.AddCell(phrase8);

                    var phrase9 = new Paragraph(new Chunk("Nama Peserta Didik", TN11));
                    var phrase10 = new Paragraph(new Chunk(myReader.GetString("nama_siswa"), TN11));
                    var phrase11 = new Paragraph(new Chunk("Tahun Ajaran", TN11));
                    var phrase12 = new Paragraph(new Chunk(getTahun, TN11));
                    raport_tbl.AddCell(phrase9); raport_tbl.AddCell(":"); raport_tbl.AddCell(phrase10);
                    raport_tbl.AddCell(phrase11); raport_tbl.AddCell(":"); raport_tbl.AddCell(phrase12);

                    var phrase13 = new Paragraph(new Chunk("Nomor Induk/NISN", TN11));
                    var phrase14 = new Paragraph(new Chunk(myReader.GetString("nis_siswa"), TN11));
                    raport_tbl.AddCell(phrase13); raport_tbl.AddCell(":"); raport_tbl.AddCell(phrase14);
                    raport_tbl.AddCell(""); raport_tbl.AddCell(""); raport_tbl.AddCell("");

                    var phrase15 = new PdfPCell(new Phrase(new Chunk("CAPAIAN KOMPETENSI", TB11)));
                    phrase15.Colspan = 6; phrase15.HorizontalAlignment = Element.ALIGN_LEFT;
                    phrase15.BorderWidth = 0f;
                    raport_tbl.AddCell(phrase15);
                }
                myConn.Close();
                doc.Add(raport_tbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void kriteriaLCK(Document doc)
        {
            raport_tbl = new PdfPTable(8);
            raport_tbl.TotalWidth = 510f; raport_tbl.LockedWidth = true;
            widths = new float[] { 10f, 185f, 35f, 40f, 35f, 40f, 55f, 80f };
            raport_tbl.SetWidths(widths);

            var cell1 = new PdfPCell(new Phrase(new Chunk("MATA PELAJARAN", TB11))); cell1.Rowspan = 2; cell1.Colspan = 2;
            cell1.HorizontalAlignment = Element.ALIGN_CENTER; cell1.VerticalAlignment = Element.ALIGN_MIDDLE;
            var cell2 = new PdfPCell(new Phrase(new Chunk("Pengetahuan \n(KI-3)", TB11))); cell2.Colspan = 2;
            cell2.HorizontalAlignment = Element.ALIGN_CENTER; cell2.VerticalAlignment = Element.ALIGN_MIDDLE;
            var cell3 = new PdfPCell(new Phrase(new Chunk("Keterampilan \n(KI-4)", TB11))); cell3.Colspan = 2;
            cell3.HorizontalAlignment = Element.ALIGN_CENTER; cell3.VerticalAlignment = Element.ALIGN_MIDDLE;
            var cell4 = new PdfPCell(new Phrase(new Chunk("Sikap Sosial dan Spiritual \n(KI-1 & KI-2)", TB11)));
            cell4.Colspan = 2; cell4.HorizontalAlignment = Element.ALIGN_CENTER; cell4.VerticalAlignment = Element.ALIGN_MIDDLE;
            raport_tbl.AddCell(cell1); raport_tbl.AddCell(cell2); raport_tbl.AddCell(cell3); raport_tbl.AddCell(cell4);

            var cell5 = new PdfPCell(new Phrase(new Chunk("Angka", TN11)));
            cell5.HorizontalAlignment = Element.ALIGN_CENTER; cell5.VerticalAlignment = Element.ALIGN_BOTTOM;
            var cell6 = new PdfPCell(new Phrase(new Chunk("Predikat", TN11)));
            cell6.HorizontalAlignment = Element.ALIGN_CENTER; cell6.VerticalAlignment = Element.ALIGN_BOTTOM;
            var cell7 = new PdfPCell(new Phrase(new Chunk("Dalam \nMapel", TN11)));
            cell7.HorizontalAlignment = Element.ALIGN_CENTER; cell7.VerticalAlignment = Element.ALIGN_MIDDLE;
            var cell8 = new PdfPCell(new Phrase(new Chunk("Antar Mapel", TN11)));
            cell8.HorizontalAlignment = Element.ALIGN_CENTER; cell8.VerticalAlignment = Element.ALIGN_BOTTOM;
            raport_tbl.AddCell(cell5); raport_tbl.AddCell(cell6); raport_tbl.AddCell(cell5);
            raport_tbl.AddCell(cell6); raport_tbl.AddCell(cell7); raport_tbl.AddCell(cell8);

            var cell9 = new PdfPCell(new Phrase(new Chunk("Kelompok A (Wajib)", TB11)));
            cell9.HorizontalAlignment = Element.ALIGN_LEFT; cell9.Colspan = 2;
            var cell10 = new PdfPCell(new Phrase(new Chunk("1 - 4", TN11))); cell10.HorizontalAlignment = Element.ALIGN_CENTER;
            var cell11 = new PdfPCell(new Phrase(new Chunk("1 - 4", TN11))); cell11.HorizontalAlignment = Element.ALIGN_CENTER;
            var cell12 = new PdfPCell(new Phrase(new Chunk("SB/B/C/K", TN11))); cell12.HorizontalAlignment = Element.ALIGN_CENTER;
            cell.BorderWidth = 0f; cell.BorderWidthRight = 0.5f;
            raport_tbl.AddCell(cell9); raport_tbl.AddCell(cell10); raport_tbl.AddCell(""); raport_tbl.AddCell(cell11);
            raport_tbl.AddCell(""); raport_tbl.AddCell(cell12); raport_tbl.AddCell(cell);

            doc.Add(raport_tbl);
        }

        public void nilaiLCK_A(Document doc)
        {
            raport_tbl = new PdfPTable(8);
            raport_tbl.TotalWidth = 510f; raport_tbl.LockedWidth = true;
            widths = new float[] { 10f, 185f, 35f, 40f, 35f, 40f, 55f, 80f };
            raport_tbl.SetWidths(widths);

            myComm = new MySqlCommand(kategoriA, myConn);
            try
            {
                myConn.Open();
                myReader = myComm.ExecuteReader();
                int i = 1;
                while (myReader.Read())
                {
                    string mapel_guru = myReader.GetString("mata_pelajaran") + "\n(" + myReader.GetString("nama_guru") + ")";
                    var cell1 = new PdfPCell(new Phrase(new Chunk(i.ToString(), TN10)));
                    cell1.HorizontalAlignment = Element.ALIGN_CENTER; cell1.VerticalAlignment = Element.ALIGN_MIDDLE;
                    var cell2 = new PdfPCell(new Phrase(new Chunk(mapel_guru, TN10)));
                    cell2.HorizontalAlignment = Element.ALIGN_LEFT;
                    var cell3 = new PdfPCell(new Phrase(new Chunk(myReader.GetString("nama_guru"), TN10)));
                    cell3.HorizontalAlignment = Element.ALIGN_LEFT; cell3.VerticalAlignment = Element.ALIGN_MIDDLE;
                    var cell4 = new PdfPCell(new Phrase(new Chunk(myReader.GetString("p_ang"), TN10)));
                    cell4.HorizontalAlignment = Element.ALIGN_CENTER; cell4.VerticalAlignment = Element.ALIGN_MIDDLE;
                    var cell5 = new PdfPCell(new Phrase(new Chunk(myReader.GetString("p_pred"), TN10)));
                    cell5.HorizontalAlignment = Element.ALIGN_CENTER; cell5.VerticalAlignment = Element.ALIGN_MIDDLE;
                    var cell6 = new PdfPCell(new Phrase(new Chunk(myReader.GetString("k_ang"), TN10)));
                    cell6.HorizontalAlignment = Element.ALIGN_CENTER; cell6.VerticalAlignment = Element.ALIGN_MIDDLE;
                    var cell7 = new PdfPCell(new Phrase(new Chunk(myReader.GetString("k_pred"), TN10)));
                    cell7.HorizontalAlignment = Element.ALIGN_CENTER; cell7.VerticalAlignment = Element.ALIGN_MIDDLE;
                    var cell8 = new PdfPCell(new Phrase(new Chunk(myReader.GetString("s_sikap"), TN10)));
                    cell8.HorizontalAlignment = Element.ALIGN_CENTER; cell8.VerticalAlignment = Element.ALIGN_MIDDLE;
                    cell.BorderWidth = 0f; cell.BorderWidthRight = 0.5f;
                    raport_tbl.AddCell(cell1); raport_tbl.AddCell(cell2);
                    raport_tbl.AddCell(cell4); raport_tbl.AddCell(cell5); raport_tbl.AddCell(cell6);
                    raport_tbl.AddCell(cell7); raport_tbl.AddCell(cell8); raport_tbl.AddCell(cell);
                    i++;
                }
                myConn.Close();
                doc.Add(raport_tbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void nilaiLCK_B(Document doc)
        {
            raport_tbl = new PdfPTable(8);
            raport_tbl.TotalWidth = 510f; raport_tbl.LockedWidth = true;
            widths = new float[] { 10f, 185f, 35f, 40f, 35f, 40f, 55f, 80f };
            raport_tbl.SetWidths(widths);

            var cell0 = new PdfPCell(new Phrase(new Chunk("Kelompok B (Wajib)", TB11))); cell0.HorizontalAlignment = Element.ALIGN_LEFT;
            cell0.Colspan = 7;
            cell.BorderWidth = 0f; cell.BorderWidthRight = 0.5f;
            raport_tbl.AddCell(cell0); raport_tbl.AddCell(cell);
            
            myComm = new MySqlCommand(kategoriB, myConn);
            try
            {
                myConn.Open();
                myReader = myComm.ExecuteReader();
                int i = 1;
                while (myReader.Read())
                {
                    string mapel_guru = myReader.GetString("mata_pelajaran") + "\n(" + myReader.GetString("nama_guru") + ")";
                    var cell1 = new PdfPCell(new Phrase(new Chunk(i.ToString(), TN10)));
                    cell1.HorizontalAlignment = Element.ALIGN_CENTER; cell1.VerticalAlignment = Element.ALIGN_MIDDLE;
                    var cell2 = new PdfPCell(new Phrase(new Chunk(mapel_guru, TN10)));
                    cell2.HorizontalAlignment = Element.ALIGN_LEFT;
                    var cell4 = new PdfPCell(new Phrase(new Chunk(myReader.GetString("p_ang"), TN10)));
                    cell4.HorizontalAlignment = Element.ALIGN_CENTER; cell4.VerticalAlignment = Element.ALIGN_MIDDLE;
                    var cell5 = new PdfPCell(new Phrase(new Chunk(myReader.GetString("p_pred"), TN10)));
                    cell5.HorizontalAlignment = Element.ALIGN_CENTER; cell5.VerticalAlignment = Element.ALIGN_MIDDLE;
                    var cell6 = new PdfPCell(new Phrase(new Chunk(myReader.GetString("k_ang"), TN10)));
                    cell6.HorizontalAlignment = Element.ALIGN_CENTER; cell6.VerticalAlignment = Element.ALIGN_MIDDLE;
                    var cell7 = new PdfPCell(new Phrase(new Chunk(myReader.GetString("k_pred"), TN10)));
                    cell7.HorizontalAlignment = Element.ALIGN_CENTER; cell7.VerticalAlignment = Element.ALIGN_MIDDLE;
                    var cell8 = new PdfPCell(new Phrase(new Chunk(myReader.GetString("s_sikap"), TN10)));
                    cell8.HorizontalAlignment = Element.ALIGN_CENTER; cell8.VerticalAlignment = Element.ALIGN_MIDDLE;
                    cell.BorderWidth = 0f; cell.BorderWidthRight = 0.5f;
                    raport_tbl.AddCell(cell1); raport_tbl.AddCell(cell2);
                    raport_tbl.AddCell(cell4); raport_tbl.AddCell(cell5); raport_tbl.AddCell(cell6);
                    raport_tbl.AddCell(cell7); raport_tbl.AddCell(cell8); raport_tbl.AddCell(cell);
                    i++;
                }
                myConn.Close();
                doc.Add(raport_tbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void nilaiLCK_C(Document doc)
        {
            raport_tbl = new PdfPTable(8);
            raport_tbl.TotalWidth = 510f; raport_tbl.LockedWidth = true;
            widths = new float[] { 10f, 185f, 35f, 40f, 35f, 40f, 55f, 80f };
            raport_tbl.SetWidths(widths);

            var cell0 = new PdfPCell(new Phrase(new Chunk("Kelompok C (Pilihan)", TB11))); cell0.HorizontalAlignment = Element.ALIGN_LEFT;
            cell0.Colspan = 7;
            cell.BorderWidthBottom = 0f; cell.BorderWidthLeft = 0f; cell.BorderWidthTop = 0f; cell.BorderWidthRight = 0.5f;
            raport_tbl.AddCell(cell0); raport_tbl.AddCell(cell);
            
            myComm = new MySqlCommand(kategoriC, myConn);
            try
            {
                myConn.Open();
                myReader = myComm.ExecuteReader();
                int i = 1;
                while (myReader.Read())
                {
                    string mapel_guru = myReader.GetString("mata_pelajaran") + "\n(" + myReader.GetString("nama_guru") + ")";
                    var cell1 = new PdfPCell(new Phrase(new Chunk(i.ToString(), TN10)));
                    cell1.HorizontalAlignment = Element.ALIGN_CENTER;
                    var cell2 = new PdfPCell(new Phrase(new Chunk(mapel_guru, TN10)));
                    cell2.HorizontalAlignment = Element.ALIGN_LEFT;
                    var cell4 = new PdfPCell(new Phrase(new Chunk(myReader.GetString("p_ang"), TN10)));
                    cell4.VerticalAlignment = Element.ALIGN_MIDDLE; cell4.HorizontalAlignment = Element.ALIGN_CENTER;
                    var cell5 = new PdfPCell(new Phrase(new Chunk(myReader.GetString("p_pred"), TN10)));
                    cell5.VerticalAlignment = Element.ALIGN_MIDDLE; cell5.HorizontalAlignment = Element.ALIGN_CENTER;
                    var cell6 = new PdfPCell(new Phrase(new Chunk(myReader.GetString("k_ang"), TN10)));
                    cell6.VerticalAlignment = Element.ALIGN_MIDDLE; cell6.HorizontalAlignment = Element.ALIGN_CENTER;
                    var cell7 = new PdfPCell(new Phrase(new Chunk(myReader.GetString("k_pred"), TN10)));
                    cell7.VerticalAlignment = Element.ALIGN_MIDDLE; cell7.HorizontalAlignment = Element.ALIGN_CENTER;
                    var cell8 = new PdfPCell(new Phrase(new Chunk(myReader.GetString("s_sikap"), TN10)));
                    cell8.VerticalAlignment = Element.ALIGN_MIDDLE; cell8.HorizontalAlignment = Element.ALIGN_CENTER;
                    cell.BorderWidth = 0f; cell.BorderWidthRight = 0.5f;
                    raport_tbl.AddCell(cell1); raport_tbl.AddCell(cell2);
                    raport_tbl.AddCell(cell4); raport_tbl.AddCell(cell5); raport_tbl.AddCell(cell6);
                    raport_tbl.AddCell(cell7); raport_tbl.AddCell(cell8); raport_tbl.AddCell(cell);
                    i++;
                }
                myConn.Close();
                cell.BorderWidth = 0f; cell.BorderWidthTop = 0.5f;
                raport_tbl.AddCell(""); raport_tbl.AddCell(""); raport_tbl.AddCell(""); raport_tbl.AddCell("");
                raport_tbl.AddCell(""); raport_tbl.AddCell(""); raport_tbl.AddCell(""); raport_tbl.AddCell(cell);
                doc.Add(raport_tbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    
        public void ekskul_siswa(Document doc)
        {
            raport_tbl = new PdfPTable(3);
            raport_tbl.TotalWidth = 510f; raport_tbl.LockedWidth = true;
            widths = new float[] { 10f, 250f, 250f };
            raport_tbl.SetWidths(widths);

            var cell1 = new PdfPCell(new Phrase(new Chunk("Ekstra Kurikuler", TB11)));
            var cell2 = new PdfPCell(new Phrase(new Chunk("Keikutsertaan dalam kegiatan", TB11))); 
            var cell3 = new PdfPCell(new Phrase(new Chunk("\n", TN8))); 
            cell1.HorizontalAlignment = Element.ALIGN_LEFT; cell1.Colspan = 2;
            cell2.HorizontalAlignment = Element.ALIGN_LEFT; cell3.HorizontalAlignment = Element.ALIGN_LEFT; 
            cell3.BorderWidth = 0f; cell3.Colspan = 3;

            raport_tbl.AddCell(cell3);
            raport_tbl.AddCell(cell1); raport_tbl.AddCell(cell2);
            raport_tbl.AddCell("1"); raport_tbl.AddCell(""); raport_tbl.AddCell("");
            raport_tbl.AddCell("2"); raport_tbl.AddCell(""); raport_tbl.AddCell("");
            raport_tbl.AddCell("3"); raport_tbl.AddCell(""); raport_tbl.AddCell("");

            doc.Add(raport_tbl);
        }

        public void absensi_siswa(Document doc)
        {
            raport_tbl = new PdfPTable(4);
            raport_tbl.TotalWidth = 510f; raport_tbl.LockedWidth = true;
            raport_tbl.DefaultCell.Border = Rectangle.NO_BORDER;
            widths = new float[] { 65f, 65f, 120f, 260f };
            raport_tbl.SetWidths(widths);

            var cell1 = new PdfPCell(new Phrase(new Chunk("Ketidakhadiran", TB11)));
            cell1.HorizontalAlignment = Element.ALIGN_LEFT; cell1.Colspan = 3;
            var cell3 = new PdfPCell(new Phrase(new Chunk("Sakit :     Hari", TN10)));
            var cell4 = new PdfPCell(new Phrase(new Chunk("Izin  :     Hari", TN10))); 
            var cell5 = new PdfPCell(new Phrase(new Chunk("Tanpa Keterangan  :     Hari", TN10)));
            var cell6 = new PdfPCell(new Phrase(new Chunk("\n", TN8)));
            cell6.BorderWidth = 0f; cell6.Colspan = 4;
            
            cell3.HorizontalAlignment = Element.ALIGN_LEFT; cell4.HorizontalAlignment = Element.ALIGN_LEFT;
            cell5.HorizontalAlignment = Element.ALIGN_LEFT; cell6.HorizontalAlignment = Element.ALIGN_LEFT;
            cell.BorderWidthBottom = 0f; cell.BorderWidthTop = 0f; cell.BorderWidthLeft = 0f; cell.BorderWidthRight = 0f;

            raport_tbl.AddCell(cell6); 
            raport_tbl.AddCell(cell1); raport_tbl.AddCell(cell);
            raport_tbl.AddCell(cell3); raport_tbl.AddCell(cell4);
            raport_tbl.AddCell(cell5); raport_tbl.AddCell(cell);

            doc.Add(raport_tbl);
        }

        public void walikelas_ortu(Document doc)
        {
            raport_tbl = new PdfPTable(4);
            raport_tbl.TotalWidth = 510f; raport_tbl.LockedWidth = true;
            raport_tbl.DefaultCell.Border = Rectangle.NO_BORDER;
            widths = new float[] { 10f, 150f, 125f, 225f };
            raport_tbl.SetWidths(widths);

            string bulan = month[DateTime.Today.Month - 1] + " " + DateTime.Today.Year.ToString();
            var cell1 = new PdfPCell(new Phrase(new Chunk("Mengetahui: \nOrang Tua/Wali", TN11)));
            cell1.HorizontalAlignment = Element.ALIGN_LEFT; cell1.BorderWidth = 0f;
            var cell3 = new PdfPCell(new Phrase(new Chunk("\n\n\n", TN10)));
            cell3.HorizontalAlignment = Element.ALIGN_LEFT; cell3.BorderWidth = 0f;
            var cell4 = new PdfPCell(new Phrase(new Chunk("....................................", TN11)));
            cell4.HorizontalAlignment = Element.ALIGN_LEFT; cell4.BorderWidth = 0f;
            var cell5 = new PdfPCell(new Phrase(new Chunk("Jampangkulon, " + tanggal + " " + bulan + "\nWali Kelas,", TN11)));
            cell5.HorizontalAlignment = Element.ALIGN_LEFT; cell5.BorderWidth = 0f;

            myComm = new MySqlCommand(wali_kelas, myConn);
            try
            {
                myConn.Open();
                myReader = myComm.ExecuteReader();
                while (myReader.Read())
                {
                    nama_guru = myReader.GetString("nama_guru");
                    nip_guru = myReader.GetString("nip");
                }
                myConn.Close();
            }
            catch
            {

            }

            var cell6 = new PdfPCell(new Phrase(new Chunk(nama_guru, TN11)));
            cell6.HorizontalAlignment = Element.ALIGN_LEFT; cell6.BorderWidth = 0f;
            var cell7 = new PdfPCell(new Phrase(new Chunk(nip_guru, TN11)));
            cell7.HorizontalAlignment = Element.ALIGN_LEFT; cell7.BorderWidth = 0f;
            var cell8 = new PdfPCell(new Phrase(new Chunk("\n", TN8)));
            cell8.Colspan = 4; cell8.BorderWidth = 0f;

            raport_tbl.AddCell(cell8);
            raport_tbl.AddCell(""); raport_tbl.AddCell(cell1); raport_tbl.AddCell(""); raport_tbl.AddCell(cell5);
            raport_tbl.AddCell(""); raport_tbl.AddCell(cell3); raport_tbl.AddCell(""); raport_tbl.AddCell(cell3);
            raport_tbl.AddCell(""); raport_tbl.AddCell(cell4); raport_tbl.AddCell(""); raport_tbl.AddCell(cell6);
            raport_tbl.AddCell(""); raport_tbl.AddCell(""); raport_tbl.AddCell(""); raport_tbl.AddCell(cell7);

            doc.Add(raport_tbl);
        }

        //END CLASS
    }
}
