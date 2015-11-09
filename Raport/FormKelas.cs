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
using System.Collections;

namespace Raport
{
    public partial class FormKelas : Form
    {
        MySqlConnection myConn = Function.getKoneksi();
        Function db = new Function();
        MySqlDataReader myReader;
        MySqlCommand myComm;
        private string table;
        private string cond;
        private string field;
        private string get_idGuru;
        private string query;
        char notif;
        private string id_kelas, idGuru, kodeMapel, id_detail;
        DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
        DataGridViewCheckBoxColumn chk2 = new DataGridViewCheckBoxColumn();
        DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();

        public FormKelas()
        {
            InitializeComponent();
            fillcomboGuru();
            getCombo();
            pilihTahun_combo.SelectedIndex = -1;
            pilihKelas_combo.SelectedIndex = -1;
        }

        private void FormKelas_Load(object sender, EventArgs e)
        {
            loadData();
            viewMember_grid.DataSource = null;
            viewKelas_combo.Enabled = false;
            refresh2_toolBtn.Enabled = false;
        }

        private void getCombo()
        {
            tahun_combo.DataSource = db.getTahuj();
            tahun_combo.DisplayMember = "valueDisplay";

            sort_combo.DataSource = db.getTahuj();
            sort_combo.DisplayMember = "valueDisplay";

            pilihTahun_combo.DataSource = db.getTahuj();
            pilihTahun_combo.DisplayMember = "valueDisplay";

            setTahun_combo.DataSource = db.getTahuj();
            setTahun_combo.DisplayMember = "valueDisplay";
        }

        //TAB VIEW CLASS
        private void loadData()
        {
            try
            {
                this.field = "kode_kelas as 'ID', nama_kelas as 'Kelas', nama_guru as 'Wali Kelas', " +
                            "tahun_ajaran as 'Tahun Ajaran', jumlah_siswa as 'Jumlah Siswa'";
                this.table = "kelas INNER JOIN guru USING (id_guru)";
                this.cond = "status_kelas = 'Aktif' ORDER BY tahun_ajaran, nama_kelas ASC";
                DataTable kelas = db.GetDataTable(field, table, cond);
                this.dataKelas_grid.DataSource = kelas;

                cancelAction();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void create_toolBtn_Click_1(object sender, EventArgs e)
        {
            cancelAction();
            addAction();
        }

        private void addAction()
        {
            kelas_tab.SelectTab(1);

            create_toolBtn.Enabled = false;
            dataKelas_grid.Enabled = false;
            kelas_txt.ReadOnly = false;

            wali_combo.Enabled = true;
            tahun_combo.Enabled = true;
            save_btn.Enabled = true;
            cancel_btn.Enabled = true;
        }

        private void dataKelas_grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex >= 0) && (e.RowIndex != -1))
            {
                DataGridViewRow row = this.dataKelas_grid.Rows[e.RowIndex];
                this.id_txt.Text = row.Cells["ID"].Value.ToString();
                this.kelas_txt.Text = row.Cells["Kelas"].Value.ToString();
                this.wali_combo.Text = row.Cells["Wali Kelas"].Value.ToString();
                this.tahun_combo.Text = row.Cells["Tahun Ajaran"].Value.ToString();
                string sJumlah = row.Cells["Jumlah Siswa"].Value.ToString();

                kelas_tab.SelectTab(1);
                cancel_btn.Enabled = true;
                update_btn.Enabled = true;
                delete_btn.Enabled = true;
                wali_combo.Enabled = true;
                tahun_combo.Enabled = true;

                kelas_txt.ReadOnly = false;
            }
        }

