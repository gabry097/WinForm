using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace BunchOfGamesWithMusic
{
    public partial class FloppyBirdLikeGames : Form
    {
        int pipeSpeed = 8;
        int gravity = 15;
        int score = 0;
        Point point = new Point();
        public FloppyBirdLikeGames()
        {
            InitializeComponent();
            point = flp.Location;
        }

        private void gameTimerEvents(object sender, EventArgs e)
        {
            flp.Top += gravity;



            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            ScoreText.Text = "Score: " + score;
            if (pipeBottom.Left < -150)
            {

                pipeBottom.Left = 800;
                score++;
            }
            if (pipeTop.Left < -180)
            {

                pipeTop.Left = 950;
                score++;
            }

            if (flp.Bounds.IntersectsWith(pipeBottom.Bounds) ||
                flp.Bounds.IntersectsWith(pipeTop.Bounds) ||
                flp.Bounds.IntersectsWith(ground.Bounds) || flp.Top < -25
                )
            {

                endGame();
            }

            if (score > 5)
            {
                pipeSpeed = 15;
            }
        }

        private void Gamekeydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -15;
            }
        }

        private void Gamekeyup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 15;

            }
        }
        private void endGame()
        {
            gameTimer.Stop();
            ScoreText.Text += " Game over!!!";
            restart.Visible=true;
            quit.Visible=true;
            restart.Enabled = true;
            quit.Enabled = true;
        }

        private void restart_Click(object sender, EventArgs e)
        {
            flp.Location = point;
            score = 0;
            gameTimer.Start();
            Thread.Sleep(2000);
        }

        private void FloppyBirdLikeGames_Load(object sender, EventArgs e)
        {

        }

        private void flappyBird_Click(object sender, EventArgs e)
        {

        }

        private void Quittare(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
