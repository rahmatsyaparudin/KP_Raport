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
        MySqlDataReader myReader;
        MySqlCommand myComm;
        private string query;
        private string table, field, cond;
        private string idValue, dispValue, sortby;
        public string getTahun, getUser, getLevel;
        private string kodeKelas, kodeMapel, kodeSmt;
        DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
        
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
            disableSorting();
            smt_combo.DataSource = db.getSmt();
            smt_combo.DisplayMember = "valueDisplay";
            smt_combo.ValueMember = "valueID";
            fillKelas();
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

        private void dataNilai_grid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex >= 0) && (e.RowIndex != -1))
            {
                try
                {
                    string inputString1, inputString2, inputString3;
                    int numVal1, numVal2, numVal3;
                    float result1, result2;
                    DataGridViewRow row = this.dataNilai_grid.Rows[e.RowIndex];
                    
                    if (dataNilai_grid.CurrentCell.ColumnIndex.Equals(3) && e.RowIndex != -1)
                    {
                        //Nilai skala untuk Pengetahuan (0-100)
                        if (Convert.ToInt16(row.Cells[3].Value) >= 0 &&
                            Convert.ToInt16(row.Cells[3].Value) <= 100)
                        {
                            inputString1 = row.Cells[3].Value.ToString();
                            numVal1 = Int16.Parse(inputString1);
                            result1 = (float)numVal1 / 25;
                            row.Cells[4].Value = result1;
                            row.Cells[3].Value = numVal1;
                            row.Cells[3].Style.BackColor = Color.LightSkyBlue;
                        }
                        //Jika nilai skala pengetahuan tidak antara 0-100
                        else if (Convert.ToInt16(row.Cells[3].Value) < 0 ||
                            Convert.ToInt16(row.Cells[3].Value) > 100)
                        {
                            MessageBox.Show("Nilai skala antara 0 dan 100");
                            row.Cells[3].Value = Int16.Parse(peng_lbl.ToString());
                            row.Cells[3].Style.BackColor = Color.Yellow;
                        }

                        //Predikat untuk Pengetahuan
                        if (Convert.ToDouble(dataNilai_grid.CurrentRow.Cells[4].Value) >= 3.85 &&
                                Convert.ToDouble(dataNilai_grid.CurrentRow.Cells[4].Value) <= 4.0)
                        {
                            dataNilai_grid.CurrentRow.Cells[5].Value = "A";
                        }
                        else if (Convert.ToDouble(dataNilai_grid.CurrentRow.Cells[4].Value) >= 3.51 &&
                                Convert.ToDouble(dataNilai_grid.CurrentRow.Cells[4].Value) <= 3.84)
                        {
                            dataNilai_grid.CurrentRow.Cells[5].Value = "A-";
                        }
                        else if (Convert.ToDouble(dataNilai_grid.CurrentRow.Cells[4].Value) >= 3.18 &&
                            Convert.ToDouble(dataNilai_grid.CurrentRow.Cells[4].Value) <= 3.50)
                        {
                            dataNilai_grid.CurrentRow.Cells[5].Value = "B+";
                        }
                        else if (Convert.ToDouble(dataNilai_grid.CurrentRow.Cells[4].Value) >= 2.85 &&
                            Convert.ToDouble(dataNilai_grid.CurrentRow.Cells[4].Value) <= 3.17)
                        {
                            dataNilai_grid.CurrentRow.Cells[5].Value = "B";
                        }
                        else if (Convert.ToDouble(dataNilai_grid.CurrentRow.Cells[4].Value) >= 2.51 &&
                            Convert.ToDouble(dataNilai_grid.CurrentRow.Cells[4].Value) <= 2.84)
                        {
                            dataNilai_grid.CurrentRow.Cells[5].Value = "B-";
                        }
                        else if (Convert.ToDouble(dataNilai_grid.CurrentRow.Cells[4].Value) >= 2.18 &&
                            Convert.ToDouble(dataNilai_grid.CurrentRow.Cells[4].Value) <= 2.50)
                        {
                            dataNilai_grid.CurrentRow.Cells[5].Value = "C+";
                        }
                        else if (Convert.ToDouble(dataNilai_grid.CurrentRow.Cells[4].Value) >= 1.85 &&
                            Convert.ToDouble(dataNilai_grid.CurrentRow.Cells[4].Value) <= 2.17)
                        {
                            dataNilai_grid.CurrentRow.Cells[5].Value = "C";
                        }
                        else if (Convert.ToDouble(dataNilai_grid.CurrentRow.Cells[4].Value) >= 1.51 &&
                            Convert.ToDouble(dataNilai_grid.CurrentRow.Cells[4].Value) <= 1.84)
                        {
                            dataNilai_grid.CurrentRow.Cells[5].Value = "C-";
                        }
                        else if (Convert.ToDouble(dataNilai_grid.CurrentRow.Cells[4].Value) >= 1.18 &&
                            Convert.ToDouble(dataNilai_grid.CurrentRow.Cells[4].Value) <= 1.50)
                        {
                            dataNilai_grid.CurrentRow.Cells[5].Value = "D+";
                        }
                        else if (Convert.ToDouble(dataNilai_grid.CurrentRow.Cells[4].Value) >= 0 &&
                            Convert.ToDouble(dataNilai_grid.CurrentRow.Cells[4].Value) <= 1.17)
                        {
                            dataNilai_grid.CurrentRow.Cells[5].Value = "D";
                        }
                    }

                    if (dataNilai_grid.CurrentCell.ColumnIndex.Equals(7) && e.RowIndex != -1)
                    {
                        //Nilai skala untuk Keterampilan (0-100)
                        if (Convert.ToInt16(row.Cells[7].Value) >= 0 &&
                            Convert.ToInt16(row.Cells[7].Value) <= 100)
                        {
                            inputString2 = row.Cells[7].Value.ToString();
                            numVal2 = Int16.Parse(inputString2);
                            result2 = (float)numVal2 / 25;
                            row.Cells[8].Value = result2;
                            row.Cells[7].Value = numVal2;
                            row.Cells[7].Style.BackColor = Color.LightSkyBlue;
                        }
                        //Jika nilai skala keterampilan tidak antara 0-100
                        else if (Convert.ToInt16(row.Cells[7].Value) < 0 ||
                            Convert.ToInt16(row.Cells[7].Value) > 100)
                        {
                            MessageBox.Show("Nilai skala antara 0 dan 100");
                            row.Cells[7].Value = Int16.Parse(ket_lbl.ToString());
                            row.Cells[7].Style.BackColor = Color.Yellow;
                        }

                        //Predikat untuk Keterampilan
                        if (Convert.ToDouble(dataNilai_grid.CurrentRow.Cells[8].Value) >= 3.85 &&
                                Convert.ToDouble(dataNilai_grid.CurrentRow.Cells[8].Value) <= 4.0)
                        {
                            dataNilai_grid.CurrentRow.Cells[9].Value = "A";
                        }
                        else if (Convert.ToDouble(dataNilai_grid.CurrentRow.Cells[8].Value) >= 3.51 &&
                                Convert.ToDouble(dataNilai_grid.CurrentRow.Cells[8].Value) <= 3.84)
                        {
                            dataNilai_grid.CurrentRow.Cells[9].Value = "A-";
                        }
                        else if (Convert.ToDouble(dataNilai_grid.CurrentRow.Cells[8].Value) >= 3.18 &&
                            Convert.ToDouble(dataNilai_grid.CurrentRow.Cells[8].Value) <= 3.50)
                        {
                            dataNilai_grid.CurrentRow.Cells[9].Value = "B+";
                        }
                        else if (Convert.ToDouble(dataNilai_grid.CurrentRow.Cells[8].Value) >= 2.85 &&
                            Convert.ToDouble(dataNilai_grid.CurrentRow.Cells[8].Value) <= 3.17)
                        {
                            dataNilai_grid.CurrentRow.Cells[9].Value = "B";
                        }
                        else if (Convert.ToDouble(dataNilai_grid.CurrentRow.Cells[8].Value) >= 2.51 &&
                            Convert.ToDouble(dataNilai_grid.CurrentRow.Cells[8].Value) <= 2.84)
                        {
                            dataNilai_grid.CurrentRow.Cells[9].Value = "B-";
                        }
                        else if (Convert.ToDouble(dataNilai_grid.CurrentRow.Cells[8].Value) >= 2.18 &&
                            Convert.ToDouble(dataNilai_grid.CurrentRow.Cells[8].Value) <= 2.50)
                        {
                            dataNilai_grid.CurrentRow.Cells[9].Value = "C+";
                        }
                        else if (Convert.ToDouble(dataNilai_grid.CurrentRow.Cells[8].Value) >= 1.85 &&
                            Convert.ToDouble(dataNilai_grid.CurrentRow.Cells[8].Value) <= 2.17)
                        {
                            dataNilai_grid.CurrentRow.Cells[9].Value = "C";
                        }
                        else if (Convert.ToDouble(dataNilai_grid.CurrentRow.Cells[8].Value) >= 1.51 &&
                            Convert.ToDouble(dataNilai_grid.CurrentRow.Cells[8].Value) <= 1.84)
                        {
                            dataNilai_grid.CurrentRow.Cells[9].Value = "C-";
                        }
                        else if (Convert.ToDouble(dataNilai_grid.CurrentRow.Cells[8].Value) >= 1.18 &&
                            Convert.ToDouble(dataNilai_grid.CurrentRow.Cells[8].Value) <= 1.50)
                        {
                            dataNilai_grid.CurrentRow.Cells[9].Value = "D+";
                        }
                        else if (Convert.ToDouble(dataNilai_grid.CurrentRow.Cells[8].Value) >= 0 &&
                            Convert.ToDouble(dataNilai_grid.CurrentRow.Cells[8].Value) <= 1.17)
                        {
                            dataNilai_grid.CurrentRow.Cells[9].Value = "D";
                        }
                    }

                    if (dataNilai_grid.CurrentCell.ColumnIndex.Equals(11) && e.RowIndex != -1)
                    {
                        
                        //Nilai skala untuk Sikap dan Spiritual (0-100)
                        if (Convert.ToInt16(row.Cells[11].Value) >= 0 &&
                        Convert.ToInt16(row.Cells[11].Value) <= 100)
                        {
                            inputString3 = row.Cells[11].Value.ToString();
                            numVal3 = Int16.Parse(inputString3);
                            row.Cells[11].Value = numVal3;
                            row.Cells[11].Style.BackColor = Color.LightSkyBlue;
                        }
                        //Jika nilai skala Sikap dan Spiritual tidak antara 0-100
                        else if (Convert.ToInt16(row.Cells[11].Value) < 0 ||
                            Convert.ToInt16(row.Cells[11].Value) > 100)
                        {
                            MessageBox.Show("Nilai skala antara 0 dan 100");
                            row.Cells[11].Value = Int16.Parse(sikap_lbl.ToString());
                            row.Cells[11].Style.BackColor = Color.Yellow;
                        }

                        //Predikat untuk Sikap dan Spiritual
                        if (Convert.ToInt16(dataNilai_grid.CurrentRow.Cells[11].Value) >= 0 &&
                                Convert.ToInt16(dataNilai_grid.CurrentRow.Cells[11].Value) <= 25)
                        {
                            dataNilai_grid.CurrentRow.Cells[12].Value = "K";
                        }
                        else if (Convert.ToInt16(dataNilai_grid.CurrentRow.Cells[11].Value) >= 26 &&
                                Convert.ToInt16(dataNilai_grid.CurrentRow.Cells[11].Value) <= 50)
                        {
                            dataNilai_grid.CurrentRow.Cells[12].Value = "C";
                        }
                        else if (Convert.ToInt16(dataNilai_grid.CurrentRow.Cells[11].Value) >= 51 &&
                                Convert.ToInt16(dataNilai_grid.CurrentRow.Cells[11].Value) <= 75)
                        {
                            dataNilai_grid.CurrentRow.Cells[12].Value = "B";
                        }
                        else if (Convert.ToInt16(dataNilai_grid.CurrentRow.Cells[11].Value) >= 76 &&
                                Convert.ToInt16(dataNilai_grid.CurrentRow.Cells[11].Value) <= 100)
                        {
                            dataNilai_grid.CurrentRow.Cells[12].Value = "SB";
                        }
                    }
                }
                catch (InvalidCastException cast)
                {
                    //MessageBox.Show("Data Tidak boleh kosong (0-100)");
                }
            }
        }

        private void dataNilai_grid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dataNilai_grid.Rows[e.RowIndex];
                this.field = "p_skala = '" + row.Cells[3].Value.ToString() +
                             "', p_ang = '" + row.Cells[4].Value.ToString() +
                             "', p_pred = '" + row.Cells[5].Value.ToString() +
                             "', p_desk = '" + row.Cells[6].Value.ToString() +
                             "', k_skala = '" + row.Cells[7].Value.ToString() +
                             "', k_ang = '" + row.Cells[8].Value.ToString() +
                             "', k_pred = '" + row.Cells[9].Value.ToString() +
                             "', k_desk = '" + row.Cells[10].Value.ToString() +
                             "', s_skala = '" + row.Cells[11].Value.ToString() +
                             "', s_sikap = '" + row.Cells[12].Value.ToString() +
                             "', s_desk = '" + row.Cells[13].Value.ToString() + "'";
                this.table = "nilai";
                this.cond = "id_nilai = '" + row.Cells[0].Value.ToString() + "'";
                db.updateData(table, field, cond);
            }
            catch
            {
                
            }
        }
        
        private void dataNilai_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex >= 0) && (e.RowIndex != -1))
            {
                DataGridViewRow row = this.dataNilai_grid.Rows[e.RowIndex];
                peng_lbl.Text = row.Cells[3].Value.ToString();
                ket_lbl.Text = row.Cells[7].Value.ToString();
                sikap_lbl.Text = row.Cells[11].Value.ToString();
            }

            if (dataNilai_grid.CurrentCell.ColumnIndex.Equals(6) && e.RowIndex != -1)
            {
                MessageBox.Show(dataNilai_grid.CurrentCell.Value.ToString());
            }
        }

        private void dataNilai_grid_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            DataGridViewRow row = this.dataNilai_grid.Rows[e.RowIndex];

            if (dataNilai_grid.CurrentCell.ColumnIndex.Equals(3) && e.RowIndex != -1)
            {
                MessageBox.Show("Ada kesalahan Input pada Nilai Skala (P) \nTekan ENTER untuk EDIT \nTekan ESC Data tidak berubah");
                row.Cells[3].Value = Int16.Parse(peng_lbl.ToString());
                row.Cells[3].Style.BackColor = Color.Yellow;
            }

            if (dataNilai_grid.CurrentCell.ColumnIndex.Equals(7) && e.RowIndex != -1)
            {
                MessageBox.Show("Ada kesalahan Input pada Nilai Skala (P) \nTekan ENTER untuk EDIT \nTekan ESC Data tidak berubah");
                row.Cells[7].Value = Int16.Parse(ket_lbl.ToString());
                row.Cells[7].Style.BackColor = Color.Yellow;
            }

            if (dataNilai_grid.CurrentCell.ColumnIndex.Equals(11) && e.RowIndex != -1)
            {
                MessageBox.Show("Ada kesalahan Input pada Nilai Skala (P) \nTekan ENTER untuk EDIT \nTekan ESC Data tidak berubah");
                row.Cells[11].Value = Int16.Parse(sikap_lbl.ToString());
                row.Cells[11].Style.BackColor = Color.Yellow;
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
                mapel_combo.SelectedIndex = -1;
                mapel_combo.Enabled = false;
            }
            else if (kelas_combo.Text != "")
            {
                mapel_combo.Enabled = true;
                kelasSiswa();
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
                fillMapel();
            }
        }

        private void load_toolBtn_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void dataNilai_grid_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewTextBoxColumn cPeng = (DataGridViewTextBoxColumn)dataNilai_grid.Columns[3];
            cPeng.MaxInputLength = 3;
            DataGridViewTextBoxColumn cKet = (DataGridViewTextBoxColumn)dataNilai_grid.Columns[7];
            cKet.MaxInputLength = 3;
            DataGridViewTextBoxColumn cSik = (DataGridViewTextBoxColumn)dataNilai_grid.Columns[11];
            cSik.MaxInputLength = 3;
        }

        private void set_btn_Click(object sender, EventArgs e)
        {
            if (smt_combo.Text != "")
            {
                if (set_btn.Text == "Set")
                {
                    smt_combo.Enabled = false;
                    set_btn.Text = "Edit";
                    kelas_combo.Enabled = true;
                }
                else if (set_btn.Text == "Edit")
                {
                    kelas_combo.SelectedIndex = -1;
                    kelas_combo.Enabled = false;
                    set_btn.Text = "Set";
                    smt_combo.Enabled = true;
                }
            }
            else if (smt_combo.Text == "")
            {
                kelas_combo.SelectedIndex = -1;
                kelas_combo.Enabled = false;
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
                load_toolBtn.Enabled = false;
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
                load_toolBtn.Enabled = true;
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
                                    "', DEFAULT, DEFAULT, DEFAULT, DEFAULT, DEFAULT, DEFAULT, DEFAULT, DEFAULT, DEFAULT, DEFAULT, DEFAULT";
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

            this.field = "id_nilai as 'ID Nilai', siswa.nis_siswa as 'NIS Siswa', nama_siswa as 'Nama Siswa', p_skala as 'Skala (P)', p_ang as 'Angka (P)', p_pred as 'Predikat (P)'" +
                        ", p_desk as 'Deskripsi (P)', k_skala as 'Skala (K)', k_ang as 'Angka (K)', k_pred as 'Predikat (K)', k_desk as 'Deskripsi (K)'"+
                        ", s_skala as 'Skala (S)', s_sikap as 'SB/B/C/K', s_desk as 'Deskripsi (S)'";
            this.table = "nilai INNER JOIN siswa USING (nis_siswa)";
            this.cond = "kode_kelas = '" + kodeKelas + "' AND kode_mapel='" + kodeMapel + 
                        "' AND kode_semester = '" + kodeSmt +
                        "' AND siswa.status_siswa = 'Aktif' ORDER by nama_siswa ASC";
            DataTable tabel = db.GetDataTable(field, table, cond);
            this.dataNilai_grid.DataSource = tabel;


            dataNilai_grid.Columns[3].DefaultCellStyle.BackColor = Color.LimeGreen;
            dataNilai_grid.Columns[7].DefaultCellStyle.BackColor = Color.LimeGreen;
            dataNilai_grid.Columns[11].DefaultCellStyle.BackColor = Color.LimeGreen;
            dataNilai_grid.Columns[0].Visible = false;
            dataNilai_grid.Columns[1].ReadOnly = true;
            dataNilai_grid.Columns[2].ReadOnly = true;
            dataNilai_grid.Columns[4].ReadOnly = true;
            dataNilai_grid.Columns[5].ReadOnly = true;
            dataNilai_grid.Columns[8].ReadOnly = true;
            dataNilai_grid.Columns[9].ReadOnly = true;
            dataNilai_grid.Columns[12].ReadOnly = true;
            dataNilai_grid.Columns[13].ReadOnly = true;
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
