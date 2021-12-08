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
            userManager = UserManager.GetInstance();//bana  bir tane obje yarat dedik, o esnada null olup olmadığına bakılır
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (userManager.LoginControl(txtUserName.Text.Trim(), txtPassword.Text.Trim()))
            {
                //yeni form açarız
                FrmDashboard frm = new FrmDashboard();
                //frmLogin login = (frmLogin)Application.OpenForms["frmLogin"];
                Hide();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Kullanıcı adınız ve ya şifreniz hatalı...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lnkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmSignUp frmSignUp = new FrmSignUp();
            frmSignUp.ShowDialog();
        }

        private void lnkForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (txtUserName.Text.Trim() == "")
            {
                MessageBox.Show("Lütfen kullanıcı adınızı giriniz. ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }

            int userId = userManager.GetUserIdByUserName(txtUserName.Text.Trim());

            if (userId > 0 )
            {
                FrmForgotPassword forgot = new FrmForgotPassword();
                forgot.userId = userId;
                forgot.ShowDialog();
            }
            else
            {
                MessageBox.Show("Kullanıcı bulunamadı. ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
        }

    }
}