        private void refresh_toolBtn_Click(object sender, EventArgs e)
        {
            loadData();
            sort_combo.SelectedIndex = -1;
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
                    this.field = "kode_kelas as 'ID', nama_kelas as 'Kelas', nama_guru as 'Wali Kelas', " +
                                "tahun_ajaran as 'Tahun Ajaran', jumlah_siswa as 'Jumlah Siswa'";
                    this.table = "kelas JOIN guru USING(id_guru)";
                    this.cond = "tahun_ajaran LIKE '" + this.sort_combo.Text + "' AND status_kelas = 'Aktif' ORDER BY nama_kelas ASC";
                    DataTable kelas = db.GetDataTable(field, table, cond);
                    this.dataKelas_grid.DataSource = kelas;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void search_txt_TextChanged(object sender, EventArgs e)
        {
            this.field = "kode_kelas as 'ID', nama_kelas as 'Kelas', nama_guru as 'Wali Kelas', " +
                            "tahun_ajaran as 'Tahun Ajaran', jumlah_siswa as 'Jumlah Siswa'";
            this.table = "kelas INNER JOIN guru USING (id_guru)";
            this.cond = "status_kelas = 'Aktif' AND" +
                        "(nama_guru LIKE '%" + search_txt.Text + "%' OR " +
                        "nama_kelas LIKE '%" + search_txt.Text + "%' OR " +
                        "tahun_ajaran LIKE '%" + search_txt.Text + "%')" +
                        "ORDER BY tahun_ajaran, nama_kelas ASC";
            DataTable tabel = db.GetDataTable(field, table, cond);
            this.dataKelas_grid.DataSource = tabel;
        }

        //TAB NEW CLASS
        public void fillcomboGuru()
        {
            try
            {
                string idValue = "id_guru";
                string dispValue = "nama_guru";
                this.table = "guru";
                this.cond = "status_guru = 'Aktif'";
                string sortby = "nama_guru";

                wali_combo.DataSource = db.setCombo(idValue, dispValue, table, cond, sortby);
                wali_combo.DisplayMember = "valueDisplay";
                wali_combo.ValueMember = "valueID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if ((kelas_txt.Text == "") && (wali_combo.Text == "") && (tahun_combo.Text == ""))
                {
                    MessageBox.Show("Data Kelas belum terisi");
                }
                else if (kelas_txt.Text == "")
                {
                    MessageBox.Show("Nama Kelas Belum diisi");
                }
                else if (wali_combo.Text == "")
                {
                    MessageBox.Show("Wali Kelas belum dipilih");
                }
                else if (tahun_combo.Text == "")
                {
                    MessageBox.Show("Tahun ajaran belum dipilih");
                }
                else
                {
                    string get_idGuru = this.wali_combo.SelectedValue.ToString();
                    this.table = "kelas";
                    this.field = "DEFAULT, '" + this.kelas_txt.Text + "', '" + this.tahun_combo.Text + "', DEFAULT, '" + get_idGuru + "', DEFAULT";
                    db.insertData(table, field);
                    MessageBox.Show("Kelas baru '" + this.kelas_txt.Text +
                        "' dibuat \n Data Tersimpan");
                    loadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cancelAction()
        {
            kelas_txt.ResetText();
            wali_combo.SelectedIndex = -1;
            tahun_combo.SelectedIndex = -1;

            save_btn.Enabled = false;
            cancel_btn.Enabled = false;
            update_btn.Enabled = false;
            delete_btn.Enabled = false;
            wali_combo.Enabled = false;
            tahun_combo.Enabled = false;

            create_toolBtn.Enabled = true;
            dataKelas_grid.Enabled = true;
            kelas_txt.ReadOnly = true;
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            cancelAction();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialog = MessageBox.Show("Hapus kelas '" + kelas_txt.Text + "' Tahun Ajaran '" + tahun_combo.Text + "' ?",
               "Hapus Data", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    this.table = "kelas";
                    this.field = "status_kelas = 'Tidak Aktif'";
                    this.cond = "kode_kelas = '" + id_txt.Text + "'";
                    db.updateData(table, field, cond);
                    MessageBox.Show("Data kelas '" + kelas_txt.Text + "' Terhapus");
                    loadData();
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

        private void update_btn_Click(object sender, EventArgs e)
        {
            try
            {
                get_idGuru = this.wali_combo.SelectedValue.ToString();
                this.table = "kelas JOIN guru USING (id_guru)";
                this.field = "nama_kelas='" + this.kelas_txt.Text +
                        "', tahun_ajaran='" + this.tahun_combo.Text +
                        "', id_guru= '" + get_idGuru + "'";
                this.cond = "kode_kelas = '" + id_txt.Text + "'";

                db.updateData(table, field, cond);
                MessageBox.Show("Edit Data Kelas Berhasil \n Data Tersimpan");
                loadData();
                kelas_tab.SelectTab(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void kelas_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar) == false
               && (char)e.KeyChar != (char)Keys.Back
               && (char)e.KeyChar != (char)Keys.Space
               && (char)e.KeyChar != (char)Keys.ControlKey)
            {
                e.Handled = true;
            }
        }

        //TAB CLASS SCHEDULE
        private void pilihTahun_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((pilihTahun_combo.Text == "") || (pilihTahun_combo.SelectedIndex == -1))
            {
                cancel_schedule();
                pilihKelas_combo.Enabled = false;
            }
            else
            {
                pilihKelas_combo.Enabled = true;
                try
                {
                    string idValue = "kode_kelas";
                    string dispValue = "nama_kelas";
                    this.table = "kelas";
                    this.cond = "tahun_ajaran = '" + this.pilihTahun_combo.Text + "' AND status_kelas = 'Aktif' ";
                    string sortby = "nama_kelas";

                    pilihKelas_combo.DataSource = db.setCombo(idValue, dispValue, table, cond, sortby);
                    pilihKelas_combo.DisplayMember = "valueDisplay";
                    pilihKelas_combo.ValueMember = "valueID";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        private void pilihKelas_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((pilihKelas_combo.Text == "") || (pilihKelas_combo.SelectedIndex == -1))
            {
                wali_txt.ResetText();
                id_lbl.Text = "0";

                schedule_grid.Enabled = false;
                create_tool.Enabled = false;
                load_tool.Enabled = false;
                edit_tool.Enabled = false;
                cancel2_btn.Enabled = false;
                save2_btn.Enabled = false;

                schedule_grid.DataSource = null;
                schedule_grid.Columns.Clear();
                schedule_grid.Enabled = false;
            }
            else
            {
                load_tool.Enabled = true;
                this.id_kelas = this.pilihKelas_combo.SelectedValue.ToString();
                this.field = "nama_guru";
                this.table = "guru INNER JOIN kelas USING (id_guru)";
                this.cond = "kode_kelas = '" + id_kelas +
                            "' AND status_kelas = 'Aktif' AND tahun_ajaran = '" + this.pilihTahun_combo.Text + "'";
                string query = "SELECT " + field + " FROM " + table + " WHERE " + cond;

                MySqlCommand myComm = new MySqlCommand(query, myConn);
                myConn.Open();
                myReader = myComm.ExecuteReader();
                while (myReader.Read())
                {
                    wali_txt.Text = myReader.GetString("nama_guru");
                }
                myConn.Close();

                string check_id = "SELECT COUNT(kode_kelas) as 'id kelas' from detailmapelkelas where kode_kelas = '" +
                                    id_kelas + "' AND status = 'Aktif'";
                myConn.Open();
                myComm = new MySqlCommand(check_id, myConn);
                myReader = myComm.ExecuteReader();
                while (myReader.Read())
                {
                    id_lbl.Text = myReader.GetString("id kelas");
                }
                myConn.Close();

                if (id_lbl.Text == "0")
                {
                    schedule_grid.DataSource = null;
                    schedule_grid.Columns.Clear();
                    schedule_grid.Enabled = false;
                    create_tool.Enabled = true;
                    edit_tool.Enabled = false;
                }
                else if (id_lbl.Text != "0")
                {
                    schedule_grid.Enabled = true;
                    edit_tool.Enabled = true;
                    load_Schedule();
                    schedule_grid.DataSource = null;
                    schedule_grid.Columns.Clear();
                    schedule_grid.Enabled = false;
                    load_Schedule();
                    edit_schedule();
                    create_tool.Enabled = true;
                }
            }
        }
        
        public void cancel_schedule()
        { 
            pilihKelas_combo.SelectedIndex = -1;
            pilihTahun_combo.SelectedIndex = -1;
            wali_txt.ResetText();
            create_tool.Enabled = false;
            load_tool.Enabled = false;
            schedule_grid.Enabled = false;
        }
        
        private void cancel2_btn_Click(object sender, EventArgs e)
        {
            edit_tool.Enabled = true;
            save2_btn.Enabled = false;
            cancel2_btn.Enabled = false;
            schedule_grid.Enabled = false;
            create_tool.Enabled = true;
            delete2_btn.Enabled = false;
            load_Schedule();
            edit_schedule();
            schedule_grid.Columns[0].Visible = false;
        }

        private void edit_tool_Click(object sender, EventArgs e)
        {
            schedule_grid.Enabled = true;
            save2_btn.Enabled = true;
            cancel2_btn.Enabled = true;
            edit_tool.Enabled = false;
            create_tool.Enabled = false;
            delete2_btn.Enabled = true;
            schedule_grid.Columns[0].Visible = true; 
        }

        private void load_tool_Click(object sender, EventArgs e)
        {
            load_Schedule();
            edit_schedule();
            edit_tool.Enabled = true;
            save2_btn.Enabled = false;
            cancel2_btn.Enabled = false;
            schedule_grid.Enabled = false;
            create_tool.Enabled = true;
            delete2_btn.Enabled = false;
        }
        
        private void save2_btn_Click(object sender, EventArgs e)
        {
            notif = 'A';
            foreach (DataGridViewRow row in schedule_grid.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value) == true)
                {
                    if (Convert.ToString(row.Cells[6].Value) == "")
                    {
                        string kosong = row.Cells[4].Value.ToString();
                        MessageBox.Show("Guru "+ kosong +" kosong \n Data tidak berubah");
                    }
                    else
                    {
                        if ((Convert.ToBoolean(row.Cells[0].Value) == true) &&
                            (Convert.ToString(row.Cells[6].Value) != ""))
                        {
                            this.id_detail = row.Cells[1].Value.ToString();
                            this.idGuru = row.Cells[6].Value.ToString();
                            this.table = "detailmapelkelas";
                            this.field = "id_guru = '" + idGuru + "'";
                            this.cond = "id_detail = '" + id_detail + "'";
                            db.updateData(table, field, cond);
                            notif = 'B';
                        }
                    }
                }
            }

            if (notif == 'B')
            {
                MessageBox.Show("Data berhasil diubah");
            }

            edit_tool.Enabled = true;
            save2_btn.Enabled = false;
            cancel2_btn.Enabled = false;
            schedule_grid.Enabled = false;
            create_tool.Enabled = true;
            delete2_btn.Enabled = false;
            load_Schedule();
            edit_schedule();
            schedule_grid.Columns[0].Visible = false;
        }

        private void schedule_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in schedule_grid.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value) == false)
                {
                    row.Cells[6].ReadOnly = true;
                }
                else
                {
                    row.Cells[6].ReadOnly = false;
                }
            }
        }

        private void delete2_btn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in schedule_grid.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value) == true)
                {
                    this.kodeMapel = row.Cells[4].Value.ToString();
                    DialogResult dialog = MessageBox.Show("Hapus mapel '" + kodeMapel + "'?",
                        "Hapus Data", MessageBoxButtons.YesNo);
                    if (dialog == DialogResult.Yes)
                    {
                        this.id_detail = row.Cells[1].Value.ToString();
                        this.table = "detailmapelkelas";
                        this.field = "status = 'Tidak Aktif'";
                        this.cond = "id_detail = '" + id_detail + "'";
                        db.updateData(table, field, cond);
                        MessageBox.Show("Mapel '" + kodeMapel + "' berhasil dihapus");
                    }
                    else if (dialog == DialogResult.No)
                    {
                        CancelEventArgs batal = new CancelEventArgs();
                        batal.Cancel = true;
                    }
                }
                cancel2_btn_Click(sender, e);
                load_tool_Click(sender, e);
            }
        }

        private void create_tool_Click(object sender, EventArgs e)
        {
            FormAddMapel FAddMapel = new FormAddMapel();
            FAddMapel.passKodeKelas = pilihKelas_combo.SelectedValue.ToString();
            FAddMapel.ShowDialog();
        }

        public void load_Schedule()
        {
            try
            {
                schedule_grid.DataSource = null;
                schedule_grid.Columns.Clear();
                schedule_grid.Rows.Clear();
                this.id_kelas = pilihKelas_combo.SelectedValue.ToString();

                //Membuat Checkbox
                chk.ReadOnly = false;
                chk.HeaderText = "Pilih";
                schedule_grid.Columns.Add(chk);

                //Mengisi datagrid dari database
                this.field = "id_detail as 'ID', mapel.kode_mapel as 'Kode Mapel', kategori_mapel as 'Kategori Mapel', mata_pelajaran as 'Mata Pelajaran', jam_pelajaran as 'JP'";
                this.table = "mapel join detailmapelkelas USING (kode_mapel)";
                this.cond = "status_mapel = 'Aktif' AND kode_kelas = '" + id_kelas + "'  AND detailmapelkelas.status = 'Aktif' ORDER BY kategori_mapel";
                DataTable tabel = db.GetDataTable(field, table, cond);
                this.schedule_grid.DataSource = tabel;

                //Membuat combobox guru Mapel
                cmb.HeaderText = "Pengajar Mapel (Wajib Diisi)";
                cmb.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                cmb.ReadOnly = false;

                //Mengisi combobox guru dari database
                string idValue = "id_guru";
                string dispValue = "nama_guru";
                this.table = "guru";
                this.cond = "status_guru = 'Aktif'";
                string sortby = "nama_guru";
                cmb.DataSource = db.setCombo(idValue, dispValue, table, cond, sortby);
                cmb.DisplayMember = "valueDisplay";
                cmb.ValueMember = "valueID";
                schedule_grid.Columns.Add(cmb);

                schedule_grid.Columns[2].Visible = false;
                schedule_grid.Columns[1].Visible = false;
                schedule_grid.Columns[0].Visible = false;
                for (int i = 2; i <= 5; i++)
                {
                    schedule_grid.Columns[i].ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void edit_schedule()
        {
            this.id_kelas = this.pilihKelas_combo.SelectedValue.ToString();
            this.query = "SELECT kode_mapel, id_guru FROM detailmapelkelas WHERE kode_kelas = '" + id_kelas + "'";
            myConn.Open();
            myComm = new MySqlCommand(query, myConn);
            myReader = myComm.ExecuteReader();
            while (myReader.Read())
            {
                this.kodeMapel = myReader.GetString("kode_mapel");
                this.idGuru = myReader.GetString("id_guru");

                foreach (DataGridViewRow row in schedule_grid.Rows)
                {
                    if (kodeMapel == row.Cells[2].Value.ToString())
                    {
                        row.Cells[6].Value = idGuru;
                    }
                }
            }
            myConn.Close();
        }

        //TAB CLASS MEMBERS
        private void viewKelas_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (viewKelas_combo.Text == "")
            {
                edit3_toolBtn.Enabled = false;
                select_toolBtn.Enabled = false;
                naikKelas_toolBtn.Enabled = false;
                cancel3_toolBtn.Enabled = false;
                refresh2_toolBtn.Enabled = false;
                viewMember_grid.Columns.Clear();
                viewMember_grid.DataSource = null;
            }
            else if (viewKelas_combo.Text != "")
            {
                edit3_toolBtn.Enabled = false;
                select_toolBtn.Enabled = false;
                naikKelas_toolBtn.Enabled = false;
                refresh2_toolBtn.Enabled = true;
                cancel3_toolBtn.Enabled = false;
                loadMember();
            }            
        }
        
        private void loadMember()
        {
            this.id_kelas = this.viewKelas_combo.SelectedValue.ToString();
            this.query = "SELECT count(nis_siswa) as 'Jumlah' FROM detailkelassiswa WHERE kode_kelas= '" + id_kelas + "'";
            MySqlCommand myComm = new MySqlCommand(query, myConn);
            myConn.Open();
            myReader = myComm.ExecuteReader();
            while (myReader.Read())
            {
                countID_lbl.Text = myReader.GetString("Jumlah");
            }
            myConn.Close();

            if (countID_lbl.Text == "0")
            {
                viewMember_grid.DataSource = null;
                viewMember_grid.Columns.Clear();
                edit3_toolBtn.Enabled = false;
            }
            else if (countID_lbl.Text != "0")
            {
                viewMemberKelas();
                edit3_toolBtn.Enabled = true;
            }
        }

        private void edit3_toolBtn_Click(object sender, EventArgs e)
        {
            viewMember_grid.Columns[0].Visible = true;
            select_toolBtn.Enabled = true;
            naikKelas_toolBtn.Enabled = true;
            cancel3_toolBtn.Enabled = true;
            refresh2_toolBtn.Enabled = true;
        }

        private void cancel3_toolBtn_Click(object sender, EventArgs e)
        {
            viewMember_grid.Columns[0].Visible = false;
            select_toolBtn.Enabled = false;
            naikKelas_toolBtn.Enabled = false;
            cancel3_toolBtn.Enabled = false;
            refresh2_toolBtn.Enabled = true;
            select_toolBtn.Text = "Select All";
            foreach (DataGridViewRow row in viewMember_grid.Rows)
            {
                row.Cells[0].Value = false;
            }
        }

        private void select_toolBtn_Click(object sender, EventArgs e)
        {
            if (select_toolBtn.Text == "Select All")
            {
                foreach (DataGridViewRow row in viewMember_grid.Rows)
                {
                    row.Cells[0].Value = true;
                    select_toolBtn.Text = "Unselect All";
                }
            }
            else
            {
                foreach (DataGridViewRow row in viewMember_grid.Rows)
                {
                    row.Cells[0].Value = false;
                    select_toolBtn.Text = "Select All";
                }
            }
        }

        private void refresh2_toolBtn_Click(object sender, EventArgs e)
        {
            loadMember();
            cancel3_toolBtn_Click(sender, e);
        }
        
        private void setTahun_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (setTahun_combo.Text == "")
            {
                viewKelas_combo.Enabled = false;
                viewKelas_combo.SelectedIndex = -1;
            }
            else if (setTahun_combo.Text != "")
            {
                viewKelas_combo.Enabled = true;
                fillKelas();
            }
        }
        
        public void fillKelas()
        {
            string getTahun = setTahun_combo.Text.ToString();
            try
            {
                string idValue = "kode_kelas";
                string dispValue = "nama_kelas";
                this.table = "kelas";
                this.cond = "status_kelas = 'Aktif' AND tahun_ajaran = '" + getTahun + "'";
                string sortby = "nama_kelas";

                viewKelas_combo.DataSource = db.setCombo(idValue, dispValue, table, cond, sortby);
                viewKelas_combo.DisplayMember = "valueDisplay";
                viewKelas_combo.ValueMember = "valueID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void viewMemberKelas()
        {
            viewMember_grid.DataSource = null;
            viewMember_grid.Columns.Clear();
            //Membuat Checkbox
            chk2.ReadOnly = false;
            chk2.HeaderText = "Pilih";
            viewMember_grid.Columns.Add(chk2);

            this.id_kelas = this.viewKelas_combo.SelectedValue.ToString();
            this.table = "detailkelassiswa INNER JOIN siswa USING(nis_siswa) INNER JOIN orangtua USING (nis_siswa)";
            this.field = "detailkelassiswa.nis_siswa as 'NIS', nisn_siswa as 'NISN', nama_siswa as 'Nama Siswa', " +
                         "tanggal_lahir as 'Tanggal Lahir', nama_ayah as 'Nama Ayah'";
            this.cond = "detailkelassiswa.kode_kelas= '" + id_kelas + "'";
            DataTable result = db.GetDataTable(field, table, cond);
            viewMember_grid.DataSource = result;
            viewMember_grid.Columns[0].Visible = false;
            for (int i = 1; i <= 5; i++)
            {
                viewMember_grid.Columns[i].ReadOnly = true;
            }
        }
        //END CLASS
    }
}
