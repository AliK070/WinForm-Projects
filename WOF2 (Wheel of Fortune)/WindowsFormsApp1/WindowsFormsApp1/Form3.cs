using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {

        int ofBody, ofHead; //Custom character body & head
        string name; //Characters Name
        string[] puzzles = {"WheelofFortune", "Todayisgood", "IloveGames"}; //3 Options for puzzles randomized.
        char[] letters;
        int lives = 7;
        int money = 1;
        int num; 
        string word;
        int guessed;
        bool clickedSpin = false; //For spin button
        Random ran = new Random();

        SoundPlayer correct = new SoundPlayer(Properties.Resources.correct_choice_43861);
        SoundPlayer incorrect = new SoundPlayer(Properties.Resources.negative_beeps_6008);
        SoundPlayer victory = new SoundPlayer(Properties.Resources.winfantasia_6912);
        SoundPlayer defeat = new SoundPlayer(Properties.Resources.failfare_86009);

        private void Form3_Load(object sender, EventArgs e)
        {
            selectCharacterLoad();
        }

        public Form3(int x, int y, string n) //Passing x, y, and n as ofBody, ofHead, and Name, to be used in this form.
        {
            InitializeComponent();
            word = selectRandomWord().ToUpper();
            letters = word.ToCharArray();
            showDashes();
            ofBody = x;
            ofHead = y;
            name = n;

            lblName.Text = name;
            disableLabels();
        }

        private void disableLabels()
        {
            Let1.Enabled = false;
            Let2.Enabled = false;
            Let3.Enabled = false;
            Let4.Enabled = false;
            Let5.Enabled = false;
            Let6.Enabled = false;
            Let7.Enabled = false;
            Let8.Enabled = false;
            Let9.Enabled = false;
            Let10.Enabled = false;
            Let11.Enabled = false;
            Let12.Enabled = false;
            Let13.Enabled = false;
            Let14.Enabled = false;
        }

        private void enableLabels()
        {
            Let1.Enabled = true;
            Let2.Enabled = true;
            Let3.Enabled = true;
            Let4.Enabled = true;
            Let5.Enabled = true;
            Let6.Enabled = true;
            Let7.Enabled = true;
            Let8.Enabled = true;
            Let8.Enabled = true;
            Let9.Enabled = true;
            Let10.Enabled = true;
            Let11.Enabled = true;
            Let12.Enabled = true;
            Let13.Enabled = true;   
            Let14.Enabled = true;   
        }

        private void showDashes()
        {
            if (word.Length == 12)
            {
                Let13.Visible = false;
                Let14.Visible = false;
            }

            else if (word.Length == 10)
            {
                Let11.Visible = false;
                Let12.Visible = false;
                Let13.Visible = false;
                Let14.Visible = false;
            }
        }
        private string selectRandomWord()
        {
            int ranIndex = ran.Next(0, puzzles.Length);
            return puzzles[ranIndex];
        }

        void selectCharacterLoad()
        {
            if (ofBody == 0)
            {
                pbBody.BackgroundImage = Resources.Body1;
            }
            else if (ofBody == 1)
            {
                pbBody.BackgroundImage = Resources.Body2;
            }
            else if (ofBody == 2)
            {
                pbBody.BackgroundImage = Resources.Body3;
            }
            else if (ofBody == 3)
            {
                pbHead.BackgroundImageLayout = ImageLayout.Stretch;
                pbBody.BackgroundImage = Resources.Body4;
            }
            else if (ofBody == 4)
            {
                pbHead.BackgroundImageLayout = ImageLayout.Stretch;
                pbBody.BackgroundImage = Resources.Body5;
            }
            else if (ofBody == 5)
            {
                pbHead.BackgroundImageLayout = ImageLayout.Stretch;
                pbBody.BackgroundImage = Resources.Body6;
            }
            //
            if (ofHead == 0)
            {
                pbHead.BackgroundImage = Resources.Head1;
            }
            else if (ofHead == 1)
            {
                pbHead.BackgroundImage = Resources.Head2;
            }
            else if (ofHead == 2)
            {
                pbHead.BackgroundImage = Resources.Head3;
            }
            else if (ofHead == 3)
            {
                pbHead.BackgroundImage = Resources.Head4;
            }
            else if (ofHead == 4)
            {
                pbHead.BackgroundImage = Resources.Head5;
            }
            else if (ofHead == 5)
            {
                pbHead.BackgroundImage = Resources.Head5;
            }
        }

        private void checkLetter(char given)
        {
            bool there = false;
            for (int i = 0; i <= word.Length - 1; i++)
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
                    if (i == 8)
                    {
                        Let9.Text = given.ToString();
                    }
                    if (i == 9)
                    {
                        Let10.Text = given.ToString();
                    }
                    if (i == 10)
                    {
                        Let11.Text = given.ToString();

                    }
                    if (i == 11)
                    {
                        Let12.Text = given.ToString();
                    }
                    if (i == 12)
                    {
                        Let13.Text = given.ToString();
                    }
                    if (i == 13)
                    {
                        Let14.Text = given.ToString();
                    }
                    ifCorrect();
                    lblGutter.Text = "Correct, spin the wheel!";
                }
             
            }
            if (!there)
            {
                lblGutter.Text = "Incorrect, you lost a live.";
                ifInncorect();
            }
        }
        private void labelParser(object sender, EventArgs e)
        {
            if (!clickedSpin) 
            {
                MessageBox.Show("Please click the spin button first.");
                return;
            }

            Label picked = (Label)sender;
            char letter = Convert.ToChar(picked.Text);
            checkLetter(letter);
            picked.Enabled = false;

            disableLabels();
            btnWheel.Enabled = true;
            clickedSpin = false;
        }



        private void ifCorrect()
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

                    Form1 form1 = new Form1();
                    this.Hide();
                    form1.Show();
                }
                if (result == DialogResult.No)
                {
                    Application.Exit();
                }
            }
        }

        private void btnWheel_Click(object sender, EventArgs e)
        {
            wheelAwards(); 
            clickedSpin = true;
            enableLabels(); 
            btnWheel.Enabled = false;

        

            
        }

        private void ifInncorect()
        {

            incorrect.Play();
            lives--;
            lblLives.Text = "Lives: " + lives.ToString();

            if (lives == 5)
            {
                money -= 500;
                lblMoney.Text = "Money: $ " + money.ToString();
                lblGutter.Text = "Incorrect, you lost $500.";
            }

            if (lives == 2)
            {
                money -= 400;
                lblMoney.Text = "Money: $ " + money.ToString();
                lblGutter.Text = "Incorrect, you lost $500.";
            }

            if (lives == 0)
            {
                defeat.Play();
                MessageBox.Show("You lost all your lives and did not guess the word! It was: " + word + ".");


                DialogResult result = MessageBox.Show("Would you like to restart the game?", "RESTART GAME", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Form1 form1 = new Form1();
                    this.Hide();
                    form1.Show();
                }
                if (result == DialogResult.No)
                {
                    Application.Exit();
                    MessageBox.Show("What a loser!");

                }
                if(money == 0 || money <= 0)
                {
                    defeat.Play();
                    MessageBox.Show("You lost all your money (bankruptcy) you lost the game: " + word + ".");

                    if (result == DialogResult.Yes)
                    {
                        Form1 form1 = new Form1();
                        this.Hide();
                        form1.Show();
                    }
                    if (result == DialogResult.No)
                    {
                        Application.Exit();
                        MessageBox.Show("What a loser!");

                    }
                }
            }

        }

        private void wheelAwards()
        {
            //Random awards till 1-7
          //  lblMoney.Text = "";
            num = ran.Next(1, 8);

            if (num == 1)
            {
                int prizeMoney = ran.Next(500, 2001);
                money += prizeMoney; 
                lblMoney.Text = "Money: $ " + money.ToString();
                lblGutter.Text = "You won $" + prizeMoney.ToString();
            }
            else if (num == 2)
            {
                string[] tripDestinations = { "Paris", "New York", "Tokyo", "London", "Dubai" };
                int index = ran.Next(tripDestinations.Length);
                string destination = tripDestinations[index];
                lblGutter.Text = "You won a trip to " + destination;
            }
            else if (num == 3)
            {
                string[] electronics = { "Paris", "New York", "Tokyo", "London", "Dubai" };
                int index = ran.Next(electronics.Length);
                string destination = electronics[index];
                lblGutter.Text = "You won a trip to " + destination;
            }

            else if (num == 4)
            {
                int prizeMoney = ran.Next(200, 400);
                money += prizeMoney;
                lblMoney.Text = "Money: $ " + money.ToString();
                lblGutter.Text = "You won $" + prizeMoney.ToString();
            }
            else if (num == 5)
            {
                string[] clothingStuff = { "T-shirt", "Jeans", "Dress", "Sweater", "Jacket" };
                int index = ran.Next(clothingStuff.Length);
                string clothing = clothingStuff[index];
                lblGutter.Text = "You won a " + clothing;
            }
            else if (num == 6)
            {
                int giftCard = ran.Next(25, 101);
                money += giftCard;
                lblMoney.Text = "Money $ " + money.ToString();
                lblGutter.Text = "You won a giftcard $" + giftCard.ToString();
            }

            else if (num == 7)
            {
                string[] someBooksIguess = { "Fiction", "Non-fiction", "Mystery", "Thriller", "Fantasy" };
                int index = ran.Next(someBooksIguess.Length);
                string type = someBooksIguess[index];
                lblGutter.Text = "You won a " + type + " book";
            }
        }
    }
    }
