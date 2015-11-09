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
        private string idGuru, kodeMapel, kodeKelas;
        public string getKodeKelas, kodeIdGuru;
        DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
        DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();

        public FormAddMapel()
        {
            InitializeComponent();
        }

        public string passKodeKelas
        {
            get { return getKodeKelas; }
            set { getKodeKelas = value; }
        }

        public string passIdGuru
        {
            get { return kodeIdGuru; }
            set { kodeIdGuru = value; }
        }

        private void FormAddMapel_Load(object sender, EventArgs e)
        {
            create_schedule();
        }

        private void schedule_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex >= 0) && (e.RowIndex != -1))
            {
                DataGridViewRow row = this.schedule_grid.Rows[e.RowIndex];
                var cmb = (DataGridViewComboBoxCell)schedule_grid.CurrentRow.Cells[5];
                schedule_grid.CurrentRow.Cells[5].Value = null;
                cmb.DataSource = null;
                cmb.Items.Clear();
                this.kodeMapel = row.Cells["Kode Mapel"].Value.ToString();
                string idValue = "id_guru";
                string dispValue = "nama_guru";
                this.table = "detailmapelguru INNER JOIN guru USING (id_guru)";
                this.cond = "status = 'Aktif' AND kode_mapel = '" + kodeMapel + "'";
                string sortby = "nama_guru";
                cmb.DataSource = db.setCombo(idValue, dispValue, table, cond, sortby);
                cmb.DisplayMember = "valueDisplay";
                cmb.ValueMember = "valueID";
            }
            
            foreach (DataGridViewRow row in schedule_grid.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value) == false)
                {
                    row.Cells[5].ReadOnly = true;
                }
                else if (Convert.ToBoolean(row.Cells[0].Value) == true)
                {
                    row.Cells[5].ReadOnly = false;
                }
            }

        }

        private void schedule_grid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
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
                if (passKodeKelas != null)
                {
                    this.field = "kode_mapel as 'Kode Mapel', kategori_mapel as 'Kategori Mapel', mata_pelajaran as 'Mata Pelajaran', jam_pelajaran as 'JP'";
                    this.table = "mapel";
                    this.cond = "status_mapel = 'Aktif' AND kode_mapel NOT IN (SELECT kode_mapel FROM detailmapelkelas WHERE kode_kelas = '" + getKodeKelas + "' AND status = 'Aktif') ORDER BY kategori_mapel";
                    DataTable tabel = db.GetDataTable(field, table, cond);
                    this.schedule_grid.DataSource = tabel;
                }

                if (passIdGuru != null)
                {
                    this.field = "kode_mapel as 'Kode Mapel', kategori_mapel as 'Kategori Mapel', mata_pelajaran as 'Mata Pelajaran', jam_pelajaran as 'JP'";
                    this.table = "mapel";
                    this.cond = "status_mapel = 'Aktif' AND kode_mapel NOT IN (SELECT kode_mapel FROM detailmapelguru WHERE id_guru = '" + passIdGuru + "' AND status = 'Aktif') ORDER BY kategori_mapel";
                    DataTable tabel = db.GetDataTable(field, table, cond);
                    this.schedule_grid.DataSource = tabel;
                }

                //Membuat combobox guru Mapel
                cmb.HeaderText = "Pengajar Mapel (Wajib Diisi)";
                cmb.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                cmb.ReadOnly = false;
                cmb.MaxDropDownItems = 5;

                //Mengisi combobox guru dari database
                
                
                schedule_grid.Columns.Add(cmb);

                if (passIdGuru != null)
                {
                    schedule_grid.Columns[5].Visible = false;
                }
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
            this.kodeKelas = getKodeKelas;
            this.kodeIdGuru = passIdGuru;
            notif = 'A';

            foreach (DataGridViewRow row in schedule_grid.Rows)
            {
                this.kodeMapel = row.Cells[1].Value.ToString();
                if (kodeKelas != null)
                {
                    if ((Convert.ToBoolean(row.Cells[0].Value) == true) &&
                        (Convert.ToString(row.Cells[5].Value) != ""))
                    {
                        string status_no = "SELECT id_detail, kode_mapel from detailmapelkelas where kode_mapel = '" +
                                                kodeMapel + "' AND kode_kelas = '" +
                                                kodeKelas + "' AND status = 'Tidak Aktif'";
                        myConn.Open();
                        myComm = new MySqlCommand(status_no, myConn);
                        myReader = myComm.ExecuteReader();
                        while (myReader.Read())
                        {
                            string getMapel = myReader.GetString("kode_mapel");
                            if (kodeMapel == getMapel)
                            {
                                string detail_check = myReader.GetString("id_detail");
                                this.idGuru = row.Cells[5].Value.ToString();
                                this.table = "detailmapelkelas";
                                this.field = "id_guru = '" + idGuru + "', status ='Aktif'";
                                this.cond = "kode_kelas = '" + kodeKelas + "' AND id_detail = '" + detail_check + "'";
                                db.updateData(table, field, cond);
                            }
                        }
                        myConn.Close();

                        string status_yes = "SELECT kode_mapel as 'Kode' from mapel where kode_mapel = '" +
                                            kodeMapel + "' AND kode_mapel NOT IN (SELECT kode_mapel FROM detailmapelkelas WHERE kode_mapel = '" +
                                            kodeMapel + "' AND kode_kelas = '" + getKodeKelas + "')";
                        myConn.Open();
                        myComm = new MySqlCommand(status_yes, myConn);
                        myReader = myComm.ExecuteReader();
                        while (myReader.Read())
                        {
                            string getMapel = myReader.GetString("Kode");
                            this.idGuru = row.Cells[5].Value.ToString();
                            this.table = "detailmapelkelas";
                            this.field = "DEFAULT, '" + kodeKelas + "', '" + idGuru +
                                         "', '" + kodeMapel + "', DEFAULT";
                            db.insertData(table, field);
                        }
                        myConn.Close();
                        notif = 'B';
                    }
                    else if ((Convert.ToBoolean(row.Cells[0].Value) == true) &&
                            (Convert.ToString(row.Cells[5].Value) == ""))
                    {
                        string warning = row.Cells[3].Value.ToString();
                        MessageBox.Show(row.Cells[3].Value.ToString() + " belum ditambahkan ke jadwal");
                    }
                }

                if (passIdGuru != null)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value) == true)
                    {
                        string status_no = "SELECT id_detail, kode_mapel from detailmapelguru where kode_mapel = '" +
                                           kodeMapel + "' AND id_guru ='" + kodeIdGuru + "' AND status = 'Tidak Aktif'";
                        myConn.Open();
                        myComm = new MySqlCommand(status_no, myConn);
                        myReader = myComm.ExecuteReader();
                        while (myReader.Read())
                        {
                            string getMapel = myReader.GetString("kode_mapel");
                            if (kodeMapel == getMapel)
                            {
                                string detail_check = myReader.GetString("id_detail");
                                this.table = "detailmapelguru";
                                this.field = "status ='Aktif'";
                                this.cond = "id_guru = '" + kodeIdGuru + "' AND id_detail = '" + detail_check + "'";
                                db.updateData(table, field, cond);
                            }
                        }
                        myConn.Close();

                        string status_yes = "SELECT kode_mapel as 'Kode' from mapel where kode_mapel = '" +
                                            kodeMapel + "' AND kode_mapel NOT IN (SELECT kode_mapel FROM detailmapelguru WHERE kode_mapel = '" +
                                            kodeMapel + "' AND id_guru = '" + kodeIdGuru + "')";
                        myConn.Open();
                        myComm = new MySqlCommand(status_yes, myConn);
                        myReader = myComm.ExecuteReader();
                        while (myReader.Read())
                        {
                            string getMapel = myReader.GetString("Kode");
                            this.table = "detailmapelguru";
                            this.field = "DEFAULT, '" + kodeIdGuru + "', '" + kodeMapel +
                                         "', DEFAULT";
                            db.insertData(table, field);
                        }
                        myConn.Close();
                        notif = 'C';
                    }
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
            else if (notif == 'C')
            {
                MessageBox.Show("Mata Pelajaran berhasil dipilih!");
                this.Close();
            }
        }
    }
}
