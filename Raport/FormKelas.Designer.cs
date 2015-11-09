using System;

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
            this.class_schedule = new System.Windows.Forms.TabPage();
            this.delete2_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.create_tool = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.edit_tool = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.load_tool = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.schedule_grid = new System.Windows.Forms.DataGridView();
            this.cancel2_btn = new System.Windows.Forms.Button();
            this.save2_btn = new System.Windows.Forms.Button();
            this.id_lbl = new System.Windows.Forms.Label();
            this.wali_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pilihKelas_combo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pilihTahun_combo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.class_members = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.setTahun_combo = new System.Windows.Forms.ComboBox();
            this.countID_lbl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.viewKelas_combo = new System.Windows.Forms.ComboBox();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.edit3_toolBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.select_toolBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.naikKelas_toolBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.refresh2_toolBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.cancel3_toolBtn = new System.Windows.Forms.ToolStripButton();
            this.viewMember_grid = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.view_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataKelas_grid)).BeginInit();
            this.sortBy_combo.SuspendLayout();
            this.create_tab.SuspendLayout();
            this.kelas_tab.SuspendLayout();
            this.class_schedule.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schedule_grid)).BeginInit();
            this.class_members.SuspendLayout();
            this.panel2.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewMember_grid)).BeginInit();
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
            this.create_toolBtn.Size = new System.Drawing.Size(102, 25);
            this.create_toolBtn.Text = "New Class";
            this.create_toolBtn.Click += new System.EventHandler(this.create_toolBtn_Click_1);
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
            this.kelas_txt.TabIndex = 3;
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
            this.tahun_combo.Location = new System.Drawing.Point(155, 83);
            this.tahun_combo.Name = "tahun_combo";
            this.tahun_combo.Size = new System.Drawing.Size(184, 27);
            this.tahun_combo.TabIndex = 4;
            // 
            // wali_combo
            // 
            this.wali_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.wali_combo.DropDownWidth = 250;
            this.wali_combo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wali_combo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wali_combo.FormattingEnabled = true;
            this.wali_combo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.wali_combo.IntegralHeight = false;
            this.wali_combo.ItemHeight = 19;
            this.wali_combo.Location = new System.Drawing.Point(155, 116);
            this.wali_combo.Name = "wali_combo";
            this.wali_combo.Size = new System.Drawing.Size(259, 27);
            this.wali_combo.Sorted = true;
            this.wali_combo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Wali Kelas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 86);
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
            this.delete_btn.TabIndex = 9;
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
            this.update_btn.TabIndex = 8;
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
            this.cancel_btn.TabIndex = 7;
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
            this.save_btn.TabIndex = 6;
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
            this.kelas_tab.Controls.Add(this.class_schedule);
            this.kelas_tab.Controls.Add(this.class_members);
            this.kelas_tab.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kelas_tab.Location = new System.Drawing.Point(0, 156);
            this.kelas_tab.Name = "kelas_tab";
            this.kelas_tab.SelectedIndex = 0;
            this.kelas_tab.Size = new System.Drawing.Size(783, 460);
            this.kelas_tab.TabIndex = 0;
            // 
            // class_schedule
            // 
            this.class_schedule.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.class_schedule.Controls.Add(this.delete2_btn);
            this.class_schedule.Controls.Add(this.panel1);
            this.class_schedule.Controls.Add(this.cancel2_btn);
            this.class_schedule.Controls.Add(this.save2_btn);
            this.class_schedule.Controls.Add(this.id_lbl);
            this.class_schedule.Controls.Add(this.wali_txt);
            this.class_schedule.Controls.Add(this.label6);
            this.class_schedule.Controls.Add(this.pilihKelas_combo);
            this.class_schedule.Controls.Add(this.label5);
            this.class_schedule.Controls.Add(this.pilihTahun_combo);
            this.class_schedule.Controls.Add(this.label4);
            this.class_schedule.Location = new System.Drawing.Point(4, 30);
            this.class_schedule.Name = "class_schedule";
            this.class_schedule.Padding = new System.Windows.Forms.Padding(3);
            this.class_schedule.Size = new System.Drawing.Size(775, 426);
            this.class_schedule.TabIndex = 2;
            this.class_schedule.Text = "Class Schedule";
            // 
            // delete2_btn
            // 
            this.delete2_btn.BackColor = System.Drawing.Color.DarkKhaki;
            this.delete2_btn.Enabled = false;
            this.delete2_btn.FlatAppearance.BorderSize = 0;
            this.delete2_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete2_btn.Image = global::Raport.Properties.Resources.delete;
            this.delete2_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delete2_btn.Location = new System.Drawing.Point(335, 386);
            this.delete2_btn.Name = "delete2_btn";
            this.delete2_btn.Size = new System.Drawing.Size(75, 32);
            this.delete2_btn.TabIndex = 26;
            this.delete2_btn.Text = "Delete";
            this.delete2_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.delete2_btn.UseVisualStyleBackColor = false;
            this.delete2_btn.Click += new System.EventHandler(this.delete2_btn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.schedule_grid);
            this.panel1.Location = new System.Drawing.Point(23, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(745, 299);
            this.panel1.TabIndex = 25;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.create_tool,
            this.toolStripSeparator2,
            this.edit_tool,
            this.toolStripSeparator4,
            this.load_tool,
            this.toolStripSeparator5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(745, 28);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // create_tool
            // 
            this.create_tool.Image = global::Raport.Properties.Resources.edit_add;
            this.create_tool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.create_tool.Name = "create_tool";
            this.create_tool.Size = new System.Drawing.Size(75, 25);
            this.create_tool.Text = "Create";
            this.create_tool.Click += new System.EventHandler(this.create_tool_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // edit_tool
            // 
            this.edit_tool.Image = global::Raport.Properties.Resources.edit;
            this.edit_tool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.edit_tool.Name = "edit_tool";
            this.edit_tool.Size = new System.Drawing.Size(56, 25);
            this.edit_tool.Text = "Edit";
            this.edit_tool.Click += new System.EventHandler(this.edit_tool_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 28);
            // 
            // load_tool
            // 
            this.load_tool.Image = global::Raport.Properties.Resources.refresh;
            this.load_tool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.load_tool.Name = "load_tool";
            this.load_tool.Size = new System.Drawing.Size(64, 25);
            this.load_tool.Text = "Load";
            this.load_tool.Click += new System.EventHandler(this.load_tool_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 28);
            // 
            // schedule_grid
            // 
            this.schedule_grid.AllowUserToAddRows = false;
            this.schedule_grid.AllowUserToDeleteRows = false;
            this.schedule_grid.AllowUserToResizeColumns = false;
            this.schedule_grid.AllowUserToResizeRows = false;
            this.schedule_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.schedule_grid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.schedule_grid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.schedule_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.schedule_grid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.schedule_grid.Enabled = false;
            this.schedule_grid.Location = new System.Drawing.Point(0, 28);
            this.schedule_grid.Name = "schedule_grid";
            this.schedule_grid.RowHeadersWidth = 30;
            this.schedule_grid.Size = new System.Drawing.Size(745, 271);
            this.schedule_grid.TabIndex = 17;
            this.schedule_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.schedule_grid_CellClick);
            // 
            // cancel2_btn
            // 
            this.cancel2_btn.BackColor = System.Drawing.Color.DarkKhaki;
            this.cancel2_btn.Enabled = false;
            this.cancel2_btn.FlatAppearance.BorderSize = 0;
            this.cancel2_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel2_btn.Image = global::Raport.Properties.Resources.cancel;
            this.cancel2_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancel2_btn.Location = new System.Drawing.Point(416, 386);
            this.cancel2_btn.Name = "cancel2_btn";
            this.cancel2_btn.Size = new System.Drawing.Size(87, 32);
            this.cancel2_btn.TabIndex = 21;
            this.cancel2_btn.Text = "Cancel";
            this.cancel2_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cancel2_btn.UseVisualStyleBackColor = false;
            this.cancel2_btn.Click += new System.EventHandler(this.cancel2_btn_Click);
            // 
            // save2_btn
            // 
            this.save2_btn.BackColor = System.Drawing.Color.DarkKhaki;
            this.save2_btn.Enabled = false;
            this.save2_btn.FlatAppearance.BorderSize = 0;
            this.save2_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save2_btn.Image = global::Raport.Properties.Resources.save;
            this.save2_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.save2_btn.Location = new System.Drawing.Point(254, 386);
            this.save2_btn.Name = "save2_btn";
            this.save2_btn.Size = new System.Drawing.Size(75, 32);
            this.save2_btn.TabIndex = 20;
            this.save2_btn.Text = "Save";
            this.save2_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.save2_btn.UseVisualStyleBackColor = false;
            this.save2_btn.Click += new System.EventHandler(this.save2_btn_Click);
            // 
            // id_lbl
            // 
            this.id_lbl.AutoSize = true;
            this.id_lbl.Enabled = false;
            this.id_lbl.Location = new System.Drawing.Point(456, 15);
            this.id_lbl.Name = "id_lbl";
            this.id_lbl.Size = new System.Drawing.Size(19, 21);
            this.id_lbl.TabIndex = 18;
            this.id_lbl.Text = "0";
            // 
            // wali_txt
            // 
            this.wali_txt.Enabled = false;
            this.wali_txt.Location = new System.Drawing.Point(133, 46);
            this.wali_txt.Name = "wali_txt";
            this.wali_txt.ReadOnly = true;
            this.wali_txt.Size = new System.Drawing.Size(317, 29);
            this.wali_txt.TabIndex = 6;
            this.wali_txt.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Wali Kelas";
            // 
            // pilihKelas_combo
            // 
            this.pilihKelas_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pilihKelas_combo.Enabled = false;
            this.pilihKelas_combo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pilihKelas_combo.FormattingEnabled = true;
            this.pilihKelas_combo.IntegralHeight = false;
            this.pilihKelas_combo.Location = new System.Drawing.Point(325, 13);
            this.pilihKelas_combo.Name = "pilihKelas_combo";
            this.pilihKelas_combo.Size = new System.Drawing.Size(125, 27);
            this.pilihKelas_combo.TabIndex = 3;
            this.pilihKelas_combo.SelectedIndexChanged += new System.EventHandler(this.pilihKelas_combo_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(268, 15);
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
            this.pilihTahun_combo.Location = new System.Drawing.Point(133, 13);
            this.pilihTahun_combo.Name = "pilihTahun_combo";
            this.pilihTahun_combo.Size = new System.Drawing.Size(127, 27);
            this.pilihTahun_combo.TabIndex = 1;
            this.pilihTahun_combo.SelectedIndexChanged += new System.EventHandler(this.pilihTahun_combo_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tahun Ajaran";
            // 
            // class_members
            // 
            this.class_members.BackColor = System.Drawing.Color.Teal;
            this.class_members.Controls.Add(this.panel2);
            this.class_members.Controls.Add(this.toolStrip3);
            this.class_members.Controls.Add(this.viewMember_grid);
            this.class_members.Location = new System.Drawing.Point(4, 30);
            this.class_members.Name = "class_members";
            this.class_members.Padding = new System.Windows.Forms.Padding(3);
            this.class_members.Size = new System.Drawing.Size(775, 426);
            this.class_members.TabIndex = 3;
            this.class_members.Text = "Class Members";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.setTahun_combo);
            this.panel2.Controls.Add(this.countID_lbl);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.viewKelas_combo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(769, 31);
            this.panel2.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(172, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 21);
            this.label8.TabIndex = 1;
            this.label8.Text = "Tahun Ajaran";
            // 
            // setTahun_combo
            // 
            this.setTahun_combo.BackColor = System.Drawing.SystemColors.Control;
            this.setTahun_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.setTahun_combo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setTahun_combo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setTahun_combo.FormattingEnabled = true;
            this.setTahun_combo.IntegralHeight = false;
            this.setTahun_combo.Location = new System.Drawing.Point(286, 4);
            this.setTahun_combo.Name = "setTahun_combo";
            this.setTahun_combo.Size = new System.Drawing.Size(107, 27);
            this.setTahun_combo.TabIndex = 3;
            this.setTahun_combo.SelectedIndexChanged += new System.EventHandler(this.setTahun_combo_SelectedIndexChanged);
            // 
            // countID_lbl
            // 
            this.countID_lbl.AutoSize = true;
            this.countID_lbl.Location = new System.Drawing.Point(592, 4);
            this.countID_lbl.Name = "countID_lbl";
            this.countID_lbl.Size = new System.Drawing.Size(19, 21);
            this.countID_lbl.TabIndex = 6;
            this.countID_lbl.Text = "0";
            this.countID_lbl.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(408, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 21);
            this.label9.TabIndex = 4;
            this.label9.Text = "Kelas";
            // 
            // viewKelas_combo
            // 
            this.viewKelas_combo.BackColor = System.Drawing.SystemColors.Control;
            this.viewKelas_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.viewKelas_combo.Enabled = false;
            this.viewKelas_combo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewKelas_combo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewKelas_combo.FormattingEnabled = true;
            this.viewKelas_combo.IntegralHeight = false;
            this.viewKelas_combo.Location = new System.Drawing.Point(465, 4);
            this.viewKelas_combo.Name = "viewKelas_combo";
            this.viewKelas_combo.Size = new System.Drawing.Size(121, 27);
            this.viewKelas_combo.TabIndex = 2;
            this.viewKelas_combo.SelectedIndexChanged += new System.EventHandler(this.viewKelas_combo_SelectedIndexChanged);
            // 
            // toolStrip3
            // 
            this.toolStrip3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.toolStrip3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.edit3_toolBtn,
            this.toolStripSeparator6,
            this.select_toolBtn,
            this.toolStripSeparator7,
            this.naikKelas_toolBtn,
            this.toolStripSeparator8,
            this.refresh2_toolBtn,
            this.toolStripSeparator9,
            this.cancel3_toolBtn});
            this.toolStrip3.Location = new System.Drawing.Point(3, 3);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(769, 28);
            this.toolStrip3.TabIndex = 7;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // edit3_toolBtn
            // 
            this.edit3_toolBtn.Enabled = false;
            this.edit3_toolBtn.Image = global::Raport.Properties.Resources.edit;
            this.edit3_toolBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.edit3_toolBtn.Name = "edit3_toolBtn";
            this.edit3_toolBtn.Size = new System.Drawing.Size(56, 25);
            this.edit3_toolBtn.Text = "Edit";
            this.edit3_toolBtn.Click += new System.EventHandler(this.edit3_toolBtn_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 28);
            // 
            // select_toolBtn
            // 
            this.select_toolBtn.Enabled = false;
            this.select_toolBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.select_toolBtn.Name = "select_toolBtn";
            this.select_toolBtn.Size = new System.Drawing.Size(77, 25);
            this.select_toolBtn.Text = "Select All";
            this.select_toolBtn.Click += new System.EventHandler(this.select_toolBtn_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 28);
            // 
            // naikKelas_toolBtn
            // 
            this.naikKelas_toolBtn.Enabled = false;
            this.naikKelas_toolBtn.Image = global::Raport.Properties.Resources.edit_add;
            this.naikKelas_toolBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.naikKelas_toolBtn.Name = "naikKelas_toolBtn";
            this.naikKelas_toolBtn.Size = new System.Drawing.Size(102, 25);
            this.naikKelas_toolBtn.Text = "Naik Kelas";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 28);
            // 
            // refresh2_toolBtn
            // 
            this.refresh2_toolBtn.Enabled = false;
            this.refresh2_toolBtn.Image = global::Raport.Properties.Resources.refresh;
            this.refresh2_toolBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refresh2_toolBtn.Name = "refresh2_toolBtn";
            this.refresh2_toolBtn.Size = new System.Drawing.Size(83, 25);
            this.refresh2_toolBtn.Text = "Refresh";
            this.refresh2_toolBtn.Click += new System.EventHandler(this.refresh2_toolBtn_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 28);
            // 
            // cancel3_toolBtn
            // 
            this.cancel3_toolBtn.Enabled = false;
            this.cancel3_toolBtn.Image = global::Raport.Properties.Resources.cancel;
            this.cancel3_toolBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cancel3_toolBtn.Name = "cancel3_toolBtn";
            this.cancel3_toolBtn.Size = new System.Drawing.Size(76, 25);
            this.cancel3_toolBtn.Text = "Cancel";
            this.cancel3_toolBtn.Click += new System.EventHandler(this.cancel3_toolBtn_Click);
            // 
            // viewMember_grid
            // 
            this.viewMember_grid.AllowUserToAddRows = false;
            this.viewMember_grid.AllowUserToDeleteRows = false;
            this.viewMember_grid.AllowUserToResizeColumns = false;
            this.viewMember_grid.AllowUserToResizeRows = false;
            this.viewMember_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.viewMember_grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.viewMember_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewMember_grid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.viewMember_grid.Location = new System.Drawing.Point(3, 68);
            this.viewMember_grid.Name = "viewMember_grid";
            this.viewMember_grid.Size = new System.Drawing.Size(769, 355);
            this.viewMember_grid.TabIndex = 5;
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
            this.class_schedule.ResumeLayout(false);
            this.class_schedule.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schedule_grid)).EndInit();
            this.class_members.ResumeLayout(false);
            this.class_members.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewMember_grid)).EndInit();
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
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton refresh_toolBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ComboBox sort_combo;
        private System.Windows.Forms.TabPage class_schedule;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox pilihTahun_combo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox pilihKelas_combo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox wali_txt;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox search_txt;
        private System.Windows.Forms.DataGridView schedule_grid;
        private System.Windows.Forms.Label id_lbl;
        private System.Windows.Forms.Button save2_btn;
        private System.Windows.Forms.Button cancel2_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton create_tool;
        private System.Windows.Forms.ToolStripButton edit_tool;
        private System.Windows.Forms.ToolStripButton load_tool;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton create_toolBtn;
        private System.Windows.Forms.Button delete2_btn;
        private System.Windows.Forms.TabPage class_members;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox viewKelas_combo;
        private System.Windows.Forms.ComboBox setTahun_combo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView viewMember_grid;
        private System.Windows.Forms.Label countID_lbl;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton edit3_toolBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton select_toolBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripButton naikKelas_toolBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton cancel3_toolBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripButton refresh2_toolBtn;
    }
}