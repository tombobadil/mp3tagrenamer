namespace MP3TagRenamer
{
    partial class MP3Player
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MP3Player));
            this.panel1 = new System.Windows.Forms.Panel();
            this.my_axWindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.my_axWindowsMediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.my_axWindowsMediaPlayer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 50);
            this.panel1.TabIndex = 0;
            // 
            // my_axWindowsMediaPlayer
            // 
            this.my_axWindowsMediaPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.my_axWindowsMediaPlayer.Enabled = true;
            this.my_axWindowsMediaPlayer.Location = new System.Drawing.Point(0, 0);
            this.my_axWindowsMediaPlayer.Name = "my_axWindowsMediaPlayer";
            this.my_axWindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("my_axWindowsMediaPlayer.OcxState")));
            this.my_axWindowsMediaPlayer.Size = new System.Drawing.Size(305, 50);
            this.my_axWindowsMediaPlayer.TabIndex = 2;
            // 
            // MP3Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 50);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MP3Player";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MP3Player";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MP3Player_FormClosing);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.my_axWindowsMediaPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private AxWMPLib.AxWindowsMediaPlayer my_axWindowsMediaPlayer;
    }
}