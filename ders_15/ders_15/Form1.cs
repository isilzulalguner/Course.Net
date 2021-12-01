using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (!RBA.Checked && !RBB.Checked && !RBC.Checked && RBD.Checked)
            {
                //checkboxta birden çok seçim yapabilirsiniz, radiobutton'da tek
                MessageBox.Show("Bir seçenek seçiniz.");
                return;
            }

            if (RBA.Checked)
            {
                //a seçili ise
                MessageBox.Show("A şıkkı seçildi.");
            }
            else if (RBB.Checked)
            {
                //b seçili ise
            }
            else if (RBC.Checked)
            {
                //c seçili ise
            }
            else if (RBD.Checked)
            {
                //d seçili ise
            }


        }

        private void RBA_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("A şıkkı seçildi.");
            //şıkkı seçer seçmez bu message ı gösterir.
        }
    }
}
