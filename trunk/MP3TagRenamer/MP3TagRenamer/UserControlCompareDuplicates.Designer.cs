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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlCompareDuplicates));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.my_main_panel = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonFindDuplicates = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonIncluedeSubdirectories = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonViewDeleteList = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonClearDirectories = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonShowHideDirectoryList = new System.Windows.Forms.ToolStripButton();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.folderSelector1 = new MP3TagRenamer.UserControlFolderSelector();
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
            this.my_main_panel.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // my_splitContainer
            // 
            this.my_splitContainer.AccessibleDescription = null;
            this.my_splitContainer.AccessibleName = null;
            resources.ApplyResources(this.my_splitContainer, "my_splitContainer");
            this.my_splitContainer.BackColor = System.Drawing.SystemColors.Control;
            this.my_splitContainer.BackgroundImage = null;
            this.my_splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.my_splitContainer.Font = null;
            this.my_splitContainer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.my_splitContainer.Name = "my_splitContainer";
            // 
            // my_splitContainer.Panel1
            // 
            this.my_splitContainer.Panel1.AccessibleDescription = null;
            this.my_splitContainer.Panel1.AccessibleName = null;
            resources.ApplyResources(this.my_splitContainer.Panel1, "my_splitContainer.Panel1");
            this.my_splitContainer.Panel1.BackgroundImage = null;
            this.my_splitContainer.Panel1.Controls.Add(this.My_GroupBox_Top);
            this.my_splitContainer.Panel1.Font = null;
            // 
            // my_splitContainer.Panel2
            // 
            this.my_splitContainer.Panel2.AccessibleDescription = null;
            this.my_splitContainer.Panel2.AccessibleName = null;
            resources.ApplyResources(this.my_splitContainer.Panel2, "my_splitContainer.Panel2");
            this.my_splitContainer.Panel2.BackgroundImage = null;
            this.my_splitContainer.Panel2.Controls.Add(this.my_splitContainer_DS);
            this.my_splitContainer.Panel2.Font = null;
            // 
            // My_GroupBox_Top
            // 
            this.My_GroupBox_Top.AccessibleDescription = null;
            this.My_GroupBox_Top.AccessibleName = null;
            resources.ApplyResources(this.My_GroupBox_Top, "My_GroupBox_Top");
            this.My_GroupBox_Top.BackgroundImage = null;
            this.My_GroupBox_Top.Controls.Add(this.my_checkedListBox_FolderList);
            this.My_GroupBox_Top.Controls.Add(this.my_folderSelector);
            this.My_GroupBox_Top.Font = null;
            this.My_GroupBox_Top.Name = "My_GroupBox_Top";
            this.My_GroupBox_Top.TabStop = false;
            // 
            // my_checkedListBox_FolderList
            // 
            this.my_checkedListBox_FolderList.AccessibleDescription = null;
            this.my_checkedListBox_FolderList.AccessibleName = null;
            resources.ApplyResources(this.my_checkedListBox_FolderList, "my_checkedListBox_FolderList");
            this.my_checkedListBox_FolderList.BackgroundImage = null;
            this.my_checkedListBox_FolderList.Font = null;
            this.my_checkedListBox_FolderList.FormattingEnabled = true;
            this.my_checkedListBox_FolderList.Name = "my_checkedListBox_FolderList";
            // 
            // my_folderSelector
            // 
            this.my_folderSelector.AccessibleDescription = null;
            this.my_folderSelector.AccessibleName = null;
            this.my_folderSelector.ActualPath = "";
            resources.ApplyResources(this.my_folderSelector, "my_folderSelector");
            this.my_folderSelector.BackgroundImage = null;
            this.my_folderSelector.Font = null;
            this.my_folderSelector.Name = "my_folderSelector";
            this.my_folderSelector.Paths = new string[] {
        ""};
            // 
            // my_splitContainer_DS
            // 
            this.my_splitContainer_DS.AccessibleDescription = null;
            this.my_splitContainer_DS.AccessibleName = null;
            resources.ApplyResources(this.my_splitContainer_DS, "my_splitContainer_DS");
            this.my_splitContainer_DS.BackgroundImage = null;
            this.my_splitContainer_DS.Font = null;
            this.my_splitContainer_DS.Name = "my_splitContainer_DS";
            // 
            // my_splitContainer_DS.Panel1
            // 
            this.my_splitContainer_DS.Panel1.AccessibleDescription = null;
            this.my_splitContainer_DS.Panel1.AccessibleName = null;
            resources.ApplyResources(this.my_splitContainer_DS.Panel1, "my_splitContainer_DS.Panel1");
            this.my_splitContainer_DS.Panel1.BackgroundImage = null;
            this.my_splitContainer_DS.Panel1.Controls.Add(this.my_dataGridView);
            this.my_splitContainer_DS.Panel1.Font = null;
            // 
            // my_splitContainer_DS.Panel2
            // 
            this.my_splitContainer_DS.Panel2.AccessibleDescription = null;
            this.my_splitContainer_DS.Panel2.AccessibleName = null;
            resources.ApplyResources(this.my_splitContainer_DS.Panel2, "my_splitContainer_DS.Panel2");
            this.my_splitContainer_DS.Panel2.BackgroundImage = null;
            this.my_splitContainer_DS.Panel2.Controls.Add(this.my_dataGridView_Duplicates);
            this.my_splitContainer_DS.Panel2.Font = null;
            // 
            // my_dataGridView
            // 
            this.my_dataGridView.AccessibleDescription = null;
            this.my_dataGridView.AccessibleName = null;
            this.my_dataGridView.AllowUserToAddRows = false;
            this.my_dataGridView.AllowUserToOrderColumns = true;
            resources.ApplyResources(this.my_dataGridView, "my_dataGridView");
            this.my_dataGridView.AutoGenerateColumns = false;
            this.my_dataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.my_dataGridView.BackgroundImage = null;
            this.my_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.my_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.duretionDataGridViewTextBoxColumn,
            this.sizeDataGridViewTextBoxColumn});
            this.my_dataGridView.DataMember = "FileInfo";
            this.my_dataGridView.DataSource = this.my_dataSet;
            this.my_dataGridView.Font = null;
            this.my_dataGridView.Name = "my_dataGridView";
            this.my_dataGridView.ReadOnly = true;
            this.my_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.my_dataGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_Files_RowEnter);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            resources.ApplyResources(this.nameDataGridViewTextBoxColumn, "nameDataGridViewTextBoxColumn");
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            resources.ApplyResources(this.idDataGridViewTextBoxColumn, "idDataGridViewTextBoxColumn");
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // duretionDataGridViewTextBoxColumn
            // 
            this.duretionDataGridViewTextBoxColumn.DataPropertyName = "Duretion";
            resources.ApplyResources(this.duretionDataGridViewTextBoxColumn, "duretionDataGridViewTextBoxColumn");
            this.duretionDataGridViewTextBoxColumn.Name = "duretionDataGridViewTextBoxColumn";
            this.duretionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sizeDataGridViewTextBoxColumn
            // 
            this.sizeDataGridViewTextBoxColumn.DataPropertyName = "Size";
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.sizeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.sizeDataGridViewTextBoxColumn, "sizeDataGridViewTextBoxColumn");
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
            this.my_dataGridView_Duplicates.AccessibleDescription = null;
            this.my_dataGridView_Duplicates.AccessibleName = null;
            this.my_dataGridView_Duplicates.AllowUserToAddRows = false;
            this.my_dataGridView_Duplicates.AllowUserToOrderColumns = true;
            resources.ApplyResources(this.my_dataGridView_Duplicates, "my_dataGridView_Duplicates");
            this.my_dataGridView_Duplicates.AutoGenerateColumns = false;
            this.my_dataGridView_Duplicates.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.my_dataGridView_Duplicates.BackgroundImage = null;
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
            this.my_dataGridView_Duplicates.Font = null;
            this.my_dataGridView_Duplicates.Name = "my_dataGridView_Duplicates";
            this.my_dataGridView_Duplicates.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_Duplicates_CellContentClick);
            // 
            // deleteDataGridViewCheckBoxColumn
            // 
            this.deleteDataGridViewCheckBoxColumn.DataPropertyName = "Delete";
            resources.ApplyResources(this.deleteDataGridViewCheckBoxColumn, "deleteDataGridViewCheckBoxColumn");
            this.deleteDataGridViewCheckBoxColumn.Name = "deleteDataGridViewCheckBoxColumn";
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            resources.ApplyResources(this.titleDataGridViewTextBoxColumn, "titleDataGridViewTextBoxColumn");
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // artistDataGridViewTextBoxColumn
            // 
            this.artistDataGridViewTextBoxColumn.DataPropertyName = "Artist";
            resources.ApplyResources(this.artistDataGridViewTextBoxColumn, "artistDataGridViewTextBoxColumn");
            this.artistDataGridViewTextBoxColumn.Name = "artistDataGridViewTextBoxColumn";
            // 
            // durationDataGridViewTextBoxColumn
            // 
            this.durationDataGridViewTextBoxColumn.DataPropertyName = "Duration";
            resources.ApplyResources(this.durationDataGridViewTextBoxColumn, "durationDataGridViewTextBoxColumn");
            this.durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
            this.durationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sizeDataGridViewTextBoxColumn1
            // 
            this.sizeDataGridViewTextBoxColumn1.DataPropertyName = "Size";
            resources.ApplyResources(this.sizeDataGridViewTextBoxColumn1, "sizeDataGridViewTextBoxColumn1");
            this.sizeDataGridViewTextBoxColumn1.Name = "sizeDataGridViewTextBoxColumn1";
            this.sizeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // pathDataGridViewTextBoxColumn
            // 
            this.pathDataGridViewTextBoxColumn.DataPropertyName = "Path";
            this.pathDataGridViewTextBoxColumn.FillWeight = 400F;
            resources.ApplyResources(this.pathDataGridViewTextBoxColumn, "pathDataGridViewTextBoxColumn");
            this.pathDataGridViewTextBoxColumn.Name = "pathDataGridViewTextBoxColumn";
            this.pathDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // duplicateIdDataGridViewTextBoxColumn
            // 
            this.duplicateIdDataGridViewTextBoxColumn.DataPropertyName = "Duplicate_Id";
            resources.ApplyResources(this.duplicateIdDataGridViewTextBoxColumn, "duplicateIdDataGridViewTextBoxColumn");
            this.duplicateIdDataGridViewTextBoxColumn.Name = "duplicateIdDataGridViewTextBoxColumn";
            // 
            // Play
            // 
            resources.ApplyResources(this.Play, "Play");
            this.Play.Name = "Play";
            // 
            // my_contextMenuStrip_Duplicates
            // 
            this.my_contextMenuStrip_Duplicates.AccessibleDescription = null;
            this.my_contextMenuStrip_Duplicates.AccessibleName = null;
            resources.ApplyResources(this.my_contextMenuStrip_Duplicates, "my_contextMenuStrip_Duplicates");
            this.my_contextMenuStrip_Duplicates.BackgroundImage = null;
            this.my_contextMenuStrip_Duplicates.Font = null;
            this.my_contextMenuStrip_Duplicates.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.my_copyToolStripMenuItem,
            this.my_pasteToolStripMenuItem,
            this.tToolStripMenuItem,
            this.my_playToolStripMenuItem,
            this.toolStripSeparator1,
            this.my_deleteToolStripMenuItem});
            this.my_contextMenuStrip_Duplicates.Name = "my_contextMenuStrip_Duplicates";
            this.my_contextMenuStrip_Duplicates.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenuStrip_Duplicates_Opening);
            // 
            // my_copyToolStripMenuItem
            // 
            this.my_copyToolStripMenuItem.AccessibleDescription = null;
            this.my_copyToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.my_copyToolStripMenuItem, "my_copyToolStripMenuItem");
            this.my_copyToolStripMenuItem.BackgroundImage = null;
            this.my_copyToolStripMenuItem.Name = "my_copyToolStripMenuItem";
            this.my_copyToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.my_copyToolStripMenuItem.Click += new System.EventHandler(this.Copy_ToolStripMenuItem_Click);
            // 
            // my_pasteToolStripMenuItem
            // 
            this.my_pasteToolStripMenuItem.AccessibleDescription = null;
            this.my_pasteToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.my_pasteToolStripMenuItem, "my_pasteToolStripMenuItem");
            this.my_pasteToolStripMenuItem.BackgroundImage = null;
            this.my_pasteToolStripMenuItem.Name = "my_pasteToolStripMenuItem";
            this.my_pasteToolStripMenuItem.ShortcutKeyDisplayString = null;
            // 
            // tToolStripMenuItem
            // 
            this.tToolStripMenuItem.AccessibleDescription = null;
            this.tToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.tToolStripMenuItem, "tToolStripMenuItem");
            this.tToolStripMenuItem.Name = "tToolStripMenuItem";
            // 
            // my_playToolStripMenuItem
            // 
            this.my_playToolStripMenuItem.AccessibleDescription = null;
            this.my_playToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.my_playToolStripMenuItem, "my_playToolStripMenuItem");
            this.my_playToolStripMenuItem.BackgroundImage = null;
            this.my_playToolStripMenuItem.Name = "my_playToolStripMenuItem";
            this.my_playToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.my_playToolStripMenuItem.Click += new System.EventHandler(this.Play_ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.AccessibleDescription = null;
            this.toolStripSeparator1.AccessibleName = null;
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // my_deleteToolStripMenuItem
            // 
            this.my_deleteToolStripMenuItem.AccessibleDescription = null;
            this.my_deleteToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.my_deleteToolStripMenuItem, "my_deleteToolStripMenuItem");
            this.my_deleteToolStripMenuItem.BackgroundImage = null;
            this.my_deleteToolStripMenuItem.Name = "my_deleteToolStripMenuItem";
            this.my_deleteToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.my_deleteToolStripMenuItem.Click += new System.EventHandler(this.Delete_ToolStripMenuItem_Click);
            // 
            // my_main_panel
            // 
            this.my_main_panel.AccessibleDescription = null;
            this.my_main_panel.AccessibleName = null;
            resources.ApplyResources(this.my_main_panel, "my_main_panel");
            this.my_main_panel.BackgroundImage = null;
            this.my_main_panel.Controls.Add(this.my_splitContainer);
            this.my_main_panel.Controls.Add(this.toolStrip1);
            this.my_main_panel.Font = null;
            this.my_main_panel.Name = "my_main_panel";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AccessibleDescription = null;
            this.toolStrip1.AccessibleName = null;
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.BackgroundImage = null;
            this.toolStrip1.Font = null;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonFindDuplicates,
            this.toolStripButtonIncluedeSubdirectories,
            this.toolStripSeparator2,
            this.toolStripButtonViewDeleteList,
            this.toolStripButtonClearDirectories,
            this.toolStripSeparator3,
            this.toolStripButtonShowHideDirectoryList});
            this.toolStrip1.Name = "toolStrip1";
            // 
            // toolStripButtonFindDuplicates
            // 
            this.toolStripButtonFindDuplicates.AccessibleDescription = null;
            this.toolStripButtonFindDuplicates.AccessibleName = null;
            resources.ApplyResources(this.toolStripButtonFindDuplicates, "toolStripButtonFindDuplicates");
            this.toolStripButtonFindDuplicates.BackgroundImage = null;
            this.toolStripButtonFindDuplicates.Name = "toolStripButtonFindDuplicates";
            this.toolStripButtonFindDuplicates.Click += new System.EventHandler(this.Button_Compare_Click);
            // 
            // toolStripButtonIncluedeSubdirectories
            // 
            this.toolStripButtonIncluedeSubdirectories.AccessibleDescription = null;
            this.toolStripButtonIncluedeSubdirectories.AccessibleName = null;
            resources.ApplyResources(this.toolStripButtonIncluedeSubdirectories, "toolStripButtonIncluedeSubdirectories");
            this.toolStripButtonIncluedeSubdirectories.BackgroundImage = null;
            this.toolStripButtonIncluedeSubdirectories.Checked = true;
            this.toolStripButtonIncluedeSubdirectories.CheckOnClick = true;
            this.toolStripButtonIncluedeSubdirectories.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripButtonIncluedeSubdirectories.Name = "toolStripButtonIncluedeSubdirectories";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.AccessibleDescription = null;
            this.toolStripSeparator2.AccessibleName = null;
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            // 
            // toolStripButtonViewDeleteList
            // 
            this.toolStripButtonViewDeleteList.AccessibleDescription = null;
            this.toolStripButtonViewDeleteList.AccessibleName = null;
            resources.ApplyResources(this.toolStripButtonViewDeleteList, "toolStripButtonViewDeleteList");
            this.toolStripButtonViewDeleteList.BackgroundImage = null;
            this.toolStripButtonViewDeleteList.Name = "toolStripButtonViewDeleteList";
            this.toolStripButtonViewDeleteList.Click += new System.EventHandler(this.Button_DeleteSelected_Click);
            // 
            // toolStripButtonClearDirectories
            // 
            this.toolStripButtonClearDirectories.AccessibleDescription = null;
            this.toolStripButtonClearDirectories.AccessibleName = null;
            resources.ApplyResources(this.toolStripButtonClearDirectories, "toolStripButtonClearDirectories");
            this.toolStripButtonClearDirectories.BackgroundImage = null;
            this.toolStripButtonClearDirectories.Name = "toolStripButtonClearDirectories";
            this.toolStripButtonClearDirectories.Click += new System.EventHandler(this.Button_Clear_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.AccessibleDescription = null;
            this.toolStripSeparator3.AccessibleName = null;
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            this.toolStripSeparator3.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            // 
            // toolStripButtonShowHideDirectoryList
            // 
            this.toolStripButtonShowHideDirectoryList.AccessibleDescription = null;
            this.toolStripButtonShowHideDirectoryList.AccessibleName = null;
            this.toolStripButtonShowHideDirectoryList.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            resources.ApplyResources(this.toolStripButtonShowHideDirectoryList, "toolStripButtonShowHideDirectoryList");
            this.toolStripButtonShowHideDirectoryList.BackgroundImage = null;
            this.toolStripButtonShowHideDirectoryList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonShowHideDirectoryList.Name = "toolStripButtonShowHideDirectoryList";
            this.toolStripButtonShowHideDirectoryList.Click += new System.EventHandler(this.ButtonShowHideDirectoryList_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.AccessibleDescription = null;
            this.checkedListBox1.AccessibleName = null;
            resources.ApplyResources(this.checkedListBox1, "checkedListBox1");
            this.checkedListBox1.BackgroundImage = null;
            this.checkedListBox1.Font = null;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Name = "checkedListBox1";
            // 
            // folderSelector1
            // 
            this.folderSelector1.AccessibleDescription = null;
            this.folderSelector1.AccessibleName = null;
            this.folderSelector1.ActualPath = "";
            resources.ApplyResources(this.folderSelector1, "folderSelector1");
            this.folderSelector1.BackgroundImage = null;
            this.folderSelector1.Font = null;
            this.folderSelector1.Name = "folderSelector1";
            this.folderSelector1.Paths = new string[] {
        ""};
            // 
            // UserControlCompareDuplicates
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.Controls.Add(this.my_main_panel);
            this.Font = null;
            this.Name = "UserControlCompareDuplicates";
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
            this.my_main_panel.ResumeLayout(false);
            this.my_main_panel.PerformLayout();
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
        private System.Windows.Forms.SplitContainer my_splitContainer_DS;
		private System.Windows.Forms.DataGridView my_dataGridView_Duplicates;
        private System.Windows.Forms.ContextMenuStrip my_contextMenuStrip_Duplicates;
        private System.Windows.Forms.ToolStripMenuItem my_copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem my_pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator tToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem my_deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem my_playToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton toolStripButtonFindDuplicates;
		private System.Windows.Forms.ToolStripButton toolStripButtonIncluedeSubdirectories;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton toolStripButtonClearDirectories;
		private System.Windows.Forms.ToolStripButton toolStripButtonViewDeleteList;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButtonShowHideDirectoryList;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn duretionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn deleteDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn duplicateIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Play;
    }
}
