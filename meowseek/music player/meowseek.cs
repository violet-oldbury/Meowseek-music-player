using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace music_player
{
    public partial class meowseek : Form
    {
        public object Textmessage { get; private set; }

        public meowseek()
        {
            InitializeComponent();
        }
        String[] paths, files;
        private void mnuQuit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("do you really want to Quit?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                Application.Exit();

            }
        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if(ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames;
                paths = ofd.FileNames;
                for (int i = 0; i < files.Length; i++)
                {
                    songs.Items.Add(files[i]);
                }
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void songs_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayerSongs.URL = paths[songs.SelectedIndex];
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            //save what files are currently open(like a playlist)
        }

        private void meowseek_Load(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
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

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

