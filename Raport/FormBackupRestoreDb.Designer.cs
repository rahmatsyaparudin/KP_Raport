namespace Raport
{
    partial class FormBackupRestoreDb
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
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.server_txt = new System.Windows.Forms.TextBox();
            this.userID_txt = new System.Windows.Forms.TextBox();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.connect_btn = new System.Windows.Forms.Button();
            this.disconnect_btn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.database_combo = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.location_txt = new System.Windows.Forms.TextBox();
            this.browse_btn = new System.Windows.Forms.Button();
            this.backup_btn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.restore_btn = new System.Windows.Forms.Button();
            this.browse2_btn = new System.Windows.Forms.Button();
            this.path_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "User ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.disconnect_btn);
            this.groupBox1.Controls.Add(this.connect_btn);
            this.groupBox1.Controls.Add(this.password_txt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.userID_txt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.server_txt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(553, 117);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mysql Server Authentication";
            // 
            // server_txt
            // 
            this.server_txt.Location = new System.Drawing.Point(90, 35);
            this.server_txt.Name = "server_txt";
            this.server_txt.Size = new System.Drawing.Size(337, 29);
            this.server_txt.TabIndex = 0;
            // 
            // userID_txt
            // 
            this.userID_txt.Location = new System.Drawing.Point(90, 70);
            this.userID_txt.Name = "userID_txt";
            this.userID_txt.Size = new System.Drawing.Size(114, 29);
            this.userID_txt.TabIndex = 2;
            // 
            // password_txt
            // 
            this.password_txt.Location = new System.Drawing.Point(298, 70);
            this.password_txt.Name = "password_txt";
            this.password_txt.PasswordChar = '*';
            this.password_txt.Size = new System.Drawing.Size(129, 29);
            this.password_txt.TabIndex = 3;
            // 
            // connect_btn
            // 
            this.connect_btn.Location = new System.Drawing.Point(433, 33);
            this.connect_btn.Name = "connect_btn";
            this.connect_btn.Size = new System.Drawing.Size(105, 31);
            this.connect_btn.TabIndex = 4;
            this.connect_btn.Text = "Connect";
            this.connect_btn.UseVisualStyleBackColor = true;
            this.connect_btn.Click += new System.EventHandler(this.connect_btn_Click);
            // 
            // disconnect_btn
            // 
            this.disconnect_btn.Enabled = false;
            this.disconnect_btn.Location = new System.Drawing.Point(433, 70);
            this.disconnect_btn.Name = "disconnect_btn";
            this.disconnect_btn.Size = new System.Drawing.Size(105, 31);
            this.disconnect_btn.TabIndex = 5;
            this.disconnect_btn.Text = "Disconnect";
            this.disconnect_btn.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.database_combo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 135);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(553, 69);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Database Selection";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Database";
            // 
            // database_combo
            // 
            this.database_combo.Enabled = false;
            this.database_combo.FormattingEnabled = true;
            this.database_combo.Location = new System.Drawing.Point(90, 28);
            this.database_combo.Name = "database_combo";
            this.database_combo.Size = new System.Drawing.Size(270, 29);
            this.database_combo.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.backup_btn);
            this.groupBox3.Controls.Add(this.browse_btn);
            this.groupBox3.Controls.Add(this.location_txt);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(12, 210);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(553, 77);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Database Backup";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Location";
            // 
            // location_txt
            // 
            this.location_txt.Location = new System.Drawing.Point(90, 29);
            this.location_txt.Name = "location_txt";
            this.location_txt.Size = new System.Drawing.Size(270, 29);
            this.location_txt.TabIndex = 1;
            this.location_txt.TextChanged += new System.EventHandler(this.location_txt_TextChanged);
            // 
            // browse_btn
            // 
            this.browse_btn.Location = new System.Drawing.Point(366, 28);
            this.browse_btn.Name = "browse_btn";
            this.browse_btn.Size = new System.Drawing.Size(85, 29);
            this.browse_btn.TabIndex = 2;
            this.browse_btn.Text = "Browse";
            this.browse_btn.UseVisualStyleBackColor = true;
            this.browse_btn.Click += new System.EventHandler(this.browse_btn_Click);
            // 
            // backup_btn
            // 
            this.backup_btn.Enabled = false;
            this.backup_btn.Location = new System.Drawing.Point(457, 28);
            this.backup_btn.Name = "backup_btn";
            this.backup_btn.Size = new System.Drawing.Size(85, 29);
            this.backup_btn.TabIndex = 3;
            this.backup_btn.Text = "Backup";
            this.backup_btn.UseVisualStyleBackColor = true;
            this.backup_btn.Click += new System.EventHandler(this.backup_btn_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.restore_btn);
            this.groupBox4.Controls.Add(this.browse2_btn);
            this.groupBox4.Controls.Add(this.path_txt);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(12, 293);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(553, 101);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Database Restore";
            // 
            // restore_btn
            // 
            this.restore_btn.Enabled = false;
            this.restore_btn.Location = new System.Drawing.Point(457, 29);
            this.restore_btn.Name = "restore_btn";
            this.restore_btn.Size = new System.Drawing.Size(85, 29);
            this.restore_btn.TabIndex = 3;
            this.restore_btn.Text = "Restore";
            this.restore_btn.UseVisualStyleBackColor = true;
            // 
            // browse2_btn
            // 
            this.browse2_btn.Location = new System.Drawing.Point(366, 29);
            this.browse2_btn.Name = "browse2_btn";
            this.browse2_btn.Size = new System.Drawing.Size(85, 29);
            this.browse2_btn.TabIndex = 2;
            this.browse2_btn.Text = "Browse";
            this.browse2_btn.UseVisualStyleBackColor = true;
            // 
            // path_txt
            // 
            this.path_txt.Location = new System.Drawing.Point(90, 29);
            this.path_txt.Name = "path_txt";
            this.path_txt.Size = new System.Drawing.Size(270, 29);
            this.path_txt.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Path";
            // 
            // FormBackupRestoreDb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 432);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FormBackupRestoreDb";
            this.Text = "FormBackupRestoreDb";
            this.Load += new System.EventHandler(this.FormBackupRestoreDb_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.TextBox userID_txt;
        private System.Windows.Forms.TextBox server_txt;
        private System.Windows.Forms.Button disconnect_btn;
        private System.Windows.Forms.Button connect_btn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox database_combo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox location_txt;
        private System.Windows.Forms.Button backup_btn;
        private System.Windows.Forms.Button browse_btn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button restore_btn;
        private System.Windows.Forms.Button browse2_btn;
        private System.Windows.Forms.TextBox path_txt;
        private System.Windows.Forms.Label label6;
    }
}