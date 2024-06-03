using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maze_Assigment
{
    public partial class Form1 : Form
    {

        System.Media.SoundPlayer startSoundPlayer = new
        System.Media.SoundPlayer(Properties.Resources.videogame_death_sound_43894);
        System.Media.SoundPlayer endSoundPlayer = new
        System.Media.SoundPlayer(Properties.Resources.goodresult_82807);
        public Form1()
        {
            InitializeComponent();
            MoveToStart();
        }

        private void wall_MouseEnter(object sender, EventArgs e)
        {
            // When the mouse pointer hits a wall or enters the panel,
            // call the MoveToStart() method.
            startSoundPlayer.Play();
            MoveToStart();
        }
        private void MoveToStart()
        {
            Point startingPoint = panel1.Location;
            startingPoint.Offset(280, 10);
            Cursor.Position = PointToScreen(startingPoint);

        }

        private void lblFin_MouseEnter(object sender, EventArgs e)
        {
            endSoundPlayer.Play();
            MessageBox.Show("Congratulations!");
            Close();

        }

       
    }
}