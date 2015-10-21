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
        private string id_kelas, idGuru, kodeMapel, kodeKelas;
        DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
        DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();

        public FormKelas()
        {
            InitializeComponent();
            fillcomboGuru();
            getCombo();
            pilihTahun_combo.SelectedIndex = -1;
            pilihKelas_combo.SelectedIndex = -1;
        }

        private void getCombo()
        {
            tahun_combo.DataSource = db.getTahuj();
            tahun_combo.DisplayMember = "valueDisplay";
            
            sort_combo.DataSource = db.getTahuj();
            sort_combo.DisplayMember = "valueDisplay";

            pilihTahun_combo.DataSource = db.getTahuj();
            pilihTahun_combo.DisplayMember = "valueDisplay";
        }

        
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

        private void loadData()
        {
            try
            {
                this.field = "kode_kelas as 'ID', nama_kelas as 'Kelas', nama_guru as 'Wali Kelas', "+
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

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            cancelAction();
        }
        
        private void FormKelas_Load(object sender, EventArgs e)
        {
            loadData();
            cancel2_btn.Enabled = false;
            create_btn.Enabled = false;
        }

        private void create_toolBtn_Click(object sender, EventArgs e)
        {
            cancelAction();
            addAction();            
        }
        
        private void refresh_toolBtn_Click(object sender, EventArgs e)
        {
            loadData();
            sort_combo.SelectedIndex = -1;
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialog = MessageBox.Show("Hapus kelas '"+kelas_txt.Text+"' Tahun Ajaran '"+tahun_combo.Text+"' ?",
               "Hapus Data", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    this.table="kelas";
                    this.field = "status_kelas = 'Tidak Aktif'";
                    this.cond= "kode_kelas = '" + id_txt.Text + "'";
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
                    this.field = "kode_kelas as 'ID', nama_kelas as 'Kelas', nama_guru as 'Wali Kelas', "+
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
        
        private void pilihTahun_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((pilihTahun_combo.Text == "") || (pilihTahun_combo.SelectedIndex==-1))
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
            if ((pilihKelas_combo.Text == "") || (pilihKelas_combo.SelectedIndex == -1)){
                wali_txt.ResetText();
                id_lbl.Text = "0";
                schedule_grid.Enabled = false;
                create_btn.Enabled = false;
                edit2_btn.Enabled = false;
                schedule_grid.DataSource = null;
                schedule_grid.Columns.Clear();
                schedule_grid.Enabled = false;
            }
            else
            {
                create_btn.Enabled = true;
                edit2_btn.Enabled = true;
                this.id_kelas = this.pilihKelas_combo.SelectedValue.ToString();
                this.field = "nama_guru";
                this.table = "guru INNER JOIN kelas USING (id_guru)";
                this.cond = "kode_kelas = '" +id_kelas+ 
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

                string check_id = "SELECT COUNT(kode_kelas) as 'id kelas' from detailmapelkelas where kode_kelas = '" + id_kelas + "'";
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
                    create_btn.Enabled = true;
                    cancel2_btn.Enabled = true;
                }
                else if (id_lbl.Text != "0")
                {
                    schedule_grid.Enabled = true;
                    load_Schedule();
                    schedule_grid.DataSource = null;
                    schedule_grid.Columns.Clear();
                    schedule_grid.Enabled = false;
                    load_Schedule();
                    create_btn.Enabled = true;
                    cancel2_btn.Enabled = false;
                    //edit_schedule();
                }
            }         
        }
        
        private void cancel2_btn_Click(object sender, EventArgs e)
        {
            load_Schedule();
        }

        public void cancel_schedule()
        { 
            pilihKelas_combo.SelectedIndex = -1;
            pilihTahun_combo.SelectedIndex = -1;
            wali_txt.ResetText();
            create_btn.Enabled = false;
            cancel2_btn.Enabled = false;
            schedule_grid.Enabled = false;
        }

        private void search_txt_TextChanged(object sender, EventArgs e)
        {
            this.field = "kode_kelas as 'ID', nama_kelas as 'Kelas', nama_guru as 'Wali Kelas', " +
                            "tahun_ajaran as 'Tahun Ajaran', jumlah_siswa as 'Jumlah Siswa'";
            this.table = "kelas INNER JOIN guru USING (id_guru)";
            this.cond = "status_kelas = 'Aktif' AND" +
                        "(nama_guru LIKE '%" + search_txt.Text + "%' OR " +
                        "nama_kelas LIKE '%" + search_txt.Text + "%' OR " +
                        "tahun_ajaran LIKE '%" + search_txt.Text + "%')"+
                        "ORDER BY tahun_ajaran, nama_kelas ASC";
            DataTable tabel = db.GetDataTable(field, table, cond);
            this.dataKelas_grid.DataSource = tabel;
        }

        private void edit2_btn_Click(object sender, EventArgs e)
        {

        }

        private void create_btn_Click(object sender, EventArgs e)
        {
            FormAddMapel FAddMapel = new FormAddMapel();
            FAddMapel.passKodeKelas = pilihKelas_combo.SelectedValue.ToString();
            FAddMapel.ShowDialog();
            //char notif;
            //notif = 'A';
            //foreach (DataGridViewRow row in schedule_grid.Rows)
            //{
            //    if ((Convert.ToBoolean(row.Cells[0].Value) == true) && 
            //            (Convert.ToString(row.Cells[1].Value) != ""))
            //    {
            //        this.idGuru = row.Cells[1].Value.ToString();
            //        this.kodeMapel = row.Cells[2].Value.ToString();
            //        this.kodeKelas = pilihKelas_combo.SelectedValue.ToString();
            //        this.table = "detailmapelkelas";
            //        this.field = "DEFAULT, '"+ kodeKelas +"', '"+ kodeMapel + 
            //                     "', '"+ idGuru +"', DEFAULT";
            //        db.insertData(table, field);
            //        notif = 'B';
            //    }
            //    else if ((Convert.ToBoolean(row.Cells[0].Value) == true) &&
            //        (Convert.ToString(row.Cells[1].Value) == ""))
            //    {
            //        string warning = row.Cells[4].Value.ToString();
            //        MessageBox.Show("Guru "+row.Cells[4].Value.ToString()+" belum dipilih");
            //    }
            //}
        
            //if (notif == 'A')
            //{
            //    MessageBox.Show("Jadwal belum dibuat!");
            //}
            //else if (notif == 'B')
            //{
            //    MessageBox.Show("Jadwal Kelas " + pilihKelas_combo.Text + " berhasil dibuat!");
            //    cancel_schedule();
            //}
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
                this.cond = "status_mapel = 'Aktif' AND kode_mapel IN (SELECT kode_mapel FROM detailmapelkelas WHERE kode_kelas = '" + id_kelas + "') ORDER BY kategori_mapel";
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


                schedule_grid.Columns[1].Visible = true;
                for (int i = 1; i <= 4; i++)
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
            this.query = "SELECT id_detail, kode_mapel, id_guru FROM detailmapelkelas WHERE kode_kelas = '" + id_kelas + "'";
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
                        row.Cells[0].Value = true;
                        row.Cells[1].Value = idGuru;
                    }
                    this.kodeKelas = pilihKelas_combo.SelectedValue.ToString();
                }
            }
            myConn.Close();
        }
        //END CLASS
    }
}
