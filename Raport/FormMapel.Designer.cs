namespace Raport
{
    partial class FormMapel
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
            this.mapel_tab = new System.Windows.Forms.TabControl();
            this.dataMapel_tab = new System.Windows.Forms.TabPage();
            this.sort_combo = new System.Windows.Forms.ComboBox();
            this.search_txt = new System.Windows.Forms.TextBox();
            this.mapel_toolStrip = new System.Windows.Forms.ToolStrip();
            this.add_toolBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.refresh_toolBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.dataMapel_grid = new System.Windows.Forms.DataGridView();
            this.addMapel_tab = new System.Windows.Forms.TabPage();
            this.getId_txt = new System.Windows.Forms.TextBox();
            this.delete_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.jam_combo = new System.Windows.Forms.ComboBox();
            this.kategori_combo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mapel_txt = new System.Windows.Forms.TextBox();
            this.kode_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mapel_tab.SuspendLayout();
            this.dataMapel_tab.SuspendLayout();
            this.mapel_toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMapel_grid)).BeginInit();
            this.addMapel_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(242, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mata Pelajaran";
            // 
            // mapel_tab
            // 
            this.mapel_tab.Controls.Add(this.dataMapel_tab);
            this.mapel_tab.Controls.Add(this.addMapel_tab);
            this.mapel_tab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mapel_tab.Location = new System.Drawing.Point(-1, 150);
            this.mapel_tab.Name = "mapel_tab";
            this.mapel_tab.SelectedIndex = 0;
            this.mapel_tab.Size = new System.Drawing.Size(685, 413);
            this.mapel_tab.TabIndex = 1;
            // 
            // dataMapel_tab
            // 
            this.dataMapel_tab.BackColor = System.Drawing.Color.LightSeaGreen;
            this.dataMapel_tab.Controls.Add(this.sort_combo);
            this.dataMapel_tab.Controls.Add(this.search_txt);
            this.dataMapel_tab.Controls.Add(this.mapel_toolStrip);
            this.dataMapel_tab.Controls.Add(this.dataMapel_grid);
            this.dataMapel_tab.Location = new System.Drawing.Point(4, 29);
            this.dataMapel_tab.Name = "dataMapel_tab";
            this.dataMapel_tab.Padding = new System.Windows.Forms.Padding(3);
            this.dataMapel_tab.Size = new System.Drawing.Size(677, 380);
            this.dataMapel_tab.TabIndex = 1;
            this.dataMapel_tab.Text = "View Mapel";
            // 
            // sort_combo
            // 
            this.sort_combo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.sort_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sort_combo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sort_combo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sort_combo.FormattingEnabled = true;
            this.sort_combo.IntegralHeight = false;
            this.sort_combo.Location = new System.Drawing.Point(298, 4);
            this.sort_combo.Name = "sort_combo";
            this.sort_combo.Size = new System.Drawing.Size(113, 24);
            this.sort_combo.TabIndex = 3;
            this.sort_combo.SelectedIndexChanged += new System.EventHandler(this.sort_combo_SelectedIndexChanged);
            // 
            // search_txt
            // 
            this.search_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search_txt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.search_txt.Location = new System.Drawing.Point(515, 3);
            this.search_txt.Name = "search_txt";
            this.search_txt.Size = new System.Drawing.Size(147, 26);
            this.search_txt.TabIndex = 4;
            this.search_txt.TextChanged += new System.EventHandler(this.search_txt_TextChanged);
            // 
            // mapel_toolStrip
            // 
            this.mapel_toolStrip.BackColor = System.Drawing.Color.Turquoise;
            this.mapel_toolStrip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mapel_toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add_toolBtn,
            this.toolStripSeparator1,
            this.refresh_toolBtn,
            this.toolStripSeparator2,
            this.toolStripLabel1});
            this.mapel_toolStrip.Location = new System.Drawing.Point(3, 3);
            this.mapel_toolStrip.Name = "mapel_toolStrip";
            this.mapel_toolStrip.Size = new System.Drawing.Size(671, 28);
            this.mapel_toolStrip.TabIndex = 2;
            this.mapel_toolStrip.Text = "toolStrip1";
            // 
            // add_toolBtn
            // 
            this.add_toolBtn.Image = global::Raport.Properties.Resources.add;
            this.add_toolBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.add_toolBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.add_toolBtn.Name = "add_toolBtn";
            this.add_toolBtn.Size = new System.Drawing.Size(94, 25);
            this.add_toolBtn.Text = "Add Data";
            this.add_toolBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.add_toolBtn.Click += new System.EventHandler(this.add_toolBtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // refresh_toolBtn
            // 
            this.refresh_toolBtn.Image = global::Raport.Properties.Resources.refresh;
            this.refresh_toolBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refresh_toolBtn.Name = "refresh_toolBtn";
            this.refresh_toolBtn.Size = new System.Drawing.Size(119, 25);
            this.refresh_toolBtn.Text = "Refresh Data";
            this.refresh_toolBtn.Click += new System.EventHandler(this.refresh_toolBtn_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(60, 25);
            this.toolStripLabel1.Text = "Sort By";
            // 
            // dataMapel_grid
            // 
            this.dataMapel_grid.AllowUserToAddRows = false;
            this.dataMapel_grid.AllowUserToDeleteRows = false;
            this.dataMapel_grid.AllowUserToResizeColumns = false;
            this.dataMapel_grid.AllowUserToResizeRows = false;
            this.dataMapel_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataMapel_grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataMapel_grid.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataMapel_grid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataMapel_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMapel_grid.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataMapel_grid.Location = new System.Drawing.Point(12, 38);
            this.dataMapel_grid.Name = "dataMapel_grid";
            this.dataMapel_grid.ReadOnly = true;
            this.dataMapel_grid.Size = new System.Drawing.Size(652, 332);
            this.dataMapel_grid.TabIndex = 5;
            this.dataMapel_grid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataMapel_grid_CellDoubleClick);
            // 
            // addMapel_tab
            // 
            this.addMapel_tab.BackColor = System.Drawing.Color.LightSeaGreen;
            this.addMapel_tab.Controls.Add(this.getId_txt);
            this.addMapel_tab.Controls.Add(this.delete_btn);
            this.addMapel_tab.Controls.Add(this.update_btn);
            this.addMapel_tab.Controls.Add(this.cancel_btn);
            this.addMapel_tab.Controls.Add(this.save_btn);
            this.addMapel_tab.Controls.Add(this.jam_combo);
            this.addMapel_tab.Controls.Add(this.kategori_combo);
            this.addMapel_tab.Controls.Add(this.label5);
            this.addMapel_tab.Controls.Add(this.mapel_txt);
            this.addMapel_tab.Controls.Add(this.kode_txt);
            this.addMapel_tab.Controls.Add(this.label4);
            this.addMapel_tab.Controls.Add(this.label3);
            this.addMapel_tab.Controls.Add(this.label2);
            this.addMapel_tab.Location = new System.Drawing.Point(4, 29);
            this.addMapel_tab.Name = "addMapel_tab";
            this.addMapel_tab.Padding = new System.Windows.Forms.Padding(3);
            this.addMapel_tab.Size = new System.Drawing.Size(677, 380);
            this.addMapel_tab.TabIndex = 0;
            this.addMapel_tab.Text = "Add Mapel";
            // 
            // getId_txt
            // 
            this.getId_txt.Location = new System.Drawing.Point(276, 42);
            this.getId_txt.Name = "getId_txt";
            this.getId_txt.Size = new System.Drawing.Size(47, 26);
            this.getId_txt.TabIndex = 8;
            this.getId_txt.Visible = false;
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.Turquoise;
            this.delete_btn.Enabled = false;
            this.delete_btn.FlatAppearance.BorderSize = 0;
            this.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_btn.Image = global::Raport.Properties.Resources.delete;
            this.delete_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delete_btn.Location = new System.Drawing.Point(152, 198);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(86, 29);
            this.delete_btn.TabIndex = 14;
            this.delete_btn.Text = "Delete";
            this.delete_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.delete_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.BackColor = System.Drawing.Color.Turquoise;
            this.update_btn.Enabled = false;
            this.update_btn.FlatAppearance.BorderSize = 0;
            this.update_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_btn.Image = global::Raport.Properties.Resources.edit1;
            this.update_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.update_btn.Location = new System.Drawing.Point(58, 198);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(88, 29);
            this.update_btn.TabIndex = 13;
            this.update_btn.Text = "Update";
            this.update_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.update_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.update_btn.UseVisualStyleBackColor = false;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.Color.Turquoise;
            this.cancel_btn.Enabled = false;
            this.cancel_btn.FlatAppearance.BorderSize = 0;
            this.cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_btn.Image = global::Raport.Properties.Resources.cancel;
            this.cancel_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancel_btn.Location = new System.Drawing.Point(152, 163);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(86, 29);
            this.cancel_btn.TabIndex = 12;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancel_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cancel_btn.UseVisualStyleBackColor = false;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.Color.Turquoise;
            this.save_btn.Enabled = false;
            this.save_btn.FlatAppearance.BorderColor = System.Drawing.Color.Aquamarine;
            this.save_btn.FlatAppearance.BorderSize = 0;
            this.save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_btn.Image = global::Raport.Properties.Resources.save;
            this.save_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.save_btn.Location = new System.Drawing.Point(58, 163);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(88, 29);
            this.save_btn.TabIndex = 11;
            this.save_btn.Text = "Save";
            this.save_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.save_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // jam_combo
            // 
            this.jam_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.jam_combo.Enabled = false;
            this.jam_combo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.jam_combo.FormattingEnabled = true;
            this.jam_combo.IntegralHeight = false;
            this.jam_combo.Location = new System.Drawing.Point(152, 75);
            this.jam_combo.Name = "jam_combo";
            this.jam_combo.Size = new System.Drawing.Size(118, 28);
            this.jam_combo.TabIndex = 9;
            // 
            // kategori_combo
            // 
            this.kategori_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kategori_combo.Enabled = false;
            this.kategori_combo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.kategori_combo.FormattingEnabled = true;
            this.kategori_combo.IntegralHeight = false;
            this.kategori_combo.Location = new System.Drawing.Point(152, 110);
            this.kategori_combo.Name = "kategori_combo";
            this.kategori_combo.Size = new System.Drawing.Size(118, 28);
            this.kategori_combo.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Kategori";
            // 
            // mapel_txt
            // 
            this.mapel_txt.Enabled = false;
            this.mapel_txt.Location = new System.Drawing.Point(152, 11);
            this.mapel_txt.MaxLength = 60;
            this.mapel_txt.Name = "mapel_txt";
            this.mapel_txt.Size = new System.Drawing.Size(227, 26);
            this.mapel_txt.TabIndex = 6;
            // 
            // kode_txt
            // 
            this.kode_txt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.kode_txt.Enabled = false;
            this.kode_txt.Location = new System.Drawing.Point(152, 42);
            this.kode_txt.MaxLength = 5;
            this.kode_txt.Name = "kode_txt";
            this.kode_txt.Size = new System.Drawing.Size(118, 26);
            this.kode_txt.TabIndex = 7;
            this.kode_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kode_txt_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Jam Pelajaran";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kode Mapel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mata Pelajaran";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Raport.Properties.Resources.appbarbook;
            this.pictureBox1.Location = new System.Drawing.Point(297, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormMapel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.mapel_tab);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormMapel";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Mata Pelajaran SMANJAK 1";
            this.Load += new System.EventHandler(this.FormMapel_Load);
            this.mapel_tab.ResumeLayout(false);
            this.dataMapel_tab.ResumeLayout(false);
            this.dataMapel_tab.PerformLayout();
            this.mapel_toolStrip.ResumeLayout(false);
            this.mapel_toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMapel_grid)).EndInit();
            this.addMapel_tab.ResumeLayout(false);
            this.addMapel_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl mapel_tab;
        private System.Windows.Forms.TabPage addMapel_tab;
        private System.Windows.Forms.TabPage dataMapel_tab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox mapel_txt;
        private System.Windows.Forms.TextBox kode_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox kategori_combo;
        private System.Windows.Forms.ComboBox jam_combo;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.DataGridView dataMapel_grid;
        private System.Windows.Forms.ToolStrip mapel_toolStrip;
        private System.Windows.Forms.ToolStripButton add_toolBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton refresh_toolBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.TextBox getId_txt;
        private System.Windows.Forms.TextBox search_txt;
        private System.Windows.Forms.ComboBox sort_combo;
    }
}