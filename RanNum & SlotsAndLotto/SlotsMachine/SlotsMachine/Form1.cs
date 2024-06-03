using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlotsMachine
{
    public partial class Form1 : Form
    {
        Random ran = new Random();
        int num, num2, num3;
        int score = 100; 
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void toRandom()
        {
            lblscore.Text = score.ToString();
            num = ran.Next(1, 4);
            num2 = ran.Next(1, 4);
            num3 = ran.Next(1, 4);

            //pb1
            if (num == 1)
            {
                pb1.BackgroundImage = Properties.Resources.cherries;
            }
            else if (num == 2)
            {
                pb1.BackgroundImage = Properties.Resources.bar;
            }
            else if (num == 3)
            {
                pb1.BackgroundImage = Properties.Resources.casino;
            }
            //pb2
            if (num2 == 1)
            {
                pb2.BackgroundImage = Properties.Resources.cherries;
            }
            else if (num2 == 2)
            {
                pb2.BackgroundImage = Properties.Resources.bar;
            }
            else if (num2 == 3)
            {
                pb2.BackgroundImage = Properties.Resources.casino;
            }
            //pb3
            if (num3 == 1)
            {
                pb3.BackgroundImage = Properties.Resources.cherries;
            }
            else if (num3 == 2)
            {
                pb3.BackgroundImage = Properties.Resources.bar;
            }
            else if (num3 == 3)
            {
                pb3.BackgroundImage = Properties.Resources.casino;

            }
        }

        private void btnPull_Click(object sender, EventArgs e)
        {

            score -= 10;

            if (score < 0)
            {
                if(MessageBox.Show("You have zero points, would you like to try again?!","Play again",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    Application.Restart();
                }
                else 
                {
                    Application.Exit();
                }
               
               // MessageBoxButtons buttons = MessageBoxButtons.YesNo;
               // DialogResult dialogResult = new MessageBox.Show("aadadada"); 
            }

            if (num == 1 && num2 == 1 && num3 == 1)
            {
                score += 500;
                lblscore.Text = score.ToString();
                MessageBox.Show("Three Cherries in a row! 500+ points.\n" + "Your score is: " + score + "\n*Does not include current pull score");
                
            }
            else if (num == 2 && num2 == 2 && num3 == 2)
            {
                score += 100;
                lblscore.Text = score.ToString();
                MessageBox.Show("Three Bars in a row! 100+ points.\n" + "Your score is: " + score + "\n*Does not include current pull score");
                
            }
            else if (num == 3 && num2 == 3 && num3 == 3)
            {
                score += 100;
                lblscore.Text = score.ToString();
                MessageBox.Show("Three Sevens in a row! 50+ points.\n" + "Your score is: " + score + "\n*Does not include current pull score");
               
            }
            toRandom();
            }
        }
    }
