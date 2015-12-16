using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Raport
{
    public partial class FormEskul : Form
    {
        MySqlConnection myConn = Function.getKoneksi();
        Function db = new Function();
        private string table;
        private string cond;
        private string field;

        public FormEskul()
        {
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            try
            {
                this.field = "kode_eskul as 'Kode', nama_eskul as 'Nama Eskul'";
                this.table = "ekstrakurikuler";
                this.cond = "keterangan = 'Aktif' ORDER BY nama_eskul ASC";
                DataTable kelas = db.GetDataTable(field, table, cond);
                this.dataEskul_grid.DataSource = kelas;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            dataEskul_grid.Enabled = false;
            add_btn.Enabled = false;
            delete_btn.Enabled = false;
            edit_btn.Enabled = false;

            save_btn.Enabled = true;
            cancel_btn.Enabled = true;
            kode_txt.Enabled = true;
            nama_txt.Enabled = true;
            kode_txt.ResetText();
            nama_txt.ResetText();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(kode_txt.Text) && kode_txt.Text.Length >= 0)
            {
                MessageBox.Show("Kode Eskul tidak Boleh Kosong");
                kode_txt.Focus();
            }
            else if (string.IsNullOrWhiteSpace(nama_txt.Text) && nama_txt.Text.Length >= 0)
            {
                MessageBox.Show("Nama Eskul tidak Boleh Kosong");
                kode_txt.Focus();
            }
            else
            {
                this.table = "ekstrakurikuler";
                this.field = "'" + kode_txt.Text.Replace("'", "''") + "', '" + nama_txt.Text.Replace("'", "''") + "', DEFAULT";
                db.insertData(table, field);
                loadData();
                MessageBox.Show("Eskul '" + nama_txt.Text + "'\n Berhasil di buat ");

                add_btn.Enabled = true;
                dataEskul_grid.Enabled = true;
                save_btn.Enabled = false;
                cancel_btn.Enabled = false;
                kode_txt.Enabled = false;
                nama_txt.Enabled = false;
                kode_txt.ResetText();
                nama_txt.ResetText();
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            dataEskul_grid.Enabled = true;
            add_btn.Enabled = true;
            save_btn.Enabled = false;
            cancel_btn.Enabled = false;
            kode_txt.Enabled = false;
            nama_txt.Enabled = false;
            delete_btn.Enabled = false;
            edit_btn.Enabled = false;
            kode_txt.ResetText();
            nama_txt.ResetText();
        }

        private void dataEskul_grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex >= 0) && (e.RowIndex != -1))
            {
                DataGridViewRow row = this.dataEskul_grid.Rows[e.RowIndex];
                string getkode = row.Cells["Kode"].Value.ToString();
                this.nama_txt.Text = row.Cells["Nama Eskul"].Value.ToString();
                this.kode_txt.Text = getkode;
                this.kode_lbl.Text = getkode;

                kode_txt.Enabled = true;
                nama_txt.Enabled = true;
                cancel_btn.Enabled = true;
                edit_btn.Enabled = true;
                delete_btn.Enabled = true;
                add_btn.Enabled = false;
            }
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            try
            {
                this.table = "ekstrakurikuler";
                this.field = "kode_eskul ='" + this.kode_txt.Text.Replace("'", "''") +
                        "', nama_eskul ='" + this.nama_txt.Text.Replace("'", "''") + "'";
                this.cond = "kode_eskul = '" + kode_lbl.Text + "'";

                db.updateData(table, field, cond);
                loadData();
                MessageBox.Show("Edit Data Eskul  Berhasil \n Data Tersimpan");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialog = MessageBox.Show("Hapus Eskul '" + nama_txt.Text + "'?",
               "Hapus Data", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    this.table = "ekstrakurikuler";
                    this.field = "keterangan = 'Tidak Aktif'";
                    this.cond = "kode_eskul = '" + kode_lbl.Text + "'";
                    db.updateData(table, field, cond);
                    loadData();
                    MessageBox.Show("Data eskul '" + nama_txt.Text + "' Terhapus");
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
    }
}
