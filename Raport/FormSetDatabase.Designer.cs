namespace Raport
{
    partial class FormSetDatabase
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
            this.label4 = new System.Windows.Forms.Label();
            this.host_txt = new System.Windows.Forms.TextBox();
            this.user_txt = new System.Windows.Forms.TextBox();
            this.pass_txt = new System.Windows.Forms.TextBox();
            this.dbms_txt = new System.Windows.Forms.TextBox();
            this.save_btn = new System.Windows.Forms.Button();
            this.test_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.port_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP Address/Server Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "User ID (Database)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password (User ID)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 105);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Database Name";
            // 
            // host_txt
            // 
            this.host_txt.Location = new System.Drawing.Point(181, 6);
            this.host_txt.Name = "host_txt";
            this.host_txt.Size = new System.Drawing.Size(173, 26);
            this.host_txt.TabIndex = 4;
            this.host_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.host_txt_KeyPress);
            // 
            // user_txt
            // 
            this.user_txt.Location = new System.Drawing.Point(181, 38);
            this.user_txt.Name = "user_txt";
            this.user_txt.Size = new System.Drawing.Size(173, 26);
            this.user_txt.TabIndex = 5;
            // 
            // pass_txt
            // 
            this.pass_txt.Location = new System.Drawing.Point(181, 70);
            this.pass_txt.Name = "pass_txt";
            this.pass_txt.Size = new System.Drawing.Size(173, 26);
            this.pass_txt.TabIndex = 6;
            this.pass_txt.UseSystemPasswordChar = true;
            // 
            // dbms_txt
            // 
            this.dbms_txt.Location = new System.Drawing.Point(181, 102);
            this.dbms_txt.Name = "dbms_txt";
            this.dbms_txt.Size = new System.Drawing.Size(173, 26);
            this.dbms_txt.TabIndex = 7;
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(181, 177);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(75, 27);
            this.save_btn.TabIndex = 11;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // test_btn
            // 
            this.test_btn.Location = new System.Drawing.Point(12, 177);
            this.test_btn.Name = "test_btn";
            this.test_btn.Size = new System.Drawing.Size(121, 27);
            this.test_btn.TabIndex = 10;
            this.test_btn.Text = "Test Connection";
            this.test_btn.UseVisualStyleBackColor = true;
            this.test_btn.Click += new System.EventHandler(this.test_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(262, 177);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(75, 27);
            this.cancel_btn.TabIndex = 12;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // port_txt
            // 
            this.port_txt.Location = new System.Drawing.Point(181, 134);
            this.port_txt.Name = "port_txt";
            this.port_txt.Size = new System.Drawing.Size(69, 26);
            this.port_txt.TabIndex = 9;
            this.port_txt.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.port_txt_MouseDoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 137);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Port Server";
            // 
            // FormSetDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 215);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.port_txt);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.test_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.dbms_txt);
            this.Controls.Add(this.pass_txt);
            this.Controls.Add(this.user_txt);
            this.Controls.Add(this.host_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormSetDatabase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setting Server";
            this.Load += new System.EventHandler(this.FormSetDatabase_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox host_txt;
        private System.Windows.Forms.TextBox user_txt;
        private System.Windows.Forms.TextBox pass_txt;
        private System.Windows.Forms.TextBox dbms_txt;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button test_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.TextBox port_txt;
        private System.Windows.Forms.Label label5;
    }
}