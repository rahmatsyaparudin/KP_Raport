using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
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
        DataTable dt;
        Font TB12 = FontFactory.GetFont(FontFactory.TIMES_BOLD, 12);
        Font TB11 = FontFactory.GetFont(FontFactory.TIMES_BOLD, 11);
        Font TB10 = FontFactory.GetFont(FontFactory.TIMES_BOLD, 10);
        Font TB14 = FontFactory.GetFont(FontFactory.TIMES_BOLD, 14);
        Font TN12 = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 12);
        Font TN11 = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 11);
        Font TN10 = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10);
        Font TN9 = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 9);
        Font TN8 = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 8);
        Font AN12 = FontFactory.GetFont("Arial Black", 12, Font.NORMAL, BaseColor.BLACK);
        PdfPTable raport_tbl;
        PdfPCell cell = new PdfPCell();
        
        public string nama_siswa, nisn_siswa, kelas_siswa, nis_siswa;
        public string nama_sekolah, alamat_sekolah;
        public string nama_guru, nip_guru;
        public string nama_bulan;
        public string getTahun, query, path, filename;
        public string valueA, valueB, valueC;
        public string field, table, cond;
        public string setNisSiswa, setKodeKelas, setKode, setSemeter, getFormat, getValue;
        float[] widths;
        string[] month = { "Januari", "Februari", "Maret", "April", "Mei", "Juni", "Juli", "Agustus", "September",
                           "Oktober", "November", "Desember" };
        string tanggal = DateTime.Today.Day.ToString();

        //public string passKodeKelas
        //{
        //    get { return setKodeKelas; }
        //    set { setKodeKelas = value; }
        //}

        //public string passNisSiswa
        //{
        //    get { return setNisSiswa; }
        //    set { setNisSiswa = value; }
        //}

        public string passKode
        {
            get { return setKode; }
            set { setKode = value; }
        }

        public string passSemester
        {
            get { return setSemeter; }
            set { setSemeter = value; }
        }

        public string passTahun
        {
            get { return getTahun; }
            set { getTahun = value; }
        }
        
        public string passValue
        {
            get { return getValue; }
            set { getValue = value; }
        }

        public string printFormat
        {
            get { return getFormat; }
            set { getFormat = value; }
        }

        public DataTable saveToPDF(string getKode)
        {
            table = "detailkelassiswa INNER JOIN kelas USING (kode_kelas) JOIN siswa USING (nis_siswa)";
            field = "nis_siswa, nama_siswa, nisn_siswa, kode_kelas";
            cond = "kode_kelas = '" + getKode + "'";
            dt = db.GetDataTable(field, table, cond);
            return dt;
        }

        public DataTable profil_sekolah()
        {
            table = "profil_sekolah";
            field = "nama_sekolah, npsn, nss, alamat_sekolah, kode_pos, " +
                    "no_telp, kelurahan, kecamatan, kota, provinsi, website, email";
            cond = "nss != ''";
            dt = db.GetDataTable(field, table, cond);
            return dt;
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
        
        //Versi per-Kelas
        public void RaportKelasToPDF()
        {
            killPDFProcess();
            try
            {
                Stopwatch sw = Stopwatch.StartNew();
                string appRootDir = new DirectoryInfo(Environment.CurrentDirectory).FullName;
                if (getValue == "PrintRaport")
                {
                    path = "Temp\\Print";
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    filename = db.randomFile() + db.randomFile() + ".pdf";
                    printFormat = appRootDir + "\\" + path + "\\" + filename;
                }
                else if (getValue == "SaveAsRaport")
                {
                    query = "Select nama_kelas from kelas where kode_kelas = '" + setKode + "'";
                    myConn.Open();
                    myComm = new MySqlCommand(query, myConn);
                    myReader = myComm.ExecuteReader();
                    while (myReader.Read())
                    {
                        kelas_siswa = myReader.GetString("nama_kelas");
                    }
                    myConn.Close();

                    path = "Temp\\Data Nilai";
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    filename = "Nilai Siswa " + kelas_siswa + " (" + setSemeter + "-" + getTahun.Replace("/", "-") + ").pdf";
                }
                
                using (FileStream fstream = new FileStream(appRootDir + "\\" + path + "\\" + filename, FileMode.Create, FileAccess.Write, FileShare.None))
                using (Document doc = new Document(PageSize.A4, 20, 20, 10, 20))
                using (PdfWriter writer = PdfWriter.GetInstance(doc, fstream))
                {
                    writer.SetEncryption(PdfWriter.STRENGTH40BITS, null, null, PdfWriter.ALLOW_COPY);
                    System.Drawing.Image image = Properties.Resources.LogoPendidikan;
                    iTextSharp.text.Image pic = iTextSharp.text.Image.GetInstance(image, System.Drawing.Imaging.ImageFormat.Png);
                    pic.ScalePercent(13.0f);
                    pic.Alignment = Element.ALIGN_CENTER;

                    var paragraf = new Paragraph("\n\n");
                    var paragraf0 = new Paragraph("\n\n\n");
                    var paragraf1 = new Paragraph(new Chunk("LAPORAN \nCAPAIAN KOMPETENSI PESERTA DIDIK" +
                                                        "\nSEKOLAH MENENGAH ATAS \n(SMA)", TB14)); paragraf1.Alignment = Element.ALIGN_CENTER;
                    var paragraf2 = new Paragraph(new Chunk("Nama Peserta Didik", TB12)); paragraf2.Alignment = Element.ALIGN_CENTER;
                    var paragraf4 = new Paragraph(new Chunk("NISN:", TB12)); paragraf4.Alignment = Element.ALIGN_CENTER;
                    var paragraf6 = new Paragraph(new Chunk("KEMENTERIAN PENDIDIKAN DAN KEBUDAYAAN \nREPUBLIK INDONESIA", TB14));
                    paragraf6.Alignment = Element.ALIGN_CENTER;
                    var paragraf7 = new Paragraph(new Chunk("KETERANGAN TENTANG DIRI PESERTA DIDIK", TB14)); paragraf7.Alignment = Element.ALIGN_CENTER;
                    var paragraf8 = new Paragraph("\n");

                    //Jilid
                    doc.Open();
                    foreach (DataRow row in saveToPDF(setKode).Rows)
                    {
                        var paragraf3 = new Paragraph(new Chunk(row["nama_siswa"].ToString(), TN12)); paragraf3.Alignment = Element.ALIGN_CENTER;
                        var paragraf5 = new Paragraph(new Chunk(row["nisn_siswa"].ToString(), TN12)); paragraf5.Alignment = Element.ALIGN_CENTER;

                        setKodeKelas = row["kode_kelas"].ToString();
                        setNisSiswa = row["nis_siswa"].ToString();

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
                        DataSiswa(doc, setNisSiswa);
                        KepalaSekolah(doc);
                        //LCK
                        doc.NewPage();
                        detailLCKSiswa(doc, setNisSiswa, setKodeKelas, setSemeter); kriteriaLCK(doc);
                        nilaiLCK(doc, setNisSiswa, setKodeKelas, "Kelompok A (Wajib)", "Kelompok A");
                        nilaiLCK(doc, setNisSiswa, setKodeKelas, "Kelompok B (Wajib)", "Kelompok B");
                        nilaiLCK(doc, setNisSiswa, setKodeKelas, "Kelompok C (Pilihan)", "Kelompok C");
                        nilai_LCKAdd(doc); ekskul_siswa(doc); absensi_siswa(doc);
                        walikelas_ortu(doc, setKodeKelas);
                        //Deskripsi
                        doc.NewPage();
                        detailLCKSiswa(doc, setNisSiswa, setKodeKelas, setSemeter); kriteria_desk(doc);
                        deskripsiLCK(doc, setKodeKelas, setNisSiswa, "Kelompok A", "Kelompok A (Wajib)");
                        deskripsiLCK(doc, setKodeKelas, setNisSiswa, "Kelompok B", "Kelompok B (Wajib)");
                        deskripsiLCK(doc, setKodeKelas, setNisSiswa, "Kelompok C", "Kelompok C (Pilihan)");
                        walikelas_ortu(doc, setKodeKelas);

                    }
                    //Close Document
                    doc.Close();
                    writer.Close();
                    fstream.Close();
                }
                MessageBox.Show("Selesai dalam: " + Convert.ToInt16(sw.Elapsed.TotalSeconds) + " detik");
            }
            catch (DocumentException de)
            {
                MessageBox.Show(de.Message);
            }
            catch (IOException ioe)
            {
                MessageBox.Show(ioe.Message);
            }
            catch (MySqlException myex)
            {
                switch (myex.Number)
                {
                    case 0: MessageBox.Show("Tidak bisa terkkoneksi ke Server."); break;
                    case 1042: MessageBox.Show("Koneksi ke Database atau Server tidak ditemukan."); break;
                    case 1045: MessageBox.Show("username/password salah."); break;
                    default: MessageBox.Show("Terjadi kesalahan data atau duplikasi data."); break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

   //     //Versi per-Siswa
   //     public void RaportSiswaToPDF()
   //     {
   //         killPDFProcess();
   //         try
   //         {
   //             foreach (DataRow row in siswa_kelas().Rows)
   //             {
   //                 nama_siswa = row["nama_siswa"].ToString();
   //                 kelas_siswa = row["nama_kelas"].ToString();
   //                 nisn_siswa = row["nisn_siswa"].ToString();
   //                 nis_siswa = row["nisn_siswa"].ToString();
   //             }

   //             string path = "Temp\\Data Nilai";
   //             if (!Directory.Exists(path))
   //             {
   //                 Directory.CreateDirectory(path);
   //             }

   //             string filename = nama_siswa + "-" + setNisSiswa + " (" + kelas_siswa + "-" + setSemeter + ").pdf";
   //             string appRootDir = new DirectoryInfo(Environment.CurrentDirectory).FullName;
   //             using (FileStream fstream = new FileStream(appRootDir + "\\" + path +"\\" + filename, FileMode.Create, FileAccess.Write, FileShare.None))
   //             using (Document doc = new Document(PageSize.A4, 20, 20, 10, 20))
   //             using (PdfWriter writer = PdfWriter.GetInstance(doc, fstream))
   //             {
   //                 writer.SetEncryption(PdfWriter.STRENGTH40BITS, null, null, PdfWriter.ALLOW_COPY);
   //                 System.Drawing.Image image = Properties.Resources.LogoPendidikan;
   //                 iTextSharp.text.Image pic = iTextSharp.text.Image.GetInstance(image, System.Drawing.Imaging.ImageFormat.Png);
   //                 pic.ScalePercent(13.0f);
   //                 pic.Alignment = Element.ALIGN_CENTER;

   //                 var paragraf = new Paragraph("\n\n");
   //                 var paragraf0 = new Paragraph("\n\n\n");
   //                 var paragraf1 = new Paragraph(new Chunk("LAPORAN \nCAPAIAN KOMPETENSI PESERTA DIDIK" +
   //                                                     "\nSEKOLAH MENENGAH ATAS \n(SMA)", TB14)); paragraf1.Alignment = Element.ALIGN_CENTER;
   //                 var paragraf2 = new Paragraph(new Chunk("Nama Peserta Didik", TB12)); paragraf2.Alignment = Element.ALIGN_CENTER;
   //                 var paragraf3 = new Paragraph(new Chunk(nama_siswa, TN12)); paragraf3.Alignment = Element.ALIGN_CENTER;
   //                 var paragraf4 = new Paragraph(new Chunk("NISN:", TB12)); paragraf4.Alignment = Element.ALIGN_CENTER;
   //                 var paragraf5 = new Paragraph(new Chunk(nisn_siswa, TN12)); paragraf5.Alignment = Element.ALIGN_CENTER;
   //                 var paragraf6 = new Paragraph(new Chunk("KEMENTERIAN PENDIDIKAN DAN KEBUDAYAAN \nREPUBLIK INDONESIA", TB14));
   //                 paragraf6.Alignment = Element.ALIGN_CENTER;
   //                 var paragraf7 = new Paragraph(new Chunk("KETERANGAN TENTANG DIRI PESERTA DIDIK", TB14)); paragraf7.Alignment = Element.ALIGN_CENTER;
   //                 var paragraf8 = new Paragraph("\n");

   //                 //Jilid
   //                 doc.Open();
   //                 doc.NewPage();
   //                 doc.Add(paragraf0); doc.Add(pic);
   //                 doc.Add(paragraf0); doc.Add(paragraf1);
   //                 doc.Add(paragraf0); doc.Add(paragraf0);
   //                 doc.Add(paragraf); doc.Add(paragraf2);
   //                 doc.Add(paragraf3); doc.Add(paragraf);
   //                 doc.Add(paragraf4); doc.Add(paragraf5);
   //                 doc.Add(paragraf0); doc.Add(paragraf6);
   //                 //Profil Sekolah
   //                 doc.NewPage();
   //                 doc.Add(paragraf1); doc.Add(paragraf0);
   //                 ProfilSekolah(doc);
   //                 //Data Diri siswa
   //                 doc.NewPage();
   //                 doc.Add(paragraf7); doc.Add(paragraf8);
   //                 DataSiswa(doc);
   //                 KepalaSekolah(doc);
   //                 //LCK
   //                 doc.NewPage();
   //                 detailLCKSiswa(doc); kriteriaLCK(doc);
   //                 nilaiLCK(doc, "Kelompok A (Wajib)", "Kelompok A");
   //                 nilaiLCK(doc, "Kelompok B (Wajib)", "Kelompok B");
   //                 nilaiLCK(doc, "Kelompok C (Pilihan)", "Kelompok C");
   //                 nilai_LCKAdd(doc); ekskul_siswa(doc); absensi_siswa(doc);
   //                 walikelas_ortu(doc);
   //                 //Deskripsi
   //                 doc.NewPage();
   //                 detailLCKSiswa(doc); kriteria_desk(doc);
   //                 deskripsiLCK(doc, "Kelompok A", "Kelompok A (Wajib)");
   //                 deskripsiLCK(doc, "Kelompok B", "Kelompok B (Wajib)");
   //                 deskripsiLCK(doc, "Kelompok C", "Kelompok C (Pilihan)");
   //                 walikelas_ortu(doc);
   //                 //Close Document
   //                 doc.Close();
   //                 writer.Close();
   //                 fstream.Close();
   //             }
   //         }
			//catch (DocumentException de)
			//{
   //             MessageBox.Show(de.Message);
   //         }
			//catch (IOException ioe)
			//{
   //             MessageBox.Show(ioe.Message);
			//}
   //         catch (MySqlException myex)
   //         {
   //             switch (myex.Number)
   //             {
   //                 case 0: MessageBox.Show("Tidak bisa terkkoneksi ke Server."); break;
   //                 case 1042: MessageBox.Show("Koneksi ke Database atau Server tidak ditemukan."); break;
   //                 case 1045: MessageBox.Show("username/password salah."); break;
   //                 default: MessageBox.Show("Terjadi kesalahan data atau duplikasi data."); break;
   //             }
   //         }
   //         catch (Exception ex)
   //         {
   //             MessageBox.Show(ex.Message);
   //         }
   //     }

        public void ProfilSekolah(Document doc)
        {
            raport_tbl = new PdfPTable(3);
            raport_tbl.TotalWidth = 500f; raport_tbl.LockedWidth = true;
            raport_tbl.DefaultCell.Border = Rectangle.NO_BORDER;
            widths = new float[] { 200f, 30f, 770f };
            raport_tbl.SetWidths(widths);

            foreach (DataRow row in profil_sekolah().Rows)
            {
                cell.Colspan = 2; cell.Border = Rectangle.NO_BORDER;
                raport_tbl.AddCell("Nama Sekolah"); raport_tbl.AddCell(":"); raport_tbl.AddCell(row["nama_sekolah"].ToString());
                raport_tbl.AddCell("\n"); raport_tbl.AddCell(cell);
                raport_tbl.AddCell("NPSN/NSS"); raport_tbl.AddCell(":"); raport_tbl.AddCell(row["npsn"].ToString() + " / " + row["nss"].ToString());
                raport_tbl.AddCell("\n"); raport_tbl.AddCell(cell);
                raport_tbl.AddCell("Alamat Sekolah"); raport_tbl.AddCell(":"); raport_tbl.AddCell(row["alamat_sekolah"].ToString());
                raport_tbl.AddCell("\n"); raport_tbl.AddCell(cell); raport_tbl.AddCell("\n\n\n"); raport_tbl.AddCell("");
                raport_tbl.AddCell("Kode Pos " + row["kode_pos"].ToString() + " Telp. " + row["no_telp"].ToString());
                raport_tbl.AddCell("\n"); raport_tbl.AddCell(cell);
                raport_tbl.AddCell("Kelurahan"); raport_tbl.AddCell(":"); raport_tbl.AddCell(row["kelurahan"].ToString());
                raport_tbl.AddCell("\n"); raport_tbl.AddCell(cell);
                raport_tbl.AddCell("Kecamatan"); raport_tbl.AddCell(":"); raport_tbl.AddCell(row["kecamatan"].ToString());
                raport_tbl.AddCell("\n"); raport_tbl.AddCell(cell);
                raport_tbl.AddCell("Kabupaten/Kota"); raport_tbl.AddCell(":"); raport_tbl.AddCell(row["kota"].ToString());
                raport_tbl.AddCell("\n"); raport_tbl.AddCell(cell);
                raport_tbl.AddCell("Provinsi"); raport_tbl.AddCell(":"); raport_tbl.AddCell(row["provinsi"].ToString());
                raport_tbl.AddCell("\n"); raport_tbl.AddCell(cell);
                raport_tbl.AddCell("Website"); raport_tbl.AddCell(":"); raport_tbl.AddCell(row["website"].ToString());
                raport_tbl.AddCell("\n"); raport_tbl.AddCell(cell);
                raport_tbl.AddCell("Email"); raport_tbl.AddCell(":"); raport_tbl.AddCell(row["email"].ToString());
            }
            doc.Add(raport_tbl);
        }

        public void DataSiswa(Document doc, string getNisSiswa)
        {
            raport_tbl = new PdfPTable(4);
            raport_tbl.TotalWidth = 500f; raport_tbl.LockedWidth = true;
            raport_tbl.DefaultCell.Border = Rectangle.NO_BORDER;
            widths = new float[] { 50f, 350f, 30f, 600f };
            raport_tbl.SetWidths(widths);

            field = "siswa.nis_siswa as 'NIS', nisn_siswa as 'NISN', nama_siswa as 'Nama Siswa', tempat_lahir as " +
                    "'Tempat Lahir', tanggal_lahir as 'Tanggal Lahir', jenis_kelamin as 'Jenis Kelamin', kelas.nama_kelas " +
                    "as 'Diterima di Kelas', status_keluarga as 'Status Anak', anak_ke as 'Anak Ke-', agama as 'Agama', " +
                    "siswa.no_telp as 'No. Telp. Siswa', alamat as 'Alamat Siswa', asal_sekolah as 'Asal Sekolah', " +
                    "tanggal_masuk as 'Diterima Tanggal', nama_ayah as 'Nama Ayah', nama_ibu as 'Nama Ibu', " +
                    "pekerjaan_ayah as 'Pekerjaan Ayah', pekerjaan_ibu as 'Pekerjaan Ibu', orangtua.no_telp as " +
                    "'No. Telp. Ortu', alamat_ortu as 'Alamat Ortu', nama_wali as 'Nama Wali', pekerjaan_wali as " +
                    "'Pekerjaan Wali', alamat_wali as 'Alamat Wali'";
            table = "siswa INNER JOIN detailkelassiswa ON siswa.nis_siswa = detailkelassiswa.nis_siswa INNER JOIN orangtua " +
                    "ON siswa.nis_siswa = orangtua.nis_siswa INNER JOIN kelas ON detailkelassiswa.kode_kelas = kelas.kode_kelas";
            cond = "siswa.nis_siswa = '" + getNisSiswa + "' AND keterangan = 'Data Siswa'";
            dt = db.GetDataTable(field, table, cond);

            foreach (DataRow row in dt.Rows)
            {
                string diterima = row["Diterima Tanggal"].ToString(); string tanggal_diterima = diterima.Substring(0, 2);
                string bulan_diterima = diterima.Substring(3, 2); string tahun_diterima = diterima.Substring(6, 4);
                string diterima_bulan = getBulan(bulan_diterima);
                string lahir = row["Tanggal Lahir"].ToString(); string tanggal_lahir = lahir.Substring(0, 2);
                string bulan_lahir = lahir.Substring(3, 2); string tahun_lahir = lahir.Substring(6, 4);
                string lahir_bulan = getBulan(bulan_lahir);

                raport_tbl.AddCell("1"); raport_tbl.AddCell("Nama Peserta Didik Lengkap"); raport_tbl.AddCell(":"); raport_tbl.AddCell(row["Nama Siswa"].ToString());
                raport_tbl.AddCell("2"); raport_tbl.AddCell("Nomor Induk Siswa Nasional"); raport_tbl.AddCell(":"); raport_tbl.AddCell(row["NISN"].ToString());
                raport_tbl.AddCell("3"); raport_tbl.AddCell("Tempat Tanggal Lahir"); raport_tbl.AddCell(":"); raport_tbl.AddCell(row["Tempat Lahir"].ToString() + ", " + tanggal_lahir + " " + lahir_bulan + " " + tahun_lahir);
                raport_tbl.AddCell("4"); raport_tbl.AddCell("Jenis Kelamin"); raport_tbl.AddCell(":"); raport_tbl.AddCell(row["Jenis Kelamin"].ToString());
                raport_tbl.AddCell("5"); raport_tbl.AddCell("Agama"); raport_tbl.AddCell(":"); raport_tbl.AddCell(row["Agama"].ToString());
                raport_tbl.AddCell("6"); raport_tbl.AddCell("Status dalam Keluarga"); raport_tbl.AddCell(":"); raport_tbl.AddCell(row["Status Anak"].ToString());
                raport_tbl.AddCell("7"); raport_tbl.AddCell("Anak Ke-"); raport_tbl.AddCell(":"); raport_tbl.AddCell(row["Anak Ke-"].ToString());
                raport_tbl.AddCell("8"); raport_tbl.AddCell("Alamat Peserta Didik"); raport_tbl.AddCell(":"); raport_tbl.AddCell(row["Alamat Siswa"].ToString());
                raport_tbl.AddCell("\n"); raport_tbl.AddCell(""); raport_tbl.AddCell(""); raport_tbl.AddCell("");
                raport_tbl.AddCell("9"); raport_tbl.AddCell("Nomor Telepon Rumah"); raport_tbl.AddCell(":"); raport_tbl.AddCell(row["No. Telp. Siswa"].ToString());
                raport_tbl.AddCell("10"); raport_tbl.AddCell("Sekolah Asal"); raport_tbl.AddCell(":"); raport_tbl.AddCell(row["Asal Sekolah"].ToString());
                raport_tbl.AddCell("11"); raport_tbl.AddCell("Diterima di Sekolah ini"); raport_tbl.AddCell(""); raport_tbl.AddCell("");
                raport_tbl.AddCell(""); raport_tbl.AddCell("a. Di Kelas"); raport_tbl.AddCell(":"); raport_tbl.AddCell(row["Diterima di Kelas"].ToString());
                raport_tbl.AddCell(""); raport_tbl.AddCell("b. Pada Tanggal"); raport_tbl.AddCell(":"); raport_tbl.AddCell(tanggal_diterima + " " + diterima_bulan + " " + tahun_diterima);
                raport_tbl.AddCell("12"); raport_tbl.AddCell("Nama Orang Tua"); raport_tbl.AddCell(""); raport_tbl.AddCell("");
                raport_tbl.AddCell(""); raport_tbl.AddCell("a. Ayah"); raport_tbl.AddCell(":"); raport_tbl.AddCell(row["Nama Ayah"].ToString());
                raport_tbl.AddCell(""); raport_tbl.AddCell("b. Ibu"); raport_tbl.AddCell(":"); raport_tbl.AddCell(row["Nama Ibu"].ToString());
                raport_tbl.AddCell("13"); raport_tbl.AddCell("Alamat Orang Tua"); raport_tbl.AddCell(":"); raport_tbl.AddCell(row["Alamat Ortu"].ToString());
                raport_tbl.AddCell(""); raport_tbl.AddCell("Nomor Telepon Rumah"); raport_tbl.AddCell(":"); raport_tbl.AddCell(row["No. Telp. Ortu"].ToString());
                raport_tbl.AddCell("14"); raport_tbl.AddCell("Pekerjaan Orang Tua"); raport_tbl.AddCell(""); raport_tbl.AddCell("");
                raport_tbl.AddCell(""); raport_tbl.AddCell("a. Pekerjaan Ayah"); raport_tbl.AddCell(":"); raport_tbl.AddCell(row["Pekerjaan Ayah"].ToString());
                raport_tbl.AddCell(""); raport_tbl.AddCell("b. Pekerjaan Ibu"); raport_tbl.AddCell(":"); raport_tbl.AddCell(row["Pekerjaan Ibu"].ToString());
                raport_tbl.AddCell("\n"); raport_tbl.AddCell(""); raport_tbl.AddCell(""); raport_tbl.AddCell("");
                raport_tbl.AddCell("15"); raport_tbl.AddCell("Nama Wali Peserta Didik"); raport_tbl.AddCell(":"); raport_tbl.AddCell(row["Nama Wali"].ToString());
                raport_tbl.AddCell("16"); raport_tbl.AddCell("Pekerjaan Wali Peserta Didik"); raport_tbl.AddCell(":"); raport_tbl.AddCell(row["Pekerjaan Wali"].ToString());
                raport_tbl.AddCell("17"); raport_tbl.AddCell("Alamat Wali Peserta Didik"); raport_tbl.AddCell(":"); raport_tbl.AddCell(row["Alamat Wali"].ToString());
                raport_tbl.AddCell("\n"); raport_tbl.AddCell(""); raport_tbl.AddCell(""); raport_tbl.AddCell("");
            }
            doc.Add(raport_tbl);
        }

        public void KepalaSekolah(Document doc)
        {
            raport_tbl = new PdfPTable(3);
            raport_tbl.TotalWidth = 500f; raport_tbl.LockedWidth = true;
            raport_tbl.DefaultCell.Border = Rectangle.NO_BORDER;
            widths = new float[] { 150f, 100f, 250f };
            raport_tbl.SetWidths(widths);

            string kepala_sekolah = "SELECT nama_guru, nip FROM guru WHERE keterangan LIKE 'Kepala Sekolah%'";
            myConn.Open();
            myComm = new MySqlCommand(kepala_sekolah, myConn);
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
        
        public void detailLCKSiswa(Document doc, string getNisSiswa, string getKodeKelas, string getSemester)
        {
            PdfPTable raport_tbl = new PdfPTable(6);
            raport_tbl.TotalWidth = 510f; raport_tbl.LockedWidth = true;
            raport_tbl.DefaultCell.Border = Rectangle.NO_BORDER;
            float[] widths0 = new float[] { 120f, 10f, 205f, 80f, 10f, 85f };
            raport_tbl.SetWidths(widths0);
            
            foreach (DataRow row in profil_sekolah().Rows)
            {
                nama_sekolah = row["nama_sekolah"].ToString();
                alamat_sekolah = row["alamat_sekolah"].ToString();
            }

            field = "nis_siswa, nisn_siswa, nama_siswa, nama_kelas, nama_guru, nip";
            table = "siswa, kelas INNER JOIN guru USING (id_guru)";
            cond = "nis_siswa = '" + getNisSiswa + "' AND kode_kelas = '" + getKodeKelas + "'";
            dt = db.GetDataTable(field, table, cond);

            foreach (DataRow row in dt.Rows)
            {
                kelas_siswa = row["nama_kelas"].ToString();
                nama_siswa = row["nama_siswa"].ToString();
                nis_siswa = row["nis_siswa"].ToString();
            }

            var phrase1 = new Paragraph(new Chunk("Nama Sekolah", TN11));
            var phrase2 = new Paragraph(new Chunk(nama_sekolah, TN11));
            var phrase3 = new Paragraph(new Chunk("Kelas", TN11));
            var phrase4 = new Paragraph(new Chunk(kelas_siswa, TN11));
            raport_tbl.AddCell(phrase1); raport_tbl.AddCell(":"); raport_tbl.AddCell(phrase2);
            raport_tbl.AddCell(phrase3); raport_tbl.AddCell(":"); raport_tbl.AddCell(phrase4);

            var phrase5 = new Paragraph(new Chunk("Alamat Sekolah", TN11));
            var phrase6 = new Paragraph(new Chunk(alamat_sekolah, TN11));
            var phrase7 = new Paragraph(new Chunk("Semester", TN11));
            
            if (getSemester == "SMT1")
            {
                var phrase8 = new Paragraph(new Chunk("1 (Satu)", TN11));
                raport_tbl.AddCell(phrase5); raport_tbl.AddCell(":"); raport_tbl.AddCell(phrase6);
                raport_tbl.AddCell(phrase7); raport_tbl.AddCell(":"); raport_tbl.AddCell(phrase8);
            }
            else if (getSemester == "SMT2")
            {
                var phrase8 = new Paragraph(new Chunk("2 (Dua)", TN11));
                raport_tbl.AddCell(phrase5); raport_tbl.AddCell(":"); raport_tbl.AddCell(phrase6);
                raport_tbl.AddCell(phrase7); raport_tbl.AddCell(":"); raport_tbl.AddCell(phrase8);
            }

            var phrase9 = new Paragraph(new Chunk("Nama Peserta Didik", TN11));
            var phrase10 = new Paragraph(new Chunk(nama_siswa, TN11));
            var phrase11 = new Paragraph(new Chunk("Tahun Ajaran", TN11));
            var phrase12 = new Paragraph(new Chunk(getTahun, TN11));
            raport_tbl.AddCell(phrase9); raport_tbl.AddCell(":"); raport_tbl.AddCell(phrase10);
            raport_tbl.AddCell(phrase11); raport_tbl.AddCell(":"); raport_tbl.AddCell(phrase12);

            var phrase13 = new Paragraph(new Chunk("Nomor Induk/NISN", TN11));
            var phrase14 = new Paragraph(new Chunk(nis_siswa, TN11));
            raport_tbl.AddCell(phrase13); raport_tbl.AddCell(":"); raport_tbl.AddCell(phrase14);
            raport_tbl.AddCell(""); raport_tbl.AddCell(""); raport_tbl.AddCell("");

            doc.Add(raport_tbl);
        }

        public void kriteriaLCK(Document doc)
        {
            raport_tbl = new PdfPTable(8);
            raport_tbl.TotalWidth = 510f; raport_tbl.LockedWidth = true;
            widths = new float[] { 10f, 185f, 35f, 40f, 35f, 40f, 55f, 80f };
            raport_tbl.SetWidths(widths);

            var phrase1 = new PdfPCell(new Phrase(new Chunk("CAPAIAN KOMPETENSI", TB11)));
            phrase1.Colspan = 8; phrase1.HorizontalAlignment = Element.ALIGN_LEFT;
            phrase1.BorderWidth = 0f;
            var cell1 = new PdfPCell(new Phrase(new Chunk("MATA PELAJARAN", TB11))); cell1.Rowspan = 2; cell1.Colspan = 2;
            cell1.HorizontalAlignment = Element.ALIGN_CENTER; cell1.VerticalAlignment = Element.ALIGN_MIDDLE;
            var cell2 = new PdfPCell(new Phrase(new Chunk("Pengetahuan \n(KI-3)", TB11))); cell2.Colspan = 2;
            cell2.HorizontalAlignment = Element.ALIGN_CENTER; cell2.VerticalAlignment = Element.ALIGN_MIDDLE;
            var cell3 = new PdfPCell(new Phrase(new Chunk("Keterampilan \n(KI-4)", TB11))); cell3.Colspan = 2;
            cell3.HorizontalAlignment = Element.ALIGN_CENTER; cell3.VerticalAlignment = Element.ALIGN_MIDDLE;
            var cell4 = new PdfPCell(new Phrase(new Chunk("Sikap Sosial dan Spiritual \n(KI-1 & KI-2)", TB11)));
            cell4.Colspan = 2; cell4.HorizontalAlignment = Element.ALIGN_CENTER; cell4.VerticalAlignment = Element.ALIGN_MIDDLE;
            raport_tbl.AddCell(phrase1);
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

        public void nilaiLCK(Document doc, string getNisSiswa, string getKodeKelas, string kelompok, string kategori)
        {
            raport_tbl = new PdfPTable(8);
            raport_tbl.TotalWidth = 510f; raport_tbl.LockedWidth = true;
            widths = new float[] { 10f, 185f, 35f, 40f, 35f, 40f, 55f, 80f };
            raport_tbl.SetWidths(widths);
            if (kelompok != "Kelompok A (Wajib)")
            {
                var cell0 = new PdfPCell(new Phrase(new Chunk(kelompok, TB11))); cell0.HorizontalAlignment = Element.ALIGN_LEFT;
                cell0.Colspan = 7;
                cell.BorderWidth = 0f; cell.BorderWidthRight = 0.5f;
                raport_tbl.AddCell(cell0); raport_tbl.AddCell(cell);
            }
            
            field = "mata_pelajaran, nama_guru, p_ang, p_pred, k_ang, k_pred, s_sikap";
            table = "nilai INNER JOIN mapel USING (kode_mapel) INNER JOIN detailmapelkelas USING (kode_mapel) " +
                    "INNER JOIN guru USING (id_guru) ";
            cond = "nis_siswa = '" + getNisSiswa + "' AND kode_semester= '" + setSemeter + "' AND nilai.kode_kelas = '" 
                   + getKodeKelas + "' AND detailmapelkelas.kode_kelas = '" + getKodeKelas + "' AND kategori_mapel = '" + kategori + "'";
            dt = db.GetDataTable(field, table, cond);
            int i = 1;
            foreach (DataRow row in dt.Rows)
            {
                string mapel_guru = row["mata_pelajaran"].ToString() + "\n(" + row["nama_guru"].ToString() + ")";
                var cell1 = new PdfPCell(new Phrase(new Chunk(i.ToString(), TN10)));
                cell1.HorizontalAlignment = Element.ALIGN_CENTER; cell1.VerticalAlignment = Element.ALIGN_MIDDLE;
                var cell2 = new PdfPCell(new Phrase(new Chunk(mapel_guru, TN10)));
                cell2.HorizontalAlignment = Element.ALIGN_LEFT;
                var cell4 = new PdfPCell(new Phrase(new Chunk(row["p_ang"].ToString(), TN10)));
                cell4.HorizontalAlignment = Element.ALIGN_CENTER; cell4.VerticalAlignment = Element.ALIGN_MIDDLE;
                var cell5 = new PdfPCell(new Phrase(new Chunk(row["p_pred"].ToString(), TN10)));
                cell5.HorizontalAlignment = Element.ALIGN_CENTER; cell5.VerticalAlignment = Element.ALIGN_MIDDLE;
                var cell6 = new PdfPCell(new Phrase(new Chunk(row["k_ang"].ToString(), TN10)));
                cell6.HorizontalAlignment = Element.ALIGN_CENTER; cell6.VerticalAlignment = Element.ALIGN_MIDDLE;
                var cell7 = new PdfPCell(new Phrase(new Chunk(row["k_pred"].ToString(), TN10)));
                cell7.HorizontalAlignment = Element.ALIGN_CENTER; cell7.VerticalAlignment = Element.ALIGN_MIDDLE;
                var cell8 = new PdfPCell(new Phrase(new Chunk(row["s_sikap"].ToString(), TN10)));
                cell8.HorizontalAlignment = Element.ALIGN_CENTER; cell8.VerticalAlignment = Element.ALIGN_MIDDLE;
                cell.BorderWidth = 0f; cell.BorderWidthRight = 0.5f;
                raport_tbl.AddCell(cell1); raport_tbl.AddCell(cell2);
                raport_tbl.AddCell(cell4); raport_tbl.AddCell(cell5); raport_tbl.AddCell(cell6);
                raport_tbl.AddCell(cell7); raport_tbl.AddCell(cell8); raport_tbl.AddCell(cell);
                i++;
            }
            doc.Add(raport_tbl);
        }
        
        public void nilai_LCKAdd(Document doc)
        {
            raport_tbl = new PdfPTable(8);
            raport_tbl.TotalWidth = 510f; raport_tbl.LockedWidth = true;
            widths = new float[] { 10f, 185f, 35f, 40f, 35f, 40f, 55f, 80f };
            raport_tbl.SetWidths(widths);
            cell.BorderWidth = 0f; cell.BorderWidthTop = 0.5f;
            raport_tbl.AddCell(""); raport_tbl.AddCell(""); raport_tbl.AddCell(""); raport_tbl.AddCell("");
            raport_tbl.AddCell(""); raport_tbl.AddCell(""); raport_tbl.AddCell(""); raport_tbl.AddCell(cell);
            doc.Add(raport_tbl);
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

        public void walikelas_ortu(Document doc, string getKodeKelas)
        {
            raport_tbl = new PdfPTable(4);
            raport_tbl.TotalWidth = 510f; raport_tbl.LockedWidth = true;
            raport_tbl.DefaultCell.Border = Rectangle.NO_BORDER;
            widths = new float[] { 10f, 150f, 125f, 225f };
            raport_tbl.SetWidths(widths);

            string bulan = month[DateTime.Today.Month - 1] + " " + DateTime.Today.Year.ToString();
            var cell1 = new PdfPCell(new Phrase(new Chunk("Mengetahui: \nOrang Tua/Wali", TN10)));
            cell1.HorizontalAlignment = Element.ALIGN_LEFT; cell1.BorderWidth = 0f;
            var cell3 = new PdfPCell(new Phrase(new Chunk("\n\n\n", TN10)));
            cell3.HorizontalAlignment = Element.ALIGN_LEFT; cell3.BorderWidth = 0f;
            var cell4 = new PdfPCell(new Phrase(new Chunk("....................................", TN10)));
            cell4.HorizontalAlignment = Element.ALIGN_LEFT; cell4.BorderWidth = 0f;
            var cell5 = new PdfPCell(new Phrase(new Chunk("Jampangkulon, " + tanggal + " " + bulan + "\nWali Kelas,", TN10)));
            cell5.HorizontalAlignment = Element.ALIGN_LEFT; cell5.BorderWidth = 0f;

            field = "nama_guru, nip";
            table = "kelas INNER JOIN guru USING (id_guru)";
            cond = "kode_kelas = '" + getKodeKelas + "'";
            dt = db.GetDataTable(field, table, cond);

            foreach (DataRow row in dt.Rows)
            {
                nama_guru = row["nama_guru"].ToString();
                nip_guru = row["nip"].ToString();
            }

            var cell6 = new PdfPCell(new Phrase(new Chunk(nama_guru, TN10)));
            cell6.HorizontalAlignment = Element.ALIGN_LEFT; cell6.BorderWidth = 0f;
            var cell7 = new PdfPCell(new Phrase(new Chunk(nip_guru, TN10)));
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

        public void kriteria_desk(Document doc)
        {
            raport_tbl = new PdfPTable(4);
            raport_tbl.TotalWidth = 510f; raport_tbl.LockedWidth = true;
            raport_tbl.DefaultCell.Border = Rectangle.NO_BORDER;
            widths = new float[] { 10f, 125f, 100f, 275f };
            raport_tbl.SetWidths(widths);

            var cell1 = new PdfPCell(new Phrase(new Chunk("MATA PELAJARAN", TB11))); cell1.Colspan = 2;
            cell1.HorizontalAlignment = Element.ALIGN_CENTER; cell1.VerticalAlignment = Element.ALIGN_MIDDLE; 
            var cell2 = new PdfPCell(new Phrase(new Chunk("KOMPETENSI", TB11)));
            cell2.HorizontalAlignment = Element.ALIGN_CENTER; cell2.VerticalAlignment = Element.ALIGN_MIDDLE;
            var cell3 = new PdfPCell(new Phrase(new Chunk("CATATAN", TB11)));
            cell3.HorizontalAlignment = Element.ALIGN_CENTER; cell3.VerticalAlignment = Element.ALIGN_MIDDLE;
            var cell4 = new PdfPCell(new Phrase(new Chunk("DESKRIPSI KOMPETENSI", TB11)));
            cell4.HorizontalAlignment = Element.ALIGN_LEFT; cell4.VerticalAlignment = Element.ALIGN_MIDDLE;
            cell4.BorderWidth = 0f; cell4.Colspan = 4;
            cell.BorderWidth = 0f; cell.Colspan = 3;

            raport_tbl.AddCell(cell4); raport_tbl.AddCell(cell); raport_tbl.AddCell("\n");
            raport_tbl.AddCell(cell1); raport_tbl.AddCell(cell2); raport_tbl.AddCell(cell3);

            doc.Add(raport_tbl);
        }
        
        public void deskripsiLCK(Document doc, string getKodeKelas, string getNisSiswa, string kategori, string kelompok)
        {
            raport_tbl = new PdfPTable(4);
            raport_tbl.TotalWidth = 510f; raport_tbl.LockedWidth = true;
            raport_tbl.DefaultCell.Border = Rectangle.NO_BORDER;
            widths = new float[] { 10f, 125f, 100f, 275f };
            raport_tbl.SetWidths(widths);

            this.field = "nilai.kode_mapel as 'kode', mata_pelajaran, p_desk, k_desk, s_desk ";
            this.table = "nilai INNER JOIN kelas USING (kode_kelas) INNER JOIN mapel USING (kode_mapel) ";
            this.cond = "kode_semester= '" + setSemeter + "' AND nilai.kode_kelas = '" + 
                         getKodeKelas + "' AND kategori_mapel = '" + kategori + "' AND nilai.nis_siswa = '" + getNisSiswa + "'";
            DataTable tabel = db.GetDataTable(field, table, cond);
            
            var cell0 = new PdfPCell(new Phrase(new Chunk(kelompok, TB11))); cell0.Colspan = 4;
            cell0.VerticalAlignment = Element.ALIGN_MIDDLE; cell0.HorizontalAlignment = Element.ALIGN_LEFT;
            raport_tbl.AddCell(cell0);

            int j = 1;
            foreach (DataRow row in tabel.Rows)
            {
                if (Convert.ToString(row["p_desk"]) == "A") valueA = "p_atas";
                else if (Convert.ToString(row["p_desk"]) == "T") valueA = "p_tengah";
                else if (Convert.ToString(row["p_desk"]) == "B") valueA = "p_bawah";
                else if (Convert.ToString(row["p_desk"]) == "") valueA = "p_bawah";

                if (Convert.ToString(row["k_desk"]) == "A") valueB = "k_atas";
                else if (Convert.ToString(row["k_desk"]) == "T") valueB = "k_tengah";
                else if (Convert.ToString(row["k_desk"]) == "B") valueB = "k_bawah";
                else if (Convert.ToString(row["k_desk"]) == "") valueB = "k_bawah";

                if (Convert.ToString(row["s_desk"]) == "A") valueC = "s_atas";
                else if (Convert.ToString(row["s_desk"]) == "T") valueC = "s_tengah";
                else if (Convert.ToString(row["s_desk"]) == "B") valueC = "s_bawah";
                else if (Convert.ToString(row["s_desk"]) == "") valueC = "s_bawah";

                string deskA = "SELECT mata_pelajaran, " + valueA + ", " + valueB + ", " + valueC + " FROM " +
                               "deskripsi INNER JOIN mapel USING (kode_mapel) INNER JOIN kelas USING (kode_kelas) " +
                               "WHERE kode_semester = '" + setSemeter + "' AND kode_kelas = '" + getKodeKelas +
                               "' AND kode_mapel = '" + row["kode"].ToString() + "'";
                myConn.Open();
                myComm = new MySqlCommand(deskA, myConn);
                myReader = myComm.ExecuteReader();
                while (myReader.Read())
                {
                    var cell1 = new PdfPCell(new Phrase(new Chunk(j.ToString(), TN10))); cell1.Rowspan = 3;
                    cell1.VerticalAlignment = Element.ALIGN_MIDDLE; cell1.HorizontalAlignment = Element.ALIGN_CENTER;
                    var cell2 = new PdfPCell(new Phrase(new Chunk(myReader.GetString("mata_pelajaran"), TN10))); cell2.Rowspan = 3;
                    cell2.VerticalAlignment = Element.ALIGN_MIDDLE; cell2.HorizontalAlignment = Element.ALIGN_LEFT;
                    var cell3 = new PdfPCell(new Phrase(new Chunk(myReader.GetString(valueA), TN10)));
                    cell3.HorizontalAlignment = Element.ALIGN_JUSTIFIED;
                    var cell4 = new PdfPCell(new Phrase(new Chunk(myReader.GetString(valueB), TN10)));
                    cell4.HorizontalAlignment = Element.ALIGN_JUSTIFIED;
                    var cell5 = new PdfPCell(new Phrase(new Chunk(myReader.GetString(valueC), TN10)));
                    cell5.HorizontalAlignment = Element.ALIGN_JUSTIFIED;
                    var cell6 = new PdfPCell(new Phrase(new Chunk("Pengetahuan", TN10)));
                    cell6.VerticalAlignment = Element.ALIGN_MIDDLE; cell6.HorizontalAlignment = Element.ALIGN_LEFT;
                    var cell7 = new PdfPCell(new Phrase(new Chunk("Keterampilan", TN10)));
                    cell7.VerticalAlignment = Element.ALIGN_MIDDLE; cell7.HorizontalAlignment = Element.ALIGN_LEFT;
                    var cell8 = new PdfPCell(new Phrase(new Chunk("Sikap Sosial dan Spiritual", TN10)));
                    cell8.VerticalAlignment = Element.ALIGN_MIDDLE; cell8.HorizontalAlignment = Element.ALIGN_LEFT;
                    cell.BorderWidth = 0f; cell.BorderWidthRight = 0.5f;

                    raport_tbl.AddCell(cell1); raport_tbl.AddCell(cell2);
                    raport_tbl.AddCell(cell6); raport_tbl.AddCell(cell3);
                    raport_tbl.AddCell(cell7); raport_tbl.AddCell(cell4);
                    raport_tbl.AddCell(cell8); raport_tbl.AddCell(cell5);
                }
                myConn.Close();
                j++;
            }
            doc.Add(raport_tbl);
        }

        public void FormatNilaiPDF()
        {
            killPDFProcess();
            try
            {
                Stopwatch sw = Stopwatch.StartNew();
                string appRootDir = new DirectoryInfo(Environment.CurrentDirectory).FullName;
                if (getValue == "PrintFormat")
                {
                    path = "Temp\\Print";
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    filename = db.randomFile() + ".pdf";
                    printFormat = appRootDir + "\\" + path + "\\" + filename;
                }
                else if (getValue == "SaveAsFormat")
                {
                    path = "Temp\\SaveAs";
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    filename = "Format penilaian siswa.pdf";
                }
                
                using (FileStream fstream = new FileStream(appRootDir + "\\" + path + "\\" + filename, FileMode.Create, FileAccess.Write, FileShare.None))
                using (Document doc = new Document(PageSize.A4, 20, 20, 10, 20))
                using (PdfWriter writer = PdfWriter.GetInstance(doc, fstream))
                {
                    writer.SetEncryption(PdfWriter.STRENGTH40BITS, null, null, PdfWriter.ALLOW_COPY);
                    var paragraf = new Paragraph(new Chunk("FORMAT PENILAIAN HASIL UJIAN SISWA", TB12));
                    paragraf.Alignment = Element.ALIGN_CENTER;

                    this.field = "kode_kelas as 'Kode', nama_kelas as 'Nama Kelas'";
                    this.table = "kelas";
                    this.cond = "tahun_ajaran = '" + getTahun + "' ORDER by nama_kelas ASC";
                    DataTable tabelKelas = db.GetDataTable(field, table, cond);

                    //Open Document
                    doc.Open();
                    foreach (DataRow row1 in tabelKelas.Rows)
                    {
                        PdfPTable format_tbl = new PdfPTable(7);
                        format_tbl.TotalWidth = 525f; format_tbl.LockedWidth = true;
                        format_tbl.DefaultCell.Border = Rectangle.NO_BORDER;
                        widths = new float[] { 100f, 5f, 100f, 115f, 100f, 5f, 100f };
                        format_tbl.SetWidths(widths);

                        var cella = new PdfPCell(new Phrase(new Chunk("Pengajar", TN10)));
                        cella.HorizontalAlignment = Element.ALIGN_LEFT; cella.BorderWidth = 0f;
                        var cellb = new PdfPCell(new Phrase(new Chunk("Mata Pelajaran", TN10)));
                        cellb.HorizontalAlignment = Element.ALIGN_LEFT; cellb.BorderWidth = 0f;
                        var cellc = new PdfPCell(new Phrase(new Chunk("Kelompok Mapel", TN10)));
                        cellc.HorizontalAlignment = Element.ALIGN_LEFT; cellc.BorderWidth = 0f;
                        var celld = new PdfPCell(new Phrase(new Chunk("Kelas", TN10)));
                        celld.HorizontalAlignment = Element.ALIGN_LEFT; celld.BorderWidth = 0f;
                        var celle = new PdfPCell(new Phrase(new Chunk("Tahun Ajaran", TN10)));
                        celle.HorizontalAlignment = Element.ALIGN_LEFT; celle.BorderWidth = 0f;
                        var cellf = new PdfPCell(new Phrase(new Chunk("Semester", TN10)));
                        cellf.HorizontalAlignment = Element.ALIGN_LEFT; cellf.BorderWidth = 0f;
                        var cellg = new PdfPCell(new Phrase(new Chunk("Satu / Dua", TN10)));
                        cellg.HorizontalAlignment = Element.ALIGN_LEFT; cellg.BorderWidth = 0f;
                        var cellh = new PdfPCell(new Phrase(new Chunk(getTahun, TN10)));
                        cellh.HorizontalAlignment = Element.ALIGN_LEFT; cellh.BorderWidth = 0f;
                        var celli = new PdfPCell(new Phrase(new Chunk("A / B / C", TN10)));
                        celli.HorizontalAlignment = Element.ALIGN_LEFT; celli.BorderWidth = 0f;
                        var cellj = new PdfPCell(new Phrase(new Chunk("\n", TN8))); cellj.Colspan = 7;
                        cellj.HorizontalAlignment = Element.ALIGN_LEFT; cellj.BorderWidth = 0f;
                        var cellk = new PdfPCell(new Phrase(new Chunk(":", TN10)));
                        cellk.HorizontalAlignment = Element.ALIGN_LEFT; cellk.BorderWidth = 0f;
                        var celll = new PdfPCell(new Phrase(new Chunk(row1["Nama Kelas"].ToString(), TN10)));
                        celll.HorizontalAlignment = Element.ALIGN_LEFT; celll.BorderWidth = 0f;

                        format_tbl.AddCell(cellj);
                        format_tbl.AddCell(cella); format_tbl.AddCell(cellk); format_tbl.AddCell("");
                        format_tbl.AddCell(""); format_tbl.AddCell(celld); format_tbl.AddCell(cellk); format_tbl.AddCell(celll);//
                        format_tbl.AddCell(cellb); format_tbl.AddCell(cellk); format_tbl.AddCell("");
                        format_tbl.AddCell(""); format_tbl.AddCell(celle); format_tbl.AddCell(cellk); format_tbl.AddCell(cellh);//
                        format_tbl.AddCell(cellc); format_tbl.AddCell(cellk); format_tbl.AddCell(celli);
                        format_tbl.AddCell(""); format_tbl.AddCell(cellf); format_tbl.AddCell(cellk); format_tbl.AddCell(cellg);//
                        format_tbl.AddCell(cellj);

                        raport_tbl = new PdfPTable(9);
                        raport_tbl.TotalWidth = 525f; raport_tbl.LockedWidth = true;
                        //raport_tbl.DefaultCell.Border = Rectangle.NO_BORDER;
                        widths = new float[] { 20f, 80f, 170f, 35f, 50f, 35f, 50f, 35f, 50f };
                        raport_tbl.SetWidths(widths);

                        var cell2 = new PdfPCell(new Phrase(new Chunk("Pengetahuan", TB10))); cell2.Colspan = 2;
                        cell2.HorizontalAlignment = Element.ALIGN_CENTER; cell2.VerticalAlignment = Element.ALIGN_MIDDLE;
                        var cell3 = new PdfPCell(new Phrase(new Chunk("Keterampilan", TB10))); cell3.Colspan = 2;
                        cell3.HorizontalAlignment = Element.ALIGN_CENTER; cell3.VerticalAlignment = Element.ALIGN_MIDDLE;
                        var cell4 = new PdfPCell(new Phrase(new Chunk("Sikap Sosial dan Spiritual", TB10)));
                        cell4.Colspan = 2; cell4.HorizontalAlignment = Element.ALIGN_CENTER; cell4.VerticalAlignment = Element.ALIGN_MIDDLE;
                        var cell5 = new PdfPCell(new Phrase(new Chunk("Skala\n(0-100)", TN10)));
                        cell5.HorizontalAlignment = Element.ALIGN_CENTER; cell5.VerticalAlignment = Element.ALIGN_BOTTOM;
                        var cell6 = new PdfPCell(new Phrase(new Chunk("Deskripsi\n(A/T/B)", TN10)));
                        cell6.HorizontalAlignment = Element.ALIGN_CENTER; cell6.VerticalAlignment = Element.ALIGN_BOTTOM;
                        var cell9 = new PdfPCell(new Phrase(new Chunk("No.", TB10))); cell9.Rowspan = 2;
                        cell9.HorizontalAlignment = Element.ALIGN_CENTER; cell9.VerticalAlignment = Element.ALIGN_BOTTOM;
                        var cell10 = new PdfPCell(new Phrase(new Chunk("NIS Siswa", TB10))); cell10.Rowspan = 2;
                        cell10.HorizontalAlignment = Element.ALIGN_CENTER; cell10.VerticalAlignment = Element.ALIGN_BOTTOM;
                        var cell11 = new PdfPCell(new Phrase(new Chunk("Nama Siswa", TB10))); cell11.Rowspan = 2;
                        cell11.HorizontalAlignment = Element.ALIGN_CENTER; cell11.VerticalAlignment = Element.ALIGN_BOTTOM;

                        raport_tbl.AddCell(cell9); raport_tbl.AddCell(cell10); raport_tbl.AddCell(cell11);
                        raport_tbl.AddCell(cell2); raport_tbl.AddCell(cell3); raport_tbl.AddCell(cell4);//Kompetensi induk
                        raport_tbl.AddCell(cell5); raport_tbl.AddCell(cell6); raport_tbl.AddCell(cell5);
                        raport_tbl.AddCell(cell6); raport_tbl.AddCell(cell5); raport_tbl.AddCell(cell6);//no, nis, nama, skala, deskripsi

                        string kelas = row1["Kode"].ToString();
                        this.field = "siswa.nis_siswa as 'NIS Siswa', nama_siswa as 'Nama Siswa'";
                        this.table = "detailkelassiswa INNER JOIN siswa USING (nis_siswa)";
                        this.cond = "kode_kelas = '" + kelas + "' AND siswa.status_siswa != 'Tidak Aktif' ORDER by nama_siswa ASC";
                        DataTable tabelSiswa = db.GetDataTable(field, table, cond);
                        int i = 1;
                        foreach (DataRow row in tabelSiswa.Rows)
                        {
                            var cell12 = new PdfPCell(new Phrase(new Chunk(i.ToString(), TN10)));
                            cell12.HorizontalAlignment = Element.ALIGN_LEFT;
                            var cell13 = new PdfPCell(new Phrase(new Chunk(row["NIS Siswa"].ToString(), TN10)));
                            cell13.HorizontalAlignment = Element.ALIGN_LEFT;
                            var cell14 = new PdfPCell(new Phrase(new Chunk(row["Nama Siswa"].ToString(), TN10)));
                            cell14.HorizontalAlignment = Element.ALIGN_LEFT;
                            raport_tbl.AddCell(cell12); raport_tbl.AddCell(cell13); raport_tbl.AddCell(cell14);
                            raport_tbl.AddCell(cell); raport_tbl.AddCell(cell); raport_tbl.AddCell(cell);
                            raport_tbl.AddCell(cell); raport_tbl.AddCell(cell); raport_tbl.AddCell(cell);
                            i++;
                        }
                        doc.NewPage();
                        doc.Add(paragraf);
                        doc.Add(format_tbl);
                        doc.Add(raport_tbl);
                    }
                    doc.NewPage();
                    FormatDeskripsi(doc);
                    //Close Document
                    doc.Close();
                    writer.Close();
                    fstream.Close();
                }
                MessageBox.Show("Selesai dalam: " + Convert.ToInt16(sw.Elapsed.TotalSeconds) + " detik");
            }
            catch (DocumentException de)
            {
                MessageBox.Show(de.Message);
            }
            catch (IOException ioe)
            {
                MessageBox.Show(ioe.Message);
            }
            catch (MySqlException myex)
            {
                switch (myex.Number)
                {
                    case 0: MessageBox.Show("Tidak bisa terkkoneksi ke Server."); break;
                    case 1042: MessageBox.Show("Koneksi ke Database atau Server tidak ditemukan."); break;
                    case 1045: MessageBox.Show("username/password salah."); break;
                    default: MessageBox.Show("Terjadi kesalahan data atau duplikasi data."); break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void FormatDeskripsi(Document doc)
        {
            PdfPTable format_tbl = new PdfPTable(7);
            format_tbl.TotalWidth = 525f; format_tbl.LockedWidth = true;
            format_tbl.DefaultCell.Border = Rectangle.NO_BORDER;
            widths = new float[] { 100f, 5f, 100f, 115f, 100f, 5f, 100f };
            format_tbl.SetWidths(widths);

            var paragraf = new Paragraph(new Chunk("FORMAT DESKRIPSI NILAI UJIAN SISWA", TB12));
            paragraf.Alignment = Element.ALIGN_CENTER;

            var cella = new PdfPCell(new Phrase(new Chunk("Pengajar", TN10)));
            cella.HorizontalAlignment = Element.ALIGN_LEFT; cella.BorderWidth = 0f;
            var cellb = new PdfPCell(new Phrase(new Chunk("Mata Pelajaran", TN10)));
            cellb.HorizontalAlignment = Element.ALIGN_LEFT; cellb.BorderWidth = 0f;
            var cellc = new PdfPCell(new Phrase(new Chunk("Kelompok Mapel", TN10)));
            cellc.HorizontalAlignment = Element.ALIGN_LEFT; cellc.BorderWidth = 0f;
            var celld = new PdfPCell(new Phrase(new Chunk("Kelas", TN10)));
            celld.HorizontalAlignment = Element.ALIGN_LEFT; celld.BorderWidth = 0f;
            var celle = new PdfPCell(new Phrase(new Chunk("Tahun Ajaran", TN10)));
            celle.HorizontalAlignment = Element.ALIGN_LEFT; celle.BorderWidth = 0f;
            var cellf = new PdfPCell(new Phrase(new Chunk("Semester", TN10)));
            cellf.HorizontalAlignment = Element.ALIGN_LEFT; cellf.BorderWidth = 0f;
            var cellg = new PdfPCell(new Phrase(new Chunk("Satu / Dua", TN10)));
            cellg.HorizontalAlignment = Element.ALIGN_LEFT; cellg.BorderWidth = 0f;
            var cellh = new PdfPCell(new Phrase(new Chunk(getTahun, TN10)));
            cellh.HorizontalAlignment = Element.ALIGN_LEFT; cellh.BorderWidth = 0f;
            var celli = new PdfPCell(new Phrase(new Chunk("A / B / C", TN10)));
            celli.HorizontalAlignment = Element.ALIGN_LEFT; celli.BorderWidth = 0f;
            var cellj = new PdfPCell(new Phrase(new Chunk("\n", TN10))); cellj.Colspan = 7;
            cellj.HorizontalAlignment = Element.ALIGN_LEFT; cellj.BorderWidth = 0f;
            var cellk = new PdfPCell(new Phrase(new Chunk(":", TN10)));
            cellk.HorizontalAlignment = Element.ALIGN_LEFT; cellk.BorderWidth = 0f;

            format_tbl.AddCell(cellj);
            format_tbl.AddCell(cella); format_tbl.AddCell(cellk); format_tbl.AddCell("");
            format_tbl.AddCell(""); format_tbl.AddCell(celld); format_tbl.AddCell(cellk); format_tbl.AddCell("");//
            format_tbl.AddCell(cellb); format_tbl.AddCell(cellk); format_tbl.AddCell("");
            format_tbl.AddCell(""); format_tbl.AddCell(celle); format_tbl.AddCell(cellk); format_tbl.AddCell(cellh);//
            format_tbl.AddCell(cellc); format_tbl.AddCell(cellk); format_tbl.AddCell(celli);
            format_tbl.AddCell(""); format_tbl.AddCell(cellf); format_tbl.AddCell(cellk); format_tbl.AddCell(cellg);//
            format_tbl.AddCell(cellj);

            var cell1 = new PdfPCell(new Phrase(new Chunk("Kompetensi Pengetahuan", TB10)));
            cell1.HorizontalAlignment = Element.ALIGN_CENTER; cell1.Colspan = 7;
            var cell2 = new PdfPCell(new Phrase(new Chunk("Kompetensi Keterampilan", TB10)));
            cell2.HorizontalAlignment = Element.ALIGN_CENTER; cell2.Colspan = 7;
            var cell3 = new PdfPCell(new Phrase(new Chunk("Kompetensi Sikap Sosial dan Spiritual", TB10)));
            cell3.HorizontalAlignment = Element.ALIGN_CENTER; cell3.Colspan = 7;
            var cell4 = new PdfPCell(new Phrase(new Chunk("Kelompok Atas", TN10)));
            cell4.HorizontalAlignment = Element.ALIGN_LEFT; cell4.Colspan = 7;
            var cell5 = new PdfPCell(new Phrase(new Chunk("Kelompok Tengah", TN10)));
            cell5.HorizontalAlignment = Element.ALIGN_LEFT; cell5.Colspan = 7;
            var cell6 = new PdfPCell(new Phrase(new Chunk("Kelompok Bawah", TN10)));
            cell6.HorizontalAlignment = Element.ALIGN_LEFT; cell6.Colspan = 7;
            var cell7 = new PdfPCell(new Phrase(new Chunk("\n\n\n\n\n", TN10)));
            cell7.HorizontalAlignment = Element.ALIGN_LEFT; cell7.Colspan = 7;
            var cell8 = new PdfPCell(new Phrase(new Chunk("\n", TN10))); cell8.BorderWidthBottom = 0f;
            cell8.Colspan = 7; cell8.BorderWidthLeft = 0f; cell8.BorderWidthRight = 0f; cell8.BorderWidthTop = 0f;

            format_tbl.AddCell(cell1);
            format_tbl.AddCell(cell4); format_tbl.AddCell(cell7);
            format_tbl.AddCell(cell5); format_tbl.AddCell(cell7);
            format_tbl.AddCell(cell6); format_tbl.AddCell(cell7);
            format_tbl.AddCell(cell8); format_tbl.AddCell(cell2);
            format_tbl.AddCell(cell4); format_tbl.AddCell(cell7);
            format_tbl.AddCell(cell5); format_tbl.AddCell(cell7);
            format_tbl.AddCell(cell6); format_tbl.AddCell(cell7);
            format_tbl.AddCell(cell8); format_tbl.AddCell(cell3);
            format_tbl.AddCell(cell4); format_tbl.AddCell(cell7);
            format_tbl.AddCell(cell5); format_tbl.AddCell(cell7);
            format_tbl.AddCell(cell6); format_tbl.AddCell(cell7);
            doc.Add(paragraf);
            doc.Add(format_tbl);
        }

        //END CLASS
    }
}
