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
			this.My_UltraID3BindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.My_TabControl_BatchRen = new System.Windows.Forms.TabControl();
			this.m_TabPageBatch = new System.Windows.Forms.TabPage();
			this.m_UserControlBatchRenameFields = new MP3TagRenamer.UserControlBatchRenameFields();
			this.m_TabPageRenaming = new System.Windows.Forms.TabPage();
			this.GroupBox_ExtractFromFName = new System.Windows.Forms.GroupBox();
			this.m_ButtonSuggest = new System.Windows.Forms.Button();
			this.m_ButtonAddRemovePressets = new System.Windows.Forms.Button();
			this.m_LabelRealRexExpression = new System.Windows.Forms.Label();
			this.ComboBox_ExtractTagsFromFNmane = new System.Windows.Forms.ComboBox();
			this.Button_ExtractFRomFName = new System.Windows.Forms.Button();
			this.Button_regexp_properties = new System.Windows.Forms.Button();
			this.Button_ExtracFromFName_Test = new System.Windows.Forms.Button();
			this.Label_Regextpresult = new System.Windows.Forms.Label();
			this.TextBox_TestPath = new System.Windows.Forms.TextBox();
			this.m_TabPageCleaning = new System.Windows.Forms.TabPage();
			this.my_textBox_removeText = new System.Windows.Forms.TextBox();
			this.my_checkBox_UseRegExp = new System.Windows.Forms.CheckBox();
			this.my_button_ClearComments = new System.Windows.Forms.Button();
			this.my_button_removeText = new System.Windows.Forms.Button();
			this.my_button_GetTrackNrFronTitle = new System.Windows.Forms.Button();
			this.my_textBox_fixTitle = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.my_button_fixTitle = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.y_splitContainer_Main = new System.Windows.Forms.SplitContainer();
			this.m_UserControlTrackList = new MP3TagRenamer.UserControlTrackList();
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
			this.m_ToolTip = new System.Windows.Forms.ToolTip(this.components);
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.My_UltraID3BindingSource)).BeginInit();
			this.My_TabControl_BatchRen.SuspendLayout();
			this.m_TabPageBatch.SuspendLayout();
			this.m_TabPageRenaming.SuspendLayout();
			this.GroupBox_ExtractFromFName.SuspendLayout();
			this.m_TabPageCleaning.SuspendLayout();
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
			this.groupBox2.TabIndex = 2;
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
			// My_UltraID3BindingSource
			// 
			this.My_UltraID3BindingSource.DataSource = typeof(HundredMilesSoftware.UltraID3Lib.UltraID3);
			// 
			// My_TabControl_BatchRen
			// 
			this.My_TabControl_BatchRen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.My_TabControl_BatchRen.Controls.Add(this.m_TabPageBatch);
			this.My_TabControl_BatchRen.Controls.Add(this.m_TabPageRenaming);
			this.My_TabControl_BatchRen.Controls.Add(this.m_TabPageCleaning);
			this.My_TabControl_BatchRen.Location = new System.Drawing.Point(13, 3);
			this.My_TabControl_BatchRen.Name = "My_TabControl_BatchRen";
			this.My_TabControl_BatchRen.SelectedIndex = 0;
			this.My_TabControl_BatchRen.Size = new System.Drawing.Size(839, 206);
			this.My_TabControl_BatchRen.TabIndex = 1;
			// 
			// m_TabPageBatch
			// 
			this.m_TabPageBatch.Controls.Add(this.m_UserControlBatchRenameFields);
			this.m_TabPageBatch.Location = new System.Drawing.Point(4, 22);
			this.m_TabPageBatch.Name = "m_TabPageBatch";
			this.m_TabPageBatch.Padding = new System.Windows.Forms.Padding(3);
			this.m_TabPageBatch.Size = new System.Drawing.Size(831, 180);
			this.m_TabPageBatch.TabIndex = 0;
			this.m_TabPageBatch.Text = "Batch";
			this.m_TabPageBatch.UseVisualStyleBackColor = true;
			// 
			// m_UserControlBatchRenameFields
			// 
			this.m_UserControlBatchRenameFields.Album = "";
			this.m_UserControlBatchRenameFields.Artist = "";
			this.m_UserControlBatchRenameFields.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_UserControlBatchRenameFields.Ganre = "";
			this.m_UserControlBatchRenameFields.Location = new System.Drawing.Point(3, 3);
			this.m_UserControlBatchRenameFields.Name = "m_UserControlBatchRenameFields";
			this.m_UserControlBatchRenameFields.Size = new System.Drawing.Size(825, 174);
			this.m_UserControlBatchRenameFields.TabIndex = 0;
			this.m_UserControlBatchRenameFields.Year = null;
			// 
			// m_TabPageRenaming
			// 
			this.m_TabPageRenaming.Controls.Add(this.GroupBox_ExtractFromFName);
			this.m_TabPageRenaming.Location = new System.Drawing.Point(4, 22);
			this.m_TabPageRenaming.Name = "m_TabPageRenaming";
			this.m_TabPageRenaming.Padding = new System.Windows.Forms.Padding(3);
			this.m_TabPageRenaming.Size = new System.Drawing.Size(831, 180);
			this.m_TabPageRenaming.TabIndex = 1;
			this.m_TabPageRenaming.Text = "Renaming";
			this.m_TabPageRenaming.UseVisualStyleBackColor = true;
			// 
			// GroupBox_ExtractFromFName
			// 
			this.GroupBox_ExtractFromFName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.GroupBox_ExtractFromFName.Controls.Add(this.m_ButtonSuggest);
			this.GroupBox_ExtractFromFName.Controls.Add(this.m_ButtonAddRemovePressets);
			this.GroupBox_ExtractFromFName.Controls.Add(this.m_LabelRealRexExpression);
			this.GroupBox_ExtractFromFName.Controls.Add(this.ComboBox_ExtractTagsFromFNmane);
			this.GroupBox_ExtractFromFName.Controls.Add(this.Button_ExtractFRomFName);
			this.GroupBox_ExtractFromFName.Controls.Add(this.Button_regexp_properties);
			this.GroupBox_ExtractFromFName.Controls.Add(this.Button_ExtracFromFName_Test);
			this.GroupBox_ExtractFromFName.Controls.Add(this.Label_Regextpresult);
			this.GroupBox_ExtractFromFName.Controls.Add(this.TextBox_TestPath);
			this.GroupBox_ExtractFromFName.Location = new System.Drawing.Point(6, 3);
			this.GroupBox_ExtractFromFName.Name = "GroupBox_ExtractFromFName";
			this.GroupBox_ExtractFromFName.Size = new System.Drawing.Size(819, 167);
			this.GroupBox_ExtractFromFName.TabIndex = 0;
			this.GroupBox_ExtractFromFName.TabStop = false;
			this.GroupBox_ExtractFromFName.Text = "Extract tags from file name";
			// 
			// m_ButtonSuggest
			// 
			this.m_ButtonSuggest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.m_ButtonSuggest.Location = new System.Drawing.Point(738, 14);
			this.m_ButtonSuggest.Name = "m_ButtonSuggest";
			this.m_ButtonSuggest.Size = new System.Drawing.Size(75, 23);
			this.m_ButtonSuggest.TabIndex = 1;
			this.m_ButtonSuggest.Text = "Suggest";
			this.m_ToolTip.SetToolTip(this.m_ButtonSuggest, "Suggest tags that can be used");
			this.m_ButtonSuggest.UseVisualStyleBackColor = true;
			this.m_ButtonSuggest.Click += new System.EventHandler(this.ButtonSuggest_Click);
			// 
			// m_ButtonAddRemovePressets
			// 
			this.m_ButtonAddRemovePressets.Location = new System.Drawing.Point(445, 43);
			this.m_ButtonAddRemovePressets.Name = "m_ButtonAddRemovePressets";
			this.m_ButtonAddRemovePressets.Size = new System.Drawing.Size(19, 23);
			this.m_ButtonAddRemovePressets.TabIndex = 5;
			this.m_ButtonAddRemovePressets.Text = "+";
			this.m_ToolTip.SetToolTip(this.m_ButtonAddRemovePressets, "Add/Remove new definitions");
			this.m_ButtonAddRemovePressets.UseVisualStyleBackColor = true;
			this.m_ButtonAddRemovePressets.Click += new System.EventHandler(this.ButtonAddRemovePressets_Click);
			// 
			// m_LabelRealRexExpression
			// 
			this.m_LabelRealRexExpression.AutoSize = true;
			this.m_LabelRealRexExpression.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.m_LabelRealRexExpression.Location = new System.Drawing.Point(513, 46);
			this.m_LabelRealRexExpression.Name = "m_LabelRealRexExpression";
			this.m_LabelRealRexExpression.Size = new System.Drawing.Size(56, 15);
			this.m_LabelRealRexExpression.TabIndex = 6;
			this.m_LabelRealRexExpression.Text = "RegExp:";
			// 
			// ComboBox_ExtractTagsFromFNmane
			// 
			this.ComboBox_ExtractTagsFromFNmane.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.ComboBox_ExtractTagsFromFNmane.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.ComboBox_ExtractTagsFromFNmane.FormattingEnabled = true;
			this.ComboBox_ExtractTagsFromFNmane.Location = new System.Drawing.Point(6, 44);
			this.ComboBox_ExtractTagsFromFNmane.Name = "ComboBox_ExtractTagsFromFNmane";
			this.ComboBox_ExtractTagsFromFNmane.Size = new System.Drawing.Size(347, 21);
			this.ComboBox_ExtractTagsFromFNmane.TabIndex = 2;
			this.ComboBox_ExtractTagsFromFNmane.TextChanged += new System.EventHandler(this.ComboBox_ExtractTagsFromFNmane_TextChanged);
			// 
			// Button_ExtractFRomFName
			// 
			this.Button_ExtractFRomFName.Location = new System.Drawing.Point(6, 71);
			this.Button_ExtractFRomFName.Name = "Button_ExtractFRomFName";
			this.Button_ExtractFRomFName.Size = new System.Drawing.Size(188, 25);
			this.Button_ExtractFRomFName.TabIndex = 7;
			this.Button_ExtractFRomFName.Text = "Extract tags from selected files";
			this.Button_ExtractFRomFName.UseVisualStyleBackColor = true;
			this.Button_ExtractFRomFName.Click += new System.EventHandler(this.Button_ExtractFRomFName_Click);
			// 
			// Button_regexp_properties
			// 
			this.Button_regexp_properties.Location = new System.Drawing.Point(470, 43);
			this.Button_regexp_properties.Name = "Button_regexp_properties";
			this.Button_regexp_properties.Size = new System.Drawing.Size(37, 23);
			this.Button_regexp_properties.TabIndex = 20;
			this.Button_regexp_properties.Text = "Edit";
			this.m_ToolTip.SetToolTip(this.Button_regexp_properties, "Edit predefind tags");
			this.Button_regexp_properties.UseVisualStyleBackColor = true;
			this.Button_regexp_properties.Click += new System.EventHandler(this.Button_regexp_properties_Click);
			// 
			// Button_ExtracFromFName_Test
			// 
			this.Button_ExtracFromFName_Test.Location = new System.Drawing.Point(359, 42);
			this.Button_ExtracFromFName_Test.Name = "Button_ExtracFromFName_Test";
			this.Button_ExtracFromFName_Test.Size = new System.Drawing.Size(80, 23);
			this.Button_ExtracFromFName_Test.TabIndex = 3;
			this.Button_ExtracFromFName_Test.Text = "Test";
			this.m_ToolTip.SetToolTip(this.Button_ExtracFromFName_Test, "Test expression before you run it");
			this.Button_ExtracFromFName_Test.UseVisualStyleBackColor = true;
			this.Button_ExtracFromFName_Test.Click += new System.EventHandler(this.Button_ExtracFromFNameTEST_Click);
			// 
			// Label_Regextpresult
			// 
			this.Label_Regextpresult.AutoEllipsis = true;
			this.Label_Regextpresult.AutoSize = true;
			this.Label_Regextpresult.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label_Regextpresult.Location = new System.Drawing.Point(212, 68);
			this.Label_Regextpresult.Name = "Label_Regextpresult";
			this.Label_Regextpresult.Size = new System.Drawing.Size(32, 16);
			this.Label_Regextpresult.TabIndex = 8;
			this.Label_Regextpresult.Text = "---";
			// 
			// TextBox_TestPath
			// 
			this.TextBox_TestPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.TextBox_TestPath.Location = new System.Drawing.Point(6, 16);
			this.TextBox_TestPath.Name = "TextBox_TestPath";
			this.TextBox_TestPath.ReadOnly = true;
			this.TextBox_TestPath.Size = new System.Drawing.Size(726, 20);
			this.TextBox_TestPath.TabIndex = 0;
			// 
			// m_TabPageCleaning
			// 
			this.m_TabPageCleaning.Controls.Add(this.my_textBox_removeText);
			this.m_TabPageCleaning.Controls.Add(this.my_checkBox_UseRegExp);
			this.m_TabPageCleaning.Controls.Add(this.my_button_ClearComments);
			this.m_TabPageCleaning.Controls.Add(this.my_button_removeText);
			this.m_TabPageCleaning.Controls.Add(this.my_button_GetTrackNrFronTitle);
			this.m_TabPageCleaning.Controls.Add(this.my_textBox_fixTitle);
			this.m_TabPageCleaning.Controls.Add(this.label2);
			this.m_TabPageCleaning.Controls.Add(this.my_button_fixTitle);
			this.m_TabPageCleaning.Controls.Add(this.label1);
			this.m_TabPageCleaning.Location = new System.Drawing.Point(4, 22);
			this.m_TabPageCleaning.Name = "m_TabPageCleaning";
			this.m_TabPageCleaning.Padding = new System.Windows.Forms.Padding(3);
			this.m_TabPageCleaning.Size = new System.Drawing.Size(831, 180);
			this.m_TabPageCleaning.TabIndex = 2;
			this.m_TabPageCleaning.Text = "Cleaning";
			this.m_TabPageCleaning.UseVisualStyleBackColor = true;
			// 
			// my_textBox_removeText
			// 
			this.my_textBox_removeText.Location = new System.Drawing.Point(6, 6);
			this.my_textBox_removeText.Name = "my_textBox_removeText";
			this.my_textBox_removeText.Size = new System.Drawing.Size(340, 20);
			this.my_textBox_removeText.TabIndex = 16;
			// 
			// my_checkBox_UseRegExp
			// 
			this.my_checkBox_UseRegExp.AutoSize = true;
			this.my_checkBox_UseRegExp.Checked = true;
			this.my_checkBox_UseRegExp.CheckState = System.Windows.Forms.CheckState.Checked;
			this.my_checkBox_UseRegExp.Location = new System.Drawing.Point(9, 86);
			this.my_checkBox_UseRegExp.Name = "my_checkBox_UseRegExp";
			this.my_checkBox_UseRegExp.Size = new System.Drawing.Size(128, 17);
			this.my_checkBox_UseRegExp.TabIndex = 24;
			this.my_checkBox_UseRegExp.Text = "Use regular expresion";
			this.my_checkBox_UseRegExp.UseVisualStyleBackColor = true;
			// 
			// my_button_ClearComments
			// 
			this.my_button_ClearComments.Location = new System.Drawing.Point(158, 141);
			this.my_button_ClearComments.Name = "my_button_ClearComments";
			this.my_button_ClearComments.Size = new System.Drawing.Size(131, 23);
			this.my_button_ClearComments.TabIndex = 23;
			this.my_button_ClearComments.Text = "Clear comments";
			this.my_button_ClearComments.UseVisualStyleBackColor = true;
			this.my_button_ClearComments.Click += new System.EventHandler(this.Button_ClearComments_Click);
			// 
			// my_button_removeText
			// 
			this.my_button_removeText.Location = new System.Drawing.Point(352, 6);
			this.my_button_removeText.Name = "my_button_removeText";
			this.my_button_removeText.Size = new System.Drawing.Size(155, 23);
			this.my_button_removeText.TabIndex = 17;
			this.my_button_removeText.Text = "Remove text";
			this.my_button_removeText.UseVisualStyleBackColor = true;
			this.my_button_removeText.Click += new System.EventHandler(this.Button_removeText_Click);
			// 
			// my_button_GetTrackNrFronTitle
			// 
			this.my_button_GetTrackNrFronTitle.Location = new System.Drawing.Point(6, 141);
			this.my_button_GetTrackNrFronTitle.Name = "my_button_GetTrackNrFronTitle";
			this.my_button_GetTrackNrFronTitle.Size = new System.Drawing.Size(135, 23);
			this.my_button_GetTrackNrFronTitle.TabIndex = 22;
			this.my_button_GetTrackNrFronTitle.Text = "Get track# from title";
			this.my_button_GetTrackNrFronTitle.UseVisualStyleBackColor = true;
			this.my_button_GetTrackNrFronTitle.Click += new System.EventHandler(this.Button_GetTrackNrFronTitle_Click);
			// 
			// my_textBox_fixTitle
			// 
			this.My_HelpProvider.SetHelpKeyword(this.my_textBox_fixTitle, "remove_text_from_title");
			this.My_HelpProvider.SetHelpNavigator(this.my_textBox_fixTitle, System.Windows.Forms.HelpNavigator.Find);
			this.My_HelpProvider.SetHelpString(this.my_textBox_fixTitle, "Remove text from title that matchs this string or this regular expretion if check" +
					"box for regullar expretion is checked ");
			this.my_textBox_fixTitle.Location = new System.Drawing.Point(6, 60);
			this.my_textBox_fixTitle.Name = "my_textBox_fixTitle";
			this.My_HelpProvider.SetShowHelp(this.my_textBox_fixTitle, true);
			this.my_textBox_fixTitle.Size = new System.Drawing.Size(340, 20);
			this.my_textBox_fixTitle.TabIndex = 18;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 106);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(257, 13);
			this.label2.TabIndex = 21;
			this.label2.Text = "Write regular expretion that removes things from tiltels";
			// 
			// my_button_fixTitle
			// 
			this.my_button_fixTitle.Location = new System.Drawing.Point(352, 57);
			this.my_button_fixTitle.Name = "my_button_fixTitle";
			this.my_button_fixTitle.Size = new System.Drawing.Size(155, 23);
			this.my_button_fixTitle.TabIndex = 19;
			this.my_button_fixTitle.Text = "Remove extra form title";
			this.my_button_fixTitle.UseVisualStyleBackColor = true;
			this.my_button_fixTitle.Click += new System.EventHandler(this.Button_fixTitle_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(320, 13);
			this.label1.TabIndex = 20;
			this.label1.Text = "write text that you want to remove from all tags ie: www.blabla.com";
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
			this.y_splitContainer_Main.Panel2.Controls.Add(this.m_UserControlTrackList);
			this.y_splitContainer_Main.Size = new System.Drawing.Size(866, 686);
			this.y_splitContainer_Main.SplitterDistance = 310;
			this.y_splitContainer_Main.SplitterWidth = 5;
			this.y_splitContainer_Main.TabIndex = 0;
			// 
			// m_UserControlTrackList
			// 
			this.m_UserControlTrackList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_UserControlTrackList.ID3V1Text = null;
			this.m_UserControlTrackList.ID3V2Text = null;
			this.m_UserControlTrackList.Location = new System.Drawing.Point(0, 0);
			this.m_UserControlTrackList.Name = "m_UserControlTrackList";
			this.m_UserControlTrackList.SelectedTracksPath = null;
			this.m_UserControlTrackList.Size = new System.Drawing.Size(862, 367);
			this.m_UserControlTrackList.TabIndex = 0;
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
			this.My_MenuStrip.TabIndex = 0;
			this.My_MenuStrip.Text = "menuStrip1";
			// 
			// viewToolStripMenuItem
			// 
			this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.batchToolStripMenuItem,
            this.renamingToolStripMenuItem,
            this.finToolStripMenuItem});
			this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
			this.viewToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
			this.viewToolStripMenuItem.Text = "&View";
			// 
			// batchToolStripMenuItem
			// 
			this.batchToolStripMenuItem.Name = "batchToolStripMenuItem";
			this.batchToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
			this.batchToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
			this.batchToolStripMenuItem.Text = "&Batch";
			this.batchToolStripMenuItem.Click += new System.EventHandler(this.BatchToolStripMenuItem_Click);
			// 
			// renamingToolStripMenuItem
			// 
			this.renamingToolStripMenuItem.Name = "renamingToolStripMenuItem";
			this.renamingToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
			this.renamingToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
			this.renamingToolStripMenuItem.Text = "&Renaming";
			this.renamingToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_RenamingClick);
			// 
			// finToolStripMenuItem
			// 
			this.finToolStripMenuItem.Name = "finToolStripMenuItem";
			this.finToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
			this.finToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
			this.finToolStripMenuItem.Text = "Find &Duplicates";
			this.finToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_FindDuplicates_Click);
			// 
			// optionsToolStripMenuItem
			// 
			this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languageToolStripMenuItem});
			this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
			this.optionsToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
			this.optionsToolStripMenuItem.Text = "&Options";
			// 
			// languageToolStripMenuItem
			// 
			this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.svenskaToolStripMenuItem,
            this.bosniskaToolStripMenuItem});
			this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
			this.languageToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
			this.languageToolStripMenuItem.Text = "&Language";
			// 
			// englishToolStripMenuItem
			// 
			this.englishToolStripMenuItem.Checked = true;
			this.englishToolStripMenuItem.CheckOnClick = true;
			this.englishToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
			this.englishToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
			this.englishToolStripMenuItem.Text = "&English";
			// 
			// svenskaToolStripMenuItem
			// 
			this.svenskaToolStripMenuItem.CheckOnClick = true;
			this.svenskaToolStripMenuItem.Name = "svenskaToolStripMenuItem";
			this.svenskaToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
			this.svenskaToolStripMenuItem.Text = "&Svenska";
			// 
			// bosniskaToolStripMenuItem
			// 
			this.bosniskaToolStripMenuItem.CheckOnClick = true;
			this.bosniskaToolStripMenuItem.Name = "bosniskaToolStripMenuItem";
			this.bosniskaToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
			this.bosniskaToolStripMenuItem.Text = "&Bosanski";
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.my_helpToolStripMenuItem,
            this.my_aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
			this.helpToolStripMenuItem.Text = "&Help";
			// 
			// my_helpToolStripMenuItem
			// 
			this.my_helpToolStripMenuItem.Name = "my_helpToolStripMenuItem";
			this.my_helpToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
			this.my_helpToolStripMenuItem.Text = "Help";
			// 
			// my_aboutToolStripMenuItem
			// 
			this.my_aboutToolStripMenuItem.Name = "my_aboutToolStripMenuItem";
			this.my_aboutToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
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
			((System.ComponentModel.ISupportInitialize)(this.My_UltraID3BindingSource)).EndInit();
			this.My_TabControl_BatchRen.ResumeLayout(false);
			this.m_TabPageBatch.ResumeLayout(false);
			this.m_TabPageRenaming.ResumeLayout(false);
			this.GroupBox_ExtractFromFName.ResumeLayout(false);
			this.GroupBox_ExtractFromFName.PerformLayout();
			this.m_TabPageCleaning.ResumeLayout(false);
			this.m_TabPageCleaning.PerformLayout();
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
        private System.Windows.Forms.BindingSource My_UltraID3BindingSource;
        private System.Windows.Forms.Label my_label_ID3V2;
		private System.Windows.Forms.Label my_label_ID3V1;
        private System.Windows.Forms.TabControl My_TabControl_BatchRen;
        private System.Windows.Forms.TabPage m_TabPageBatch;
		private System.Windows.Forms.TabPage m_TabPageRenaming;
		private System.Windows.Forms.SplitContainer y_splitContainer_Main;
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
		private System.Windows.Forms.ToolStripMenuItem finToolStripMenuItem;        
        private System.Windows.Forms.Button Button_ExtracFromFName_Test;
        private System.Windows.Forms.Label Label_Regextpresult;
        private System.Windows.Forms.TextBox TextBox_TestPath;
        private System.Windows.Forms.Button Button_regexp_properties;
        private System.Windows.Forms.GroupBox GroupBox_ExtractFromFName;
        private System.Windows.Forms.Button Button_ExtractFRomFName;
		private System.Windows.Forms.ComboBox ComboBox_ExtractTagsFromFNmane;
		private UserControlTrackList m_UserControlTrackList;
		private UserControlBatchRenameFields m_UserControlBatchRenameFields;
		private System.Windows.Forms.TabPage m_TabPageCleaning;
		private System.Windows.Forms.TextBox my_textBox_removeText;
		private System.Windows.Forms.CheckBox my_checkBox_UseRegExp;
		private System.Windows.Forms.Button my_button_ClearComments;
		private System.Windows.Forms.Button my_button_removeText;
		private System.Windows.Forms.Button my_button_GetTrackNrFronTitle;
		private System.Windows.Forms.TextBox my_textBox_fixTitle;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button my_button_fixTitle;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label m_LabelRealRexExpression;
		private System.Windows.Forms.Button m_ButtonAddRemovePressets;
		private System.Windows.Forms.ToolTip m_ToolTip;
		private System.Windows.Forms.Button m_ButtonSuggest;
    }
}

