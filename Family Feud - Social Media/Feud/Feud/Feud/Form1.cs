using Feud.Properties;
using System.Diagnostics.Eventing.Reader;
using System.Media;

namespace Feud
{
    public partial class Form1 : Form
    {

        //Vars
        int score = 0;
        int chances = 3;
        int time = 60;
        //Sounds
        SoundPlayer correct = new SoundPlayer(Properties.Resources.correct_choice_43861);
        SoundPlayer incorrect = new SoundPlayer(Properties.Resources.negative_beeps_6008);
        SoundPlayer victory = new SoundPlayer(Properties.Resources.winfantasia_6912);
        SoundPlayer defeat = new SoundPlayer(Properties.Resources.failfare_86009);

        public Form1()

        {
            InitializeComponent();
            pb1.Visible = pb2.Visible = pb3.Visible = pb3.Visible = pb4.Visible = pb5.Visible = pb6.Visible = pb7.Visible = pb8.Visible = pb9.Visible = pb10.Visible = false;
            Time.Start();

        }

        #region Adds 10 points to score and changes the text to score. Plays correct sound.
        public void Toscore()
        {
            score += 10;
            lblscore.Text = score.ToString();
            correct.Play();
            if (score == 100)
            {
                Time.Stop();
                victory.Play();
                MessageBox.Show("Congratulations! You did it!");
                Application.Exit();
            }
        }
        #endregion

        #region Minuses one chance from the three and changes the text to chances + panel color changes. Plays incorrect Sound.
        public void Tochance()
        {
            chances--;
            score -= 10;
            incorrect.Play();
            lblchance.Text = chances.ToString();
            pnlchanc.BackColor = Color.DarkGoldenrod;


            if (chances == 2)
            {
                pnlchanc.BackColor = Color.DarkGoldenrod;
                MessageBox.Show("Incorrect, please try again. You have two chances.");
            }
            else if (chances == 1)
            {
                pnlchanc.BackColor = Color.DarkRed;
                MessageBox.Show("Incorrect, please try again. You have one chance.");
            }
            else if (chances >= 0)
            {
                Time.Stop();
                defeat.Play();
                MessageBox.Show("You have lost all your chances! Try again next time.");
                Application.Exit();
            }

        }
        #endregion

        #region Minuses a second from the timer per interval of 1000 and displays it to a string. Loading bar is a panel that increases in width + changes color when it gets close.

        public void Totimer()
        {
            lbltime.Text = time.ToString();
            time--;
            pnlload.Width += 21;
            //Load bar for fun
            if (pnlload.Width >= 326)
            {
                lblmotiv.Text = "You are a quarter way through! You still have time.";
                pnlload.BackColor = Color.DarkGoldenrod;
            }
            if (pnlload.Width >= 653)
            {
                lblmotiv.Text = "You are half way through! Push through!";
                pnlload.BackColor = Color.DarkOrange;
            }
            if (pnlload.Width >= 1100)
            {
                lblmotiv.Text = "The time is almsot over! You can do this.";
                pnlload.BackColor = Color.DarkRed;
            }
            if (time == -1)
            {
                Time.Stop();
                defeat.Play();
                MessageBox.Show("Your time has ended, please play again.");
                Application.Exit();
            }
            if (time < 15)
            {
                lbltime.ForeColor = Color.Red;
            }
        }

        #endregion

        private void btnent_Click(object sender, EventArgs e)
        {

            //Lets make them use their heads, wechat (I think nobody knows about this one) and telegram.
            Focus();
            string input = txtgues.Text.ToLower();

            Toscore();
            if (input == "facebook" || input == "fb")
            {
                pb1.Visible = true;
                lbl1.Text = txtgues.Text;
            }

            else if (input == "whatsapp")
            {
                pb2.Visible = true;
                lbl2.Text = txtgues.Text;
            }
            else if (input == "youtube" || input == "yt")
            {
                pb3.Visible = true;
                lbl3.Text = txtgues.Text;

            }
            else if (input == "instagram" || input == "insta")
            {
                pb4.Visible = true;
                lbl4.Text = txtgues.Text;

            }
            else if (input == "wechat")
            {
                pb5.Visible = true;
                lbl5.Text = txtgues.Text;

            }
            else if (input == "tiktok")
            {
                pb6.Visible = true;
                lbl6.Text = txtgues.Text;

            }
            else if (input == "telegram")
            {
                pb7.Visible = true;
                lbl7.Text = txtgues.Text;

            }
            else if (input == "snapchat" || input == "snap")
            {
                pb8.Visible = true;
                lbl8.Text = txtgues.Text;

            }
            else if (input == "twitter" || input == "x")
            {
                pb9.Visible = true;
                lbl9.Text = txtgues.Text;

            }
            else if (input == "reddit")
            {
                pb10.Visible = true;
                lbl10.Text = txtgues.Text;

            }
            else
            {
                Tochance();
            }


        }

        private void Time_Tick(object sender, EventArgs e)
        {
            Totimer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
