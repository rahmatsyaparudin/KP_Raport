using System;
using System.Data;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using MySql.Data.MySqlClient;
using SpreadsheetLight;
using DocumentFormat.OpenXml.Spreadsheet;

namespace Raport
{
    class DataToExcel
    {
        MySqlConnection myConn = Function.getKoneksi();
        Function db = new Function();
        MySqlDataReader myReader;
        MySqlCommand myComm;
        DataTable dt;
        SLStyle style;
        SLTable table;
        public string getTahun, nama_bulan;
        public string getDiterima, getLahir;
        private string query;
        public string field, cond, dbTabel;
        private string filename;
        public int i, j;

        public string passTahun
        {
            get { return getTahun; }
            set { getTahun = value; }
        }

        public string appRootdir()
        {
            string dir = new DirectoryInfo(Environment.CurrentDirectory).FullName;
            return dir;
        }

        public void killExcelProcess()
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
        
        public void SiswaToExcel(string status)
        {
            Stopwatch sw = Stopwatch.StartNew();
            string path = "Temp\\Data Siswa";
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            SLDocument sl = new SLDocument();
            sl.AddWorksheet(getTahun.ToString().Replace("/", "-"));
            sl.DeleteWorksheet(SLDocument.DefaultFirstSheetName);

            dt = new DataTable();
            dt.Columns.Add("No", typeof(int)); dt.Columns.Add("Nama Siswa", typeof(string));
            dt.Columns.Add("NIS", typeof(string)); dt.Columns.Add("NISN", typeof(string));
            dt.Columns.Add("Tempat Lahir", typeof(string)); dt.Columns.Add("Tanggal Lahir", typeof(string));
            dt.Columns.Add("Jenis Kelamin", typeof(string)); dt.Columns.Add("Agama", typeof(string));
            dt.Columns.Add("Status", typeof(string)); dt.Columns.Add("Anak ke-", typeof(int));
            dt.Columns.Add("Alamat Siswa", typeof(string)); dt.Columns.Add("No. Telp. Rumah", typeof(string));
            dt.Columns.Add("Sekolah Asal", typeof(string)); dt.Columns.Add("Diterima di Kelas", typeof(string));
            dt.Columns.Add("Diterima Tanggal", typeof(string)); dt.Columns.Add("Nama Ayah", typeof(string));
            dt.Columns.Add("Nama Ibu", typeof(string)); dt.Columns.Add("Alamat Orangtua", typeof(string));
            dt.Columns.Add("No. Telp.", typeof(string)); dt.Columns.Add("Pekerjaan Ayah", typeof(string));
            dt.Columns.Add("Pekerjaan Ibu", typeof(string)); dt.Columns.Add("Nama Wali", typeof(string));
            dt.Columns.Add("Alamat Wali", typeof(string)); dt.Columns.Add("Pekerjaan Wali", typeof(string));

            myConn.Open();
            query = "SELECT siswa.nis_siswa as 'NIS', nisn_siswa as 'NISN', nama_siswa as 'Nama Siswa', tempat_lahir as " +
                    "'Tempat Lahir', tanggal_lahir as 'Tanggal Lahir', jenis_kelamin as 'Jenis Kelamin', kelas.nama_kelas " +
                    "as 'Diterima di Kelas', status_keluarga as 'Status Anak', anak_ke as 'Anak Ke-', agama as 'Agama', " +
                    "siswa.no_telp as 'No. Telp. Siswa', alamat as 'Alamat Siswa', asal_sekolah as 'Asal Sekolah', " +
                    "tanggal_masuk as 'Diterima Tanggal', nama_ayah as 'Nama Ayah', nama_ibu as 'Nama Ibu', " +
                    "pekerjaan_ayah as 'Pekerjaan Ayah', pekerjaan_ibu as 'Pekerjaan Ibu', orangtua.no_telp as " +
                    "'No. Telp. Ortu', alamat_ortu as 'Alamat Ortu', nama_wali as 'Nama Wali', pekerjaan_wali as " +
                    "'Pekerjaan Wali', alamat_wali as 'Alamat Wali' FROM detailkelassiswa INNER JOIN siswa ON " +
                    "siswa.nis_siswa = detailkelassiswa.nis_siswa INNER JOIN orangtua ON siswa.nis_siswa = orangtua.nis_siswa " +
                    "INNER JOIN kelas ON detailkelassiswa.kode_kelas = kelas.kode_kelas WHERE tahun_ajaran = '" + getTahun + 
                    "' AND (detailkelassiswa.keterangan = 'Data Siswa' OR detailkelassiswa.keterangan = " +
                    "'Data Kelas') AND status_siswa = '" + status + "' ORDER BY siswa.nis_siswa";
            myComm = new MySqlCommand(query, myConn);
            myReader = myComm.ExecuteReader();
            i = 1;
            while (myReader.Read())
            {
                string diterima = myReader.GetString("Diterima Tanggal"); string tanggal_diterima = diterima.Substring(0, 2);
                string bulan_diterima = diterima.Substring(3, 2); string tahun_diterima = diterima.Substring(6, 4);
                string diterima_bulan = getBulan(bulan_diterima);
                string lahir = myReader.GetString("Tanggal Lahir"); string tanggal_lahir = lahir.Substring(0, 2);
                string bulan_lahir = lahir.Substring(3, 2); string tahun_lahir = lahir.Substring(6, 4);
                string lahir_bulan = getBulan(bulan_lahir);
                getLahir = tanggal_lahir + " " + lahir_bulan + " " + tahun_lahir;
                getDiterima = tanggal_diterima + " " + diterima_bulan + " " + tahun_diterima;

                dt.Rows.Add(new object[]
                    { i,
                        myReader.GetString("Nama Siswa"), myReader.GetString("NIS"), myReader.GetString("NISN"),
                        myReader.GetString("Tempat Lahir"), getLahir, myReader.GetString("Jenis Kelamin"),
                        myReader.GetString("Agama"), myReader.GetString("Status Anak"), myReader.GetString("Anak ke-"),
                        myReader.GetString("Alamat Siswa"), myReader.GetString("No. Telp. Siswa"), myReader.GetString("Asal Sekolah"),
                        myReader.GetString("Diterima di Kelas"), getDiterima, myReader.GetString("Nama Ayah"),
                        myReader.GetString("Nama Ibu"), myReader.GetString("Alamat Ortu"), myReader.GetString("No. Telp. Ortu"),
                        myReader.GetString("Pekerjaan Ayah"), myReader.GetString("Pekerjaan Ibu"), myReader.GetString("Nama Wali"),
                        myReader.GetString("Alamat Wali"), myReader.GetString("Pekerjaan Wali")
                    });
                i++;
            }
            myConn.Close();

            int iStartRowIndex = 4;
            int iStartColumnIndex = 1;
            sl.ImportDataTable(iStartRowIndex, iStartColumnIndex, dt, true);

            style = sl.CreateStyle();

            int iEndRowIndex = iStartRowIndex + dt.Rows.Count + 1 - 1;
            int iEndColumnIndex = iStartColumnIndex + dt.Columns.Count - 1;
            table = sl.CreateTable(iStartRowIndex, iStartColumnIndex, iEndRowIndex, iEndColumnIndex);
            table.SetTableStyle(SLTableStyleTypeValues.Light10);
            sl.InsertTable(table);

            int iStartCount = 1;
            int iEndCount = dt.Columns.Count;
            style = sl.CreateStyle();
            style.Font.FontName = "Times New Roman";
            style.Font.FontSize = 12;
            sl.AutoFitColumn(iStartCount, iEndCount);
            sl.SetColumnStyle(iStartCount, iEndCount, style);

            style = sl.CreateStyle();
            style.Alignment.Horizontal = HorizontalAlignmentValues.Center;
            style.Alignment.JustifyLastLine = true;
            style.Alignment.ShrinkToFit = true;
            style.Font.FontSize = 18;
            style.Font.Bold = true;
            style.Font.FontName = "Times New Roman";
            sl.MergeWorksheetCells(1, 1, 1, 10);
            sl.SetCellValue(1, 1, "DATA SISWA SMA NEGERI 1 JAMPANGKULON");
            sl.SetCellStyle(1, 1, style);
            sl.MergeWorksheetCells(2, 1, 2, 10);
            sl.SetCellValue(2, 1, "TAHUN AJARAN " + getTahun);
            sl.SetCellStyle(2, 1, style);
            filename = "Data Siswa [" + getTahun.ToString().Replace("/", "-") + "].xlsx";
            sl.SaveAs(appRootdir() + "\\" + path + "\\" + filename);

            sw.Stop();
            MessageBox.Show("Time taken: " + Convert.ToInt16(sw.Elapsed.TotalSeconds));
        }
        
