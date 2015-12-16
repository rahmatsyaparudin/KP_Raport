using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace Raport
{
    public partial class FormSetDatabase : Form
    {
        // Open App.Config of executable
        Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
        
        public FormSetDatabase()
        {
            InitializeComponent();
        }

        private void FormSetDatabase_Load(object sender, EventArgs e)
        {
            host_txt.Text = ConfigurationManager.AppSettings["host"];
            user_txt.Text = ConfigurationManager.AppSettings["user"];
            pass_txt.Text = ConfigurationManager.AppSettings["pass"];
            dbms_txt.Text = ConfigurationManager.AppSettings["dbms"];
            port_txt.Text = ConfigurationManager.AppSettings["port"];
            port_txt.ReadOnly = true;
        }
        
        private void getConfig()
        {
            // Add an Application Setting if not exist
            config.AppSettings.Settings.Remove("host");
            config.AppSettings.Settings.Add("host", host_txt.Text);
            config.AppSettings.Settings.Remove("user");
            config.AppSettings.Settings.Add("user", user_txt.Text);
            config.AppSettings.Settings.Remove("pass");
            config.AppSettings.Settings.Add("pass", pass_txt.Text);
            config.AppSettings.Settings.Remove("dbms");
            config.AppSettings.Settings.Add("dbms", dbms_txt.Text);
            config.AppSettings.Settings.Remove("port");
            config.AppSettings.Settings.Add("port", port_txt.Text);
            // Save the changes in App.config file.
            config.Save(ConfigurationSaveMode.Modified);
                // Force a reload of a changed section.
            ConfigurationManager.RefreshSection("appSettings");
            // Get the AppSettings section.
            AppSettingsSection appSettingSection =
              (AppSettingsSection)config.GetSection("appSettings");
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Tutup Server Setting? \n Perubahan tidak akan tersimpan",
               "Warning", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                CancelEventArgs batal = new CancelEventArgs();
                batal.Cancel = true;
            }
        }

        private void test_btn_Click(object sender, EventArgs e)
        {
            string server;
            try
            {
                server = "server='" + host_txt.Text + "';port='" + port_txt.Text + "';username='" + 
                         user_txt.Text + "';password='" + pass_txt.Text +
                         "';database='" + dbms_txt.Text + "';UseCompression=True";
                MySqlConnection myConn = new MySqlConnection(server);
                Function db = new Function();
                MySqlDataReader myReader;

                string connTest;
                string query = "SELECT count(*) as 'Jumlah' from user";
                MySqlCommand myComm = new MySqlCommand(query, myConn);
                myConn.Open();
                myReader = myComm.ExecuteReader();
                while (myReader.Read())
                {
                    connTest = myReader.GetString("Jumlah");
                }
                MessageBox.Show("Server Terhubung");
                myConn.Close();
            }
            catch
            {
                MessageBox.Show("Tidak Dapat Terhubung ke Server");
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(host_txt.Text) && host_txt.Text.Length >= 0)
            {
                MessageBox.Show("Host tidak boleh Kosong");
                host_txt.Focus();
            }
            else if (string.IsNullOrWhiteSpace(user_txt.Text) && user_txt.Text.Length >= 0)
            {
                MessageBox.Show("User tidak boleh Kosong");
                user_txt.Focus();
            }
            else if (string.IsNullOrWhiteSpace(pass_txt.Text) && pass_txt.Text.Length >= 0)
            {
                MessageBox.Show("Password tidak boleh Kosong");
                pass_txt.Focus();
            }
            else if (string.IsNullOrWhiteSpace(dbms_txt.Text) && dbms_txt.Text.Length >= 0)
            {
                MessageBox.Show("Database tidak boleh Kosong");
                dbms_txt.Focus();
            }
            else if (string.IsNullOrWhiteSpace(port_txt.Text) && port_txt.Text.Length >= 0)
            {
                MessageBox.Show("Port tidak boleh Kosong");
                port_txt.Focus();
            }
            else
            {
                getConfig();
                MessageBox.Show("Setting Tersimpan \n Aplikasi Akan Restart");
                Application.Restart();
            }
        }

        private void host_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsDigit(e.KeyChar) == false
                && (int)e.KeyChar != (int)Keys.Back
                && (char)e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void port_txt_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            port_txt.Enabled = true;
            port_txt.ReadOnly = false;
        }
    }
}
