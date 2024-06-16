using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangMan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProc_Click(object sender, EventArgs e)
        {
            string word = txtWord.Text;
            if (word.Length == 5 || word.Length == 6 || word.Length == 7 || word.Length == 8)
            {
             
            }
            else
            {
                MessageBox.Show("Please enter a word that is at least 5-8 characters long");
                txtWord.Clear();
                txtWord.Focus();
            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
            }
        }
    }
}
