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
        private string query;
        private string table;
        private string field;
        private string cond;
        private string idValue, dispValue, sortby;
        public string getTahun, getUser, getLevel;
        private string kodeKelas, kodeMapel;

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
            //loadData();
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
                                "' AND detailmapelkelas.id_guru IN (SELECT id_guru FROM guru WHERE nama_guru = '" + getUser + "') GROUP BY kode_kelas";
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

        public void fillMapel()
        {
            try
            {
                this.kodeKelas = this.kelas_combo.SelectedValue.ToString();
                string idValue = "kode_mapel";
                string dispValue = "kode_mapel";
                this.table = "detailmapelkelas";
                this.cond = "status = 'Aktif' AND kode_kelas = '" + kodeKelas + "'";
                string sortby = "kode_mapel";

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

        public void loadData()
        {
            //this.field = "id_nilai as 'ID Nilai', nis_siswa as 'NIS Siswa', nama_siswa as 'Nama Siswa',"+ 
            //             "p_angka as 'Pengetahuan-Angka', p_predikat as 'Pengetahuan-Predikat, p_desk as 'Pengetahuan-Deskripsi'" +
            //             "";
            //this.table = "nilai INNER JOIN sis";
            //this.cond = "status_guru = 'Akthif' ORDER BY nip, nama_guru ASC";
            //DataTable tabel = db.GetDataTable(field, table, cond);
            //this.dataNilai_grid.DataSource = tabel;

            //this.query = "SELECT count(id_nilai) from nilai where "
        }

        
    }
}
