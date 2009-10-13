namespace MP3TagRenamer
{
	partial class UserControlTrackList
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlTrackList));
			this.m_UserControlFolderSelector = new MP3TagRenamer.UserControlFolderSelector();
			this.m_DataGridViewTrackList = new System.Windows.Forms.DataGridView();
			this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.m_BindingSourceUltraID3 = new System.Windows.Forms.BindingSource(this.components);
			this.m_FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			((System.ComponentModel.ISupportInitialize)(this.m_DataGridViewTrackList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.m_BindingSourceUltraID3)).BeginInit();
			this.SuspendLayout();
			// 
			// m_UserControlFolderSelector
			// 
			this.m_UserControlFolderSelector.ActualPath = "";
			this.m_UserControlFolderSelector.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_UserControlFolderSelector.Location = new System.Drawing.Point(0, 0);
			this.m_UserControlFolderSelector.Name = "m_UserControlFolderSelector";
			this.m_UserControlFolderSelector.Paths = new string[] {
        ""};
			this.m_UserControlFolderSelector.Size = new System.Drawing.Size(704, 47);
			this.m_UserControlFolderSelector.TabIndex = 7;
			// 
			// m_DataGridViewTrackList
			// 
			this.m_DataGridViewTrackList.AllowUserToAddRows = false;
			this.m_DataGridViewTrackList.AllowUserToOrderColumns = true;
			this.m_DataGridViewTrackList.AutoGenerateColumns = false;
			this.m_DataGridViewTrackList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
			this.m_DataGridViewTrackList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
			this.m_DataGridViewTrackList.DataSource = this.m_BindingSourceUltraID3;
			this.m_DataGridViewTrackList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_DataGridViewTrackList.Location = new System.Drawing.Point(0, 47);
			this.m_DataGridViewTrackList.Name = "m_DataGridViewTrackList";
			this.m_DataGridViewTrackList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.m_DataGridViewTrackList.Size = new System.Drawing.Size(704, 771);
			this.m_DataGridViewTrackList.TabIndex = 2;
			this.m_DataGridViewTrackList.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_MP3s_RowEnter);
			this.m_DataGridViewTrackList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_MP3s_CellContentClick);
			// 
			// dataGridViewImageColumn1
			// 
			this.dataGridViewImageColumn1.HeaderText = "Play";
			this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
			this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
			this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
			this.dataGridViewImageColumn1.Width = 33;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "TrackNum";
			this.dataGridViewTextBoxColumn1.HeaderText = "TrackNum";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.Width = 82;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "Artist";
			this.dataGridViewTextBoxColumn2.HeaderText = "Artist";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.Width = 55;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dataGridViewTextBoxColumn3.DataPropertyName = "Title";
			this.dataGridViewTextBoxColumn3.HeaderText = "Title";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.Width = 52;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "Genre";
			this.dataGridViewTextBoxColumn4.HeaderText = "Genre";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.Width = 61;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "Album";
			this.dataGridViewTextBoxColumn5.HeaderText = "Album";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.Width = 61;
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.DataPropertyName = "Year";
			this.dataGridViewTextBoxColumn6.HeaderText = "Year";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn6.Width = 54;
			// 
			// dataGridViewTextBoxColumn7
			// 
			this.dataGridViewTextBoxColumn7.DataPropertyName = "Size";
			this.dataGridViewTextBoxColumn7.HeaderText = "Size";
			this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
			this.dataGridViewTextBoxColumn7.ReadOnly = true;
			this.dataGridViewTextBoxColumn7.Width = 52;
			// 
			// dataGridViewTextBoxColumn8
			// 
			this.dataGridViewTextBoxColumn8.DataPropertyName = "Comments";
			this.dataGridViewTextBoxColumn8.HeaderText = "Comments";
			this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
			this.dataGridViewTextBoxColumn8.Width = 81;
			// 
			// dataGridViewTextBoxColumn9
			// 
			this.dataGridViewTextBoxColumn9.DataPropertyName = "Duration";
			this.dataGridViewTextBoxColumn9.HeaderText = "Duration";
			this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
			this.dataGridViewTextBoxColumn9.ReadOnly = true;
			this.dataGridViewTextBoxColumn9.Width = 72;
			// 
			// dataGridViewTextBoxColumn10
			// 
			this.dataGridViewTextBoxColumn10.DataPropertyName = "FileName";
			this.dataGridViewTextBoxColumn10.HeaderText = "FileName";
			this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
			this.dataGridViewTextBoxColumn10.ReadOnly = true;
			this.dataGridViewTextBoxColumn10.Width = 76;
			// 
			// m_BindingSourceUltraID3
			// 
			this.m_BindingSourceUltraID3.DataSource = typeof(HundredMilesSoftware.UltraID3Lib.UltraID3);
			this.m_BindingSourceUltraID3.DataError += new System.Windows.Forms.BindingManagerDataErrorEventHandler(this.BindingSourceUltraID3_DataError);
			// 
			// UserControlTrackList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.m_DataGridViewTrackList);
			this.Controls.Add(this.m_UserControlFolderSelector);
			this.Name = "UserControlTrackList";
			this.Size = new System.Drawing.Size(704, 818);
			((System.ComponentModel.ISupportInitialize)(this.m_DataGridViewTrackList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.m_BindingSourceUltraID3)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private UserControlFolderSelector m_UserControlFolderSelector;
		private System.Windows.Forms.DataGridView m_DataGridViewTrackList;
		private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
		private System.Windows.Forms.BindingSource m_BindingSourceUltraID3;
		private System.Windows.Forms.FolderBrowserDialog m_FolderBrowserDialog;

		/// Save statistics
		private System.Collections.Hashtable batchCounting_Artist;
		private System.Collections.Hashtable batchCounting_Album;
		private System.Collections.Hashtable batchCounting_Ganre;
		private System.Collections.Hashtable batchCounting_Year;
		private System.Collections.Hashtable m_VisitedDirsPaths;
		private string m_ActivePath;


	}
}
