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
    public partial class FormGuru : Form
    {
        MySqlConnection myConn = Function.getKoneksi();
        Function db = new Function();
        private string table;
        private string field;
        private string cond;

        public FormGuru()
        {
            InitializeComponent();
        }

        private void FormGuru_Load(object sender, EventArgs e)
        {
            loadData();
            disableSorting();
            loadHistori();
            fillcomboGuru();
        }

        //TAB VIEW DATA
        private void loadData()
        {
            this.field = "id_guru as 'ID Guru', nama_guru as 'Nama Guru', nip as 'NIP', nuptk as 'NUPTK'," +
                    "keterangan as 'Keterangan'";
            this.table = "guru";
            this.cond = "status_guru = 'Aktif' ORDER BY nip, nama_guru ASC";
            DataTable tabel = db.GetDataTable(field, table, cond);
            this.dataGuru_grid.DataSource = tabel;
            dataGuru_grid.Columns[0].Visible = false;
            loadHistori();
            cancelAction();
        }

        private void deleteGuru()
        {
            try
            {
                DialogResult dialog = MessageBox.Show("Hapus data guru '" + this.nama_txt.Text + "'?",
               "Hapus Data", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    this.table = "guru";
                    this.field = "status_guru = 'Tidak Aktif'";
                    this.cond = "id_guru ='" + this.id_txt.Text + "'";
                    db.updateData(table, field, cond);
                    MessageBox.Show("Data Guru '" + this.nama_txt.Text + "' Terhapus");
                    loadData();
                    guru_tab.SelectTab(0);
                }
                else if (dialog == DialogResult.No)
                {
                    CancelEventArgs batal = new CancelEventArgs();
                    batal.Cancel = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addGuru()
        {
            guru_tab.SelectTab(1);
            addAction();
            this.id_txt.Text = db.randomIdGuru();
        }

        private void disableSorting()
        {
            for (int i = 0; i <= dataGuru_grid.ColumnCount - 1; i++)
            {
                dataGuru_grid.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void dataGuru_grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                guru_tab.SelectTab(1);
                DataGridViewRow row = this.dataGuru_grid.Rows[e.RowIndex];

                id_txt.Text = row.Cells["ID Guru"].Value.ToString();
                nip_txt.Text = row.Cells["NIP"].Value.ToString();
                nuptk_txt.Text = row.Cells["NUPTK"].Value.ToString();
                nama_txt.Text = row.Cells["Nama Guru"].Value.ToString();
                keterangan_txt.Text = row.Cells["Keterangan"].Value.ToString();
            }
            update_btn.Enabled = true;
            delete_btn.Enabled = true;
            cancel_btn.Enabled = true;


            nama_txt.ReadOnly = false;
            nip_txt.ReadOnly = false;
            nuptk_txt.ReadOnly = false;
            keterangan_txt.ReadOnly = false;
        }

        private void search_txt_TextChanged(object sender, EventArgs e)
        {
            this.field = "id_guru as 'ID Guru', nama_guru as 'Nama Guru', nip as 'NIP', nuptk as 'NUPTK'," +
                    "keterangan as 'Keterangan'";
            this.table = "guru";
            this.cond = "status_guru = 'Aktif' AND " +
                        "(nama_guru LIKE '%" + search_txt.Text + "%' OR " +
                        "nip LIKE '%" + search_txt.Text + "%' OR " +
                        "nuptk LIKE '%" + search_txt.Text + "%' OR " +
                        "keterangan LIKE '%" + search_txt.Text + "%') ORDER BY nip, nama_guru ASC";
            DataTable tabel = db.GetDataTable(field, table, cond);
            this.dataGuru_grid.DataSource = tabel;
            dataGuru_grid.Columns[0].Visible = false;
        }

        private void add_toolbtn_Click(object sender, EventArgs e)
        {
            addGuru();
        }

        private void refresh_toolbtn_Click(object sender, EventArgs e)
        {
            loadData();
        }

        //TAB CHANGE DATA
        private void cancelAction()
        {
            id_txt.ResetText();
            nip_txt.ResetText();
            nuptk_txt.ResetText();
            nama_txt.ResetText();
            keterangan_txt.ResetText();

            save_btn.Enabled = false;
            cancel_btn.Enabled = false;
            update_btn.Enabled = false;
            delete_btn.Enabled = false;

            dataGuru_grid.Enabled = true;
            add_btn.Enabled = true;
            add_toolbtn.Enabled = true;
            nama_txt.ReadOnly = true;
            nip_txt.ReadOnly = true;
            nuptk_txt.ReadOnly = true;
            keterangan_txt.ReadOnly = true;
        }

        private void addAction()
        {
            cancelAction();

            save_btn.Enabled = true;
            cancel_btn.Enabled = true;

            dataGuru_grid.Enabled = false;
            add_btn.Enabled = false;
            add_toolbtn.Enabled = false;
            nama_txt.ReadOnly = false;
            nip_txt.ReadOnly = false;
            nuptk_txt.ReadOnly = false;
            keterangan_txt.ReadOnly = false;
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            addGuru();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            cancelAction();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            deleteGuru();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (nama_txt.Text == "")
                {
                    MessageBox.Show("Nama Guru Tidak Boleh Kosong");
                }
                else
                {
                    this.table = "guru";
                    this.field = "'" + this.id_txt.Text + "', '" + this.nip_txt.Text +
                                "', '" + this.nuptk_txt.Text + "', '" + this.nama_txt.Text +
                                "', DEFAULT, '" + this.keterangan_txt.Text + "'";
                    db.insertData(table, field);
                    MessageBox.Show("Tambah Data dengan id '" + this.id_txt.Text +
                        "' Berhasil \n Data Tersimpan");
                    loadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (nama_txt.Text == "")
                {
                    MessageBox.Show("Nama Guru Tidak Boleh Kosong");
                }
                else
                {
                    this.table = "guru";
                    this.field = "nip='" + this.nip_txt.Text +
                            "', nuptk='" + this.nuptk_txt.Text +
                            "', nama_guru='" + this.nama_txt.Text +
                            "', keterangan='" + this.keterangan_txt.Text + "'";
                    this.cond = " id_guru = '" + this.id_txt.Text + "'";
                    db.updateData(table, field, cond);
                    MessageBox.Show("Edit Data id '" + this.id_txt.Text + "' Berhasil \n Data Tersimpan");
                    loadData();
                    guru_tab.SelectTab(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void nip_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsDigit(e.KeyChar) == false
                && (int)e.KeyChar != (int)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void nuptk_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsDigit(e.KeyChar) == false
                && (int)e.KeyChar != (int)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void nama_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false
               && (char)e.KeyChar != (char)Keys.Back
               && (char)e.KeyChar != (char)Keys.Space
               && (char)e.KeyChar != '.'
               && (char)e.KeyChar != ','
               )
            {
                e.Handled = true;
            }
        }

        private void nama_txt_TextChanged(object sender, EventArgs e)
        {
            string nama = this.nama_txt.Text;
            this.nama_txt.Text = db.capitalizeWord(nama);
            nama_txt.Select(nama.Length, 0);
        }

        //TAB HISTORY DATA
        private void loadHistori()
        {
            this.field = "id_guru as 'ID Guru', nama_guru as 'Nama Guru', nip as 'NIP'," +
                    "nuptk as 'NUPTK', keterangan as 'Keterangan'";
            this.table = "guru";
            this.cond = "status_guru = 'Tidak Aktif'";
            DataTable historiGuru = db.GetDataTable(field, table, cond);
            this.historiGuru_grid.DataSource = historiGuru;
            historiGuru_grid.Columns["ID Guru"].Visible = false;
        }

        //TAB TEACHING
        public void fillcomboGuru()
        {
            try
            {
                string idValue = "id_guru";
                string dispValue = "nama_guru";
                this.table = "guru";
                this.cond = "status_guru = 'Aktif'";
                string sortby = "nama_guru";

                pilihGuru_combo.DataSource = db.setCombo(idValue, dispValue, table, cond, sortby);
                pilihGuru_combo.DisplayMember = "valueDisplay";
                pilihGuru_combo.ValueMember = "valueID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void pilihGuru_combo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //END CLASS
    }
}
