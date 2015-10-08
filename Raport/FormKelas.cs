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
    public partial class FormKelas : Form
    {
        MySqlConnection myConn = Function.getKoneksi();
        Function db = new Function();
        private string table;
        private string cond;
        private string field;
        private string get_idGuru;

        public FormKelas()
        {
            InitializeComponent();
            fillcomboGuru();
            getCombo();
            pilihTahun_combo.SelectedIndex = -1;
            pilihKelas_combo.SelectedIndex = -1;
            viewKelas_tree();
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
                pilihKelas_combo.Enabled = false;
                pilihKelas_combo.SelectedIndex = -1;
            }
            else
            {
                pilihKelas_combo.Enabled = true;
                try
                {
                    string idValue = "kode_kelas";
                    string dispValue = "nama_kelas";
                    this.table = "kelas";
                    this.cond = "tahun_ajaran = '" + this.pilihTahun_combo.Text + "' AND status_kelas = 'Aktif'";
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
                kelas_tree.Enabled = false;
                wali_txt.ResetText();
                kelas_tree.CollapseAll();
            }
            else
            {
                kelas_tree.Enabled = true;
                kelas_tree.ExpandAll();
                create_btn.Enabled = true;
                cancel2_btn.Enabled = true;

                this.field = "nama_guru";
                this.table = "guru INNER JOIN kelas USING (id_guru)";
                this.cond = "nama_kelas = '" + this.pilihKelas_combo.Text + 
                            "' AND status_kelas = 'Aktif' AND tahun_ajaran = '" + this.pilihTahun_combo.Text + "'";
                string query = "SELECT " + field + " FROM " + table + " WHERE " + cond;

                MySqlCommand getGuru = new MySqlCommand(query, myConn);
                myConn.Open();
                MySqlDataReader myReader = getGuru.ExecuteReader();
                while (myReader.Read())
                {
                    wali_txt.Text = myReader.GetString("nama_guru");
                }
                myConn.Close();
            }         
        }
        void viewKelas_tree()
        {
            this.field = "kode_mapel, mata_pelajaran, jam_pelajaran, kategori_mapel";
            this.table = "mapel";
            this.cond = " status_mapel = 'Aktif' order by kategori_mapel asc";
            string query = "SELECT " + field + " FROM " + table + " WHERE " + cond;

            myConn.Open();
            MySqlCommand MyComm = new MySqlCommand(query, myConn);
            MySqlDataReader da = MyComm.ExecuteReader();
            CheckBox getID = new CheckBox();
            kelas_tree.Nodes.Add("Kelompok A (Wajib)").Checked=false;
            kelas_tree.Nodes.Add("Kelompok B (Wajib)").Checked = false;
            kelas_tree.Nodes.Add("Kelompok C (Pilihan)").Checked = false;
            while (da.Read())
            {
                string mapel = da.GetString("mata_pelajaran");
                string jam = da.GetString("jam_pelajaran");
                string kode = da.GetString("kode_mapel");
                
                string display = mapel + " (" + jam + " jam)";
                string kategori = da.GetString("kategori_mapel");

                if (kategori == "Kelompok A")
                {
                    kelas_tree.Nodes[0].Nodes.Add(display).Checked = true; 
                }
                else if (kategori == "Kelompok B")
                {
                    kelas_tree.Nodes[1].Nodes.Add(display).Checked = true;
                }
                else if (kategori == "Kelompok C")
                {
                    kelas_tree.Nodes[2].Nodes.Add(display);
                }
            }
            myConn.Close();
        }

        private void kelas_tree_MouseMove(object sender, MouseEventArgs e)
        {
            kelas_tree.Nodes[0].Checked = false;
            kelas_tree.Nodes[1].Checked = false;
            kelas_tree.Nodes[2].Checked = false;
        }

        private void cancel2_btn_Click(object sender, EventArgs e)
        {
            pilihTahun_combo.SelectedIndex = -1;
            create_btn.Enabled = false;
            cancel2_btn.Enabled = false;
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

        private void create_btn_Click(object sender, EventArgs e)
        {

        }

        private void data()
        {

        }
    }
}
