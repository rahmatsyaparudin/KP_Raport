using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Raport
{
    public partial class FormDeskripsi : Form
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
        private string fieldVal = null;
        DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();

        public FormDeskripsi()
        {
            InitializeComponent();
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
        
        public string passTahuj
        {
            get { return getTahun; }
            set { getTahun = value; }
        }
        
        private void FormDeskripsi_Load(object sender, EventArgs e)
        {
            smt_combo.DataSource = db.getSmt();
            smt_combo.DisplayMember = "valueDisplay";
            smt_combo.ValueMember = "valueID";
            fillKelas();
        }
        
        private void fillKelas()
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
        
        private void kelas_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (kelas_combo.Text == "")
                {
                    mapel_combo.SelectedIndex = -1;
                    mapel_combo.Enabled = false;
                }
                else if ((kelas_combo.Text != "") && (kelas_combo.SelectedIndex != -1))
                {
                    mapel_combo.Enabled = true;
                    fillMapel();
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
        
        private void mapel_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if ((mapel_combo.Text == "") && (mapel_combo.SelectedIndex == -1))
                {
                    mapel_txt.ResetText();
                    wali_txt.ResetText();
                    desk_tab.Enabled = false;
                    peng_rad.Checked = false;
                    ket_rad.Checked = false;
                    sss_rad.Checked = false;
                    atas_txt.ResetText();
                    tengah_txt.ResetText();
                    bawah_txt.ResetText();
                    jumlah_lbl.Text = "null";
                }
                else if ((mapel_combo.Text != "") && (mapel_combo.SelectedIndex != -1))
                {
                    desk_tab.Enabled = true;
                    pindahKelompok();
                    this.kodeKelas = this.kelas_combo.SelectedValue.ToString();
                    this.kodeMapel = this.mapel_combo.SelectedValue.ToString();
                    query = "SELECT mata_pelajaran, nama_guru from detailmapelkelas INNER JOIN guru USING (id_guru)" +
                             "INNER JOIN mapel USING (kode_mapel) WHERE kode_kelas='" + kodeKelas + "' AND detailmapelkelas.kode_mapel='" +
                             kodeMapel + "'";
                    myComm = new MySqlCommand(query, myConn);
                    myConn.Open();
                    myReader = myComm.ExecuteReader();
                    while (myReader.Read())
                    {
                        mapel_txt.Text = myReader.GetString("mata_pelajaran");
                        wali_txt.Text = myReader.GetString("nama_guru");
                    }
                    myConn.Close();
                    generate_desk();
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
        
        private void peng_rad_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                this.fieldVal = "PENG";
                pindahKelompok();
                this.query = "SELECT p_atas, p_tengah, p_bawah FROM deskripsi" +
                             " WHERE kode_kelas = '" + kodeKelas + "' AND kode_mapel = '" + kodeMapel +
                             "' AND kode_semester = '" + kodeSmt + "'";
                myConn.Open();
                myComm = new MySqlCommand(query, myConn);
                myReader = myComm.ExecuteReader();
                while (myReader.Read())
                {
                    atas_txt.Text = myReader.GetString("p_atas");
                    tengah_txt.Text = myReader.GetString("p_tengah");
                    bawah_txt.Text = myReader.GetString("p_bawah");
                }
                myConn.Close();
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

        private void ket_rad_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                this.fieldVal = "KET";
                pindahKelompok();
                this.query = "SELECT k_atas, k_tengah, k_bawah FROM deskripsi" +
                             " WHERE kode_kelas = '" + kodeKelas + "' AND kode_mapel = '" + kodeMapel +
                             "' AND kode_semester = '" + kodeSmt + "'";
                myConn.Open();
                myComm = new MySqlCommand(query, myConn);
                myReader = myComm.ExecuteReader();
                while (myReader.Read())
                {
                    atas_txt.Text = myReader.GetString("k_atas");
                    tengah_txt.Text = myReader.GetString("k_tengah");
                    bawah_txt.Text = myReader.GetString("k_bawah");
                }
                myConn.Close();
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

        private void sss_rad_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                this.fieldVal = "SSS";
                pindahKelompok();
                this.query = "SELECT s_atas, s_tengah, s_bawah FROM deskripsi" +
                             " WHERE kode_kelas = '" + kodeKelas + "' AND kode_mapel = '" + kodeMapel +
                             "' AND kode_semester = '" + kodeSmt + "'";
                myConn.Open();
                myComm = new MySqlCommand(query, myConn);
                myReader = myComm.ExecuteReader();
                while (myReader.Read())
                {
                    atas_txt.Text = myReader.GetString("s_atas");
                    tengah_txt.Text = myReader.GetString("s_tengah");
                    bawah_txt.Text = myReader.GetString("s_bawah");
                }
                myConn.Close();
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

        private void generate_desk()
        {
            this.kodeKelas = this.kelas_combo.SelectedValue.ToString();
            this.kodeSmt = this.smt_combo.SelectedValue.ToString();
            this.kodeMapel = this.mapel_combo.SelectedValue.ToString();
            
            jumlah_lbl.Text = "null";
            string query2 = "SELECT count(*) as 'total' FROM deskripsi WHERE kode_kelas = '" + kodeKelas + 
                         "' AND kode_mapel = '" + kodeMapel + "' AND kode_semester = '" + kodeSmt + "'";
            myConn.Open();
            myComm = new MySqlCommand(query2, myConn);
            myReader = myComm.ExecuteReader();
            while (myReader.Read())
            {
                jumlah_lbl.Text = myReader.GetString("total");
            }
            myConn.Close();

            if ((jumlah_lbl.Text == "0") && (kodeMapel != "System.Data.DataRowView"))
            {
                this.field = "DEFAULT, '" + kodeKelas + "', '" + kodeMapel + "', '" + kodeSmt +
                        "', DEFAULT, DEFAULT, DEFAULT, DEFAULT, DEFAULT, DEFAULT, DEFAULT, DEFAULT, DEFAULT";
                this.table = "deskripsi";
                db.insertData(table, field);
            }
            else if (jumlah_lbl.Text != "0")
            {

            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (fieldVal == "PENG")
                {
                    field = "p_atas = '" + atas_txt.Text.Replace("'", "''") + "', p_tengah = '"
                                + tengah_txt.Text.Replace("'", "''") + "', p_bawah = '" + bawah_txt.Text.Replace("'", "''") + "'";
                }
                if (fieldVal == "KET")
                {
                    field = "k_atas = '" + atas_txt.Text.Replace("'", "''") + "', k_tengah = '"
                            + tengah_txt.Text.Replace("'", "''") + "', k_bawah = '" + bawah_txt.Text.Replace("'", "''") + "'";
                }

                if (fieldVal == "SSS")
                {
                    this.field = "s_atas = '" + atas_txt.Text.Replace("'", "''") + "', s_tengah = '"
                        + tengah_txt.Text.Replace("'", "''") + "', s_bawah = '" + bawah_txt.Text.Replace("'", "''") + "'";
                }

                this.table = "deskripsi";
                this.cond = "kode_kelas = '" + kelas_combo.SelectedValue.ToString() + "' AND kode_mapel = '" + mapel_combo.SelectedValue.ToString() +
                            "' AND kode_semester = '" + smt_combo.SelectedValue.ToString() + "'";
                db.updateData(table, field, cond);
                save_btn.Enabled = false;
                reset_btn.Enabled = false;
                atas_txt.Enabled = false;
                bawah_txt.Enabled = false;
                tengah_txt.Enabled = false;
                edit_btn.Text = "Edit";
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

        private void reset_btn_Click(object sender, EventArgs e)
        {
            atas_txt.Undo();
            tengah_txt.Undo();
            bawah_txt.Undo();
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            if (edit_btn.Text == "Edit")
            {
                save_btn.Enabled = true;
                reset_btn.Enabled = true;
                atas_txt.Enabled = true;
                bawah_txt.Enabled = true;
                tengah_txt.Enabled = true;
                edit_btn.Text = "Cancel";
            }
            else if (edit_btn.Text == "Cancel")
            {
                pindahKelompok();
            }
        }

        public void pindahKelompok()
        {
            save_btn.Enabled = false;
            reset_btn.Enabled = false;
            atas_txt.Enabled = false;
            bawah_txt.Enabled = false;
            tengah_txt.Enabled = false;
            edit_btn.Text = "Edit";
            atas_txt.ResetText();
            tengah_txt.ResetText();
            bawah_txt.ResetText();
        }
        //END CLASS 
    }
}
