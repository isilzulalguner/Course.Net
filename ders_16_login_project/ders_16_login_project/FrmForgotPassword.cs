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
    public partial class FrmForgotPassword : Form
    {
        UserManager userManager;

        public int userId;

        public FrmForgotPassword()
        {
            InitializeComponent();
            userManager = UserManager.GetInstance();
        }

        private void FrmForgotPassword_Load(object sender, EventArgs e)
        {
            grpBox.Visible = false;
            lblQuestion.Text = userManager.GetQuestionByUserId(userId);
        }

        private void btnCheckAnswer_Click(object sender, EventArgs e)
        {
            //cevabı methoda döndür true false getirsin 
            if (txtAnswer.Text == "")
            {
                MessageBox.Show("Lütfen gizli cevabı giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (userManager.GetAnswerByUserId(userId) == txtAnswer.Text.Trim())
            {
                grpBox.Visible = true;

            }
            else
            {
                MessageBox.Show("Yanlış cevap.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRenewPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "" && txtRepassword.Text == "")
            {
                MessageBox.Show("Lütfen şifreleri yazınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtPassword.Text.Trim() != txtRepassword.Text.Trim()) // trim boşlukları kırp
            {
                MessageBox.Show("Şifreler uyumlu değil.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show(userManager.UpdatePassword(userId, txtPassword.Text));
            }

            string userName = userManager.GetUserNameByUserId(userId);
            frmLogin frm = (frmLogin)Application.OpenForms["frmLogin"];
            frm.txtUserName.Text = userName; 
            frm.txtUserName.Enabled = false;

            //ctrl + shift + f9 tüm breakpointleri kaldırır
            Close();
        }
    }
}
