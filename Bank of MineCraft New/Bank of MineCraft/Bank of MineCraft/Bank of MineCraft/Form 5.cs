using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_of_MineCraft
{
    // Original Splash screen for the weblogin,
    public partial class Form5 : Form
    {

        int width = 23; //useless
        public Form5()
        {
            MaximizeBox = false;
            InitializeComponent();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
        }



        private void Form4_Load(object sender, EventArgs e)
        {
            timer1.Start();
        
            
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            //width of the bar increases each time of an interval of 15 of the timer. 
            pnlload.Width += + 3; 
            //if it reaches max width of 966, switches forms. 
            if(pnlload.Width >= 986)
            {
                timer1.Stop();
                Form1 aboutus = new Form1();
                aboutus.Show();
                this.Hide();
            }
         
            if (pnlload.Width >= 100)
            {
                label4.Text = "Loading Assets...";
            }
            if (pnlload.Width >= 200)
            {
                label4.Text = "Initalizing Variables...";
            }
            if (pnlload.Width >= 300)
            {
                label4.Text = "Loading MCSafeWeb AboutUs Portal...";
            }
            if (pnlload.Width >= 450)
            {
                label4.Text = "Loading MCSafeWeb Login Portal...";
            }
            if (pnlload.Width >= 550)
            {
                label4.Text = "Loading MCSafeWeb Products Portal...";
            }
            if (pnlload.Width >= 550)
            {
                label12.Text = "Cool Easter Egg Eh?";
            }
            if (pnlload.Width >= 650)
            {
                label4.Text = "Loading MCSafeWeb Accounts Portal...";
            }
            if (pnlload.Width >= 750)
            {
                label4.Text = "Updating UI...";
            }
            if (pnlload.Width >= 850)
            {
                label4.Text = "Finalizing...";
            }
            if (pnlload.Width >= 950)
            {
                label4.Text = "Completed";
            }
            if (pnlload.Width >= 950)
            {
          
                label12.Text = "Welcome to TBOM!";
            }
            //useless, would use this after the login page, but two forms back to back does not seem possible
            //nor do I know how to.
            //Fine easteregg it is..

        }

        private void pnlback_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
