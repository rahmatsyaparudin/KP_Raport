namespace Raport
{
    partial class FormDeskripsi
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
            this.label1 = new System.Windows.Forms.Label();
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
            this.atas_txt = new System.Windows.Forms.RichTextBox();
            this.tengah_txt = new System.Windows.Forms.RichTextBox();
            this.bawah_txt = new System.Windows.Forms.RichTextBox();
            this.desk_tab = new System.Windows.Forms.TabControl();
            this.add_tab = new System.Windows.Forms.TabPage();
            this.deskID_lbl = new System.Windows.Forms.Label();
            this.edit_btn = new System.Windows.Forms.Button();
            this.reset_btn = new System.Windows.Forms.Button();
            this.jumlah_lbl = new System.Windows.Forms.Label();
            this.save_btn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sss_rad = new System.Windows.Forms.RadioButton();
            this.ket_rad = new System.Windows.Forms.RadioButton();
            this.peng_rad = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.desk_tab.SuspendLayout();
            this.add_tab.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(377, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Deskripsi Nilai";
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
            // atas_txt
            // 
            this.atas_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.atas_txt.Enabled = false;
            this.atas_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atas_txt.Location = new System.Drawing.Point(6, 28);
            this.atas_txt.Name = "atas_txt";
            this.atas_txt.Size = new System.Drawing.Size(286, 260);
            this.atas_txt.TabIndex = 14;
            this.atas_txt.Text = "";
            // 
            // tengah_txt
            // 
            this.tengah_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tengah_txt.Enabled = false;
            this.tengah_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tengah_txt.Location = new System.Drawing.Point(4, 28);
            this.tengah_txt.Name = "tengah_txt";
            this.tengah_txt.Size = new System.Drawing.Size(286, 260);
            this.tengah_txt.TabIndex = 15;
            this.tengah_txt.Text = "";
            // 
            // bawah_txt
            // 
            this.bawah_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bawah_txt.Enabled = false;
            this.bawah_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bawah_txt.Location = new System.Drawing.Point(6, 28);
            this.bawah_txt.Name = "bawah_txt";
            this.bawah_txt.Size = new System.Drawing.Size(286, 260);
            this.bawah_txt.TabIndex = 16;
            this.bawah_txt.Text = "";
            // 
            // desk_tab
            // 
            this.desk_tab.Controls.Add(this.add_tab);
            this.desk_tab.Enabled = false;
            this.desk_tab.Location = new System.Drawing.Point(19, 195);
            this.desk_tab.Name = "desk_tab";
            this.desk_tab.SelectedIndex = 0;
            this.desk_tab.Size = new System.Drawing.Size(938, 418);
            this.desk_tab.TabIndex = 17;
            // 
            // add_tab
            // 
            this.add_tab.BackColor = System.Drawing.Color.SteelBlue;
            this.add_tab.Controls.Add(this.jumlah_lbl);
            this.add_tab.Controls.Add(this.edit_btn);
            this.add_tab.Controls.Add(this.deskID_lbl);
            this.add_tab.Controls.Add(this.reset_btn);
            this.add_tab.Controls.Add(this.save_btn);
            this.add_tab.Controls.Add(this.groupBox3);
            this.add_tab.Controls.Add(this.groupBox2);
            this.add_tab.Controls.Add(this.groupBox1);
            this.add_tab.Controls.Add(this.sss_rad);
            this.add_tab.Controls.Add(this.ket_rad);
            this.add_tab.Controls.Add(this.peng_rad);
            this.add_tab.Controls.Add(this.label7);
            this.add_tab.Location = new System.Drawing.Point(4, 30);
            this.add_tab.Name = "add_tab";
            this.add_tab.Padding = new System.Windows.Forms.Padding(3);
            this.add_tab.Size = new System.Drawing.Size(930, 384);
            this.add_tab.TabIndex = 0;
            this.add_tab.Text = "Add Desc";
            // 
            // deskID_lbl
            // 
            this.deskID_lbl.AutoSize = true;
            this.deskID_lbl.Location = new System.Drawing.Point(688, 8);
            this.deskID_lbl.Name = "deskID_lbl";
            this.deskID_lbl.Size = new System.Drawing.Size(36, 21);
            this.deskID_lbl.TabIndex = 31;
            this.deskID_lbl.Text = "null";
            // 
            // edit_btn
            // 
            this.edit_btn.Location = new System.Drawing.Point(840, 8);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(75, 32);
            this.edit_btn.TabIndex = 30;
            this.edit_btn.Text = "Edit";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // reset_btn
            // 
            this.reset_btn.Enabled = false;
            this.reset_btn.Location = new System.Drawing.Point(440, 349);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(75, 32);
            this.reset_btn.TabIndex = 29;
            this.reset_btn.Text = "Reset";
            this.reset_btn.UseVisualStyleBackColor = true;
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // jumlah_lbl
            // 
            this.jumlah_lbl.AutoSize = true;
            this.jumlah_lbl.Location = new System.Drawing.Point(646, 8);
            this.jumlah_lbl.Name = "jumlah_lbl";
            this.jumlah_lbl.Size = new System.Drawing.Size(36, 21);
            this.jumlah_lbl.TabIndex = 28;
            this.jumlah_lbl.Text = "null";
            // 
            // save_btn
            // 
            this.save_btn.Enabled = false;
            this.save_btn.Location = new System.Drawing.Point(359, 349);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(75, 32);
            this.save_btn.TabIndex = 18;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bawah_txt);
            this.groupBox3.Location = new System.Drawing.Point(617, 38);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(298, 302);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kelompok Bawah (B)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tengah_txt);
            this.groupBox2.Location = new System.Drawing.Point(313, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 302);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kelompok Tengah (T)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.atas_txt);
            this.groupBox1.Location = new System.Drawing.Point(9, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 302);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kelompok Atas (A)";
            // 
            // sss_rad
            // 
            this.sss_rad.AutoSize = true;
            this.sss_rad.Location = new System.Drawing.Point(413, 6);
            this.sss_rad.Name = "sss_rad";
            this.sss_rad.Size = new System.Drawing.Size(218, 25);
            this.sss_rad.TabIndex = 24;
            this.sss_rad.TabStop = true;
            this.sss_rad.Text = "Sikap Sosial dan Spiritual";
            this.sss_rad.UseVisualStyleBackColor = true;
            this.sss_rad.CheckedChanged += new System.EventHandler(this.sss_rad_CheckedChanged);
            // 
            // ket_rad
            // 
            this.ket_rad.AutoSize = true;
            this.ket_rad.Location = new System.Drawing.Point(282, 6);
            this.ket_rad.Name = "ket_rad";
            this.ket_rad.Size = new System.Drawing.Size(125, 25);
            this.ket_rad.TabIndex = 23;
            this.ket_rad.TabStop = true;
            this.ket_rad.Text = "Keterampilan";
            this.ket_rad.UseVisualStyleBackColor = true;
            this.ket_rad.CheckedChanged += new System.EventHandler(this.ket_rad_CheckedChanged);
            // 
            // peng_rad
            // 
            this.peng_rad.AutoSize = true;
            this.peng_rad.Location = new System.Drawing.Point(155, 6);
            this.peng_rad.Name = "peng_rad";
            this.peng_rad.Size = new System.Drawing.Size(121, 25);
            this.peng_rad.TabIndex = 22;
            this.peng_rad.TabStop = true;
            this.peng_rad.Text = "Pengetahuan";
            this.peng_rad.UseVisualStyleBackColor = true;
            this.peng_rad.CheckedChanged += new System.EventHandler(this.peng_rad_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 21);
            this.label7.TabIndex = 17;
            this.label7.Text = "Deskripsi Untuk";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::Raport.Properties.Resources.deskripsi;
            this.pictureBox1.Location = new System.Drawing.Point(432, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormDeskripsi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(971, 652);
            this.Controls.Add(this.desk_tab);
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
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FormDeskripsi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deskripsi Nilai";
            this.Load += new System.EventHandler(this.FormDeskripsi_Load);
            this.desk_tab.ResumeLayout(false);
            this.add_tab.ResumeLayout(false);
            this.add_tab.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox kelas_combo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox mapel_combo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox mapel_txt;
        private System.Windows.Forms.TextBox wali_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox smt_combo;
        private System.Windows.Forms.Button set_btn;
        private System.Windows.Forms.RichTextBox atas_txt;
        private System.Windows.Forms.RichTextBox tengah_txt;
        private System.Windows.Forms.RichTextBox bawah_txt;
        private System.Windows.Forms.TabControl desk_tab;
        private System.Windows.Forms.TabPage add_tab;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton peng_rad;
        private System.Windows.Forms.RadioButton ket_rad;
        private System.Windows.Forms.RadioButton sss_rad;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label jumlah_lbl;
        private System.Windows.Forms.Button reset_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Label deskID_lbl;
    }
}