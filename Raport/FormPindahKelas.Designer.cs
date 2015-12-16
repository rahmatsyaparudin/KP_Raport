namespace Raport
{
    partial class FormPindahKelas
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
            this.tahun_combo = new System.Windows.Forms.ComboBox();
            this.kelas_combo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.save_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.judul_lbl = new System.Windows.Forms.Label();
            this.kode_lbl = new System.Windows.Forms.Label();
            this.edit_link = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tahun Ajaran";
            // 
            // tahun_combo
            // 
            this.tahun_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tahun_combo.Enabled = false;
            this.tahun_combo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tahun_combo.FormattingEnabled = true;
            this.tahun_combo.IntegralHeight = false;
            this.tahun_combo.Location = new System.Drawing.Point(128, 42);
            this.tahun_combo.Name = "tahun_combo";
            this.tahun_combo.Size = new System.Drawing.Size(146, 29);
            this.tahun_combo.TabIndex = 1;
            this.tahun_combo.SelectedIndexChanged += new System.EventHandler(this.tahun_combo_SelectedIndexChanged);
            // 
            // kelas_combo
            // 
            this.kelas_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kelas_combo.Enabled = false;
            this.kelas_combo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kelas_combo.FormattingEnabled = true;
            this.kelas_combo.IntegralHeight = false;
            this.kelas_combo.Location = new System.Drawing.Point(128, 77);
            this.kelas_combo.Name = "kelas_combo";
            this.kelas_combo.Size = new System.Drawing.Size(146, 29);
            this.kelas_combo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kelas";
            // 
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.save_btn.FlatAppearance.BorderSize = 0;
            this.save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_btn.Location = new System.Drawing.Point(87, 122);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(75, 31);
            this.save_btn.TabIndex = 4;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.cancel_btn.FlatAppearance.BorderSize = 0;
            this.cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_btn.Location = new System.Drawing.Point(168, 122);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(75, 31);
            this.cancel_btn.TabIndex = 5;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = false;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // judul_lbl
            // 
            this.judul_lbl.AutoSize = true;
            this.judul_lbl.Location = new System.Drawing.Point(93, 9);
            this.judul_lbl.Name = "judul_lbl";
            this.judul_lbl.Size = new System.Drawing.Size(116, 21);
            this.judul_lbl.TabIndex = 6;
            this.judul_lbl.Text = "Naik Ke Kelas";
            // 
            // kode_lbl
            // 
            this.kode_lbl.AutoSize = true;
            this.kode_lbl.Location = new System.Drawing.Point(280, 45);
            this.kode_lbl.Name = "kode_lbl";
            this.kode_lbl.Size = new System.Drawing.Size(19, 21);
            this.kode_lbl.TabIndex = 7;
            this.kode_lbl.Text = "0";
            // 
            // edit_link
            // 
            this.edit_link.AutoSize = true;
            this.edit_link.Location = new System.Drawing.Point(280, 85);
            this.edit_link.Name = "edit_link";
            this.edit_link.Size = new System.Drawing.Size(40, 21);
            this.edit_link.TabIndex = 8;
            this.edit_link.TabStop = true;
            this.edit_link.Text = "Edit";
            this.edit_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.edit_link_LinkClicked);
            // 
            // FormPindahKelas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(338, 173);
            this.Controls.Add(this.edit_link);
            this.Controls.Add(this.kode_lbl);
            this.Controls.Add(this.judul_lbl);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.kelas_combo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tahun_combo);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormPindahKelas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Naik Kelas";
            this.Load += new System.EventHandler(this.FormPindahKelas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox kelas_combo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Label kode_lbl;
        private System.Windows.Forms.LinkLabel edit_link;
        private System.Windows.Forms.ComboBox tahun_combo;
        public System.Windows.Forms.Label judul_lbl;
    }
}