using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_of_MineCraft
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            MaximizeBox = false;
            InitializeComponent();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 aboutus = new Form1();
            aboutus.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 login = new Form2();
            login.Show();
            this.Hide();

        }

        private void label8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clean_UI-v2 is another version of the user interface design. - Ali Khan");
        }
    }
}
