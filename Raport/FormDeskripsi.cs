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
        private string fieldVal;
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
            if (kelas_combo.Text == "")
            {
                mapel_combo.SelectedIndex = -1;
                mapel_combo.Enabled = false;
            }
            else if (kelas_combo.Text != "")
            {
                mapel_combo.Enabled = true;
                fillMapel();
            }
        }
        
        private void mapel_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((mapel_combo.Text == "") || (mapel_combo.SelectedIndex == -1))
            {
                mapel_txt.ResetText();
                wali_txt.ResetText();
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
            }
        }

        private void peng_rad_CheckedChanged(object sender, EventArgs e)
        {
            this.fieldVal = "Pengetahuan";
        }

        private void ket_rad_CheckedChanged(object sender, EventArgs e)
        {
            this.fieldVal = "Keterampilan";
        }

        private void sss_rad_CheckedChanged(object sender, EventArgs e)
        {
            this.fieldVal = "Sikap Sosial Spiritual";
        }

        //END CLASS 
    }
}
