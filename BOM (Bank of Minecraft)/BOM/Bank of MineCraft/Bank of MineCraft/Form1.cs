using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Bank_of_MineCraft
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            int volume; 
         //windows media player, plays the song from the debug file location, using .wavs tried mp3 dont think they work
            System.Media.SoundPlayer menutheme = new System.Media.SoundPlayer("1-01. Key.wav");
       
            menutheme.Play();
           
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

            //sends to login
            Form2 register = new Form2();
            register.Show();
            this.Hide(); 

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //sends to product page
            Form4 ourproducts = new Form4();
            ourproducts.Show();
            this.Hide();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //dead button
            Form2 register = new Form2();
            register.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //sends to login
            Form2 register = new Form2();
            register.Show();
            this.Hide();
        }
    }
}
