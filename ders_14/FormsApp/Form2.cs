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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "zülal" && txtPassword.Text == "12345")
            {
                Form1 form = new Form1();
                form.ShowDialog();
                MessageBox.Show(dtPicker.Value + " tarihinde sisteme giriş yaptınız.");// sadece show dersen hepsi anı anda çalışır
                //show vs. show dialog farkı
                //showda açılan tüm form pencerelerine geçiş yapılabilir ancak show dialog ta diğer forma geri dönüş yapılamaz

            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı ve/veya şifre.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