        public void GuruToExcel(string status)
        {
            Stopwatch sw = Stopwatch.StartNew();
            string path = "Temp\\Data Guru";
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            SLDocument sl = new SLDocument();
            sl.AddWorksheet(getTahun.ToString().Replace("/", "-"));
            sl.DeleteWorksheet(SLDocument.DefaultFirstSheetName);

            dt = new DataTable();
            dt.Columns.Add("No", typeof(string));
            dt.Columns.Add("Nama Guru", typeof(string));
            dt.Columns.Add("NIP", typeof(string));
            dt.Columns.Add("NUPTK", typeof(string));
            dt.Columns.Add("Keterangan", typeof(string));

            field = "nama_guru as 'Nama Guru', nip as 'NIP', nuptk as 'NUPTK', keterangan as 'Keterangan'";
            dbTabel = "guru";
            cond = "status_guru = '" + status + "' ORDER BY nip, nama_guru ASC";

            query = "SELECT " + field + " FROM " + dbTabel + " WHERE " + cond;
            myComm = new MySqlCommand(query, myConn);
            myConn.Open();
            myReader = myComm.ExecuteReader();
            i = 1;
            while (myReader.Read())
            {
                dt.Rows.Add(new object[]{
                            i.ToString(), myReader.GetString("Nama Guru"), myReader.GetString("NIP"),
                            myReader.GetString("NUPTK"), myReader.GetString("Keterangan")
                            });
                i++;
            }
            myConn.Close();
            
            int iStartRowIndex = 4;
            int iStartColumnIndex = 1;
            sl.ImportDataTable(iStartRowIndex, iStartColumnIndex, dt, true);
            style = sl.CreateStyle();

            int iEndRowIndex = iStartRowIndex + dt.Rows.Count + 1 - 1;
            int iEndColumnIndex = iStartColumnIndex + dt.Columns.Count - 1;
            table = sl.CreateTable(iStartRowIndex, iStartColumnIndex, iEndRowIndex, iEndColumnIndex);
            table.SetTableStyle(SLTableStyleTypeValues.Light10);
            sl.InsertTable(table);

            int iStartColumnCount = 0;
            int iEndColumnCount = dt.Columns.Count;
            int iEndRowCount = dt.Rows.Count;
            style = sl.CreateStyle();
            style.Font.FontName = "Times New Roman";
            style.Font.FontSize = 12;
            sl.AutoFitColumn(iStartColumnCount, iEndColumnCount);
            sl.SetColumnStyle(iStartColumnCount, iEndColumnCount, style);

            style = sl.CreateStyle();
            style.Alignment.Horizontal = HorizontalAlignmentValues.Center;
            style.Alignment.JustifyLastLine = true;
            style.Alignment.ShrinkToFit = true;
            style.Font.FontSize = 18;
            style.Font.Bold = true;
            style.Font.FontName = "Times New Roman";
            sl.MergeWorksheetCells(1, 1, 1, 5);
            sl.SetCellValue(1, 1, "DATA GURU SMA NEGERI 1 JAMPANGKULON");
            sl.SetCellStyle(1, 1, style);
            sl.MergeWorksheetCells(2, 1, 2, 5);
            sl.SetCellValue(2, 1, "TAHUN AJARAN " + getTahun);
            sl.SetCellStyle(2, 1, style);
            filename = "Data Guru [" + getTahun.ToString().Replace("/", "-") + "].xlsx";
            sl.SaveAs(appRootdir() + "\\" + path + "\\" + filename);

            sw.Stop();
            MessageBox.Show("Time taken: " + Convert.ToInt16(sw.Elapsed.TotalSeconds));
        }

