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
    public partial class FormAddMapel : Form
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
        public string getKodeKelas;
        DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
        DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();

        public FormAddMapel()
        {
            InitializeComponent();
        }

        private void FormAddMapel_Load(object sender, EventArgs e)
        {
            create_schedule();
        }

        private void schedule_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in schedule_grid.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value) == false)
                {
                    row.Cells[5].ReadOnly = true;
                }
                else
                {
                    row.Cells[5].ReadOnly = false;
                }
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string passKodeKelas
        {
            get { return getKodeKelas; }
            set { getKodeKelas = value; }
        }

        public void create_schedule()
        {
            try
            {
                //Membuat Checkbox
                chk.ReadOnly = false;
                chk.HeaderText = "Pilih";
                schedule_grid.Columns.Add(chk);

                //Mengisi datagrid dari database
                this.field = "kode_mapel as 'Kode Mapel', kategori_mapel as 'Kategori Mapel', mata_pelajaran as 'Mata Pelajaran', jam_pelajaran as 'JP'";
                this.table = "mapel";
                this.cond = "status_mapel = 'Aktif' AND kode_mapel NOT IN (SELECT kode_mapel FROM detailmapelkelas WHERE kode_kelas = '" + getKodeKelas + "') ORDER BY kategori_mapel";
                DataTable tabel = db.GetDataTable(field, table, cond);
                this.schedule_grid.DataSource = tabel;

                //Membuat combobox guru Mapel
                cmb.HeaderText = "Pengajar Mapel (Wajib Diisi)";
                cmb.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                cmb.ReadOnly = false;
                cmb.MaxDropDownItems = 5;

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

                schedule_grid.Columns[1].Visible = false;
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

        private void create_btn_Click(object sender, EventArgs e)
        {
            char notif;
            notif = 'A';
            foreach (DataGridViewRow row in schedule_grid.Rows)
            {
                if ((Convert.ToBoolean(row.Cells[0].Value) == true) &&
                        (Convert.ToString(row.Cells[5].Value) != ""))
                {
                    this.idGuru = row.Cells[5].Value.ToString();
                    this.kodeMapel = row.Cells[1].Value.ToString();
                    this.kodeKelas = getKodeKelas;
                    this.table = "detailmapelkelas";
                    this.field = "DEFAULT, '" + kodeKelas + "', '" + kodeMapel +
                                 "', '" + idGuru + "', DEFAULT";
                    db.insertData(table, field);
                    notif = 'B';
                }
                else if ((Convert.ToBoolean(row.Cells[0].Value) == true) &&
                    (Convert.ToString(row.Cells[5].Value) == ""))
                {
                    string warning = row.Cells[3].Value.ToString();
                    MessageBox.Show(row.Cells[3].Value.ToString() + " belum ditambahkan ke jadwal");
                }
            }

            if (notif == 'A')
            {
                MessageBox.Show("Jadwal belum dibuat!");
            }
            else if (notif == 'B')
            {
                MessageBox.Show("Jadwal Kelas berhasil dibuat!");
                this.Close();
            }
        }
    }
}
