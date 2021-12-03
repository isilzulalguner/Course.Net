using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders_16_login_project
{
    public partial class frmLogin : Form
    {
        UserManager userManager;

        public frmLogin()
        {
            InitializeComponent();//label textbox vs. ekler çalıştırır
            userManager = UserManager.GetInstance();//ban abir tane obje yarat dedik, o esnada null olup olmadığına bakılır
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text!= "" && txtPassword.Text!="")
            {
                //yeni form açarız
            }
            else
            {
                MessageBox.Show("Kullanıcı adınız ve ya şifreniz hatalı...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