        public void KelasToExcel(string status)
        {
            Stopwatch sw = Stopwatch.StartNew();
            string path = "Temp\\Data Kelas";
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            SLDocument sl = new SLDocument();
            
            dbTabel = "kelas INNER JOIN guru USING (id_guru)";
            field = "kode_kelas as 'Kode Kelas', nama_kelas as 'Nama Kelas', nama_guru as 'Wali Kelas'";
            cond = "status_kelas= '" + status + "' AND tahun_ajaran = '" + getTahun + "'";
            dt = db.GetDataTable(field, dbTabel, cond);

            foreach (DataRow row in dt.Rows)
            {
                DataTable result = new DataTable();
                result.Columns.Add("No", typeof(string));
                result.Columns.Add("No. Induk", typeof(string));
                result.Columns.Add("NISN", typeof(string));
                result.Columns.Add("Nama Siswa", typeof(string));
                result.Columns.Add("Tanggal Lahir", typeof(string));
                result.Columns.Add("No. Telp. Siswa", typeof(string));
                result.Columns.Add("Nama Ayah", typeof(string));
                result.Columns.Add("Alamat Siswa", typeof(string));

                dbTabel = "detailkelassiswa INNER JOIN siswa USING (nis_siswa) INNER JOIN orangtua USING (nis_siswa)";
                field = "detailkelassiswa.nis_siswa as 'NIS', nisn_siswa as 'NISN', nama_siswa as 'Nama Siswa', " +
                        "tanggal_lahir as 'Tanggal Lahir', siswa.no_telp as 'No. Telp. Siswa', nama_ayah as 'Nama Ayah', alamat as 'Alamat Siswa'";
                cond = "detailkelassiswa.kode_kelas= '" + row["Kode Kelas"].ToString() +
                       "' AND (keterangan = 'Data Siswa' OR keterangan = 'Data Kelas')";

                query = "SELECT " + field + " FROM " + dbTabel + " WHERE " + cond;
                myComm = new MySqlCommand(query, myConn);
                myConn.Open();
                myReader = myComm.ExecuteReader();
                i = 1;
                while (myReader.Read())
                {
                    result.Rows.Add(new object[] { 
                        i.ToString(), myReader.GetString("NIS"), myReader.GetString("NISN"),
                        myReader.GetString("Nama Siswa"), myReader.GetString("Tanggal Lahir"),
                        myReader.GetString("No. Telp. Siswa"), myReader.GetString("Nama Ayah"),
                        myReader.GetString("Alamat Siswa")
                        });
                    i++;
                }
                myConn.Close();
                
                sl.AddWorksheet(row["Nama Kelas"].ToString());

                int iStartRowIndex = 7;
                int iStartColumnIndex = 1;
                sl.ImportDataTable(iStartRowIndex, iStartColumnIndex, result, true);
                style = sl.CreateStyle();
                int iEndRowIndex = iStartRowIndex + result.Rows.Count + 1 - 1;
                int iEndColumnIndex = iStartColumnIndex + result.Columns.Count - 1;
                table = sl.CreateTable(iStartRowIndex, iStartColumnIndex, iEndRowIndex, iEndColumnIndex);
                table.SetTableStyle(SLTableStyleTypeValues.Light10);
                sl.InsertTable(table);
                int iStartColumnCount = 1;
                int iStartRowCount = 1;
                int iEndColumnCount = result.Columns.Count;
                int iEndRowCount = result.Rows.Count;
                style = sl.CreateStyle();
                style.Font.FontName = "Times New Roman";
                style.Font.FontSize = 12;
                sl.AutoFitColumn(iStartColumnCount, iEndColumnCount);
                sl.SetColumnStyle(iStartColumnCount, iEndColumnCount, style);

                style = sl.CreateStyle();
                style.Alignment.Horizontal = HorizontalAlignmentValues.Center;
                style.Alignment.JustifyLastLine = true;
                style.Alignment.ShrinkToFit = true;
                style.Font.FontSize = 18;
                style.Font.Bold = true;
                style.Font.FontName = "Times New Roman";
                sl.MergeWorksheetCells(1, 1, 1, 7);
                sl.SetCellValue(1, 1, "DATA KELAS SMA NEGERI 1 JAMPANGKULON");
                sl.SetCellStyle(1, 1, style);
                sl.MergeWorksheetCells(2, 1, 2, 7);
                sl.SetCellValue(2, 1, "TAHUN AJARAN " + getTahun);
                sl.SetCellStyle(2, 1, style);
                sl.MergeWorksheetCells(3, 1, 3, 7);

                style = sl.CreateStyle();
                style.Alignment.Horizontal = HorizontalAlignmentValues.Left;
                style.Alignment.JustifyLastLine = true;
                style.Alignment.ShrinkToFit = true;
                style.Font.FontSize = 12;
                style.Font.Bold = true;
                style.Font.FontName = "Times New Roman";
                sl.MergeWorksheetCells(4, 1, 4, 2);
                sl.SetCellValue(4, 1, "Nama Kelas");
                sl.SetCellStyle(4, 1, style);
                sl.MergeWorksheetCells(4, 3, 4, 4);
                sl.SetCellValue(4, 3, row["Nama Kelas"].ToString());
                sl.SetCellStyle(4, 3, style);
                sl.MergeWorksheetCells(5, 1, 5, 2);
                sl.SetCellValue(5, 1, "Wali Kelas");
                sl.SetCellStyle(5, 1, style);
                sl.MergeWorksheetCells(5, 3, 5, 4);
                sl.SetCellValue(5, 3, row["Wali Kelas"].ToString());
                sl.SetCellStyle(5, 3, style);
                sl.MergeWorksheetCells(6, 1, 6, 2);
                sl.SetCellValue(6, 1, "Tahun Ajaran");
                sl.SetCellStyle(6, 1, style);
                sl.MergeWorksheetCells(6, 3, 6, 4);
                sl.SetCellValue(6, 3, getTahun);
                sl.SetCellStyle(6, 3, style);
            }
            sl.DeleteWorksheet(SLDocument.DefaultFirstSheetName);
            filename = "Data Kelas [" + getTahun.ToString().Replace("/", "-") + "].xlsx";
            sl.SaveAs(appRootdir() + "\\" + path + "\\" + filename);

            sw.Stop();
            MessageBox.Show("Time taken: " + Convert.ToInt16(sw.Elapsed.TotalSeconds));
        }

