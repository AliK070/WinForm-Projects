using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triva_Assigment
{
    public partial class Form1 : Form
    {

        int score = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
            score = score - 5;
            pb1.BackgroundImage = Properties.Resources.Wrong;
            rd1Gb1.Enabled = false;
            rd2Gb1.Enabled = false;
            rd3Gb1.Enabled = false;
            lbl_numscore.Text = score.ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //Correct Answer for Gb1
            pb1.BackgroundImage = Properties.Resources.Right;
            score = score + 3;
            rd1Gb1.Enabled = false;
            rd2Gb1.Enabled = false;
            rd3Gb1.Enabled = false;
            lbl_numscore.Text = score.ToString();

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
            score = score * score;
            pb3.BackgroundImage = Properties.Resources.Right;
            rd1Gb3.Enabled = false;
            rd2Gb3.Enabled = false;
            rd3Gb3.Enabled = false;
            lbl_numscore.Text = score.ToString();
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            //Inorrect Answer for Gb4
            score = score - 10;
            pb4.BackgroundImage = Properties.Resources.Wrong;
            rd1Gb4.Enabled = false;
            rd2Gb4.Enabled = false;
            rd3Gb4.Enabled = false;
            lbl_numscore.Text = score.ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
            //Incorrect Answer for Gb6
            score = score - 10;
            pb5.BackgroundImage = Properties.Resources.Wrong;
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
            score = score * 2;
            pb2.BackgroundImage = Properties.Resources.Right;
            rd1Gb2.Enabled = false;
            rd2Gb2.Enabled = false;
            rd3Gb2.Enabled = false;
            rd4Gb2.Enabled = false;
            lbl_numscore.Text = score.ToString();

        }

        private void rd3Gb1_CheckedChanged(object sender, EventArgs e)
        {
            //Incorrect Answer for Gb1
            score = score - 5;
            pb1.BackgroundImage = Properties.Resources.Wrong;
            rd1Gb1.Enabled = false;
            rd2Gb1.Enabled = false;
            rd3Gb1.Enabled = false;
            lbl_numscore.Text = score.ToString();
        }

        private void rd3Gb2_CheckedChanged(object sender, EventArgs e)
        {
            //Incorrect Answer for Gb2
            score = score - 10;
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
            score = score - 20;
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
            score = score - 10;
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
            score = score - 10;
            pb3.BackgroundImage = Properties.Resources.Wrong;
            rd1Gb3.Enabled = false;
            rd2Gb3.Enabled = false;
            rd3Gb3.Enabled = false;
            lbl_numscore.Text = score.ToString();
        }

        private void rd3Gb3_CheckedChanged(object sender, EventArgs e)
        {
            //Correct Answer for Gb3
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
            score = score + 10;
            pb4.BackgroundImage = Properties.Resources.Right;
            rd1Gb4.Enabled = false;
            rd2Gb4.Enabled = false;
            rd3Gb4.Enabled = false;
            lbl_numscore.Text = score.ToString();

        }

        private void rd3Gb4_CheckedChanged(object sender, EventArgs e)
        {
            //Inorrect Answer for Gb4
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
            score = score + 24;
            pb5.BackgroundImage = Properties.Resources.Right;
            rd1Gb5.Enabled = false;
            rd2Gb5.Enabled = false;
            lbl_numscore.Text = score.ToString();


        }

        private void rd2Gb5_CheckedChanged(object sender, EventArgs e)
        {
            //Incorrect Answer for Gb5
            score = score % 12;
            pb5.BackgroundImage = Properties.Resources.Wrong;
            rd1Gb5.Enabled = false;
            rd2Gb5.Enabled = false;
            lbl_numscore.Text = score.ToString();
        }

        private void rd1Gb6_CheckedChanged(object sender, EventArgs e)
        {
            //Correct Answer for Gb6
            score = score + 30;
            pb6.BackgroundImage = Properties.Resources.Right;
            rd1Gb6.Enabled = false;
            rd2Gb6.Enabled = false;
            rd3Gb6.Enabled = false;
            lbl_numscore.Text = score.ToString();
        }

        private void rd3Gb6_CheckedChanged(object sender, EventArgs e)
        {
            //Incorrect Answer for Gb6
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
            if (score <= 50)
            {
                MessageBox.Show("Goodjob! You passed the computer triva");

            }
            if (score >= 50)
            {
                MessageBox.Show("Practice next time more, you failed the computer triva");
            }
        }

        private void lbl_numscore_Click(object sender, EventArgs e)
        {

        }
    }
}
