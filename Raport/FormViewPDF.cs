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
    public partial class FormViewPDF : Form
    {
        private string table, cond, field;
        private string query;
        public bool valType;
        public string getTahun, getValue, getFormat;
        MySqlConnection myConn = Function.getKoneksi();
        Function db = new Function();
        MySqlDataReader myReader;
        MySqlCommand myComm;
        
        public FormViewPDF()
        {
            InitializeComponent();
        }

        public string passTahun
        {
            get { return getTahun; }
            set { getTahun = value; }
        }

        public string passValue
        {
            get { return getValue; }
            set { getValue = value; }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            //PDFReader.src = @"C:\Users\Sri Musniati\Pictures\Print\Format Penilaian Ujian Siswa.pdf";
        }

        private void FormViewPDF_Load(object sender, EventArgs e)
        {
            loadKelas();
            semester_combo.DataSource = db.getSmt();
            semester_combo.DisplayMember = "valueDisplay";
            semester_combo.ValueMember = "valueID";
            if (getValue.Equals("Raport"))
            {
                saveAs_btn.Text = "Save as PDF";
                print_btn.Visible = true;
            }
            else if (getValue.Equals("Nilai"))
            {
                saveAs_btn.Text = "Save as Excel";
                print_btn.Visible = false;
            }
            else if (getValue.Equals("Format"))
            {
                saveAs_btn.Text = "Save as PDF";
                print_btn.Visible = true;
                saveAs_btn.Enabled = true;
                print_btn.Enabled = true;
                kelas_combo.Enabled = false;
                semester_combo.Enabled = false;
            }
        }
        
        private void loadKelas()
        {
            try
            {
                string idValue = "kode_kelas";
                string dispValue = "nama_kelas";
                string sortby = "nama_kelas";
                table = "kelas";
                cond = "status_kelas = 'Aktif' AND tahun_ajaran = '" + getTahun + "'";
                kelas_combo.DataSource = db.setCombo(idValue, dispValue, table, cond, sortby);
                kelas_combo.DisplayMember = "valueDisplay"; kelas_combo.ValueMember = "valueID";
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

        private void kelas_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(kelas_combo.Text))
            {
                semester_combo.Enabled = false;
                semester_combo.SelectedIndex = -1;
            }
            else if (!String.IsNullOrEmpty(kelas_combo.Text))
            {
                semester_combo.Enabled = true;
            }   
        }

        private void semester_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(semester_combo.Text))
            {
                print_btn.Enabled = false;
                saveAs_btn.Enabled = false;
            }
            else
            {
                print_btn.Enabled = true;
                saveAs_btn.Enabled = true;
            }
        }

        private void saveAs_btn_Click(object sender, EventArgs e)
        {
            DataToPDF dbToPDF = new DataToPDF();
            DataToExcel dbToExcel = new DataToExcel();
            if (getValue.Equals("Raport"))
            {
                string kode_kelas = kelas_combo.SelectedValue.ToString();
                string semester = semester_combo.SelectedValue.ToString();
                dbToPDF.passTahun = getTahun;
                dbToPDF.passKode = kode_kelas;
                dbToPDF.passSemester = semester;
                dbToPDF.passValue = "SaveAsRaport";
                dbToPDF.RaportKelasToPDF();
                db.BrowserDialog(fbDialog, "Data Nilai");
                this.Close();
            }
            else if (getValue.Equals("Nilai"))
            {
                string kodeKelas = kelas_combo.SelectedValue.ToString();
                string semester = semester_combo.SelectedValue.ToString();
                dbToExcel.passTahun = getTahun;
                dbToExcel.NilaiToExcel("Tidak Aktif", kodeKelas, semester);
                db.BrowserDialog(fbDialog, "Data Nilai");
                this.Close();
            }
            else if (getValue.Equals("Format"))
            {
                dbToPDF.passTahun = getTahun;
                dbToPDF.passValue = "SaveAsFormat";
                dbToPDF.FormatNilaiPDF();
                db.BrowserDialog(fbDialog, "SaveAs");
                this.Close();
            }
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            DataToPDF dbToPDF = new DataToPDF();
            if (getValue.Equals("Raport"))
            {
                string kode_kelas = kelas_combo.SelectedValue.ToString();
                string semester = semester_combo.SelectedValue.ToString();
                dbToPDF.passTahun = getTahun;
                dbToPDF.passKode = kode_kelas;
                dbToPDF.passSemester = semester;
                dbToPDF.passValue = "PrintRaport";
                dbToPDF.RaportKelasToPDF();
                string print = dbToPDF.getFormat.ToString();
                db.SendToPrinter(print);
                this.Close();
            }
            else if (getValue.Equals("Format"))
            {
                dbToPDF.passTahun = getTahun;
                dbToPDF.passValue = "PrintFormat";
                dbToPDF.FormatNilaiPDF();
                string print = dbToPDF.getFormat.ToString();
                db.SendToPrinter(print);
                this.Close();
            }
        }
    }
}
