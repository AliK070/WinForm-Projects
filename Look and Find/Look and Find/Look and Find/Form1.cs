using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Look_and_Find
{
    public partial class Form1 : Form
    {
        Random ran = new Random();
        int time = 25;
        int num1, num2, num3;

        public Form1()
        {
            InitializeComponent();
            btnNext.Visible = false;
            pnlShowFinish.Visible = false;  
            label1.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        void isbuttonEnabled()
        {

            if (cbPurplestap.Checked && cbSilvertroph.Checked && cbBanana.Checked && cbViolin.Checked &&
                  cbMannequin.Checked && cbHarmonica.Checked && cbDuck.Checked && cbKey.Checked)
            {
                pnlImage.Visible = false;
                btnNext.Visible = true;
                pnlShowFinish.Visible = true;
               // timer.Start();

            }
        }

        /*Use inbuilt ARGB and store the values of random between num1-num3. 
         * Num 1 to Num 3 will take values of 0-254, (Max value), and than 
         * store it in rgbColorm inputing num 1 to num 3. After this you can
         * return rgbColor to be used. 
         * */
        public Color randomRGBcolor()
        {
            num1 = ran.Next(0, 255);
            num2 = ran.Next(0, 255);
            num3 = ran.Next(0, 255);
            Color rgbColor = new Color();
            rgbColor = Color.FromArgb(num1, num2, num3);
            return rgbColor;
        }


        //Has to be a better way of doing this. Maybe switch and break?
        #region All mouse enter event handlers for the pictureboxes.
        private void pbStapler_MouseEnter(object sender, EventArgs e)
        {
                pbStapler.Enabled = false; 
                MessageBox.Show("You found the purple stapler!");
                cbPurplestap.Checked = true;
                isbuttonEnabled();
        }

        private void pbSilvertroph_MouseEnter(object sender, EventArgs e)
        {
                pbSilvertroph.Enabled = false;
                MessageBox.Show("You found the silver trophy!");
                cbSilvertroph.Checked = true;
                isbuttonEnabled();
        }

        private void pbBanana_MouseEnter(object sender, EventArgs e)
        {
                pbBanana.Enabled = false;
                MessageBox.Show("You found the banana!");
                cbBanana.Checked = true;
                isbuttonEnabled();
        }

        private void pbViolin_MouseEnter(object sender, EventArgs e)
        {
                pbViolin.Enabled = false;
                MessageBox.Show("You found the violin!");
                cbViolin.Checked = true;
                isbuttonEnabled();
        }

        private void pbMannequin_MouseEnter(object sender, EventArgs e)
        {
                pbMannequin.Enabled = false; 
                MessageBox.Show("You found the mannequin!");
                cbMannequin.Checked = true;
                isbuttonEnabled();
        }

        private void pbHarmonica_MouseEnter(object sender, EventArgs e)
        {
                pbHarmonica.Enabled = false;
                MessageBox.Show("You found the harmonica!");
                cbHarmonica.Checked = true;
                isbuttonEnabled();
        }

        private void pbDuck_MouseEnter(object sender, EventArgs e)
        {
                pbDuck.Enabled = false;
                MessageBox.Show("You found the duck!");
                cbDuck.Checked = true;
                isbuttonEnabled();
        }

        private void pbKey_MouseEnter(object sender, EventArgs e)
        {
                pbKey.Enabled = false;
                MessageBox.Show("You found the key!");
                cbKey.Checked = true;
                isbuttonEnabled();
        }
        #endregion

        private void btnNext_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            time--;
            //label1.Text = time.ToString(); Testing purposes
           
            if (time <= 20)
            {
                pbFinish.Visible = false;
                pnlShowFinish.BackColor = randomRGBcolor();
            }
            if (time == 0)
            {
                timer.Stop();

                Form2 Fdiff;
                Fdiff = new Form2();
                this.Hide();
                Fdiff.Show();
               
            }

        }
    }
}
