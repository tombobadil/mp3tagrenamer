namespace MP3TagRenamer
{
    partial class UserControlCompareDuplicates
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlCompareDuplicates));
			this.my_main_panel = new System.Windows.Forms.Panel();
			this.my_splitContainer = new System.Windows.Forms.SplitContainer();
			this.My_GroupBox_Top = new System.Windows.Forms.GroupBox();
			this.my_checkedListBox_FolderList = new System.Windows.Forms.CheckedListBox();
			this.my_folderSelector = new MP3TagRenamer.UserControlFolderSelector();
			this.my_splitContainer_DS = new System.Windows.Forms.SplitContainer();
			this.my_dataGridView = new System.Windows.Forms.DataGridView();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.duretionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.my_dataSet = new System.Data.DataSet();
			this.my_dataTable_ID3Info = new System.Data.DataTable();
			this.my_id3Info_dc_title = new System.Data.DataColumn();
			this.my_id3Info_dc_artist = new System.Data.DataColumn();
			this.my_id3Info_dc_duration = new System.Data.DataColumn();
			this.my_id3Info_dc_size = new System.Data.DataColumn();
			this.my_id3Info_dc_path = new System.Data.DataColumn();
			this.my_id3Info_dc_delete = new System.Data.DataColumn();
			this.my_id3Info_dc_dupl_id = new System.Data.DataColumn();
			this.my_dataTable_FileInfo = new System.Data.DataTable();
			this.my_fileinfo_dc_name = new System.Data.DataColumn();
			this.my_fileinfo_dc_id = new System.Data.DataColumn();
			this.my_fileinfo_dc_duration = new System.Data.DataColumn();
			this.my_fileinfo_dc_size = new System.Data.DataColumn();
			this.my_dataGridView_Duplicates = new System.Windows.Forms.DataGridView();
			this.deleteDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.artistDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sizeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.duplicateIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Play = new System.Windows.Forms.DataGridViewButtonColumn();
			this.my_contextMenuStrip_Duplicates = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.my_copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.my_pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
			this.my_playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.my_deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonIncluedeSubdirectories = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButtonViewDeleteList = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonClearDirectories = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButtonShowHideDirectoryList = new System.Windows.Forms.ToolStripButton();
			this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
			this.folderSelector1 = new MP3TagRenamer.UserControlFolderSelector();
			this.my_main_panel.SuspendLayout();
			this.my_splitContainer.Panel1.SuspendLayout();
			this.my_splitContainer.Panel2.SuspendLayout();
			this.my_splitContainer.SuspendLayout();
			this.My_GroupBox_Top.SuspendLayout();
			this.my_splitContainer_DS.Panel1.SuspendLayout();
			this.my_splitContainer_DS.Panel2.SuspendLayout();
			this.my_splitContainer_DS.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.my_dataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.my_dataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.my_dataTable_ID3Info)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.my_dataTable_FileInfo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.my_dataGridView_Duplicates)).BeginInit();
			this.my_contextMenuStrip_Duplicates.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// my_main_panel
			// 
			this.my_main_panel.Controls.Add(this.my_splitContainer);
			this.my_main_panel.Controls.Add(this.toolStrip1);
			this.my_main_panel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.my_main_panel.Location = new System.Drawing.Point(0, 0);
			this.my_main_panel.Name = "my_main_panel";
			this.my_main_panel.Size = new System.Drawing.Size(1038, 806);
			this.my_main_panel.TabIndex = 0;
			// 
			// my_splitContainer
			// 
			this.my_splitContainer.BackColor = System.Drawing.SystemColors.Control;
			this.my_splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.my_splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.my_splitContainer.ForeColor = System.Drawing.SystemColors.ControlText;
			this.my_splitContainer.Location = new System.Drawing.Point(0, 25);
			this.my_splitContainer.Name = "my_splitContainer";
			this.my_splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// my_splitContainer.Panel1
			// 
			this.my_splitContainer.Panel1.AutoScroll = true;
			this.my_splitContainer.Panel1.Controls.Add(this.My_GroupBox_Top);
			this.my_splitContainer.Panel1MinSize = 195;
			// 
			// my_splitContainer.Panel2
			// 
			this.my_splitContainer.Panel2.AutoScroll = true;
			this.my_splitContainer.Panel2.Controls.Add(this.my_splitContainer_DS);
			this.my_splitContainer.Size = new System.Drawing.Size(1038, 781);
			this.my_splitContainer.SplitterDistance = 211;
			this.my_splitContainer.SplitterWidth = 10;
			this.my_splitContainer.TabIndex = 3;
			// 
			// My_GroupBox_Top
			// 
			this.My_GroupBox_Top.AutoSize = true;
			this.My_GroupBox_Top.Controls.Add(this.my_checkedListBox_FolderList);
			this.My_GroupBox_Top.Controls.Add(this.my_folderSelector);
			this.My_GroupBox_Top.Dock = System.Windows.Forms.DockStyle.Fill;
			this.My_GroupBox_Top.Location = new System.Drawing.Point(0, 0);
			this.My_GroupBox_Top.Margin = new System.Windows.Forms.Padding(0);
			this.My_GroupBox_Top.Name = "My_GroupBox_Top";
			this.My_GroupBox_Top.Padding = new System.Windows.Forms.Padding(0);
			this.My_GroupBox_Top.Size = new System.Drawing.Size(1038, 211);
			this.My_GroupBox_Top.TabIndex = 2;
			this.My_GroupBox_Top.TabStop = false;
			this.My_GroupBox_Top.Text = "Search in directories";
			// 
			// my_checkedListBox_FolderList
			// 
			this.my_checkedListBox_FolderList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.my_checkedListBox_FolderList.FormattingEnabled = true;
			this.my_checkedListBox_FolderList.Location = new System.Drawing.Point(10, 69);
			this.my_checkedListBox_FolderList.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
			this.my_checkedListBox_FolderList.Name = "my_checkedListBox_FolderList";
			this.my_checkedListBox_FolderList.Size = new System.Drawing.Size(1004, 139);
			this.my_checkedListBox_FolderList.TabIndex = 1;
			// 
			// my_folderSelector
			// 
			this.my_folderSelector.ActualPath = "";
			this.my_folderSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.my_folderSelector.Location = new System.Drawing.Point(234, 13);
			this.my_folderSelector.Margin = new System.Windows.Forms.Padding(0);
			this.my_folderSelector.Name = "my_folderSelector";
			this.my_folderSelector.Paths = new string[] {
        ""};
			this.my_folderSelector.Size = new System.Drawing.Size(780, 48);
			this.my_folderSelector.TabIndex = 0;
			// 
			// my_splitContainer_DS
			// 
			this.my_splitContainer_DS.Dock = System.Windows.Forms.DockStyle.Fill;
			this.my_splitContainer_DS.Location = new System.Drawing.Point(0, 0);
			this.my_splitContainer_DS.Name = "my_splitContainer_DS";
			this.my_splitContainer_DS.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// my_splitContainer_DS.Panel1
			// 
			this.my_splitContainer_DS.Panel1.Controls.Add(this.my_dataGridView);
			// 
			// my_splitContainer_DS.Panel2
			// 
			this.my_splitContainer_DS.Panel2.Controls.Add(this.my_dataGridView_Duplicates);
			this.my_splitContainer_DS.Size = new System.Drawing.Size(1038, 560);
			this.my_splitContainer_DS.SplitterDistance = 279;
			this.my_splitContainer_DS.TabIndex = 2;
			// 
			// my_dataGridView
			// 
			this.my_dataGridView.AllowUserToAddRows = false;
			this.my_dataGridView.AllowUserToOrderColumns = true;
			this.my_dataGridView.AutoGenerateColumns = false;
			this.my_dataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
			this.my_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.my_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.duretionDataGridViewTextBoxColumn,
            this.sizeDataGridViewTextBoxColumn});
			this.my_dataGridView.DataMember = "FileInfo";
			this.my_dataGridView.DataSource = this.my_dataSet;
			this.my_dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.my_dataGridView.Location = new System.Drawing.Point(0, 0);
			this.my_dataGridView.Name = "my_dataGridView";
			this.my_dataGridView.ReadOnly = true;
			this.my_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.my_dataGridView.Size = new System.Drawing.Size(1038, 279);
			this.my_dataGridView.TabIndex = 0;
			this.my_dataGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_Files_RowEnter);
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			this.nameDataGridViewTextBoxColumn.ReadOnly = true;
			this.nameDataGridViewTextBoxColumn.Width = 60;
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			this.idDataGridViewTextBoxColumn.Visible = false;
			// 
			// duretionDataGridViewTextBoxColumn
			// 
			this.duretionDataGridViewTextBoxColumn.DataPropertyName = "Duretion";
			this.duretionDataGridViewTextBoxColumn.HeaderText = "Duretion";
			this.duretionDataGridViewTextBoxColumn.Name = "duretionDataGridViewTextBoxColumn";
			this.duretionDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// sizeDataGridViewTextBoxColumn
			// 
			this.sizeDataGridViewTextBoxColumn.DataPropertyName = "Size";
			dataGridViewCellStyle1.Format = "N0";
			dataGridViewCellStyle1.NullValue = null;
			this.sizeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
			this.sizeDataGridViewTextBoxColumn.HeaderText = "Size";
			this.sizeDataGridViewTextBoxColumn.Name = "sizeDataGridViewTextBoxColumn";
			this.sizeDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// my_dataSet
			// 
			this.my_dataSet.DataSetName = "ID3Info";
			this.my_dataSet.EnforceConstraints = false;
			this.my_dataSet.Locale = new System.Globalization.CultureInfo("");
			this.my_dataSet.Tables.AddRange(new System.Data.DataTable[] {
            this.my_dataTable_ID3Info,
            this.my_dataTable_FileInfo});
			// 
			// my_dataTable_ID3Info
			// 
			this.my_dataTable_ID3Info.Columns.AddRange(new System.Data.DataColumn[] {
            this.my_id3Info_dc_title,
            this.my_id3Info_dc_artist,
            this.my_id3Info_dc_duration,
            this.my_id3Info_dc_size,
            this.my_id3Info_dc_path,
            this.my_id3Info_dc_delete,
            this.my_id3Info_dc_dupl_id});
			this.my_dataTable_ID3Info.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "Duplicate_Id",
                        "Path"}, true)});
			this.my_dataTable_ID3Info.PrimaryKey = new System.Data.DataColumn[] {
        this.my_id3Info_dc_dupl_id,
        this.my_id3Info_dc_path};
			this.my_dataTable_ID3Info.TableName = "ID3Info";
			// 
			// my_id3Info_dc_title
			// 
			this.my_id3Info_dc_title.ColumnName = "Title";
			// 
			// my_id3Info_dc_artist
			// 
			this.my_id3Info_dc_artist.ColumnName = "Artist";
			// 
			// my_id3Info_dc_duration
			// 
			this.my_id3Info_dc_duration.ColumnName = "Duration";
			this.my_id3Info_dc_duration.DataType = typeof(System.TimeSpan);
			// 
			// my_id3Info_dc_size
			// 
			this.my_id3Info_dc_size.ColumnName = "Size";
			this.my_id3Info_dc_size.DataType = typeof(long);
			// 
			// my_id3Info_dc_path
			// 
			this.my_id3Info_dc_path.AllowDBNull = false;
			this.my_id3Info_dc_path.ColumnName = "Path";
			// 
			// my_id3Info_dc_delete
			// 
			this.my_id3Info_dc_delete.ColumnName = "Delete";
			this.my_id3Info_dc_delete.DataType = typeof(bool);
			this.my_id3Info_dc_delete.DefaultValue = false;
			// 
			// my_id3Info_dc_dupl_id
			// 
			this.my_id3Info_dc_dupl_id.AllowDBNull = false;
			this.my_id3Info_dc_dupl_id.ColumnName = "Duplicate_Id";
			this.my_id3Info_dc_dupl_id.DataType = typeof(int);
			// 
			// my_dataTable_FileInfo
			// 
			this.my_dataTable_FileInfo.Columns.AddRange(new System.Data.DataColumn[] {
            this.my_fileinfo_dc_name,
            this.my_fileinfo_dc_id,
            this.my_fileinfo_dc_duration,
            this.my_fileinfo_dc_size});
			this.my_dataTable_FileInfo.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "Id"}, true)});
			this.my_dataTable_FileInfo.PrimaryKey = new System.Data.DataColumn[] {
        this.my_fileinfo_dc_id};
			this.my_dataTable_FileInfo.TableName = "FileInfo";
			// 
			// my_fileinfo_dc_name
			// 
			this.my_fileinfo_dc_name.AllowDBNull = false;
			this.my_fileinfo_dc_name.ColumnName = "Name";
			// 
			// my_fileinfo_dc_id
			// 
			this.my_fileinfo_dc_id.AllowDBNull = false;
			this.my_fileinfo_dc_id.AutoIncrement = true;
			this.my_fileinfo_dc_id.AutoIncrementSeed = ((long)(1));
			this.my_fileinfo_dc_id.ColumnName = "Id";
			this.my_fileinfo_dc_id.DataType = typeof(int);
			// 
			// my_fileinfo_dc_duration
			// 
			this.my_fileinfo_dc_duration.ColumnName = "Duretion";
			this.my_fileinfo_dc_duration.DataType = typeof(System.TimeSpan);
			// 
			// my_fileinfo_dc_size
			// 
			this.my_fileinfo_dc_size.ColumnName = "Size";
			this.my_fileinfo_dc_size.DataType = typeof(long);
			// 
			// my_dataGridView_Duplicates
			// 
			this.my_dataGridView_Duplicates.AllowUserToAddRows = false;
			this.my_dataGridView_Duplicates.AllowUserToOrderColumns = true;
			this.my_dataGridView_Duplicates.AutoGenerateColumns = false;
			this.my_dataGridView_Duplicates.BackgroundColor = System.Drawing.SystemColors.ControlLight;
			this.my_dataGridView_Duplicates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.my_dataGridView_Duplicates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.deleteDataGridViewCheckBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.artistDataGridViewTextBoxColumn,
            this.durationDataGridViewTextBoxColumn,
            this.sizeDataGridViewTextBoxColumn1,
            this.pathDataGridViewTextBoxColumn,
            this.duplicateIdDataGridViewTextBoxColumn,
            this.Play});
			this.my_dataGridView_Duplicates.ContextMenuStrip = this.my_contextMenuStrip_Duplicates;
			this.my_dataGridView_Duplicates.DataMember = "ID3Info";
			this.my_dataGridView_Duplicates.DataSource = this.my_dataSet;
			this.my_dataGridView_Duplicates.Dock = System.Windows.Forms.DockStyle.Fill;
			this.my_dataGridView_Duplicates.Location = new System.Drawing.Point(0, 0);
			this.my_dataGridView_Duplicates.Name = "my_dataGridView_Duplicates";
			this.my_dataGridView_Duplicates.Size = new System.Drawing.Size(1038, 277);
			this.my_dataGridView_Duplicates.TabIndex = 1;
			this.my_dataGridView_Duplicates.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_Duplicates_CellContentClick);
			// 
			// deleteDataGridViewCheckBoxColumn
			// 
			this.deleteDataGridViewCheckBoxColumn.DataPropertyName = "Delete";
			this.deleteDataGridViewCheckBoxColumn.HeaderText = "Delete";
			this.deleteDataGridViewCheckBoxColumn.Name = "deleteDataGridViewCheckBoxColumn";
			// 
			// titleDataGridViewTextBoxColumn
			// 
			this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
			this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
			this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
			// 
			// artistDataGridViewTextBoxColumn
			// 
			this.artistDataGridViewTextBoxColumn.DataPropertyName = "Artist";
			this.artistDataGridViewTextBoxColumn.HeaderText = "Artist";
			this.artistDataGridViewTextBoxColumn.Name = "artistDataGridViewTextBoxColumn";
			// 
			// durationDataGridViewTextBoxColumn
			// 
			this.durationDataGridViewTextBoxColumn.DataPropertyName = "Duration";
			this.durationDataGridViewTextBoxColumn.HeaderText = "Duration";
			this.durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
			this.durationDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// sizeDataGridViewTextBoxColumn1
			// 
			this.sizeDataGridViewTextBoxColumn1.DataPropertyName = "Size";
			this.sizeDataGridViewTextBoxColumn1.HeaderText = "Size";
			this.sizeDataGridViewTextBoxColumn1.Name = "sizeDataGridViewTextBoxColumn1";
			this.sizeDataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// pathDataGridViewTextBoxColumn
			// 
			this.pathDataGridViewTextBoxColumn.DataPropertyName = "Path";
			this.pathDataGridViewTextBoxColumn.FillWeight = 400F;
			this.pathDataGridViewTextBoxColumn.HeaderText = "Path";
			this.pathDataGridViewTextBoxColumn.Name = "pathDataGridViewTextBoxColumn";
			this.pathDataGridViewTextBoxColumn.ReadOnly = true;
			this.pathDataGridViewTextBoxColumn.Width = 200;
			// 
			// duplicateIdDataGridViewTextBoxColumn
			// 
			this.duplicateIdDataGridViewTextBoxColumn.DataPropertyName = "Duplicate_Id";
			this.duplicateIdDataGridViewTextBoxColumn.HeaderText = "Duplicate_Id";
			this.duplicateIdDataGridViewTextBoxColumn.Name = "duplicateIdDataGridViewTextBoxColumn";
			this.duplicateIdDataGridViewTextBoxColumn.Visible = false;
			// 
			// Play
			// 
			this.Play.HeaderText = "Play";
			this.Play.Name = "Play";
			// 
			// my_contextMenuStrip_Duplicates
			// 
			this.my_contextMenuStrip_Duplicates.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.my_copyToolStripMenuItem,
            this.my_pasteToolStripMenuItem,
            this.tToolStripMenuItem,
            this.my_playToolStripMenuItem,
            this.toolStripSeparator1,
            this.my_deleteToolStripMenuItem});
			this.my_contextMenuStrip_Duplicates.Name = "my_contextMenuStrip_Duplicates";
			this.my_contextMenuStrip_Duplicates.Size = new System.Drawing.Size(151, 104);
			this.my_contextMenuStrip_Duplicates.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenuStrip_Duplicates_Opening);
			// 
			// my_copyToolStripMenuItem
			// 
			this.my_copyToolStripMenuItem.Name = "my_copyToolStripMenuItem";
			this.my_copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
			this.my_copyToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
			this.my_copyToolStripMenuItem.Text = "Copy";
			this.my_copyToolStripMenuItem.Click += new System.EventHandler(this.Copy_ToolStripMenuItem_Click);
			// 
			// my_pasteToolStripMenuItem
			// 
			this.my_pasteToolStripMenuItem.Name = "my_pasteToolStripMenuItem";
			this.my_pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
			this.my_pasteToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
			this.my_pasteToolStripMenuItem.Text = "Paste";
			// 
			// tToolStripMenuItem
			// 
			this.tToolStripMenuItem.Name = "tToolStripMenuItem";
			this.tToolStripMenuItem.Size = new System.Drawing.Size(147, 6);
			// 
			// my_playToolStripMenuItem
			// 
			this.my_playToolStripMenuItem.Name = "my_playToolStripMenuItem";
			this.my_playToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
			this.my_playToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
			this.my_playToolStripMenuItem.Text = "Play";
			this.my_playToolStripMenuItem.Click += new System.EventHandler(this.Play_ToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(147, 6);
			// 
			// my_deleteToolStripMenuItem
			// 
			this.my_deleteToolStripMenuItem.Name = "my_deleteToolStripMenuItem";
			this.my_deleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
			this.my_deleteToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
			this.my_deleteToolStripMenuItem.Text = "Delete";
			this.my_deleteToolStripMenuItem.Click += new System.EventHandler(this.Delete_ToolStripMenuItem_Click);
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButtonIncluedeSubdirectories,
            this.toolStripSeparator2,
            this.toolStripButtonViewDeleteList,
            this.toolStripButtonClearDirectories,
            this.toolStripSeparator3,
            this.toolStripButtonShowHideDirectoryList});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1038, 25);
			this.toolStrip1.TabIndex = 4;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(98, 22);
			this.toolStripButton1.Text = "Find duplicates";
			this.toolStripButton1.ToolTipText = "Find duplicates in directories";
			this.toolStripButton1.Click += new System.EventHandler(this.Button_Compare_Click);
			// 
			// toolStripButtonIncluedeSubdirectories
			// 
			this.toolStripButtonIncluedeSubdirectories.Checked = true;
			this.toolStripButtonIncluedeSubdirectories.CheckOnClick = true;
			this.toolStripButtonIncluedeSubdirectories.CheckState = System.Windows.Forms.CheckState.Checked;
			this.toolStripButtonIncluedeSubdirectories.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonIncluedeSubdirectories.Image")));
			this.toolStripButtonIncluedeSubdirectories.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonIncluedeSubdirectories.Name = "toolStripButtonIncluedeSubdirectories";
			this.toolStripButtonIncluedeSubdirectories.Size = new System.Drawing.Size(139, 22);
			this.toolStripButtonIncluedeSubdirectories.Text = "Incluede Subdirectories";
			this.toolStripButtonIncluedeSubdirectories.ToolTipText = "Incluede Subdirectories in search";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripButtonViewDeleteList
			// 
			this.toolStripButtonViewDeleteList.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonViewDeleteList.Image")));
			this.toolStripButtonViewDeleteList.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonViewDeleteList.Name = "toolStripButtonViewDeleteList";
			this.toolStripButtonViewDeleteList.Size = new System.Drawing.Size(114, 22);
			this.toolStripButtonViewDeleteList.Text = "View selected files";
			this.toolStripButtonViewDeleteList.Click += new System.EventHandler(this.Button_DeleteSelected_Click);
			// 
			// toolStripButtonClearDirectories
			// 
			this.toolStripButtonClearDirectories.Enabled = false;
			this.toolStripButtonClearDirectories.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonClearDirectories.Image")));
			this.toolStripButtonClearDirectories.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonClearDirectories.Name = "toolStripButtonClearDirectories";
			this.toolStripButtonClearDirectories.Size = new System.Drawing.Size(105, 22);
			this.toolStripButtonClearDirectories.Text = "Clear directories";
			this.toolStripButtonClearDirectories.Click += new System.EventHandler(this.Button_Clear_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripButtonShowHideDirectoryList
			// 
			this.toolStripButtonShowHideDirectoryList.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.toolStripButtonShowHideDirectoryList.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonShowHideDirectoryList.Image")));
			this.toolStripButtonShowHideDirectoryList.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonShowHideDirectoryList.Name = "toolStripButtonShowHideDirectoryList";
			this.toolStripButtonShowHideDirectoryList.Size = new System.Drawing.Size(106, 22);
			this.toolStripButtonShowHideDirectoryList.Text = "Hide direcory list";
			this.toolStripButtonShowHideDirectoryList.Click += new System.EventHandler(this.ButtonShowHideDirectoryList_Click);
			// 
			// checkedListBox1
			// 
			this.checkedListBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.checkedListBox1.FormattingEnabled = true;
			this.checkedListBox1.Location = new System.Drawing.Point(3, 63);
			this.checkedListBox1.Name = "checkedListBox1";
			this.checkedListBox1.Size = new System.Drawing.Size(1032, 109);
			this.checkedListBox1.TabIndex = 1;
			// 
			// folderSelector1
			// 
			this.folderSelector1.ActualPath = "";
			this.folderSelector1.Dock = System.Windows.Forms.DockStyle.Top;
			this.folderSelector1.Location = new System.Drawing.Point(3, 16);
			this.folderSelector1.Name = "folderSelector1";
			this.folderSelector1.Paths = new string[] {
        ""};
			this.folderSelector1.Size = new System.Drawing.Size(1032, 47);
			this.folderSelector1.TabIndex = 0;
			// 
			// UserControlCompareDuplicates
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.my_main_panel);
			this.Name = "UserControlCompareDuplicates";
			this.Size = new System.Drawing.Size(1038, 806);
			this.my_main_panel.ResumeLayout(false);
			this.my_main_panel.PerformLayout();
			this.my_splitContainer.Panel1.ResumeLayout(false);
			this.my_splitContainer.Panel1.PerformLayout();
			this.my_splitContainer.Panel2.ResumeLayout(false);
			this.my_splitContainer.ResumeLayout(false);
			this.My_GroupBox_Top.ResumeLayout(false);
			this.my_splitContainer_DS.Panel1.ResumeLayout(false);
			this.my_splitContainer_DS.Panel2.ResumeLayout(false);
			this.my_splitContainer_DS.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.my_dataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.my_dataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.my_dataTable_ID3Info)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.my_dataTable_FileInfo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.my_dataGridView_Duplicates)).EndInit();
			this.my_contextMenuStrip_Duplicates.ResumeLayout(false);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel my_main_panel;
        private System.Windows.Forms.GroupBox My_GroupBox_Top;
        private UserControlFolderSelector my_folderSelector;
        private System.Windows.Forms.CheckedListBox my_checkedListBox_FolderList;
		private System.Windows.Forms.SplitContainer my_splitContainer;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
		private UserControlFolderSelector folderSelector1;
        private System.Windows.Forms.DataGridView my_dataGridView;
        private System.Data.DataSet my_dataSet;
        private System.Data.DataTable my_dataTable_ID3Info;
        private System.Data.DataTable my_dataTable_FileInfo;
        private System.Data.DataColumn my_id3Info_dc_title;
        private System.Data.DataColumn my_fileinfo_dc_name;
        private System.Data.DataColumn my_id3Info_dc_artist;
        private System.Data.DataColumn my_id3Info_dc_duration;
        private System.Data.DataColumn my_id3Info_dc_size;
        private System.Data.DataColumn my_id3Info_dc_path;
        private System.Data.DataColumn my_id3Info_dc_delete;
        private System.Data.DataColumn my_id3Info_dc_dupl_id;
        private System.Data.DataColumn my_fileinfo_dc_id;
        private System.Data.DataColumn my_fileinfo_dc_duration;
        private System.Data.DataColumn my_fileinfo_dc_size;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn duretionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.SplitContainer my_splitContainer_DS;
		private System.Windows.Forms.DataGridView my_dataGridView_Duplicates;
        private System.Windows.Forms.ContextMenuStrip my_contextMenuStrip_Duplicates;
        private System.Windows.Forms.ToolStripMenuItem my_copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem my_pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator tToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem my_deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem my_playToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn deleteDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn duplicateIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Play;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStripButton toolStripButtonIncluedeSubdirectories;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton toolStripButtonClearDirectories;
		private System.Windows.Forms.ToolStripButton toolStripButtonViewDeleteList;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripButton toolStripButtonShowHideDirectoryList;
    }
}
