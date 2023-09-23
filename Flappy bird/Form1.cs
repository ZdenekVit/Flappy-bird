using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_bird
{
    public partial class Form1 : Form
    {
        int PipeSpeed = 8;
        int Gravity = 5;
        int Score = 0;
        Random rnd= new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            FlappyBird.Top += Gravity;
            PipeTop.Left -= PipeSpeed;
            PipeBot.Left -= PipeSpeed;
            while(PipeTop.Left < -100 && PipeBot.Left < -100)
            {
                int distance = rnd.Next(600,700);
                int Height = rnd.Next(-225, -20);
                PipeTop.Left = distance;
                PipeTop.Top = Height;
                PipeBot.Left = distance;
                PipeBot.Top = Height + 500;
            }
        }

        private void GameKeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                Gravity = -5;
            }
        }

        private void GameKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                Gravity = 5;
            }
        }

        private void PipeBot_Click(object sender, EventArgs e)
        {

        }
    }
}
