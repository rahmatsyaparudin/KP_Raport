using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Runtime.Serialization;

namespace Raport
{
    public partial class FormUtama : Form
    { 
        MySqlConnection myConn = Function.getKoneksi();
        MySqlDataReader myReader;
        MySqlCommand myComm;
        Function db = new Function();
        DataToExcel dbToExcel = new DataToExcel();
        DataToPDF dbToPDF = new DataToPDF();
        DateTime jamku = new DateTime();
        private string table, cond, field, query;
        public string getLevel, getUser, getFormat;
        
        public FormUtama()
        {
            InitializeComponent();
            
            Thread t = new Thread(new ThreadStart(SplashStart));
            t.Start();
            Thread.Sleep(3000);
            t.Abort();
        }

        public void SplashStart()
        {
            Application.Run(new SplashScreen());
        }

        public string passLevel
        {
            get { return getLevel; }
            set { getLevel = value; }
        }
        
        public string passUser
        {
            get { return getUser; }
            set { getUser = value; }
        }

        private void FormUtama_Load(object sender, EventArgs e)
        {
            try
            {
                if (getLevel == "0")  //User
                    user_lbl.Text = getUser;
                else if (getLevel == "1") //Admin
                {
                    profil_menu.Enabled = true;
                    mapel_menu.Enabled = true;
                    user_menu.Enabled = true;
                    user_menu.Enabled = true;
                    export_btn.Enabled = true;
                    user_lbl.Text = getUser;
                }

                getCombo();
                jamku = DateTime.Now;
                query = "SELECT * FROM profil_sekolah";
                myComm = new MySqlCommand(query, myConn);
                myConn.Open();
                myReader = myComm.ExecuteReader();
                while (myReader.Read())
                {
                    string sNama = myReader.GetString("nama_sekolah");
                    string sAlamat = myReader.GetString("alamat_sekolah");
                    string sKec = myReader.GetString("kecamatan");
                    string sKel = myReader.GetString("kelurahan");
                    string sKota = myReader.GetString("kota");
                    string sProv = myReader.GetString("provinsi");
                    string sPos = myReader.GetInt32("kode_pos").ToString();
                    string sTelp = myReader.GetString("no_telp");
                    string sWeb = myReader.GetString("website");
                    string sEmail = myReader.GetString("email");
                    nama_lbl.Text = sNama;
                    alamat_lbl.Text = sAlamat + ", Kec. " + sKec + ", Kel. " + sKel;
                    alamat2_lbl.Text = "Kab. " + sKota + ", " + sProv + " - " + sPos + ". Telp. " + sTelp;
                    alamat3_lbl.Text = "Email: " + sEmail;
                }
                myConn.Close();
            }
            catch (MySqlException myex)
            {
                switch (myex.Number)
                {
                    case 0: MessageBox.Show("Tidak bisa terkkoneksi ke Server."); break;
                    case 1042: MessageBox.Show("Koneksi ke Database atau Server tidak ditemukan."); break;
                    case 1045: MessageBox.Show("username/password salah."); break;
                    default: MessageBox.Show("Terjadi kesalahan data atau aplikasi."); break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void getCombo()
        {
            tahuj_combo.DataSource = db.getTahuj();
            tahuj_combo.DisplayMember = "valueDisplay";
        }

        private void set_btn_Click(object sender, EventArgs e)
        {
            if ((set_btn.Text.Equals("Set")) &&
                (!String.IsNullOrEmpty(tahuj_combo.Text)))
            {
                set_btn.Text = "Edit";
                tahuj_combo.Enabled = false;
                if (getLevel == "0")
                {
                    deskripsi_menu.Enabled = true;
                    nilai_menu.Enabled = true;
                    saveDataGuru_btn.Enabled = true;
                    saveDataKelas_btn.Enabled = true;
                    saveDataNilai_btn.Enabled = true;
                    printFormat_Btn.Enabled = true;
                    printRaport_Btn.Enabled = true;
                }
                else if (getLevel == "1")
                {
                    kelas_menu.Enabled = true;
                    eskul_menu.Enabled = true;
                    siswa_menu.Enabled = true;
                    deskripsi_menu.Enabled = true;
                    nilai_menu.Enabled = true;
                    guru_menu.Enabled = true;
                    saveDataGuru_btn.Enabled = true;
                    saveDataKelas_btn.Enabled = true;
                    saveDataNilai_btn.Enabled = true;
                    saveDataSiswa_btn.Enabled = true;
                    printFormat_Btn.Enabled = true;
                    printRaport_Btn.Enabled = true;
                }
            }
            else if (set_btn.Text.Equals("Edit"))
            {
                tahuj_combo.Enabled = true;
                siswa_menu.Enabled = false;
                deskripsi_menu.Enabled = false;
                nilai_menu.Enabled = false;
                guru_menu.Enabled = false;
                saveDataGuru_btn.Enabled = false;
                saveDataKelas_btn.Enabled = false;
                saveDataNilai_btn.Enabled = false;
                saveDataSiswa_btn.Enabled = false;
                printFormat_Btn.Enabled = false;
                printRaport_Btn.Enabled = false;
                kelas_menu.Enabled = false;
                eskul_menu.Enabled = false;
                set_btn.Text = "Set";
            }
        }

        private void LogOut_btn_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Apakah Anda yakin ingin Log Out?",
            "Exit Aplikasi", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                this.Close();
                FormLogin fLogin = new FormLogin();
                fLogin.Show();
            }
            else if (dialog == DialogResult.No)
            {
                CancelEventArgs batal = new CancelEventArgs();
                batal.Cancel = true;
            }
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Apakah Anda yakin ingin Menutup aplikasi?",
            "Exit Aplikasi", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                dbToExcel.killExcelProcess();
                dbToPDF.killPDFProcess();
                Application.ExitThread();
                Application.Exit();
            }
            else if (dialog == DialogResult.No)
            {
                CancelEventArgs batal = new CancelEventArgs();
                batal.Cancel = true;
            }
        }


