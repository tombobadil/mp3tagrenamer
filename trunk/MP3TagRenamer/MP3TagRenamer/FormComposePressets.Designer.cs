namespace MP3TagRenamer
{
	partial class FormComposePressets
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
			this.m_GroupBoxBottom = new System.Windows.Forms.GroupBox();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonOK = new System.Windows.Forms.Button();
			this.textBoxResult = new System.Windows.Forms.TextBox();
			this.m_FlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.buttonClear = new System.Windows.Forms.Button();
			this.buttonFolderSeparator = new MP3TagRenamer.MovableButton(this.components);
			this.buttonSeparator = new MP3TagRenamer.MovableButton(this.components);
			this.buttonTitle = new MP3TagRenamer.MovableButton(this.components);
			this.buttonTrackNr = new MP3TagRenamer.MovableButton(this.components);
			this.buttonYear = new MP3TagRenamer.MovableButton(this.components);
			this.buttonArtist = new MP3TagRenamer.MovableButton(this.components);
			this.buttonAlbum = new MP3TagRenamer.MovableButton(this.components);
			this.textBoxPath = new System.Windows.Forms.TextBox();
			this.buttonTest = new System.Windows.Forms.Button();
			this.labelTest = new System.Windows.Forms.Label();
			this.m_GroupBoxBottom.SuspendLayout();
			this.SuspendLayout();
			// 
			// m_GroupBoxBottom
			// 
			this.m_GroupBoxBottom.Controls.Add(this.buttonCancel);
			this.m_GroupBoxBottom.Controls.Add(this.buttonOK);
			this.m_GroupBoxBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.m_GroupBoxBottom.Location = new System.Drawing.Point(0, 303);
			this.m_GroupBoxBottom.Name = "m_GroupBoxBottom";
			this.m_GroupBoxBottom.Size = new System.Drawing.Size(668, 38);
			this.m_GroupBoxBottom.TabIndex = 9;
			this.m_GroupBoxBottom.TabStop = false;
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(543, 9);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(103, 23);
			this.buttonCancel.TabIndex = 1;
			this.buttonCancel.Text = "&Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// buttonOK
			// 
			this.buttonOK.Location = new System.Drawing.Point(426, 9);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(111, 23);
			this.buttonOK.TabIndex = 0;
			this.buttonOK.Text = "&OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// textBoxResult
			// 
			this.textBoxResult.Location = new System.Drawing.Point(12, 142);
			this.textBoxResult.Name = "textBoxResult";
			this.textBoxResult.Size = new System.Drawing.Size(525, 20);
			this.textBoxResult.TabIndex = 8;
			// 
			// m_FlowLayoutPanel
			// 
			this.m_FlowLayoutPanel.AllowDrop = true;
			this.m_FlowLayoutPanel.AutoScroll = true;
			this.m_FlowLayoutPanel.BackColor = System.Drawing.SystemColors.ControlDark;
			this.m_FlowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.m_FlowLayoutPanel.Location = new System.Drawing.Point(13, 76);
			this.m_FlowLayoutPanel.Name = "m_FlowLayoutPanel";
			this.m_FlowLayoutPanel.Size = new System.Drawing.Size(525, 60);
			this.m_FlowLayoutPanel.TabIndex = 7;
			this.m_FlowLayoutPanel.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.FlowLayoutPanel_ControlChange);
			this.m_FlowLayoutPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.FlowLayoutPanel_DragDrop);
			this.m_FlowLayoutPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FlowLayoutPanel_MouseDown);
			this.m_FlowLayoutPanel.DragLeave += new System.EventHandler(this.FlowLayoutPanel_DragLeave);
			this.m_FlowLayoutPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.FlowLayoutPanel_DragEnter);
			this.m_FlowLayoutPanel.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.FlowLayoutPanel_ControlChange);
			// 
			// buttonClear
			// 
			this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonClear.Location = new System.Drawing.Point(543, 76);
			this.buttonClear.Name = "buttonClear";
			this.buttonClear.Size = new System.Drawing.Size(75, 23);
			this.buttonClear.TabIndex = 10;
			this.buttonClear.Text = "Clear";
			this.buttonClear.UseVisualStyleBackColor = true;
			this.buttonClear.Click += new System.EventHandler(this.ButtonClear_Click);
			// 
			// buttonFolderSeparator
			// 
			this.buttonFolderSeparator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonFolderSeparator.Location = new System.Drawing.Point(436, 49);
			this.buttonFolderSeparator.Name = "buttonFolderSeparator";
			this.buttonFolderSeparator.Size = new System.Drawing.Size(46, 21);
			this.buttonFolderSeparator.TabIndex = 6;
			this.buttonFolderSeparator.Text = "\\";
			this.buttonFolderSeparator.UseVisualStyleBackColor = true;
			this.buttonFolderSeparator.Click += new System.EventHandler(this.ButtonTag_Click);
			// 
			// buttonSeparator
			// 
			this.buttonSeparator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonSeparator.Location = new System.Drawing.Point(383, 49);
			this.buttonSeparator.Name = "buttonSeparator";
			this.buttonSeparator.Size = new System.Drawing.Size(46, 21);
			this.buttonSeparator.TabIndex = 5;
			this.buttonSeparator.Text = " - ";
			this.buttonSeparator.UseVisualStyleBackColor = true;
			this.buttonSeparator.Click += new System.EventHandler(this.ButtonTag_Click);
			// 
			// buttonTitle
			// 
			this.buttonTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonTitle.Location = new System.Drawing.Point(309, 49);
			this.buttonTitle.Name = "buttonTitle";
			this.buttonTitle.Size = new System.Drawing.Size(67, 21);
			this.buttonTitle.TabIndex = 4;
			this.buttonTitle.Text = "Title";
			this.buttonTitle.UseVisualStyleBackColor = true;
			this.buttonTitle.Click += new System.EventHandler(this.ButtonTag_Click);
			// 
			// buttonTrackNr
			// 
			this.buttonTrackNr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonTrackNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonTrackNr.Location = new System.Drawing.Point(235, 49);
			this.buttonTrackNr.Name = "buttonTrackNr";
			this.buttonTrackNr.Size = new System.Drawing.Size(67, 21);
			this.buttonTrackNr.TabIndex = 3;
			this.buttonTrackNr.Text = "Track nr";
			this.buttonTrackNr.UseVisualStyleBackColor = true;
			this.buttonTrackNr.Click += new System.EventHandler(this.ButtonTag_Click);
			// 
			// buttonYear
			// 
			this.buttonYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonYear.Location = new System.Drawing.Point(161, 49);
			this.buttonYear.Name = "buttonYear";
			this.buttonYear.Size = new System.Drawing.Size(67, 21);
			this.buttonYear.TabIndex = 2;
			this.buttonYear.Text = "Year";
			this.buttonYear.UseVisualStyleBackColor = true;
			this.buttonYear.Click += new System.EventHandler(this.ButtonTag_Click);
			// 
			// buttonArtist
			// 
			this.buttonArtist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonArtist.Location = new System.Drawing.Point(87, 49);
			this.buttonArtist.Name = "buttonArtist";
			this.buttonArtist.Size = new System.Drawing.Size(67, 21);
			this.buttonArtist.TabIndex = 1;
			this.buttonArtist.Text = "Artist";
			this.buttonArtist.UseVisualStyleBackColor = true;
			this.buttonArtist.Click += new System.EventHandler(this.ButtonTag_Click);
			// 
			// buttonAlbum
			// 
			this.buttonAlbum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonAlbum.Location = new System.Drawing.Point(13, 49);
			this.buttonAlbum.Name = "buttonAlbum";
			this.buttonAlbum.Size = new System.Drawing.Size(67, 21);
			this.buttonAlbum.TabIndex = 0;
			this.buttonAlbum.Text = "Album";
			this.buttonAlbum.UseVisualStyleBackColor = true;
			this.buttonAlbum.Click += new System.EventHandler(this.ButtonTag_Click);
			// 
			// textBoxPath
			// 
			this.textBoxPath.Location = new System.Drawing.Point(13, 13);
			this.textBoxPath.Name = "textBoxPath";
			this.textBoxPath.ReadOnly = true;
			this.textBoxPath.Size = new System.Drawing.Size(643, 20);
			this.textBoxPath.TabIndex = 11;
			// 
			// buttonTest
			// 
			this.buttonTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonTest.Location = new System.Drawing.Point(543, 139);
			this.buttonTest.Name = "buttonTest";
			this.buttonTest.Size = new System.Drawing.Size(75, 23);
			this.buttonTest.TabIndex = 12;
			this.buttonTest.Text = "Test";
			this.buttonTest.UseVisualStyleBackColor = true;
			this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
			// 
			// labelTest
			// 
			this.labelTest.AutoSize = true;
			this.labelTest.Location = new System.Drawing.Point(13, 169);
			this.labelTest.Name = "labelTest";
			this.labelTest.Size = new System.Drawing.Size(16, 13);
			this.labelTest.TabIndex = 13;
			this.labelTest.Text = "---";
			// 
			// FormComposePressets
			// 
			this.AcceptButton = this.buttonOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(668, 341);
			this.Controls.Add(this.labelTest);
			this.Controls.Add(this.buttonTest);
			this.Controls.Add(this.textBoxPath);
			this.Controls.Add(this.buttonClear);
			this.Controls.Add(this.m_FlowLayoutPanel);
			this.Controls.Add(this.buttonFolderSeparator);
			this.Controls.Add(this.textBoxResult);
			this.Controls.Add(this.buttonSeparator);
			this.Controls.Add(this.buttonTitle);
			this.Controls.Add(this.buttonTrackNr);
			this.Controls.Add(this.buttonYear);
			this.Controls.Add(this.buttonArtist);
			this.Controls.Add(this.buttonAlbum);
			this.Controls.Add(this.m_GroupBoxBottom);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "FormComposePressets";
			this.Text = "Compose pressets";
			this.m_GroupBoxBottom.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox m_GroupBoxBottom;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonOK;
		private MovableButton buttonArtist;
		private MovableButton buttonYear;
		private MovableButton buttonTrackNr;
		private MovableButton buttonTitle;
		private MovableButton buttonSeparator;
		private System.Windows.Forms.TextBox textBoxResult;
		private MovableButton buttonFolderSeparator;
		private System.Windows.Forms.FlowLayoutPanel m_FlowLayoutPanel;
		private MovableButton buttonAlbum;
		private System.Windows.Forms.Button buttonClear;
		private System.Windows.Forms.TextBox textBoxPath;
		private System.Windows.Forms.Button buttonTest;
		private System.Windows.Forms.Label labelTest;
	}
}