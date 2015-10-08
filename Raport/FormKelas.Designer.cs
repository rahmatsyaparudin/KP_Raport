namespace Raport
{
    partial class FormKelas
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
            this.view_tab = new System.Windows.Forms.TabPage();
            this.search_txt = new System.Windows.Forms.TextBox();
            this.sort_combo = new System.Windows.Forms.ComboBox();
            this.dataKelas_grid = new System.Windows.Forms.DataGridView();
            this.sortBy_combo = new System.Windows.Forms.ToolStrip();
            this.create_toolBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.refresh_toolBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.create_tab = new System.Windows.Forms.TabPage();
            this.kelas_txt = new System.Windows.Forms.TextBox();
            this.id_txt = new System.Windows.Forms.TextBox();
            this.tahun_combo = new System.Windows.Forms.ComboBox();
            this.wali_combo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.delete_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.kelas_tab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cancel2_btn = new System.Windows.Forms.Button();
            this.create_btn = new System.Windows.Forms.Button();
            this.wali_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.kelas_tree = new System.Windows.Forms.TreeView();
            this.pilihKelas_combo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pilihTahun_combo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.view_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataKelas_grid)).BeginInit();
            this.sortBy_combo.SuspendLayout();
            this.create_tab.SuspendLayout();
            this.kelas_tab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // view_tab
            // 
            this.view_tab.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.view_tab.Controls.Add(this.search_txt);
            this.view_tab.Controls.Add(this.sort_combo);
            this.view_tab.Controls.Add(this.dataKelas_grid);
            this.view_tab.Controls.Add(this.sortBy_combo);
            this.view_tab.Location = new System.Drawing.Point(4, 30);
            this.view_tab.Name = "view_tab";
            this.view_tab.Padding = new System.Windows.Forms.Padding(3);
            this.view_tab.Size = new System.Drawing.Size(775, 426);
            this.view_tab.TabIndex = 1;
            this.view_tab.Text = "View Class";
            // 
            // search_txt
            // 
            this.search_txt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.search_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_txt.Location = new System.Drawing.Point(566, 3);
            this.search_txt.Name = "search_txt";
            this.search_txt.Size = new System.Drawing.Size(192, 26);
            this.search_txt.TabIndex = 4;
            this.search_txt.TextChanged += new System.EventHandler(this.search_txt_TextChanged);
            // 
            // sort_combo
            // 
            this.sort_combo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.sort_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sort_combo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sort_combo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sort_combo.FormattingEnabled = true;
            this.sort_combo.Location = new System.Drawing.Point(281, 5);
            this.sort_combo.Name = "sort_combo";
            this.sort_combo.Size = new System.Drawing.Size(121, 23);
            this.sort_combo.TabIndex = 3;
            this.sort_combo.SelectedIndexChanged += new System.EventHandler(this.sort_combo_SelectedIndexChanged);
            // 
            // dataKelas_grid
            // 
            this.dataKelas_grid.AllowUserToAddRows = false;
            this.dataKelas_grid.AllowUserToDeleteRows = false;
            this.dataKelas_grid.AllowUserToResizeColumns = false;
            this.dataKelas_grid.AllowUserToResizeRows = false;
            this.dataKelas_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataKelas_grid.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataKelas_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataKelas_grid.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataKelas_grid.Location = new System.Drawing.Point(19, 34);
            this.dataKelas_grid.Name = "dataKelas_grid";
            this.dataKelas_grid.ReadOnly = true;
            this.dataKelas_grid.Size = new System.Drawing.Size(739, 370);
            this.dataKelas_grid.TabIndex = 2;
            this.dataKelas_grid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataKelas_grid_CellDoubleClick);
            // 
            // sortBy_combo
            // 
            this.sortBy_combo.BackColor = System.Drawing.Color.DarkKhaki;
            this.sortBy_combo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortBy_combo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.create_toolBtn,
            this.toolStripSeparator1,
            this.refresh_toolBtn,
            this.toolStripSeparator3,
            this.toolStripLabel1});
            this.sortBy_combo.Location = new System.Drawing.Point(3, 3);
            this.sortBy_combo.Name = "sortBy_combo";
            this.sortBy_combo.Padding = new System.Windows.Forms.Padding(0);
            this.sortBy_combo.Size = new System.Drawing.Size(769, 28);
            this.sortBy_combo.TabIndex = 1;
            this.sortBy_combo.Text = "toolStrip1";
            // 
            // create_toolBtn
            // 
            this.create_toolBtn.Image = global::Raport.Properties.Resources.edit_add;
            this.create_toolBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.create_toolBtn.Name = "create_toolBtn";
            this.create_toolBtn.Size = new System.Drawing.Size(115, 25);
            this.create_toolBtn.Text = "Create Class";
            this.create_toolBtn.Click += new System.EventHandler(this.create_toolBtn_Click);
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
            this.refresh_toolBtn.Size = new System.Drawing.Size(83, 25);
            this.refresh_toolBtn.Text = "Refresh";
            this.refresh_toolBtn.Click += new System.EventHandler(this.refresh_toolBtn_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(60, 25);
            this.toolStripLabel1.Text = "Sort by";
            // 
            // create_tab
            // 
            this.create_tab.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.create_tab.Controls.Add(this.kelas_txt);
            this.create_tab.Controls.Add(this.id_txt);
            this.create_tab.Controls.Add(this.tahun_combo);
            this.create_tab.Controls.Add(this.wali_combo);
            this.create_tab.Controls.Add(this.label3);
            this.create_tab.Controls.Add(this.label2);
            this.create_tab.Controls.Add(this.label1);
            this.create_tab.Controls.Add(this.delete_btn);
            this.create_tab.Controls.Add(this.update_btn);
            this.create_tab.Controls.Add(this.cancel_btn);
            this.create_tab.Controls.Add(this.save_btn);
            this.create_tab.Location = new System.Drawing.Point(4, 30);
            this.create_tab.Name = "create_tab";
            this.create_tab.Padding = new System.Windows.Forms.Padding(3);
            this.create_tab.Size = new System.Drawing.Size(775, 426);
            this.create_tab.TabIndex = 0;
            this.create_tab.Text = "New Class";
            // 
            // kelas_txt
            // 
            this.kelas_txt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.kelas_txt.Location = new System.Drawing.Point(155, 48);
            this.kelas_txt.MaxLength = 10;
            this.kelas_txt.Name = "kelas_txt";
            this.kelas_txt.Size = new System.Drawing.Size(184, 29);
            this.kelas_txt.TabIndex = 13;
            this.kelas_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kelas_txt_KeyPress);
            // 
            // id_txt
            // 
            this.id_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.id_txt.Location = new System.Drawing.Point(345, 46);
            this.id_txt.Name = "id_txt";
            this.id_txt.Size = new System.Drawing.Size(24, 29);
            this.id_txt.TabIndex = 12;
            this.id_txt.Visible = false;
            // 
            // tahun_combo
            // 
            this.tahun_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tahun_combo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tahun_combo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tahun_combo.FormattingEnabled = true;
            this.tahun_combo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tahun_combo.IntegralHeight = false;
            this.tahun_combo.Location = new System.Drawing.Point(155, 124);
            this.tahun_combo.Name = "tahun_combo";
            this.tahun_combo.Size = new System.Drawing.Size(184, 27);
            this.tahun_combo.TabIndex = 7;
            // 
            // wali_combo
            // 
            this.wali_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.wali_combo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wali_combo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wali_combo.FormattingEnabled = true;
            this.wali_combo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.wali_combo.IntegralHeight = false;
            this.wali_combo.ItemHeight = 19;
            this.wali_combo.Location = new System.Drawing.Point(155, 86);
            this.wali_combo.Name = "wali_combo";
            this.wali_combo.Size = new System.Drawing.Size(184, 27);
            this.wali_combo.Sorted = true;
            this.wali_combo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Wali Kelas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tahun Ajaran";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Kelas";
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.DarkKhaki;
            this.delete_btn.Enabled = false;
            this.delete_btn.FlatAppearance.BorderSize = 0;
            this.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_btn.Image = global::Raport.Properties.Resources.delete;
            this.delete_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delete_btn.Location = new System.Drawing.Point(179, 210);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(93, 29);
            this.delete_btn.TabIndex = 11;
            this.delete_btn.Text = "Delete";
            this.delete_btn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.delete_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.BackColor = System.Drawing.Color.DarkKhaki;
            this.update_btn.Enabled = false;
            this.update_btn.FlatAppearance.BorderSize = 0;
            this.update_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_btn.Image = global::Raport.Properties.Resources.edit1;
            this.update_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.update_btn.Location = new System.Drawing.Point(64, 210);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(97, 29);
            this.update_btn.TabIndex = 10;
            this.update_btn.Text = "Update";
            this.update_btn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.update_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.update_btn.UseVisualStyleBackColor = false;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.Color.DarkKhaki;
            this.cancel_btn.FlatAppearance.BorderSize = 0;
            this.cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_btn.Image = global::Raport.Properties.Resources.cancel;
            this.cancel_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancel_btn.Location = new System.Drawing.Point(179, 175);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(93, 29);
            this.cancel_btn.TabIndex = 9;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cancel_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cancel_btn.UseVisualStyleBackColor = false;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.Color.DarkKhaki;
            this.save_btn.FlatAppearance.BorderSize = 0;
            this.save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_btn.Image = global::Raport.Properties.Resources.save;
            this.save_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.save_btn.Location = new System.Drawing.Point(64, 175);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(97, 29);
            this.save_btn.TabIndex = 8;
            this.save_btn.Text = "Save";
            this.save_btn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.save_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // kelas_tab
            // 
            this.kelas_tab.Controls.Add(this.view_tab);
            this.kelas_tab.Controls.Add(this.create_tab);
            this.kelas_tab.Controls.Add(this.tabPage1);
            this.kelas_tab.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kelas_tab.Location = new System.Drawing.Point(0, 156);
            this.kelas_tab.Name = "kelas_tab";
            this.kelas_tab.SelectedIndex = 0;
            this.kelas_tab.Size = new System.Drawing.Size(783, 460);
            this.kelas_tab.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.tabPage1.Controls.Add(this.cancel2_btn);
            this.tabPage1.Controls.Add(this.create_btn);
            this.tabPage1.Controls.Add(this.wali_txt);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.kelas_tree);
            this.tabPage1.Controls.Add(this.pilihKelas_combo);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.pilihTahun_combo);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(775, 426);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Create Schedule";
            // 
            // cancel2_btn
            // 
            this.cancel2_btn.Enabled = false;
            this.cancel2_btn.Image = global::Raport.Properties.Resources.cancel;
            this.cancel2_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancel2_btn.Location = new System.Drawing.Point(234, 378);
            this.cancel2_btn.Name = "cancel2_btn";
            this.cancel2_btn.Size = new System.Drawing.Size(85, 32);
            this.cancel2_btn.TabIndex = 8;
            this.cancel2_btn.Text = "Cancel";
            this.cancel2_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cancel2_btn.UseVisualStyleBackColor = true;
            this.cancel2_btn.Click += new System.EventHandler(this.cancel2_btn_Click);
            // 
            // create_btn
            // 
            this.create_btn.Enabled = false;
            this.create_btn.Image = global::Raport.Properties.Resources.edit_add;
            this.create_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.create_btn.Location = new System.Drawing.Point(133, 378);
            this.create_btn.Name = "create_btn";
            this.create_btn.Size = new System.Drawing.Size(85, 32);
            this.create_btn.TabIndex = 7;
            this.create_btn.Text = "Create";
            this.create_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.create_btn.UseVisualStyleBackColor = true;
            this.create_btn.Click += new System.EventHandler(this.create_btn_Click);
            // 
            // wali_txt
            // 
            this.wali_txt.Location = new System.Drawing.Point(133, 56);
            this.wali_txt.Name = "wali_txt";
            this.wali_txt.ReadOnly = true;
            this.wali_txt.Size = new System.Drawing.Size(317, 29);
            this.wali_txt.TabIndex = 6;
            this.wali_txt.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Wali Kelas";
            // 
            // kelas_tree
            // 
            this.kelas_tree.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.kelas_tree.CheckBoxes = true;
            this.kelas_tree.Enabled = false;
            this.kelas_tree.Location = new System.Drawing.Point(23, 104);
            this.kelas_tree.Name = "kelas_tree";
            this.kelas_tree.ShowNodeToolTips = true;
            this.kelas_tree.Size = new System.Drawing.Size(427, 268);
            this.kelas_tree.TabIndex = 4;
            this.kelas_tree.MouseMove += new System.Windows.Forms.MouseEventHandler(this.kelas_tree_MouseMove);
            // 
            // pilihKelas_combo
            // 
            this.pilihKelas_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pilihKelas_combo.Enabled = false;
            this.pilihKelas_combo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pilihKelas_combo.FormattingEnabled = true;
            this.pilihKelas_combo.IntegralHeight = false;
            this.pilihKelas_combo.Location = new System.Drawing.Point(325, 21);
            this.pilihKelas_combo.Name = "pilihKelas_combo";
            this.pilihKelas_combo.Size = new System.Drawing.Size(125, 27);
            this.pilihKelas_combo.TabIndex = 3;
            this.pilihKelas_combo.SelectedIndexChanged += new System.EventHandler(this.pilihKelas_combo_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(268, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Kelas";
            // 
            // pilihTahun_combo
            // 
            this.pilihTahun_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pilihTahun_combo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pilihTahun_combo.FormattingEnabled = true;
            this.pilihTahun_combo.IntegralHeight = false;
            this.pilihTahun_combo.Location = new System.Drawing.Point(133, 21);
            this.pilihTahun_combo.Name = "pilihTahun_combo";
            this.pilihTahun_combo.Size = new System.Drawing.Size(127, 27);
            this.pilihTahun_combo.TabIndex = 1;
            this.pilihTahun_combo.SelectedIndexChanged += new System.EventHandler(this.pilihTahun_combo_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tahun Ajaran";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Raport.Properties.Resources.kelas;
            this.pictureBox1.Location = new System.Drawing.Point(349, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(322, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 36);
            this.label7.TabIndex = 2;
            this.label7.Text = "Data Kelas";
            // 
            // FormKelas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(784, 616);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.kelas_tab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormKelas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Kelas SMANJAK 1";
            this.Load += new System.EventHandler(this.FormKelas_Load);
            this.view_tab.ResumeLayout(false);
            this.view_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataKelas_grid)).EndInit();
            this.sortBy_combo.ResumeLayout(false);
            this.sortBy_combo.PerformLayout();
            this.create_tab.ResumeLayout(false);
            this.create_tab.PerformLayout();
            this.kelas_tab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage view_tab;
        private System.Windows.Forms.TabPage create_tab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl kelas_tab;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox wali_combo;
        private System.Windows.Forms.ComboBox tahun_combo;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.TextBox id_txt;
        private System.Windows.Forms.TextBox kelas_txt;
        private System.Windows.Forms.DataGridView dataKelas_grid;
        private System.Windows.Forms.ToolStrip sortBy_combo;
        private System.Windows.Forms.ToolStripButton create_toolBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton refresh_toolBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ComboBox sort_combo;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox pilihTahun_combo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox pilihKelas_combo;
        private System.Windows.Forms.TreeView kelas_tree;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox wali_txt;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button create_btn;
        private System.Windows.Forms.Button cancel2_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox search_txt;
    }
}