        //Update jumlah siswa di kelas
        public void jumlahSiswa()
        {
            try
            {
                this.field = "kode_kelas as 'Kode', count(*) as 'Jumlah'";
                this.table = "detailkelassiswa";
                this.cond = "group by kode_kelas";
                string query = "SELECT " + field + " FROM " + table + " " + cond;

                myComm = new MySqlCommand(query, myConn);
                myConn.Open();
                myReader = myComm.ExecuteReader();
                while (myReader.Read())
                {
                    string kode = myReader.GetString("Kode");
                    string value = myReader.GetString("Jumlah");
                    string table2 = "kelas";
                    string field2 = "jumlah_siswa = '" + value + "'";
                    string cond2 = "kode_kelas = '" + kode + "'";
                    db.updateData(table2, field2, cond2);
                    MessageBox.Show(value);
                }
                myConn.Close();
            }
            catch (MySqlException myex)
            {
                switch (myex.Number)
                {
                    case 0: MessageBox.Show("Tidak bisa terkkoneksi ke Server."); break;
                    case 1042: MessageBox.Show("Koneksi ke Database atau Server tidak ditemukan."); break;
                    case 1045: MessageBox.Show("username/password salah."); break;
                    default: MessageBox.Show("Terjadi kesalahan data atau aplikasi."); break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void profil_menu_Click(object sender, EventArgs e)
        {
            FormProfilSekolah fProfil = new FormProfilSekolah();
            fProfil.ShowDialog();
        }

        private void guru_menu_Click(object sender, EventArgs e)
        {
            FormGuru fGuru = new FormGuru();
            fGuru.passTahun = tahuj_combo.Text.ToString();
            fGuru.ShowDialog();
        }

        private void mapel_menu_Click(object sender, EventArgs e)
        {
            FormMapel fMapel = new FormMapel();
            fMapel.ShowDialog();
        }

        private void user_menu_Click(object sender, EventArgs e)
        {
            FormUser fUser = new FormUser();
            fUser.ShowDialog();
        }
        
        private void kelas_menu_Click(object sender, EventArgs e)
        {
            jumlahSiswa();
            FormKelas fKelas = new FormKelas();
            fKelas.passTahun = tahuj_combo.Text.ToString();
            fKelas.ShowDialog();
        }

        private void eskul_menu_Click(object sender, EventArgs e)
        {
            FormEskul fEskul = new FormEskul();
            fEskul.ShowDialog();                 
        }

        private void siswa_menu_Click(object sender, EventArgs e)
        {
            FormSiswa fSiswa = new FormSiswa();
            fSiswa.tahun_ajaran = tahuj_combo.Text.ToString();
            fSiswa.ShowDialog();
        }

        private void nilai_menu_Click(object sender, EventArgs e)
        {
            FormNilai fNilai = new FormNilai();
            fNilai.passTahuj = tahuj_combo.Text.ToString();
            fNilai.passUser = getUser;
            fNilai.passLevel = getLevel;
            fNilai.ShowDialog();
        }

        private void deskripsi_menu_Click(object sender, EventArgs e)
        {
            FormDeskripsi fDesk = new FormDeskripsi();
            fDesk.passTahuj = tahuj_combo.Text.ToString();
            fDesk.passUser = getUser;
            fDesk.passLevel = getLevel;
            fDesk.ShowDialog();
        }
        
        private void saveDataGuru_btn_Click(object sender, EventArgs e)
        {
            try
            {
                dbToExcel.passTahun = tahuj_combo.Text.ToString();
                dbToExcel.GuruToExcel("Aktif");
                db.BrowserDialog(fbDialog, "Data Guru");
            }
            catch (MySqlException myex)
            {
                switch (myex.Number)
                {
                    case 0: MessageBox.Show("Tidak bisa terkkoneksi ke Server."); break;
                    case 1042: MessageBox.Show("Koneksi ke Database atau Server tidak ditemukan."); break;
                    case 1045: MessageBox.Show("username/password salah."); break;
                    default: MessageBox.Show("Terjadi kesalahan data atau aplikasi."); break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void saveDataSiswa_btn_Click(object sender, EventArgs e)
        {
            try
            {
                dbToExcel.passTahun = tahuj_combo.Text.ToString();
                dbToExcel.SiswaToExcel("Aktif");
                db.BrowserDialog(fbDialog, "Data Siswa");
            }
            catch (MySqlException myex)
            {
                switch (myex.Number)
                {
                    case 0: MessageBox.Show("Tidak bisa terkkoneksi ke Server."); break;
                    case 1042: MessageBox.Show("Koneksi ke Database atau Server tidak ditemukan."); break;
                    case 1045: MessageBox.Show("username/password salah."); break;
                    default: MessageBox.Show("Terjadi kesalahan data atau aplikasi."); break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void raport_printBtn_Click(object sender, EventArgs e)
        {
            //try
            //{
                dbToPDF.passTahun = tahuj_combo.Text.ToString();
                string kode_kelas = "3";
                string semester = "SMT1";
                dbToPDF.passKode = kode_kelas;
                dbToPDF.passSemester = semester;
                dbToPDF.RaportKelasToPDF();
                db.BrowserDialog(fbDialog, "Data Nilai");
            //}
            //catch (MySqlException myex)
            //{
            //    switch (myex.Number)
            //    {
            //        case 0: MessageBox.Show("Tidak bisa terkkoneksi ke Server."); break;
            //        case 1042: MessageBox.Show("Koneksi ke Database atau Server tidak ditemukan."); break;
            //        case 1045: MessageBox.Show("username/password salah."); break;
            //        default: MessageBox.Show("Terjadi kesalahan data atau aplikasi."); break;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void saveDataKelas_btn_Click(object sender, EventArgs e)
        {
            try
            {
                dbToExcel.passTahun = tahuj_combo.Text.ToString();
                dbToExcel.KelasToExcel("Aktif");
                db.BrowserDialog(fbDialog, "Data Kelas");
            }
            catch (MySqlException myex)
            {
                switch (myex.Number)
                {
                    case 0: MessageBox.Show("Tidak bisa terkkoneksi ke Server."); break;
                    case 1042: MessageBox.Show("Koneksi ke Database atau Server tidak ditemukan."); break;
                    case 1045: MessageBox.Show("username/password salah."); break;
                    default: MessageBox.Show("Terjadi kesalahan data atau aplikasi."); break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void saveDataNilai_btn_Click(object sender, EventArgs e)
        {
            //try
            //{
                dbToExcel.passTahun = tahuj_combo.Text.ToString();
                dbToExcel.NilaiToExcel("Tidak Aktif");
                db.BrowserDialog(fbDialog, "Data Nilai");
            //}
            //catch (MySqlException myex)
            //{
            //    switch (myex.Number)
            //    {
            //        case 0: MessageBox.Show("Tidak bisa terkkoneksi ke Server."); break;
            //        case 1042: MessageBox.Show("Koneksi ke Database atau Server tidak ditemukan."); break;
            //        case 1045: MessageBox.Show("username/password salah."); break;
            //        default: MessageBox.Show("Terjadi kesalahan data atau aplikasi."); break;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void export_btn_Click(object sender, EventArgs e)
        {
            FormExport fDesk = new FormExport();
            fDesk.ShowDialog();
        }
        
        private void print_formatBtn_Click(object sender, EventArgs e)
        {
            try
            {
                dbToPDF.passTahun = tahuj_combo.Text.ToString();
                dbToPDF.FormatNilaiPDF();
                string print = dbToPDF.getFormat;
                MessageBox.Show(print);
                //db.BrowserDialog(fbDialog, "Print");
                db.SendToPrinter(print);
            }
            catch (MySqlException myex)
            {
                switch (myex.Number)
                {
                    case 0: MessageBox.Show("Tidak bisa terkkoneksi ke Server."); break;
                    case 1042: MessageBox.Show("Koneksi ke Database atau Server tidak ditemukan."); break;
                    case 1045: MessageBox.Show("username/password salah."); break;
                    default: MessageBox.Show("Terjadi kesalahan data atau aplikasi."); break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void back_rest_Btn_Click(object sender, EventArgs e)
        {
            FormBackupRestoreDb fBackRest = new FormBackupRestoreDb();
            fBackRest.ShowDialog();
        }

        private void clock_timer_Tick(object sender, EventArgs e)
        {
            string[] bulan = { "Januari", "Februari", "Maret", "April", "Mei", "Juni", "Juli", "Agustus", "September", "Oktober", "November", "Desember" };
            string[] hari = { "Senin", "Selasa", "Rabu", "Kamis", "Jumat", "Sabtu", "Minggu" };

            string today = DateTime.Today.DayOfWeek.ToString("d");
            if (today == "0") hari_lbl.Text = "Minggu";
            else if (today == "1") hari_lbl.Text = "Senin";
            else if (today == "2") hari_lbl.Text = "Selasa";
            else if (today == "3") hari_lbl.Text = "Rabu";
            else if (today == "4") hari_lbl.Text = "Kamis";
            else if (today == "5") hari_lbl.Text = "Jumat";
            else if (today == "6") hari_lbl.Text = "Sabtu";
            jamku = DateTime.Now;
            tanggal_lbl.Text = DateTime.Today.Day.ToString();
            bulan_lbl.Text = bulan[DateTime.Today.Month - 1] + ", " + DateTime.Today.Year.ToString();
            jam_lbl.Text = jamku.Hour.ToString() + ":" + jamku.Minute.ToString() +
                            ":" + jamku.Second.ToString();
        }

        private void color_timer_Tick(object sender, EventArgs e)
        {
            if (profil_menu.BackColor == Color.DeepSkyBlue)
            {
                profil_menu.BackColor = Color.Magenta; guru_menu.BackColor = Color.DeepSkyBlue;
                kelas_menu.BackColor = Color.CadetBlue; mapel_menu.BackColor = Color.LimeGreen;
                siswa_menu.BackColor = Color.Lavender; eskul_menu.BackColor = Color.Yellow;
                nilai_menu.BackColor = Color.Red; deskripsi_menu.BackColor = Color.BurlyWood;
            }
            else if (profil_menu.BackColor == Color.Magenta)
            {
                profil_menu.BackColor = Color.BurlyWood; guru_menu.BackColor = Color.Magenta;
                kelas_menu.BackColor = Color.DeepSkyBlue; mapel_menu.BackColor = Color.CadetBlue;
                siswa_menu.BackColor = Color.LimeGreen; eskul_menu.BackColor = Color.Lavender;
                nilai_menu.BackColor = Color.Yellow; deskripsi_menu.BackColor = Color.Red;
            }
            else if (profil_menu.BackColor == Color.BurlyWood)
            {
                profil_menu.BackColor = Color.Red; guru_menu.BackColor = Color.BurlyWood;
                kelas_menu.BackColor = Color.Magenta; mapel_menu.BackColor = Color.DeepSkyBlue;
                siswa_menu.BackColor = Color.CadetBlue; eskul_menu.BackColor = Color.LimeGreen;
                nilai_menu.BackColor = Color.Lavender; deskripsi_menu.BackColor = Color.Yellow;
            }
            else if (profil_menu.BackColor == Color.Red)
            {
                profil_menu.BackColor = Color.Yellow; guru_menu.BackColor = Color.Red;
                kelas_menu.BackColor = Color.BurlyWood; mapel_menu.BackColor = Color.Magenta;
                siswa_menu.BackColor = Color.DeepSkyBlue; eskul_menu.BackColor = Color.CadetBlue;
                nilai_menu.BackColor = Color.LimeGreen; deskripsi_menu.BackColor = Color.Lavender;
            }
            else if (profil_menu.BackColor == Color.Yellow)
            {
                profil_menu.BackColor = Color.Lavender; guru_menu.BackColor = Color.Yellow;
                kelas_menu.BackColor = Color.Red; mapel_menu.BackColor = Color.BurlyWood;
                siswa_menu.BackColor = Color.Magenta; eskul_menu.BackColor = Color.DeepSkyBlue;
                nilai_menu.BackColor = Color.CadetBlue; deskripsi_menu.BackColor = Color.LimeGreen;
            }
            else if (profil_menu.BackColor == Color.Lavender)
            {
                profil_menu.BackColor = Color.LimeGreen; guru_menu.BackColor = Color.Lavender;
                kelas_menu.BackColor = Color.Yellow; mapel_menu.BackColor = Color.Red;
                siswa_menu.BackColor = Color.BurlyWood; eskul_menu.BackColor = Color.Magenta;
                nilai_menu.BackColor = Color.DeepSkyBlue; deskripsi_menu.BackColor = Color.CadetBlue;
            }
            else if (profil_menu.BackColor == Color.LimeGreen)
            {
                profil_menu.BackColor = Color.CadetBlue; guru_menu.BackColor = Color.LimeGreen;
                kelas_menu.BackColor = Color.Lavender; mapel_menu.BackColor = Color.Yellow;
                siswa_menu.BackColor = Color.Red; eskul_menu.BackColor = Color.BurlyWood;
                nilai_menu.BackColor = Color.Magenta; deskripsi_menu.BackColor = Color.DeepSkyBlue;
            }
            else
            {
                profil_menu.BackColor = Color.DeepSkyBlue; guru_menu.BackColor = Color.CadetBlue;
                kelas_menu.BackColor = Color.LimeGreen; mapel_menu.BackColor = Color.Lavender;
                siswa_menu.BackColor = Color.Yellow; eskul_menu.BackColor = Color.Red;
                nilai_menu.BackColor = Color.BurlyWood; deskripsi_menu.BackColor = Color.Magenta;
            }
        }
        
       
        //END CLASS
    }
}
