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
using System.Configuration;

namespace Raport
{
    public partial class FormLogin : Form
    {
        MySqlConnection myConn = Function.getKoneksi();
        Function db = new Function();
        MySqlDataReader myReader;
        MySqlCommand SelectCommand;
        public FormLogin()
        {
            InitializeComponent();
        }
        
        //Method untuk cek Login User
        private void Login()
        {
            try
            {
                string username = user_txt.Text.Replace("'", "");
                username = username.Replace("\"", "");
                string password = pass_txt.Text.Replace("'", "");
                password = password.Replace("\"", "");
                SelectCommand = new MySqlCommand("SELECT username, password, nama, level from user where username = '" + username +
                                                "'and password='" + db.Encrypt(password) + "'; ", myConn);
                myConn.Open();
                myReader = SelectCommand.ExecuteReader();
                int count = 0;
                while (myReader.Read())
                {
                    count = count + 1;
                    level_lbl.Text = myReader.GetString("level");
                    user_lbl.Text = myReader.GetString("nama");
                }
                if (count == 1)
                {
                    info_panel.BackColor = System.Drawing.Color.LimeGreen;
                    info_img.Image = Properties.Resources.unlockKey;
                    info_timer.Enabled = true;
                    info_lbl.Text = "Anda Berhasil Login, Tunggu Sebentar...";
                    info_lbl.Visible = true;
                }
                else if (count == 0)
                {
                    info_panel.BackColor = System.Drawing.Color.Red;
                    info_timer.Enabled = true;
                    info_lbl.Text = "Username atau Password salah, Silakan coba lagi!";
                    info_lbl.Visible = true;
                }
                else if (count > 1)
                {
                    info_panel.BackColor = System.Drawing.Color.DarkOrange;
                    info_timer.Enabled = true;
                    info_lbl.Text = "Duplikasi Username, Silakan coba lagi!";
                    info_lbl.Visible = true;
                }
                myConn.Close();
            }
            catch (Exception ex)
            {
                info_panel.BackColor = System.Drawing.Color.Yellow;
                info_img.Image = Properties.Resources.warning;
                info_timer.Enabled = true;
                info_lbl.Text = "Koneksi ke Database tidak ditemukan";
                info_lbl.Visible = true;
            }
        }

        //Perubahan warna pada info panel & label
        private void info_timer_Tick(object sender, EventArgs e)
        {
            if (this.info_panel.BackColor == Color.Red)
            {
                this.info_panel.BackColor = Color.MediumBlue;
                info_timer.Enabled = false;
            }
            if (this.info_panel.BackColor == Color.Yellow)
            {
                this.info_panel.BackColor = Color.MediumBlue;
                info_timer.Enabled = false;
                info_img.Image = Properties.Resources.lockKey;
            }
            if (this.info_panel.BackColor == Color.DarkOrange)
            {
                this.info_panel.BackColor = Color.MediumBlue;
                info_timer.Enabled = false;
            }
            if (this.info_panel.BackColor == Color.LimeGreen)
            {
                this.info_panel.BackColor = Color.MediumBlue;
                info_timer.Enabled = false;
                this.Hide();
                FormUtama fUtama = new FormUtama();
                fUtama.passLevel = level_lbl.Text;
                fUtama.passUser = user_lbl.Text;
                fUtama.Show();
            }
        }

        //Event Tombol Login
        private void login_btn_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void login_btn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char)e.KeyChar == (char)Keys.Enter)
            {
                Login();
            }
        }
        //Event Tombol Reset 
        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
            Application.Exit();
        }
        
        private void user_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char)e.KeyChar == (char)Keys.Enter)
            {
                Login();
            }
        }

        private void pass_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char)e.KeyChar == (char)Keys.Enter)
            {
                Login();
            }
        }

        private void setting_btn_Click(object sender, EventArgs e)
        {
            FormSetDatabase fDbms = new FormSetDatabase();
            fDbms.ShowDialog();
        }
    }
}
