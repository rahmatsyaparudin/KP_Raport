namespace Raport
{
    partial class FormExport
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.data_grid = new System.Windows.Forms.DataGridView();
            this.path_txt = new System.Windows.Forms.TextBox();
            this.sheet_txt = new System.Windows.Forms.TextBox();
            this.choose_btn = new System.Windows.Forms.Button();
            this.load_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.data_grid);
            this.panel1.Location = new System.Drawing.Point(2, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 244);
            this.panel1.TabIndex = 0;
            // 
            // data_grid
            // 
            this.data_grid.AllowUserToAddRows = false;
            this.data_grid.AllowUserToDeleteRows = false;
            this.data_grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.data_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_grid.Location = new System.Drawing.Point(0, 0);
            this.data_grid.Name = "data_grid";
            this.data_grid.Size = new System.Drawing.Size(521, 244);
            this.data_grid.TabIndex = 0;
            // 
            // path_txt
            // 
            this.path_txt.Location = new System.Drawing.Point(109, 42);
            this.path_txt.Name = "path_txt";
            this.path_txt.Size = new System.Drawing.Size(335, 20);
            this.path_txt.TabIndex = 1;
            // 
            // sheet_txt
            // 
            this.sheet_txt.Location = new System.Drawing.Point(109, 64);
            this.sheet_txt.Name = "sheet_txt";
            this.sheet_txt.Size = new System.Drawing.Size(335, 20);
            this.sheet_txt.TabIndex = 2;
            // 
            // choose_btn
            // 
            this.choose_btn.Location = new System.Drawing.Point(12, 40);
            this.choose_btn.Name = "choose_btn";
            this.choose_btn.Size = new System.Drawing.Size(91, 23);
            this.choose_btn.TabIndex = 3;
            this.choose_btn.Text = "Choose Excel";
            this.choose_btn.UseVisualStyleBackColor = true;
            this.choose_btn.Click += new System.EventHandler(this.choose_btn_Click);
            // 
            // load_btn
            // 
            this.load_btn.Location = new System.Drawing.Point(12, 64);
            this.load_btn.Name = "load_btn";
            this.load_btn.Size = new System.Drawing.Size(91, 23);
            this.load_btn.TabIndex = 4;
            this.load_btn.Text = "Load Sheet";
            this.load_btn.UseVisualStyleBackColor = true;
            this.load_btn.Click += new System.EventHandler(this.load_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(200, 361);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(116, 23);
            this.save_btn.TabIndex = 5;
            this.save_btn.Text = "Save To Database";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // FormExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 396);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.load_btn);
            this.Controls.Add(this.choose_btn);
            this.Controls.Add(this.sheet_txt);
            this.Controls.Add(this.path_txt);
            this.Controls.Add(this.panel1);
            this.Name = "FormExport";
            this.Text = "FormExport";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView data_grid;
        private System.Windows.Forms.TextBox path_txt;
        private System.Windows.Forms.TextBox sheet_txt;
        private System.Windows.Forms.Button choose_btn;
        private System.Windows.Forms.Button load_btn;
        private System.Windows.Forms.Button save_btn;
    }
}