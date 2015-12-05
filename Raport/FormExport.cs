using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using ExcelLibrary.CompoundDocumentFormat;
using ExcelLibrary.SpreadSheet;
using MySql.Data.MySqlClient;

namespace Raport
{
    public partial class FormExport : Form
    {
        MySqlConnection myConn = Function.getKoneksi();
        Function db = new Function();
        private string table;
        private string field;
        private string cond;

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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            try
            {
               // DataGridViewRow row = this.data_grid.Rows[e.RowIndex]
                foreach (DataGridViewRow row in data_grid.Rows)
                {
                    this.table = "siswa";
                    this.field = "'" + row.Cells[0].Value.ToString() +
                                "', '" + row.Cells[1].Value.ToString() +
                                "', '" + row.Cells[2].Value.ToString() +
                                "', '" + row.Cells[3].Value.ToString() +
                                "', '" + row.Cells[4].Value.ToString() +
                                "', '" + row.Cells[5].Value.ToString() +
                                "', '" + row.Cells[6].Value.ToString() +
                                "', '" + row.Cells[7].Value.ToString() +
                                "', '" + row.Cells[8].Value.ToString() +
                                "', '" + row.Cells[9].Value.ToString() +
                                "', '" + row.Cells[10].Value.ToString() +
                                "', '" + row.Cells[11].Value.ToString() +
                                "', '" + row.Cells[13].Value.ToString() + "', DEFAULT";
                    db.insertData(table, field);

                    //insert ke tabel orangtua
                    string table2 = "orangtua";
                    string field2 = "DEFAULT, '" + row.Cells[0].Value.ToString() +
                                    "', '" + row.Cells[14].Value.ToString() +
                                    "', '" + row.Cells[15].Value.ToString() +
                                    "', '" + row.Cells[16].Value.ToString() +
                                    "', '" + row.Cells[17].Value.ToString() +
                                    "', '" + row.Cells[18].Value.ToString() +
                                    "', '" + row.Cells[19].Value.ToString() +
                                    "', '" + row.Cells[20].Value.ToString() +
                                    "', '" + row.Cells[21].Value.ToString() +
                                    "', '" + row.Cells[22].Value.ToString() + "'";
                    db.insertData(table2, field2);

                    //insert ke tabel detailkelassiswa
                    string table3 = "detailkelassiswa";
                    string field3 = "DEFAULT, '" + row.Cells[12].Value.ToString() +
                                    "', '" + row.Cells[0].Value.ToString() + "', 'Data Siswa'";
                    db.insertData(table3, field3);
                    FormSiswa fSiswa = new FormSiswa();
                    fSiswa.loadData();
                    MessageBox.Show("Data Siswa '" + row.Cells[1].Value.ToString() + "' disimpan");
                    this.Close();
                }
                //insert ke tabel siswa
                
            }
            catch
            {
                MessageBox.Show("Kesalahan Dalam Input Data");
            }
        }
    }
}
