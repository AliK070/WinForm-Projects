using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Triva_Assigment
{
    public partial class Form1 : Form
    {
    //score starting and username declaration
       int score = 100;
       string userName = "";
        public Form1()

        {

            //Vis when btn pressed
            InitializeComponent();
            lbl_numscore.Visible = false;
            lbl_score.Visible = false;
            btn1.Enabled = false;
            this.MaximizeBox = false;
         
          //  string userName = Interaction.InputBox("Enter your username", "Username", "username", -1, -1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // userName = Interaction.InputBox("Enter your username", "Username", "username", -1, -1);
            MessageBox.Show("Please enter your name in the text box above before starting.");
            txtUsername.Focus();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //Incorrect Answer for Gb1
            pb1.Visible = false;
            score = score - 120;
            pb1.BackgroundImage = Properties.Resources.Wrong;
            rd1Gb1.Enabled = false;
            rd2Gb1.Enabled = false;
            rd3Gb1.Enabled = false;
            lbl_numscore.Text = score.ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //Correct Answer for Gb1
            pb1.Visible = false;
            pb1.BackgroundImage = Properties.Resources.Right;
            score = score * 2;
            rd1Gb1.Enabled = false;
            rd2Gb1.Enabled = false;
            rd3Gb1.Enabled = false;
            lbl_numscore.Text = score.ToString();
            gb2.Focus();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void rd4Gb1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gb2_Enter(object sender, EventArgs e)
        {

        }

        private void rd1Gb3_CheckedChanged(object sender, EventArgs e)
        {
            //Correct Answer for Gb3
            pb3.Visible = false;
            score = score + 9;
            pb3.BackgroundImage = Properties.Resources.Right;
            rd1Gb3.Enabled = false;
            rd2Gb3.Enabled = false;
            rd3Gb3.Enabled = false;
            lbl_numscore.Text = score.ToString();
            gb4.Focus();
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            //Inorrect Answer for Gb4
            pb4.Visible = false;
            score = score - 10;
            pb4.BackgroundImage = Properties.Resources.Wrong;
            rd1Gb4.Enabled = false;
            rd2Gb4.Enabled = false;
            rd3Gb4.Enabled = false;
            lbl_numscore.Text = score.ToString();
            gb5.Focus();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
            //Incorrect Answer for Gb6
            pb6.Visible = false;
            btn1.Enabled = true;
            score = score - 10;
            pb6.BackgroundImage = Properties.Resources.Wrong;
            rd1Gb6.Enabled = false;
            rd2Gb6.Enabled = false;
            rd3Gb6.Enabled = false;
            lbl_numscore.Text = score.ToString();
        }

        private void gb1_Enter(object sender, EventArgs e)
        {



        }

        private void rd1Gb2_CheckedChanged(object sender, EventArgs e)
        {

            //Correct Answer for Gb2
            pb2.Visible = false;
            score = score % 2;
            pb2.BackgroundImage = Properties.Resources.Right;
            rd1Gb2.Enabled = false;
            rd2Gb2.Enabled = false;
            rd3Gb2.Enabled = false;
            rd4Gb2.Enabled = false;
            lbl_numscore.Text = score.ToString();
            gb3.Focus();

        }

        private void rd3Gb1_CheckedChanged(object sender, EventArgs e)
        {
            //Incorrect Answer for Gb1
            pb1.Visible = false;
            score = score - 100;
            pb1.BackgroundImage = Properties.Resources.Wrong;
            rd1Gb1.Enabled = false;
            rd2Gb1.Enabled = false;
            rd3Gb1.Enabled = false;
            lbl_numscore.Text = score.ToString();
        }

        private void rd3Gb2_CheckedChanged(object sender, EventArgs e)
        {
            //Incorrect Answer for Gb2
            pb2.Visible = false;
            score = score - 120;
            pb2.BackgroundImage = Properties.Resources.Wrong;
            rd1Gb2.Enabled = false;
            rd2Gb2.Enabled = false;
            rd3Gb2.Enabled = false;
            rd4Gb2.Enabled = false;
            lbl_numscore.Text = score.ToString();
        }

        private void rd2Gb2_CheckedChanged(object sender, EventArgs e)
        {
            //Incorrect Answer for Gb2
            pb2.Visible = false;
            score = score - 120;
            pb2.BackgroundImage = Properties.Resources.Wrong;
            rd1Gb2.Enabled = false;
            rd2Gb2.Enabled = false;
            rd3Gb2.Enabled = false;
            rd4Gb2.Enabled = false;
            lbl_numscore.Text = score.ToString();
        }

        private void rd4Gb2_CheckedChanged(object sender, EventArgs e)
        {
            //Incorrect Answer for Gb2
            pb2.Visible = false;
            score = score - 120;
            pb2.BackgroundImage = Properties.Resources.Wrong;
            rd1Gb2.Enabled = false;
            rd2Gb2.Enabled = false;
            rd3Gb2.Enabled = false;
            rd4Gb2.Enabled = false;
            lbl_numscore.Text = score.ToString();
        }

        private void rd2Gb3_CheckedChanged(object sender, EventArgs e)
        {
            //Incorrect Answer for Gb3
            pb3.Visible = false;
            score = score - 10;
            pb3.BackgroundImage = Properties.Resources.Wrong;
            rd1Gb3.Enabled = false;
            rd2Gb3.Enabled = false;
            rd3Gb3.Enabled = false;
            lbl_numscore.Text = score.ToString();
        }

        private void rd3Gb3_CheckedChanged(object sender, EventArgs e)
        {
            //Incorrect Answer for Gb3
            pb3.Visible = false;
            score = score - 10;
            pb3.BackgroundImage = Properties.Resources.Wrong;
            rd1Gb3.Enabled = false;
            rd2Gb3.Enabled = false;
            rd3Gb3.Enabled = false;
            lbl_numscore.Text = score.ToString();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void rd2Gb4_CheckedChanged(object sender, EventArgs e)
        {
            //Correct Answer for Gb4
            pb4.Visible = false;
            score = score * score;
            pb4.BackgroundImage = Properties.Resources.Right;
            rd1Gb4.Enabled = false;
            rd2Gb4.Enabled = false;
            rd3Gb4.Enabled = false;
            lbl_numscore.Text = score.ToString();

        }

        private void rd3Gb4_CheckedChanged(object sender, EventArgs e)
        {
            //Inorrect Answer for Gb4
            pb4.Visible = false;
            score = score - 10;
            pb4.BackgroundImage = Properties.Resources.Wrong;
            rd1Gb4.Enabled = false;
            rd2Gb4.Enabled = false;
            rd3Gb4.Enabled = false;
            lbl_numscore.Text = score.ToString();
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void rd1Gb5_CheckedChanged(object sender, EventArgs e)
        {
            //Correct Answer for Gb5
            pb5.Visible = false;
            score = score + 3;
            pb5.BackgroundImage = Properties.Resources.Right;
            rd1Gb5.Enabled = false;
            rd2Gb5.Enabled = false;
            lbl_numscore.Text = score.ToString();
            gb6.Focus();

        }

        private void rd2Gb5_CheckedChanged(object sender, EventArgs e)
        {
            //Incorrect Answer for Gb5
            pb5.Visible = false;
            score = score - 30;
            pb5.BackgroundImage = Properties.Resources.Wrong;
            rd1Gb5.Enabled = false;
            rd2Gb5.Enabled = false;
            lbl_numscore.Text = score.ToString();
        }

        private void rd1Gb6_CheckedChanged(object sender, EventArgs e)
        {
            //Correct Answer for Gb6
            pb6.Visible = false;
            btn1.Enabled = true;
            score = score + 16;
            pb6.BackgroundImage = Properties.Resources.Right;
            rd1Gb6.Enabled = false;
            rd2Gb6.Enabled = false;
            rd3Gb6.Enabled = false;
            lbl_numscore.Text = score.ToString();
            btn1.Focus();
        }

        private void rd3Gb6_CheckedChanged(object sender, EventArgs e)
        {
            //Incorrect Answer for Gb6
            pb6.Visible = false;
            btn1.Enabled = true;
            score = score - 10;
            pb6.BackgroundImage = Properties.Resources.Wrong;
            rd1Gb6.Enabled = false;
            rd2Gb6.Enabled = false;
            rd3Gb6.Enabled = false;
            lbl_numscore.Text = score.ToString();

            
        }

        private void gb6_Enter(object sender, EventArgs e)
        {

        }

        private void gb5_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* I got bored, decided to tinker around - Ali
             * If textbox/usernmame is blank or null it will show a message box and it will set 
             * the foucs on the textbox, return statment will not excute the rest of the code that
             * comes after it if the name is not entered. 
            
            */
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Please enter username");
                txtUsername.Focus();
                return;
            }
            userName = txtUsername.Text;
            //Pictures are enabled when btn pressed
            pb1.Visible = pb2.Visible = pb3.Visible = pb4.Visible = pb5.Visible = pb6.Visible = true;
            lbl_numscore.Visible = true;
            lbl_score.Visible = true;
              if (!string.IsNullOrEmpty(txtUsername.Text)) { 
                userName = txtUsername.Text;
            }
            //userName = txtbx1.Text;
           
            //Fail
            if (score <= 50)
            {
                MessageBox.Show("Better Luck Next time " + userName + "! Your final score was: " + score);
        //Pass
            }
            if (score >= 50)
            {
                MessageBox.Show("Great Job " + userName + "! Your final score is: " + score);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click_1(object sender, EventArgs e)
        {

        }

        private void txtbx1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
          
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
