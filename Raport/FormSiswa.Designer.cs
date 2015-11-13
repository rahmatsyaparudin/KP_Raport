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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siswa_grid)).BeginInit();
            this.siswa_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBox2);
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 30);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(872, 433);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(236, 51);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 29);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(81, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 29);
            this.textBox1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DarkCyan;
            this.tabPage2.Controls.Add(this.search_txt);
            this.tabPage2.Controls.Add(this.sortby_combo);
            this.tabPage2.Controls.Add(this.toolStrip1);
            this.tabPage2.Controls.Add(this.siswa_grid);
            this.tabPage2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(872, 433);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "View Data";
            // 
            // search_txt
            // 
            this.search_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search_txt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.search_txt.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_txt.Location = new System.Drawing.Point(675, 4);
            this.search_txt.Name = "search_txt";
            this.search_txt.Size = new System.Drawing.Size(179, 25);
            this.search_txt.TabIndex = 3;
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
            this.sortby_combo.TabIndex = 2;
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
            this.toolStrip1.TabIndex = 1;
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
            dataGridViewCellStyle1.NullValue = null;
            this.siswa_grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.siswa_grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.siswa_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.siswa_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.siswa_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.siswa_grid.DefaultCellStyle = dataGridViewCellStyle3;
            this.siswa_grid.Location = new System.Drawing.Point(0, 36);
            this.siswa_grid.Name = "siswa_grid";
            this.siswa_grid.ReadOnly = true;
            this.siswa_grid.Size = new System.Drawing.Size(872, 397);
            this.siswa_grid.TabIndex = 0;
            this.siswa_grid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.siswa_grid_CellDoubleClick);
            // 
            // siswa_tab
            // 
            this.siswa_tab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.siswa_tab.Controls.Add(this.tabPage2);
            this.siswa_tab.Controls.Add(this.tabPage1);
            this.siswa_tab.Controls.Add(this.tabPage3);
            this.siswa_tab.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siswa_tab.Location = new System.Drawing.Point(0, 151);
            this.siswa_tab.Name = "siswa_tab";
            this.siswa_tab.SelectedIndex = 0;
            this.siswa_tab.Size = new System.Drawing.Size(880, 467);
            this.siswa_tab.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.AutoScrollMargin = new System.Drawing.Size(20, 20);
            this.tabPage1.AutoScrollMinSize = new System.Drawing.Size(200, 200);
            this.tabPage1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(872, 433);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Student";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(369, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 36);
            this.label2.TabIndex = 2;
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
            // FormSiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(880, 616);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.siswa_tab);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormSiswa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Siswa SMANJAK 1";
            this.Load += new System.EventHandler(this.FormSiswa_Load);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siswa_grid)).EndInit();
            this.siswa_tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl siswa_tab;
        private System.Windows.Forms.TabPage tabPage1;
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
    }
}