using AxWMPLib;
using meowseek;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace meowseek
{
    public partial class meowseek : Form
    {
        private List<string> musicfiles;
        private string currentsong;
        private bool ispaused;
        private bool ischangingposition;
        private bool ismax;
        public meowseek()
        {
            InitializeComponent();
            musicfiles = new List<string>();
            ispaused = false;
            ischangingposition = false;
            ismax = false;
            if (ischangingposition == true)
            {
                timebar.Value = (int)musicplayer.Ctlcontrols.currentPosition;
            }

        }
        String[] paths, files;

        Boolean shuffleenabled = false;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        //closes program when you click quit
        private void mnuQuit_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("do you really want to Quit?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        //opens files when you press the button
        private void mnuOpen_Click_1(object sender, EventArgs e)
        {
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Multiselect = true;
                ofd.Filter = "Mp3 Files|*.mp3|Avi Files|*.avi|Wav Files|*.wav";
                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    files = ofd.SafeFileNames;
                    paths = ofd.FileNames;
                    for (int i = 0; i < files.Length; i++)
                    {
                        songs.Items.Add(files[i]);
                    }
                }
            }
        }

        //gets media player to play the songs if doesnt equal null
        private void songs_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                musicplayer.URL = paths[songs.SelectedIndex];
                timerplayback.Start();
            }
            catch (IndexOutOfRangeException)
            { }
        }

        //closes program when you click x
        private void closex_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //makes program go fullscreen and windowed
        private void fullscreen_Click(object sender, EventArgs e)
        {
            if (ismax == false)
            {
                this.WindowState = FormWindowState.Maximized;
                ismax = true;
            }

            else if (ismax == true)
            {
                this.WindowState = FormWindowState.Normal;
                ismax = false;
            }
        }

        //minimises window
        private void minibutton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //opens calculator
        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.ShowDialog();
        }

        //changes playstate
        private void musicplayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 8)
            {
                int nextindex = 0;
                try
                {
                    nextindex = songs.SelectedIndex += 1;
                }
                catch(ArgumentOutOfRangeException) 
                { }

                if (nextindex < musicfiles.Count)
                {
                    songs.SelectedIndex = nextindex;
                    currentsong = musicfiles[nextindex];
                    musicplayer.URL = currentsong;
                    musicplayer.Ctlcontrols.play();
                    ispaused = false;
                }

                else
                {
                    musicplayer.Ctlcontrols.stop();
                    ispaused = false;
                }

                if (musicplayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
                {
                    timebar.Maximum = (int)musicplayer.Ctlcontrols.currentItem.duration;
                    timerplayback.Start();
                }

                else if (musicplayer.playState == WMPLib.WMPPlayState.wmppsStopped)
                {
                    timerplayback.Stop();
                    timebar.Value = 0;
                }

                if (musicplayer.playState == WMPLib.WMPPlayState.wmppsMediaEnded)
                {
                    songs.SelectedIndex = 0;
                    timebar.Update();
                }

                if(musicplayer.playState == WMPLib.WMPPlayState.wmppsReady)
                {
                    ispaused = true;
                }
            }
        }

        //changes time to selected value on bar
        private void timebar_Scroll(object sender, EventArgs e)
        {
            musicplayer.Ctlcontrols.currentPosition = timebar.Value;
        }

        //changes volume
        private void volumebar_Scroll(object sender, EventArgs e)
        {
            musicplayer.settings.volume = volumebar.Value;
            volumep.Text = Convert.ToString(musicplayer.settings.volume) + "%";
        }

        //sets songtime text to be current time
        private void timerplayback_Tick_1(object sender, EventArgs e)
        {
            songtime.Text = "length " + formattime(musicplayer.Ctlcontrols.currentPosition) + "/" + formattime(musicplayer.currentMedia.duration);


            timebar.Maximum = ((int)musicplayer.currentMedia.duration);

            if (musicplayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                timebar.Value = (int)musicplayer.Ctlcontrols.currentPosition;
            }
        }

        //plays/pauses songs
        private void playpause_Click_1(object sender, EventArgs e)
        {
            if (ispaused == true)
            {
                if (songs.SelectedIndex >= 0)
                {
                    if (ispaused)
                    {
                        musicplayer.Ctlcontrols.play();
                        ispaused = false;
                    }
                    else
                    {
                        currentsong = musicfiles[songs.SelectedIndex];
                        musicplayer.URL = currentsong;
                        musicplayer.Ctlcontrols.play();
                    }
                    timerplayback.Enabled = true;
                }
            }
            else
            {
                if (ispaused == false)
                {
                    musicplayer.Ctlcontrols.pause();
                    ispaused = true;
                }
                else
                {
                    musicplayer.Ctlcontrols.play();
                    ispaused = false;
                }
            }
        }

        //opens pong
        private void pongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pong newForm = new pong();
            newForm.ShowDialog();
        }

        //changes form to light mode/dark mode
        private void lightModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.BackColor == Color.Black)
            {
                //turns it white
                this.BackColor = Color.White;
                this.ForeColor = Color.Black;

                this.filebox.BackColor = Color.White;
                this.filebox.ForeColor = Color.Black;

                this.songs.BackColor = Color.White;
                this.songs.ForeColor = Color.Black;

                this.menuStrip1.BackColor = Color.White;
                this.mnufile.ForeColor = Color.Black;
                this.mnuMisc.ForeColor = Color.Black;

                this.songtime.BackColor = Color.Black;
                this.playpause.BackColor = Color.White;
                this.timebar.BackColor = Color.White;
                this.closex.ForeColor = Color.Black;
                this.minibutton.ForeColor = Color.Black;
                this.volumep.ForeColor = Color.Black;
                this.pictureBox1.BackColor = Color.Black;
                this.mnumode.Text = "dark mode";
            }

            else
            {
                //turns it black
                this.BackColor = Color.Black;
                this.ForeColor = Color.White;

                this.filebox.BackColor = Color.Black;
                this.filebox.ForeColor= Color.White;

                this.songs.BackColor = Color.Black;
                this.songs.ForeColor= Color.White;

                this.menuStrip1.BackColor = Color.Black;
                this.mnufile.ForeColor = Color.White;
                this.mnuMisc.ForeColor = Color.White;
                
                this.songtime.BackColor = Color.Black;
                this.playpause.BackColor= Color.Black;
                this.timebar.BackColor = Color.Black;
                this.closex.ForeColor = Color.White ;
                this.minibutton.ForeColor= Color.White ;
                this.volumep.ForeColor= Color.White ;
                this.pictureBox1.BackColor = Color.White;
                this.mnumode.Text = "light mode";
            }
        }

        //shuffles songs
        private void mnu2shuffle_Click(object sender, EventArgs e)
        {
            if (shuffleenabled == false)
            {
                ListBox.ObjectCollection list = songs.Items;
                Random random = new Random();
                int listnum = list.Count;
                songs.BeginUpdate();
                while (listnum > 1)
                {
                    listnum--;
                    int next = random.Next(listnum + 1);
                    object value = list[next];
                    list[next] = list[listnum];
                    list[listnum] = value;

                }
                songs.EndUpdate();
                songs.Invalidate();
            }
            else
            {

            }
        }

        //paradigm egg
        private void paradigmbox_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 7;)
            {
                MessageBox.Show("paradigm?", "paradigm", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        //moves form about
        private void movebox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        //returns song time to formattime
        private string formattime(double seconds)
        {
            TimeSpan time = TimeSpan.FromSeconds(seconds);
            return time.ToString(@"mm\:ss");
        }
    }
}
// add shuffle