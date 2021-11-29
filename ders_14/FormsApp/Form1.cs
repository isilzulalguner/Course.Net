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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba Dünya");
        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtMessage.Text, "Başlık", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                MessageBox.Show("CheckBox1 şu an seçili.");
            }
            else
            {
                MessageBox.Show("CheckBox1 şu an seçili değil.");
            }
        }
    }
}
