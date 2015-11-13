using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Raport
{
    public partial class FormUtama : Form
    { 
        MySqlConnection myConn = Function.getKoneksi();
        MySqlDataReader myReader;
        Function db = new Function();
        DataToFile dbToFile = new DataToFile();
        DateTime jamku = new DateTime();
        private string table;
        private string cond;
        private string field;
        private string query;
        public string getLevel, getUser;
        
        public FormUtama()
        {
            Thread t = new Thread(new ThreadStart(SplashStart));
            t.Start();
            Thread.Sleep(3000);
            InitializeComponent();
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
            if (getLevel == "0")
            {
                profil_menu.Enabled = false;
                guru_menu.Enabled = false;
                kelas_menu.Enabled = false;
                mapel_menu.Enabled = false;
                siswa_menu.Enabled = false;
                eskul_menu.Enabled = false;
                user_menu.Enabled = false;
                siswa_menu.Enabled = false;
                user_lbl.Text = getUser;
            }
            else if (getLevel == "1")
            {
                profil_menu.Enabled = true;
                guru_menu.Enabled = true;
                kelas_menu.Enabled = true;
                mapel_menu.Enabled = true;
                siswa_menu.Enabled = true;
                eskul_menu.Enabled = true;
                user_menu.Enabled = true;
                siswa_menu.Enabled = true;
                user_lbl.Text = getUser;
            }

            getCombo();
            jamku = DateTime.Now;
            query = "SELECT * FROM profil_sekolah";
            MySqlCommand getProfil = new MySqlCommand(query, myConn);
            try
            {
                myConn.Open();
                myReader = getProfil.ExecuteReader();
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
        
        //Update jumlah siswa di kelas
        public void jumlahSiswa()
        {
            this.field = "kode_kelas as 'Kode', count(*) as 'Jumlah'";
            this.table = "detailkelassiswa";
            this.cond = "group by kode_kelas";
            string query = "SELECT " + field + " FROM " + table + " " + cond;

            MySqlCommand getGuru = new MySqlCommand(query, myConn);
            myConn.Open();
            MySqlDataReader myReader = getGuru.ExecuteReader();
            while (myReader.Read())
            {
                string kode = myReader.GetString("Kode");
                string value = myReader.GetString("Jumlah");
                string table2 = "kelas";
                string field2 = "jumlah_siswa = '" + value + "'";
                string cond2 = "kode_kelas = '" + kode + "'";
                db.updateData(table2, field2, cond2);
            }
            myConn.Close();
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

        private void LogOut_btn_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Apakah Anda yakin ingin keluar aplikasi?",
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
            DialogResult dialog = MessageBox.Show("Apakah Anda yakin ingin keluar aplikasi?",
            "Exit Aplikasi", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.ExitThread();
                Application.Exit();
            }
            else if (dialog == DialogResult.No)
            {
                CancelEventArgs batal = new CancelEventArgs();
                batal.Cancel = true;
            }
        }
        
        private void kelas_menu_Click(object sender, EventArgs e)
        {
            jumlahSiswa();
            FormKelas fKelas = new FormKelas();
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
            fDesk.ShowDialog();
        }

        private void set_btn_Click(object sender, EventArgs e)
        {
            string tahuj = tahuj_combo.Text.ToString();
            tahuj_combo.Enabled = false;
            set_btn.Enabled = false;
            change_btn.Enabled = true;
            SimpanData_group.Enabled = true; //nanti dihapus
            if (tahuj_combo.Text != "")
            {
                if (getLevel == "0")
                {
                    siswa_menu.Enabled = false;
                    deskripsi_menu.Enabled = true;
                    nilai_menu.Enabled = true;
                    SimpanData_group.Enabled = true;
                }
                else if (getLevel == "1")
                {
                    siswa_menu.Enabled = true;
                    deskripsi_menu.Enabled = true;
                    nilai_menu.Enabled = true;
                    SimpanData_group.Enabled = true;
                }
            }
        }

        private void change_btn_Click(object sender, EventArgs e)
        {
            tahuj_combo.Enabled = true;
            set_btn.Enabled = true;
            change_btn.Enabled = false;

            siswa_menu.Enabled = false;
            deskripsi_menu.Enabled = false;
            nilai_menu.Enabled = false;
            SimpanData_group.Enabled = false;
        }

        private void clock_timer_Tick(object sender, EventArgs e)
        {
            string[] bulan = { "Januari", "Februari", "Maret", "April", "Mei", "Juni", "Juli", "Agustus", "September", "Oktober", "November", "Desember" };
            string[] hari = { "Senin", "Selasa", "Rabu", "Kamis", "Jumat", "Sabtu", "Minggu" };

            string today = DateTime.Today.DayOfWeek.ToString("d");
            if (today == "0")
                hari_lbl.Text = "Minggu";
            else if (today == "1")
                hari_lbl.Text = "Senin";
            else if (today == "2")
                hari_lbl.Text = "Selasa";
            else if (today == "3")
                hari_lbl.Text = "Rabu";
            else if (today == "4")
                hari_lbl.Text = "Kamis";
            else if (today == "5" )
                hari_lbl.Text = "Jumat";
            else if (today == "6")
                hari_lbl.Text = "Sabtu";
            jamku = DateTime.Now;
            tanggal_lbl.Text = DateTime.Today.Day.ToString();
            bulan_lbl.Text = bulan[DateTime.Today.Month - 1] + ", " + DateTime.Today.Year.ToString();
            jam_lbl.Text = jamku.Hour.ToString() + ":" + jamku.Minute.ToString() + 
                            ":" + jamku.Second.ToString();
        }

        private void printDataGuru_btn_Click(object sender, EventArgs e)
        {
            dbToFile.passTahun = tahuj_combo.Text.ToString();
            string tanggal = dbToFile.formattedDate();
            dbToFile.saveDataGuru(print_grid);
            dbToFile.GuruToExcel(print_grid, "Data Guru SMANJAK (" + tanggal + ")", sfDialog);
        }

        private void printDataSiswa_btn_Click(object sender, EventArgs e)
        {
            dbToFile.passTahun = tahuj_combo.Text.ToString();
            string tanggal = dbToFile.formattedDate();
            dbToFile.saveDataSiswa(print_grid);
            dbToFile.SiswaToExcel(print_grid, "Data Siswa SMANJAK (" + tanggal + ")", sfDialog);
        }
        
        private void color_timer_Tick(object sender, EventArgs e)
        {
            if (profil_menu.BackColor == Color.DeepSkyBlue)
            {
                profil_menu.BackColor = Color.Magenta;
                guru_menu.BackColor = Color.DeepSkyBlue;
                kelas_menu.BackColor = Color.CadetBlue;
                mapel_menu.BackColor = Color.LimeGreen;
                siswa_menu.BackColor = Color.Lavender;
                eskul_menu.BackColor = Color.Yellow;
                nilai_menu.BackColor = Color.Red;
                deskripsi_menu.BackColor = Color.BurlyWood;

            }
            else if (profil_menu.BackColor == Color.Magenta)
            {
                profil_menu.BackColor = Color.BurlyWood;
                guru_menu.BackColor = Color.Magenta;
                kelas_menu.BackColor = Color.DeepSkyBlue;
                mapel_menu.BackColor = Color.CadetBlue;
                siswa_menu.BackColor = Color.LimeGreen;
                eskul_menu.BackColor = Color.Lavender;
                nilai_menu.BackColor = Color.Yellow;
                deskripsi_menu.BackColor = Color.Red;
            }
            else if (profil_menu.BackColor == Color.BurlyWood)
            {
                profil_menu.BackColor = Color.Red;
                guru_menu.BackColor = Color.BurlyWood;
                kelas_menu.BackColor = Color.Magenta;
                mapel_menu.BackColor = Color.DeepSkyBlue;
                siswa_menu.BackColor = Color.CadetBlue;
                eskul_menu.BackColor = Color.LimeGreen;
                nilai_menu.BackColor = Color.Lavender;
                deskripsi_menu.BackColor = Color.Yellow;
            }
            else if (profil_menu.BackColor == Color.Red)
            {
                profil_menu.BackColor = Color.Yellow;
                guru_menu.BackColor = Color.Red;
                kelas_menu.BackColor = Color.BurlyWood;
                mapel_menu.BackColor = Color.Magenta;
                siswa_menu.BackColor = Color.DeepSkyBlue;
                eskul_menu.BackColor = Color.CadetBlue;
                nilai_menu.BackColor = Color.LimeGreen;
                deskripsi_menu.BackColor = Color.Lavender;
            }
            else if (profil_menu.BackColor == Color.Yellow)
            {
                profil_menu.BackColor = Color.Lavender;
                guru_menu.BackColor = Color.Yellow;
                kelas_menu.BackColor = Color.Red;
                mapel_menu.BackColor = Color.BurlyWood;
                siswa_menu.BackColor = Color.Magenta;
                eskul_menu.BackColor = Color.DeepSkyBlue;
                nilai_menu.BackColor = Color.CadetBlue;
                deskripsi_menu.BackColor = Color.LimeGreen;
            }
            else if (profil_menu.BackColor == Color.Lavender)
            {
                profil_menu.BackColor = Color.LimeGreen;
                guru_menu.BackColor = Color.Lavender;
                kelas_menu.BackColor = Color.Yellow;
                mapel_menu.BackColor = Color.Red;
                siswa_menu.BackColor = Color.BurlyWood;
                eskul_menu.BackColor = Color.Magenta;
                nilai_menu.BackColor = Color.DeepSkyBlue;
                deskripsi_menu.BackColor = Color.CadetBlue;
            }
            else if (profil_menu.BackColor == Color.LimeGreen)
            {
                profil_menu.BackColor = Color.CadetBlue;
                guru_menu.BackColor = Color.LimeGreen;
                kelas_menu.BackColor = Color.Lavender;
                mapel_menu.BackColor = Color.Yellow;
                siswa_menu.BackColor = Color.Red;
                eskul_menu.BackColor = Color.BurlyWood;
                nilai_menu.BackColor = Color.Magenta;
                deskripsi_menu.BackColor = Color.DeepSkyBlue;
            }
            else
            {
                profil_menu.BackColor = Color.DeepSkyBlue;
                guru_menu.BackColor = Color.CadetBlue;
                kelas_menu.BackColor = Color.LimeGreen;
                mapel_menu.BackColor = Color.Lavender;
                siswa_menu.BackColor = Color.Yellow;
                eskul_menu.BackColor = Color.Red;
                nilai_menu.BackColor = Color.BurlyWood;
                deskripsi_menu.BackColor = Color.Magenta;
            }
        }
        
        //END CLASS
    }
}
