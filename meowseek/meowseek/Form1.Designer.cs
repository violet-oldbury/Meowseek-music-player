namespace meowseek
{
    partial class meowseek
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(meowseek));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnufile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMisc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnucalc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnupong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnumode = new System.Windows.Forms.ToolStripMenuItem();
            this.closex = new System.Windows.Forms.Label();
            this.songs = new System.Windows.Forms.ListBox();
            this.minibutton = new System.Windows.Forms.Label();
            this.filebox = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.volumep = new System.Windows.Forms.Label();
            this.playpause = new System.Windows.Forms.Button();
            this.timebar = new System.Windows.Forms.TrackBar();
            this.volumebar = new System.Windows.Forms.TrackBar();
            this.timerplayback = new System.Windows.Forms.Timer(this.components);
            this.songtime = new System.Windows.Forms.Label();
            this.movebox = new System.Windows.Forms.PictureBox();
            this.fullscreen = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.paradigmbox = new System.Windows.Forms.PictureBox();
            this.musicplayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu2shuffle = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timebar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumebar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullscreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paradigmbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicplayer)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.WindowText;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnufile,
            this.mnuMisc});
            this.menuStrip1.Location = new System.Drawing.Point(9, 9);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(108, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnufile
            // 
            this.mnufile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpen,
            this.toolStripMenuItem1,
            this.mnuQuit});
            this.mnufile.Font = new System.Drawing.Font("ByteBounce", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnufile.ForeColor = System.Drawing.SystemColors.Window;
            this.mnufile.Name = "mnufile";
            this.mnufile.Size = new System.Drawing.Size(46, 20);
            this.mnufile.Text = "file";
            this.mnufile.ToolTipText = "file tool bar";
            // 
            // mnuOpen
            // 
            this.mnuOpen.BackColor = System.Drawing.SystemColors.Window;
            this.mnuOpen.ForeColor = System.Drawing.SystemColors.WindowText;
            this.mnuOpen.Name = "mnuOpen";
            this.mnuOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnuOpen.Size = new System.Drawing.Size(164, 22);
            this.mnuOpen.Text = "open";
            this.mnuOpen.Click += new System.EventHandler(this.mnuOpen_Click_1);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.SystemColors.WindowText;
            this.toolStripMenuItem1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(161, 6);
            // 
            // mnuQuit
            // 
            this.mnuQuit.BackColor = System.Drawing.SystemColors.Window;
            this.mnuQuit.ForeColor = System.Drawing.SystemColors.WindowText;
            this.mnuQuit.Name = "mnuQuit";
            this.mnuQuit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.mnuQuit.Size = new System.Drawing.Size(164, 22);
            this.mnuQuit.Text = "quit";
            this.mnuQuit.Click += new System.EventHandler(this.mnuQuit_Click_1);
            // 
            // mnuMisc
            // 
            this.mnuMisc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnucalc,
            this.mnupong,
            this.mnumode});
            this.mnuMisc.Font = new System.Drawing.Font("ByteBounce", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuMisc.ForeColor = System.Drawing.SystemColors.Window;
            this.mnuMisc.Name = "mnuMisc";
            this.mnuMisc.Size = new System.Drawing.Size(54, 20);
            this.mnuMisc.Text = "misc";
            this.mnuMisc.ToolTipText = "miscellaneous things";
            // 
            // mnucalc
            // 
            this.mnucalc.Name = "mnucalc";
            this.mnucalc.Size = new System.Drawing.Size(156, 22);
            this.mnucalc.Text = "calculator";
            this.mnucalc.Click += new System.EventHandler(this.calculatorToolStripMenuItem_Click);
            // 
            // mnupong
            // 
            this.mnupong.Name = "mnupong";
            this.mnupong.Size = new System.Drawing.Size(156, 22);
            this.mnupong.Text = "pong";
            this.mnupong.Click += new System.EventHandler(this.pongToolStripMenuItem_Click);
            // 
            // mnumode
            // 
            this.mnumode.Name = "mnumode";
            this.mnumode.Size = new System.Drawing.Size(156, 22);
            this.mnumode.Text = "light mode";
            this.mnumode.Click += new System.EventHandler(this.lightModeToolStripMenuItem_Click);
            // 
            // closex
            // 
            this.closex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closex.AutoSize = true;
            this.closex.ForeColor = System.Drawing.SystemColors.Window;
            this.closex.Location = new System.Drawing.Point(776, 9);
            this.closex.Name = "closex";
            this.closex.Size = new System.Drawing.Size(14, 13);
            this.closex.TabIndex = 2;
            this.closex.Text = "X";
            this.closex.Click += new System.EventHandler(this.closex_Click);
            // 
            // songs
            // 
            this.songs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.songs.BackColor = System.Drawing.SystemColors.WindowText;
            this.songs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.songs.Font = new System.Drawing.Font("ByteBounce", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songs.ForeColor = System.Drawing.SystemColors.Window;
            this.songs.FormattingEnabled = true;
            this.songs.Location = new System.Drawing.Point(12, 36);
            this.songs.Name = "songs";
            this.songs.Size = new System.Drawing.Size(120, 407);
            this.songs.TabIndex = 3;
            this.songs.SelectedIndexChanged += new System.EventHandler(this.songs_SelectedIndexChanged_1);
            // 
            // minibutton
            // 
            this.minibutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minibutton.AutoSize = true;
            this.minibutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.minibutton.Location = new System.Drawing.Point(730, 9);
            this.minibutton.Name = "minibutton";
            this.minibutton.Size = new System.Drawing.Size(22, 13);
            this.minibutton.TabIndex = 6;
            this.minibutton.Text = "-----";
            this.minibutton.Click += new System.EventHandler(this.minibutton_Click);
            // 
            // filebox
            // 
            this.filebox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filebox.BackColor = System.Drawing.SystemColors.WindowText;
            this.filebox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filebox.Font = new System.Drawing.Font("ByteBounce", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filebox.ForeColor = System.Drawing.SystemColors.Window;
            this.filebox.FormattingEnabled = true;
            this.filebox.Location = new System.Drawing.Point(136, 36);
            this.filebox.Name = "filebox";
            this.filebox.Size = new System.Drawing.Size(654, 303);
            this.filebox.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.volumep);
            this.panel1.Controls.Add(this.playpause);
            this.panel1.Controls.Add(this.timebar);
            this.panel1.Controls.Add(this.volumebar);
            this.panel1.Location = new System.Drawing.Point(138, 397);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 46);
            this.panel1.TabIndex = 11;
            // 
            // volumep
            // 
            this.volumep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.volumep.AutoSize = true;
            this.volumep.Font = new System.Drawing.Font("ByteBounce", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volumep.ForeColor = System.Drawing.SystemColors.Window;
            this.volumep.Location = new System.Drawing.Point(608, 17);
            this.volumep.Name = "volumep";
            this.volumep.Size = new System.Drawing.Size(39, 14);
            this.volumep.TabIndex = 16;
            this.volumep.Text = "25%";
            // 
            // playpause
            // 
            this.playpause.BackColor = System.Drawing.SystemColors.WindowText;
            this.playpause.BackgroundImage = global::meowseek.Properties.Resources.play_pause1;
            this.playpause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playpause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playpause.Location = new System.Drawing.Point(3, 2);
            this.playpause.Name = "playpause";
            this.playpause.Size = new System.Drawing.Size(58, 43);
            this.playpause.TabIndex = 14;
            this.playpause.UseVisualStyleBackColor = false;
            this.playpause.Click += new System.EventHandler(this.playpause_Click_1);
            // 
            // timebar
            // 
            this.timebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timebar.BackColor = System.Drawing.SystemColors.WindowText;
            this.timebar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.timebar.Location = new System.Drawing.Point(65, 3);
            this.timebar.Maximum = 50;
            this.timebar.Name = "timebar";
            this.timebar.Size = new System.Drawing.Size(444, 45);
            this.timebar.TabIndex = 14;
            this.timebar.Scroll += new System.EventHandler(this.timebar_Scroll);
            // 
            // volumebar
            // 
            this.volumebar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.volumebar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.volumebar.Location = new System.Drawing.Point(515, 3);
            this.volumebar.Maximum = 100;
            this.volumebar.Name = "volumebar";
            this.volumebar.Size = new System.Drawing.Size(96, 45);
            this.volumebar.TabIndex = 12;
            this.volumebar.Value = 25;
            this.volumebar.Scroll += new System.EventHandler(this.volumebar_Scroll);
            // 
            // timerplayback
            // 
            this.timerplayback.Tick += new System.EventHandler(this.timerplayback_Tick_1);
            // 
            // songtime
            // 
            this.songtime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.songtime.AutoSize = true;
            this.songtime.BackColor = System.Drawing.Color.Transparent;
            this.songtime.Font = new System.Drawing.Font("ByteBounce", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songtime.ForeColor = System.Drawing.SystemColors.Window;
            this.songtime.Location = new System.Drawing.Point(632, 381);
            this.songtime.Name = "songtime";
            this.songtime.Size = new System.Drawing.Size(138, 13);
            this.songtime.TabIndex = 12;
            this.songtime.Text = "length 0:00/0:00";
            // 
            // movebox
            // 
            this.movebox.BackColor = System.Drawing.Color.Transparent;
            this.movebox.BackgroundImage = global::meowseek.Properties.Resources.arrow;
            this.movebox.Image = global::meowseek.Properties.Resources.move_arrow;
            this.movebox.Location = new System.Drawing.Point(699, 4);
            this.movebox.Name = "movebox";
            this.movebox.Size = new System.Drawing.Size(25, 26);
            this.movebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.movebox.TabIndex = 14;
            this.movebox.TabStop = false;
            this.movebox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.movebox_MouseDown);
            // 
            // fullscreen
            // 
            this.fullscreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fullscreen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fullscreen.Location = new System.Drawing.Point(758, 9);
            this.fullscreen.Name = "fullscreen";
            this.fullscreen.Size = new System.Drawing.Size(12, 13);
            this.fullscreen.TabIndex = 5;
            this.fullscreen.TabStop = false;
            this.fullscreen.Click += new System.EventHandler(this.fullscreen_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Location = new System.Drawing.Point(136, 343);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(654, 102);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // paradigmbox
            // 
            this.paradigmbox.BackColor = System.Drawing.Color.Transparent;
            this.paradigmbox.Location = new System.Drawing.Point(731, 431);
            this.paradigmbox.Name = "paradigmbox";
            this.paradigmbox.Size = new System.Drawing.Size(75, 23);
            this.paradigmbox.TabIndex = 13;
            this.paradigmbox.TabStop = false;
            this.paradigmbox.Click += new System.EventHandler(this.paradigmbox_Click);
            // 
            // musicplayer
            // 
            this.musicplayer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.musicplayer.Enabled = true;
            this.musicplayer.Location = new System.Drawing.Point(138, 345);
            this.musicplayer.Name = "musicplayer";
            this.musicplayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("musicplayer.OcxState")));
            this.musicplayer.Size = new System.Drawing.Size(650, 98);
            this.musicplayer.TabIndex = 4;
            this.musicplayer.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.musicplayer_PlayStateChange);
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.SystemColors.WindowText;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.menuStrip2.Location = new System.Drawing.Point(138, 345);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(71, 24);
            this.menuStrip2.TabIndex = 15;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu2shuffle});
            this.toolStripMenuItem2.Font = new System.Drawing.Font("ByteBounce", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem2.ForeColor = System.Drawing.SystemColors.Window;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(63, 20);
            this.toolStripMenuItem2.Text = "music";
            this.toolStripMenuItem2.ToolTipText = "file tool bar";
            // 
            // mnu2shuffle
            // 
            this.mnu2shuffle.Name = "mnu2shuffle";
            this.mnu2shuffle.Size = new System.Drawing.Size(130, 22);
            this.mnu2shuffle.Text = "shuffle";
            this.mnu2shuffle.Click += new System.EventHandler(this.mnu2shuffle_Click);
            // 
            // meowseek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.movebox);
            this.Controls.Add(this.songtime);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.filebox);
            this.Controls.Add(this.minibutton);
            this.Controls.Add(this.fullscreen);
            this.Controls.Add(this.musicplayer);
            this.Controls.Add(this.songs);
            this.Controls.Add(this.closex);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.paradigmbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "meowseek";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timebar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumebar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullscreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paradigmbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicplayer)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label closex;
        private System.Windows.Forms.ListBox songs;
        private System.Windows.Forms.ToolStripMenuItem mnufile;
        private System.Windows.Forms.ToolStripMenuItem mnuOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuQuit;
        private AxWMPLib.AxWindowsMediaPlayer musicplayer;
        private System.Windows.Forms.PictureBox fullscreen;
        private System.Windows.Forms.Label minibutton;
        private System.Windows.Forms.ToolStripMenuItem mnuMisc;
        private System.Windows.Forms.ToolStripMenuItem mnucalc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox filebox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar timebar;
        private System.Windows.Forms.TrackBar volumebar;
        private System.Windows.Forms.Timer timerplayback;
        private System.Windows.Forms.Label songtime;
        private System.Windows.Forms.Label volumep;
        private System.Windows.Forms.Button playpause;
        private System.Windows.Forms.ToolStripMenuItem mnupong;
        private System.Windows.Forms.ToolStripMenuItem mnumode;
        private System.Windows.Forms.PictureBox paradigmbox;
        private System.Windows.Forms.PictureBox movebox;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mnu2shuffle;
    }
}

