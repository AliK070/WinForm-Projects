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
    // Original Splash screen for the weblogin
    public partial class Form5 : Form
    {

        int width = 23;
        public Form5()
        {
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
            pnlload.Width += + 10; 
            //if it reaches max width of 966, switches forms. 
            if(pnlload.Width >= 966)
            {
                timer1.Stop();
                Form1 aboutus = new Form1();
                aboutus.Show();
                this.Hide();
            }
            //useless, would use this after the login page, but two forms back to back does not seem possible
            //nor do I know how to.
           
        }
    }
}
