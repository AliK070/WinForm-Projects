using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace PacMan
{
  
    
    
    public partial class Form1 : Form
    {
        public Form1()

        {
            SoundPlayer player = new SoundPlayer();
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void PacManDeful_Click(object sender, EventArgs e)
        {

            PacManDeful.Location = new Point(0,10);
            //Right
            for (int x = 5; x < 650; x+= 5) 
            {
                if (x % 2 == 0) {
                    PacManDeful.BackgroundImage = Properties.Resources.pacMouthOpen;
                }
                else
                {
                    PacManDeful.BackgroundImage = Properties.Resources.pacMouthClosed;
                }
                PacManDeful.Refresh(); // I was missing this piece
                PacManDeful.Location = new Point(x, 10);
                PacManDeful.BackgroundImage = Properties.Resources.pacMouthOpen;
                this.Update();
                Thread.Sleep(1);
                
            }
            //Down
            for (int y = 5; y < 350; y += 5)
            {
                if (y % 2 == 0)
                {
                    PacManDeful.BackgroundImage = Properties.Resources.pacMouthOpendown;
                }
                else
                {
                    PacManDeful.BackgroundImage = Properties.Resources.pacMouthClosed;
                }
                PacManDeful.Refresh();
                PacManDeful.Location = new Point(650, y);
                PacManDeful.BackgroundImage = Properties.Resources.pacMouthOpendown;
                this.Update();
                Thread.Sleep(1);

            }
            //left
            for (int x = 650; x > 10; x -= 5)
            {
                if (x % 2 == 0)
                {
                    PacManDeful.BackgroundImage = Properties.Resources.pacMouthOpenLeft;
                }
                else
                {
                    PacManDeful.BackgroundImage = Properties.Resources.pacMouthClosed;
                }
                PacManDeful.Refresh();
                PacManDeful.Location = new Point(x, 350);
                PacManDeful.BackgroundImage = Properties.Resources.pacMouthOpenLeft;
                this.Update();
                Thread.Sleep(1);

            }
            //Back up
            for (int y = 350; y > 10; y -= 5)
            {
                if (y % 2 == 0)
                {
                    PacManDeful.BackgroundImage = Properties.Resources.pacMouthOpenUp;
                }
                else
                {
                    PacManDeful.BackgroundImage = Properties.Resources.pacMouthClosed;
                }
                PacManDeful.Refresh();
                PacManDeful.Location = new Point(10, y);
                PacManDeful.BackgroundImage = Properties.Resources.pacMouthOpenUp;
                this.Update();
                PacManDeful.BackgroundImage = Properties.Resources.pacMouthClosed;
                Thread.Sleep(1);

            }
        }
    }




}