        public void NilaiToExcel(string status)
        {
            Stopwatch sw = Stopwatch.StartNew();
            string path = "Temp\\Data Nilai";
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            SLDocument sl = new SLDocument();

            //dbTabel = "nilai INNER JOIN siswa USING (nis_siswa) INNER JOIN mapel USING (kode_mapel)";
            //field = "nis_siswa as 'NIS Siswa', nama_siswa as 'Nama Siswa', p_skala as 'Skala (P)', p_ang as 'Angka (P)', " +
            //        "p_pred as 'Predikat (P)', p_desk as 'Deskripsi (P)', k_skala as 'Skala (K)', k_ang as 'Angka (K)', " +
            //        "k_pred as 'Predikat (K)', k_desk as 'Deskripsi (K)', s_skala as 'Skala (S)', s_sikap as 'SB/B/C/K', " +
            //        "s_desk as 'Deskripsi (S)', kode_mapel as 'Kode Mapel'";
            //cond = "status_kelas= '" + status + "' AND tahun_ajaran = '" + getTahun + "'";

            dbTabel = "detailmapelkelas INNER JOIN mapel USING (kode_mapel) INNER JOIN guru USING (id_guru)";
            field = "kode_mapel as 'Kode Mapel', nama_guru as 'Nama Guru', mata_pelajaran as 'Mata Pelajaran', kategori_mapel as 'Kategori'";
            cond = "kode_kelas = '3'";
            dt = db.GetDataTable(field, dbTabel, cond);

            foreach (DataRow row in dt.Rows)
            {
                DataTable result = new DataTable();
                result.Columns.Add("No. Induk", typeof(string)); result.Columns.Add("Nama Siswa", typeof(string));
                result.Columns.Add("Skala (P)", typeof(string)); result.Columns.Add("Angka (P)", typeof(string));
                result.Columns.Add("Predikat (P)", typeof(string)); result.Columns.Add("Deskripsi (P)", typeof(string));
                result.Columns.Add("Skala (K)", typeof(string)); result.Columns.Add("Angka (K)", typeof(string));
                result.Columns.Add("Predikat (K)", typeof(string)); result.Columns.Add("Deskripsi (K)", typeof(string));
                result.Columns.Add("Skala (S)", typeof(string)); result.Columns.Add("SB/B/C/K", typeof(string));
                result.Columns.Add("Deskripsi (S)", typeof(string));

                dbTabel = "nilai INNER JOIN siswa USING (nis_siswa) INNER JOIN mapel USING (kode_mapel) INNER JOIN kelas USING (kode_kelas)";
                field = "nis_siswa as 'NIS Siswa', nama_siswa as 'Nama Siswa', p_skala as 'Skala (P)', p_ang as 'Angka (P)', " +
                        "p_pred as 'Predikat (P)', p_desk as 'Deskripsi (P)', k_skala as 'Skala (K)', k_ang as 'Angka (K)', " +
                        "k_pred as 'Predikat (K)', k_desk as 'Deskripsi (K)', s_skala as 'Skala (S)', s_sikap as 'SB/B/C/K', " +
                        "s_desk as 'Deskripsi (S)'";
                cond = "status_siswa != '" + status + "' AND tahun_ajaran = '" + getTahun + 
                       "' AND kode_kelas = '3' AND kode_mapel ='"+row["Kode Mapel"].ToString()+ "'";
                query = "SELECT " + field + " FROM " + dbTabel + " WHERE " + cond;
                myComm = new MySqlCommand(query, myConn);
                myConn.Open();
                myReader = myComm.ExecuteReader();
                while (myReader.Read())
                {
                    result.Rows.Add(new object[]
                        {
                        myReader.GetString("NIS Siswa"), myReader.GetString("Nama Siswa"),
                        myReader.GetString("Skala (P)"), myReader.GetString("Angka (P)"),
                        myReader.GetString("Predikat (P)"), myReader.GetString("Deskripsi (P)"),
                        myReader.GetString("Skala (K)"), myReader.GetString("Angka (K)"),
                        myReader.GetString("Predikat (K)"), myReader.GetString("Deskripsi (K)"),
                        myReader.GetString("Skala (S)"), myReader.GetString("SB/B/C/K"),
                        myReader.GetString("Deskripsi (P)")
                        });
                }
                myConn.Close();
                sl.AddWorksheet(row["Kode Mapel"].ToString());

                int iStartRowIndex = 7;
                int iStartColumnIndex = 1;
                sl.ImportDataTable(iStartRowIndex, iStartColumnIndex, result, true);
                style = sl.CreateStyle();
                int iEndRowIndex = iStartRowIndex + result.Rows.Count + 1 - 1;
                int iEndColumnIndex = iStartColumnIndex + result.Columns.Count - 1;
                table = sl.CreateTable(iStartRowIndex, iStartColumnIndex, iEndRowIndex, iEndColumnIndex);
                table.SetTableStyle(SLTableStyleTypeValues.Light10);
                sl.InsertTable(table);
                int iStartColumnCount = 1;
                int iStartRowCount = 1;
                int iEndColumnCount = result.Columns.Count;
                int iEndRowCount = result.Rows.Count;
                style = sl.CreateStyle();
                style.Font.FontName = "Times New Roman";
                style.Font.FontSize = 12;
                sl.AutoFitColumn(iStartColumnCount, iEndColumnCount);
                sl.SetColumnStyle(iStartColumnCount, iEndColumnCount, style);

                style = sl.CreateStyle();
                style.Alignment.Horizontal = HorizontalAlignmentValues.Center;
                style.Alignment.JustifyLastLine = true;
                style.Alignment.ShrinkToFit = true;
                style.Font.FontSize = 18;
                style.Font.Bold = true;
                style.Font.FontName = "Times New Roman";
                sl.MergeWorksheetCells(1, 1, 1, 7);
                sl.SetCellValue(1, 1, "DATA KELAS SMA NEGERI 1 JAMPANGKULON");
                sl.SetCellStyle(1, 1, style);
                sl.MergeWorksheetCells(2, 1, 2, 7);
                sl.SetCellValue(2, 1, "TAHUN AJARAN " + getTahun);
                sl.SetCellStyle(2, 1, style);
                sl.MergeWorksheetCells(3, 1, 3, 7);

                style = sl.CreateStyle();
                style.Alignment.Horizontal = HorizontalAlignmentValues.Left;
                style.Alignment.JustifyLastLine = true;
                style.Alignment.ShrinkToFit = true;
                style.Font.FontSize = 12;
                style.Font.Bold = true;
                style.Font.FontName = "Times New Roman";
                sl.MergeWorksheetCells(4, 1, 4, 2);
                sl.SetCellValue(4, 1, "Mata Pelajaran");
                sl.SetCellStyle(4, 1, style);
                sl.MergeWorksheetCells(4, 3, 4, 4);
                sl.SetCellValue(4, 3, row["Mata Pelajaran"].ToString());
                sl.SetCellStyle(4, 3, style);
                sl.MergeWorksheetCells(5, 1, 5, 2);
                sl.SetCellValue(5, 1, "Kategori");
                sl.SetCellStyle(5, 1, style);
                sl.MergeWorksheetCells(5, 3, 5, 4);
                sl.SetCellValue(5, 3, row["Kategori"].ToString());
                sl.SetCellStyle(5, 3, style);
                sl.MergeWorksheetCells(6, 1, 6, 2);
                sl.SetCellValue(6, 1, "Tahun Ajaran");
                sl.SetCellStyle(6, 1, style);
                sl.MergeWorksheetCells(6, 3, 6, 4);
                sl.SetCellValue(6, 3, getTahun);
                sl.SetCellStyle(6, 3, style);
            }
            sl.DeleteWorksheet(SLDocument.DefaultFirstSheetName);
            filename = "Data Nilai [" + getTahun.ToString().Replace("/", "-") + "].xlsx";
            sl.SaveAs(appRootdir() + "\\" + path + "\\" + filename);

            sw.Stop();
            MessageBox.Show("Time taken: " + Convert.ToInt16(sw.Elapsed.TotalSeconds));
        }
        //END CLASS
    }
}
