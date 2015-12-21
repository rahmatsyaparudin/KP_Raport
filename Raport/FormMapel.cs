using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Raport
{
    public partial class FormMapel : Form
    {
        MySqlConnection myConn = Function.getKoneksi();
        Function db = new Function();
        private string table;
        private string cond;
        private string field;

        public FormMapel()
        {
            InitializeComponent();
            comboAngka();
        }

        private void FormMapel_Load(object sender, EventArgs e)
        {
            loadData();
        }

        //TAB VIEW MAPEL
        private void addAction()
        {
            mapel_tab.SelectTab(1);
            save_btn.Enabled = true;
            cancel_btn.Enabled = true;
            mapel_txt.Enabled = true;
            kategori_combo.Enabled = true;
            jam_combo.Enabled = true;
            kode_txt.Enabled = true;

            add_toolBtn.Enabled = false;
            dataMapel_grid.Enabled = false;
        }

        private void loadData()
        {
            try
            {
                this.field = "kode_mapel as 'Kode', mata_pelajaran as 'Mata Pelajaran', kategori_mapel as 'Kategori', " +
                            "jam_pelajaran as 'JP', jumlah_jp as 'Jumlah JP'";
                this.table = "mapel";
                this.cond = "status_mapel = 'Aktif' ORDER BY kategori_mapel, mata_pelajaran ASC";
                DataTable tabel = db.GetDataTable(field, table, cond);
                this.dataMapel_grid.DataSource = tabel;

                cancelAction();
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

        private void sort_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sort_combo.Text == "")
            {
                loadData();
            }
            else
            {
                try
                {
                    this.field = "kode_mapel as 'Kode', mata_pelajaran as 'Mata Pelajaran', kategori_mapel as 'Kategori', " +
                            "jam_pelajaran as 'JP', jumlah_jp as 'Jumlah JP'";
                    this.table = "mapel";
                    this.cond = "kategori_mapel LIKE '" + this.sort_combo.Text +
                                "' AND status_mapel = 'Aktif' ORDER BY kategori_mapel, mata_pelajaran ASC";
                    DataTable kelas = db.GetDataTable(field, table, cond);
                    this.dataMapel_grid.DataSource = kelas;
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
        }

        private void add_toolBtn_Click(object sender, EventArgs e)
        {
            cancelAction();
            addAction();
        }

        private void refresh_toolBtn_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void dataMapel_grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if ((e.RowIndex >= 0) && (e.RowIndex != -1))
                {
                    mapel_tab.SelectTab(1);
                    DataGridViewRow row = this.dataMapel_grid.Rows[e.RowIndex];
                    this.kode_txt.Text = row.Cells["Kode"].Value.ToString();
                    this.mapel_txt.Text = row.Cells["Mata Pelajaran"].Value.ToString();
                    this.jam_combo.Text = row.Cells["JP"].Value.ToString();
                    this.kategori_combo.Text = row.Cells["Kategori"].Value.ToString();
                    this.getId_txt.Text = row.Cells["Kode"].Value.ToString();

                    cancel_btn.Enabled = true;
                    update_btn.Enabled = true;
                    delete_btn.Enabled = true;
                    jam_combo.Enabled = true;
                    mapel_txt.Enabled = true;
                    kode_txt.Enabled = true;
                    kategori_combo.Enabled = true;
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

        private void search_txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.field = "kode_mapel as 'Kode', mata_pelajaran as 'Mata Pelajaran', kategori_mapel as 'Kategori', " +
                            "jam_pelajaran as 'JP', jumlah_jp as 'Jumlah JP'";
                this.table = "mapel";
                this.cond = "status_mapel = 'Aktif' AND" +
                "(kode_mapel LIKE '%" + search_txt.Text + "%' OR " +
                "mata_pelajaran LIKE '%" + search_txt.Text + "%' OR " +
                "jumlah_jp LIKE '%" + search_txt.Text + "%' OR " +
                "jam_pelajaran LIKE '%" + search_txt.Text + "%') ORDER BY kategori_mapel, mata_pelajaran ASC";
                DataTable tabel = db.GetDataTable(field, table, cond);
                this.dataMapel_grid.DataSource = tabel;
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

        //TAB ADD MAPEL
        private void cancelAction()
        {
            save_btn.Enabled = false; cancel_btn.Enabled = false;
            update_btn.Enabled = false; delete_btn.Enabled = false;
            mapel_txt.Enabled = false; jam_combo.Enabled = false;
            kode_txt.Enabled = false; kategori_combo.Enabled = false;

            dataMapel_grid.Enabled = true; add_toolBtn.Enabled = true;
            mapel_txt.ResetText(); jam_combo.SelectedIndex = -1;
            kategori_combo.SelectedIndex = -1; kode_txt.ResetText();
        }
        
        private void comboAngka()
        {
            jam_combo.DataSource = db.getAngka();
            jam_combo.DisplayMember = "valueDisplay";

            kategori_combo.DataSource = db.getKategori();
            kategori_combo.DisplayMember = "valueDisplay";

            sort_combo.DataSource = db.getKategori();
            sort_combo.DisplayMember = "valueDisplay";
        }
        
        private void save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if ((mapel_txt.Text == "") 
                    && (kode_txt.Text == "") 
                    && (kategori_combo.Text == "")
                    && (jam_combo.Text == ""))
                {
                    MessageBox.Show("Data Mata Pelajaran belum terisi");
                }
                else if (mapel_txt.Text == "")
                {
                    MessageBox.Show("Mata Pelajaran Belum terisi");
                }
                else if (kode_txt.Text == "")
                {
                    MessageBox.Show("Kode Mapel Belum terisi");
                }
                else if (kategori_combo.Text == "")
                {
                    MessageBox.Show("Kategori belum dipilih");
                }
                else if (jam_combo.Text == "")
                {
                    MessageBox.Show("Jam Pelajaran belum dipilih");
                }
                else
                {
                    this.table = "mapel";
                    this.field = "'" + this.kode_txt.Text.Replace("'", "''") +
                            "', '" + this.mapel_txt.Text.Replace("'", "''") + "', '" + this.kategori_combo.Text +
                            "', '" + this.jam_combo.Text + "', DEFAULT, DEFAULT";
                    db.insertData(table, field);
                    MessageBox.Show("Mata Pelajaran '" + this.mapel_txt.Text +
                        "' dibuat \n Data Tersimpan");
                    loadData();
                    mapel_tab.SelectTab(0);
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
            cancelAction();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            try
            {
                this.table = "mapel";
                this.field = "mata_pelajaran = '" + this.mapel_txt.Text.Replace("'", "''") +
                        "', kategori_mapel = '" + this.kategori_combo.Text +
                        "', jam_pelajaran = '" + jam_combo.Text + 
                        "', kode_mapel = '" + kode_txt.Text.Replace("'", "''") + "'";
                this.cond = "kode_mapel = '" + getId_txt.Text.Replace("'", "''") + "'";

                db.updateData(table, field, cond);
                MessageBox.Show("Edit Data Mata Pelajaran Berhasil \n Data Tersimpan");
                loadData();
                mapel_tab.SelectTab(0);
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

        private void kode_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false
               && (char)e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        
        private void delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialog = MessageBox.Show("Hapus Mata Pelajaran '" + mapel_txt.Text + "' ?",
               "Hapus Data", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    this.table = "mapel";
                    this.field = "status_mapel = 'Tidak Aktif'";
                    this.cond = "kode_mapel = '" + getId_txt.Text + "'";
                    db.updateData(table, field, cond);
                    MessageBox.Show("Mata Pelajaran '" + mapel_txt.Text + "' Terhapus");
                    loadData();
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
        
        //END CLASS
    }
}
