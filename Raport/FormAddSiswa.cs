using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        string passKode;
        DateTime passLahir, passMasuk;
        string loadValue;
        
        public FormAddSiswa()
        {
            InitializeComponent();
            getCombo();
        }

        //Passing Value From FormSiswa
        public string valueLoad
        {
            get { return loadValue; }
            set { loadValue = value; }
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
            this.tahun_lbl.Text = diterima_date.Value.Year.ToString();
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
                this.cond = "status_kelas = 'Aktif' AND tahun_ajaran LIKE '"+ tahun_lbl.Text +"%'";
                string sortby = "nama_kelas";

                dikelas_combo.DataSource = db.setCombo(idValue, dispValue, table, cond, sortby);
                dikelas_combo.DisplayMember = "valueDisplay";
                dikelas_combo.ValueMember = "valueID";
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
                MessageBox.Show("NIS Siswa harus diisi");
                nis_txt.Focus();
            }
            else if (string.IsNullOrWhiteSpace(namaSiswa_txt.Text) && namaSiswa_txt.Text.Length >= 0)
            {
                MessageBox.Show("Nama Siswa harus diisi");
                namaSiswa_txt.Focus();
            }
            else if (string.IsNullOrWhiteSpace(tempatLahir_txt.Text) && tempatLahir_txt.Text.Length >= 0)
            {
                MessageBox.Show("Tempat Lahir harus diisi");
                tempatLahir_txt.Focus();
            }
            else if (ttl_date.Checked == false)
            {
                MessageBox.Show("Tanggal lahir belum dipilih");
                ttl_date.Focus();
            }
            else if (kelamin_combo.Text == "")
            {
                MessageBox.Show("Jenis Kelamin belum dipilih");
                kelamin_combo.Focus();
            }
            else if (agama_combo.Text == "")
            {
                MessageBox.Show("Agama belum dipilih");
                agama_combo.Focus();
            }
            else if (status_combo.Text == "")
            {
                MessageBox.Show("Status anak belum dipilih");
                status_combo.Focus();
            }
            else if (anakke_combo.Text == "")
            {
                MessageBox.Show("Anak ke- belum dipilih");
                anakke_combo.Focus();
            }
            else if (string.IsNullOrWhiteSpace(asalSekolah_txt.Text) && asalSekolah_txt.Text.Length >= 0)
            {
                MessageBox.Show("Asal Sekolah harus diisi");
                asalSekolah_txt.Focus();
            }
            else if (dikelas_combo.Text == "")
            {
                MessageBox.Show("Kelas Belum dipilih");
                dikelas_combo.Focus();
            }
            else if (string.IsNullOrWhiteSpace(alamatSiswa_txt.Text) && alamatSiswa_txt.Text.Length >= 0)
            {
                MessageBox.Show("Alamat Siswa harus diisi");
                alamatSiswa_txt.Focus();
            }
            else if (string.IsNullOrWhiteSpace(namaAyah_txt.Text) && namaAyah_txt.Text.Length >= 0)
            {
                MessageBox.Show("Nama Ayah harus diisi");
                namaAyah_txt.Focus();
            }
            else if (string.IsNullOrWhiteSpace(namaIbu_txt.Text) && namaIbu_txt.Text.Length >= 0)
            {
                MessageBox.Show("Nama Ibu harus diisi");
                namaIbu_txt.Focus();
            }
            else if (string.IsNullOrWhiteSpace(pekerjaanAyah_txt.Text) && pekerjaanAyah_txt.Text.Length >= 0)
            {
                MessageBox.Show("Pekerjaan Ayah harus diisi");
                pekerjaanAyah_txt.Focus();
            }
            else if (string.IsNullOrWhiteSpace(pekerjaanIbu_txt.Text) && pekerjaanIbu_txt.Text.Length >= 0)
            {
                MessageBox.Show("Pekerjaan Ibu harus diisi");
                pekerjaanIbu_txt.Focus();
            }
            else if (string.IsNullOrWhiteSpace(alamatOrtu_txt.Text) && alamatOrtu_txt.Text.Length >= 0)
            {
                MessageBox.Show("Alamat Ortu harus diisi");
                alamatOrtu_txt.Focus();
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
                            "', '" + this.namaSiswa_txt.Text +
                            "', '" + this.nisn_txt.Text +
                            "', '" + this.tempatLahir_txt.Text +
                            "', '" + this.ttl_date.Text +
                            "', '" + this.kelamin_combo.Text +
                            "', '" + this.agama_combo.Text +
                            "', '" + this.status_combo.Text +
                            "', '" + this.anakke_combo.Text +
                            "', '" + this.alamatSiswa_txt.Text +
                            "', '" + this.telpSiswa_txt.Text +
                            "', '" + this.asalSekolah_txt.Text +
                            "', '" + this.diterima_date.Text + "', DEFAULT";
                db.insertData(table, field);

                //insert ke tabel orangtua
                string table2 = "orangtua";
                string field2 = "DEFAULT, '" + this.nis_txt.Text +
                                "', '" + this.namaAyah_txt.Text +
                                "', '" + this.namaIbu_txt.Text +
                                "', '" + this.alamatOrtu_txt.Text +
                                "', '" + this.telpOrtu_txt.Text +
                                "', '" + this.pekerjaanAyah_txt.Text +
                                "', '" + this.pekerjaanIbu_txt.Text +
                                "', '" + this.namaWali_txt.Text +
                                "', '" + this.alamatWali_txt.Text +
                                "', '" + this.pekerjaanWali_txt.Text + "'";
                db.insertData(table2, field2);

                //insert ke tabel detailkelassiswa
                string table3 = "detailkelassiswa";
                string field3 = "DEFAULT, '" + dikelas +
                                "', '" + this.nis_txt.Text + "', 'Data Siswa'";
                db.insertData(table3, field3);

                MessageBox.Show("Data Siswa '" + this.namaSiswa_txt.Text + "' disimpan");
                FormSiswa fSiswa = new FormSiswa();
                fSiswa.loadData();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kesalahan Dalam Input Data");
            }
        }

        private void updateData()
        {
            try
            {
                //update ke tabel siswa
                this.table = "siswa";
                this.field = "nis_siswa ='" + this.nis_txt.Text +
                        "', nama_siswa ='" + this.namaSiswa_txt.Text +
                        "', nisn_siswa ='" + this.nisn_txt.Text +
                        "', tempat_lahir ='" + this.tempatLahir_txt.Text +
                        "', tanggal_lahir ='" + this.ttl_date.Text +
                        "', jenis_kelamin ='" + this.kelamin_combo.Text +
                        "', agama ='" + this.agama_combo.Text +
                        "', status_keluarga ='" + this.status_combo.Text +
                        "', anak_ke ='" + this.anakke_combo.Text +
                        "', alamat ='" + this.alamatSiswa_txt.Text +
                        "', no_telp ='" + this.telpSiswa_txt.Text +
                        "', asal_sekolah ='" + this.asalSekolah_txt.Text +
                        "', tanggal_masuk ='" + this.diterima_date.Text + "'";
                this.cond = "nis_siswa = '" + nis_lbl.Text + "'";
                db.updateData(table, field, cond);

                //update ke tabel orangtua
                string table2 = "orangtua";
                string field2 = "nama_ayah = '" + this.namaAyah_txt.Text +
                                "', nama_ibu = '" + this.namaIbu_txt.Text +
                                "', alamat_ortu = '" + this.alamatOrtu_txt.Text +
                                "', no_telp = '" + this.telpOrtu_txt.Text +
                                "', pekerjaan_ayah = '" + this.pekerjaanAyah_txt.Text +
                                "', pekerjaan_ibu ='" + this.pekerjaanIbu_txt.Text +
                                "', nama_wali = '" + this.namaWali_txt.Text +
                                "', alamat_wali = '" + this.alamatWali_txt.Text +
                                "', pekerjaan_wali = '" + this.pekerjaanWali_txt.Text + "'";
                string cond2 = "nis_siswa = '" + nis_txt.Text + "'";
                db.updateData(table2, field2, cond2);

                //update ke tabel detailkelassiswa
                string dikelas = this.dikelas_combo.SelectedValue.ToString();
                string table3 = "detailkelassiswa";
                string field3 = "kode_kelas = '" + dikelas + "'";
                string cond3 = "id_detail = '"+ id_lbl.Text +"'";
                db.updateData(table3, field3, cond3);
                MessageBox.Show("Edit Data Siswa Berhasil \n Data Tersimpan");
                FormSiswa fSiswa = new FormSiswa();
                fSiswa.loadData();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Menyimpan Data
        private void save_btn_Click(object sender, EventArgs e)
        {
            dataFilled();
        }

        //Update Data siswa
        private void update_btn_Click(object sender, EventArgs e)
        {
            dataFilled();
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
        
        //Event Jenis Kelamin Siswa

        //Event Agama Siswa

        //Event Status Anak

        //Event Anak Ke-

        //Event Telepon Siswa

        //Event Asal Sekolah Siswa

        //Event Tanggal diterima

        //Event diterima di kelas
        private void diterima_date_ValueChanged(object sender, EventArgs e)
        {
            getTahunAjaran();
        }

        //Event Alamat Siswa

        //Event Nama Ayah
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