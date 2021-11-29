using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsApp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.Description = "Lütfen bir klasör seçin.";
            folderBrowserDialog1.ShowNewFolderButton = true;
            DialogResult folderResult = folderBrowserDialog1.ShowDialog(); //dosyayı seçtik onu set ediyoruz

            if (folderResult == DialogResult.OK)
            {
                string folderPath = folderBrowserDialog1.SelectedPath;
                MessageBox.Show(folderPath);
            }
        }

        private void btnOpenFileDialog_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Lütfen dosya seçiniz.";
            DialogResult dialogResult = openFileDialog1.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
               // MessageBox.Show(openFileDialog1.FileName);
               // MessageBox.Show(saveFileDialog1.FileName)
                string result = saveFileDialog1.FileName;
                richTextBox1.Text = result;
            }
        }

    }
}
