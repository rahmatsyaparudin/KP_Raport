﻿namespace Raport
{
    partial class FormUtama
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUtama));
            this.label1 = new System.Windows.Forms.Label();
            this.nama_lbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.alamat3_lbl = new System.Windows.Forms.Label();
            this.alamat_lbl = new System.Windows.Forms.Label();
            this.alamat2_lbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.jam_lbl = new System.Windows.Forms.Label();
            this.clock_timer = new System.Windows.Forms.Timer(this.components);
            this.hari_lbl = new System.Windows.Forms.Label();
            this.tanggal_lbl = new System.Windows.Forms.Label();
            this.bulan_lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.color_timer = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.set_btn = new System.Windows.Forms.Button();
            this.change_btn = new System.Windows.Forms.Button();
            this.tahuj_combo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.eskul_menu = new System.Windows.Forms.Button();
            this.deskripsi_menu = new System.Windows.Forms.Button();
            this.profil_menu = new System.Windows.Forms.Button();
            this.guru_menu = new System.Windows.Forms.Button();
            this.siswa_menu = new System.Windows.Forms.Button();
            this.nilai_menu = new System.Windows.Forms.Button();
            this.mapel_menu = new System.Windows.Forms.Button();
            this.kelas_menu = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.logo_pic = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aplikasi e-Raport Kurikulum 13";
            // 
            // nama_lbl
            // 
            this.nama_lbl.AutoSize = true;
            this.nama_lbl.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nama_lbl.Location = new System.Drawing.Point(3, 36);
            this.nama_lbl.Name = "nama_lbl";
            this.nama_lbl.Size = new System.Drawing.Size(199, 36);
            this.nama_lbl.TabIndex = 2;
            this.nama_lbl.Text = "Nama Sekolah";
            this.nama_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.logo_pic);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 138);
            this.panel1.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.alamat3_lbl, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.alamat_lbl, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.alamat2_lbl, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.nama_lbl, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(170, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(429, 129);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // alamat3_lbl
            // 
            this.alamat3_lbl.AutoSize = true;
            this.alamat3_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alamat3_lbl.Location = new System.Drawing.Point(5, 110);
            this.alamat3_lbl.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.alamat3_lbl.Name = "alamat3_lbl";
            this.alamat3_lbl.Size = new System.Drawing.Size(105, 19);
            this.alamat3_lbl.TabIndex = 5;
            this.alamat3_lbl.Text = "Website - Email";
            // 
            // alamat_lbl
            // 
            this.alamat_lbl.AutoSize = true;
            this.alamat_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alamat_lbl.Location = new System.Drawing.Point(5, 72);
            this.alamat_lbl.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.alamat_lbl.Name = "alamat_lbl";
            this.alamat_lbl.Size = new System.Drawing.Size(252, 19);
            this.alamat_lbl.TabIndex = 3;
            this.alamat_lbl.Text = "Alamat Sekolah, Kecamatan, Kelurahan";
            // 
            // alamat2_lbl
            // 
            this.alamat2_lbl.AutoSize = true;
            this.alamat2_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alamat2_lbl.Location = new System.Drawing.Point(5, 91);
            this.alamat2_lbl.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.alamat2_lbl.Name = "alamat2_lbl";
            this.alamat2_lbl.Size = new System.Drawing.Size(238, 19);
            this.alamat2_lbl.TabIndex = 4;
            this.alamat2_lbl.Text = "Kabupaten, Provinsi - Kode Pos Telp";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox1.Controls.Add(this.profil_menu);
            this.groupBox1.Controls.Add(this.guru_menu);
            this.groupBox1.Controls.Add(this.siswa_menu);
            this.groupBox1.Controls.Add(this.nilai_menu);
            this.groupBox1.Controls.Add(this.mapel_menu);
            this.groupBox1.Controls.Add(this.deskripsi_menu);
            this.groupBox1.Controls.Add(this.kelas_menu);
            this.groupBox1.Controls.Add(this.eskul_menu);
            this.groupBox1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(7, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 407);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pengolah Data";
            // 
            // jam_lbl
            // 
            this.jam_lbl.AutoSize = true;
            this.jam_lbl.BackColor = System.Drawing.Color.Aquamarine;
            this.jam_lbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jam_lbl.ForeColor = System.Drawing.Color.DarkBlue;
            this.jam_lbl.Location = new System.Drawing.Point(651, 257);
            this.jam_lbl.Name = "jam_lbl";
            this.jam_lbl.Size = new System.Drawing.Size(88, 23);
            this.jam_lbl.TabIndex = 15;
            this.jam_lbl.Text = "00:00:00";
            // 
            // clock_timer
            // 
            this.clock_timer.Enabled = true;
            this.clock_timer.Tick += new System.EventHandler(this.clock_timer_Tick);
            // 
            // hari_lbl
            // 
            this.hari_lbl.AutoSize = true;
            this.hari_lbl.BackColor = System.Drawing.Color.Aquamarine;
            this.hari_lbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hari_lbl.ForeColor = System.Drawing.Color.DarkBlue;
            this.hari_lbl.Location = new System.Drawing.Point(626, 169);
            this.hari_lbl.Name = "hari_lbl";
            this.hari_lbl.Size = new System.Drawing.Size(47, 23);
            this.hari_lbl.TabIndex = 16;
            this.hari_lbl.Text = "Hari";
            // 
            // tanggal_lbl
            // 
            this.tanggal_lbl.AutoSize = true;
            this.tanggal_lbl.BackColor = System.Drawing.Color.Aquamarine;
            this.tanggal_lbl.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tanggal_lbl.ForeColor = System.Drawing.Color.DarkBlue;
            this.tanggal_lbl.Location = new System.Drawing.Point(676, 193);
            this.tanggal_lbl.Name = "tanggal_lbl";
            this.tanggal_lbl.Size = new System.Drawing.Size(35, 40);
            this.tanggal_lbl.TabIndex = 17;
            this.tanggal_lbl.Text = "0";
            // 
            // bulan_lbl
            // 
            this.bulan_lbl.AutoSize = true;
            this.bulan_lbl.BackColor = System.Drawing.Color.Aquamarine;
            this.bulan_lbl.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bulan_lbl.ForeColor = System.Drawing.Color.DarkBlue;
            this.bulan_lbl.Location = new System.Drawing.Point(624, 233);
            this.bulan_lbl.Name = "bulan_lbl";
            this.bulan_lbl.Size = new System.Drawing.Size(108, 21);
            this.bulan_lbl.TabIndex = 18;
            this.bulan_lbl.Text = "Bulan, Tahun";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Aquamarine;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(623, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 39);
            this.label2.TabIndex = 19;
            this.label2.Text = "______";
            // 
            // color_timer
            // 
            this.color_timer.Enabled = true;
            this.color_timer.Interval = 30000;
            this.color_timer.Tick += new System.EventHandler(this.color_timer_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Aquamarine;
            this.panel2.Location = new System.Drawing.Point(622, 165);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(139, 116);
            this.panel2.TabIndex = 20;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Aquamarine;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.tahuj_combo);
            this.panel3.Controls.Add(this.change_btn);
            this.panel3.Controls.Add(this.set_btn);
            this.panel3.Location = new System.Drawing.Point(485, 165);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(131, 115);
            this.panel3.TabIndex = 21;
            // 
            // set_btn
            // 
            this.set_btn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.set_btn.FlatAppearance.BorderSize = 0;
            this.set_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.set_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.set_btn.Location = new System.Drawing.Point(6, 73);
            this.set_btn.Name = "set_btn";
            this.set_btn.Size = new System.Drawing.Size(55, 29);
            this.set_btn.TabIndex = 0;
            this.set_btn.Text = "Set";
            this.set_btn.UseVisualStyleBackColor = false;
            this.set_btn.Click += new System.EventHandler(this.set_btn_Click);
            // 
            // change_btn
            // 
            this.change_btn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.change_btn.Enabled = false;
            this.change_btn.FlatAppearance.BorderSize = 0;
            this.change_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.change_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.change_btn.Location = new System.Drawing.Point(64, 73);
            this.change_btn.Name = "change_btn";
            this.change_btn.Size = new System.Drawing.Size(64, 29);
            this.change_btn.TabIndex = 1;
            this.change_btn.Text = "Edit";
            this.change_btn.UseVisualStyleBackColor = false;
            this.change_btn.Click += new System.EventHandler(this.change_btn_Click);
            // 
            // tahuj_combo
            // 
            this.tahuj_combo.BackColor = System.Drawing.Color.MediumAquamarine;
            this.tahuj_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tahuj_combo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tahuj_combo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tahuj_combo.FormattingEnabled = true;
            this.tahuj_combo.IntegralHeight = false;
            this.tahuj_combo.ItemHeight = 19;
            this.tahuj_combo.Location = new System.Drawing.Point(6, 35);
            this.tahuj_combo.MaxDropDownItems = 4;
            this.tahuj_combo.Name = "tahuj_combo";
            this.tahuj_combo.Size = new System.Drawing.Size(121, 27);
            this.tahuj_combo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(5, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tahun Ajaran";
            // 
            // eskul_menu
            // 
            this.eskul_menu.BackColor = System.Drawing.Color.Red;
            this.eskul_menu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.eskul_menu.FlatAppearance.BorderSize = 0;
            this.eskul_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eskul_menu.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eskul_menu.Image = global::Raport.Properties.Resources.eskul;
            this.eskul_menu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.eskul_menu.Location = new System.Drawing.Point(155, 209);
            this.eskul_menu.Name = "eskul_menu";
            this.eskul_menu.Size = new System.Drawing.Size(129, 71);
            this.eskul_menu.TabIndex = 9;
            this.eskul_menu.Text = "Data Eskul";
            this.eskul_menu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.eskul_menu.UseVisualStyleBackColor = false;
            this.eskul_menu.Click += new System.EventHandler(this.eskul_menu_Click);
            // 
            // deskripsi_menu
            // 
            this.deskripsi_menu.BackColor = System.Drawing.Color.Magenta;
            this.deskripsi_menu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.deskripsi_menu.Enabled = false;
            this.deskripsi_menu.FlatAppearance.BorderSize = 0;
            this.deskripsi_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deskripsi_menu.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deskripsi_menu.Image = global::Raport.Properties.Resources.deskripsi;
            this.deskripsi_menu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.deskripsi_menu.Location = new System.Drawing.Point(155, 286);
            this.deskripsi_menu.Name = "deskripsi_menu";
            this.deskripsi_menu.Size = new System.Drawing.Size(129, 71);
            this.deskripsi_menu.TabIndex = 11;
            this.deskripsi_menu.Text = "Deskripsi";
            this.deskripsi_menu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.deskripsi_menu.UseVisualStyleBackColor = false;
            this.deskripsi_menu.Click += new System.EventHandler(this.deskripsi_menu_Click);
            // 
            // profil_menu
            // 
            this.profil_menu.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.profil_menu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.profil_menu.FlatAppearance.BorderSize = 0;
            this.profil_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profil_menu.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profil_menu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.profil_menu.Image = global::Raport.Properties.Resources.home;
            this.profil_menu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.profil_menu.Location = new System.Drawing.Point(19, 55);
            this.profil_menu.Name = "profil_menu";
            this.profil_menu.Size = new System.Drawing.Size(130, 71);
            this.profil_menu.TabIndex = 4;
            this.profil_menu.Text = "Profil Sekolah";
            this.profil_menu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.profil_menu.UseVisualStyleBackColor = false;
            this.profil_menu.Click += new System.EventHandler(this.profil_menu_Click);
            // 
            // guru_menu
            // 
            this.guru_menu.BackColor = System.Drawing.Color.CadetBlue;
            this.guru_menu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.guru_menu.FlatAppearance.BorderSize = 0;
            this.guru_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guru_menu.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guru_menu.Image = global::Raport.Properties.Resources.guru;
            this.guru_menu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.guru_menu.Location = new System.Drawing.Point(155, 55);
            this.guru_menu.Name = "guru_menu";
            this.guru_menu.Size = new System.Drawing.Size(130, 71);
            this.guru_menu.TabIndex = 5;
            this.guru_menu.Text = "Data Guru";
            this.guru_menu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.guru_menu.UseVisualStyleBackColor = false;
            this.guru_menu.Click += new System.EventHandler(this.guru_menu_Click);
            // 
            // siswa_menu
            // 
            this.siswa_menu.BackColor = System.Drawing.Color.Yellow;
            this.siswa_menu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.siswa_menu.Enabled = false;
            this.siswa_menu.FlatAppearance.BorderSize = 0;
            this.siswa_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.siswa_menu.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siswa_menu.Image = global::Raport.Properties.Resources.siswa;
            this.siswa_menu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.siswa_menu.Location = new System.Drawing.Point(20, 209);
            this.siswa_menu.Name = "siswa_menu";
            this.siswa_menu.Size = new System.Drawing.Size(130, 71);
            this.siswa_menu.TabIndex = 8;
            this.siswa_menu.Text = "Data Siswa";
            this.siswa_menu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.siswa_menu.UseVisualStyleBackColor = false;
            this.siswa_menu.Click += new System.EventHandler(this.siswa_menu_Click);
            // 
            // nilai_menu
            // 
            this.nilai_menu.BackColor = System.Drawing.Color.BurlyWood;
            this.nilai_menu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.nilai_menu.Enabled = false;
            this.nilai_menu.FlatAppearance.BorderSize = 0;
            this.nilai_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nilai_menu.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nilai_menu.Image = global::Raport.Properties.Resources.nilai;
            this.nilai_menu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.nilai_menu.Location = new System.Drawing.Point(20, 286);
            this.nilai_menu.Name = "nilai_menu";
            this.nilai_menu.Size = new System.Drawing.Size(129, 71);
            this.nilai_menu.TabIndex = 10;
            this.nilai_menu.Text = "Data Nilai";
            this.nilai_menu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.nilai_menu.UseVisualStyleBackColor = false;
            this.nilai_menu.Click += new System.EventHandler(this.nilai_menu_Click);
            // 
            // mapel_menu
            // 
            this.mapel_menu.BackColor = System.Drawing.Color.Lavender;
            this.mapel_menu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.mapel_menu.FlatAppearance.BorderSize = 0;
            this.mapel_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mapel_menu.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mapel_menu.Image = global::Raport.Properties.Resources.appbar_book;
            this.mapel_menu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mapel_menu.Location = new System.Drawing.Point(155, 132);
            this.mapel_menu.Name = "mapel_menu";
            this.mapel_menu.Size = new System.Drawing.Size(130, 71);
            this.mapel_menu.TabIndex = 6;
            this.mapel_menu.Text = "Mata Pelajaran";
            this.mapel_menu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mapel_menu.UseVisualStyleBackColor = false;
            this.mapel_menu.Click += new System.EventHandler(this.mapel_menu_Click);
            // 
            // kelas_menu
            // 
            this.kelas_menu.BackColor = System.Drawing.Color.LimeGreen;
            this.kelas_menu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.kelas_menu.FlatAppearance.BorderSize = 0;
            this.kelas_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kelas_menu.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kelas_menu.Image = global::Raport.Properties.Resources.kelas;
            this.kelas_menu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.kelas_menu.Location = new System.Drawing.Point(20, 132);
            this.kelas_menu.Name = "kelas_menu";
            this.kelas_menu.Size = new System.Drawing.Size(129, 71);
            this.kelas_menu.TabIndex = 7;
            this.kelas_menu.Text = "Data Kelas";
            this.kelas_menu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.kelas_menu.UseVisualStyleBackColor = false;
            this.kelas_menu.Click += new System.EventHandler(this.kelas_menu_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.exit_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exit_btn.FlatAppearance.BorderSize = 0;
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exit_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_btn.Image = global::Raport.Properties.Resources.power;
            this.exit_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exit_btn.Location = new System.Drawing.Point(647, 510);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.exit_btn.Size = new System.Drawing.Size(121, 35);
            this.exit_btn.TabIndex = 12;
            this.exit_btn.Text = "Exit Program";
            this.exit_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // logo_pic
            // 
            this.logo_pic.Image = global::Raport.Properties.Resources._133x133;
            this.logo_pic.Location = new System.Drawing.Point(18, 5);
            this.logo_pic.Name = "logo_pic";
            this.logo_pic.Size = new System.Drawing.Size(133, 133);
            this.logo_pic.TabIndex = 0;
            this.logo_pic.TabStop = false;
            // 
            // FormUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelButton = this.deskripsi_menu;
            this.ClientSize = new System.Drawing.Size(780, 557);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.tanggal_lbl);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bulan_lbl);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.jam_lbl);
            this.Controls.Add(this.hari_lbl);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormUtama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Utama e-Raport SMANJAK 1";
            this.Load += new System.EventHandler(this.FormUtama_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo_pic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nama_lbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label alamat_lbl;
        private System.Windows.Forms.Label alamat2_lbl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label alamat3_lbl;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Button siswa_menu;
        private System.Windows.Forms.Button eskul_menu;
        private System.Windows.Forms.Button mapel_menu;
        private System.Windows.Forms.Button nilai_menu;
        private System.Windows.Forms.Button deskripsi_menu;
        private System.Windows.Forms.Button kelas_menu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label jam_lbl;
        private System.Windows.Forms.Timer clock_timer;
        private System.Windows.Forms.Label hari_lbl;
        private System.Windows.Forms.Label tanggal_lbl;
        private System.Windows.Forms.Label bulan_lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button profil_menu;
        private System.Windows.Forms.Button guru_menu;
        private System.Windows.Forms.Timer color_timer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button set_btn;
        private System.Windows.Forms.Button change_btn;
        private System.Windows.Forms.ComboBox tahuj_combo;
        private System.Windows.Forms.Label label3;
    }
}