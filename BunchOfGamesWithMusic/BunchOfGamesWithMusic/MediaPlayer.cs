using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;//aggiunto

namespace BunchOfGamesWithMusic
{
    public partial class MediaPlayer : Form
    {
        List<string> filteredFiles = new List<string>();
        FolderBrowserDialog browser = new FolderBrowserDialog();
        int CurrentFile = 0;
        public MediaPlayer()
        {
            InitializeComponent();
        }

        private void LoadFolderEvent(object sender, EventArgs e)
        {
            MusicPlayer.Ctlcontrols.stop();
            if (filteredFiles.Count > 1)
            {
                filteredFiles.Clear();
                filteredFiles = null;
                PlayList.Items.Clear();
                CurrentFile = 0;
            }
            DialogResult result = browser.ShowDialog();
            if (result == DialogResult.OK)
            {
                filteredFiles = Directory.GetFiles(browser.SelectedPath, "*.*").Where(file => file.ToLower().EndsWith("webm") || file.ToLower().EndsWith("mp4") || file.ToLower().EndsWith("wmv") || file.ToLower().EndsWith("mkv") || file.ToLower().EndsWith("avi") || file.ToLower().EndsWith("mp3")).ToList();
                LoadPlayList();
            }
        }

        private void PlaychangeEvent(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 0)
            {
                // undefined loaded
                Duration.Text = "Media Player is Ready to be loaded";
            }
            else if (e.newState == 1)
            {
                // if the file is stopped 
                Duration.Text = "Media Player stopped";
            }
            else if (e.newState == 3)
            {
                // if the file is playing 
                Duration.Text = "Duration: " + MusicPlayer.currentMedia.durationString;
            }
            else if (e.newState == 8)
            {
                // media has ended here
                if (CurrentFile >= filteredFiles.Count - 1)
                {
                    CurrentFile = 0;
                }
                else
                {
                    CurrentFile += 1;
                }
                PlayList.SelectedIndex = CurrentFile;
                ShowFileName(FileName);
            }
            else if (e.newState == 9)
            {
                // if the media player is loading new video
                Duration.Text = "Loading new video";
            }
            else if (e.newState == 10)
            {
                // media is ready to play again
                timer1.Start();
            }
        }
        private void TimerEvent(object sender, EventArgs e)
        {
            MusicPlayer.Ctlcontrols.play();
            timer1.Stop();
        }
        private void LoadPlayList()
        {
            MusicPlayer.currentPlaylist = MusicPlayer.newPlaylist("PlayList", "");
            foreach (string videos in filteredFiles)
            {
                MusicPlayer.currentPlaylist.appendItem(MusicPlayer.newMedia(videos));
                PlayList.Items.Add(videos);
            }
            if (filteredFiles.Count > 0)
            {
                FileName.Text = "Files Found " + filteredFiles.Count;
                PlayList.SelectedIndex = CurrentFile;
                PlayFile(PlayList.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("No Video Files Found in this folder");
            }
        }
        private void PlayFile(string url)
        {
            MusicPlayer.URL = url;
        }
        private void ShowFileName(Label name)
        {
            string file = Path.GetFileName(PlayList.SelectedItem.ToString());
            name.Text = "Currently Playing: " + file;
        }

        private void Duration_Click(object sender, EventArgs e)
        {

        }

        private void Play_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentFile = PlayList.SelectedIndex;
            PlayFile(PlayList.SelectedItem.ToString());
            ShowFileName(FileName);
        }

        private void MusicPlayer_Enter(object sender, EventArgs e)
        {

        }

        private void inserisciToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
