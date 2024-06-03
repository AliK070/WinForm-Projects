
using System.Windows.Forms.Design;

namespace TreasureHunt
{
    public partial class Form1 : Form
    {
        int lives = 4;
        int emerald = 0;
        int score = 0;




        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            e1.Visible = false;
            e2.Visible = false;
            e3.Visible = false;

        }

        #region Score addition and conversion to string.
        public void Toscore()
        {
            score += 10;
            lblscore.Text = score.ToString();

        }
        #endregion

        #region This is a method for when the TNT is clicked, prompting the loss of lives.
        public void TNTclick()
        {
            lives--;

            if (lives == 3)
            {
                h1.Visible = false;
                MessageBox.Show("You have ignited the first TNT! Stay away from the other three! -1 life");
            }
            else if (lives == 2)
            {
                h2.Visible = false;
                MessageBox.Show("You have ignited the second TNT! Stay away from the other two! -1 life");
            }
            else if (lives == 1)
            {
                h3.Visible = false;
                MessageBox.Show("You have ignited the third TNT! Stay away from the last one! -1 life");
            }
            else if (lives == 0)
            {
                h4.Visible = false;
                MessageBox.Show("You have ignited all the TNT! You have lost.");
                Application.Exit();
            }

        }
        #endregion

        #region This is a method for when the Emerald is clicked, prompting the gain of one.
        public void EMclick()
        {
            emerald++;

            if (emerald == 1)
            {
                e1.Visible = true;
                MessageBox.Show("You have found the first Emerald! Only two more to go! +1 Emerald");
            }
            else if (emerald == 2)
            {
                e2.Visible = true;
                MessageBox.Show("You have found the second Emerald! Only one more to go! +1 Emerald");
            }
            else if (emerald == 3)
            {
                e3.Visible = true;
                MessageBox.Show("You have found the third Emerald! +1 Emerald");

            }
            if (emerald == 3)
            {
                Form2 win = new Form2();
                this.Hide();
                win.Show();
            }

        }
        #endregion



        private void pictureBox1_Click(object sender, EventArgs e)
        {

            pb1.BackgroundImage = Properties.Resources.Wheat_JE2_BE2__1_;
            MessageBox.Show("You found wheat! +10 points");
            Toscore();
        }

        private void pb2_Click(object sender, EventArgs e)
        {
            //TNT 
            pb2.BackgroundImage = Properties.Resources.TNT_JE3_BE2;
            TNTclick();
        }

        private void pb4_Click(object sender, EventArgs e)
        {
            //Emerald
            pb4.BackgroundImage = Properties.Resources.Emerald_JE3_BE3;
            Toscore();
            EMclick();

        }

        private void pb3_Click(object sender, EventArgs e)
        {

            pb3.BackgroundImage = Properties.Resources.Wheat_JE2_BE2__1_;
            MessageBox.Show("You found wheat! +10 points");
            Toscore();

        }

        private void pb5_Click(object sender, EventArgs e)
        {


            pb5.BackgroundImage = Properties.Resources.Diamond_JE3_BE3;
            MessageBox.Show("You found a diamond, shiny! +10 points");
            Toscore();

        }

        private void pb6_Click(object sender, EventArgs e)
        {
            pb6.BackgroundImage = Properties.Resources.Coal_JE4_BE3;
            MessageBox.Show("You found coal! +10 points");
            Toscore();

        }

        private void pb7_Click(object sender, EventArgs e)
        {
            pb7.BackgroundImage = Properties.Resources.Wheat_JE2_BE2__1_;
            MessageBox.Show("You found wheat! +10 points");
            Toscore();
        }


        private void pb8_Click(object sender, EventArgs e)
        {
            //TNT
            pb8.BackgroundImage = Properties.Resources.TNT_JE3_BE2;
            TNTclick();
        }

        private void pb9_Click(object sender, EventArgs e)
        {
            pb9.BackgroundImage = Properties.Resources.Iron;
            MessageBox.Show("You found iron! +10 points");
            Toscore();
        }

        private void pb10_Click(object sender, EventArgs e)
        {
            //Emerald
            pb10.BackgroundImage = Properties.Resources.Emerald_JE3_BE3;
            Toscore();
            EMclick();
        }

        private void pb11_Click(object sender, EventArgs e)
        {
            //TNT
            pb11.BackgroundImage = Properties.Resources.TNT_JE3_BE2;
            TNTclick();
        }

        private void pb12_Click(object sender, EventArgs e)
        {
            pb12.BackgroundImage = Properties.Resources.Gold_Ingot_JE4_BE2;
            MessageBox.Show("You found gold! +10 points");
            Toscore();
        }

        private void pb13_Click(object sender, EventArgs e)
        {
            //TNT
            pb13.BackgroundImage = Properties.Resources.TNT_JE3_BE2;
            TNTclick();
        }

        private void pb14_Click(object sender, EventArgs e)
        {
            pb14.BackgroundImage = Properties.Resources.Diamond_JE3_BE3;
            MessageBox.Show("You found a diamond, shiny! +10 points");
            Toscore();
        }

        private void pb15_Click(object sender, EventArgs e)
        {
            //Emerald
            pb15.BackgroundImage = Properties.Resources.Emerald_JE3_BE3;
            Toscore();
            EMclick();
        }

        private void pb16_Click(object sender, EventArgs e)
        {
            pb16.BackgroundImage = Properties.Resources.Coal_JE4_BE3;
            MessageBox.Show("You found coal! +10 points");
            Toscore();

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HARSHDEEP SINGH GHOTRA WAS HERE (Ali needs 100 percent NOW!!)");
            Application.Exit();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnpanel_Click(object sender, EventArgs e)
        {
            Panelintro.Visible = false;
        }

        private void Panelintro_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
        