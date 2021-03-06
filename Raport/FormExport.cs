﻿using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;
using MySql.Data.MySqlClient;

namespace Raport
{
    public partial class FormExport : Form
    {
        MySqlConnection myConn = Function.getKoneksi();
        Function db = new Function();
        private string table;
        private string field;

        public FormExport()
        {
            InitializeComponent();
        }

        private void choose_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog1 = new OpenFileDialog();
            if (dialog1.ShowDialog() == DialogResult.OK)
            {
                this.path_txt.Text = dialog1.FileName;
            }
        }

        private void load_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string pathConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source =" + path_txt.Text + ";Extended Properties=\"Excel 8.0;HDR=Yes;\";";
                OleDbConnection conn = new OleDbConnection(pathConn);

                OleDbDataAdapter myAdapter = new OleDbDataAdapter("Select * from [" + sheet_txt.Text + "$]", conn);
                DataTable dt = new DataTable();
                myAdapter.Fill(dt);
                data_grid.DataSource = dt;
                save_btn.Enabled = true;
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
            catch (OleDbException olex)
            {
                if (olex.ErrorCode == -2147467259)
                    MessageBox.Show("Terjadi kesalahan format Excel (.xls) atau Sheet tidak ditemukan.");
                else
                    MessageBox.Show(olex.Message);
            }
            catch (Exception ex)
            {
                save_btn.Enabled = false;
                MessageBox.Show(ex.Message);
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in data_grid.Rows)
                {
                    this.table = "siswa";
                    this.field = "'" + row.Cells[0].Value.ToString().Replace("'", "''") +
                                "', '" + row.Cells[1].Value.ToString().Replace("'", "''") +
                                "', '" + row.Cells[2].Value.ToString().Replace("'", "''") +
                                "', '" + row.Cells[3].Value.ToString().Replace("'", "''") +
                                "', '" + row.Cells[4].Value.ToString().Replace("'", "''") +
                                "', '" + row.Cells[5].Value.ToString().Replace("'", "''") +
                                "', '" + row.Cells[6].Value.ToString().Replace("'", "''") +
                                "', '" + row.Cells[7].Value.ToString().Replace("'", "''") +
                                "', '" + row.Cells[8].Value.ToString().Replace("'", "''") +
                                "', '" + row.Cells[9].Value.ToString().Replace("'", "''") +
                                "', '" + row.Cells[10].Value.ToString().Replace("'", "''") +
                                "', '" + row.Cells[11].Value.ToString().Replace("'", "''") +
                                "', '" + row.Cells[13].Value.ToString().Replace("'", "''") + "', DEFAULT";
                    db.insertData(table, field);

                    //insert ke tabel orangtua
                    string table2 = "orangtua";
                    string field2 = "DEFAULT, '" + row.Cells[0].Value.ToString().Replace("'", "''") +
                                    "', '" + row.Cells[14].Value.ToString().Replace("'", "''") +
                                    "', '" + row.Cells[15].Value.ToString().Replace("'", "''") +
                                    "', '" + row.Cells[16].Value.ToString().Replace("'", "''") +
                                    "', '" + row.Cells[17].Value.ToString().Replace("'", "''") +
                                    "', '" + row.Cells[18].Value.ToString().Replace("'", "''") +
                                    "', '" + row.Cells[19].Value.ToString().Replace("'", "''") +
                                    "', '" + row.Cells[20].Value.ToString().Replace("'", "''") +
                                    "', '" + row.Cells[21].Value.ToString().Replace("'", "''") +
                                    "', '" + row.Cells[22].Value.ToString().Replace("'", "''") + "'";
                    db.insertData(table2, field2);

                    //insert ke tabel detailkelassiswa
                    string table3 = "detailkelassiswa";
                    string field3 = "DEFAULT, '" + row.Cells[12].Value.ToString() +
                                    "', '" + row.Cells[0].Value.ToString() + "', 'Data Siswa'";
                    db.insertData(table3, field3);
                    FormSiswa fSiswa = new FormSiswa();
                    fSiswa.loadData();
                    this.Close();
                }
            }
            catch (MySqlException myex)
            {
                save_btn.Enabled = false;
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
                save_btn.Enabled = false;
                MessageBox.Show("Terjadi kesalahan atau ada duplikasi data");
            }
        }

        private void path_txt_TextChanged(object sender, EventArgs e)
        {
            if (path_txt.Text != "")
                sheet_txt.Enabled = true;
            else
                sheet_txt.Enabled = false;
        }

        private void sheet_txt_TextChanged(object sender, EventArgs e)
        {
            if (sheet_txt.Text != "")
                load_btn.Enabled = true;
            else
                load_btn.Enabled = false;
        }
    }
}
