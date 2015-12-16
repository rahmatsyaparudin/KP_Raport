using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Raport
{
    public partial class FormPindahKelas : Form
    {
        MySqlConnection myConn = Function.getKoneksi();
        Function db = new Function();
        MySqlDataReader myReader;
        private string query;
        private string table, cond;
        public string getTahun, getUser, getLevel, getKelas, getText;
        
        public FormPindahKelas()
        {
            InitializeComponent();
        }
        
        public string passTahuj
        {
            get { return getTahun; }
            set { getTahun = value; }
        }

        public string passText
        {
            get { return getText; }
            set { getText = value; }
        }

        public string passKelas
        {
            get { return getKelas; }
            set { getKelas = value; }
        }
        
        private void FormPindahKelas_Load(object sender, EventArgs e)
        {
            tahun_combo.DataSource = db.getTahuj();
            tahun_combo.DisplayMember = "valueDisplay";
            tahun_combo.SelectedIndex = Convert.ToInt16(getTahun);
            fillKelas();
            setKelas();
        }

        private void tahun_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tahun_combo.Text == "")
            {

            }
            else if (tahun_combo.Text != "")
            {
                fillKelas();
            }
        }

        public void setKelas()
        {
            string tahuj = tahun_combo.GetItemText(tahun_combo.Items[Convert.ToInt16(getTahun)]).ToString();
            try
            {
                this.query = "SELECT kode_kelas from kelas where nama_kelas = '" + getKelas + "' AND tahun_ajaran = '" + tahuj + "'";
                MySqlCommand myComm = new MySqlCommand(query, myConn);
                myConn.Open();
                myReader = myComm.ExecuteReader();
                while (myReader.Read())
                {
                    kode_lbl.Text  = myReader.GetString("kode_kelas");
                }
                myConn.Close();
                kelas_combo.SelectedValue = kode_lbl.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void fillKelas()
        {
            string tahun = tahun_combo.Text.ToString();
            try
            {
                string idValue = "kode_kelas";
                string dispValue = "nama_kelas";
                this.table = "kelas";
                this.cond = "status_kelas = 'Aktif' AND tahun_ajaran = '" + tahun + "'";
                string sortby = "nama_kelas";

                kelas_combo.DataSource = db.setCombo(idValue, dispValue, table, cond, sortby);
                kelas_combo.DisplayMember = "valueDisplay";
                kelas_combo.ValueMember = "valueID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void edit_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (edit_link.Text.Equals("Edit"))
            {
                tahun_combo.Enabled = true;
                kelas_combo.Enabled = true;
                edit_link.Text = "Cancel";
            }
            else if (edit_link.Text.Equals("Cancel"))
            {
                tahun_combo.Enabled = false;
                kelas_combo.Enabled = false;
                edit_link.Text = "Edit";
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            passText = "Cancel";
            this.Close();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            passText = "Create";
            passKelas = kelas_combo.SelectedValue.ToString();
            passTahuj = tahun_combo.SelectedValue.ToString();
            this.Close();
        }
    }
}
