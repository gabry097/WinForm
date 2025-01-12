namespace BunchOfGamesWithMusic
{
    partial class MediaPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MediaPlayer));
            menuStrip1 = new MenuStrip();
            inserisciToolStripMenuItem = new ToolStripMenuItem();
            caricaCartellaToolStripMenuItem = new ToolStripMenuItem();
            MusicPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            PlayList1 = new ListBox();
            FileName = new Label();
            Duration = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            Play_List = new ListBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MusicPlayer).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { inserisciToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(980, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // inserisciToolStripMenuItem
            // 
            inserisciToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { caricaCartellaToolStripMenuItem });
            inserisciToolStripMenuItem.Name = "inserisciToolStripMenuItem";
            inserisciToolStripMenuItem.Size = new Size(61, 20);
            inserisciToolStripMenuItem.Text = "Inserisci";
            inserisciToolStripMenuItem.Click += inserisciToolStripMenuItem_Click;
            // 
            // caricaCartellaToolStripMenuItem
            // 
            caricaCartellaToolStripMenuItem.Name = "caricaCartellaToolStripMenuItem";
            caricaCartellaToolStripMenuItem.Size = new Size(180, 22);
            caricaCartellaToolStripMenuItem.Text = "Carica Cartella";
            caricaCartellaToolStripMenuItem.Click += LoadFolderEvent;
            // 
            // MusicPlayer
            // 
            MusicPlayer.Enabled = true;
            MusicPlayer.Location = new Point(0, 27);
            MusicPlayer.Name = "MusicPlayer";
            MusicPlayer.OcxState = (AxHost.State)resources.GetObject("MusicPlayer.OcxState");
            MusicPlayer.Size = new Size(673, 451);
            MusicPlayer.TabIndex = 1;
            MusicPlayer.PlayStateChange += PlaychangeEvent;
            MusicPlayer.Enter += MusicPlayer_Enter;
            // 
            // PlayList1
            // 
            PlayList1.Location = new Point(0, 0);
            PlayList1.Name = "PlayList1";
            PlayList1.Size = new Size(120, 96);
            PlayList1.TabIndex = 0;
            // 
            // FileName
            // 
            FileName.AutoSize = true;
            FileName.Location = new Point(1, 480);
            FileName.Name = "FileName";
            FileName.Size = new Size(60, 15);
            FileName.TabIndex = 3;
            FileName.Text = "File Name";
            // 
            // Duration
            // 
            Duration.AutoSize = true;
            Duration.Location = new Point(679, 483);
            Duration.Name = "Duration";
            Duration.Size = new Size(65, 15);
            Duration.TabIndex = 4;
            Duration.Text = "Duration: 0";
            Duration.Click += Duration_Click;
            // 
            // timer1
            // 
            timer1.Tick += TimerEvent;
            // 
            // Play_List
            // 
            Play_List.FormattingEnabled = true;
            Play_List.ItemHeight = 15;
            Play_List.Location = new Point(679, 26);
            Play_List.Name = "Play_List";
            Play_List.Size = new Size(289, 454);
            Play_List.TabIndex = 5;
            Play_List.SelectedIndexChanged += Play_List_SelectedIndexChanged;
            // 
            // MediaPlayer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 566);
            Controls.Add(Play_List);
            Controls.Add(Duration);
            Controls.Add(FileName);
            Controls.Add(MusicPlayer);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MediaPlayer";
            Text = "MediaPlayer";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MusicPlayer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem inserisciToolStripMenuItem;
        private ToolStripMenuItem caricaCartellaToolStripMenuItem;
        private AxWMPLib.AxWindowsMediaPlayer MusicPlayer;
        private ListBox PlayList;
        private Label FileName;
        private Label Duration;
        private System.Windows.Forms.Timer timer1;
        private ListBox PlayList1;
        private ListBox Play_List;
    }
}