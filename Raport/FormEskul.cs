using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Raport
{
    public partial class FormEskul : Form
    {
        MySqlConnection myConn = Function.getKoneksi();
        Function db = new Function();
        private string table, cond, field;
        public string getTahun;
        DataGridViewComboBoxColumn ekskul1, ekskul2, ekskul3;
        DataGridViewTextBoxColumn nis, nama, keterangan1, keterangan2, keterangan3;

        public string passTahun
        {
            get { return getTahun; }
            set { getTahun = value; }
        }

        public FormEskul()
        {
            InitializeComponent();
            loadData();
        }

        private void FormEskul_Load(object sender, EventArgs e)
        {
            fillKelas();
        }

        private void loadData()
        {
            try
            {
                this.field = "kode_eskul as 'Kode', nama_eskul as 'Nama Eskul'";
                this.table = "ekstrakurikuler";
                this.cond = "keterangan = 'Aktif' ORDER BY nama_eskul ASC";
                DataTable kelas = db.GetDataTable(field, table, cond);
                this.dataEskul_grid.DataSource = kelas;
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

        private void add_btn_Click(object sender, EventArgs e)
        {
            dataEskul_grid.Enabled = false; add_btn.Enabled = false;
            delete_btn.Enabled = false; edit_btn.Enabled = false;
            save_btn.Enabled = true; cancel_btn.Enabled = true;
            kode_txt.Enabled = true; nama_txt.Enabled = true;
            kode_txt.ResetText(); nama_txt.ResetText();
        }
        
        private void save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(kode_txt.Text) && kode_txt.Text.Length >= 0)
                {
                    MessageBox.Show("Kode Eskul tidak Boleh Kosong");
                    kode_txt.Focus();
                }
                else if (string.IsNullOrWhiteSpace(nama_txt.Text) && nama_txt.Text.Length >= 0)
                {
                    MessageBox.Show("Nama Eskul tidak Boleh Kosong");
                    kode_txt.Focus();
                }
                else
                {
                    this.table = "ekstrakurikuler";
                    this.field = "'" + kode_txt.Text.Replace("'", "''") + "', '" + nama_txt.Text.Replace("'", "''") + "', DEFAULT";
                    db.insertData(table, field);
                    loadData();
                    MessageBox.Show("Eskul '" + nama_txt.Text + "'\n Berhasil di buat ");

                    add_btn.Enabled = true;
                    dataEskul_grid.Enabled = true;
                    save_btn.Enabled = false;
                    cancel_btn.Enabled = false;
                    kode_txt.Enabled = false;
                    nama_txt.Enabled = false;
                    kode_txt.ResetText();
                    nama_txt.ResetText();
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
        
        private void cancel_btn_Click(object sender, EventArgs e)
        {
            dataEskul_grid.Enabled = true;
            add_btn.Enabled = true;
            save_btn.Enabled = false;
            cancel_btn.Enabled = false;
            kode_txt.Enabled = false;
            nama_txt.Enabled = false;
            delete_btn.Enabled = false;
            edit_btn.Enabled = false;
            kode_txt.ResetText();
            nama_txt.ResetText();
        }
        
        private void dataEskul_grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if ((e.RowIndex >= 0) && (e.RowIndex != -1))
                {
                    DataGridViewRow row = this.dataEskul_grid.Rows[e.RowIndex];
                    string getkode = row.Cells["Kode"].Value.ToString();
                    this.nama_txt.Text = row.Cells["Nama Eskul"].Value.ToString();
                    this.kode_txt.Text = getkode;
                    this.kode_lbl.Text = getkode;

                    kode_txt.Enabled = true;
                    nama_txt.Enabled = true;
                    cancel_btn.Enabled = true;
                    edit_btn.Enabled = true;
                    delete_btn.Enabled = true;
                    add_btn.Enabled = false;
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

        private void edit_btn_Click(object sender, EventArgs e)
        {
            try
            {
                this.table = "ekstrakurikuler";
                this.field = "kode_eskul ='" + this.kode_txt.Text.Replace("'", "''") +
                        "', nama_eskul ='" + this.nama_txt.Text.Replace("'", "''") + "'";
                this.cond = "kode_eskul = '" + kode_lbl.Text + "'";

                db.updateData(table, field, cond);
                loadData();
                MessageBox.Show("Edit Data Eskul  Berhasil \n Data Tersimpan");
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

        private void delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialog = MessageBox.Show("Hapus Eskul '" + nama_txt.Text + "'?",
               "Hapus Data", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    this.table = "ekstrakurikuler";
                    this.field = "keterangan = 'Tidak Aktif'";
                    this.cond = "kode_eskul = '" + kode_lbl.Text + "'";
                    db.updateData(table, field, cond);
                    loadData();
                    MessageBox.Show("Data eskul '" + nama_txt.Text + "' Terhapus");
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
        
        private void kelas_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (kelas_combo.Text.Equals(""))
            {
                ekskulSiswa_grid.Columns.Clear(); ekskulSiswa_grid.Rows.Clear();
            }
            else if (!kelas_combo.Text.Equals(""))
            {
                viewMemberKelas();
            }
        }

        public void fillKelas()
        {
            try
            {
                string idValue = "kode_kelas";
                string dispValue = "nama_kelas";
                string sortby = "nama_kelas";
                table = "kelas";
                cond = "status_kelas = 'Aktif' AND tahun_ajaran = '" + getTahun + "'";
                kelas_combo.DataSource = db.setCombo(idValue, dispValue, table, cond, sortby);
                kelas_combo.DisplayMember = "valueDisplay"; kelas_combo.ValueMember = "valueID";
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

        private void viewMemberKelas()
        {
            try
            {
                //ekskulSiswa_grid.DataSource = null;
                ekskulSiswa_grid.Columns.Clear(); ekskulSiswa_grid.Rows.Clear();
                //ekskulSiswa_grid.ColumnCount = 8;
                ekskul1 = new DataGridViewComboBoxColumn();
                ekskul1.Name = "ekskul1";
                ekskul1.HeaderText = "Ekskul 1";
                ekskul2 = new DataGridViewComboBoxColumn();
                ekskul2.Name = "ekskul2";
                ekskul2.HeaderText = "Ekskul 2";
                ekskul3 = new DataGridViewComboBoxColumn();
                ekskul3.Name = "ekskul3";
                ekskul3.HeaderText = "Ekskul 3";
                nis = new DataGridViewTextBoxColumn();
                nis.Name = "nis_siswa";
                nis.HeaderText = "No. Induk";
                nama = new DataGridViewTextBoxColumn();
                nama.Name = "nama_siswa";
                nama.HeaderText = "Nama Siswa";
                keterangan1 = new DataGridViewTextBoxColumn();
                keterangan1.Name = "keterangan1";
                keterangan1.HeaderText = "Keterangan";
                keterangan2 = new DataGridViewTextBoxColumn();
                keterangan2.Name = "keterangan2";
                keterangan2.HeaderText = "Keterangan";
                keterangan3 = new DataGridViewTextBoxColumn();
                keterangan3.Name = "keterangan3";
                keterangan3.HeaderText = "Keterangan";
                ekskulSiswa_grid.Columns.Add(nis);
                ekskulSiswa_grid.Columns.Add(nama);
                ekskulSiswa_grid.Columns.Add(ekskul1);
                ekskulSiswa_grid.Columns.Add(keterangan1);
                ekskulSiswa_grid.Columns.Add(ekskul2);
                ekskulSiswa_grid.Columns.Add(keterangan2);
                ekskulSiswa_grid.Columns.Add(ekskul3);
                ekskulSiswa_grid.Columns.Add(keterangan3);

                string kodeKelas = kelas_combo.SelectedValue.ToString();
                table = "detailkelassiswa INNER JOIN siswa USING (nis_siswa)";
                field = "detailkelassiswa.nis_siswa as 'NIS', nama_siswa as 'Nama Siswa'";
                cond = "kode_kelas= '" + kodeKelas + "' AND (keterangan = 'Data Siswa' OR keterangan = 'Data Kelas')";
                DataTable result = db.GetDataTable(field, table, cond);
                foreach (DataRow row in result.Rows)
                {
                    string[] row1 = new string[] {
                        row["NIS"].ToString(),
                        row["Nama Siswa"].ToString(),
                        "", "", "", "","", ""
                    };
                    ekskulSiswa_grid.Rows.Add(row1);
                }

                string idValue = "kode_eskul";
                string dispValue = "nama_eskul";
                string sortby = "nama_eskul";
                table = "ekstrakurikuler";
                cond = "keterangan = 'Aktif'";
                ekskul1.DataSource = db.setCombo(idValue, dispValue, table, cond, sortby);
                ekskul1.DisplayMember = "valueDisplay"; ekskul1.ValueMember = "valueID";
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

        private void ekskulSiswa_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void ekskulSiswa_grid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in ekskulSiswa_grid.Rows)
            {
                for (int i = 3; i <= 7; i++)
                {
                    row.Cells[i].ReadOnly = true;
                }

                if (Convert.ToString(row.Cells[2].Value) == "")
                {
                    row.Cells[3].Value = "";
                    row.Cells[4].Value = "";
                    row.Cells[5].Value = "";
                    row.Cells[6].Value = "";
                    row.Cells[7].Value = "";
                }
                else if (Convert.ToString(row.Cells[2].Value) != "")
                {
                    row.Cells[3].ReadOnly = false;
                    row.Cells[4].ReadOnly = false;
                    string idValue = "kode_eskul";
                    string dispValue = "nama_eskul";
                    string sortby = "nama_eskul";
                    table = "ekstrakurikuler";
                    cond = "keterangan = 'Aktif' AND kode_eskul != '" + row.Cells[2].Value.ToString() + "'";
                    ekskul2.DataSource = db.setCombo(idValue, dispValue, table, cond, sortby);
                    ekskul2.DisplayMember = "valueDisplay"; ekskul2.ValueMember = "valueID";
                }

                if (Convert.ToString(row.Cells[4].Value) == "")
                {
                    row.Cells[5].Value = "";
                    row.Cells[6].Value = "";
                    row.Cells[7].Value = "";
                }
                else if (Convert.ToString(row.Cells[4].Value) != "")
                {
                    row.Cells[5].ReadOnly = false;
                    row.Cells[6].ReadOnly = false;
                    string idValue = "kode_eskul";
                    string dispValue = "nama_eskul";
                    string sortby = "nama_eskul";
                    table = "ekstrakurikuler";
                    cond = "keterangan = 'Aktif' AND kode_eskul != '" + row.Cells[2].Value.ToString() +
                           "' AND kode_eskul != '" + row.Cells[4].Value.ToString() + "'";
                    ekskul3.DataSource = db.setCombo(idValue, dispValue, table, cond, sortby);
                    ekskul3.DisplayMember = "valueDisplay"; ekskul3.ValueMember = "valueID";
                }

                if (Convert.ToString(row.Cells[6].Value) == "")
                {
                    row.Cells[7].Value = "";
                }
                else if (Convert.ToString(row.Cells[6].Value) != "")
                {
                    row.Cells[7].ReadOnly = false;
                }
            }
        }

        private void ekskulSiswa_grid_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.ekskulSiswa_grid.Rows[e.RowIndex];
                if (Convert.ToString(row.Cells[2].Value) != "")
                {
                    row.Cells[3].Value = "";
                    row.Cells[4].Value = "";
                    row.Cells[5].Value = "";
                    row.Cells[6].Value = "";
                    row.Cells[7].Value = "";
                }

                if (Convert.ToString(row.Cells[4].Value) != "")
                {
                    row.Cells[5].Value = "";
                    row.Cells[6].Value = "";
                    row.Cells[7].Value = "";
                }

                if (Convert.ToString(row.Cells[6].Value) != "")
                {
                    row.Cells[7].Value = "";
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
        //END CLASS
    }
}
