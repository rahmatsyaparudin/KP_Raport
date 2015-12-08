namespace Raport
{
    partial class FormNilai
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sss_rad = new System.Windows.Forms.RadioButton();
            this.ket_rad = new System.Windows.Forms.RadioButton();
            this.peng_rad = new System.Windows.Forms.RadioButton();
            this.all_rad = new System.Windows.Forms.RadioButton();
            this.dataNilai_grid = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.nis_lbl = new System.Windows.Forms.ToolStripLabel();
            this.jumlah_lbl = new System.Windows.Forms.ToolStripLabel();
            this.peng_lbl = new System.Windows.Forms.ToolStripLabel();
            this.ket_lbl = new System.Windows.Forms.ToolStripLabel();
            this.sikap_lbl = new System.Windows.Forms.ToolStripLabel();
            this.load_toolBtn = new System.Windows.Forms.ToolStripButton();
            this.dPeng_lbl = new System.Windows.Forms.ToolStripLabel();
            this.dKet_lbl = new System.Windows.Forms.ToolStripLabel();
            this.dSik_lbl = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.siswa_grid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.kelas_combo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mapel_combo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mapel_txt = new System.Windows.Forms.TextBox();
            this.wali_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.smt_combo = new System.Windows.Forms.ComboBox();
            this.set_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataNilai_grid)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siswa_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::Raport.Properties.Resources.nilai;
            this.pictureBox1.Location = new System.Drawing.Point(463, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(377, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Nilai Siswa";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.sss_rad);
            this.panel1.Controls.Add(this.ket_rad);
            this.panel1.Controls.Add(this.peng_rad);
            this.panel1.Controls.Add(this.all_rad);
            this.panel1.Controls.Add(this.dataNilai_grid);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(21, 187);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(938, 389);
            this.panel1.TabIndex = 2;
            // 
            // sss_rad
            // 
            this.sss_rad.AutoSize = true;
            this.sss_rad.BackColor = System.Drawing.Color.SteelBlue;
            this.sss_rad.Location = new System.Drawing.Point(518, -1);
            this.sss_rad.Name = "sss_rad";
            this.sss_rad.Size = new System.Drawing.Size(172, 21);
            this.sss_rad.TabIndex = 17;
            this.sss_rad.TabStop = true;
            this.sss_rad.Text = "Sikap Sosial dan Spiritual";
            this.sss_rad.UseVisualStyleBackColor = false;
            this.sss_rad.CheckedChanged += new System.EventHandler(this.sss_rad_CheckedChanged);
            // 
            // ket_rad
            // 
            this.ket_rad.AutoSize = true;
            this.ket_rad.BackColor = System.Drawing.Color.SteelBlue;
            this.ket_rad.Location = new System.Drawing.Point(415, -1);
            this.ket_rad.Name = "ket_rad";
            this.ket_rad.Size = new System.Drawing.Size(105, 21);
            this.ket_rad.TabIndex = 16;
            this.ket_rad.TabStop = true;
            this.ket_rad.Text = "Keterampilan";
            this.ket_rad.UseVisualStyleBackColor = false;
            this.ket_rad.CheckedChanged += new System.EventHandler(this.ket_rad_CheckedChanged);
            // 
            // peng_rad
            // 
            this.peng_rad.AutoSize = true;
            this.peng_rad.BackColor = System.Drawing.Color.SteelBlue;
            this.peng_rad.Location = new System.Drawing.Point(314, -1);
            this.peng_rad.Name = "peng_rad";
            this.peng_rad.Size = new System.Drawing.Size(102, 21);
            this.peng_rad.TabIndex = 15;
            this.peng_rad.TabStop = true;
            this.peng_rad.Text = "Pengetahuan";
            this.peng_rad.UseVisualStyleBackColor = false;
            this.peng_rad.CheckedChanged += new System.EventHandler(this.peng_rad_CheckedChanged);
            // 
            // all_rad
            // 
            this.all_rad.AutoSize = true;
            this.all_rad.BackColor = System.Drawing.Color.SteelBlue;
            this.all_rad.Location = new System.Drawing.Point(248, -1);
            this.all_rad.Name = "all_rad";
            this.all_rad.Size = new System.Drawing.Size(66, 21);
            this.all_rad.TabIndex = 18;
            this.all_rad.TabStop = true;
            this.all_rad.Text = "Semua";
            this.all_rad.UseVisualStyleBackColor = false;
            this.all_rad.CheckedChanged += new System.EventHandler(this.all_rad_CheckedChanged);
            // 
            // dataNilai_grid
            // 
            this.dataNilai_grid.AllowUserToAddRows = false;
            this.dataNilai_grid.AllowUserToDeleteRows = false;
            this.dataNilai_grid.AllowUserToResizeColumns = false;
            this.dataNilai_grid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataNilai_grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataNilai_grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataNilai_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataNilai_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataNilai_grid.Location = new System.Drawing.Point(0, 25);
            this.dataNilai_grid.Name = "dataNilai_grid";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataNilai_grid.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataNilai_grid.Size = new System.Drawing.Size(938, 364);
            this.dataNilai_grid.TabIndex = 14;
            this.dataNilai_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataNilai_grid_CellClick);
            this.dataNilai_grid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataNilai_grid_CellEndEdit);
            this.dataNilai_grid.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataNilai_grid_CellEnter);
            this.dataNilai_grid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataNilai_grid_CellValueChanged);
            this.dataNilai_grid.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataNilai_grid_DataError);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.SteelBlue;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nis_lbl,
            this.jumlah_lbl,
            this.peng_lbl,
            this.ket_lbl,
            this.sikap_lbl,
            this.load_toolBtn,
            this.dPeng_lbl,
            this.dKet_lbl,
            this.dSik_lbl,
            this.toolStripSeparator1,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(938, 25);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // nis_lbl
            // 
            this.nis_lbl.Name = "nis_lbl";
            this.nis_lbl.Size = new System.Drawing.Size(27, 22);
            this.nis_lbl.Text = "null";
            this.nis_lbl.Visible = false;
            // 
            // jumlah_lbl
            // 
            this.jumlah_lbl.Name = "jumlah_lbl";
            this.jumlah_lbl.Size = new System.Drawing.Size(13, 22);
            this.jumlah_lbl.Text = "0";
            this.jumlah_lbl.Visible = false;
            // 
            // peng_lbl
            // 
            this.peng_lbl.Name = "peng_lbl";
            this.peng_lbl.Size = new System.Drawing.Size(34, 22);
            this.peng_lbl.Text = "Peng";
            this.peng_lbl.Visible = false;
            // 
            // ket_lbl
            // 
            this.ket_lbl.Name = "ket_lbl";
            this.ket_lbl.Size = new System.Drawing.Size(24, 22);
            this.ket_lbl.Text = "Ket";
            this.ket_lbl.Visible = false;
            // 
            // sikap_lbl
            // 
            this.sikap_lbl.Name = "sikap_lbl";
            this.sikap_lbl.Size = new System.Drawing.Size(35, 22);
            this.sikap_lbl.Text = "Sikap";
            this.sikap_lbl.Visible = false;
            // 
            // load_toolBtn
            // 
            this.load_toolBtn.Enabled = false;
            this.load_toolBtn.Image = global::Raport.Properties.Resources.refresh;
            this.load_toolBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.load_toolBtn.Name = "load_toolBtn";
            this.load_toolBtn.Size = new System.Drawing.Size(66, 22);
            this.load_toolBtn.Text = "Refresh";
            this.load_toolBtn.Click += new System.EventHandler(this.load_toolBtn_Click);
            // 
            // dPeng_lbl
            // 
            this.dPeng_lbl.Name = "dPeng_lbl";
            this.dPeng_lbl.Size = new System.Drawing.Size(41, 22);
            this.dPeng_lbl.Text = "dPeng";
            // 
            // dKet_lbl
            // 
            this.dKet_lbl.Name = "dKet_lbl";
            this.dKet_lbl.Size = new System.Drawing.Size(31, 22);
            this.dKet_lbl.Text = "dKet";
            // 
            // dSik_lbl
            // 
            this.dSik_lbl.Name = "dSik_lbl";
            this.dSik_lbl.Size = new System.Drawing.Size(29, 22);
            this.dSik_lbl.Text = "dSik";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(65, 22);
            this.toolStripLabel1.Text = "Input Nilai ";
            // 
            // siswa_grid
            // 
            this.siswa_grid.AllowUserToAddRows = false;
            this.siswa_grid.AllowUserToDeleteRows = false;
            this.siswa_grid.AllowUserToResizeColumns = false;
            this.siswa_grid.AllowUserToResizeRows = false;
            this.siswa_grid.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.siswa_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.siswa_grid.Location = new System.Drawing.Point(673, 12);
            this.siswa_grid.Name = "siswa_grid";
            this.siswa_grid.Size = new System.Drawing.Size(294, 172);
            this.siswa_grid.TabIndex = 1;
            this.siswa_grid.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pilih Kelas";
            // 
            // kelas_combo
            // 
            this.kelas_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kelas_combo.Enabled = false;
            this.kelas_combo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kelas_combo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kelas_combo.FormattingEnabled = true;
            this.kelas_combo.IntegralHeight = false;
            this.kelas_combo.Location = new System.Drawing.Point(209, 153);
            this.kelas_combo.Name = "kelas_combo";
            this.kelas_combo.Size = new System.Drawing.Size(121, 27);
            this.kelas_combo.TabIndex = 6;
            this.kelas_combo.SelectedIndexChanged += new System.EventHandler(this.kelas_combo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(332, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kode Mapel";
            // 
            // mapel_combo
            // 
            this.mapel_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mapel_combo.Enabled = false;
            this.mapel_combo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mapel_combo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mapel_combo.FormattingEnabled = true;
            this.mapel_combo.IntegralHeight = false;
            this.mapel_combo.Location = new System.Drawing.Point(336, 153);
            this.mapel_combo.Name = "mapel_combo";
            this.mapel_combo.Size = new System.Drawing.Size(121, 27);
            this.mapel_combo.TabIndex = 8;
            this.mapel_combo.SelectedIndexChanged += new System.EventHandler(this.mapel_combo_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(674, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Pengajar";
            // 
            // mapel_txt
            // 
            this.mapel_txt.Enabled = false;
            this.mapel_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mapel_txt.Location = new System.Drawing.Point(463, 154);
            this.mapel_txt.Name = "mapel_txt";
            this.mapel_txt.ReadOnly = true;
            this.mapel_txt.Size = new System.Drawing.Size(209, 26);
            this.mapel_txt.TabIndex = 10;
            this.mapel_txt.TabStop = false;
            // 
            // wali_txt
            // 
            this.wali_txt.Enabled = false;
            this.wali_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wali_txt.Location = new System.Drawing.Point(678, 153);
            this.wali_txt.Name = "wali_txt";
            this.wali_txt.ReadOnly = true;
            this.wali_txt.Size = new System.Drawing.Size(281, 26);
            this.wali_txt.TabIndex = 12;
            this.wali_txt.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(459, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mata Pelajaran";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 21);
            this.label6.TabIndex = 2;
            this.label6.Text = "Pilih Semester";
            // 
            // smt_combo
            // 
            this.smt_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.smt_combo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smt_combo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smt_combo.FormattingEnabled = true;
            this.smt_combo.IntegralHeight = false;
            this.smt_combo.Location = new System.Drawing.Point(21, 153);
            this.smt_combo.Name = "smt_combo";
            this.smt_combo.Size = new System.Drawing.Size(121, 27);
            this.smt_combo.TabIndex = 3;
            // 
            // set_btn
            // 
            this.set_btn.Location = new System.Drawing.Point(148, 152);
            this.set_btn.Name = "set_btn";
            this.set_btn.Size = new System.Drawing.Size(55, 29);
            this.set_btn.TabIndex = 4;
            this.set_btn.Text = "Set";
            this.set_btn.UseVisualStyleBackColor = true;
            this.set_btn.Click += new System.EventHandler(this.set_btn_Click);
            // 
            // FormNilai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(971, 608);
            this.Controls.Add(this.set_btn);
            this.Controls.Add(this.smt_combo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.wali_txt);
            this.Controls.Add(this.mapel_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mapel_combo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kelas_combo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.siswa_grid);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormNilai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pengolah Data Nilai";
            this.Load += new System.EventHandler(this.FormNilai_Load);
            this.SizeChanged += new System.EventHandler(this.FormNilai_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataNilai_grid)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siswa_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox kelas_combo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox mapel_combo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox mapel_txt;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridView dataNilai_grid;
        private System.Windows.Forms.TextBox wali_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox smt_combo;
        private System.Windows.Forms.ToolStripLabel nis_lbl;
        private System.Windows.Forms.DataGridView siswa_grid;
        private System.Windows.Forms.ToolStripLabel jumlah_lbl;
        private System.Windows.Forms.Button set_btn;
        private System.Windows.Forms.ToolStripLabel peng_lbl;
        private System.Windows.Forms.ToolStripLabel ket_lbl;
        private System.Windows.Forms.ToolStripLabel sikap_lbl;
        private System.Windows.Forms.ToolStripButton load_toolBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.RadioButton peng_rad;
        private System.Windows.Forms.RadioButton sss_rad;
        private System.Windows.Forms.RadioButton ket_rad;
        private System.Windows.Forms.RadioButton all_rad;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel dPeng_lbl;
        private System.Windows.Forms.ToolStripLabel dKet_lbl;
        private System.Windows.Forms.ToolStripLabel dSik_lbl;
    }
}