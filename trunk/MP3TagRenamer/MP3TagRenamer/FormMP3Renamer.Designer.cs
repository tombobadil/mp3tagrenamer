namespace MP3TagRenamer
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.my_label_ID3V2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.my_label_ID3V1 = new System.Windows.Forms.Label();
            this.my_dataGridView_MP3s = new System.Windows.Forms.DataGridView();
            this.my_play_datagridcolumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.trackNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.albumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.My_UltraID3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.My_FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.my_textBox_removeText = new System.Windows.Forms.TextBox();
            this.my_button_removeText = new System.Windows.Forms.Button();
            this.my_textBox_fixTitle = new System.Windows.Forms.TextBox();
            this.my_button_fixTitle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.my_button_GetTrackNrFronTitle = new System.Windows.Forms.Button();
            this.my_button_ClearComments = new System.Windows.Forms.Button();
            this.My_TabControl_BatchRen = new System.Windows.Forms.TabControl();
            this.My_TabPage_Batch = new System.Windows.Forms.TabPage();
            this.my_comboBox_Ganre = new System.Windows.Forms.ComboBox();
            this.my_textBox_Year = new System.Windows.Forms.TextBox();
            this.my_checkBox_Year = new System.Windows.Forms.CheckBox();
            this.my_checkBox_Ganre = new System.Windows.Forms.CheckBox();
            this.my_textBox_Album = new System.Windows.Forms.TextBox();
            this.my_checkBox_Album = new System.Windows.Forms.CheckBox();
            this.my_button_UpdateBatch = new System.Windows.Forms.Button();
            this.my_textBox_Artist = new System.Windows.Forms.TextBox();
            this.my_checkBox_artist = new System.Windows.Forms.CheckBox();
            this.my_tabPage_Renaming = new System.Windows.Forms.TabPage();
            this.GroupBox_ExtractFromFName = new System.Windows.Forms.GroupBox();
            this.ComboBox_ExtractTagsFromFNmane = new System.Windows.Forms.ComboBox();
            this.Button_ExtractFRomFName = new System.Windows.Forms.Button();
            this.Button_regexp_properties = new System.Windows.Forms.Button();
            this.Button_ExtracFromFName_Test = new System.Windows.Forms.Button();
            this.Label_Regextpresult = new System.Windows.Forms.Label();
            this.TextBox_TestPath = new System.Windows.Forms.TextBox();
            this.my_checkBox_UseRegExp = new System.Windows.Forms.CheckBox();
            this.y_splitContainer_Main = new System.Windows.Forms.SplitContainer();
            this.my_folderSelector = new MP3TagRenamer.UserControlFolderSelector();
            this.My_MenuStrip = new System.Windows.Forms.MenuStrip();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.batchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renamingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.svenskaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bosniskaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.my_helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.my_aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.My_HelpProvider = new System.Windows.Forms.HelpProvider();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.my_dataGridView_MP3s)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.My_UltraID3BindingSource)).BeginInit();
            this.My_TabControl_BatchRen.SuspendLayout();
            this.My_TabPage_Batch.SuspendLayout();
            this.my_tabPage_Renaming.SuspendLayout();
            this.GroupBox_ExtractFromFName.SuspendLayout();
            this.y_splitContainer_Main.Panel1.SuspendLayout();
            this.y_splitContainer_Main.Panel2.SuspendLayout();
            this.y_splitContainer_Main.SuspendLayout();
            this.My_MenuStrip.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.my_label_ID3V2);
            this.groupBox1.Location = new System.Drawing.Point(301, 215);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 87);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ID3 V2";
            // 
            // my_label_ID3V2
            // 
            this.my_label_ID3V2.AutoSize = true;
            this.my_label_ID3V2.Location = new System.Drawing.Point(7, 20);
            this.my_label_ID3V2.Name = "my_label_ID3V2";
            this.my_label_ID3V2.Size = new System.Drawing.Size(0, 13);
            this.my_label_ID3V2.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.my_label_ID3V1);
            this.groupBox2.Location = new System.Drawing.Point(13, 215);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 87);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ID3 V1";
            // 
            // my_label_ID3V1
            // 
            this.my_label_ID3V1.AutoSize = true;
            this.my_label_ID3V1.Location = new System.Drawing.Point(6, 20);
            this.my_label_ID3V1.Name = "my_label_ID3V1";
            this.my_label_ID3V1.Size = new System.Drawing.Size(0, 13);
            this.my_label_ID3V1.TabIndex = 0;
            // 
            // my_dataGridView_MP3s
            // 
            this.my_dataGridView_MP3s.AllowUserToAddRows = false;
            this.my_dataGridView_MP3s.AllowUserToOrderColumns = true;
            this.my_dataGridView_MP3s.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.my_dataGridView_MP3s.AutoGenerateColumns = false;
            this.my_dataGridView_MP3s.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.my_dataGridView_MP3s.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.my_play_datagridcolumn,
            this.trackNumDataGridViewTextBoxColumn,
            this.artistDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.genreDataGridViewTextBoxColumn,
            this.albumDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.sizeDataGridViewTextBoxColumn,
            this.commentsDataGridViewTextBoxColumn,
            this.durationDataGridViewTextBoxColumn,
            this.fileNameDataGridViewTextBoxColumn});
            this.my_dataGridView_MP3s.DataSource = this.My_UltraID3BindingSource;
            this.my_dataGridView_MP3s.Location = new System.Drawing.Point(13, 56);
            this.my_dataGridView_MP3s.Name = "my_dataGridView_MP3s";
            this.my_dataGridView_MP3s.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.my_dataGridView_MP3s.Size = new System.Drawing.Size(842, 309);
            this.my_dataGridView_MP3s.TabIndex = 2;
            this.my_dataGridView_MP3s.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_MP3s_RowEnter);
            this.my_dataGridView_MP3s.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_MP3s_CellContentClick);
            // 
            // my_play_datagridcolumn
            // 
            this.my_play_datagridcolumn.HeaderText = "Play";
            this.my_play_datagridcolumn.Image = ((System.Drawing.Image)(resources.GetObject("my_play_datagridcolumn.Image")));
            this.my_play_datagridcolumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.my_play_datagridcolumn.Name = "my_play_datagridcolumn";
            this.my_play_datagridcolumn.Width = 33;
            // 
            // trackNumDataGridViewTextBoxColumn
            // 
            this.trackNumDataGridViewTextBoxColumn.DataPropertyName = "TrackNum";
            this.trackNumDataGridViewTextBoxColumn.HeaderText = "TrackNum";
            this.trackNumDataGridViewTextBoxColumn.Name = "trackNumDataGridViewTextBoxColumn";
            this.trackNumDataGridViewTextBoxColumn.Width = 82;
            // 
            // artistDataGridViewTextBoxColumn
            // 
            this.artistDataGridViewTextBoxColumn.DataPropertyName = "Artist";
            this.artistDataGridViewTextBoxColumn.HeaderText = "Artist";
            this.artistDataGridViewTextBoxColumn.Name = "artistDataGridViewTextBoxColumn";
            this.artistDataGridViewTextBoxColumn.Width = 55;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.Width = 52;
            // 
            // genreDataGridViewTextBoxColumn
            // 
            this.genreDataGridViewTextBoxColumn.DataPropertyName = "Genre";
            this.genreDataGridViewTextBoxColumn.HeaderText = "Genre";
            this.genreDataGridViewTextBoxColumn.Name = "genreDataGridViewTextBoxColumn";
            this.genreDataGridViewTextBoxColumn.Width = 61;
            // 
            // albumDataGridViewTextBoxColumn
            // 
            this.albumDataGridViewTextBoxColumn.DataPropertyName = "Album";
            this.albumDataGridViewTextBoxColumn.HeaderText = "Album";
            this.albumDataGridViewTextBoxColumn.Name = "albumDataGridViewTextBoxColumn";
            this.albumDataGridViewTextBoxColumn.Width = 61;
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Year";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            this.yearDataGridViewTextBoxColumn.Width = 54;
            // 
            // sizeDataGridViewTextBoxColumn
            // 
            this.sizeDataGridViewTextBoxColumn.DataPropertyName = "Size";
            this.sizeDataGridViewTextBoxColumn.HeaderText = "Size";
            this.sizeDataGridViewTextBoxColumn.Name = "sizeDataGridViewTextBoxColumn";
            this.sizeDataGridViewTextBoxColumn.ReadOnly = true;
            this.sizeDataGridViewTextBoxColumn.Width = 52;
            // 
            // commentsDataGridViewTextBoxColumn
            // 
            this.commentsDataGridViewTextBoxColumn.DataPropertyName = "Comments";
            this.commentsDataGridViewTextBoxColumn.HeaderText = "Comments";
            this.commentsDataGridViewTextBoxColumn.Name = "commentsDataGridViewTextBoxColumn";
            this.commentsDataGridViewTextBoxColumn.Width = 81;
            // 
            // durationDataGridViewTextBoxColumn
            // 
            this.durationDataGridViewTextBoxColumn.DataPropertyName = "Duration";
            this.durationDataGridViewTextBoxColumn.HeaderText = "Duration";
            this.durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
            this.durationDataGridViewTextBoxColumn.ReadOnly = true;
            this.durationDataGridViewTextBoxColumn.Width = 72;
            // 
            // fileNameDataGridViewTextBoxColumn
            // 
            this.fileNameDataGridViewTextBoxColumn.DataPropertyName = "FileName";
            this.fileNameDataGridViewTextBoxColumn.HeaderText = "FileName";
            this.fileNameDataGridViewTextBoxColumn.Name = "fileNameDataGridViewTextBoxColumn";
            this.fileNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.fileNameDataGridViewTextBoxColumn.Width = 76;
            // 
            // My_UltraID3BindingSource
            // 
            this.My_UltraID3BindingSource.DataSource = typeof(HundredMilesSoftware.UltraID3Lib.UltraID3);
            // 
            // my_textBox_removeText
            // 
            this.my_textBox_removeText.Location = new System.Drawing.Point(9, 10);
            this.my_textBox_removeText.Name = "my_textBox_removeText";
            this.my_textBox_removeText.Size = new System.Drawing.Size(220, 20);
            this.my_textBox_removeText.TabIndex = 7;
            // 
            // my_button_removeText
            // 
            this.my_button_removeText.Location = new System.Drawing.Point(235, 10);
            this.my_button_removeText.Name = "my_button_removeText";
            this.my_button_removeText.Size = new System.Drawing.Size(155, 23);
            this.my_button_removeText.TabIndex = 8;
            this.my_button_removeText.Text = "Remove text";
            this.my_button_removeText.UseVisualStyleBackColor = true;
            this.my_button_removeText.Click += new System.EventHandler(this.Button_removeText_Click);
            // 
            // my_textBox_fixTitle
            // 
            this.My_HelpProvider.SetHelpKeyword(this.my_textBox_fixTitle, "remove_text_from_title");
            this.My_HelpProvider.SetHelpNavigator(this.my_textBox_fixTitle, System.Windows.Forms.HelpNavigator.Find);
            this.My_HelpProvider.SetHelpString(this.my_textBox_fixTitle, "Remove text from title that matchs this string or this regular expretion if check" +
                    "box for regullar expretion is checked ");
            this.my_textBox_fixTitle.Location = new System.Drawing.Point(9, 58);
            this.my_textBox_fixTitle.Name = "my_textBox_fixTitle";
            this.My_HelpProvider.SetShowHelp(this.my_textBox_fixTitle, true);
            this.my_textBox_fixTitle.Size = new System.Drawing.Size(220, 20);
            this.my_textBox_fixTitle.TabIndex = 9;
            // 
            // my_button_fixTitle
            // 
            this.my_button_fixTitle.Location = new System.Drawing.Point(235, 58);
            this.my_button_fixTitle.Name = "my_button_fixTitle";
            this.my_button_fixTitle.Size = new System.Drawing.Size(155, 23);
            this.my_button_fixTitle.TabIndex = 10;
            this.my_button_fixTitle.Text = "Remove extra form title";
            this.my_button_fixTitle.UseVisualStyleBackColor = true;
            this.my_button_fixTitle.Click += new System.EventHandler(this.Button_fixTitle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "write text that you want to remove from all tags ie: www.blabla.com";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Write regular expretion that removes things from tiltels";
            // 
            // my_button_GetTrackNrFronTitle
            // 
            this.my_button_GetTrackNrFronTitle.Location = new System.Drawing.Point(9, 140);
            this.my_button_GetTrackNrFronTitle.Name = "my_button_GetTrackNrFronTitle";
            this.my_button_GetTrackNrFronTitle.Size = new System.Drawing.Size(135, 23);
            this.my_button_GetTrackNrFronTitle.TabIndex = 13;
            this.my_button_GetTrackNrFronTitle.Text = "Get track# from title";
            this.my_button_GetTrackNrFronTitle.UseVisualStyleBackColor = true;
            this.my_button_GetTrackNrFronTitle.Click += new System.EventHandler(this.Button_GetTrackNrFronTitle_Click);
            // 
            // my_button_ClearComments
            // 
            this.my_button_ClearComments.Location = new System.Drawing.Point(161, 140);
            this.my_button_ClearComments.Name = "my_button_ClearComments";
            this.my_button_ClearComments.Size = new System.Drawing.Size(131, 23);
            this.my_button_ClearComments.TabIndex = 14;
            this.my_button_ClearComments.Text = "Clear comments";
            this.my_button_ClearComments.UseVisualStyleBackColor = true;
            this.my_button_ClearComments.Click += new System.EventHandler(this.Button_ClearComments_Click);
            // 
            // My_TabControl_BatchRen
            // 
            this.My_TabControl_BatchRen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.My_TabControl_BatchRen.Controls.Add(this.My_TabPage_Batch);
            this.My_TabControl_BatchRen.Controls.Add(this.my_tabPage_Renaming);
            this.My_TabControl_BatchRen.Location = new System.Drawing.Point(13, 3);
            this.My_TabControl_BatchRen.Name = "My_TabControl_BatchRen";
            this.My_TabControl_BatchRen.SelectedIndex = 0;
            this.My_TabControl_BatchRen.Size = new System.Drawing.Size(839, 206);
            this.My_TabControl_BatchRen.TabIndex = 15;
            // 
            // My_TabPage_Batch
            // 
            this.My_TabPage_Batch.Controls.Add(this.my_comboBox_Ganre);
            this.My_TabPage_Batch.Controls.Add(this.my_textBox_Year);
            this.My_TabPage_Batch.Controls.Add(this.my_checkBox_Year);
            this.My_TabPage_Batch.Controls.Add(this.my_checkBox_Ganre);
            this.My_TabPage_Batch.Controls.Add(this.my_textBox_Album);
            this.My_TabPage_Batch.Controls.Add(this.my_checkBox_Album);
            this.My_TabPage_Batch.Controls.Add(this.my_button_UpdateBatch);
            this.My_TabPage_Batch.Controls.Add(this.my_textBox_Artist);
            this.My_TabPage_Batch.Controls.Add(this.my_checkBox_artist);
            this.My_TabPage_Batch.Location = new System.Drawing.Point(4, 22);
            this.My_TabPage_Batch.Name = "My_TabPage_Batch";
            this.My_TabPage_Batch.Padding = new System.Windows.Forms.Padding(3);
            this.My_TabPage_Batch.Size = new System.Drawing.Size(831, 180);
            this.My_TabPage_Batch.TabIndex = 0;
            this.My_TabPage_Batch.Text = "Batch";
            this.My_TabPage_Batch.UseVisualStyleBackColor = true;
            // 
            // my_comboBox_Ganre
            // 
            this.my_comboBox_Ganre.FormattingEnabled = true;
            this.my_comboBox_Ganre.Location = new System.Drawing.Point(85, 67);
            this.my_comboBox_Ganre.Name = "my_comboBox_Ganre";
            this.my_comboBox_Ganre.Size = new System.Drawing.Size(357, 21);
            this.my_comboBox_Ganre.TabIndex = 12;
            // 
            // my_textBox_Year
            // 
            this.my_textBox_Year.Location = new System.Drawing.Point(85, 92);
            this.my_textBox_Year.Name = "my_textBox_Year";
            this.my_textBox_Year.Size = new System.Drawing.Size(357, 20);
            this.my_textBox_Year.TabIndex = 11;
            // 
            // my_checkBox_Year
            // 
            this.my_checkBox_Year.AutoSize = true;
            this.my_checkBox_Year.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.my_checkBox_Year.Location = new System.Drawing.Point(15, 96);
            this.my_checkBox_Year.Name = "my_checkBox_Year";
            this.my_checkBox_Year.Size = new System.Drawing.Size(54, 17);
            this.my_checkBox_Year.TabIndex = 10;
            this.my_checkBox_Year.Text = "&Year  ";
            this.my_checkBox_Year.UseVisualStyleBackColor = true;
            // 
            // my_checkBox_Ganre
            // 
            this.my_checkBox_Ganre.AutoSize = true;
            this.my_checkBox_Ganre.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.my_checkBox_Ganre.Location = new System.Drawing.Point(15, 71);
            this.my_checkBox_Ganre.Name = "my_checkBox_Ganre";
            this.my_checkBox_Ganre.Size = new System.Drawing.Size(55, 17);
            this.my_checkBox_Ganre.TabIndex = 8;
            this.my_checkBox_Ganre.Text = "&Ganre";
            this.my_checkBox_Ganre.UseVisualStyleBackColor = true;
            // 
            // my_textBox_Album
            // 
            this.my_textBox_Album.Location = new System.Drawing.Point(85, 43);
            this.my_textBox_Album.Name = "my_textBox_Album";
            this.my_textBox_Album.Size = new System.Drawing.Size(357, 20);
            this.my_textBox_Album.TabIndex = 7;
            // 
            // my_checkBox_Album
            // 
            this.my_checkBox_Album.AutoSize = true;
            this.my_checkBox_Album.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.my_checkBox_Album.Location = new System.Drawing.Point(15, 46);
            this.my_checkBox_Album.Name = "my_checkBox_Album";
            this.my_checkBox_Album.Size = new System.Drawing.Size(55, 17);
            this.my_checkBox_Album.TabIndex = 6;
            this.my_checkBox_Album.Text = "Al&bum";
            this.my_checkBox_Album.UseVisualStyleBackColor = true;
            // 
            // my_button_UpdateBatch
            // 
            this.my_button_UpdateBatch.Location = new System.Drawing.Point(460, 21);
            this.my_button_UpdateBatch.Name = "my_button_UpdateBatch";
            this.my_button_UpdateBatch.Size = new System.Drawing.Size(152, 93);
            this.my_button_UpdateBatch.TabIndex = 5;
            this.my_button_UpdateBatch.Text = "&Update";
            this.my_button_UpdateBatch.UseVisualStyleBackColor = true;
            this.my_button_UpdateBatch.Click += new System.EventHandler(this.Button_UpdateBatch_Click);
            // 
            // my_textBox_Artist
            // 
            this.my_textBox_Artist.Location = new System.Drawing.Point(85, 19);
            this.my_textBox_Artist.Name = "my_textBox_Artist";
            this.my_textBox_Artist.Size = new System.Drawing.Size(357, 20);
            this.my_textBox_Artist.TabIndex = 4;
            // 
            // my_checkBox_artist
            // 
            this.my_checkBox_artist.AutoSize = true;
            this.my_checkBox_artist.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.my_checkBox_artist.Location = new System.Drawing.Point(15, 21);
            this.my_checkBox_artist.Name = "my_checkBox_artist";
            this.my_checkBox_artist.Size = new System.Drawing.Size(55, 17);
            this.my_checkBox_artist.TabIndex = 0;
            this.my_checkBox_artist.Text = "&Artist  ";
            this.my_checkBox_artist.UseVisualStyleBackColor = true;
            // 
            // my_tabPage_Renaming
            // 
            this.my_tabPage_Renaming.Controls.Add(this.GroupBox_ExtractFromFName);
            this.my_tabPage_Renaming.Controls.Add(this.my_textBox_removeText);
            this.my_tabPage_Renaming.Controls.Add(this.my_checkBox_UseRegExp);
            this.my_tabPage_Renaming.Controls.Add(this.my_button_ClearComments);
            this.my_tabPage_Renaming.Controls.Add(this.my_button_removeText);
            this.my_tabPage_Renaming.Controls.Add(this.my_button_GetTrackNrFronTitle);
            this.my_tabPage_Renaming.Controls.Add(this.my_textBox_fixTitle);
            this.my_tabPage_Renaming.Controls.Add(this.label2);
            this.my_tabPage_Renaming.Controls.Add(this.my_button_fixTitle);
            this.my_tabPage_Renaming.Controls.Add(this.label1);
            this.my_tabPage_Renaming.Location = new System.Drawing.Point(4, 22);
            this.my_tabPage_Renaming.Name = "my_tabPage_Renaming";
            this.my_tabPage_Renaming.Padding = new System.Windows.Forms.Padding(3);
            this.my_tabPage_Renaming.Size = new System.Drawing.Size(831, 180);
            this.my_tabPage_Renaming.TabIndex = 1;
            this.my_tabPage_Renaming.Text = "Renaming";
            this.my_tabPage_Renaming.UseVisualStyleBackColor = true;
            // 
            // GroupBox_ExtractFromFName
            // 
            this.GroupBox_ExtractFromFName.Controls.Add(this.ComboBox_ExtractTagsFromFNmane);
            this.GroupBox_ExtractFromFName.Controls.Add(this.Button_ExtractFRomFName);
            this.GroupBox_ExtractFromFName.Controls.Add(this.Button_regexp_properties);
            this.GroupBox_ExtractFromFName.Controls.Add(this.Button_ExtracFromFName_Test);
            this.GroupBox_ExtractFromFName.Controls.Add(this.Label_Regextpresult);
            this.GroupBox_ExtractFromFName.Controls.Add(this.TextBox_TestPath);
            this.GroupBox_ExtractFromFName.Location = new System.Drawing.Point(396, 6);
            this.GroupBox_ExtractFromFName.Name = "GroupBox_ExtractFromFName";
            this.GroupBox_ExtractFromFName.Size = new System.Drawing.Size(429, 167);
            this.GroupBox_ExtractFromFName.TabIndex = 21;
            this.GroupBox_ExtractFromFName.TabStop = false;
            this.GroupBox_ExtractFromFName.Text = "Extract tags from file name";
            // 
            // ComboBox_ExtractTagsFromFNmane
            // 
            this.ComboBox_ExtractTagsFromFNmane.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBox_ExtractTagsFromFNmane.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ComboBox_ExtractTagsFromFNmane.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboBox_ExtractTagsFromFNmane.FormattingEnabled = true;
            this.ComboBox_ExtractTagsFromFNmane.Items.AddRange(new object[] {
            "#artist# - #tracknr# - #album# - #year# - #title#",
            "#artist# - #album# - #year# - #tracknr# - #title#",
            "#artist# - #tracknr# - #album# - #title#",
            "#artist# - #tracknr# - #title#",
            "#artist# - #title#",
            "#title#"});
            this.ComboBox_ExtractTagsFromFNmane.Location = new System.Drawing.Point(6, 14);
            this.ComboBox_ExtractTagsFromFNmane.Name = "ComboBox_ExtractTagsFromFNmane";
            this.ComboBox_ExtractTagsFromFNmane.Size = new System.Drawing.Size(322, 21);
            this.ComboBox_ExtractTagsFromFNmane.TabIndex = 22;
            // 
            // Button_ExtractFRomFName
            // 
            this.Button_ExtractFRomFName.Location = new System.Drawing.Point(301, 123);
            this.Button_ExtractFRomFName.Name = "Button_ExtractFRomFName";
            this.Button_ExtractFRomFName.Size = new System.Drawing.Size(122, 38);
            this.Button_ExtractFRomFName.TabIndex = 21;
            this.Button_ExtractFRomFName.Text = "Extract tags from selected files";
            this.Button_ExtractFRomFName.UseVisualStyleBackColor = true;
            this.Button_ExtractFRomFName.Click += new System.EventHandler(this.Button_ExtractFRomFName_Click);
            // 
            // Button_regexp_properties
            // 
            this.Button_regexp_properties.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_regexp_properties.Location = new System.Drawing.Point(334, 12);
            this.Button_regexp_properties.Name = "Button_regexp_properties";
            this.Button_regexp_properties.Size = new System.Drawing.Size(21, 23);
            this.Button_regexp_properties.TabIndex = 20;
            this.Button_regexp_properties.Text = "?";
            this.Button_regexp_properties.UseVisualStyleBackColor = true;
            this.Button_regexp_properties.Click += new System.EventHandler(this.Button_regexp_properties_Click);
            // 
            // Button_ExtracFromFName_Test
            // 
            this.Button_ExtracFromFName_Test.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_ExtracFromFName_Test.Location = new System.Drawing.Point(358, 12);
            this.Button_ExtracFromFName_Test.Name = "Button_ExtracFromFName_Test";
            this.Button_ExtracFromFName_Test.Size = new System.Drawing.Size(65, 23);
            this.Button_ExtracFromFName_Test.TabIndex = 17;
            this.Button_ExtracFromFName_Test.Text = "Test";
            this.Button_ExtracFromFName_Test.UseVisualStyleBackColor = true;
            this.Button_ExtracFromFName_Test.Click += new System.EventHandler(this.Button_ExtracFromFNameTEST_Click);
            // 
            // Label_Regextpresult
            // 
            this.Label_Regextpresult.AutoEllipsis = true;
            this.Label_Regextpresult.AutoSize = true;
            this.Label_Regextpresult.Location = new System.Drawing.Point(6, 71);
            this.Label_Regextpresult.Name = "Label_Regextpresult";
            this.Label_Regextpresult.Size = new System.Drawing.Size(0, 13);
            this.Label_Regextpresult.TabIndex = 19;
            // 
            // TextBox_TestPath
            // 
            this.TextBox_TestPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_TestPath.Location = new System.Drawing.Point(5, 40);
            this.TextBox_TestPath.Name = "TextBox_TestPath";
            this.TextBox_TestPath.Size = new System.Drawing.Size(418, 20);
            this.TextBox_TestPath.TabIndex = 18;
            // 
            // my_checkBox_UseRegExp
            // 
            this.my_checkBox_UseRegExp.AutoSize = true;
            this.my_checkBox_UseRegExp.Checked = true;
            this.my_checkBox_UseRegExp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.my_checkBox_UseRegExp.Location = new System.Drawing.Point(9, 84);
            this.my_checkBox_UseRegExp.Name = "my_checkBox_UseRegExp";
            this.my_checkBox_UseRegExp.Size = new System.Drawing.Size(128, 17);
            this.my_checkBox_UseRegExp.TabIndex = 15;
            this.my_checkBox_UseRegExp.Text = "Use regular expresion";
            this.my_checkBox_UseRegExp.UseVisualStyleBackColor = true;
            // 
            // y_splitContainer_Main
            // 
            this.y_splitContainer_Main.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.y_splitContainer_Main.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.y_splitContainer_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.y_splitContainer_Main.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.y_splitContainer_Main.Location = new System.Drawing.Point(0, 0);
            this.y_splitContainer_Main.Name = "y_splitContainer_Main";
            this.y_splitContainer_Main.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // y_splitContainer_Main.Panel1
            // 
            this.y_splitContainer_Main.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.y_splitContainer_Main.Panel1.Controls.Add(this.groupBox1);
            this.y_splitContainer_Main.Panel1.Controls.Add(this.groupBox2);
            this.y_splitContainer_Main.Panel1.Controls.Add(this.My_TabControl_BatchRen);
            // 
            // y_splitContainer_Main.Panel2
            // 
            this.y_splitContainer_Main.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.y_splitContainer_Main.Panel2.Controls.Add(this.my_folderSelector);
            this.y_splitContainer_Main.Panel2.Controls.Add(this.my_dataGridView_MP3s);
            this.y_splitContainer_Main.Size = new System.Drawing.Size(866, 686);
            this.y_splitContainer_Main.SplitterDistance = 310;
            this.y_splitContainer_Main.SplitterWidth = 5;
            this.y_splitContainer_Main.TabIndex = 16;
            // 
            // my_folderSelector
            // 
            this.my_folderSelector.ActualPath = "";
            this.my_folderSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.my_folderSelector.Location = new System.Drawing.Point(13, 3);
            this.my_folderSelector.Name = "my_folderSelector";
            this.my_folderSelector.Paths = new string[] {
        ""};
            this.my_folderSelector.Size = new System.Drawing.Size(842, 47);
            this.my_folderSelector.TabIndex = 7;
            // 
            // My_MenuStrip
            // 
            this.My_MenuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.My_MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.My_MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.My_MenuStrip.Name = "My_MenuStrip";
            this.My_MenuStrip.Size = new System.Drawing.Size(866, 24);
            this.My_MenuStrip.TabIndex = 16;
            this.My_MenuStrip.Text = "menuStrip1";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.batchToolStripMenuItem,
            this.renamingToolStripMenuItem,
            this.finToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // batchToolStripMenuItem
            // 
            this.batchToolStripMenuItem.Name = "batchToolStripMenuItem";
            this.batchToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.batchToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.batchToolStripMenuItem.Text = "&Batch";
            this.batchToolStripMenuItem.Click += new System.EventHandler(this.BatchToolStripMenuItem_Click);
            // 
            // renamingToolStripMenuItem
            // 
            this.renamingToolStripMenuItem.Name = "renamingToolStripMenuItem";
            this.renamingToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.renamingToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.renamingToolStripMenuItem.Text = "&Renaming";
            this.renamingToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_RenamingClick);
            // 
            // finToolStripMenuItem
            // 
            this.finToolStripMenuItem.Name = "finToolStripMenuItem";
            this.finToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.finToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.finToolStripMenuItem.Text = "Find &Duplicates";
            this.finToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_FindDuplicates_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languageToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.svenskaToolStripMenuItem,
            this.bosniskaToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.languageToolStripMenuItem.Text = "&Language";
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Checked = true;
            this.englishToolStripMenuItem.CheckOnClick = true;
            this.englishToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.englishToolStripMenuItem.Text = "&English";
            // 
            // svenskaToolStripMenuItem
            // 
            this.svenskaToolStripMenuItem.CheckOnClick = true;
            this.svenskaToolStripMenuItem.Name = "svenskaToolStripMenuItem";
            this.svenskaToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.svenskaToolStripMenuItem.Text = "&Svenska";
            // 
            // bosniskaToolStripMenuItem
            // 
            this.bosniskaToolStripMenuItem.CheckOnClick = true;
            this.bosniskaToolStripMenuItem.Name = "bosniskaToolStripMenuItem";
            this.bosniskaToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.bosniskaToolStripMenuItem.Text = "&Bosanski";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.my_helpToolStripMenuItem,
            this.my_aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // my_helpToolStripMenuItem
            // 
            this.my_helpToolStripMenuItem.Name = "my_helpToolStripMenuItem";
            this.my_helpToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.my_helpToolStripMenuItem.Text = "Help";
            // 
            // my_aboutToolStripMenuItem
            // 
            this.my_aboutToolStripMenuItem.Name = "my_aboutToolStripMenuItem";
            this.my_aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.my_aboutToolStripMenuItem.Text = "About";
            this.my_aboutToolStripMenuItem.Click += new System.EventHandler(this.About_Click);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.AutoScroll = true;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.y_splitContainer_Main);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(866, 686);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(866, 710);
            this.toolStripContainer1.TabIndex = 17;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.My_MenuStrip);
            // 
            // My_HelpProvider
            // 
            this.My_HelpProvider.HelpNamespace = "Help.htm";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 710);
            this.Controls.Add(this.toolStripContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.My_MenuStrip;
            this.Name = "MainForm";
            this.Text = "MP3 Tag renamer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.my_dataGridView_MP3s)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.My_UltraID3BindingSource)).EndInit();
            this.My_TabControl_BatchRen.ResumeLayout(false);
            this.My_TabPage_Batch.ResumeLayout(false);
            this.My_TabPage_Batch.PerformLayout();
            this.my_tabPage_Renaming.ResumeLayout(false);
            this.my_tabPage_Renaming.PerformLayout();
            this.GroupBox_ExtractFromFName.ResumeLayout(false);
            this.GroupBox_ExtractFromFName.PerformLayout();
            this.y_splitContainer_Main.Panel1.ResumeLayout(false);
            this.y_splitContainer_Main.Panel2.ResumeLayout(false);
            this.y_splitContainer_Main.ResumeLayout(false);
            this.My_MenuStrip.ResumeLayout(false);
            this.My_MenuStrip.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView my_dataGridView_MP3s;
        private System.Windows.Forms.FolderBrowserDialog My_FolderBrowserDialog;
        private System.Windows.Forms.BindingSource My_UltraID3BindingSource;
        private System.Windows.Forms.Label my_label_ID3V2;
        private System.Windows.Forms.Label my_label_ID3V1;
        private System.Windows.Forms.TextBox my_textBox_removeText;
        private System.Windows.Forms.Button my_button_removeText;
        private System.Windows.Forms.TextBox my_textBox_fixTitle;
        private System.Windows.Forms.Button my_button_fixTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button my_button_GetTrackNrFronTitle;
        private System.Windows.Forms.Button my_button_ClearComments;
        private System.Windows.Forms.TabControl My_TabControl_BatchRen;
        private System.Windows.Forms.TabPage My_TabPage_Batch;
        private System.Windows.Forms.TabPage my_tabPage_Renaming;
        private System.Windows.Forms.Button my_button_UpdateBatch;
        private System.Windows.Forms.TextBox my_textBox_Artist;
        private System.Windows.Forms.CheckBox my_checkBox_artist;
        private System.Windows.Forms.TextBox my_textBox_Year;
        private System.Windows.Forms.CheckBox my_checkBox_Year;
        private System.Windows.Forms.CheckBox my_checkBox_Ganre;
        private System.Windows.Forms.TextBox my_textBox_Album;
        private System.Windows.Forms.CheckBox my_checkBox_Album;
        private System.Windows.Forms.ComboBox my_comboBox_Ganre;
        private System.Windows.Forms.SplitContainer y_splitContainer_Main;
        private System.Windows.Forms.CheckBox my_checkBox_UseRegExp;
        private System.Windows.Forms.MenuStrip My_MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem my_helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem my_aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStripMenuItem batchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renamingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bosniskaToolStripMenuItem;
        private System.Windows.Forms.HelpProvider My_HelpProvider;
        private System.Windows.Forms.ToolStripMenuItem svenskaToolStripMenuItem;
        private UserControlFolderSelector my_folderSelector;
        private System.Windows.Forms.ToolStripMenuItem finToolStripMenuItem;
        private System.Windows.Forms.DataGridViewImageColumn my_play_datagridcolumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dc_trackNumDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dc_artistDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dc_titleDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dc_genreDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dc_albumDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dc_yearDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dc_sizeDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dc_commentsDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dc_durationDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dc_fileNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Button_ExtracFromFName_Test;
        private System.Windows.Forms.Label Label_Regextpresult;
        private System.Windows.Forms.TextBox TextBox_TestPath;
        private System.Windows.Forms.Button Button_regexp_properties;
        private System.Windows.Forms.GroupBox GroupBox_ExtractFromFName;
        private System.Windows.Forms.Button Button_ExtractFRomFName;
        private System.Windows.Forms.ComboBox ComboBox_ExtractTagsFromFNmane;
        private System.Windows.Forms.DataGridViewTextBoxColumn trackNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn albumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileNameDataGridViewTextBoxColumn;
    }
}

