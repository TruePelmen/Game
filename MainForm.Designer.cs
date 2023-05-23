
namespace Game
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.scoreLabel = new System.Windows.Forms.Label();
            this.labelLose = new System.Windows.Forms.Label();
            this.ball = new System.Windows.Forms.PictureBox();
            this.blackball = new System.Windows.Forms.PictureBox();
            this.blueball = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueball)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPlay
            // 
            this.buttonPlay.AllowDrop = true;
            this.buttonPlay.Location = new System.Drawing.Point(271, 136);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(141, 66);
            this.buttonPlay.TabIndex = 0;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonExit.Location = new System.Drawing.Point(432, 136);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(141, 66);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(93, 44);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(61, 20);
            this.scoreLabel.TabIndex = 2;
            this.scoreLabel.Text = "Score: 0";
            // 
            // labelLose
            // 
            this.labelLose.AutoSize = true;
            this.labelLose.Location = new System.Drawing.Point(380, 91);
            this.labelLose.Name = "labelLose";
            this.labelLose.Size = new System.Drawing.Size(80, 20);
            this.labelLose.TabIndex = 3;
            this.labelLose.Text = "You lost =(";
            // 
            // ball
            // 
            this.ball.Image = global::Game.Properties.Resources.Red_Ball_PNG;
            this.ball.Location = new System.Drawing.Point(476, 91);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(46, 37);
            this.ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ball.TabIndex = 4;
            this.ball.TabStop = false;
            this.ball.Click += new System.EventHandler(this.ball_Click);
            // 
            // blackball
            // 
            this.blackball.Image = global::Game.Properties.Resources.Red_Ball_PNG__1_;
            this.blackball.Location = new System.Drawing.Point(528, 91);
            this.blackball.Name = "blackball";
            this.blackball.Size = new System.Drawing.Size(46, 37);
            this.blackball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.blackball.TabIndex = 5;
            this.blackball.TabStop = false;
            this.blackball.Click += new System.EventHandler(this.blackball_Click);
            // 
            // blueball
            // 
            this.blueball.Image = global::Game.Properties.Resources.BlueBall_PNG___Copy;
            this.blueball.Location = new System.Drawing.Point(580, 91);
            this.blueball.Name = "blueball";
            this.blueball.Size = new System.Drawing.Size(46, 37);
            this.blueball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.blueball.TabIndex = 6;
            this.blueball.TabStop = false;
            this.blueball.Click += new System.EventHandler(this.blueball_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(846, 484);
            this.Controls.Add(this.blueball);
            this.Controls.Add(this.blackball);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.labelLose);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonPlay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueball)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label labelLose;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox blackball;
        private System.Windows.Forms.PictureBox blueball;
    }
}

