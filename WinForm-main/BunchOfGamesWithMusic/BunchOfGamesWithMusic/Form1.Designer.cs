namespace BunchOfGamesWithMusic
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
       

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MediaPlayerButton = new Button();
            FloppyBird = new Button();
            MainGame = new Button();
            TopScore = new Label();
            TopScoreMainGame = new Label();

            // 
            // MediaPlayerButton
            // 
            MediaPlayerButton.Location = new Point(44, 12);
            MediaPlayerButton.Name = "MediaPlayerButton";
            MediaPlayerButton.Size = new Size(118, 23);
            MediaPlayerButton.TabIndex = 0;
            MediaPlayerButton.Text = "Media Player";
            MediaPlayerButton.UseVisualStyleBackColor = true;

            // 
            // FloppyBird
            // 
            FloppyBird.Location = new Point(44, 96);
            FloppyBird.Name = "FloppyBird";
            FloppyBird.Size = new Size(119, 23);
            FloppyBird.TabIndex = 1;
            FloppyBird.Text = "Floppy Birds";
            FloppyBird.UseVisualStyleBackColor = true;

            // 
            // MainGame
            // 
            MainGame.Location = new Point(45, 182);
            MainGame.Name = "MainGame";
            MainGame.Size = new Size(118, 23);
            MainGame.TabIndex = 2;
            MainGame.Text = "Vero gioco";
            MainGame.UseVisualStyleBackColor = true;
 
            // 
            // TopScore
            // 
            TopScore.AutoSize = true;
            TopScore.Location = new Point(180, 100);
            TopScore.Name = "TopScore";
            TopScore.Size = new Size(70, 15);
            TopScore.TabIndex = 3;
            TopScore.Text = "Top Score: 0";
            // 
            // TopScoreMainGame
            // 
            TopScoreMainGame.AutoSize = true;
            TopScoreMainGame.Location = new Point(180, 186);
            TopScoreMainGame.Name = "TopScoreMainGame";
            TopScoreMainGame.Size = new Size(70, 15);
            TopScoreMainGame.TabIndex = 4;
            TopScoreMainGame.Text = "Top Score: 0";
            // 
            // Form1
            // 
            
        }

        #endregion

        private Button MediaPlayerButton;
        private Button FloppyBird;
        private Button MainGame;
        private Label TopScore;
        private Label TopScoreMainGame;
    }
}
