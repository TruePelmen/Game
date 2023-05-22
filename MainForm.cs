using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class MainForm : Form
    {
        bool ckeck_for_click = false;
        int score = 5;
        public void Game()
        {
            buttonExit.Enabled = true;
            buttonExit.Visible = false;
            buttonPlay.Enabled = false;
            buttonPlay.Visible = false;
            scoreLabel.Visible = true;
            blackball.Top = -100;
            blueball.Top = -100;
            ball.Top = -100;
            ball.Visible = true;
            blackball.Visible = true;
            blueball.Visible = true;
            score = 5;
            Random rand = new Random();
            ball.Top = rand.Next(100, 400);
            timer.Enabled = true;
        }
        public MainForm()
        {
            InitializeComponent();
            labelLose.Visible = false;
            scoreLabel.Visible = false;
            ball.Visible = false;
            blackball.Visible = false;
            blueball.Visible = false;
            scoreLabel.Text = $"Score: {score}";
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            labelLose.Visible = false;
            Game();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
                        
            if(ckeck_for_click == false) score -= 1;
            scoreLabel.Text = $"Score: {score}";
            ckeck_for_click = false;
            if(timer.Interval>=100) timer.Interval -= 20;
            if (score<0)
            {
                labelLose.Visible = true;
                ball.Visible = false;
                timer.Enabled = false;            
                buttonExit.Enabled = true;
                buttonExit.Visible = true;
                buttonPlay.Enabled = true;
                buttonPlay.Visible = true;
                blueball.Visible = false;
                blackball.Visible = false;
                return;
            }     
            Random rand = new Random();            
            int bl = rand.Next(1, 4);
            switch(bl)
            {
                case 1:            
                    ball.Top = rand.Next(100, 400);
                    ball.Left = rand.Next(100, 600);
                    blueball.Top = -100;
                    blackball.Top = -100;
                    break;
                case 2:
                    blackball.Top = rand.Next(100, 400);
                    blackball.Left = rand.Next(100, 600);
                    blueball.Top = -100;
                    ball.Top = -100;
                    break;
                case 3:
                    blueball.Top = rand.Next(100, 400);
                    blueball.Left = rand.Next(100, 600);
                    blackball.Top = -100;
                    ball.Top = -100;
                    break;
            }

        }

        private void ball_Click(object sender, EventArgs e)
        {
            ball.Top = -100;
            blueball.Top = -100;
            blackball.Top = -100;
            score += 1;
            scoreLabel.Text = $"Score: {score}";
            ckeck_for_click = true;
            //timer.Enabled = false;
            //timer.Enabled = true;
            timer.Stop();
            timer.Start();

        }

        private void blackball_Click(object sender, EventArgs e)
        {
            ball.Top = -100;
            blueball.Top = -100;
            blackball.Top = -100;
            score += 5;
            scoreLabel.Text = $"Score: {score}";
            ckeck_for_click = true;
            //timer.Enabled = false;
            //timer.Enabled = true;
            timer.Stop();
            timer.Start();

        }

        private void blueball_Click(object sender, EventArgs e)
        {
            ball.Top = -100;
            blueball.Top = -100;
            blackball.Top = -100;
            score -= 10;
            scoreLabel.Text = $"Score: {score}";
            ckeck_for_click = true;
            //timer.Enabled = false;
            //timer.Enabled = true;
            timer.Stop();
            timer.Start();
        }
        //private void buttonExit(object sender, EventArgs e)
        //{
        //    Close();
        //}

    }
}
