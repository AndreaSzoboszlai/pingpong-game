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

            if (e.KeyCode == Keys.Up)
            {
                goUp = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
        }

        private void timerTick(object sender, EventArgs e)
        {
            Player1Score.Text = "" + score1;
            Player2Score.Text = "" + score2;
            Ball.Top -= bally;
            Ball.Left -= ballx;
            Player2.Top += speed;

            if (score1 < 5)
            {
                if (Player2.Top < 0 || Player2.Top > 455)
                {
                    speed = -speed;
                }
            }
            else
            {
                Player2.Top = Ball.Top + 30;
            }

            if (Ball.Left < 0)
            {
                Ball.Left = 434;
                ballx = -ballx;
                ballx -= 2;
                score2++;
            }

            if (Ball.Left + Ball.Width > ClientSize.Width)
            {
                Ball.Left = 434;
                ballx = -ballx;
                ballx += 2;
                score1++;
            }

            if (Ball.Top < 95 || Ball.Top + Ball.Height > 480)
            {
                bally = -bally;
            }

            if (Ball.Bounds.IntersectsWith(Player1.Bounds) || Ball.Bounds.IntersectsWith(Player2.Bounds))
            {
                ballx = -ballx;
            }

            if (goUp == true && Player1.Top > 0)
            {
                Player1.Top -= 8;
            }

            if (goDown == true && Player1.Top < 450)
            {
                Player1.Top += 8;
            }

            if (score1 > 10)
            {
                gameTimer.Stop();
                MessageBox.Show("You won!");
            }

            if (score2 > 10)
            {
                gameTimer.Stop();
                MessageBox.Show("You Lost!");
            }
        }

    }
}
