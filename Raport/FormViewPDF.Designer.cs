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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormViewPDF));
            this.button1 = new System.Windows.Forms.Button();
            this.PDFReader = new AxAcroPDFLib.AxAcroPDF();
            ((System.ComponentModel.ISupportInitialize)(this.PDFReader)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(187, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PDFReader
            // 
            this.PDFReader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PDFReader.Enabled = true;
            this.PDFReader.Location = new System.Drawing.Point(12, 41);
            this.PDFReader.Name = "PDFReader";
            this.PDFReader.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("PDFReader.OcxState")));
            this.PDFReader.Size = new System.Drawing.Size(417, 192);
            this.PDFReader.TabIndex = 2;
            // 
            // FormViewPDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 261);
            this.Controls.Add(this.PDFReader);
            this.Controls.Add(this.button1);
            this.Name = "FormViewPDF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormViewPDF";
            ((System.ComponentModel.ISupportInitialize)(this.PDFReader)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private AxAcroPDFLib.AxAcroPDF PDFReader;
    }
}