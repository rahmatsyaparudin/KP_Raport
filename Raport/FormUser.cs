﻿using System;
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
    public partial class FormUser : Form
    {
        MySqlConnection myConn = Function.getKoneksi();
        Function db = new Function();
        private string table;
        private string field;
        private string cond;
        private string value, pass, level, user;

        public FormUser()
        {
            InitializeComponent();
        }

        public string getPass
        {
            get { return pass; }
            set { pass = value; }
        }

        public string getUser
        {
            get { return user; }
            set { user = value; }
        }

        public string getLevel
        {
            get { return level; }
            set { level = value; }
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            fillGuru();
            load_user();
        }
        
        private void fillGuru()
        {
            try
            {
                string idValue = "nama_guru";
                string dispValue = "nama_guru";
                this.table = "guru";
                this.cond = "status_guru = 'Aktif'";
                string sortby = "nama_guru";

                guru_combo.DataSource = db.setCombo(idValue, dispValue, table, cond, sortby);
                guru_combo.DisplayMember = "valueDisplay";
                guru_combo.ValueMember = "valueID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void cancelAction()
        {
            user_radio.Checked = false;
            admin_radio.Checked = false;
            guru_combo.SelectedIndex = -1;
            user_txt.ResetText();
            pass_txt.ResetText();
            retypePass_txt.ResetText();
            save_btn.Enabled = true;
            cancel_btn.Enabled = true;
            delete_btn.Enabled = false;
            edit_btn.Enabled = false;
            aksi_lbl.Text = "save";
            user_lbl.Text = "null";
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            cancelAction();
        }

        private void dataUser_grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex >= 0) && (e.RowIndex != -1))
            {
                DataGridViewRow row = this.dataUser_grid.Rows[e.RowIndex];
                this.guru_combo.Text = row.Cells["Nama User"].Value.ToString();
                this.user_txt.Text = row.Cells["Username"].Value.ToString();
                this.user_lbl.Text = row.Cells["Username"].Value.ToString();
                this.pass_txt.Text = db.Decrypt(row.Cells["Password"].Value.ToString());
                this.retypePass_txt.Text = db.Decrypt(row.Cells["Password"].Value.ToString());
                this.level_lbl.Text = row.Cells["Level"].Value.ToString();
                this.aksi_lbl.Text = "edit";
            }
            if (level_lbl.Text == "1")
            {
                user_radio.Checked = true;
            }
            if (level_lbl.Text == "0")
            {
                admin_radio.Checked = true;
            }

            save_btn.Enabled = false;
            edit_btn.Enabled = true;
            delete_btn.Enabled = true;
        }

        private void dataUser_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex >= 0) && (e.RowIndex != -1))
            {
                DataGridViewRow row = this.dataUser_grid.Rows[e.RowIndex];
                this.getPass = db.Decrypt(row.Cells["Password"].Value.ToString());
                this.getLevel = row.Cells["Level"].Value.ToString();
                this.getUser = row.Cells["Username"].Value.ToString();
            }
        }

        private void view_toolBtn_Click(object sender, EventArgs e)
        {
            if (level == "1")
            {
                this.value = "Administrator";
            }

            if (level == "0")
            {
                this.value = "User";
            }
            MessageBox.Show("Level: " + value + "\nUsername: " + user + "\nPassword: " + pass);
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialog = MessageBox.Show("Hapus user '" + user_txt.Text + "'?",
               "Hapus Data", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    this.table = "user";
                    this.cond = "username = '" + user_txt.Text + "'";
                    db.deleteData(table, cond);
                    load_user();
                    MessageBox.Show("Username '" + user_txt.Text + "' Terhapus");
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

        private void edit_btn_Click(object sender, EventArgs e)
        {
            filledData();
        }

        private void refresh_toolBtn_Click(object sender, EventArgs e)
        {
            load_user();
            cancel_btn_Click(sender, e);
        }
        
        private void save_btn_Click(object sender, EventArgs e)
        {
            filledData();
        }

        private void filledData()
        {
            value = "NULL";
            if (user_radio.Checked == true)
            {
                value = "1";
            }

            if (admin_radio.Checked == true)
            {
                value = "0";
            }

            if (value == "NULL")
            {
                MessageBox.Show("Level User belum dipilih");
            }
            else if (guru_combo.Text == "")
            {
                MessageBox.Show("Guru belum dipilih");
            }
            else if (string.IsNullOrWhiteSpace(user_txt.Text) && user_txt.Text.Length >= 0)
            {
                MessageBox.Show("Username Tidak Boleh Kosong");
            }
            else if (string.IsNullOrWhiteSpace(pass_txt.Text) && pass_txt.Text.Length >= 0)
            {
                MessageBox.Show("Password Tidak Boleh Kosong");
            }
            else if (string.IsNullOrWhiteSpace(retypePass_txt.Text) && retypePass_txt.Text.Length >= 0)
            {
                MessageBox.Show("Retype Password Tidak Boleh Kosong");
            }
            else
            {
                if (pass_txt.Text != retypePass_txt.Text)
                {
                    MessageBox.Show("Password Tidak Sama");
                }
                else if (pass_txt.Text == retypePass_txt.Text)
                {
                    if (aksi_lbl.Text == "save")
                    {
                        saveData();
                    }   
                    else if (aksi_lbl.Text == "edit")
                    {
                        editData();
                    }
                }
            }
        }

        public void saveData()
        {
            try
            {
                string guru = guru_combo.SelectedValue.ToString();
                string pass = db.Encrypt(pass_txt.Text);
                table = "user";
                field = "'" + user_txt.Text + "', '" + pass + "', '" + guru + "', '" + value + "'";
                db.insertData(table, field);
                load_user();
                MessageBox.Show("User '" + user_txt.Text + "' telah ditambah");
                cancelAction();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Username sudah Terpakai atau terjadi kesalahan input");
            }
        }

        public void editData()
        {
            try
            {
                string guru = guru_combo.SelectedValue.ToString();
                string pass = db.Encrypt(pass_txt.Text);
                this.table = "user";
                this.field = " username = '" + user_txt.Text +
                             "', password = '" + pass +
                             "', nama = '" + guru +
                             "', level = '" + value + "'";
                this.cond = "username = '" + user_lbl.Text + "'";
                db.updateData(table, field, cond);
                load_user();
                MessageBox.Show("Edit Data User '" + user_txt.Text + "' berhasil");
                cancelAction();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Username sudah Terpakai atau terjadi kesalahan input");
            }
        }

        private void load_user()
        {
            this.field = "username as 'Username', password as 'Password', nama as 'Nama User', level as 'Level'";
            this.table = "user";
            this.cond = "level = '0' OR level = '1'";
            DataTable tabel = db.GetDataTable(field, table, cond);
            this.dataUser_grid.DataSource = tabel;
            dataUser_grid.Columns[1].Visible = false;
            dataUser_grid.Columns[3].Visible = false;
        }
    //END CLASS
    }
}