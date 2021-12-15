using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders_18_student_project
{
    public partial class FrmDashboard : Form
    {
        public Student student;
        //design a f7 yaparsan bu sayfayı açar
        StudentManager studentManager;
        public FrmDashboard()
        {
            InitializeComponent();
            studentManager = StudentManager.GetInstance();
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            List();
        }

        void List() 
        {
            dgStudent.DataSource = null; // en güncel listeyi alabilmek için
            dgStudent.DataSource = studentManager.GetList();
            DatagridProps();
        }

        void DatagridProps()
        {
            dgStudent.Columns["Id"].Visible = false;//collection - array geri döndürüyor
            dgStudent.Columns["Name"].HeaderText = "İsim";
            dgStudent.Columns["Mail"].HeaderText = "E-Posta";
            dgStudent.Columns["Phone"].HeaderText = "Telefon No";
            dgStudent.Columns["Birthday"].HeaderText = "Doğum Tarihi";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtMail.Text) || string.IsNullOrEmpty(mskPhone.Text) || string.IsNullOrEmpty(mskBirth.Text))
            {
                return ;
            }
            Student student = new Student(studentManager.GetMaxId(), txtName.Text, txtMail.Text, mskPhone.Text, Convert.ToDateTime(mskBirth.Text));
            MessageBox.Show(studentManager.AddStudent(student));

            List();


        }

        private void yenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List();
        }

        private void detayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgStudent.CurrentRow == null)
            {
                MessageBox.Show("Lütfen işlem yapmak istediğiniz öğrenciyi seçiniz.");
                return;
            }
            int id = (int)dgStudent.CurrentRow.Cells["Id"].Value;
            string name = dgStudent.CurrentRow.Cells["Name"].Value.ToString();
            string phone = dgStudent.CurrentRow.Cells["Phone"].Value.ToString();
            string mail= dgStudent.CurrentRow.Cells["Mail"].Value.ToString();
            DateTime birthday = (DateTime) dgStudent.CurrentRow.Cells["Birthday"].Value;

            Student student = new Student(id, name, mail, phone, birthday);
            FrmUpdateDetail frm = new FrmUpdateDetail();      
            frm.student = student;
            //Hide();
            frm.ShowDialog();
            List();
        }
    }
}
