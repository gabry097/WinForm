namespace BunchOfGamesWithMusic
{
    partial class MainGames
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
            pictureBox5 = new PictureBox();
            pictureBox3 = new PictureBox();
            trex = new PictureBox();
            txtScore = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trex).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.obstacle_2;
            pictureBox5.Location = new Point(405, 373);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(32, 33);
            pictureBox5.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox5.TabIndex = 0;
            pictureBox5.TabStop = false;
            pictureBox5.Tag = "obstacle";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.obstacle_1;
            pictureBox3.Location = new Point(733, 360);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(23, 46);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            pictureBox3.Tag = "obstacle";
            // 
            // trex
            // 
            trex.Image = Properties.Resources.running;
            trex.Location = new Point(60, 363);
            trex.Name = "trex";
            trex.Size = new Size(40, 43);
            trex.SizeMode = PictureBoxSizeMode.AutoSize;
            trex.TabIndex = 4;
            trex.TabStop = false;
            // 
            // txtScore
            // 
            txtScore.AutoSize = true;
            txtScore.Font = new Font("Swis721 BdOul BT", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtScore.Location = new Point(12, 9);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(94, 25);
            txtScore.TabIndex = 5;
            txtScore.Text = "Score: 0";
            // 
            // gameTimer
            // 
            gameTimer.Interval = 20;
            gameTimer.Tick += MainGameTimerEvent;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Location = new Point(-6, 406);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(811, 55);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // MainGames
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(txtScore);
            Controls.Add(trex);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox5);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "MainGames";
            Text = "DinoJump";
            KeyDown += keyisdown;
            KeyUp += keyisup;
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)trex).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox5;
        private PictureBox pictureBox3;
        private PictureBox trex;
        private Label txtScore;
        private System.Windows.Forms.Timer gameTimer;
        private PictureBox pictureBox1;
    }
}