using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Look_and_Find
{
    public partial class Form2 : Form
    {
        int count = 0;
        int time = 71; //change to 60
        int sub = 5;

        Random ran = new Random();
        int num, num2, num3;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        #region Subroutine to simply add to count and convert it to a string, win conditions stated here.
        void toString() {
            count++;
            lblCount.Text = count.ToString();

            if (count == 5 || count == 6)
            {
                timer1.Stop();
                MessageBox.Show("You found all the differences!");
                MessageBox.Show("Congradulations!");
                Application.Exit();

            }
        }
        #endregion

        #region Randomization for the pictureboxes.
        public void toRandom()
        {
            num = ran.Next(1, 3);
            num2 = ran.Next(1, 3);
            num3 = ran.Next(1, 3);

            //pb1
            if (num == 1)
            {
                pb1.BackgroundImage = Properties.Resources.add;
            }
            else if (num == 2)
            {
                pb1.BackgroundImage = Properties.Resources.sign;
            }
            //pb2
            if (num2 == 1)
            {
                pb2.BackgroundImage = Properties.Resources.add;
            }
            else if (num2 == 2)
            {
                pb2.BackgroundImage = Properties.Resources.sign;
            }

            //pb3
            if (num3 == 1)
            {
                pb3.BackgroundImage = Properties.Resources.add;
            }
            else if (num3 == 2)
            {
                pb3.BackgroundImage = Properties.Resources.sign;
            }


        }
        #endregion

        #region All mouse_enter events for the pictureboxes.
        private void pbVase_MouseEnter(object sender, EventArgs e)
        {

            pbVase.Enabled = false;
            MessageBox.Show("You found the difference in the Vase!");
            toString();

        }

        private void pbPlaque_MouseEnter(object sender, EventArgs e)
        {
            pbPlaque.Enabled = false;
            MessageBox.Show("You found the difference in the Plaque!");
            toString();
        }

        private void pbHead_MouseEnter(object sender, EventArgs e)
        {
            pbHead.Enabled = false;
            MessageBox.Show("You found the difference in the Head!");
            toString();

        }

        private void pbBorder_MouseEnter(object sender, EventArgs e)
        {
            pbBorder.Enabled = false;
            MessageBox.Show("You found the difference in the Border!");
            toString();
        }

        private void pbPillow_MouseEnter(object sender, EventArgs e)
        {
            pbPillow.Enabled = false;
            MessageBox.Show("You found the difference in the Pillow!");
            toString();
        }

        private void pbSofa_MouseEnter(object sender, EventArgs e)
        {
            pbSofa.Enabled = false;
            MessageBox.Show("You found the difference in the Sofa!");
            toString();
        }

        #endregion

        #region Condition for if the player hovers over the - sign at if time - sub is less or equal to zero exit game.
        public void conditionNegative() 
        
        {

            if (time - sub <= 0)
            {
                timer1.Stop();
                MessageBox.Show("You hovered over the - sign at last (no time), you have lost, try again later");
                Application.Exit();
            }


        }
        #endregion

        #region All mouse_enter events for randomization pictureboxes 

        private void pb1_MouseEnter(object sender, EventArgs e)
        {

            if (num == 1) {
                MessageBox.Show("Plus 10 Seconds");
                time += 10;
            }
         

            if (num == 2)
            {
                MessageBox.Show("Minus 5 Seconds");
                time -= sub;
            }

            conditionNegative();
            pb1.Visible = false;
        }

        private void pb2_MouseEnter(object sender, EventArgs e)
        {
            if (num2 == 1)
            {
                MessageBox.Show("Plus 10 Seconds");
                time += 10;
            }


            if (num2 == 2)
            {
                MessageBox.Show("Minus 5 Seconds");
                time -= sub;
            }

            conditionNegative();
            pb2.Visible = false;
        }

        private void pb3_MouseEnter(object sender, EventArgs e)
        {
            if (num3 == 1)
            {
                MessageBox.Show("Plus 10 Seconds");
                time += 10;
            }


            if (num3 == 2)
            {
                MessageBox.Show("Minus 5 Seconds");
                time -= sub;
            }

            conditionNegative();
            pb3.Visible = false;

        }

        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (time % 2 == 0)
            {
                toRandom();
            }

            int minutes = (time / 60); 
            int seconds = (time % 60);


            if (seconds > 9) 
            lblTime.Text = minutes + ":" + seconds;
            else
            lblTime.Text = minutes + ":0" + seconds;
            time--;


           

            if (time <= -1) { 
                timer1.Stop();
                MessageBox.Show("Time has run out, please play again later"); 
                Application.Exit();
            }

        }
    }
}
