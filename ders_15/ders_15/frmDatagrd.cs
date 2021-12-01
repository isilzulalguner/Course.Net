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
    public partial class frmDatagrd : Form
    {
        public frmDatagrd()
        {
            InitializeComponent();
        }

        private void frmDatagrd_Load(object sender, EventArgs e)
        {
            List<User> users = new List<User>()
            {
                //new User(0, "Öğrenciler"),
                new User(1, "Ali"),
                new User(2, "Veli"),
                new User(3, "Hasan")
            };

            dataGridView1.DataSource = users;//id ve nameleri ile tablo olarak yazdırır
            dataGridView1.Columns["Id"].Visible = false;//collection - array geri döndürüyor
            dataGridView1.Columns["Name"].HeaderText = "İsim";
        }

        private void gösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns["Id"].Visible = true;
        }

        private void değiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns["Id"].HeaderText = "Numara";
        }
    }

    class User
    {
        int _id;
        string _name;
        //ctrl + r+ e
        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }

        public User(int id, string name)
        {
            _id = id;
            _name = name;

        }
    }
}
