namespace Raport
{
    partial class FormAddMapel
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
            this.schedule_grid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sumMapel_lbl = new System.Windows.Forms.Label();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.create_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.schedule_grid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // schedule_grid
            // 
            this.schedule_grid.AllowUserToAddRows = false;
            this.schedule_grid.AllowUserToDeleteRows = false;
            this.schedule_grid.AllowUserToResizeColumns = false;
            this.schedule_grid.AllowUserToResizeRows = false;
            this.schedule_grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.schedule_grid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.schedule_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.schedule_grid.Dock = System.Windows.Forms.DockStyle.Top;
            this.schedule_grid.Location = new System.Drawing.Point(0, 0);
            this.schedule_grid.Name = "schedule_grid";
            this.schedule_grid.Size = new System.Drawing.Size(585, 269);
            this.schedule_grid.TabIndex = 0;
            this.schedule_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.schedule_grid_CellClick);
            this.schedule_grid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.schedule_grid_CellEndEdit);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.sumMapel_lbl);
            this.panel1.Controls.Add(this.cancel_btn);
            this.panel1.Controls.Add(this.create_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 269);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(585, 69);
            this.panel1.TabIndex = 1;
            // 
            // sumMapel_lbl
            // 
            this.sumMapel_lbl.AutoSize = true;
            this.sumMapel_lbl.Location = new System.Drawing.Point(445, 33);
            this.sumMapel_lbl.Name = "sumMapel_lbl";
            this.sumMapel_lbl.Size = new System.Drawing.Size(13, 13);
            this.sumMapel_lbl.TabIndex = 2;
            this.sumMapel_lbl.Text = "0";
            this.sumMapel_lbl.Visible = false;
            // 
            // cancel_btn
            // 
            this.cancel_btn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_btn.Image = global::Raport.Properties.Resources.cancel;
            this.cancel_btn.Location = new System.Drawing.Point(309, 22);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(89, 33);
            this.cancel_btn.TabIndex = 1;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // create_btn
            // 
            this.create_btn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create_btn.Image = global::Raport.Properties.Resources.edit_add;
            this.create_btn.Location = new System.Drawing.Point(215, 22);
            this.create_btn.Name = "create_btn";
            this.create_btn.Size = new System.Drawing.Size(88, 33);
            this.create_btn.TabIndex = 0;
            this.create_btn.Text = "Create";
            this.create_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.create_btn.UseVisualStyleBackColor = true;
            this.create_btn.Click += new System.EventHandler(this.create_btn_Click);
            // 
            // FormAddMapel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(585, 336);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.schedule_grid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.Name = "FormAddMapel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pilih Mata Pelajaran";
            this.Load += new System.EventHandler(this.FormAddMapel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schedule_grid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView schedule_grid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button create_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Label sumMapel_lbl;
    }
}