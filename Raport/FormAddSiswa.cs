using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Raport
{
    public partial class FormAddSiswa : Form
    {
        MySqlConnection myConn = Function.getKoneksi();
        Function db = new Function();
        private string table;
        private string field;
        private string cond;
        DateTime passLahir, passMasuk;
        public string loadValue, tahuj, passKode;
        
        public FormAddSiswa()
        {
            InitializeComponent();
            getCombo();
            tahun_lbl.Text = tahuj;
        }

        //Passing Value From FormSiswa
        public string valueLoad
        {
            get { return loadValue; }
            set { loadValue = value; }
        }

        public string tahun_ajaran
        {
            get { return tahuj; }
            set { tahuj = value; }
        }
        
        public string valueKelas
        {
            get { return passKode; }
            set { passKode = value; }
        }

        public DateTime valueLahir
        {
            get { return passLahir; }
            set { passLahir = value; }
        }

        public DateTime valueMasuk
        {
            get { return passMasuk; }
            set { passMasuk = value; }
        }

        //Load Siswa untuk aksi tambah atau update siswa
        private void FormAddSiswa_Load(object sender, EventArgs e)
        {
            tahun_lbl.Text = tahuj;
            if (loadValue == "Update")
            {
                getTahunAjaran();
                ttl_date.Value = passLahir;
                diterima_date.Value = passMasuk;
            } 
            else if (loadValue != "Update")
            {
                getTahunAjaran();
            }
        }
        
        //Menentukan Kelas sesuai dengan tahun ajaran pendaftaran 
        public void getTahunAjaran()
        {
            fillCombo();
            dikelas_combo.Text = passKode;
        }

        //Mengisi nilai Combobox di Form      
        public void getCombo()
        {
            status_combo.DataSource = db.getStatusAnak();
            status_combo.DisplayMember = "valueDisplay";

            kelamin_combo.DataSource = db.getKelamin();
            kelamin_combo.DisplayMember = "valueDisplay";
            
            anakke_combo.DataSource = db.getAngka();
            anakke_combo.DisplayMember = "valueDisplay";

            agama_combo.DataSource = db.getAgama();
            agama_combo.DisplayMember = "valueDisplay";
        }

        public void fillCombo()
        {
            try
            {
                string idValue = "kode_kelas";
                string dispValue = "nama_kelas";
                this.table = "kelas";
                this.cond = "status_kelas = 'Aktif' AND tahun_ajaran = '"+ tahun_lbl.Text +"'";
                string sortby = "nama_kelas";

                dikelas_combo.DataSource = db.setCombo(idValue, dispValue, table, cond, sortby);
                dikelas_combo.DisplayMember = "valueDisplay";
                dikelas_combo.ValueMember = "valueID";
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

        void dataFilled()
        {            
            if (string.IsNullOrWhiteSpace(nis_txt.Text) && nis_txt.Text.Length >= 0)
            {
                nis_txt.Focus();
                MessageBox.Show("NIS Siswa harus diisi");
            }
            else if (string.IsNullOrWhiteSpace(namaSiswa_txt.Text) && namaSiswa_txt.Text.Length >= 0)
            {
                namaSiswa_txt.Focus();
                MessageBox.Show("Nama Siswa harus diisi");
            }
            else if (string.IsNullOrWhiteSpace(tempatLahir_txt.Text) && tempatLahir_txt.Text.Length >= 0)
            {
                tempatLahir_txt.Focus();
                MessageBox.Show("Tempat Lahir harus diisi");
            }
            else if (ttl_date.Checked == false)
            {
                ttl_date.Focus();
                MessageBox.Show("Tanggal lahir belum dipilih");
            }
            else if (kelamin_combo.Text == "")
            {
                kelamin_combo.Focus();
                MessageBox.Show("Jenis Kelamin belum dipilih");
            }
            else if (agama_combo.Text == "")
            {
                agama_combo.Focus();
                MessageBox.Show("Agama belum dipilih");
            }
            else if (status_combo.Text == "")
            {
                status_combo.Focus();
                MessageBox.Show("Status anak belum dipilih");
            }
            else if (anakke_combo.Text == "")
            {
                anakke_combo.Focus();
                MessageBox.Show("Anak ke- belum dipilih");
            }
            else if (string.IsNullOrWhiteSpace(asalSekolah_txt.Text) && asalSekolah_txt.Text.Length >= 0)
            {
                asalSekolah_txt.Focus();
                MessageBox.Show("Asal Sekolah harus diisi");
            }
            else if (dikelas_combo.Text == "")
            {
                dikelas_combo.Focus();
                MessageBox.Show("Kelas Belum dipilih");
            }
            else if (string.IsNullOrWhiteSpace(alamatSiswa_txt.Text) && alamatSiswa_txt.Text.Length >= 0)
            {
                alamatSiswa_txt.Focus();
                MessageBox.Show("Alamat Siswa harus diisi");
            }
            else if (string.IsNullOrWhiteSpace(namaAyah_txt.Text) && namaAyah_txt.Text.Length >= 0)
            {
                namaAyah_txt.Focus();
                MessageBox.Show("Nama Ayah harus diisi");
            }
            else if (string.IsNullOrWhiteSpace(namaIbu_txt.Text) && namaIbu_txt.Text.Length >= 0)
            {
                namaIbu_txt.Focus();
                MessageBox.Show("Nama Ibu harus diisi");
            }
            else if (string.IsNullOrWhiteSpace(pekerjaanAyah_txt.Text) && pekerjaanAyah_txt.Text.Length >= 0)
            {
                pekerjaanAyah_txt.Focus();
                MessageBox.Show("Pekerjaan Ayah harus diisi");
            }
            else if (string.IsNullOrWhiteSpace(pekerjaanIbu_txt.Text) && pekerjaanIbu_txt.Text.Length >= 0)
            {
                pekerjaanIbu_txt.Focus();
                MessageBox.Show("Pekerjaan Ibu harus diisi");
            }
            else if (string.IsNullOrWhiteSpace(alamatOrtu_txt.Text) && alamatOrtu_txt.Text.Length >= 0)
            {
                alamatOrtu_txt.Focus();
                MessageBox.Show("Alamat Ortu harus diisi");
            }
            else if (loadValue == "Update")
            {
                updateData();
            }
            else if (loadValue != "Update")
            {
                insertData();
            }
        }

        private void insertData()
        {
            try
            {
                //insert ke tabel siswa
                string dikelas = this.dikelas_combo.SelectedValue.ToString();
                this.table = "siswa";
                this.field = "'" + this.nis_txt.Text +
                            "', '" + this.namaSiswa_txt.Text.Replace("'", "''") +
                            "', '" + this.nisn_txt.Text +
                            "', '" + this.tempatLahir_txt.Text.Replace("'", "''") +
                            "', '" + this.ttl_date.Text +
                            "', '" + this.kelamin_combo.Text +
                            "', '" + this.agama_combo.Text +
                            "', '" + this.status_combo.Text +
                            "', '" + this.anakke_combo.Text +
                            "', '" + this.alamatSiswa_txt.Text.Replace("'", "''") +
                            "', '" + this.telpSiswa_txt.Text +
                            "', '" + this.asalSekolah_txt.Text.Replace("'", "''") +
                            "', '" + this.diterima_date.Text + "', DEFAULT";
                db.insertData(table, field);

                //insert ke tabel orangtua
                string table2 = "orangtua";
                string field2 = "DEFAULT, '" + this.nis_txt.Text +
                                "', '" + this.namaAyah_txt.Text.Replace("'", "''") +
                                "', '" + this.namaIbu_txt.Text.Replace("'", "''") +
                                "', '" + this.alamatOrtu_txt.Text.Replace("'", "''") +
                                "', '" + this.telpOrtu_txt.Text +
                                "', '" + this.pekerjaanAyah_txt.Text.Replace("'", "''") +
                                "', '" + this.pekerjaanIbu_txt.Text.Replace("'", "''") +
                                "', '" + this.namaWali_txt.Text.Replace("'", "''") +
                                "', '" + this.alamatWali_txt.Text.Replace("'", "''") +
                                "', '" + this.pekerjaanWali_txt.Text.Replace("'", "''") + "'";
                db.insertData(table2, field2);

                //insert ke tabel detailkelassiswa
                string table3 = "detailkelassiswa";
                string field3 = "DEFAULT, '" + dikelas +
                                "', '" + this.nis_txt.Text + "', 'Data Siswa'";
                db.insertData(table3, field3);
                FormSiswa fSiswa = new FormSiswa();
                fSiswa.loadData();
                MessageBox.Show("Data Siswa '" + this.namaSiswa_txt.Text + "' disimpan");
                this.Close();
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

        private void updateData()
        {
            try
            {
                //update ke tabel siswa
                this.table = "siswa";
                this.field = "nis_siswa ='" + this.nis_txt.Text +
                        "', nama_siswa ='" + this.namaSiswa_txt.Text.Replace("'", "''") +
                        "', nisn_siswa ='" + this.nisn_txt.Text +
                        "', tempat_lahir ='" + this.tempatLahir_txt.Text.Replace("'", "''") +
                        "', tanggal_lahir ='" + this.ttl_date.Text +
                        "', jenis_kelamin ='" + this.kelamin_combo.Text +
                        "', agama ='" + this.agama_combo.Text +
                        "', status_keluarga ='" + this.status_combo.Text +
                        "', anak_ke ='" + this.anakke_combo.Text +
                        "', alamat ='" + this.alamatSiswa_txt.Text.Replace("'", "''") +
                        "', no_telp ='" + this.telpSiswa_txt.Text +
                        "', asal_sekolah ='" + this.asalSekolah_txt.Text.Replace("'", "''") +
                        "', tanggal_masuk ='" + this.diterima_date.Text + "'";
                this.cond = "nis_siswa = '" + nis_lbl.Text + "'";
                db.updateData(table, field, cond);

                //update ke tabel orangtua
                string table2 = "orangtua";
                string field2 = "nama_ayah = '" + this.namaAyah_txt.Text.Replace("'", "''") +
                                "', nama_ibu = '" + this.namaIbu_txt.Text.Replace("'", "''") +
                                "', alamat_ortu = '" + this.alamatOrtu_txt.Text.Replace("'", "''") +
                                "', no_telp = '" + this.telpOrtu_txt.Text +
                                "', pekerjaan_ayah = '" + this.pekerjaanAyah_txt.Text.Replace("'", "''") +
                                "', pekerjaan_ibu ='" + this.pekerjaanIbu_txt.Text.Replace("'", "''") +
                                "', nama_wali = '" + this.namaWali_txt.Text.Replace("'", "''") +
                                "', alamat_wali = '" + this.alamatWali_txt.Text.Replace("'", "''") +
                                "', pekerjaan_wali = '" + this.pekerjaanWali_txt.Text.Replace("'", "''") + "'";
                string cond2 = "nis_siswa = '" + nis_txt.Text + "'";
                db.updateData(table2, field2, cond2);

                //update ke tabel detailkelassiswa
                string dikelas = this.dikelas_combo.SelectedValue.ToString();
                string table3 = "detailkelassiswa";
                string field3 = "kode_kelas = '" + dikelas + "'";
                string cond3 = "id_detail = '"+ id_lbl.Text +"'";
                db.updateData(table3, field3, cond3);
                FormSiswa fSiswa = new FormSiswa();
                fSiswa.loadData();
                MessageBox.Show("Edit Data Siswa Berhasil \n Data Tersimpan");
                this.Close();
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

        //Menyimpan Data
        private void save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                dataFilled();
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

        //Update Data siswa
        private void update_btn_Click(object sender, EventArgs e)
        {
            try
            {
                dataFilled();
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

        //Aksi Tombol Cancel
        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Aksi Tombol Delete
        private void delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialog = MessageBox.Show("Hapus Data Siswa '" + namaSiswa_txt.Text + "' ?",
                "Hapus Data", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    this.table = "siswa";
                    this.field = "status_siswa = 'Tidak Aktif'";
                    this.cond = "nis_siswa = '" + nis_txt.Text + "'";
                    db.updateData(table, field, cond);
                    MessageBox.Show("Data Siswa '" + namaSiswa_txt.Text + "' Terhapus");
                    this.Close();
                }
                else if (dialog == DialogResult.No)
                {
                    CancelEventArgs batal = new CancelEventArgs();
                    batal.Cancel = true;
                }
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

        //Event NIS Siswa
        private void nis_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsDigit(e.KeyChar) == false
                && (int)e.KeyChar != (int)Keys.Back
                && (char)e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void nis_txt_DoubleClick(object sender, EventArgs e)
        {
            nis_txt.ReadOnly = false;
            nis_txt.BackColor = SystemColors.Window;
        }

        //Event NISN Siswa
        private void nisn_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsDigit(e.KeyChar) == false
                && (int)e.KeyChar != (int)Keys.Back))
            {
                e.Handled = true;
            }
        }

        //Event Nama Siswa
        private void namaSiswa_txt_TextChanged(object sender, EventArgs e)
        {
            string nama = this.namaSiswa_txt.Text;
            this.namaSiswa_txt.Text = db.capitalizeWord(nama);
            namaSiswa_txt.Select(nama.Length, 0);
        }
        
        //Event Tempat Lahir Siswa
        private void tempatLahir_txt_TextChanged(object sender, EventArgs e)
        {
            string tempat = this.tempatLahir_txt.Text;
            this.tempatLahir_txt.Text = db.capitalizeWord(tempat);
            tempatLahir_txt.Select(tempat.Length, 0);
        }
        
        //Event Tanggal Lahir Siswa
        private void ttl_date_ValueChanged(object sender, EventArgs e)
        {
            ttl_date.Checked = true;
        }

        private void namaAyah_txt_TextChanged(object sender, EventArgs e)
        {
            string nama = this.namaAyah_txt.Text;
            this.namaAyah_txt.Text = db.capitalizeWord(nama);
            namaAyah_txt.Select(nama.Length, 0);
        }

        //Event Nama Ibu
        private void namaIbu_txt_TextChanged(object sender, EventArgs e)
        {
            string nama = this.namaIbu_txt.Text;
            this.namaIbu_txt.Text = db.capitalizeWord(nama);
            namaIbu_txt.Select(nama.Length, 0);
        }

        //Event Pekerjaan Wali
        private void pekerjaanWali_txt_TextChanged(object sender, EventArgs e)
        {
            string pekerjaan = this.pekerjaanWali_txt.Text;
            this.pekerjaanWali_txt.Text = db.capitalizeWord(pekerjaan);
            pekerjaanWali_txt.Select(pekerjaan.Length, 0);
        }

        //Event Pekerjaan Ibu
        private void pekerjaanIbu_txt_TextChanged(object sender, EventArgs e)
        {
            string pekerjaan = this.pekerjaanIbu_txt.Text;
            this.pekerjaanIbu_txt.Text = db.capitalizeWord(pekerjaan);
            pekerjaanIbu_txt.Select(pekerjaan.Length, 0);
        }

        //Event Pekerjaan Ayah
        private void pekerjaanAyah_txt_TextChanged(object sender, EventArgs e)
        {
            string pekerjaan = this.pekerjaanAyah_txt.Text;
            this.pekerjaanAyah_txt.Text = db.capitalizeWord(pekerjaan);
            pekerjaanAyah_txt.Select(pekerjaan.Length, 0);
        }
        
        //Event Nama Wali
        private void namaWali_txt_TextChanged(object sender, EventArgs e)
        {
            string nama = this.namaWali_txt.Text;
            this.namaWali_txt.Text = db.capitalizeWord(nama);
            namaWali_txt.Select(nama.Length, 0);
        }
    }
}