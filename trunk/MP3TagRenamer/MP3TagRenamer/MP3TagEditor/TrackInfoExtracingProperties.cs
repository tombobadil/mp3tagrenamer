using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MP3TagRenamer.MP3TagEditor
{
    public partial class TrackInfoExtracingProperties : Form
    {
        public TrackInfoExtracingProperties()
        {
            InitializeComponent();
        }

        private void Button_Update_Click( object sender , EventArgs e )
        {
            this.Close();
        }
    }
}