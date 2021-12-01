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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //string[] arr = { "Ali","Veli","Murat","Cengiz"};
            //comboBox1.Items.AddRange(arr);
            //comboBox1.Items.Add("Ali");
            //comboBox1.Items.Add("Veli");
            //comboBox1.Items.Add("Murat");
            //comboBox1.Items.Add("Cengiz");

            List<User> users = new List<User>()
            {
                //new User(0, "Öğrenciler"),
                new User(1, "Ali"),
                new User(2, "Veli"),
                new User(3, "Hasan")
            };

            comboBox1.DataSource = users;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";
            comboBox1.SelectedValue = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((int)comboBox1.SelectedValue == 0)//boxing - unboxing
            {
                MessageBox.Show("Lütfen öğrenci seçiniz");
                return;
            }
            //MessageBox.Show(comboBox1.SelectedIndex.ToString());//seçilenin index no'sunu verir
            MessageBox.Show("UserID: " + comboBox1.SelectedValue + " Name: " + comboBox1.Text);
        }
    }

    //class User
    //{
    //    int _id;
    //    string _name;
    //    //ctrl + r+ e
    //    public int Id { get => _id; set => _id = value; }
    //    public string Name { get => _name; set => _name = value; }

    //    public User(int id, string name)
    //    {
    //        _id = id;
    //        _name = name;
            
    //    }
    //}
}
