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
    public partial class Form2 : Form
    {
        //username, addy, and pstlcd strings f
        string Username, Address, PostalCd; 

        public Form2()
        {
            InitializeComponent();
            linkLabel4.Visible = false;
            label3.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void txtCard_TextChanged(object sender, EventArgs e)
        {
    
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //sends to about us page
            Form1 aboutus = new Form1();
            aboutus.Show();
            this.Hide();

        }


        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //sends to our products page
            Form4 ourproducts = new Form4();
            ourproducts.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Convert to text
            Username = txtUsername.Text;
            Address = txtAddress.Text; 
            PostalCd = txtPostalCode.Text;

            //Three if statments for if the boxes are null or empty, show these messages:
            if (string.IsNullOrEmpty(txtUsername.Text))
            {

                MessageBox.Show("Please enter your Username");
                txtUsername.Focus();
                return;

            }

            if (string.IsNullOrEmpty(txtAddress.Text))
            {

                MessageBox.Show("Please enter your Address");
                txtAddress.Focus();
                return;

            }

            if (string.IsNullOrEmpty(txtPostalCode.Text))
            {

                MessageBox.Show("Please enter your Postal Code");
                txtPostalCode.Focus();
                return;

            }
            //All forms filled out? Sends to accounts page

            Form3 accounts = new Form3(Username, Address, PostalCd);
            accounts.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //enable secure password view
            label3.Visible = true;
            txtUsername.PasswordChar = '*';
            txtAddress.PasswordChar = '*';
            txtPostalCode.PasswordChar = '*';
            linkLabel4.Visible = true;
            linkLabel1.Visible = false;

        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            //disable secure password view \0 is a null character, yes very cool indeed
            label11.Text = label11.Text;
            txtUsername.PasswordChar = '\0';
            txtAddress.PasswordChar = '\0';
            txtPostalCode.PasswordChar = '\0';
            linkLabel4.Visible = false;
            linkLabel1.Visible = true;
            label3.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //closes app (duh)
            Application.Exit();
        }
    }
}
