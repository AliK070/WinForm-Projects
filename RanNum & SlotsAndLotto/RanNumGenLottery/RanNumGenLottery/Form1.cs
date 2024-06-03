using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace RanNumGenLottery
{
    public partial class Form1 : Form
    {

         // string generatedres = ""; 
        //this is really stupid, it dosent clear it here but clears it in the genRandom, method??? what??
        // Ill declare it there.
        public Form1()
        {
            InitializeComponent();
        }
        public void genRandom(int amount)
        {
            string generatedres = ""; // It works! and clears the label!
            Random random = new Random();

            for (int i = 0; i < amount; i++)
            {
                int ran = random.Next(100);
                generatedres += ran.ToString() + "-"; 
            }
            generatedres = generatedres.TrimEnd('-'); //trims the end removing the extra -
            lblGen.Text = generatedres;
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            if (rbNum3.Checked == true)
            {
                genRandom(3);
            }
            if (rbNum4.Checked == true)
            {
                genRandom(4);
            }
            if (rbNum5.Checked == true)
            {
                genRandom(5);
            }
            if (lblGen.Text.Count() >= 10)
            {
                lblGen.Location = new Point(130, 5);
            }
            else if (lblGen.Text.Count() >= 11)
            {
                lblGen.Location = new Point(125, 5);
            }
            else if (lblGen.Text.Count() >= 13)
            {
                lblGen.Location = new Point(110, 5);
            }
            else
            {
                lblGen.Location = new Point(150, 5); //Pos deafult
            }
        
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please come back again and see your numbers!. (:");
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        /* terribly garbage way of doing this 
        public void toRan3()
        { 
          int ran = random.Next(100);int ran2 = random.Next(100);int ran3 = random.Next(100);
             lblGen.Text = ran.ToString() + "-" + ran2.ToString() + "-" + ran3.ToString();
            
         
        }
        public void toRan4()
        {
            int ran = random.Next(100);int ran2 = random.Next(100);int ran3 = random.Next(100);int ran4 = random.Next(100);
            lblGen.Text = ran.ToString() + "-" + ran2.ToString() + "-" + ran3.ToString() + "-" + ran4.ToString();
        }
        public void toRan5()
        {
            int ran = random.Next(100);int ran2 = random.Next(100);int ran3 = random.Next(100);
            lblGen.Text = ran.ToString() + "-" + ran2.ToString() + "-" + ran3.ToString();
        }
        */

    }
}

