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
        MySqlDataReader myReader;
        MySqlCommand myComm;
        private string table, cond, field, query, kodePramuka;
        public string getTahun;

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
                ekskulSiswa_grid.DataSource = null;
            }
            else if (!kelas_combo.Text.Equals(""))
            {
                query = "select count(kode_eskul) as 'kode', kode_eskul from ekstrakurikuler where nama_eskul LIKE '%Pramuka%'";
                myConn.Open();
                myComm = new MySqlCommand(query, myConn);
                myReader = myComm.ExecuteReader();
                string cekKode = "";
                int status_pramuka = myReader.GetOrdinal("kode_eskul");
                while (myReader.Read())
                {
                    cekKode = myReader.GetString("kode");
                    kodePramuka = myReader.IsDBNull(status_pramuka) ? string.Empty
                                    : myReader.GetString("kode_eskul");
                }
                myConn.Close();
                if (cekKode == "0")
                {
                    MessageBox.Show("Ekstrakurikuler Pramuka belum ada di database");
                }
                else if (cekKode != "0")
                {
                    string pramuka = kodePramuka;
                    if (siswadt().Rows.Count != 0)
                    {
                        foreach (DataRow row in siswadt().Rows)
                        {
                            query = "select count(kode_eskul) as 'kode' from deskripsieskul where kode_eskul = '"
                                    + pramuka + "' AND kode_kelas = '" + kelas_combo.SelectedValue.ToString() +
                                    "' AND nis_siswa ='" + row["NIS"].ToString() + "'";
                            myConn.Open();
                            myComm = new MySqlCommand(query, myConn);
                            myReader = myComm.ExecuteReader();
                            string cekJumlah = "";
                            while (myReader.Read())
                            {
                                cekJumlah = myReader.GetString("kode");
                                if (cekJumlah == "0")
                                {
                                    field = "DEFAULT, '" + kelas_combo.SelectedValue.ToString() + "', '" + row["NIS"].ToString() +
                                    "', '" + kodePramuka + "', 'Aktif sebagai anggota'";
                                    table = "deskripsieskul";
                                    db.insertData(table, field);
                                }
                            }
                            myConn.Close();
                        }
                    }
                }
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

        public DataTable siswadt()
        {
            DataTable result = new DataTable();
            string kodeKelas = kelas_combo.SelectedValue.ToString();
            table = "detailkelassiswa INNER JOIN siswa USING (nis_siswa)";
            field = "detailkelassiswa.nis_siswa as 'NIS', nama_siswa as 'Nama Siswa'";
            cond = "kode_kelas= '" + kodeKelas + "' AND (keterangan = 'Data Siswa' OR keterangan = 'Data Kelas')";
            result = db.GetDataTable(field, table, cond);
            return result;
        }
        
        private void viewMemberKelas()
        {
            try
            {
                ekskulSiswa_grid.DataSource = siswadt();
                string idValue = "kode_eskul";
                string dispValue = "nama_eskul";
                string sortby = "nama_eskul";
                table = "ekstrakurikuler";
                cond = "keterangan = 'Aktif'";
                ekskul1_combo.DataSource = db.setCombo(idValue, dispValue, table, cond, sortby);
                ekskul1_combo.DisplayMember = "valueDisplay"; ekskul1_combo.ValueMember = "valueID";
                ekskul2_combo.DataSource = db.setCombo(idValue, dispValue, table, cond, sortby);
                ekskul2_combo.DisplayMember = "valueDisplay"; ekskul2_combo.ValueMember = "valueID";
                ekskul3_combo.DataSource = db.setCombo(idValue, dispValue, table, cond, sortby);
                ekskul3_combo.DisplayMember = "valueDisplay"; ekskul3_combo.ValueMember = "valueID";
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
        
        private void refresh_toolBtn_Click(object sender, EventArgs e)
        {
            viewMemberKelas();
        }

        private void ekskulSiswa_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string kodeKelas = kelas_combo.SelectedValue.ToString();
            ekskul1_combo.SelectedIndex = -1;
            ekskul2_combo.SelectedIndex = -1;
            ekskul3_combo.SelectedIndex = -1;
            keterangan1_txt.ResetText();
            keterangan2_txt.ResetText();
            keterangan3_txt.ResetText();
            nis_lbl.Text = "0";
            id1_lbl.Text = "null";
            id2_lbl.Text = "null";
            id3_lbl.Text = "null";
            DataGridViewRow row = this.ekskulSiswa_grid.Rows[e.RowIndex];
            nis_lbl.Text = row.Cells[0].Value.ToString();
            this.field = "id_deskripsieskul as 'Detail', kode_eskul as 'Kode', keterangan as 'Ket'";
            this.table = "deskripsieskul";
            this.cond = "nis_siswa = '" + nis_lbl.Text + "' AND kode_kelas =  '" + kodeKelas + "' ORDER BY id_deskripsieskul ASC";
            DataTable ekstra = db.GetDataTable(field, table, cond);
            MessageBox.Show(ekstra.Rows.Count.ToString());
            if (ekstra.Rows.Count == 0)
            {
                group1.Enabled = true;
                ekskul1_combo.Enabled = false;
                group2.Enabled = false;
                group3.Enabled = false;
            }
            else if (ekstra.Rows.Count == 1)
            {
                group1.Enabled = false;
                group2.Enabled = true;
                group3.Enabled = false;
                DataRow row0 = ekstra.Rows[0];
                ekskul1_combo.SelectedValue = row0["Kode"].ToString();
                keterangan1_txt.Text = row0["Ket"].ToString();
                id1_lbl.Text = row0["Detail"].ToString();
            }
            else if (ekstra.Rows.Count == 2)
            {
                group1.Enabled = false;
                group2.Enabled = false;
                group3.Enabled = true;
                DataRow row0 = ekstra.Rows[0];
                ekskul1_combo.SelectedValue = row0["Kode"].ToString();
                keterangan1_txt.Text = row0["Ket"].ToString();
                id1_lbl.Text = row0["Detail"].ToString();
                DataRow row1 = ekstra.Rows[1];
                ekskul2_combo.SelectedValue = row1["Kode"].ToString();
                keterangan2_txt.Text = row1["Ket"].ToString();
                id2_lbl.Text = row1["Detail"].ToString();
            }
            else if (ekstra.Rows.Count == 3)
            {
                group1.Enabled = false;
                group2.Enabled = false;
                group3.Enabled = true;
                DataRow row0 = ekstra.Rows[0];
                ekskul1_combo.SelectedValue = row0["Kode"].ToString();
                keterangan1_txt.Text = row0["Ket"].ToString();
                id1_lbl.Text = row0["Detail"].ToString();
                DataRow row1 = ekstra.Rows[1];
                ekskul2_combo.SelectedValue = row1["Kode"].ToString();
                keterangan2_txt.Text = row1["Ket"].ToString();
                id2_lbl.Text = row1["Detail"].ToString();
                DataRow row2 = ekstra.Rows[2];
                ekskul3_combo.SelectedValue = row2["Kode"].ToString();
                keterangan3_txt.Text = row2["Ket"].ToString();
                id3_lbl.Text = row2["Detail"].ToString();
            }
        }

        private void ekskul1_btn_Click(object sender, EventArgs e)
        {
            string kodeKelas = kelas_combo.SelectedValue.ToString();
            if (string.IsNullOrEmpty(ekskul1_combo.Text) && !string.IsNullOrEmpty(keterangan1_txt.Text))
            {
                //DELETE DETAIL YG ADA
                group1.Enabled = true;
                group2.Enabled = false;
                group3.Enabled = false;
            }
            else if (string.IsNullOrEmpty(ekskul1_combo.Text) && string.IsNullOrEmpty(keterangan1_txt.Text))
            {
                //DELETE DETAIL YG ADA
                group1.Enabled = true;
                group2.Enabled = false;
                group3.Enabled = false;
            }
            else if (!string.IsNullOrEmpty(ekskul1_combo.Text) && string.IsNullOrEmpty(keterangan1_txt.Text))
            {
                MessageBox.Show("Keterangan tidak boleh kosong!");
            }
            else if (!string.IsNullOrEmpty(ekskul1_combo.Text) && !string.IsNullOrEmpty(keterangan1_txt.Text))
            {
                //SAVE DATA ESKUL 1
                field = "keterangan = '" + keterangan1_txt.Text + "'";
                table = "deskripsieskul";
                cond = "id_deskripsieskul = '" + id1_lbl.Text + "'";
                db.updateData(table, field, cond);
                MessageBox.Show("Data Tersimpan");
                group1.Enabled = false;
                group2.Enabled = true;
                group3.Enabled = false;
            }
        }

        private void ekskul2_btn_Click(object sender, EventArgs e)
        {
            string kodeKelas = kelas_combo.SelectedValue.ToString();
            if (string.IsNullOrEmpty(ekskul2_combo.Text) && !string.IsNullOrEmpty(keterangan2_txt.Text))
            {
                //DELETE DETAIL YG ADA
                table = "deskripsieskul";
                cond = "id_deskripsieskul ='" + id2_lbl.Text + "'";
                db.deleteData(table, cond);
                MessageBox.Show("Data dihapus");
                keterangan2_txt.ResetText();
                group1.Enabled = true;
                ekskul1_combo.Enabled = false;
                group2.Enabled = false;
                group3.Enabled = false;
            }
            else if (string.IsNullOrEmpty(ekskul2_combo.Text) && string.IsNullOrEmpty(keterangan2_txt.Text))
            {
                //DELETE DETAIL YG ADA
                table = "deskripsieskul";
                cond = "id_deskripsieskul ='" + id2_lbl.Text + "'";
                db.deleteData(table, cond);
                MessageBox.Show("Data dihapus");
                group1.Enabled = true;
                ekskul1_combo.Enabled = false;
                group2.Enabled = false;
                group3.Enabled = false;
            }
            else if (!string.IsNullOrEmpty(ekskul2_combo.Text) && string.IsNullOrEmpty(keterangan2_txt.Text))
            {
                MessageBox.Show("Keterangan tidak boleh kosong!");
            }
            else if (!string.IsNullOrEmpty(ekskul2_combo.Text) && !string.IsNullOrEmpty(keterangan2_txt.Text))
            {
                if (ekskul2_combo.Text.Equals(ekskul1_combo.Text))
                {
                    MessageBox.Show("Ekstrakurikuler sudah dipilih!");
                }
                else
                {
                    //SAVE DATA ESKUL 2
                    query = "select count(id_deskripsieskul) as 'kode' from deskripsieskul where kode_kelas = '"
                            + kodeKelas + "' AND nis_siswa ='" + nis_lbl.Text + "'";
                    myConn.Open();
                    myComm = new MySqlCommand(query, myConn);
                    myReader = myComm.ExecuteReader();
                    string cekJumlah = "";
                    while (myReader.Read())
                    {
                        cekJumlah = myReader.GetString("kode");
                    }
                    myConn.Close();
                    if (cekJumlah == "1")
                    {
                        field = "DEFAULT, '" + kodeKelas + "', '" + nis_lbl.Text +
                        "', '" + ekskul2_combo.SelectedValue.ToString() + "', '" + keterangan2_txt.Text + "'";
                        table = "deskripsieskul";
                        db.insertData(table, field);
                    }
                    else if (cekJumlah == "2")
                    {
                        field = "kode_eskul = '" + ekskul2_combo.SelectedValue.ToString() +
                                "', keterangan = '" + keterangan2_txt.Text + "'";
                        table = "deskripsieskul";
                        cond = "id_deskripsieskul = '" + id2_lbl.Text + "'";
                        db.updateData(table, field, cond);
                    }
                    query = "select id_deskripsieskul as 'ID' from deskripsieskul where kode_eskul = '" +
                            ekskul2_combo.SelectedValue.ToString() + "' AND kode_kelas = '"
                            + kodeKelas + "' AND nis_siswa ='" + nis_lbl.Text + "'";
                    myConn.Open();
                    myComm = new MySqlCommand(query, myConn);
                    myReader = myComm.ExecuteReader();
                    while (myReader.Read())
                    {
                        id2_lbl.Text = myReader.GetString("ID");
                    }
                    myConn.Close();

                    MessageBox.Show("Data Tersimpan");
                    group1.Enabled = false;
                    group2.Enabled = false;
                    group3.Enabled = true;
                }
            }
        }

        private void ekskul3_btn_Click(object sender, EventArgs e)
        {
            string kodeKelas = kelas_combo.SelectedValue.ToString();
            if (string.IsNullOrEmpty(ekskul3_combo.Text) && !string.IsNullOrEmpty(keterangan3_txt.Text))
            {
                //DELETE DETAIL YG ADA
                table = "deskripsieskul";
                cond = "id_deskripsieskul ='" + id3_lbl.Text + "'";
                db.deleteData(table, cond);
                MessageBox.Show("Data dihapus");
                keterangan3_txt.ResetText();
                group1.Enabled = false;
                group2.Enabled = true;
                group3.Enabled = false;
            }
            else if (string.IsNullOrEmpty(ekskul3_combo.Text) && string.IsNullOrEmpty(keterangan3_txt.Text))
            {
                //DELETE DETAIL YG ADA
                table = "deskripsieskul";
                cond = "id_deskripsieskul ='" + id3_lbl.Text + "'";
                db.deleteData(table, cond);
                MessageBox.Show("Data dihapus");
                group1.Enabled = false;
                group2.Enabled = true;
                group3.Enabled = false;
            }
            else if (!string.IsNullOrEmpty(ekskul3_combo.Text) && string.IsNullOrEmpty(keterangan3_txt.Text))
            {
                MessageBox.Show("Keterangan tidak boleh kosong!");
            }
            else if (!string.IsNullOrEmpty(ekskul3_combo.Text) && !string.IsNullOrEmpty(keterangan3_txt.Text))
            {
                if (ekskul3_combo.Text.Equals(ekskul1_combo.Text))
                {
                    MessageBox.Show("Ekstrakurikuler sudah dipilih!");
                }
                else if (ekskul3_combo.Text.Equals(ekskul2_combo.Text))
                {
                    MessageBox.Show("Ekstrakurikuler sudah dipilih!");
                }
                else
                {
                    //SAVE DATA ESKUL 3
                    query = "select count(id_deskripsieskul) as 'kode' from deskripsieskul where kode_kelas = '" 
                            + kodeKelas + "' AND nis_siswa ='" + nis_lbl.Text + "'";
                    myConn.Open();
                    myComm = new MySqlCommand(query, myConn);
                    myReader = myComm.ExecuteReader();
                    string cekJumlah = "";
                    while (myReader.Read())
                    {
                        cekJumlah = myReader.GetString("kode");
                    }
                    myConn.Close();
                    if (cekJumlah == "2")
                    {
                        field = "DEFAULT, '" + kodeKelas + "', '" + nis_lbl.Text +
                        "', '" + ekskul3_combo.SelectedValue.ToString() + "', '" + keterangan3_txt.Text + "'";
                        table = "deskripsieskul";
                        db.insertData(table, field);
                    }
                    else if (cekJumlah == "3")
                    {
                        field = "kode_eskul = '" + ekskul3_combo.SelectedValue.ToString() +
                                "', keterangan = '" + keterangan3_txt.Text + "'";
                        table = "deskripsieskul";
                        cond = "id_deskripsieskul = '" + id3_lbl.Text + "'";
                        db.updateData(table, field, cond);
                    }
                    query = "select id_deskripsieskul as 'ID' from deskripsieskul where kode_eskul = '" +
                            ekskul3_combo.SelectedValue.ToString() + "' AND kode_kelas = '"
                            + kodeKelas + "' AND nis_siswa ='" + nis_lbl.Text + "'";
                    myConn.Open();
                    myComm = new MySqlCommand(query, myConn);
                    myReader = myComm.ExecuteReader();
                    while (myReader.Read())
                    {
                        id3_lbl.Text = myReader.GetString("ID");
                    }
                    myConn.Close();
                    MessageBox.Show("Data Tersimpan");
                    group1.Enabled = false;
                    group2.Enabled = false;
                    group3.Enabled = true;
                }
            }
        }

//END CLASS
    }
}
