using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Raport
{
    public partial class FormProfilSekolah : Form
    {
        MySqlConnection myConn = Function.getKoneksi();
        Function db = new Function();
        MySqlDataReader myReader;
        private string query;
        private string table;
        private string field;
        private string cond;
        
        public FormProfilSekolah()
        {
            InitializeComponent();
        }

        private void FormEditProfilSekolah_Load(object sender, EventArgs e)
        {
            editClick();
            myConn.Close();
            getData();
        }

        public void getData()
        {
            query = "SELECT * from profil_sekolah";
            MySqlCommand getProfil = new MySqlCommand(query, myConn);
            try
            {
                myConn.Open();
                myReader = getProfil.ExecuteReader();
                while (myReader.Read())
                {
                    nama_txt.Text = myReader.GetString("nama_sekolah");
                    npsn_txt.Text = myReader.GetString("npsn");
                    npsn_lbl.Text = myReader.GetString("npsn");
                    nss_txt.Text = myReader.GetString("nss");
                    alamat_txt.Text = myReader.GetString("alamat_sekolah");
                    pos_txt.Text = myReader.GetInt32("kode_pos").ToString();
                    telp_txt.Text = myReader.GetString("no_telp");
                    kelurahan_txt.Text = myReader.GetString("kelurahan");
                    kecamatan_txt.Text = myReader.GetString("kecamatan");
                    kota_txt.Text = myReader.GetString("kota");
                    provinsi_txt.Text = myReader.GetString("provinsi");
                    website_txt.Text = myReader.GetString("website");
                    email_txt.Text = myReader.GetString("email");
                }
                myConn.Close();
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

        private void save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                this.table = "profil_sekolah";
                this.field = "npsn='" + this.npsn_txt.Text + 
                        "', nss='" + this.nss_txt.Text + 
                        "', nama_sekolah='" + this.nama_txt.Text.Replace("'", "''") +
                        "', alamat_sekolah='" + this.alamat_txt.Text.Replace("'", "''") + 
                        "', kode_pos='" + this.pos_txt.Text + 
                        "', no_telp='" + this.telp_txt.Text + 
                        "', kelurahan='" + this.kelurahan_txt.Text.Replace("'", "''") +
                        "', kecamatan='" + this.kecamatan_txt.Text.Replace("'", "''") + 
                        "', kota='" + this.kota_txt.Text.Replace("'", "''") + 
                        "', provinsi='" + this.provinsi_txt.Text.Replace("'", "''") + 
                        "', website='" + this.website_txt.Text.Replace("'", "''") +
                        "', email='" + this.email_txt.Text.Replace("'", "''") + "'";
                this.cond = "npsn = '" + this.npsn_lbl.Text + "'";

                db.updateData(table, field, cond);
                MessageBox.Show("Edit Profil Sekolah Berhasil \n Data Tersimpan");
                editClick();
                getData();
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

        public void editClick()
        {
            nama_txt.ReadOnly = true;
            npsn_txt.ReadOnly = true;
            npsn_txt.Enabled = true;
            nss_txt.ReadOnly = true;
            alamat_txt.ReadOnly = true;
            pos_txt.ReadOnly = true;
            telp_txt.ReadOnly = true;
            kelurahan_txt.ReadOnly = true;
            kecamatan_txt.ReadOnly = true;
            kota_txt.ReadOnly = true;
            provinsi_txt.ReadOnly = true;
            website_txt.ReadOnly = true;
            email_txt.ReadOnly = true;

            nama_txt.BackColor = SystemColors.HotTrack;
            npsn_txt.BackColor = SystemColors.HotTrack;
            nss_txt.BackColor = SystemColors.HotTrack;
            alamat_txt.BackColor = SystemColors.HotTrack;
            pos_txt.BackColor = SystemColors.HotTrack;
            telp_txt.BackColor = SystemColors.HotTrack;
            kelurahan_txt.BackColor = SystemColors.HotTrack;
            kecamatan_txt.BackColor = SystemColors.HotTrack;
            kota_txt.BackColor = SystemColors.HotTrack;
            provinsi_txt.BackColor = SystemColors.HotTrack;
            website_txt.BackColor = SystemColors.HotTrack;
            email_txt.BackColor = SystemColors.HotTrack;

            close_btn.Show();
            save_btn.Hide();
            cancel_btn.Hide();
        }


        private void cancel_btn_Click(object sender, EventArgs e)
        {
            editClick();
            myConn.Close();
            getData();
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            close_btn.Hide();
            save_btn.Show();
            cancel_btn.Show();

            npsn_txt.ReadOnly = false;
            nama_txt.ReadOnly = false;
            nss_txt.ReadOnly = false;
            alamat_txt.ReadOnly = false;
            pos_txt.ReadOnly = false;
            telp_txt.ReadOnly = false;
            kelurahan_txt.ReadOnly = false;
            kecamatan_txt.ReadOnly = false;
            kota_txt.ReadOnly = false;
            provinsi_txt.ReadOnly = false;
            website_txt.ReadOnly = false;
            email_txt.ReadOnly = false;

            nama_txt.BackColor = SystemColors.Window;
            npsn_txt.BackColor = SystemColors.Window;
            nss_txt.BackColor = SystemColors.Window;
            alamat_txt.BackColor = SystemColors.Window;
            pos_txt.BackColor = SystemColors.Window;
            telp_txt.BackColor = SystemColors.Window;
            kelurahan_txt.BackColor = SystemColors.Window;
            kecamatan_txt.BackColor = SystemColors.Window;
            kota_txt.BackColor = SystemColors.Window;
            provinsi_txt.BackColor = SystemColors.Window;
            website_txt.BackColor = SystemColors.Window;
            email_txt.BackColor = SystemColors.Window;
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void npsn_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false
               && (char)e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void pos_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false
               && (char)e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void telp_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false
               && (char)e.KeyChar != (char)Keys.Back
               && (char)e.KeyChar != (char)Keys.Space
               && (char)e.KeyChar != '('
               && (char)e.KeyChar != ')'
               && (char)e.KeyChar != '-'
               && (char)e.KeyChar != '+'
               && (char)e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void kelurahan_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false
               && (char)e.KeyChar != (char)Keys.Back
               && (char)e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true;
            }
        }

        private void kecamatan_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false
               && (char)e.KeyChar != (char)Keys.Back
               && (char)e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true;
            }
        }

        private void kota_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false
               && (char)e.KeyChar != (char)Keys.Back
               && (char)e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true;
            }
        }

        private void provinsi_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false
               && (char)e.KeyChar != (char)Keys.Back
               && (char)e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true;
            }
        }

        private void nss_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false
               && (char)e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
