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
    public partial class FormNilai : Form
    {
        MySqlConnection myConn = Function.getKoneksi();
        Function db = new Function();
        MySqlDataReader myReader, myReader2;
        MySqlCommand myComm, myComm2;
        private string query;
        private string table;
        private string field;
        private string cond;
        private string idValue, dispValue, sortby;
        public string getTahun, getUser, getLevel;
        private string kodeKelas, kodeMapel, kodeSmt;
        DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
        DataGridViewComboBoxColumn cmb1, cmb2, cmb3 = new DataGridViewComboBoxColumn();

        public string passTahuj
        {
            get { return getTahun; }
            set { getTahun = value; }
        }

        public string passUser
        {
            get { return getUser; }
            set { getUser = value; }
        }

        public string passLevel
        {
            get { return getLevel; }
            set { getLevel = value; }
        }

        public FormNilai()
        {
            InitializeComponent();
        }

        private void FormNilai_Load(object sender, EventArgs e)
        {
            fillKelas();
            disableSorting();
        }

        public void fillKelas()
        {
            try
            {
                if (getLevel == "1")
                {
                    this.idValue = "kode_kelas";
                    this.dispValue = "nama_kelas";
                    this.table = "kelas";
                    this.cond = "status_kelas = 'Aktif' AND tahun_ajaran = '" + getTahun + "'";
                    this.sortby = "nama_kelas";
                }
                else if (getLevel == "0")
                {
                    this.idValue = "kode_kelas";
                    this.dispValue = "nama_kelas";
                    this.table = "detailmapelkelas INNER JOIN kelas USING (kode_kelas)";
                    this.cond = "status_kelas = 'Aktif' AND kelas.tahun_ajaran = '" + getTahun +
                                "' AND (kelas.id_guru IN (SELECT id_guru FROM guru WHERE nama_guru = '" + getUser +
                                "') OR detailmapelkelas.id_guru IN (SELECT id_guru FROM guru WHERE nama_guru = '" + getUser + 
                                "')) GROUP BY kode_kelas";
                    this.sortby = "nama_kelas";
                }
                kelas_combo.DataSource = db.setCombo(idValue, dispValue, table, cond, sortby);
                kelas_combo.DisplayMember = "valueDisplay";
                kelas_combo.ValueMember = "valueID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void kelasSiswa()
        {
            siswa_grid.DataSource = null;
            siswa_grid.Columns.Clear();
            siswa_grid.Rows.Clear();

            //Membuat Checkbox
            chk.ReadOnly = false;
            chk.HeaderText = "Pilih";
            siswa_grid.Columns.Add(chk);

            this.kodeKelas = this.kelas_combo.SelectedValue.ToString();
            this.field = "nis_siswa";
            this.table = "detailkelassiswa INNER JOIN siswa USING (nis_siswa)";
            this.cond = "kode_kelas = '" + kodeKelas + "' AND status_siswa = 'Aktif'";
            DataTable tabel = db.GetDataTable(field, table, cond);
            siswa_grid.DataSource = tabel;
        }

        private void kelas_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (kelas_combo.Text == "")
            {
                smt_combo.SelectedIndex = -1;
                smt_combo.Enabled = false;
            }
            else if (kelas_combo.Text != "")
            {
                smt_combo.Enabled = true;
                smt_combo.DataSource = db.getSmt();
                smt_combo.DisplayMember = "valueDisplay";
                smt_combo.ValueMember = "valueID";
            }
        }

        private void smt_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (smt_combo.Text == "")
            {
                mapel_combo.SelectedIndex = -1;
                mapel_combo.Enabled = false;
            }
            else if (smt_combo.Text != "")
            {
                mapel_combo.Enabled = true;
                kelasSiswa();
                fillMapel();
                this.jumlah_lbl.Text = "0";
                string jumlah = "SELECT count(*) as 'jumlah' FROM detailkelassiswa INNER JOIN siswa USING (nis_siswa) WHERE kode_kelas = '" + 
                                kodeKelas + "' AND status_siswa = 'Aktif'";
                myConn.Open();
                myComm = new MySqlCommand(jumlah, myConn);
                myReader = myComm.ExecuteReader();
                while (myReader.Read())
                {
                    jumlah_lbl.Text = myReader.GetString("jumlah");
                }
                myConn.Close();
            }
        }
        
        public void fillMapel()
        {
            try
            {
                if (getLevel == "1")
                {
                    this.kodeKelas = this.kelas_combo.SelectedValue.ToString();
                    this.idValue = "kode_mapel";
                    this.dispValue = "kode_mapel";
                    this.table = "detailmapelkelas";
                    this.cond = "status = 'Aktif' AND kode_kelas = '" + kodeKelas + "'";
                    this.sortby = "kode_mapel";
                }
                else if (getLevel == "0")
                {
                    this.kodeKelas = this.kelas_combo.SelectedValue.ToString();
                    this.idValue = "kode_mapel";
                    this.dispValue = "kode_mapel";
                    this.table = "detailmapelkelas INNER JOIN kelas USING (kode_kelas)";
                    this.cond = "status = 'Aktif' AND kode_kelas = '" + kodeKelas +
                                "' AND (kelas.id_guru IN (SELECT id_guru FROM guru WHERE nama_guru = '" + getUser +
                                "') OR detailmapelkelas.id_guru IN (SELECT id_guru FROM guru WHERE nama_guru = '" + getUser +
                                "')) GROUP BY kode_mapel";
                    this.sortby = "kode_mapel";
                }
                mapel_combo.DataSource = db.setCombo(idValue, dispValue, table, cond, sortby);
                mapel_combo.DisplayMember = "valueDisplay";
                mapel_combo.ValueMember = "valueID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void mapel_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((mapel_combo.Text == "") || (mapel_combo.SelectedIndex == -1))
            {
                mapel_txt.ResetText();
                wali_txt.ResetText();
                dataNilai_grid.DataSource = null;
                dataNilai_grid.Columns.Clear();
                dataNilai_grid.Rows.Clear();
            }
            else if (mapel_combo.Text != "")
            {
                this.kodeKelas = this.kelas_combo.SelectedValue.ToString();
                this.kodeMapel = this.mapel_combo.SelectedValue.ToString();
                query = "SELECT mata_pelajaran, nama_guru from detailmapelkelas INNER JOIN guru USING (id_guru)" +
                         "INNER JOIN mapel USING (kode_mapel) WHERE kode_kelas='" + kodeKelas + "' AND detailmapelkelas.kode_mapel='" +
                         kodeMapel + "'";
                MySqlCommand getProfil = new MySqlCommand(query, myConn);
                try
                {
                    myConn.Open();
                    myReader = getProfil.ExecuteReader();
                    while (myReader.Read())
                    {
                        mapel_txt.Text = myReader.GetString("mata_pelajaran");
                        wali_txt.Text = myReader.GetString("nama_guru");
                    }
                    myConn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                loadData();
                generate_nilai();
            }
        }

        public void generate_nilai()
        {
            this.kodeKelas = this.kelas_combo.SelectedValue.ToString();
            this.kodeSmt = this.smt_combo.SelectedValue.ToString();
            this.kodeMapel = this.mapel_combo.SelectedValue.ToString();
            string nis_siswa, getSiswa;

            if (jumlah_lbl.Text != "0")
            {
                foreach (DataGridViewRow row in siswa_grid.Rows)
                {
                    row.Cells[0].Value = true;
                    if (Convert.ToBoolean(row.Cells[0].Value) == true)
                    {
                        nis_siswa = row.Cells[1].Value.ToString();
                        this.nis_lbl.Text = "null";
                        getSiswa = "SELECT count(*) as 'jumlah' FROM nilai WHERE nis_siswa = '" + nis_siswa + "' AND kode_kelas = '" + kodeKelas + "' AND kode_mapel = '" + kodeMapel + "' AND kode_semester = '" + kodeSmt + "'";
                        myConn.Open();
                        myComm = new MySqlCommand(getSiswa, myConn);
                        myReader = myComm.ExecuteReader();
                        while (myReader.Read())
                        {
                            nis_lbl.Text = myReader.GetString("jumlah");
                        }
                        if (nis_lbl.Text == "0")
                        {
                            this.field = "DEFAULT, '" + nis_siswa + "', '" + kodeKelas + "', '" + kodeMapel + "', '" + kodeSmt +
                                    "', DEFAULT, NULL, NULL, DEFAULT, NULL, NULL, DEFAULT, NULL, NULL";
                            this.table = "nilai";
                            db.insertData(table, field);
                            loadData();
                        }
                        myConn.Close();
                    }
                }
                this.nis_lbl.Text = "null";
            }
            if (jumlah_lbl.Text == "0")
            {
                this.nis_lbl.Text = "null";
                this.jumlah_lbl.Text = "0";
            }
        }

        private void createNilai_toolBtn_Click(object sender, EventArgs e)
        {
            loadData();
        }

        public void loadData()
        {
            dataNilai_grid.DataSource = null;
            dataNilai_grid.Columns.Clear();
            dataNilai_grid.Rows.Clear();
            
            this.kodeKelas = this.kelas_combo.SelectedValue.ToString();
            this.kodeSmt = this.smt_combo.SelectedValue.ToString();
            this.kodeMapel = this.mapel_combo.SelectedValue.ToString();

            this.field = "id_nilai as 'ID', siswa.nis_siswa as 'NIS Siswa', nama_siswa as 'Nama Siswa', p_ang as 'Peng-Angka', p_pred as 'Peng-Predikat'" +
                        ", p_desk as 'Peng-Deskripsi', k_ang as 'Ket-Angka', k_pred as 'Ket-Predikat', k_desk as 'Ket-Deskripsi'"+
                        ", s_ang as 'SSS-Angka', s_pred as 'SSS-Predikat', s_desk as 'SSS-Deskripsi'";
            this.table = "nilai INNER JOIN siswa USING (nis_siswa)";
            this.cond = "kode_kelas = '" + kodeKelas + "' AND kode_mapel='" + kodeMapel + 
                        "' AND kode_semester = '" + kodeSmt +
                        "' AND siswa.status_siswa = 'Aktif' ORDER by nama_siswa ASC";
            DataTable tabel = db.GetDataTable(field, table, cond);
            this.dataNilai_grid.DataSource = tabel;
            
            dataNilai_grid.Columns[0].Visible = false;
            dataNilai_grid.Columns[1].ReadOnly = true;
            dataNilai_grid.Columns[2].ReadOnly = true;
            disableSorting();
        }

        private void disableSorting()
        {
            for (int i = 0; i <= dataNilai_grid.ColumnCount - 1; i++)
            {
                dataNilai_grid.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }


    }
}
