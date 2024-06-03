using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace HangMan
{
    public partial class Form2 : Form
    {
        //title could have been way worse
        string word; 
        char[] letters;
        int lives = 7; //head, body, arm1, arm2, leg1, leg2, face. 
        int guessed;

        //sounds
        SoundPlayer correct = new SoundPlayer(Properties.Resources.correct_choice_43861);
        SoundPlayer incorrect = new SoundPlayer(Properties.Resources.negative_beeps_6008);
        SoundPlayer victory = new SoundPlayer(Properties.Resources.winfantasia_6912);
        SoundPlayer defeat = new SoundPlayer(Properties.Resources.failfare_86009);


        public Form2(string w)
        {
            InitializeComponent();
            word = w.ToUpper();
            letters = word.ToCharArray();
            showdashes();

            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
          
        }

        private void showdashes()
        {
            if (word.Length == 5)
            {
                Let6.Visible = false;
                Let7.Visible = false;
                Let8.Visible = false;
            }

            else if (word.Length == 6)
            {
                Let7.Visible = false;
                Let8.Visible = false;
            }

            else if (word.Length == 7)
            {
                Let8.Visible = false;
            }
        }
        private void checkLetter(char given)
        {
            bool there = false;
            for (int i = 0;  i <= word.Length - 1; i++)
            {
                
                if (word[i] == given)
                {
                    there = true;
                    if (i == 0)
                    {
                        Let1.Text = given.ToString();
                    }
             
                    if (i == 1)
                    {
                        Let2.Text = given.ToString();
                    }
                    if (i == 2)
                    {
                        Let3.Text = given.ToString();
                    }
                    if (i == 3)
                    {
                        Let4.Text = given.ToString();
                    }
                    if (i == 4)
                    {
                        Let5.Text = given.ToString();
                    }
                    if (i == 5)
                    {
                        Let6.Text = given.ToString();
                    }
                    if (i == 6)
                    {
                        Let7.Text = given.ToString();
                    }
                    if (i == 7)
                    {
                        Let8.Text = given.ToString();
                    }
                 
                    didGuess();
                }
              }

            if (there == false)
            {
                didNotGuess();
                drawHandman();
            }
        }

        //YOUWIN(); condition + restart condition
        private void didGuess()
        {
            correct.Play();
            guessed++; 
            if (guessed == word.Length)
            {
                victory.Play();
                MessageBox.Show("You guessed the word correctly! It was: " + word + ".");

                DialogResult result = MessageBox.Show("Would you like to restart the game?", "RESTART GAME", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Form1 fm1 = new Form1();
                    this.Hide();
                    fm1.Show();
                }
                if (result == DialogResult.No)
                {
                    Application.Exit();
                }
            }
        }

        //YOULOSE(); condition + restart condition
        private void didNotGuess()
        {
            incorrect.Play();
            lives--;
            MessageBox.Show("You lost a life");

            lblLives.Text = "Fingers Left (hand included): " + lives.ToString();
            

            if (lives == 0)
            {
                defeat.Play();
                MessageBox.Show("You lost all your lives and did not guess the word! It was: " + word + ".");


                DialogResult result = MessageBox.Show("Would you like to restart the game?", "RESTART GAME", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Form1 fm1 = new Form1();
                    this.Hide();
                    fm1.Show();
                }
                if (result == DialogResult.No)
                {
                    Application.Exit();
                    MessageBox.Show("What a loser!");

                }
            }

        }


        //DRAWHANGMAN(); 
        private void drawHandman()
        {
            if (lives == 6)
            {
                pbHand.Visible = true;
            }
            
            if (lives == 5)
            {
                MessageBox.Show("My index finger! You lost it!");
                pbHand.Visible = true;
                pb1.Visible = true;
            }
            if (lives == 4)
            {
                pbHand.Visible = true;
                pb2.Visible = true;
            }
            if (lives == 3)
            {
                pbHand.Visible = true;
                pb3.Visible = true;
            }
            if (lives == 2)
            {
                MessageBox.Show("At this rate ill be fingerless!");
                pbHand.Visible = true;
                pb4.Visible = true;
            }
            if (lives == 1)
            {
                MessageBox.Show("Seriously!");
                pbHand.Visible = true;
                pb5.Visible = true;
            }
            if (lives == 0)
            {
                MessageBox.Show("Real funny, now im palm man!!");
                pbHand.Visible = false;
            }
           


        }

        private void labelParser(object sender, EventArgs e)
        {
            Label picked = (Label)sender;
            char letter = Convert.ToChar(picked.Text);
            checkLetter(letter);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
;