using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Raport
{
    public partial class FormNilai : Form
    {
        MySqlConnection myConn = Function.getKoneksi();
        Function db = new Function();
        MySqlDataReader myReader;
        MySqlCommand myComm;
        private string query;
        private string table, field, cond;
        private string idValue, dispValue, sortby;
        public string getTahun, getUser, getLevel;
        private string kodeKelas, kodeMapel, kodeSmt;
        DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
        
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

        public DataTable siswadt(string getKodeKelas)
        {
            DataTable tabel = new DataTable();
            this.field = "nis_siswa";
            this.table = "detailkelassiswa INNER JOIN siswa USING (nis_siswa)";
            this.cond = "kode_kelas = '" + getKodeKelas + "' AND status_siswa = 'Aktif'";
            tabel = db.GetDataTable(field, table, cond);
            return tabel;
        }

        public FormNilai()
        {
            InitializeComponent();
        }

        private void FormNilai_Load(object sender, EventArgs e)
        {
            disableSorting();
            smt_combo.DataSource = db.getSmt();
            smt_combo.DisplayMember = "valueDisplay";
            smt_combo.ValueMember = "valueID";
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
                                "' AND (kelas.id_guru IN (SELECT id_guru FROM guru WHERE nama_guru = '" + getUser +
                                "') OR detailmapelkelas.id_guru IN (SELECT id_guru FROM guru WHERE nama_guru = '" + getUser + 
                                "')) GROUP BY kode_kelas";
                    this.sortby = "nama_kelas";
                }
                kelas_combo.DataSource = db.setCombo(idValue, dispValue, table, cond, sortby);
                kelas_combo.DisplayMember = "valueDisplay";
                kelas_combo.ValueMember = "valueID";
            }
            catch (MySqlException myex)
            {
                switch (myex.Number)
                {
                    case 0: MessageBox.Show("Tidak bisa terkkoneksi ke Server."); break;
                    case 1042: MessageBox.Show("Koneksi ke Database atau Server tidak ditemukan."); break;
                    case 1045: MessageBox.Show("username/password salah."); break;
                    default: MessageBox.Show("Terjadi kesalahan data atau aplikasi."); break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataNilai_grid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if ((e.RowIndex >= 0) && (e.RowIndex != -1))
                {
                    string inputString1, inputString2, inputString3;
                    int numVal1, numVal2, numVal3;
                    float result1, result2;
                    DataGridViewRow row = this.dataNilai_grid.Rows[e.RowIndex];

                    if (dataNilai_grid.CurrentCell.ColumnIndex.Equals(3) && e.RowIndex != -1)
                    {
                        //Nilai skala untuk Pengetahuan (0-100)
                        if (Convert.ToInt16(row.Cells[3].Value) >= 0 &&
                            Convert.ToInt16(row.Cells[3].Value) <= 100)
                        {
                            inputString1 = row.Cells[3].Value.ToString();
                            numVal1 = Int16.Parse(inputString1);
                            result1 = (float)numVal1 / 25;
                            row.Cells[4].Value = result1;
                            row.Cells[3].Value = numVal1;
                            row.Cells[3].Style.BackColor = Color.LightSkyBlue;
                        }
                        //Jika nilai skala pengetahuan tidak antara 0-100
                        else if (Convert.ToInt16(row.Cells[3].Value) < 0 ||
                            Convert.ToInt16(row.Cells[3].Value) > 100)
                        {
                            MessageBox.Show("Nilai skala antara 0 dan 100");
                            row.Cells[3].Value = Int16.Parse(peng_lbl.ToString());
                            row.Cells[3].Style.BackColor = Color.Yellow;
                        }

                        //Predikat untuk Pengetahuan
                        if (Convert.ToDouble(dataNilai_grid.CurrentRow.Cells[4].Value) >= 3.85 &&
                                Convert.ToDouble(dataNilai_grid.CurrentRow.Cells[4].Value) <= 4.0)
                        {
                            dataNilai_grid.CurrentRow.Cells[5].Value = "A";
                        }
                        else if (Convert.ToDouble(dataNilai_grid.CurrentRow.Cells[4].Value) >= 3.51 &&
                                Convert.ToDouble(dataNilai_grid.CurrentRow.Cells[4].Value) <= 3.84)
                        {
                            dataNilai_grid.CurrentRow.Cells[5].Value = "A-";
                        }
                        else if (Convert.ToDouble(dataNilai_grid.CurrentRow.Cells[4].Value) >= 3.18 &&
                            Convert.ToDouble(dataNilai_grid.CurrentRow.Cells[4].Value) <= 3.50)
                        {
                            dataNilai_grid.CurrentRow.Cells[5].Value = "B+";
                        }
                        else if (Convert.ToDouble(dataNilai_grid.CurrentRow.Cells[4].Value) >= 2.85 &&
                            Convert.ToDouble(dataNilai_grid.CurrentRow.Cells[4].Value) <= 3.17)
                        {
                            dataNilai_grid.CurrentRow.Cells[5].Value = "B";
                        }
                        else if (Convert.ToDouble(dataNilai_grid.CurrentRow.Cells[4].Value) >= 2.51 &&
                            Convert.ToDouble(dataNilai_grid.CurrentRow.Cells[4].Value) <= 2.84)
                        {
                            dataNilai_grid.CurrentRow.Cells[5].Value = "B-";
                        }
                        else if (Convert.ToDouble(dataNilai_grid.CurrentRow.Cells[4].Value) >= 2.18 &&
                            Convert.ToDouble(dataNilai_grid.CurrentRow.Cells[4].Value) <= 2.50)
                        {
                            dataNilai_grid.CurrentRow.Cells[5].Value = "C+";
                        }
                        else if (Convert.ToDouble(dataNilai_grid.CurrentRow.Cells[4].Value) >= 1.85 &&
                            Convert.ToDouble(dataNilai_grid.CurrentRow.Cells[4].Value) <= 2.17)
                        {
                            dataNilai_grid.CurrentRow.Cells[5].Value = "C";
                        }
                        else if (Convert.ToDouble(dataNilai_grid.CurrentRow.Cells[4].Value) >= 1.51 &&
                            Convert.ToDouble(dataNilai_grid.CurrentRow.Cells[4].Value) <= 1.84)
                        {
                            dataNilai_grid.CurrentRow.Cells[5].Value = "C-";
                        }
                        else if (Convert.ToDouble(dataNilai_grid.CurrentRow.Cells[4].Value) >= 1.18 &&
                            Convert.ToDouble(dataNilai_grid.CurrentRow.Cells[4].Value) <= 1.50)
                        {
                            dataNilai_grid.CurrentRow.Cells[5].Value = "D+";
                        }
                        else if (Convert.ToDouble(dataNilai_grid.CurrentRow.Cells[4].Value) >= 0 &&
                            Convert.ToDouble(dataNilai_grid.CurrentRow.Cells[4].Value) <= 1.17)
                        {
                            dataNilai_grid.CurrentRow.Cells[5].Value = "D";
                        }
                    }

                    if (dataNilai_grid.CurrentCell.ColumnIndex.Equals(7) && e.RowIndex != -1)
                    {
                        //Nilai skala untuk Keterampilan (0-100)
                        if (Convert.ToInt16(row.Cells[7].Value) >= 0 &&
                            Convert.ToInt16(row.Cells[7].Value) <= 100)
                        {
                            inputString2 = row.Cells[7].Value.ToString();
                            numVal2 = Int16.Parse(inputString2);
                            result2 = (float)numVal2 / 25;
                            row.Cells[8].Value = result2;
                            row.Cells[7].Value = numVal2;
                            row.Cells[7].Style.BackColor = Color.LightSkyBlue;
                        }
                        //Jika nilai skala keterampilan tidak antara 0-100
                        else if (Convert.ToInt16(row.Cells[7].Value) < 0 ||
                            Convert.ToInt16(row.Cells[7].Value) > 100)
                        {
                            MessageBox.Show("Nilai skala antara 0 dan 100");
                            row.Cells[7].Value = Int16.Parse(ket_lbl.ToString());
                            row.Cells[7].Style.BackColor = Color.Yellow;
                        }

                        //Predikat untuk Keterampilan
                        if (Convert.ToDouble(dataNilai_grid.CurrentRow.Cells[8].Value) >= 3.85 &&
                                Convert.ToDouble(dataNilai_grid.CurrentRow.Cells[8].Value) <= 4.0)
                        {
                            dataNilai_grid.CurrentRow.Cells[9].Value = "A";
                        }
                        else if (Convert.ToDouble(dataNilai_grid.CurrentRow.Cells[8].Value) >= 3.51 &&
                                Convert.ToDouble(dataNilai_grid.CurrentRow.Cells[8].Value) <= 3.84)
                        {
                            dataNilai_grid.CurrentRow.Cells[9].Value = "A-";
                        }
                        else if (Convert.ToDouble(dataNilai_grid.CurrentRow.Cells[8].Value) >= 3.18 &&
                            Convert.ToDouble(dataNilai_grid.CurrentRow.Cells[8].Value) <= 3.50)
                        {
                            dataNilai_grid.CurrentRow.Cells[9].Value = "B+";
                        }
                        else if (Convert.ToDouble(dataNilai_grid.CurrentRow.Cells[8].Value) >= 2.85 &&
                            Convert.ToDouble(dataNilai_grid.CurrentRow.Cells[8].Value) <= 3.17)
                        {
                            dataNilai_grid.CurrentRow.Cells[9].Value = "B";
                        }
                        else if (Convert.ToDouble(dataNilai_grid.CurrentRow.Cells[8].Value) >= 2.51 &&
                            Convert.ToDouble(dataNilai_grid.CurrentRow.Cells[8].Value) <= 2.84)
                        {
                            dataNilai_grid.CurrentRow.Cells[9].Value = "B-";
                        }
                        else if (Convert.ToDouble(dataNilai_grid.CurrentRow.Cells[8].Value) >= 2.18 &&
                            Convert.ToDouble(dataNilai_grid.CurrentRow.Cells[8].Value) <= 2.50)
                        {
                            dataNilai_grid.CurrentRow.Cells[9].Value = "C+";
                        }
                        else if (Convert.ToDouble(dataNilai_grid.CurrentRow.Cells[8].Value) >= 1.85 &&
                            Convert.ToDouble(dataNilai_grid.CurrentRow.Cells[8].Value) <= 2.17)
                        {
                            dataNilai_grid.CurrentRow.Cells[9].Value = "C";
                        }
                        else if (Convert.ToDouble(dataNilai_grid.CurrentRow.Cells[8].Value) >= 1.51 &&
                            Convert.ToDouble(dataNilai_grid.CurrentRow.Cells[8].Value) <= 1.84)
                        {
                            dataNilai_grid.CurrentRow.Cells[9].Value = "C-";
                        }
                        else if (Convert.ToDouble(dataNilai_grid.CurrentRow.Cells[8].Value) >= 1.18 &&
                            Convert.ToDouble(dataNilai_grid.CurrentRow.Cells[8].Value) <= 1.50)
                        {
                            dataNilai_grid.CurrentRow.Cells[9].Value = "D+";
                        }
                        else if (Convert.ToDouble(dataNilai_grid.CurrentRow.Cells[8].Value) >= 0 &&
                            Convert.ToDouble(dataNilai_grid.CurrentRow.Cells[8].Value) <= 1.17)
                        {
                            dataNilai_grid.CurrentRow.Cells[9].Value = "D";
                        }
                    }

                    if (dataNilai_grid.CurrentCell.ColumnIndex.Equals(11) && e.RowIndex != -1)
                    {

                        //Nilai skala untuk Sikap dan Spiritual (0-100)
                        if (Convert.ToInt16(row.Cells[11].Value) >= 0 &&
                        Convert.ToInt16(row.Cells[11].Value) <= 100)
                        {
                            inputString3 = row.Cells[11].Value.ToString();
                            numVal3 = Int16.Parse(inputString3);
                            row.Cells[11].Value = numVal3;
                            row.Cells[11].Style.BackColor = Color.LightSkyBlue;
                        }
                        //Jika nilai skala Sikap dan Spiritual tidak antara 0-100
                        else if (Convert.ToInt16(row.Cells[11].Value) < 0 ||
                            Convert.ToInt16(row.Cells[11].Value) > 100)
                        {
                            MessageBox.Show("Nilai skala antara 0 dan 100");
                            row.Cells[11].Value = Int16.Parse(sikap_lbl.ToString());
                            row.Cells[11].Style.BackColor = Color.Yellow;
                        }

                        //Predikat untuk Sikap dan Spiritual
                        if (Convert.ToInt16(dataNilai_grid.CurrentRow.Cells[11].Value) >= 0 &&
                                Convert.ToInt16(dataNilai_grid.CurrentRow.Cells[11].Value) <= 25)
                        {
                            dataNilai_grid.CurrentRow.Cells[12].Value = "K";
                        }
                        else if (Convert.ToInt16(dataNilai_grid.CurrentRow.Cells[11].Value) >= 26 &&
                                Convert.ToInt16(dataNilai_grid.CurrentRow.Cells[11].Value) <= 50)
                        {
                            dataNilai_grid.CurrentRow.Cells[12].Value = "C";
                        }
                        else if (Convert.ToInt16(dataNilai_grid.CurrentRow.Cells[11].Value) >= 51 &&
                                Convert.ToInt16(dataNilai_grid.CurrentRow.Cells[11].Value) <= 75)
                        {
                            dataNilai_grid.CurrentRow.Cells[12].Value = "B";
                        }
                        else if (Convert.ToInt16(dataNilai_grid.CurrentRow.Cells[11].Value) >= 76 &&
                                Convert.ToInt16(dataNilai_grid.CurrentRow.Cells[11].Value) <= 100)
                        {
                            dataNilai_grid.CurrentRow.Cells[12].Value = "SB";
                        }
                    }

                    //Input Masukkan untuk Deskripsi Pengetahuan
                    if (dataNilai_grid.CurrentCell.ColumnIndex.Equals(6) && e.RowIndex != -1)
                    {
                        if ((Convert.ToString(row.Cells[6].Value) == "A") ||
                            (Convert.ToString(row.Cells[6].Value) == "a") ||
                            (Convert.ToString(row.Cells[6].Value) == "T") ||
                            (Convert.ToString(row.Cells[6].Value) == "t") ||
                            (Convert.ToString(row.Cells[6].Value) == "B") ||
                            (Convert.ToString(row.Cells[6].Value) == "b") ||
                            (Convert.ToString(row.Cells[6].Value) == ""))
                        {
                            string desk = row.Cells[6].Value.ToString();
                            row.Cells[6].Value = Convert.ToString(desk).ToUpper();
                            row.Cells[6].Style.BackColor = Color.LightSkyBlue;
                        }
                        else if ((Convert.ToString(row.Cells[6].Value) == "A") ||
                            (Convert.ToString(row.Cells[6].Value) != "a") ||
                            (Convert.ToString(row.Cells[6].Value) != "T") ||
                            (Convert.ToString(row.Cells[6].Value) != "t") ||
                            (Convert.ToString(row.Cells[6].Value) != "B") ||
                            (Convert.ToString(row.Cells[6].Value) != "b"))
                        {
                            MessageBox.Show("Deskripsi (P) hanya boleh berisi A/T/B");
                            row.Cells[6].Value = dPeng_lbl.Text.ToString();
                            row.Cells[6].Style.BackColor = Color.Yellow;
                        }
                    }

                    //Input Masukkan untuk Deskripsi Keterampilan
                    if (dataNilai_grid.CurrentCell.ColumnIndex.Equals(10) && e.RowIndex != -1)
                    {
                        if ((Convert.ToString(row.Cells[10].Value) == "A") ||
                            (Convert.ToString(row.Cells[10].Value) == "a") ||
                            (Convert.ToString(row.Cells[10].Value) == "T") ||
                            (Convert.ToString(row.Cells[10].Value) == "t") ||
                            (Convert.ToString(row.Cells[10].Value) == "B") ||
                            (Convert.ToString(row.Cells[10].Value) == "b") ||
                            (Convert.ToString(row.Cells[10].Value) == ""))
                        {
                            string desk = row.Cells[10].Value.ToString();
                            row.Cells[10].Value = Convert.ToString(desk).ToUpper();
                            row.Cells[10].Style.BackColor = Color.LightSkyBlue;
                        }
                        else if ((Convert.ToString(row.Cells[10].Value) == "A") ||
                            (Convert.ToString(row.Cells[10].Value) != "a") ||
                            (Convert.ToString(row.Cells[10].Value) != "T") ||
                            (Convert.ToString(row.Cells[10].Value) != "t") ||
                            (Convert.ToString(row.Cells[10].Value) != "B") ||
                            (Convert.ToString(row.Cells[10].Value) != "b") ||
                            (Convert.ToString(row.Cells[10].Value) != "b"))
                        {
                            MessageBox.Show("Deskripsi (K) hanya boleh berisi A/T/B");
                            row.Cells[10].Value = dKet_lbl.Text.ToString();
                            row.Cells[10].Style.BackColor = Color.Yellow;
                        }
                    }

                    //Input Masukkan untuk Deskripsi Sikap Sosial dan Spiritual
                    if (dataNilai_grid.CurrentCell.ColumnIndex.Equals(13) && e.RowIndex != -1)
                    {
                        if ((Convert.ToString(row.Cells[13].Value) == "A") ||
                            (Convert.ToString(row.Cells[13].Value) == "a") ||
                            (Convert.ToString(row.Cells[13].Value) == "T") ||
                            (Convert.ToString(row.Cells[13].Value) == "t") ||
                            (Convert.ToString(row.Cells[13].Value) == "B") ||
                            (Convert.ToString(row.Cells[13].Value) == "b") ||
                            (Convert.ToString(row.Cells[13].Value) == ""))
                        {
                            string desk = row.Cells[13].Value.ToString();
                            row.Cells[13].Value = Convert.ToString(desk).ToUpper();
                            row.Cells[13].Style.BackColor = Color.LightSkyBlue;
                        }
                        else if ((Convert.ToString(row.Cells[13].Value) != "A") ||
                            (Convert.ToString(row.Cells[13].Value) != "a") ||
                            (Convert.ToString(row.Cells[13].Value) != "T") ||
                            (Convert.ToString(row.Cells[13].Value) != "t") ||
                            (Convert.ToString(row.Cells[13].Value) != "B") ||
                            (Convert.ToString(row.Cells[13].Value) != "b") ||
                            (Convert.ToString(row.Cells[13].Value) != ""))
                        {
                            MessageBox.Show("Deskripsi (S) hanya boleh berisi A/T/B");
                            row.Cells[13].Value = dSik_lbl.Text.ToString();
                            row.Cells[13].Style.BackColor = Color.Yellow;
                        }
                    }
                }
            }
            catch (InvalidCastException cast)
            {
                throw cast;
                MessageBox.Show("Ada kesalahan input!.");
            }
            catch (MySqlException myex)
            {
                switch (myex.Number)
                {
                    case 0: MessageBox.Show("Tidak bisa terkkoneksi ke Server."); break;
                    case 1042: MessageBox.Show("Koneksi ke Database atau Server tidak ditemukan."); break;
                    case 1045: MessageBox.Show("username/password salah."); break;
                    default: MessageBox.Show("Terjadi kesalahan data atau aplikasi."); break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataNilai_grid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dataNilai_grid.Rows[e.RowIndex];
                if (dataNilai_grid.CurrentCell.ColumnIndex.Equals(6) && e.RowIndex != -1)
                {
                    if ((Convert.ToString(row.Cells[6].Value) == "A") || (Convert.ToString(row.Cells[6].Value) == "a"))
                        row.Cells[6].Value = "A";
                    if ((Convert.ToString(row.Cells[6].Value) == "T") || (Convert.ToString(row.Cells[6].Value) == "t"))
                        row.Cells[6].Value = "T";
                    if ((Convert.ToString(row.Cells[6].Value) == "B") || (Convert.ToString(row.Cells[6].Value) == "b"))
                        row.Cells[6].Value = "B";
                }
                
                this.field = "p_skala = '" + row.Cells[3].Value.ToString() +
                             "', p_ang = '" + row.Cells[4].Value.ToString() +
                             "', p_pred = '" + row.Cells[5].Value.ToString() +
                             "', p_desk = '" + row.Cells[6].Value.ToString() +
                             "', k_skala = '" + row.Cells[7].Value.ToString() +
                             "', k_ang = '" + row.Cells[8].Value.ToString() +
                             "', k_pred = '" + row.Cells[9].Value.ToString() +
                             "', k_desk = '" + row.Cells[10].Value.ToString() +
                             "', s_skala = '" + row.Cells[11].Value.ToString() +
                             "', s_sikap = '" + row.Cells[12].Value.ToString() +
                             "', s_desk = '" + row.Cells[13].Value.ToString() + "'";
                this.table = "nilai";
                this.cond = "id_nilai = '" + row.Cells[0].Value.ToString() + "'";
                db.updateData(table, field, cond);
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
        
        private void dataNilai_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if ((e.RowIndex >= 0) && (e.RowIndex != -1))
                {
                    DataGridViewRow row = this.dataNilai_grid.Rows[e.RowIndex];
                    peng_lbl.Text = row.Cells[3].Value.ToString();
                    dPeng_lbl.Text = row.Cells[6].Value.ToString();
                    ket_lbl.Text = row.Cells[7].Value.ToString();
                    dKet_lbl.Text = row.Cells[10].Value.ToString();
                    sikap_lbl.Text = row.Cells[11].Value.ToString();
                    dSik_lbl.Text = row.Cells[13].Value.ToString();
                }
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

        private void dataNilai_grid_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dataNilai_grid.Rows[e.RowIndex];
                if (dataNilai_grid.CurrentCell.ColumnIndex.Equals(3) && e.RowIndex != -1)
                {
                    MessageBox.Show("Ada kesalahan Input pada Nilai Skala (P) \nTekan ENTER untuk EDIT \nTekan ESC Data tidak berubah");
                    row.Cells[3].Value = Int16.Parse(peng_lbl.ToString()); row.Cells[3].Style.BackColor = Color.Yellow;
                }

                if (dataNilai_grid.CurrentCell.ColumnIndex.Equals(7) && e.RowIndex != -1)
                {
                    MessageBox.Show("Ada kesalahan Input pada Nilai Skala (K) \nTekan ENTER untuk EDIT \nTekan ESC Data tidak berubah");
                    row.Cells[7].Value = Int16.Parse(ket_lbl.ToString()); row.Cells[7].Style.BackColor = Color.Yellow;
                }

                if (dataNilai_grid.CurrentCell.ColumnIndex.Equals(11) && e.RowIndex != -1)
                {
                    MessageBox.Show("Ada kesalahan Input pada Nilai Skala (S) \nTekan ENTER untuk EDIT \nTekan ESC Data tidak berubah");
                    row.Cells[11].Value = Int16.Parse(sikap_lbl.ToString()); row.Cells[11].Style.BackColor = Color.Yellow;
                }
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

        private void dataNilai_grid_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if ((e.RowIndex >= 0) && (e.RowIndex != -1))
                {
                    DataGridViewRow row = this.dataNilai_grid.Rows[e.RowIndex];
                    peng_lbl.Text = row.Cells[3].Value.ToString();
                    dPeng_lbl.Text = row.Cells[6].Value.ToString();
                    ket_lbl.Text = row.Cells[7].Value.ToString();
                    dKet_lbl.Text = row.Cells[10].Value.ToString();
                    sikap_lbl.Text = row.Cells[11].Value.ToString();
                    dSik_lbl.Text = row.Cells[13].Value.ToString();
                }

                DataGridViewTextBoxColumn cPeng = (DataGridViewTextBoxColumn)dataNilai_grid.Columns[3];
                cPeng.MaxInputLength = 3;
                DataGridViewTextBoxColumn dPeng = (DataGridViewTextBoxColumn)dataNilai_grid.Columns[6];
                dPeng.MaxInputLength = 1;
                DataGridViewTextBoxColumn cKet = (DataGridViewTextBoxColumn)dataNilai_grid.Columns[7];
                cKet.MaxInputLength = 3;
                DataGridViewTextBoxColumn dKet = (DataGridViewTextBoxColumn)dataNilai_grid.Columns[10];
                dKet.MaxInputLength = 1;
                DataGridViewTextBoxColumn cSik = (DataGridViewTextBoxColumn)dataNilai_grid.Columns[11];
                cSik.MaxInputLength = 3;
                DataGridViewTextBoxColumn dSik = (DataGridViewTextBoxColumn)dataNilai_grid.Columns[13];
                dSik.MaxInputLength = 1;
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
        
        public void kelasSiswa()
        {
            try
            {
                kodeKelas = this.kelas_combo.SelectedValue.ToString();
                siswadt(kodeKelas);
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
            try
            {
                if (kelas_combo.Text == "")
                {
                    mapel_combo.SelectedIndex = -1;
                    mapel_combo.Enabled = false;
                }
                else if (kelas_combo.Text != "")
                {
                    mapel_combo.Enabled = true;
                    kelasSiswa();
                    this.jumlah_lbl.Text = "0";
                    string jumlah = "SELECT count(*) as 'jumlah' FROM detailkelassiswa INNER JOIN siswa USING (nis_siswa) WHERE kode_kelas = '" +
                                    kodeKelas + "' AND status_siswa = 'Aktif'";
                    myConn.Open();
                    myComm = new MySqlCommand(jumlah, myConn);
                    myReader = myComm.ExecuteReader();
                    while (myReader.Read())
                    {
                        jumlah_lbl.Text = myReader.GetString("jumlah");
                    }
                    myConn.Close();
                    fillMapel();
                }
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

        private void load_toolBtn_Click(object sender, EventArgs e)
        {
            loadData();
            all_rad.Checked = true;
        }
        
        private void set_btn_Click(object sender, EventArgs e)
        {
            if (smt_combo.Text != "")
            {
                if (set_btn.Text == "Set")
                {
                    smt_combo.Enabled = false;
                    set_btn.Text = "Edit";
                    kelas_combo.Enabled = true;
                }
                else if (set_btn.Text == "Edit")
                {
                    kelas_combo.SelectedIndex = -1;
                    kelas_combo.Enabled = false;
                    set_btn.Text = "Set";
                    smt_combo.Enabled = true;
                }
            }
            else if (smt_combo.Text == "")
            {
                kelas_combo.SelectedIndex = -1;
                kelas_combo.Enabled = false;
            }
        }

        

        public void fillMapel()
        {
            try
            {
                if (getLevel == "1")
                {
                    this.kodeKelas = this.kelas_combo.SelectedValue.ToString();
                    this.idValue = "kode_mapel";
                    this.dispValue = "kode_mapel";
                    this.table = "detailmapelkelas";
                    this.cond = "status = 'Aktif' AND kode_kelas = '" + kodeKelas + "'";
                    this.sortby = "kode_mapel";
                }
                else if (getLevel == "0")
                {
                    this.kodeKelas = this.kelas_combo.SelectedValue.ToString();
                    this.idValue = "kode_mapel";
                    this.dispValue = "kode_mapel";
                    this.table = "detailmapelkelas INNER JOIN kelas USING (kode_kelas)";
                    this.cond = "status = 'Aktif' AND kode_kelas = '" + kodeKelas +
                                "' AND (kelas.id_guru IN (SELECT id_guru FROM guru WHERE nama_guru = '" + getUser +
                                "') OR detailmapelkelas.id_guru IN (SELECT id_guru FROM guru WHERE nama_guru = '" + getUser +
                                "')) GROUP BY kode_mapel";
                    this.sortby = "kode_mapel";
                }
                mapel_combo.DataSource = db.setCombo(idValue, dispValue, table, cond, sortby);
                mapel_combo.DisplayMember = "valueDisplay";
                mapel_combo.ValueMember = "valueID";
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

        private void mapel_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if ((mapel_combo.Text == "") || (mapel_combo.SelectedIndex == -1))
                {
                    mapel_txt.ResetText(); wali_txt.ResetText();
                    load_toolBtn.Enabled = false; all_rad.Checked = false;
                    peng_rad.Checked = false; ket_rad.Checked = false;
                    sss_rad.Checked = false; all_rad.Enabled = false;
                    peng_rad.Enabled = false; ket_rad.Enabled = false;
                    sss_rad.Enabled = false; dataNilai_grid.DataSource = null;
                    dataNilai_grid.Columns.Clear(); dataNilai_grid.Rows.Clear();
                }
                else if (mapel_combo.Text != "")
                {
                    this.kodeKelas = this.kelas_combo.SelectedValue.ToString();
                    this.kodeMapel = this.mapel_combo.SelectedValue.ToString();
                    query = "SELECT mata_pelajaran, nama_guru from detailmapelkelas INNER JOIN guru USING (id_guru)" +
                             "INNER JOIN mapel USING (kode_mapel) WHERE kode_kelas='" + kodeKelas + "' AND detailmapelkelas.kode_mapel='" +
                             kodeMapel + "'";
                    myComm = new MySqlCommand(query, myConn);
                    myConn.Open();
                    myReader = myComm.ExecuteReader();
                    while (myReader.Read())
                    {
                        mapel_txt.Text = myReader.GetString("mata_pelajaran");
                        wali_txt.Text = myReader.GetString("nama_guru");
                    }
                    myConn.Close(); loadData(); generate_nilai();
                    load_toolBtn.Enabled = true; all_rad.Enabled = true;
                    peng_rad.Enabled = true; ket_rad.Enabled = true;
                    sss_rad.Enabled = true; all_rad.Checked = true;
                }
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

        public void generate_nilai()
        {
            try
            {
                kodeKelas = kelas_combo.SelectedValue.ToString();
                kodeSmt = smt_combo.SelectedValue.ToString();
                kodeMapel = mapel_combo.SelectedValue.ToString();
                string nis_siswa, getSiswa;

                if (jumlah_lbl.Text != "0")
                {
                    foreach (DataRow row in siswadt(kodeKelas).Rows)
                    {
                        nis_siswa = row["nis_siswa"].ToString();
                        nis_lbl.Text = "null";
                        getSiswa = "SELECT count(*) as 'jumlah' FROM nilai WHERE nis_siswa = '" + nis_siswa +
                                   "' AND kode_kelas = '" + kodeKelas + "' AND kode_mapel = '" + kodeMapel +
                                   "' AND kode_semester = '" + kodeSmt + "'";
                        myConn.Open();
                        myComm = new MySqlCommand(getSiswa, myConn);
                        myReader = myComm.ExecuteReader();
                        while (myReader.Read())
                        {
                            nis_lbl.Text = myReader.GetString("jumlah");
                        }
                        if (nis_lbl.Text == "0")
                        {
                            this.field = "DEFAULT, '" + nis_siswa + "', '" + kodeKelas + "', '" + kodeMapel + "', '" + kodeSmt +
                                    "', DEFAULT, DEFAULT, DEFAULT, DEFAULT, DEFAULT, DEFAULT, DEFAULT, DEFAULT, DEFAULT, DEFAULT, DEFAULT";
                            this.table = "nilai";
                            db.insertData(table, field);
                            loadData();
                        }
                        myConn.Close();
                    }
                    this.nis_lbl.Text = "null";
                }
                if (jumlah_lbl.Text == "0")
                {
                    this.nis_lbl.Text = "null";
                    this.jumlah_lbl.Text = "0";
                }
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
        
        private void createNilai_toolBtn_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void all_rad_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 3; i <= dataNilai_grid.ColumnCount - 1; i++)
            {
                dataNilai_grid.Columns[i].Visible = true;
            }
        }

        private void peng_rad_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 3; i <= dataNilai_grid.ColumnCount - 1; i++)
            {
                dataNilai_grid.Columns[i].Visible = false;
            }
            dataNilai_grid.Columns[3].Visible = true;
            dataNilai_grid.Columns[4].Visible = true;
            dataNilai_grid.Columns[5].Visible = true;
            dataNilai_grid.Columns[6].Visible = true;
        }
        
        private void ket_rad_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 3; i <= dataNilai_grid.ColumnCount - 1; i++)
            {
                dataNilai_grid.Columns[i].Visible = false;
            }
            dataNilai_grid.Columns[7].Visible = true;
            dataNilai_grid.Columns[8].Visible = true;
            dataNilai_grid.Columns[9].Visible = true;
            dataNilai_grid.Columns[10].Visible = true;
        }

        private void sss_rad_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 3; i <= dataNilai_grid.ColumnCount - 1; i++)
            {
                dataNilai_grid.Columns[i].Visible = false;
            }
            dataNilai_grid.Columns[11].Visible = true;
            dataNilai_grid.Columns[12].Visible = true;
            dataNilai_grid.Columns[13].Visible = true;
        }

        public void loadData()
        {
            try
            {
                dataNilai_grid.DataSource = null;
                dataNilai_grid.Columns.Clear();
                dataNilai_grid.Rows.Clear();

                this.kodeKelas = this.kelas_combo.SelectedValue.ToString();
                this.kodeSmt = this.smt_combo.SelectedValue.ToString();
                this.kodeMapel = this.mapel_combo.SelectedValue.ToString();

                this.field = "id_nilai as 'ID Nilai', siswa.nis_siswa as 'NIS Siswa', nama_siswa as 'Nama Siswa', p_skala as 'Skala (P)', p_ang as 'Angka (P)', p_pred as 'Predikat (P)'" +
                            ", p_desk as 'Deskripsi (P)', k_skala as 'Skala (K)', k_ang as 'Angka (K)', k_pred as 'Predikat (K)', k_desk as 'Deskripsi (K)'" +
                            ", s_skala as 'Skala (S)', s_sikap as 'SB/B/C/K (S)', s_desk as 'Deskripsi (S)'";
                this.table = "nilai INNER JOIN siswa USING (nis_siswa)";
                this.cond = "kode_kelas = '" + kodeKelas + "' AND kode_mapel='" + kodeMapel +
                            "' AND kode_semester = '" + kodeSmt +
                            "' AND siswa.status_siswa != 'Tidak Aktif' ORDER by nama_siswa ASC";
                DataTable tabel = db.GetDataTable(field, table, cond);
                this.dataNilai_grid.DataSource = tabel;

                //Cell Formatting untuk Pengetahuan
                foreach (DataGridViewRow row in dataNilai_grid.Rows)
                {
                    if (Convert.ToInt16(row.Cells[3].Value) == 0)
                        row.Cells[3].Style.BackColor = Color.LimeGreen;
                    else
                        row.Cells[3].Style.BackColor = Color.LightSkyBlue;

                    if (Convert.ToString(row.Cells[6].Value) == "")
                        row.Cells[6].Style.BackColor = Color.LimeGreen;
                    else
                        row.Cells[6].Style.BackColor = Color.LightSkyBlue;

                    //Cell Formatting untuk Keterangan
                    if (Convert.ToInt16(row.Cells[7].Value) == 0)
                        row.Cells[7].Style.BackColor = Color.LimeGreen;
                    else
                        row.Cells[7].Style.BackColor = Color.LightSkyBlue;

                    if (Convert.ToString(row.Cells[10].Value) == "")
                        row.Cells[10].Style.BackColor = Color.LimeGreen;
                    else
                        row.Cells[10].Style.BackColor = Color.LightSkyBlue;

                    //Cell Formatting untuk Sikap Sosial dan Spiritual
                    if (Convert.ToInt16(row.Cells[11].Value) == 0)
                        row.Cells[11].Style.BackColor = Color.LimeGreen;
                    else
                        row.Cells[11].Style.BackColor = Color.LightSkyBlue;

                    if (Convert.ToString(row.Cells[13].Value) == "")
                        row.Cells[13].Style.BackColor = Color.LimeGreen;
                    else
                        row.Cells[13].Style.BackColor = Color.LightSkyBlue;
                }


                dataNilai_grid.Columns[0].Visible = false;
                dataNilai_grid.Columns[1].ReadOnly = true;
                dataNilai_grid.Columns[2].ReadOnly = true;
                dataNilai_grid.Columns[4].ReadOnly = true;
                dataNilai_grid.Columns[5].ReadOnly = true;
                dataNilai_grid.Columns[8].ReadOnly = true;
                dataNilai_grid.Columns[9].ReadOnly = true;
                dataNilai_grid.Columns[12].ReadOnly = true;

                for (int i = 0; i <= dataNilai_grid.ColumnCount - 1; i++)
                {
                    dataNilai_grid.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                }
                dataNilai_grid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataNilai_grid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                disableSorting();
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

        private void FormNilai_SizeChanged(object sender, EventArgs e)
        {
            try
            {
                if ((this.Size.Width == 991) &&
                    (this.Size.Height == 651))
                {
                    if (dataNilai_grid.DataSource != null)
                    {
                        dataNilai_grid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                        dataNilai_grid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    }
                }
                else
                {
                    if (dataNilai_grid.DataSource != null)
                    {
                        dataNilai_grid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        dataNilai_grid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                }
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

        private void disableSorting()
        {
            try
            {
                for (int i = 0; i <= dataNilai_grid.ColumnCount - 1; i++)
                {
                    dataNilai_grid.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                }
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
    }
}
