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
        int score = 5;
        public void Game()
        {
            buttonExit.Enabled = true;
            buttonExit.Visible = false;
            buttonPlay.Enabled = true;
            buttonPlay.Visible = false;
            scoreLabel.Visible = true;
            ball.Visible = true;
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
            if(score<0)
            {
                labelLose.Visible = true;
                ball.Visible = false;
                timer.Enabled = false;            
                buttonExit.Enabled = true;
                buttonExit.Visible = true;
                buttonPlay.Enabled = true;
                buttonPlay.Visible = true;
                return;
            }     

            Random rand = new Random();
            ball.Top = rand.Next(100, 400);
            ball.Left = rand.Next(100, 600);
            score -= 1;
            scoreLabel.Text = $"Score: {score}";

        }

        private void ball_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            ball.Top = rand.Next(100, 400);
            ball.Left = rand.Next(100, 600);
            score += 1;
            scoreLabel.Text = $"Score: {score}";
            timer.Enabled = false;
            timer.Enabled = true;

        }
        //private void buttonExit(object sender, EventArgs e)
        //{
        //    Close();
        //}

    }
}
