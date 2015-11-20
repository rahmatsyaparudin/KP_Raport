namespace Raport
{
    partial class FormUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUser));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataUser_grid = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.refresh_toolBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.view_toolBtn = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.user_lbl = new System.Windows.Forms.Label();
            this.aksi_lbl = new System.Windows.Forms.Label();
            this.level_lbl = new System.Windows.Forms.Label();
            this.delete_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.retypePass_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pass_txt = new System.Windows.Forms.TextBox();
            this.user_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.guru_combo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.admin_radio = new System.Windows.Forms.RadioButton();
            this.user_radio = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataUser_grid)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(839, 422);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataUser_grid);
            this.groupBox2.Controls.Add(this.toolStrip1);
            this.groupBox2.Location = new System.Drawing.Point(386, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(441, 284);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data User";
            // 
            // dataUser_grid
            // 
            this.dataUser_grid.AllowUserToAddRows = false;
            this.dataUser_grid.AllowUserToDeleteRows = false;
            this.dataUser_grid.AllowUserToResizeColumns = false;
            this.dataUser_grid.AllowUserToResizeRows = false;
            this.dataUser_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataUser_grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataUser_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataUser_grid.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataUser_grid.Location = new System.Drawing.Point(3, 50);
            this.dataUser_grid.Name = "dataUser_grid";
            this.dataUser_grid.ReadOnly = true;
            this.dataUser_grid.Size = new System.Drawing.Size(435, 228);
            this.dataUser_grid.TabIndex = 1;
            this.dataUser_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataUser_grid_CellClick);
            this.dataUser_grid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataUser_grid_CellDoubleClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refresh_toolBtn,
            this.toolStripSeparator1,
            this.view_toolBtn});
            this.toolStrip1.Location = new System.Drawing.Point(3, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(435, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // refresh_toolBtn
            // 
            this.refresh_toolBtn.Image = global::Raport.Properties.Resources.refresh;
            this.refresh_toolBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refresh_toolBtn.Name = "refresh_toolBtn";
            this.refresh_toolBtn.Size = new System.Drawing.Size(66, 22);
            this.refresh_toolBtn.Text = "Refresh";
            this.refresh_toolBtn.Click += new System.EventHandler(this.refresh_toolBtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // view_toolBtn
            // 
            this.view_toolBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.view_toolBtn.Image = ((System.Drawing.Image)(resources.GetObject("view_toolBtn.Image")));
            this.view_toolBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.view_toolBtn.Name = "view_toolBtn";
            this.view_toolBtn.Size = new System.Drawing.Size(89, 22);
            this.view_toolBtn.Text = "View Password";
            this.view_toolBtn.Click += new System.EventHandler(this.view_toolBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.user_lbl);
            this.groupBox1.Controls.Add(this.aksi_lbl);
            this.groupBox1.Controls.Add(this.level_lbl);
            this.groupBox1.Controls.Add(this.delete_btn);
            this.groupBox1.Controls.Add(this.edit_btn);
            this.groupBox1.Controls.Add(this.cancel_btn);
            this.groupBox1.Controls.Add(this.save_btn);
            this.groupBox1.Controls.Add(this.retypePass_txt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.pass_txt);
            this.groupBox1.Controls.Add(this.user_txt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.guru_combo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.admin_radio);
            this.groupBox1.Controls.Add(this.user_radio);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 284);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create New User";
            // 
            // user_lbl
            // 
            this.user_lbl.AutoSize = true;
            this.user_lbl.Location = new System.Drawing.Point(267, 250);
            this.user_lbl.Name = "user_lbl";
            this.user_lbl.Size = new System.Drawing.Size(36, 21);
            this.user_lbl.TabIndex = 18;
            this.user_lbl.Text = "null";
            this.user_lbl.Visible = false;
            // 
            // aksi_lbl
            // 
            this.aksi_lbl.AutoSize = true;
            this.aksi_lbl.Location = new System.Drawing.Point(267, 212);
            this.aksi_lbl.Name = "aksi_lbl";
            this.aksi_lbl.Size = new System.Drawing.Size(43, 21);
            this.aksi_lbl.TabIndex = 17;
            this.aksi_lbl.Text = "save";
            this.aksi_lbl.Visible = false;
            // 
            // level_lbl
            // 
            this.level_lbl.AutoSize = true;
            this.level_lbl.Location = new System.Drawing.Point(328, 25);
            this.level_lbl.Name = "level_lbl";
            this.level_lbl.Size = new System.Drawing.Size(28, 21);
            this.level_lbl.TabIndex = 16;
            this.level_lbl.Text = "10";
            this.level_lbl.Visible = false;
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.DarkBlue;
            this.delete_btn.Enabled = false;
            this.delete_btn.FlatAppearance.BorderSize = 0;
            this.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_btn.Image = global::Raport.Properties.Resources.delete;
            this.delete_btn.Location = new System.Drawing.Point(176, 244);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(85, 32);
            this.delete_btn.TabIndex = 15;
            this.delete_btn.Text = "Delete";
            this.delete_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.BackColor = System.Drawing.Color.DarkBlue;
            this.edit_btn.Enabled = false;
            this.edit_btn.FlatAppearance.BorderSize = 0;
            this.edit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_btn.Image = global::Raport.Properties.Resources.edit_add;
            this.edit_btn.Location = new System.Drawing.Point(95, 244);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(75, 32);
            this.edit_btn.TabIndex = 14;
            this.edit_btn.Text = "Edit";
            this.edit_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.edit_btn.UseVisualStyleBackColor = false;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.Color.DarkBlue;
            this.cancel_btn.FlatAppearance.BorderSize = 0;
            this.cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_btn.Image = global::Raport.Properties.Resources.cancel;
            this.cancel_btn.Location = new System.Drawing.Point(176, 206);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(85, 32);
            this.cancel_btn.TabIndex = 13;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cancel_btn.UseVisualStyleBackColor = false;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.Color.DarkBlue;
            this.save_btn.FlatAppearance.BorderSize = 0;
            this.save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_btn.Image = global::Raport.Properties.Resources.save;
            this.save_btn.Location = new System.Drawing.Point(95, 206);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(75, 32);
            this.save_btn.TabIndex = 6;
            this.save_btn.Text = "Save";
            this.save_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // retypePass_txt
            // 
            this.retypePass_txt.Location = new System.Drawing.Point(155, 161);
            this.retypePass_txt.Name = "retypePass_txt";
            this.retypePass_txt.PasswordChar = '*';
            this.retypePass_txt.Size = new System.Drawing.Size(201, 29);
            this.retypePass_txt.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Retype Password";
            // 
            // pass_txt
            // 
            this.pass_txt.Location = new System.Drawing.Point(155, 124);
            this.pass_txt.Name = "pass_txt";
            this.pass_txt.PasswordChar = '*';
            this.pass_txt.Size = new System.Drawing.Size(201, 29);
            this.pass_txt.TabIndex = 10;
            // 
            // user_txt
            // 
            this.user_txt.Location = new System.Drawing.Point(155, 89);
            this.user_txt.Name = "user_txt";
            this.user_txt.Size = new System.Drawing.Size(201, 29);
            this.user_txt.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // guru_combo
            // 
            this.guru_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guru_combo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guru_combo.FormattingEnabled = true;
            this.guru_combo.IntegralHeight = false;
            this.guru_combo.Location = new System.Drawing.Point(99, 54);
            this.guru_combo.Name = "guru_combo";
            this.guru_combo.Size = new System.Drawing.Size(257, 29);
            this.guru_combo.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username";
            // 
            // admin_radio
            // 
            this.admin_radio.AutoSize = true;
            this.admin_radio.Location = new System.Drawing.Point(168, 23);
            this.admin_radio.Name = "admin_radio";
            this.admin_radio.Size = new System.Drawing.Size(130, 25);
            this.admin_radio.TabIndex = 7;
            this.admin_radio.TabStop = true;
            this.admin_radio.Text = "Administrator";
            this.admin_radio.UseVisualStyleBackColor = true;
            // 
            // user_radio
            // 
            this.user_radio.AutoSize = true;
            this.user_radio.Location = new System.Drawing.Point(99, 23);
            this.user_radio.Name = "user_radio";
            this.user_radio.Size = new System.Drawing.Size(63, 25);
            this.user_radio.TabIndex = 6;
            this.user_radio.TabStop = true;
            this.user_radio.Text = "User";
            this.user_radio.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Pilih Level";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Pilih Guru";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(325, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tambah Data User";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Raport.Properties.Resources.guru;
            this.pictureBox1.Location = new System.Drawing.Point(386, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(839, 422);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FormUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tambah User";
            this.Load += new System.EventHandler(this.FormUser_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataUser_grid)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton user_radio;
        private System.Windows.Forms.RadioButton admin_radio;
        private System.Windows.Forms.ComboBox guru_combo;
        private System.Windows.Forms.TextBox user_txt;
        private System.Windows.Forms.TextBox pass_txt;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox retypePass_txt;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridView dataUser_grid;
        private System.Windows.Forms.Label level_lbl;
        private System.Windows.Forms.ToolStripButton refresh_toolBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton view_toolBtn;
        private System.Windows.Forms.Label aksi_lbl;
        private System.Windows.Forms.Label user_lbl;
    }
}