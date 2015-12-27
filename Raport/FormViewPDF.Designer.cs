namespace Raport
{
    partial class FormViewPDF
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
            this.kelas_combo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveAs_btn = new System.Windows.Forms.Button();
            this.print_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.semester_combo = new System.Windows.Forms.ComboBox();
            this.fbDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // kelas_combo
            // 
            this.kelas_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kelas_combo.FormattingEnabled = true;
            this.kelas_combo.Location = new System.Drawing.Point(122, 17);
            this.kelas_combo.Name = "kelas_combo";
            this.kelas_combo.Size = new System.Drawing.Size(170, 29);
            this.kelas_combo.TabIndex = 0;
            this.kelas_combo.SelectedIndexChanged += new System.EventHandler(this.kelas_combo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kelas";
            // 
            // saveAs_btn
            // 
            this.saveAs_btn.Location = new System.Drawing.Point(32, 91);
            this.saveAs_btn.Name = "saveAs_btn";
            this.saveAs_btn.Size = new System.Drawing.Size(139, 31);
            this.saveAs_btn.TabIndex = 2;
            this.saveAs_btn.Text = "Save as PDF";
            this.saveAs_btn.UseVisualStyleBackColor = true;
            this.saveAs_btn.Click += new System.EventHandler(this.saveAs_btn_Click);
            // 
            // print_btn
            // 
            this.print_btn.Location = new System.Drawing.Point(177, 91);
            this.print_btn.Name = "print_btn";
            this.print_btn.Size = new System.Drawing.Size(115, 31);
            this.print_btn.TabIndex = 3;
            this.print_btn.Text = "Print";
            this.print_btn.UseVisualStyleBackColor = true;
            this.print_btn.Click += new System.EventHandler(this.print_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Semester";
            // 
            // semester_combo
            // 
            this.semester_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.semester_combo.FormattingEnabled = true;
            this.semester_combo.Location = new System.Drawing.Point(122, 52);
            this.semester_combo.Name = "semester_combo";
            this.semester_combo.Size = new System.Drawing.Size(170, 29);
            this.semester_combo.TabIndex = 5;
            this.semester_combo.SelectedIndexChanged += new System.EventHandler(this.semester_combo_SelectedIndexChanged);
            // 
            // FormViewPDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 152);
            this.Controls.Add(this.semester_combo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.print_btn);
            this.Controls.Add(this.saveAs_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kelas_combo);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormViewPDF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pilih Kelas";
            this.Load += new System.EventHandler(this.FormViewPDF_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox kelas_combo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveAs_btn;
        private System.Windows.Forms.Button print_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox semester_combo;
        private System.Windows.Forms.FolderBrowserDialog fbDialog;
    }
}