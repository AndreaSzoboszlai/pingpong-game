using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PongPongGame
{
    public partial class Form1 : Form
    {
        bool goDown;
        bool goUp;
        bool secondPlayerUp;
        bool secondPlayerDown;
        bool paused;
        int level = 1;
        int counter = 1;
        int speed = 7;
        int ballx = 5;
        int bally = 5;
        int score1 = 0;
        int score2 = 0;

        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Down)
            {
                goDown = true;
            }

            if (e.KeyCode == Keys.S)
            {
                secondPlayerDown = true;
            }

            if (e.KeyCode == Keys.Up)
            {
                goUp = true;
            }

            if (e.KeyCode == Keys.W)
            {
                secondPlayerUp = true;
            }

            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

            if (e.KeyCode == Keys.Space)
            {
                gameTimer.Enabled = false;
                paused = true;
            }

            if (e.KeyCode != Keys.Space)
            {
                gameTimer.Enabled = true;
                paused = false;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }

            if (e.KeyCode == Keys.S)
            {
                secondPlayerDown = false;
            }

            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }

            if (e.KeyCode == Keys.W)
            {
                secondPlayerUp = false;
            }
        }

        private void timerTick(object sender, EventArgs e)
        {
            Player1Score.Text = "" + score1;
            Player2Score.Text = "" + score2;
            double progressPercent = ((counter % 500) / (double)500)  * 100;
            label3.Text = "Level " + level + ", progress to reach next level: "+ progressPercent + " %";
            Ball.Top -= bally;
            Ball.Left -= ballx;
            counter++;

            if ( counter % 500 == 0)
            {
                level++;
                ballx -= 3;
                MessageBox.Show("You got a gift, speed decreased");
            } else if (counter % 150 == 0)
            {
                ballx += 2;
            }

            if (Ball.Left < 0)
            {
                Ball.Left = 434;
                ballx = -ballx;
                //ballx -= 2;
            }

            if (Ball.Left + Ball.Width > ClientSize.Width)
            {
                Ball.Left = 434;
                ballx = -ballx;
            }

            if (Ball.Top < 95 || Ball.Top + Ball.Height > 480)
            {
                bally = -bally;
            }

            if (Ball.Bounds.IntersectsWith(Player1.Bounds))
            {
                ballx = -ballx;
                score1++;
            }

            if (Ball.Bounds.IntersectsWith(Player2.Bounds))
            {
                ballx = -ballx;
                score2++;
            }

            if (goUp == true && Player1.Top > 0)
            {
                Player1.Top -= 8;
            }

            if (secondPlayerUp == true && Player2.Top > 0)
            {
                Player2.Top -= 8;
            }

            if (goDown == true && Player1.Top < 450)
            {
                Player1.Top += 8;
            }

            if (secondPlayerDown == true && Player2.Top < 450)
            {
                Player2.Top += 8;
            }

            if (score1 > 25)
            {
                gameTimer.Stop();
                MessageBox.Show("First Player won! Your score is " + score1);
            }

            if (score2 > 25)
            {
                gameTimer.Stop();
                MessageBox.Show("Second Player won! Your score is " + score2);
            }
        }

    }
}
