using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace meowseek
{
    public partial class pong : Form
    {
        private bool goup;
        private bool godown;
        private int speed = 5;
        private int ballx = 5;
        private int bally = 5;
        private int score = 0;
        private int cpuPoint = 0;

        public pong()
        {
            InitializeComponent();
        }

        //stops player moving
        private void pong_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                goup = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                godown = false;
            }
        }

        //checks collision, win and lose
        private void gametimer_Tick(object sender, EventArgs e)
        {
            playerscore.Text = "" + score;
            cpuscore.Text = "" + cpuPoint;
            ball.Top -= bally;
            ball.Left -= ballx;
            cpu.Top += speed;

            if (score < 5)
            {
                if (cpu.Top < 0 || cpu.Top > 455)
                {
                    speed = -speed;
                }
            }
            else
            {
                cpu.Top = ball.Top + 30;
            }
            if (ball.Left < 0)
            {
                ball.Left = 434;
                ballx = -ballx;
                ballx -= 2;
                cpuPoint++;
            }

            if (ball.Left + ball.Width > ClientSize.Width)
            {
                ball.Left = 434;
                ballx = -ballx;
                ballx += 2;
                score++;
            }

            if (ball.Top < 0 || ball.Top + ball.Height > ClientSize.Height)
            {
                bally = -bally;
            }
            if (ball.Bounds.IntersectsWith(player.Bounds) || ball.Bounds.IntersectsWith(cpu.Bounds))
            {
                ballx = -ballx;
            }

            if (goup == true && player.Top > 0)
            {
                player.Top -= 8;
            }

            if (godown == true && player.Top < 455)
            {
                player.Top += 8;
            }

            if (score > 20)
            {
                gametimer.Stop();
                MessageBox.Show("You are the best", "you win", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

            if (cpuPoint > 20)
            {
                gametimer.Stop();
                MessageBox.Show("you lose L boso", "you lose", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        //makes player move
        private void pong_keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                goup = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                godown = true;
            }
        }

    }
}

