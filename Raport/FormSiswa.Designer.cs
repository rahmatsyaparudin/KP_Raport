namespace Raport
{
    partial class FormSiswa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            this.view_tab = new System.Windows.Forms.TabPage();
            this.search_txt = new System.Windows.Forms.TextBox();
            this.sortby_combo = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.add_toolStr = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.refresh_toolStr = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.siswa_grid = new System.Windows.Forms.DataGridView();
            this.siswa_tab = new System.Windows.Forms.TabControl();
            this.kelas_tab = new System.Windows.Forms.TabPage();
            this.history_tab = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.dataKelas_grid = new System.Windows.Forms.DataGridView();
            this.datagrid_datakelas = new System.Windows.Forms.DataGridView();
            this.view_tab.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siswa_grid)).BeginInit();
            this.siswa_tab.SuspendLayout();
            this.kelas_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataKelas_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_datakelas)).BeginInit();
            this.SuspendLayout();
            // 
            // view_tab
            // 
            this.view_tab.BackColor = System.Drawing.Color.DarkCyan;
            this.view_tab.Controls.Add(this.search_txt);
            this.view_tab.Controls.Add(this.sortby_combo);
            this.view_tab.Controls.Add(this.toolStrip1);
            this.view_tab.Controls.Add(this.siswa_grid);
            this.view_tab.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_tab.Location = new System.Drawing.Point(4, 30);
            this.view_tab.Name = "view_tab";
            this.view_tab.Padding = new System.Windows.Forms.Padding(3);
            this.view_tab.Size = new System.Drawing.Size(872, 433);
            this.view_tab.TabIndex = 1;
            this.view_tab.Text = "View Data";
            // 
            // search_txt
            // 
            this.search_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search_txt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.search_txt.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_txt.Location = new System.Drawing.Point(675, 4);
            this.search_txt.Name = "search_txt";
            this.search_txt.Size = new System.Drawing.Size(179, 25);
            this.search_txt.TabIndex = 4;
            this.search_txt.TextChanged += new System.EventHandler(this.search_txt_TextChanged);
            // 
            // sortby_combo
            // 
            this.sortby_combo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.sortby_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortby_combo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sortby_combo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortby_combo.FormattingEnabled = true;
            this.sortby_combo.IntegralHeight = false;
            this.sortby_combo.Location = new System.Drawing.Point(300, 5);
            this.sortby_combo.Name = "sortby_combo";
            this.sortby_combo.Size = new System.Drawing.Size(112, 25);
            this.sortby_combo.TabIndex = 3;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add_toolStr,
            this.toolStripSeparator1,
            this.refresh_toolStr,
            this.toolStripSeparator2,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(866, 28);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // add_toolStr
            // 
            this.add_toolStr.Image = global::Raport.Properties.Resources.add;
            this.add_toolStr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.add_toolStr.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.add_toolStr.Name = "add_toolStr";
            this.add_toolStr.Size = new System.Drawing.Size(94, 25);
            this.add_toolStr.Text = "Add New";
            this.add_toolStr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.add_toolStr.Click += new System.EventHandler(this.add_toolStr_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // refresh_toolStr
            // 
            this.refresh_toolStr.Image = global::Raport.Properties.Resources.refresh;
            this.refresh_toolStr.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refresh_toolStr.Name = "refresh_toolStr";
            this.refresh_toolStr.Size = new System.Drawing.Size(119, 25);
            this.refresh_toolStr.Text = "Refresh Data";
            this.refresh_toolStr.Click += new System.EventHandler(this.refresh_toolStr_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(60, 25);
            this.toolStripLabel1.Text = "Sort By";
            // 
            // siswa_grid
            // 
            this.siswa_grid.AllowUserToAddRows = false;
            this.siswa_grid.AllowUserToDeleteRows = false;
            this.siswa_grid.AllowUserToResizeColumns = false;
            this.siswa_grid.AllowUserToResizeRows = false;
            dataGridViewCellStyle28.NullValue = null;
            this.siswa_grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle28;
            this.siswa_grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.siswa_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.siswa_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.siswa_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle30.NullValue = null;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.siswa_grid.DefaultCellStyle = dataGridViewCellStyle30;
            this.siswa_grid.Location = new System.Drawing.Point(0, 36);
            this.siswa_grid.Name = "siswa_grid";
            this.siswa_grid.ReadOnly = true;
            this.siswa_grid.Size = new System.Drawing.Size(872, 397);
            this.siswa_grid.TabIndex = 5;
            this.siswa_grid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.siswa_grid_CellDoubleClick);
            // 
            // siswa_tab
            // 
            this.siswa_tab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.siswa_tab.Controls.Add(this.view_tab);
            this.siswa_tab.Controls.Add(this.kelas_tab);
            this.siswa_tab.Controls.Add(this.history_tab);
            this.siswa_tab.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siswa_tab.Location = new System.Drawing.Point(0, 151);
            this.siswa_tab.Name = "siswa_tab";
            this.siswa_tab.SelectedIndex = 0;
            this.siswa_tab.Size = new System.Drawing.Size(880, 467);
            this.siswa_tab.TabIndex = 1;
            // 
            // kelas_tab
            // 
            this.kelas_tab.Controls.Add(this.dataKelas_grid);
            this.kelas_tab.Controls.Add(this.toolStrip2);
            this.kelas_tab.Location = new System.Drawing.Point(4, 30);
            this.kelas_tab.Name = "kelas_tab";
            this.kelas_tab.Padding = new System.Windows.Forms.Padding(3);
            this.kelas_tab.Size = new System.Drawing.Size(872, 433);
            this.kelas_tab.TabIndex = 2;
            this.kelas_tab.Text = "Data Kelas";
            this.kelas_tab.UseVisualStyleBackColor = true;
            // 
            // history_tab
            // 
            this.history_tab.Location = new System.Drawing.Point(4, 30);
            this.history_tab.Name = "history_tab";
            this.history_tab.Padding = new System.Windows.Forms.Padding(3);
            this.history_tab.Size = new System.Drawing.Size(872, 433);
            this.history_tab.TabIndex = 3;
            this.history_tab.Text = "History Data";
            this.history_tab.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(369, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "Data Siswa";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::Raport.Properties.Resources.siswa;
            this.pictureBox1.Location = new System.Drawing.Point(393, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Location = new System.Drawing.Point(3, 3);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(866, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // dataKelas_grid
            // 
            this.dataKelas_grid.AllowUserToAddRows = false;
            this.dataKelas_grid.AllowUserToDeleteRows = false;
            this.dataKelas_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataKelas_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataKelas_grid.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataKelas_grid.Location = new System.Drawing.Point(3, 28);
            this.dataKelas_grid.Name = "dataKelas_grid";
            this.dataKelas_grid.ReadOnly = true;
            this.dataKelas_grid.Size = new System.Drawing.Size(866, 405);
            this.dataKelas_grid.TabIndex = 2;
            // 
            // datagrid_datakelas
            // 
            this.datagrid_datakelas.AllowUserToAddRows = false;
            this.datagrid_datakelas.AllowUserToDeleteRows = false;
            this.datagrid_datakelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_datakelas.Location = new System.Drawing.Point(533, 5);
            this.datagrid_datakelas.Name = "datagrid_datakelas";
            this.datagrid_datakelas.ReadOnly = true;
            this.datagrid_datakelas.Size = new System.Drawing.Size(318, 151);
            this.datagrid_datakelas.TabIndex = 3;
            // 
            // FormSiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(880, 616);
            this.Controls.Add(this.datagrid_datakelas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.siswa_tab);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormSiswa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Siswa SMANJAK 1";
            this.Load += new System.EventHandler(this.FormSiswa_Load);
            this.view_tab.ResumeLayout(false);
            this.view_tab.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siswa_grid)).EndInit();
            this.siswa_tab.ResumeLayout(false);
            this.kelas_tab.ResumeLayout(false);
            this.kelas_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataKelas_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_datakelas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage view_tab;
        private System.Windows.Forms.TabControl siswa_tab;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton add_toolStr;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ComboBox sortby_combo;
        private System.Windows.Forms.TextBox search_txt;
        private System.Windows.Forms.ToolStripButton refresh_toolStr;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView siswa_grid;
        private System.Windows.Forms.TabPage kelas_tab;
        private System.Windows.Forms.TabPage history_tab;
        private System.Windows.Forms.DataGridView dataKelas_grid;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.DataGridView datagrid_datakelas;
    }
}