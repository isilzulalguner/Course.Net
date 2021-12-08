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
    public partial class FrmSignUp : Form
    {
        UserManager userManager;

        public FrmSignUp()
        {
            InitializeComponent();
            userManager = UserManager.GetInstance();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text.Trim() != txtRepassword.Text.Trim()) // trim boşlukları kırp
            {
                MessageBox.Show("Şifreler birbiri ile uyumlu değil.");
                return;
            }

            User user = new User(txtUserName.Text, txtPassword.Text, txtQuestion.Text, txtAnswer.Text);

            MessageBox.Show(userManager.AddUser(user));
            string userName = txtUserName.Text;
            var frmLogin = (frmLogin)Application.OpenForms["frmLogin"]; // collection alır, açık olan frmLogini bulur  - yeni bir tane üretmek yerine
            frmLogin.txtUserName.Text = userName; //txtUsername txtboxının modifierını public yaptık ki ulaşabilelim
            frmLogin.txtUserName.Enabled = false;
            Close(); //this.Close();


        }

        
    }
}
