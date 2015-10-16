namespace Raport
{
    partial class FormAddSiswa
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
            this.nisn_txt = new System.Windows.Forms.TextBox();
            this.nis_txt = new System.Windows.Forms.TextBox();
            this.tempatLahir_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.kelamin_combo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ttl_date = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.namaSiswa_txt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.status_combo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.anakke_combo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dikelas_combo = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.diterima_date = new System.Windows.Forms.DateTimePicker();
            this.asalSekolah_txt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.alamatSiswa_txt = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.telpSiswa_txt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.agama_combo = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.alamatWali_txt = new System.Windows.Forms.RichTextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.namaWali_txt = new System.Windows.Forms.TextBox();
            this.namaAyah_txt = new System.Windows.Forms.TextBox();
            this.alamatOrtu_txt = new System.Windows.Forms.RichTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.namaIbu_txt = new System.Windows.Forms.TextBox();
            this.pekerjaanWali_txt = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.telpOrtu_txt = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.pekerjaanAyah_txt = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.pekerjaanIbu_txt = new System.Windows.Forms.TextBox();
            this.update_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.kode_lbl = new System.Windows.Forms.Label();
            this.nis_lbl = new System.Windows.Forms.Label();
            this.id_lbl = new System.Windows.Forms.Label();
            this.nis_toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.title_lbl = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.tahun_lbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // nisn_txt
            // 
            this.nisn_txt.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nisn_txt.Location = new System.Drawing.Point(171, 39);
            this.nisn_txt.Margin = new System.Windows.Forms.Padding(5);
            this.nisn_txt.MaxLength = 13;
            this.nisn_txt.Name = "nisn_txt";
            this.nisn_txt.Size = new System.Drawing.Size(149, 29);
            this.nisn_txt.TabIndex = 10;
            this.nisn_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nisn_txt_KeyPress);
            // 
            // nis_txt
            // 
            this.nis_txt.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nis_txt.Location = new System.Drawing.Point(17, 39);
            this.nis_txt.Margin = new System.Windows.Forms.Padding(5);
            this.nis_txt.MaxLength = 13;
            this.nis_txt.Name = "nis_txt";
            this.nis_txt.Size = new System.Drawing.Size(141, 29);
            this.nis_txt.TabIndex = 8;
            this.nis_toolTip.SetToolTip(this.nis_txt, "Double Klik Untuk Edit NIS Siswa");
            this.nis_txt.DoubleClick += new System.EventHandler(this.nis_txt_DoubleClick);
            this.nis_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nis_txt_KeyPress);
            // 
            // tempatLahir_txt
            // 
            this.tempatLahir_txt.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempatLahir_txt.Location = new System.Drawing.Point(17, 159);
            this.tempatLahir_txt.Margin = new System.Windows.Forms.Padding(5);
            this.tempatLahir_txt.MaxLength = 35;
            this.tempatLahir_txt.Name = "tempatLahir_txt";
            this.tempatLahir_txt.Size = new System.Drawing.Size(303, 29);
            this.tempatLahir_txt.TabIndex = 14;
            this.tempatLahir_txt.TextChanged += new System.EventHandler(this.tempatLahir_txt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 133);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tempat Lahir";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "NIS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 193);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "Tanggal Lahir";
            // 
            // kelamin_combo
            // 
            this.kelamin_combo.BackColor = System.Drawing.SystemColors.Control;
            this.kelamin_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kelamin_combo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.kelamin_combo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kelamin_combo.FormattingEnabled = true;
            this.kelamin_combo.IntegralHeight = false;
            this.kelamin_combo.Location = new System.Drawing.Point(171, 219);
            this.kelamin_combo.Margin = new System.Windows.Forms.Padding(5);
            this.kelamin_combo.MaxDropDownItems = 5;
            this.kelamin_combo.Name = "kelamin_combo";
            this.kelamin_combo.Size = new System.Drawing.Size(149, 29);
            this.kelamin_combo.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(167, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "NISN";
            // 
            // ttl_date
            // 
            this.ttl_date.Checked = false;
            this.ttl_date.Cursor = System.Windows.Forms.Cursors.Default;
            this.ttl_date.CustomFormat = "dd/MM/yyyy";
            this.ttl_date.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttl_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ttl_date.Location = new System.Drawing.Point(17, 219);
            this.ttl_date.Margin = new System.Windows.Forms.Padding(5);
            this.ttl_date.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.ttl_date.MinDate = new System.DateTime(1994, 1, 1, 0, 0, 0, 0);
            this.ttl_date.Name = "ttl_date";
            this.ttl_date.Size = new System.Drawing.Size(141, 29);
            this.ttl_date.TabIndex = 16;
            this.ttl_date.ValueChanged += new System.EventHandler(this.ttl_date_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(175, 253);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 21);
            this.label7.TabIndex = 21;
            this.label7.Text = "Status Anak";
            // 
            // namaSiswa_txt
            // 
            this.namaSiswa_txt.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namaSiswa_txt.Location = new System.Drawing.Point(17, 99);
            this.namaSiswa_txt.Margin = new System.Windows.Forms.Padding(5);
            this.namaSiswa_txt.MaxLength = 35;
            this.namaSiswa_txt.Name = "namaSiswa_txt";
            this.namaSiswa_txt.Size = new System.Drawing.Size(303, 29);
            this.namaSiswa_txt.TabIndex = 12;
            this.namaSiswa_txt.TextChanged += new System.EventHandler(this.namaSiswa_txt_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 15);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 21);
            this.label8.TabIndex = 24;
            this.label8.Text = "Anak ke-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(167, 193);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 21);
            this.label6.TabIndex = 17;
            this.label6.Text = "Jenis Kelamin";
            // 
            // status_combo
            // 
            this.status_combo.BackColor = System.Drawing.SystemColors.Control;
            this.status_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.status_combo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.status_combo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_combo.FormattingEnabled = true;
            this.status_combo.IntegralHeight = false;
            this.status_combo.Location = new System.Drawing.Point(171, 279);
            this.status_combo.Margin = new System.Windows.Forms.Padding(5);
            this.status_combo.MaxDropDownItems = 5;
            this.status_combo.Name = "status_combo";
            this.status_combo.Size = new System.Drawing.Size(149, 29);
            this.status_combo.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nama Siswa ";
            // 
            // anakke_combo
            // 
            this.anakke_combo.BackColor = System.Drawing.SystemColors.Control;
            this.anakke_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.anakke_combo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.anakke_combo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anakke_combo.FormattingEnabled = true;
            this.anakke_combo.IntegralHeight = false;
            this.anakke_combo.Location = new System.Drawing.Point(24, 39);
            this.anakke_combo.Margin = new System.Windows.Forms.Padding(5);
            this.anakke_combo.MaxDropDownItems = 5;
            this.anakke_combo.Name = "anakke_combo";
            this.anakke_combo.Size = new System.Drawing.Size(73, 29);
            this.anakke_combo.TabIndex = 25;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 78);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(732, 390);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Siswa";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dikelas_combo);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.diterima_date);
            this.panel2.Controls.Add(this.asalSekolah_txt);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.alamatSiswa_txt);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.telpSiswa_txt);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.anakke_combo);
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(359, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(340, 331);
            this.panel2.TabIndex = 23;
            // 
            // dikelas_combo
            // 
            this.dikelas_combo.BackColor = System.Drawing.SystemColors.Control;
            this.dikelas_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dikelas_combo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dikelas_combo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dikelas_combo.FormattingEnabled = true;
            this.dikelas_combo.IntegralHeight = false;
            this.dikelas_combo.Location = new System.Drawing.Point(186, 161);
            this.dikelas_combo.MaxDropDownItems = 5;
            this.dikelas_combo.Name = "dikelas_combo";
            this.dikelas_combo.Size = new System.Drawing.Size(143, 29);
            this.dikelas_combo.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(20, 135);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 21);
            this.label11.TabIndex = 30;
            this.label11.Text = "Tanggal Masuk";
            // 
            // diterima_date
            // 
            this.diterima_date.Cursor = System.Windows.Forms.Cursors.Default;
            this.diterima_date.CustomFormat = "dd/MM/yyyy";
            this.diterima_date.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diterima_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.diterima_date.Location = new System.Drawing.Point(24, 161);
            this.diterima_date.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.diterima_date.MinDate = new System.DateTime(2006, 1, 1, 0, 0, 0, 0);
            this.diterima_date.Name = "diterima_date";
            this.diterima_date.Size = new System.Drawing.Size(141, 29);
            this.diterima_date.TabIndex = 31;
            // 
            // asalSekolah_txt
            // 
            this.asalSekolah_txt.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asalSekolah_txt.Location = new System.Drawing.Point(24, 101);
            this.asalSekolah_txt.MaxLength = 35;
            this.asalSekolah_txt.Name = "asalSekolah_txt";
            this.asalSekolah_txt.Size = new System.Drawing.Size(305, 29);
            this.asalSekolah_txt.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(20, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 21);
            this.label10.TabIndex = 28;
            this.label10.Text = "Asal Sekolah";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(20, 195);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 21);
            this.label13.TabIndex = 34;
            this.label13.Text = "Alamat Siswa";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(182, 135);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(137, 21);
            this.label12.TabIndex = 32;
            this.label12.Text = "Diterima di Kelas";
            // 
            // alamatSiswa_txt
            // 
            this.alamatSiswa_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alamatSiswa_txt.Location = new System.Drawing.Point(24, 221);
            this.alamatSiswa_txt.Name = "alamatSiswa_txt";
            this.alamatSiswa_txt.Size = new System.Drawing.Size(305, 90);
            this.alamatSiswa_txt.TabIndex = 35;
            this.alamatSiswa_txt.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(105, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 21);
            this.label9.TabIndex = 26;
            this.label9.Text = "No. Telepon Siswa";
            // 
            // telpSiswa_txt
            // 
            this.telpSiswa_txt.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telpSiswa_txt.Location = new System.Drawing.Point(105, 39);
            this.telpSiswa_txt.MaxLength = 15;
            this.telpSiswa_txt.Name = "telpSiswa_txt";
            this.telpSiswa_txt.Size = new System.Drawing.Size(224, 29);
            this.telpSiswa_txt.TabIndex = 27;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.agama_combo);
            this.panel1.Controls.Add(this.ttl_date);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.kelamin_combo);
            this.panel1.Controls.Add(this.namaSiswa_txt);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tempatLahir_txt);
            this.panel1.Controls.Add(this.status_combo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.nis_txt);
            this.panel1.Controls.Add(this.nisn_txt);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(11, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 331);
            this.panel1.TabIndex = 6;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(13, 253);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(62, 21);
            this.label23.TabIndex = 19;
            this.label23.Text = "Agama";
            // 
            // agama_combo
            // 
            this.agama_combo.BackColor = System.Drawing.SystemColors.Control;
            this.agama_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.agama_combo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.agama_combo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agama_combo.FormattingEnabled = true;
            this.agama_combo.IntegralHeight = false;
            this.agama_combo.Location = new System.Drawing.Point(17, 279);
            this.agama_combo.MaxDropDownItems = 5;
            this.agama_combo.Name = "agama_combo";
            this.agama_combo.Size = new System.Drawing.Size(141, 29);
            this.agama_combo.TabIndex = 20;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.IndianRed;
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 466);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(732, 340);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data Orang Tua/Wali";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.alamatWali_txt);
            this.panel3.Controls.Add(this.label20);
            this.panel3.Controls.Add(this.label22);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.namaWali_txt);
            this.panel3.Controls.Add(this.namaAyah_txt);
            this.panel3.Controls.Add(this.alamatOrtu_txt);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.namaIbu_txt);
            this.panel3.Controls.Add(this.pekerjaanWali_txt);
            this.panel3.Controls.Add(this.label21);
            this.panel3.Controls.Add(this.telpOrtu_txt);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.pekerjaanAyah_txt);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.pekerjaanIbu_txt);
            this.panel3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(14, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(686, 295);
            this.panel3.TabIndex = 37;
            // 
            // alamatWali_txt
            // 
            this.alamatWali_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alamatWali_txt.Location = new System.Drawing.Point(370, 203);
            this.alamatWali_txt.Name = "alamatWali_txt";
            this.alamatWali_txt.Size = new System.Drawing.Size(305, 77);
            this.alamatWali_txt.TabIndex = 55;
            this.alamatWali_txt.Text = "";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(366, 67);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(90, 21);
            this.label20.TabIndex = 50;
            this.label20.Text = "Nama Wali";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(366, 179);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(99, 21);
            this.label22.TabIndex = 54;
            this.label22.Text = "Alamat Wali";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(13, 11);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 21);
            this.label14.TabIndex = 38;
            this.label14.Text = "Nama Ayah";
            // 
            // namaWali_txt
            // 
            this.namaWali_txt.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namaWali_txt.Location = new System.Drawing.Point(370, 91);
            this.namaWali_txt.MaxLength = 35;
            this.namaWali_txt.Name = "namaWali_txt";
            this.namaWali_txt.Size = new System.Drawing.Size(305, 29);
            this.namaWali_txt.TabIndex = 51;
            this.namaWali_txt.TextChanged += new System.EventHandler(this.namaWali_txt_TextChanged);
            // 
            // namaAyah_txt
            // 
            this.namaAyah_txt.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namaAyah_txt.Location = new System.Drawing.Point(17, 35);
            this.namaAyah_txt.MaxLength = 35;
            this.namaAyah_txt.Name = "namaAyah_txt";
            this.namaAyah_txt.Size = new System.Drawing.Size(303, 29);
            this.namaAyah_txt.TabIndex = 39;
            this.namaAyah_txt.TextChanged += new System.EventHandler(this.namaAyah_txt_TextChanged);
            // 
            // alamatOrtu_txt
            // 
            this.alamatOrtu_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alamatOrtu_txt.Location = new System.Drawing.Point(17, 203);
            this.alamatOrtu_txt.Name = "alamatOrtu_txt";
            this.alamatOrtu_txt.Size = new System.Drawing.Size(303, 77);
            this.alamatOrtu_txt.TabIndex = 47;
            this.alamatOrtu_txt.Text = "";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(366, 123);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(118, 21);
            this.label19.TabIndex = 52;
            this.label19.Text = "Pekerjaan Wali";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(13, 67);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 21);
            this.label15.TabIndex = 40;
            this.label15.Text = "Nama Ibu";
            // 
            // namaIbu_txt
            // 
            this.namaIbu_txt.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namaIbu_txt.Location = new System.Drawing.Point(17, 91);
            this.namaIbu_txt.MaxLength = 35;
            this.namaIbu_txt.Name = "namaIbu_txt";
            this.namaIbu_txt.Size = new System.Drawing.Size(303, 29);
            this.namaIbu_txt.TabIndex = 41;
            this.namaIbu_txt.TextChanged += new System.EventHandler(this.namaIbu_txt_TextChanged);
            // 
            // pekerjaanWali_txt
            // 
            this.pekerjaanWali_txt.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pekerjaanWali_txt.Location = new System.Drawing.Point(370, 147);
            this.pekerjaanWali_txt.Name = "pekerjaanWali_txt";
            this.pekerjaanWali_txt.Size = new System.Drawing.Size(149, 29);
            this.pekerjaanWali_txt.TabIndex = 53;
            this.pekerjaanWali_txt.TextChanged += new System.EventHandler(this.pekerjaanWali_txt_TextChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(13, 179);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(146, 21);
            this.label21.TabIndex = 46;
            this.label21.Text = "Alamat Orang Tua";
            // 
            // telpOrtu_txt
            // 
            this.telpOrtu_txt.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telpOrtu_txt.Location = new System.Drawing.Point(370, 35);
            this.telpOrtu_txt.MaxLength = 35;
            this.telpOrtu_txt.Name = "telpOrtu_txt";
            this.telpOrtu_txt.Size = new System.Drawing.Size(305, 29);
            this.telpOrtu_txt.TabIndex = 49;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(13, 123);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(122, 21);
            this.label16.TabIndex = 42;
            this.label16.Text = "Pekerjaan Ayah";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(366, 11);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(137, 21);
            this.label18.TabIndex = 48;
            this.label18.Text = "No Telepon Ortu";
            // 
            // pekerjaanAyah_txt
            // 
            this.pekerjaanAyah_txt.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pekerjaanAyah_txt.Location = new System.Drawing.Point(17, 147);
            this.pekerjaanAyah_txt.Name = "pekerjaanAyah_txt";
            this.pekerjaanAyah_txt.Size = new System.Drawing.Size(141, 29);
            this.pekerjaanAyah_txt.TabIndex = 43;
            this.pekerjaanAyah_txt.TextChanged += new System.EventHandler(this.pekerjaanAyah_txt_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(167, 123);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(111, 21);
            this.label17.TabIndex = 44;
            this.label17.Text = "Pekerjaan Ibu";
            // 
            // pekerjaanIbu_txt
            // 
            this.pekerjaanIbu_txt.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pekerjaanIbu_txt.Location = new System.Drawing.Point(171, 147);
            this.pekerjaanIbu_txt.Name = "pekerjaanIbu_txt";
            this.pekerjaanIbu_txt.Size = new System.Drawing.Size(149, 29);
            this.pekerjaanIbu_txt.TabIndex = 45;
            this.pekerjaanIbu_txt.TextChanged += new System.EventHandler(this.pekerjaanIbu_txt_TextChanged);
            // 
            // update_btn
            // 
            this.update_btn.BackColor = System.Drawing.Color.Lavender;
            this.update_btn.FlatAppearance.BorderSize = 0;
            this.update_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_btn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_btn.Image = global::Raport.Properties.Resources.edit1;
            this.update_btn.Location = new System.Drawing.Point(259, 38);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(89, 29);
            this.update_btn.TabIndex = 59;
            this.update_btn.Text = "Update";
            this.update_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.update_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.update_btn.UseVisualStyleBackColor = false;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.Color.Lavender;
            this.save_btn.FlatAppearance.BorderSize = 0;
            this.save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_btn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_btn.Image = global::Raport.Properties.Resources.save;
            this.save_btn.Location = new System.Drawing.Point(259, 3);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(89, 29);
            this.save_btn.TabIndex = 57;
            this.save_btn.Text = "Save";
            this.save_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.save_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.Lavender;
            this.delete_btn.FlatAppearance.BorderSize = 0;
            this.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_btn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.Image = global::Raport.Properties.Resources.delete;
            this.delete_btn.Location = new System.Drawing.Point(354, 38);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(89, 29);
            this.delete_btn.TabIndex = 60;
            this.delete_btn.Text = "Delete";
            this.delete_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delete_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.Color.Lavender;
            this.cancel_btn.FlatAppearance.BorderSize = 0;
            this.cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_btn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_btn.Image = global::Raport.Properties.Resources.cancel;
            this.cancel_btn.Location = new System.Drawing.Point(354, 3);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(89, 29);
            this.cancel_btn.TabIndex = 58;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancel_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cancel_btn.UseVisualStyleBackColor = false;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel4.Controls.Add(this.delete_btn);
            this.panel4.Controls.Add(this.save_btn);
            this.panel4.Controls.Add(this.cancel_btn);
            this.panel4.Controls.Add(this.update_btn);
            this.panel4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(0, 806);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(732, 83);
            this.panel4.TabIndex = 56;
            // 
            // kode_lbl
            // 
            this.kode_lbl.AutoSize = true;
            this.kode_lbl.Location = new System.Drawing.Point(603, 0);
            this.kode_lbl.Name = "kode_lbl";
            this.kode_lbl.Size = new System.Drawing.Size(97, 21);
            this.kode_lbl.TabIndex = 1;
            this.kode_lbl.Text = "Kode Kelas";
            this.kode_lbl.Visible = false;
            // 
            // nis_lbl
            // 
            this.nis_lbl.AutoSize = true;
            this.nis_lbl.Location = new System.Drawing.Point(603, 21);
            this.nis_lbl.Name = "nis_lbl";
            this.nis_lbl.Size = new System.Drawing.Size(89, 21);
            this.nis_lbl.TabIndex = 2;
            this.nis_lbl.Text = "NIS Siswa";
            this.nis_lbl.Visible = false;
            // 
            // id_lbl
            // 
            this.id_lbl.AutoSize = true;
            this.id_lbl.Location = new System.Drawing.Point(632, 54);
            this.id_lbl.Name = "id_lbl";
            this.id_lbl.Size = new System.Drawing.Size(76, 21);
            this.id_lbl.TabIndex = 4;
            this.id_lbl.Text = "ID Detail";
            this.id_lbl.Visible = false;
            // 
            // nis_toolTip
            // 
            this.nis_toolTip.Active = false;
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_lbl.Location = new System.Drawing.Point(204, 13);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(142, 31);
            this.title_lbl.TabIndex = 57;
            this.title_lbl.Text = "Form Siswa";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(201, 42);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(161, 31);
            this.label24.TabIndex = 58;
            this.label24.Text = "Tahun Ajaran";
            // 
            // tahun_lbl
            // 
            this.tahun_lbl.AutoSize = true;
            this.tahun_lbl.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tahun_lbl.Location = new System.Drawing.Point(357, 42);
            this.tahun_lbl.Name = "tahun_lbl";
            this.tahun_lbl.Size = new System.Drawing.Size(161, 31);
            this.tahun_lbl.TabIndex = 3;
            this.tahun_lbl.Text = "Tahun Ajaran";
            // 
            // FormAddSiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(732, 505);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.title_lbl);
            this.Controls.Add(this.id_lbl);
            this.Controls.Add(this.tahun_lbl);
            this.Controls.Add(this.nis_lbl);
            this.Controls.Add(this.kode_lbl);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FormAddSiswa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pengolah Data Siswa";
            this.Load += new System.EventHandler(this.FormAddSiswa_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.TextBox nisn_txt;
        public System.Windows.Forms.TextBox nis_txt;
        public System.Windows.Forms.TextBox tempatLahir_txt;
        public System.Windows.Forms.ComboBox kelamin_combo;
        public System.Windows.Forms.DateTimePicker ttl_date;
        public System.Windows.Forms.TextBox namaSiswa_txt;
        public System.Windows.Forms.ComboBox status_combo;
        public System.Windows.Forms.ComboBox anakke_combo;
        public System.Windows.Forms.ComboBox agama_combo;
        public System.Windows.Forms.DateTimePicker diterima_date;
        public System.Windows.Forms.RichTextBox alamatSiswa_txt;
        public System.Windows.Forms.TextBox telpSiswa_txt;
        public System.Windows.Forms.TextBox asalSekolah_txt;
        public System.Windows.Forms.ComboBox dikelas_combo;
        public System.Windows.Forms.RichTextBox alamatWali_txt;
        public System.Windows.Forms.TextBox namaWali_txt;
        public System.Windows.Forms.TextBox namaAyah_txt;
        public System.Windows.Forms.RichTextBox alamatOrtu_txt;
        public System.Windows.Forms.TextBox namaIbu_txt;
        public System.Windows.Forms.TextBox pekerjaanWali_txt;
        public System.Windows.Forms.TextBox telpOrtu_txt;
        public System.Windows.Forms.TextBox pekerjaanAyah_txt;
        public System.Windows.Forms.TextBox pekerjaanIbu_txt;
        public System.Windows.Forms.Button delete_btn;
        public System.Windows.Forms.Button save_btn;
        public System.Windows.Forms.Button update_btn;
        public System.Windows.Forms.Button cancel_btn;
        public System.Windows.Forms.Label kode_lbl;
        public System.Windows.Forms.Label nis_lbl;
        public System.Windows.Forms.Label id_lbl;
        public System.Windows.Forms.ToolTip nis_toolTip;
        public System.Windows.Forms.Label title_lbl;
        public System.Windows.Forms.Label label24;
        public System.Windows.Forms.Label tahun_lbl;
    }
}