using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MP3TagRenamer
{
    public partial class MP3Player : Form
    {
        private string path = "";
        public MP3Player(string path)
        {
            InitializeComponent();
            this.path = path;
           // this.my_axWindowsMediaPlayer.URL = path;
        }

        private void MP3Player_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.my_axWindowsMediaPlayer.Dispose();
        }

    }
}