namespace BunchOfGamesWithMusic
{
    partial class FloppyBirdLikeGames
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FloppyBirdLikeGames));
            pipeTop = new PictureBox();
            pipeBottom = new PictureBox();
            ground = new PictureBox();
            ScoreText = new Label();
            flappyBird = new PictureBox();
            gameTimer = new System.Windows.Forms.Timer(components);
            restart = new Label();
            flp = new Panel();
            quit = new Label();
            ((System.ComponentModel.ISupportInitialize)pipeTop).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipeBottom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ground).BeginInit();
            ((System.ComponentModel.ISupportInitialize)flappyBird).BeginInit();
            flp.SuspendLayout();
            SuspendLayout();
            // 
            // pipeTop
            // 
            pipeTop.Image = (Image)resources.GetObject("pipeTop.Image");
            pipeTop.Location = new Point(649, -8);
            pipeTop.Name = "pipeTop";
            pipeTop.Size = new Size(139, 163);
            pipeTop.SizeMode = PictureBoxSizeMode.CenterImage;
            pipeTop.TabIndex = 0;
            pipeTop.TabStop = false;
            // 
            // pipeBottom
            // 
            pipeBottom.BackColor = Color.FromArgb(0, 192, 192);
            pipeBottom.Image = (Image)resources.GetObject("pipeBottom.Image");
            pipeBottom.Location = new Point(484, 355);
            pipeBottom.Name = "pipeBottom";
            pipeBottom.Size = new Size(138, 355);
            pipeBottom.SizeMode = PictureBoxSizeMode.CenterImage;
            pipeBottom.TabIndex = 2;
            pipeBottom.TabStop = false;
            // 
            // ground
            // 
            ground.Image = (Image)resources.GetObject("ground.Image");
            ground.Location = new Point(-26, 679);
            ground.Name = "ground";
            ground.Size = new Size(872, 235);
            ground.SizeMode = PictureBoxSizeMode.StretchImage;
            ground.TabIndex = 3;
            ground.TabStop = false;
            // 
            // ScoreText
            // 
            ScoreText.AutoSize = true;
            ScoreText.Font = new Font("Stencil", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ScoreText.Location = new Point(12, 3);
            ScoreText.Name = "ScoreText";
            ScoreText.Size = new Size(104, 22);
            ScoreText.TabIndex = 4;
            ScoreText.Text = "Score : 0";
            // 
            // flappyBird
            // 
            flappyBird.BackColor = Color.FromArgb(0, 192, 192);
            flappyBird.Image = (Image)resources.GetObject("flappyBird.Image");
            flappyBird.Location = new Point(0, 0);
            flappyBird.Name = "flappyBird";
            flappyBird.Size = new Size(65, 63);
            flappyBird.SizeMode = PictureBoxSizeMode.CenterImage;
            flappyBird.TabIndex = 5;
            flappyBird.TabStop = false;
            flappyBird.Click += flappyBird_Click;
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Interval = 20;
            gameTimer.Tick += gameTimerEvents;
            // 
            // restart
            // 
            restart.AutoSize = true;
            restart.BackColor = Color.White;
            restart.Enabled = false;
            restart.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            restart.Location = new Point(360, 785);
            restart.Name = "restart";
            restart.Size = new Size(83, 21);
            restart.TabIndex = 6;
            restart.Text = "restartare";
            restart.Visible = false;
            restart.Click += restart_Click;
            // 
            // flp
            // 
            flp.Controls.Add(flappyBird);
            flp.Location = new Point(144, 198);
            flp.Name = "flp";
            flp.Size = new Size(65, 63);
            flp.TabIndex = 7;
            // 
            // quit
            // 
            quit.AutoSize = true;
            quit.BackColor = Color.White;
            quit.Enabled = false;
            quit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            quit.Location = new Point(468, 785);
            quit.Name = "quit";
            quit.Size = new Size(43, 21);
            quit.TabIndex = 8;
            quit.Text = "Quit";
            quit.Visible = false;
            quit.Click += Quittare;
            // 
            // FloppyBirdLikeGames
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(793, 873);
            Controls.Add(quit);
            Controls.Add(flp);
            Controls.Add(restart);
            Controls.Add(ScoreText);
            Controls.Add(pipeBottom);
            Controls.Add(pipeTop);
            Controls.Add(ground);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FloppyBirdLikeGames";
            Text = "FloppyBirdLikeGames";
            Load += FloppyBirdLikeGames_Load;
            KeyDown += Gamekeydown;
            KeyUp += Gamekeyup;
            ((System.ComponentModel.ISupportInitialize)pipeTop).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipeBottom).EndInit();
            ((System.ComponentModel.ISupportInitialize)ground).EndInit();
            ((System.ComponentModel.ISupportInitialize)flappyBird).EndInit();
            flp.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pipeTop;
        private PictureBox pipeBottom;
        private PictureBox ground;
        private Label ScoreText;
        private PictureBox flappyBird;
        private System.Windows.Forms.Timer gameTimer;
        private Label restart;
        private Panel flp;
        private Label quit;
    }
}