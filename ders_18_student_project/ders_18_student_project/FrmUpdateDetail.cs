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
    public partial class FrmUpdateDetail : Form
    {
        public Student student;
        
        StudentManager studentManager;

        bool start = true;

        public FrmUpdateDetail()
        {
            InitializeComponent();
            //student = new Student();
            studentManager = StudentManager.GetInstance();
        }

        private void FrmUpdateDetail_Load(object sender, EventArgs e)
        {
            StudentInfo();
            CmbStudentLoad();
            start = false;
        }
        void CmbStudentLoad() 
        {
            cbStudents.DataSource = studentManager.GetList();
            cbStudents.DisplayMember = "Name";
            cbStudents.ValueMember = "Id";
            cbStudents.SelectedValue = 0;
        }

        void StudentInfo() 
        {
            txtName.Text = student.Name;
            txtMail.Text = student.Mail;
            mskPhone.Text = student.Phone;

            string date = "";

            if (student.Birthday.ToString().Split('.')[0].Length == 1)
            {
                date += "0" + student.Birthday.ToString().Split('.')[0] + ".";
            }
            else
            {
                date += student.Birthday.ToString().Split('.')[0] + ".";
            }


            if (student.Birthday.ToString().Split('.')[1].Length == 1)
            {
                date += "0" + student.Birthday.ToString().Split('.')[1] + "." + student.Birthday.ToString().Split('.')[2];
            }
            else
            {
                date += student.Birthday.ToString().Split('.')[1] + "." + student.Birthday.ToString().Split('.')[2];
            }

            mskBirth.Text = date;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(student.Name + " öğrencisi güncellenecektir. Emin misiniz ?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Student new_student = new Student(student.Id, txtName.Text, txtMail.Text, mskPhone.Text, Convert.ToDateTime(mskBirth.Text));
                studentManager.UpdateStudent(new_student);
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(student.Name + " öğrencisi silinecektir. Emin misiniz ?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                studentManager.DeleteStudent(student.Id);
            }

        }

        private void cbStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (start)
            {
                return;
            }

            if ((int)cbStudents.SelectedValue < 1)//object int dönecek ise parantez içine int yaz
            {
                return;
            }

            int chosenId = (int)cbStudents.SelectedValue; //parantez içi int yerine convert desen de olur ama gerek yok
            student = studentManager.GetStudentById(chosenId);
            StudentInfo();
        }
    }
}
