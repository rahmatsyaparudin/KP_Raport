namespace Raport
{
    partial class FormLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.user_txt = new System.Windows.Forms.TextBox();
            this.pass_txt = new System.Windows.Forms.TextBox();
            this.info_panel = new System.Windows.Forms.Panel();
            this.info_lbl = new System.Windows.Forms.Label();
            this.info_img = new System.Windows.Forms.PictureBox();
            this.info_timer = new System.Windows.Forms.Timer(this.components);
            this.exit_btn = new System.Windows.Forms.Button();
            this.reset_btn = new System.Windows.Forms.Button();
            this.login_btn = new System.Windows.Forms.Button();
            this.logo_picbox = new System.Windows.Forms.PictureBox();
            this.info_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.info_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_picbox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login Admin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(124, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "SMAN 1 Jampang Kulon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(196, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(196, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // user_txt
            // 
            this.user_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_txt.Location = new System.Drawing.Point(200, 155);
            this.user_txt.MaxLength = 15;
            this.user_txt.Name = "user_txt";
            this.user_txt.Size = new System.Drawing.Size(223, 26);
            this.user_txt.TabIndex = 5;
            this.user_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.user_txt_KeyPress);
            // 
            // pass_txt
            // 
            this.pass_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_txt.Location = new System.Drawing.Point(200, 214);
            this.pass_txt.MaxLength = 25;
            this.pass_txt.Name = "pass_txt";
            this.pass_txt.PasswordChar = '*';
            this.pass_txt.Size = new System.Drawing.Size(223, 26);
            this.pass_txt.TabIndex = 6;
            this.pass_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pass_txt_KeyPress);
            // 
            // info_panel
            // 
            this.info_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.info_panel.BackColor = System.Drawing.Color.MediumBlue;
            this.info_panel.Controls.Add(this.info_lbl);
            this.info_panel.Controls.Add(this.info_img);
            this.info_panel.Location = new System.Drawing.Point(0, 0);
            this.info_panel.Name = "info_panel";
            this.info_panel.Size = new System.Drawing.Size(512, 49);
            this.info_panel.TabIndex = 10;
            // 
            // info_lbl
            // 
            this.info_lbl.AutoSize = true;
            this.info_lbl.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info_lbl.Location = new System.Drawing.Point(59, 19);
            this.info_lbl.Name = "info_lbl";
            this.info_lbl.Size = new System.Drawing.Size(93, 28);
            this.info_lbl.TabIndex = 12;
            this.info_lbl.Text = "Info Login";
            this.info_lbl.Visible = false;
            // 
            // info_img
            // 
            this.info_img.Image = global::Raport.Properties.Resources.lockKey;
            this.info_img.Location = new System.Drawing.Point(12, 3);
            this.info_img.Name = "info_img";
            this.info_img.Size = new System.Drawing.Size(44, 44);
            this.info_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.info_img.TabIndex = 11;
            this.info_img.TabStop = false;
            // 
            // info_timer
            // 
            this.info_timer.Interval = 2000;
            this.info_timer.Tick += new System.EventHandler(this.info_timer_Tick);
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.exit_btn.FlatAppearance.BorderSize = 0;
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.exit_btn.Image = global::Raport.Properties.Resources.leave;
            this.exit_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exit_btn.Location = new System.Drawing.Point(359, 258);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.exit_btn.Size = new System.Drawing.Size(64, 28);
            this.exit_btn.TabIndex = 9;
            this.exit_btn.Text = "Exit";
            this.exit_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exit_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // reset_btn
            // 
            this.reset_btn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.reset_btn.FlatAppearance.BorderSize = 0;
            this.reset_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reset_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.reset_btn.Image = global::Raport.Properties.Resources.cancel;
            this.reset_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reset_btn.Location = new System.Drawing.Point(280, 258);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.reset_btn.Size = new System.Drawing.Size(73, 28);
            this.reset_btn.TabIndex = 8;
            this.reset_btn.Text = "Reset";
            this.reset_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reset_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.reset_btn.UseVisualStyleBackColor = false;
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.login_btn.FlatAppearance.BorderSize = 0;
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.login_btn.Image = global::Raport.Properties.Resources._lock;
            this.login_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.login_btn.Location = new System.Drawing.Point(200, 258);
            this.login_btn.Name = "login_btn";
            this.login_btn.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.login_btn.Size = new System.Drawing.Size(74, 28);
            this.login_btn.TabIndex = 7;
            this.login_btn.Text = "Login";
            this.login_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.login_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            this.login_btn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.login_btn_KeyPress);
            // 
            // logo_picbox
            // 
            this.logo_picbox.Image = global::Raport.Properties.Resources._133x133;
            this.logo_picbox.Location = new System.Drawing.Point(64, 141);
            this.logo_picbox.Name = "logo_picbox";
            this.logo_picbox.Size = new System.Drawing.Size(126, 127);
            this.logo_picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo_picbox.TabIndex = 4;
            this.logo_picbox.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(512, 305);
            this.ControlBox = false;
            this.Controls.Add(this.info_panel);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.pass_txt);
            this.Controls.Add(this.user_txt);
            this.Controls.Add(this.logo_picbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Admin";
            this.info_panel.ResumeLayout(false);
            this.info_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.info_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_picbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox logo_picbox;
        private System.Windows.Forms.TextBox user_txt;
        private System.Windows.Forms.TextBox pass_txt;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Button reset_btn;
        private System.Windows.Forms.Panel info_panel;
        private System.Windows.Forms.PictureBox info_img;
        private System.Windows.Forms.Label info_lbl;
        private System.Windows.Forms.Timer info_timer;
        private System.Windows.Forms.Button login_btn;
    }
}

