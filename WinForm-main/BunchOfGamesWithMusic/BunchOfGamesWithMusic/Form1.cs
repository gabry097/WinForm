using System.Text.Json;
using Newtonsoft.Json;

namespace BunchOfGamesWithMusic
{
    public partial class Luncher : Form
    {
        public Luncher()
        {
            InitializeComponent();
        }
        private Button flappyBirdss;
        private Button Media_Playerr;
        private Button main_game;
        private string _jsonData;
        private string _jsonData1;

        private void InitializeComponent()
        {
            flappyBirdss = new Button();
            Media_Playerr = new Button();
            main_game = new Button();
            quit = new Button();
            SuspendLayout();
            // 
            // flappyBirdss
            // 
            flappyBirdss.Location = new Point(59, 68);
            flappyBirdss.Name = "flappyBirdss";
            flappyBirdss.Size = new Size(133, 23);
            flappyBirdss.TabIndex = 0;
            flappyBirdss.Text = "flappy Birds";
            flappyBirdss.UseVisualStyleBackColor = true;
            flappyBirdss.Click += flappyBirdss_Click;
            // 
            // Media_Playerr
            // 
            Media_Playerr.Location = new Point(304, 321);
            Media_Playerr.Name = "Media_Playerr";
            Media_Playerr.Size = new Size(150, 23);
            Media_Playerr.TabIndex = 1;
            Media_Playerr.Text = "media player";
            Media_Playerr.UseVisualStyleBackColor = true;
            Media_Playerr.Click += Media_Playerr_Click;
            // 
            // main_game
            // 
            main_game.BackColor = Color.White;
            main_game.Location = new Point(557, 68);
            main_game.Name = "main_game";
            main_game.Size = new Size(166, 23);
            main_game.TabIndex = 2;
            main_game.Text = "DinoRun_";
            main_game.UseVisualStyleBackColor = false;
            main_game.Click += main_game_Click;
            // 
            // quit
            // 
            quit.Font = new Font("Swis721 BdOul BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            quit.Location = new Point(237, 521);
            quit.Name = "quit";
            quit.Size = new Size(290, 40);
            quit.TabIndex = 3;
            quit.Text = "Quit";
            quit.UseVisualStyleBackColor = true;
            quit.Click += quit_Click;
            // 
            // Luncher
            // 
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(827, 599);
            Controls.Add(quit);
            Controls.Add(main_game);
            Controls.Add(Media_Playerr);
            Controls.Add(flappyBirdss);
            Name = "Luncher";
            ResumeLayout(false);
        }

        private void flappyBirdss_Click(object sender, EventArgs e)
        {
            FloppyBirdLikeGames floppyBirdLikeGames = new FloppyBirdLikeGames();
            floppyBirdLikeGames.ShowDialog();
        }

        private void Media_Playerr_Click(object sender, EventArgs e)
        {
            MediaPlayer mediaPlayer = new MediaPlayer();
            mediaPlayer.ShowDialog();
        }

        private void main_game_Click(object sender, EventArgs e)
        {
            MainGames mainGames = new MainGames();
            mainGames.ShowDialog();
        }

        private void ScoreMain_Click(object sender, EventArgs e)
        {

        }

        private Button quit;

        private void quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
