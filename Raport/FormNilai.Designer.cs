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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataNilai_grid = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.label2 = new System.Windows.Forms.Label();
            this.kelas_combo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mapel_combo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mapel_txt = new System.Windows.Forms.TextBox();
            this.wali_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataNilai_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::Raport.Properties.Resources.nilai;
            this.pictureBox1.Location = new System.Drawing.Point(370, 12);
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
            this.label1.Location = new System.Drawing.Point(284, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data Nilai Siswa";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.dataNilai_grid);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(21, 189);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 340);
            this.panel1.TabIndex = 2;
            // 
            // dataNilai_grid
            // 
            this.dataNilai_grid.AllowUserToAddRows = false;
            this.dataNilai_grid.AllowUserToDeleteRows = false;
            this.dataNilai_grid.AllowUserToResizeColumns = false;
            this.dataNilai_grid.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataNilai_grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dataNilai_grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataNilai_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataNilai_grid.Location = new System.Drawing.Point(0, 25);
            this.dataNilai_grid.Name = "dataNilai_grid";
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataNilai_grid.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dataNilai_grid.Size = new System.Drawing.Size(750, 315);
            this.dataNilai_grid.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(750, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pilih Kelas";
            // 
            // kelas_combo
            // 
            this.kelas_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kelas_combo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kelas_combo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kelas_combo.FormattingEnabled = true;
            this.kelas_combo.IntegralHeight = false;
            this.kelas_combo.Location = new System.Drawing.Point(21, 154);
            this.kelas_combo.Name = "kelas_combo";
            this.kelas_combo.Size = new System.Drawing.Size(121, 27);
            this.kelas_combo.TabIndex = 4;
            this.kelas_combo.SelectedIndexChanged += new System.EventHandler(this.kelas_combo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 21);
            this.label3.TabIndex = 5;
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
            this.mapel_combo.Location = new System.Drawing.Point(148, 154);
            this.mapel_combo.Name = "mapel_combo";
            this.mapel_combo.Size = new System.Drawing.Size(121, 27);
            this.mapel_combo.TabIndex = 6;
            this.mapel_combo.SelectedIndexChanged += new System.EventHandler(this.mapel_combo_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(487, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Wali Kelas";
            // 
            // mapel_txt
            // 
            this.mapel_txt.Enabled = false;
            this.mapel_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mapel_txt.Location = new System.Drawing.Point(275, 154);
            this.mapel_txt.Name = "mapel_txt";
            this.mapel_txt.ReadOnly = true;
            this.mapel_txt.Size = new System.Drawing.Size(209, 26);
            this.mapel_txt.TabIndex = 8;
            this.mapel_txt.TabStop = false;
            // 
            // wali_txt
            // 
            this.wali_txt.Enabled = false;
            this.wali_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wali_txt.Location = new System.Drawing.Point(490, 154);
            this.wali_txt.Name = "wali_txt";
            this.wali_txt.ReadOnly = true;
            this.wali_txt.Size = new System.Drawing.Size(281, 26);
            this.wali_txt.TabIndex = 9;
            this.wali_txt.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(271, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Mata Pelajaran";
            // 
            // FormNilai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(784, 561);
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
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormNilai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pengolah Data Nilai";
            this.Load += new System.EventHandler(this.FormNilai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataNilai_grid)).EndInit();
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
    }
}