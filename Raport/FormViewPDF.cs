using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Raport
{
    public partial class FormViewPDF : Form
    {
        public FormViewPDF()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PDFReader.src = @"C:\Users\Sri Musniati\Pictures\Print\Format Penilaian Ujian Siswa.pdf";
        }
    }
}
