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
using System.IO;

namespace Raport
{
    public partial class FormBackupRestoreDb : Form
    {
        public string host = ConfigurationManager.AppSettings["host"];
        public string user = ConfigurationManager.AppSettings["user"];
        public string pass = ConfigurationManager.AppSettings["pass"];
        public string dbms = ConfigurationManager.AppSettings["dbms"];
        public string port = ConfigurationManager.AppSettings["port"];
        public string connString;
        public string query;
        MySqlConnection myConn = Function.getKoneksi();
        MySqlDataReader myReader;
        MySqlCommand myComm;
        SaveFileDialog sfDialog;

        public FormBackupRestoreDb()
        {
            InitializeComponent();
        }
        
        private void FormBackupRestoreDb_Load(object sender, EventArgs e)
        {
            server_txt.Text = host;
            userID_txt.Text = user;
            password_txt.Text = pass;

        }

        private void connect_btn_Click(object sender, EventArgs e)
        {
            if ((String.IsNullOrEmpty(userID_txt.Text)) || (String.IsNullOrWhiteSpace(userID_txt.Text)))
            {
                MessageBox.Show("User tidak boleh kosong!");
            }
            else if ((String.IsNullOrEmpty(server_txt.Text)) || (String.IsNullOrWhiteSpace(server_txt.Text)))
            {
                MessageBox.Show("Server tidak boleh kosong!");
            }
            else
            {
                connString  = "server='" + server_txt.Text + "';port='" + port + "';username='" + userID_txt.Text + 
                              "';password='" + password_txt + "'";
                myConn = new MySqlConnection(connString);
                try
                {
                    myConn.Open();
                    query = "Show databases";
                    myComm = new MySqlCommand(query, myConn);
                    myReader = myComm.ExecuteReader();
                    database_combo.Items.Clear();
                    while (myReader.Read())
                    {
                        database_combo.Items.Add(myReader[0].ToString());
                    }
                    database_combo.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }


        }

        private void browse_btn_Click(object sender, EventArgs e)
        {
            sfDialog = new SaveFileDialog();
            if(sfDialog.ShowDialog() == DialogResult.Yes)
            {
                location_txt.Text = sfDialog.FileName;
            }
        }

        private void Backup(string sMySQLDatabase, string sFilePath)
        {
            string constring = "server=" + host + ";username=" + user + ";password=" + pass + ";database=" + dbms + 
                                ";port=" + port;
            //string file = "C:tempbackup.sql";
            using (MySqlConnection conn = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        cmd.Connection = conn;
                        conn.Open();
                        mb.ExportToFile(sFilePath);
                        conn.Close();
                    }
                }
            }
        }

        private void backup_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Backup(dbms, "E:\\Saya.sql");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void location_txt_TextChanged(object sender, EventArgs e)
        {
            if ((String.IsNullOrEmpty(location_txt.Text)) || (String.IsNullOrWhiteSpace(location_txt.Text)))
            {
                backup_btn.Enabled = false;
            }
            else
            {
                backup_btn.Enabled = true;
            }
            
        }
    }
}
