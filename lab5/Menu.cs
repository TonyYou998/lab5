using Bai4_NhanMail;
using System;
using System.Windows.Forms;

namespace lab5
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)// Bài 3
        {
            Login Gui = new Login();
            Gui.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bai1 b1 = new Bai1();
            b1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bai2 b2 = new Bai2();
            b2.Show();
        }
    }
}
