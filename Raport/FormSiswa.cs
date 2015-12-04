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
    public partial class FormSiswa : Form
    {
        MySqlConnection myConn = Function.getKoneksi();
        Function db = new Function();
        MySqlDataReader myReader;
        private string table, field, cond;
        private string nis_siswa, nama_siswa, nama_kelas, kelasX, kelasXI, kelasXII;
        private string query;
        public string tahuj;
        DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();

        public FormSiswa()
        {
            InitializeComponent();
        }

        private void FormSiswa_Load(object sender, EventArgs e)
        {
            loadData();
            addColumn_dataKelas();
        }

        public string tahun_ajaran
        {
            get { return tahuj; }
            set { tahuj = value; }
        }

        //TAB VIEW DATA
        private void add_toolStr_Click(object sender, EventArgs e)
        {
            FormAddSiswa fAddSiswa = new FormAddSiswa();
            fAddSiswa.tahun_ajaran = tahuj;
            fAddSiswa.title_lbl.Text = "Form Tambah Data Siswa";
            fAddSiswa.update_btn.Enabled = false;
            fAddSiswa.delete_btn.Enabled = false;
            fAddSiswa.Show();
        }
        
        public void loadData()
        {
            this.field = "id_detail as 'ID Detail', detailkelassiswa.kode_kelas as 'Kode Kelas', siswa.nis_siswa as 'NIS', nisn_siswa as 'NISN', nama_siswa as 'Nama Siswa', tempat_lahir as 'Tempat Lahir'," +
                         "tanggal_lahir as 'Tanggal Lahir', jenis_kelamin as 'Jenis Kelamin', kelas.nama_kelas as 'Diterima di Kelas', status_keluarga as 'Status Anak'," +
                         "anak_ke as 'Anak Ke-', agama as 'Agama', siswa.no_telp as 'No. Telp. Siswa', alamat as 'Alamat Siswa', asal_sekolah as 'Asal Sekolah',"+
                         "tanggal_masuk as 'Diterima Tanggal', nama_ayah as 'Nama Ayah', nama_ibu as 'Nama Ibu', pekerjaan_ayah as 'Pekerjaan Ayah'," +
                         "pekerjaan_ibu as 'Pekerjaan Ibu', orangtua.no_telp as 'No. Telp. Ortu', alamat_ortu as 'Alamat Ortu'," +
                         "nama_wali as 'Nama Wali', pekerjaan_wali as 'Pekerjaan Wali', alamat_wali as 'Alamat Wali'";
            this.table = "detailkelassiswa INNER JOIN siswa ON siswa.nis_siswa = detailkelassiswa.nis_siswa INNER JOIN orangtua ON siswa.nis_siswa = orangtua.nis_siswa INNER JOIN kelas ON detailkelassiswa.kode_kelas = kelas.kode_kelas";
            this.cond = "detailkelassiswa.keterangan = 'Data Siswa' AND status_siswa = 'Aktif'";
            DataTable tabel = db.GetDataTable(field, table, cond);
            this.siswa_grid.DataSource = tabel;
            siswa_grid.Columns[0].Visible = false;
            siswa_grid.Columns[1].Visible = false;
        }
        
        private void refresh_toolStr_Click(object sender, EventArgs e)
        {
            loadData();
        }
        
        private void siswa_grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex >= 0) && (e.RowIndex != -1))
            {
                FormAddSiswa fEditSiswa = new FormAddSiswa();
                string dateLahir, dateMasuk, format;
                System.Globalization.CultureInfo provider = System.Globalization.CultureInfo.InvariantCulture;
                fEditSiswa.valueLoad = "Update";
                fEditSiswa.tahun_ajaran = tahuj;

                DataGridViewRow row = this.siswa_grid.Rows[e.RowIndex];
                fEditSiswa.nis_txt.Text = row.Cells["NIS"].Value.ToString();
                fEditSiswa.nisn_txt.Text = row.Cells["NISN"].Value.ToString();
                fEditSiswa.namaSiswa_txt.Text = row.Cells["Nama Siswa"].Value.ToString();
                fEditSiswa.tempatLahir_txt.Text = row.Cells["Tempat Lahir"].Value.ToString();
                fEditSiswa.kelamin_combo.Text = row.Cells["Jenis Kelamin"].Value.ToString();
                fEditSiswa.status_combo.Text = row.Cells["Status Anak"].Value.ToString();
                fEditSiswa.anakke_combo.Text = row.Cells["Anak Ke-"].Value.ToString();
                fEditSiswa.agama_combo.Text = row.Cells["Agama"].Value.ToString();
                fEditSiswa.telpSiswa_txt.Text = row.Cells["No. Telp. Siswa"].Value.ToString();
                fEditSiswa.asalSekolah_txt.Text = row.Cells["Asal Sekolah"].Value.ToString();
                fEditSiswa.alamatSiswa_txt.Text = row.Cells["Alamat Siswa"].Value.ToString();
                fEditSiswa.namaAyah_txt.Text = row.Cells["Nama Ayah"].Value.ToString();
                fEditSiswa.namaIbu_txt.Text = row.Cells["Nama Ibu"].Value.ToString();
                fEditSiswa.pekerjaanAyah_txt.Text = row.Cells["Pekerjaan Ayah"].Value.ToString();
                fEditSiswa.pekerjaanIbu_txt.Text = row.Cells["Pekerjaan Ibu"].Value.ToString();
                fEditSiswa.alamatOrtu_txt.Text = row.Cells["Alamat Ortu"].Value.ToString();
                fEditSiswa.telpOrtu_txt.Text = row.Cells["No. Telp. Ortu"].Value.ToString();
                fEditSiswa.namaWali_txt.Text = row.Cells["Nama Wali"].Value.ToString();
                fEditSiswa.pekerjaanWali_txt.Text = row.Cells["Pekerjaan Wali"].Value.ToString();
                fEditSiswa.alamatWali_txt.Text = row.Cells["Alamat Wali"].Value.ToString();
                fEditSiswa.valueKelas = row.Cells["Diterima di Kelas"].Value.ToString();
                fEditSiswa.nis_lbl.Text = row.Cells["NIS"].Value.ToString();
                fEditSiswa.id_lbl.Text = row.Cells["ID Detail"].Value.ToString();
                fEditSiswa.kode_lbl.Text = row.Cells["Kode Kelas"].Value.ToString();

                dateLahir = row.Cells["Tanggal Lahir"].Value.ToString();
                dateMasuk = row.Cells["Diterima Tanggal"].Value.ToString();
                format = "dd/MM/yyyy";
                try
                {
                    fEditSiswa.valueLahir = DateTime.ParseExact(dateLahir, format, provider);
                    fEditSiswa.valueMasuk = DateTime.ParseExact(dateMasuk, format, provider);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                fEditSiswa.title_lbl.Text = "   Form Edit Data Siswa";
                fEditSiswa.nis_txt.ReadOnly = true;
                fEditSiswa.nis_txt.BackColor = SystemColors.ControlDark;
                fEditSiswa.nis_txt.TabStop = false;
                fEditSiswa.nis_toolTip.Active = true;
                fEditSiswa.save_btn.Enabled = false;
                fEditSiswa.ShowDialog();
            }
        }

        private void search_txt_TextChanged(object sender, EventArgs e)
        {
            this.field = "id_detail as 'ID Detail', detailkelassiswa.kode_kelas as 'Kode Kelas', siswa.nis_siswa as 'NIS', nisn_siswa as 'NISN', nama_siswa as 'Nama Siswa', tempat_lahir as 'Tempat Lahir'," +
                         "tanggal_lahir as 'Tanggal Lahir', jenis_kelamin as 'Jenis Kelamin', kelas.nama_kelas as 'Diterima di Kelas', status_keluarga as 'Status Anak'," +
                         "anak_ke as 'Anak Ke-', agama as 'Agama', siswa.no_telp as 'No. Telp. Siswa', alamat as 'Alamat Siswa', asal_sekolah as 'Asal Sekolah'," +
                         "tanggal_masuk as 'Diterima Tanggal', nama_ayah as 'Nama Ayah', nama_ibu as 'Nama Ibu', pekerjaan_ayah as 'Pekerjaan Ayah'," +
                         "pekerjaan_ibu as 'Pekerjaan Ibu', orangtua.no_telp as 'No. Telp. Ortu', alamat_ortu as 'Alamat Ortu'," +
                         "nama_wali as 'Nama Wali', pekerjaan_wali as 'Pekerjaan Wali', alamat_wali as 'Alamat Wali'";
            this.table = "detailkelassiswa INNER JOIN siswa ON siswa.nis_siswa = detailkelassiswa.nis_siswa INNER JOIN orangtua ON siswa.nis_siswa = orangtua.nis_siswa INNER JOIN kelas ON detailkelassiswa.kode_kelas = kelas.kode_kelas";
            this.cond = "detailkelassiswa.keterangan = 'Data Siswa' AND " +
                        "(siswa.nis_siswa LIKE '%" + search_txt.Text + "%' OR " +
                        "nisn_siswa LIKE '%" + search_txt.Text + "%' OR " +
                        "nama_siswa LIKE '%" + search_txt.Text + "%' OR " +
                        "nama_ayah LIKE '%" + search_txt.Text + "%' OR " +
                        "nama_ibu LIKE '%" + search_txt.Text + "%' OR " +
                        "nama_wali LIKE '%" + search_txt.Text + "%' OR " +
                        "asal_sekolah LIKE '%" + search_txt.Text + "%' OR " +
                        "pekerjaan_ayah LIKE '%" + search_txt.Text + "%' OR " +
                        "pekerjaan_ibu LIKE '%" + search_txt.Text + "%' OR " +
                        "pekerjaan_wali LIKE '%" + search_txt.Text + "%' OR " +
                        "kelas.nama_kelas LIKE '%" + search_txt.Text + "%')";
            DataTable tabel = db.GetDataTable(field, table, cond);
            this.siswa_grid.DataSource = tabel;
            siswa_grid.Columns[0].Visible = false;
            siswa_grid.Columns[1].Visible = false;
        }

        //TAB DATA KELAS
        public void addColumn_dataKelas()
        {
            var col1 = new DataGridViewTextBoxColumn();
                col1.HeaderText = "NIS Siswa";
                col1.Name = "NIS Siswa";
            var col2 = new DataGridViewTextBoxColumn();
                col2.HeaderText = "Nama Siswa";
                col2.Name = "Nama Siswa";
            var col3 = new DataGridViewTextBoxColumn();
                col3.HeaderText = "Kelas 10";
                col3.Name = "Kelas 10";
            var col4 = new DataGridViewTextBoxColumn();
                col4.HeaderText = "Kelas 11";
                col4.Name = "Kelas 11";
            var col5 = new DataGridViewTextBoxColumn();
                col5.HeaderText = "Kelas 12";
                col5.Name = "Kelas 12";
            dataKelas_grid.Columns.AddRange(new DataGridViewColumn[] { col1, col2, col3, col4, col5 });

            try
            {
                datagrid_datakelas.DataSource = null;
                datagrid_datakelas.Columns.Clear();
                datagrid_datakelas.Rows.Clear();

                //Membuat Checkbox
                chk.ReadOnly = false;
                chk.HeaderText = "Pilih";
                datagrid_datakelas.Columns.Add(chk);

                this.field = "nis_siswa";
                this.table = "siswa";
                this.cond = "status_siswa = 'Aktif'";

                DataTable tabel = db.GetDataTable(field, table, cond);
                datagrid_datakelas.DataSource = tabel;

                foreach (DataGridViewRow row in datagrid_datakelas.Rows)
                {
                    row.Cells[0].Value = true;
                    if (Convert.ToBoolean(row.Cells[0].Value) == true)
                    {
                        this.nis_siswa = row.Cells[1].Value.ToString();
                        this.query = "SELECT nama_kelas, nama_siswa from detailkelassiswa " +
                                     "INNER JOIN kelas USING (kode_kelas) " +
                                     "INNER JOIN siswa USING (nis_siswa) " +
                                     "WHERE detailkelassiswa.nis_siswa = '" + nis_siswa + "'";
                        MySqlCommand myComm = new MySqlCommand(query, myConn);
                        myConn.Open();
                        myReader = myComm.ExecuteReader();
                        while (myReader.Read())
                        {
                            nama_kelas = myReader.GetString("nama_kelas");
                            nama_siswa = myReader.GetString("nama_siswa");

                            int i = nama_kelas.IndexOf(' ');
                            i = nama_kelas.IndexOf(' ', i);
                            if (nama_kelas.Substring(0, i) == "X")
                            {
                                this.kelasX = nama_kelas;
                            }
                            else if (nama_kelas.Substring(0, i) == "XI")
                            {
                                this.kelasXI = nama_kelas;
                            }
                            else if (nama_kelas.Substring(0, i) == "XII")
                            {
                                this.kelasXII = nama_kelas;
                            }
                        }
                        dataKelas_grid.Rows.Add(nis_siswa, nama_siswa, kelasX, kelasXI, kelasXII);
                        myConn.Close();
                    }
                }
            }
            catch
            {

            }

        }


        //END CLASS
    }
}
