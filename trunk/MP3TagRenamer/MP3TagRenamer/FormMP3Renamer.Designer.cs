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
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
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
            this.My_UltraID3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.My_HelpProvider = new System.Windows.Forms.HelpProvider();
            this.m_ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.y_splitContainer_Main = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.my_label_ID3V2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.my_label_ID3V1 = new System.Windows.Forms.Label();
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
            this.m_UserControlTrackList = new MP3TagRenamer.UserControlTrackList();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.My_MenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.My_UltraID3BindingSource)).BeginInit();
            this.y_splitContainer_Main.Panel1.SuspendLayout();
            this.y_splitContainer_Main.Panel2.SuspendLayout();
            this.y_splitContainer_Main.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.My_TabControl_BatchRen.SuspendLayout();
            this.m_TabPageBatch.SuspendLayout();
            this.m_TabPageRenaming.SuspendLayout();
            this.GroupBox_ExtractFromFName.SuspendLayout();
            this.m_TabPageCleaning.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.My_HelpProvider.SetShowHelp(this.toolStripContainer1.BottomToolStripPanel, ((bool)(resources.GetObject("toolStripContainer1.BottomToolStripPanel.ShowHelp"))));
            // 
            // toolStripContainer1.ContentPanel
            // 
            resources.ApplyResources(this.toolStripContainer1.ContentPanel, "toolStripContainer1.ContentPanel");
            this.toolStripContainer1.ContentPanel.Controls.Add(this.y_splitContainer_Main);
            this.My_HelpProvider.SetShowHelp(this.toolStripContainer1.ContentPanel, ((bool)(resources.GetObject("toolStripContainer1.ContentPanel.ShowHelp"))));
            resources.ApplyResources(this.toolStripContainer1, "toolStripContainer1");
            // 
            // toolStripContainer1.LeftToolStripPanel
            // 
            this.My_HelpProvider.SetShowHelp(this.toolStripContainer1.LeftToolStripPanel, ((bool)(resources.GetObject("toolStripContainer1.LeftToolStripPanel.ShowHelp"))));
            this.toolStripContainer1.Name = "toolStripContainer1";
            // 
            // toolStripContainer1.RightToolStripPanel
            // 
            this.My_HelpProvider.SetShowHelp(this.toolStripContainer1.RightToolStripPanel, ((bool)(resources.GetObject("toolStripContainer1.RightToolStripPanel.ShowHelp"))));
            this.My_HelpProvider.SetShowHelp(this.toolStripContainer1, ((bool)(resources.GetObject("toolStripContainer1.ShowHelp"))));
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.My_MenuStrip);
            this.My_HelpProvider.SetShowHelp(this.toolStripContainer1.TopToolStripPanel, ((bool)(resources.GetObject("toolStripContainer1.TopToolStripPanel.ShowHelp"))));
            // 
            // My_MenuStrip
            // 
            resources.ApplyResources(this.My_MenuStrip, "My_MenuStrip");
            this.My_MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.My_MenuStrip.Name = "My_MenuStrip";
            this.My_HelpProvider.SetShowHelp(this.My_MenuStrip, ((bool)(resources.GetObject("My_MenuStrip.ShowHelp"))));
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.batchToolStripMenuItem,
            this.renamingToolStripMenuItem,
            this.finToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            resources.ApplyResources(this.viewToolStripMenuItem, "viewToolStripMenuItem");
            // 
            // batchToolStripMenuItem
            // 
            this.batchToolStripMenuItem.Name = "batchToolStripMenuItem";
            resources.ApplyResources(this.batchToolStripMenuItem, "batchToolStripMenuItem");
            this.batchToolStripMenuItem.Click += new System.EventHandler(this.BatchToolStripMenuItem_Click);
            // 
            // renamingToolStripMenuItem
            // 
            this.renamingToolStripMenuItem.Name = "renamingToolStripMenuItem";
            resources.ApplyResources(this.renamingToolStripMenuItem, "renamingToolStripMenuItem");
            this.renamingToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_RenamingClick);
            // 
            // finToolStripMenuItem
            // 
            this.finToolStripMenuItem.Name = "finToolStripMenuItem";
            resources.ApplyResources(this.finToolStripMenuItem, "finToolStripMenuItem");
            this.finToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_FindDuplicates_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languageToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            resources.ApplyResources(this.optionsToolStripMenuItem, "optionsToolStripMenuItem");
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.svenskaToolStripMenuItem,
            this.bosniskaToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            resources.ApplyResources(this.languageToolStripMenuItem, "languageToolStripMenuItem");
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Checked = true;
            this.englishToolStripMenuItem.CheckOnClick = true;
            this.englishToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            resources.ApplyResources(this.englishToolStripMenuItem, "englishToolStripMenuItem");
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // svenskaToolStripMenuItem
            // 
            this.svenskaToolStripMenuItem.CheckOnClick = true;
            this.svenskaToolStripMenuItem.Name = "svenskaToolStripMenuItem";
            resources.ApplyResources(this.svenskaToolStripMenuItem, "svenskaToolStripMenuItem");
            this.svenskaToolStripMenuItem.Click += new System.EventHandler(this.svenskaToolStripMenuItem_Click);
            // 
            // bosniskaToolStripMenuItem
            // 
            this.bosniskaToolStripMenuItem.CheckOnClick = true;
            this.bosniskaToolStripMenuItem.Name = "bosniskaToolStripMenuItem";
            resources.ApplyResources(this.bosniskaToolStripMenuItem, "bosniskaToolStripMenuItem");
            this.bosniskaToolStripMenuItem.Click += new System.EventHandler(this.bosniskaToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.my_helpToolStripMenuItem,
            this.my_aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            // 
            // my_helpToolStripMenuItem
            // 
            this.my_helpToolStripMenuItem.Name = "my_helpToolStripMenuItem";
            resources.ApplyResources(this.my_helpToolStripMenuItem, "my_helpToolStripMenuItem");
            // 
            // my_aboutToolStripMenuItem
            // 
            this.my_aboutToolStripMenuItem.Name = "my_aboutToolStripMenuItem";
            resources.ApplyResources(this.my_aboutToolStripMenuItem, "my_aboutToolStripMenuItem");
            this.my_aboutToolStripMenuItem.Click += new System.EventHandler(this.About_Click);
            // 
            // My_UltraID3BindingSource
            // 
            this.My_UltraID3BindingSource.DataSource = typeof(HundredMilesSoftware.UltraID3Lib.UltraID3);
            // 
            // My_HelpProvider
            // 
            resources.ApplyResources(this.My_HelpProvider, "My_HelpProvider");
            // 
            // y_splitContainer_Main
            // 
            this.y_splitContainer_Main.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.y_splitContainer_Main.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.y_splitContainer_Main, "y_splitContainer_Main");
            this.y_splitContainer_Main.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.y_splitContainer_Main.Name = "y_splitContainer_Main";
            // 
            // y_splitContainer_Main.Panel1
            // 
            this.y_splitContainer_Main.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.y_splitContainer_Main.Panel1.Controls.Add(this.groupBox1);
            this.y_splitContainer_Main.Panel1.Controls.Add(this.groupBox2);
            this.y_splitContainer_Main.Panel1.Controls.Add(this.My_TabControl_BatchRen);
            this.My_HelpProvider.SetShowHelp(this.y_splitContainer_Main.Panel1, ((bool)(resources.GetObject("y_splitContainer_Main.Panel1.ShowHelp"))));
            // 
            // y_splitContainer_Main.Panel2
            // 
            this.y_splitContainer_Main.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.y_splitContainer_Main.Panel2.Controls.Add(this.m_UserControlTrackList);
            this.My_HelpProvider.SetShowHelp(this.y_splitContainer_Main.Panel2, ((bool)(resources.GetObject("y_splitContainer_Main.Panel2.ShowHelp"))));
            this.My_HelpProvider.SetShowHelp(this.y_splitContainer_Main, ((bool)(resources.GetObject("y_splitContainer_Main.ShowHelp"))));
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.my_label_ID3V2);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.My_HelpProvider.SetShowHelp(this.groupBox1, ((bool)(resources.GetObject("groupBox1.ShowHelp"))));
            this.groupBox1.TabStop = false;
            // 
            // my_label_ID3V2
            // 
            resources.ApplyResources(this.my_label_ID3V2, "my_label_ID3V2");
            this.my_label_ID3V2.Name = "my_label_ID3V2";
            this.My_HelpProvider.SetShowHelp(this.my_label_ID3V2, ((bool)(resources.GetObject("my_label_ID3V2.ShowHelp"))));
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.my_label_ID3V1);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.My_HelpProvider.SetShowHelp(this.groupBox2, ((bool)(resources.GetObject("groupBox2.ShowHelp"))));
            this.groupBox2.TabStop = false;
            // 
            // my_label_ID3V1
            // 
            resources.ApplyResources(this.my_label_ID3V1, "my_label_ID3V1");
            this.my_label_ID3V1.Name = "my_label_ID3V1";
            this.My_HelpProvider.SetShowHelp(this.my_label_ID3V1, ((bool)(resources.GetObject("my_label_ID3V1.ShowHelp"))));
            // 
            // My_TabControl_BatchRen
            // 
            resources.ApplyResources(this.My_TabControl_BatchRen, "My_TabControl_BatchRen");
            this.My_TabControl_BatchRen.Controls.Add(this.m_TabPageBatch);
            this.My_TabControl_BatchRen.Controls.Add(this.m_TabPageRenaming);
            this.My_TabControl_BatchRen.Controls.Add(this.m_TabPageCleaning);
            this.My_TabControl_BatchRen.Name = "My_TabControl_BatchRen";
            this.My_TabControl_BatchRen.SelectedIndex = 0;
            this.My_HelpProvider.SetShowHelp(this.My_TabControl_BatchRen, ((bool)(resources.GetObject("My_TabControl_BatchRen.ShowHelp"))));
            // 
            // m_TabPageBatch
            // 
            this.m_TabPageBatch.Controls.Add(this.m_UserControlBatchRenameFields);
            resources.ApplyResources(this.m_TabPageBatch, "m_TabPageBatch");
            this.m_TabPageBatch.Name = "m_TabPageBatch";
            this.My_HelpProvider.SetShowHelp(this.m_TabPageBatch, ((bool)(resources.GetObject("m_TabPageBatch.ShowHelp"))));
            this.m_TabPageBatch.UseVisualStyleBackColor = true;
            // 
            // m_UserControlBatchRenameFields
            // 
            this.m_UserControlBatchRenameFields.Album = "";
            this.m_UserControlBatchRenameFields.Artist = "";
            resources.ApplyResources(this.m_UserControlBatchRenameFields, "m_UserControlBatchRenameFields");
            this.m_UserControlBatchRenameFields.Ganre = "";
            this.m_UserControlBatchRenameFields.Name = "m_UserControlBatchRenameFields";
            this.My_HelpProvider.SetShowHelp(this.m_UserControlBatchRenameFields, ((bool)(resources.GetObject("m_UserControlBatchRenameFields.ShowHelp"))));
            this.m_UserControlBatchRenameFields.Year = null;
            // 
            // m_TabPageRenaming
            // 
            this.m_TabPageRenaming.Controls.Add(this.GroupBox_ExtractFromFName);
            resources.ApplyResources(this.m_TabPageRenaming, "m_TabPageRenaming");
            this.m_TabPageRenaming.Name = "m_TabPageRenaming";
            this.My_HelpProvider.SetShowHelp(this.m_TabPageRenaming, ((bool)(resources.GetObject("m_TabPageRenaming.ShowHelp"))));
            this.m_TabPageRenaming.UseVisualStyleBackColor = true;
            // 
            // GroupBox_ExtractFromFName
            // 
            resources.ApplyResources(this.GroupBox_ExtractFromFName, "GroupBox_ExtractFromFName");
            this.GroupBox_ExtractFromFName.Controls.Add(this.m_ButtonSuggest);
            this.GroupBox_ExtractFromFName.Controls.Add(this.m_ButtonAddRemovePressets);
            this.GroupBox_ExtractFromFName.Controls.Add(this.m_LabelRealRexExpression);
            this.GroupBox_ExtractFromFName.Controls.Add(this.ComboBox_ExtractTagsFromFNmane);
            this.GroupBox_ExtractFromFName.Controls.Add(this.Button_ExtractFRomFName);
            this.GroupBox_ExtractFromFName.Controls.Add(this.Button_regexp_properties);
            this.GroupBox_ExtractFromFName.Controls.Add(this.Button_ExtracFromFName_Test);
            this.GroupBox_ExtractFromFName.Controls.Add(this.Label_Regextpresult);
            this.GroupBox_ExtractFromFName.Controls.Add(this.TextBox_TestPath);
            this.GroupBox_ExtractFromFName.Name = "GroupBox_ExtractFromFName";
            this.My_HelpProvider.SetShowHelp(this.GroupBox_ExtractFromFName, ((bool)(resources.GetObject("GroupBox_ExtractFromFName.ShowHelp"))));
            this.GroupBox_ExtractFromFName.TabStop = false;
            // 
            // m_ButtonSuggest
            // 
            resources.ApplyResources(this.m_ButtonSuggest, "m_ButtonSuggest");
            this.m_ButtonSuggest.Name = "m_ButtonSuggest";
            this.My_HelpProvider.SetShowHelp(this.m_ButtonSuggest, ((bool)(resources.GetObject("m_ButtonSuggest.ShowHelp"))));
            this.m_ToolTip.SetToolTip(this.m_ButtonSuggest, resources.GetString("m_ButtonSuggest.ToolTip"));
            this.m_ButtonSuggest.UseVisualStyleBackColor = true;
            this.m_ButtonSuggest.Click += new System.EventHandler(this.ButtonSuggest_Click);
            // 
            // m_ButtonAddRemovePressets
            // 
            resources.ApplyResources(this.m_ButtonAddRemovePressets, "m_ButtonAddRemovePressets");
            this.m_ButtonAddRemovePressets.Name = "m_ButtonAddRemovePressets";
            this.My_HelpProvider.SetShowHelp(this.m_ButtonAddRemovePressets, ((bool)(resources.GetObject("m_ButtonAddRemovePressets.ShowHelp"))));
            this.m_ToolTip.SetToolTip(this.m_ButtonAddRemovePressets, resources.GetString("m_ButtonAddRemovePressets.ToolTip"));
            this.m_ButtonAddRemovePressets.UseVisualStyleBackColor = true;
            this.m_ButtonAddRemovePressets.Click += new System.EventHandler(this.ButtonAddRemovePressets_Click);
            // 
            // m_LabelRealRexExpression
            // 
            resources.ApplyResources(this.m_LabelRealRexExpression, "m_LabelRealRexExpression");
            this.m_LabelRealRexExpression.Name = "m_LabelRealRexExpression";
            this.My_HelpProvider.SetShowHelp(this.m_LabelRealRexExpression, ((bool)(resources.GetObject("m_LabelRealRexExpression.ShowHelp"))));
            // 
            // ComboBox_ExtractTagsFromFNmane
            // 
            this.ComboBox_ExtractTagsFromFNmane.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ComboBox_ExtractTagsFromFNmane.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboBox_ExtractTagsFromFNmane.FormattingEnabled = true;
            resources.ApplyResources(this.ComboBox_ExtractTagsFromFNmane, "ComboBox_ExtractTagsFromFNmane");
            this.ComboBox_ExtractTagsFromFNmane.Name = "ComboBox_ExtractTagsFromFNmane";
            this.My_HelpProvider.SetShowHelp(this.ComboBox_ExtractTagsFromFNmane, ((bool)(resources.GetObject("ComboBox_ExtractTagsFromFNmane.ShowHelp"))));
            this.ComboBox_ExtractTagsFromFNmane.TextChanged += new System.EventHandler(this.ComboBox_ExtractTagsFromFNmane_TextChanged);
            // 
            // Button_ExtractFRomFName
            // 
            resources.ApplyResources(this.Button_ExtractFRomFName, "Button_ExtractFRomFName");
            this.Button_ExtractFRomFName.Name = "Button_ExtractFRomFName";
            this.My_HelpProvider.SetShowHelp(this.Button_ExtractFRomFName, ((bool)(resources.GetObject("Button_ExtractFRomFName.ShowHelp"))));
            this.Button_ExtractFRomFName.UseVisualStyleBackColor = true;
            this.Button_ExtractFRomFName.Click += new System.EventHandler(this.Button_ExtractFRomFName_Click);
            // 
            // Button_regexp_properties
            // 
            resources.ApplyResources(this.Button_regexp_properties, "Button_regexp_properties");
            this.Button_regexp_properties.Name = "Button_regexp_properties";
            this.My_HelpProvider.SetShowHelp(this.Button_regexp_properties, ((bool)(resources.GetObject("Button_regexp_properties.ShowHelp"))));
            this.m_ToolTip.SetToolTip(this.Button_regexp_properties, resources.GetString("Button_regexp_properties.ToolTip"));
            this.Button_regexp_properties.UseVisualStyleBackColor = true;
            this.Button_regexp_properties.Click += new System.EventHandler(this.Button_regexp_properties_Click);
            // 
            // Button_ExtracFromFName_Test
            // 
            resources.ApplyResources(this.Button_ExtracFromFName_Test, "Button_ExtracFromFName_Test");
            this.Button_ExtracFromFName_Test.Name = "Button_ExtracFromFName_Test";
            this.My_HelpProvider.SetShowHelp(this.Button_ExtracFromFName_Test, ((bool)(resources.GetObject("Button_ExtracFromFName_Test.ShowHelp"))));
            this.m_ToolTip.SetToolTip(this.Button_ExtracFromFName_Test, resources.GetString("Button_ExtracFromFName_Test.ToolTip"));
            this.Button_ExtracFromFName_Test.UseVisualStyleBackColor = true;
            this.Button_ExtracFromFName_Test.Click += new System.EventHandler(this.Button_ExtracFromFNameTEST_Click);
            // 
            // Label_Regextpresult
            // 
            this.Label_Regextpresult.AutoEllipsis = true;
            resources.ApplyResources(this.Label_Regextpresult, "Label_Regextpresult");
            this.Label_Regextpresult.Name = "Label_Regextpresult";
            this.My_HelpProvider.SetShowHelp(this.Label_Regextpresult, ((bool)(resources.GetObject("Label_Regextpresult.ShowHelp"))));
            // 
            // TextBox_TestPath
            // 
            resources.ApplyResources(this.TextBox_TestPath, "TextBox_TestPath");
            this.TextBox_TestPath.Name = "TextBox_TestPath";
            this.TextBox_TestPath.ReadOnly = true;
            this.My_HelpProvider.SetShowHelp(this.TextBox_TestPath, ((bool)(resources.GetObject("TextBox_TestPath.ShowHelp"))));
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
            resources.ApplyResources(this.m_TabPageCleaning, "m_TabPageCleaning");
            this.m_TabPageCleaning.Name = "m_TabPageCleaning";
            this.My_HelpProvider.SetShowHelp(this.m_TabPageCleaning, ((bool)(resources.GetObject("m_TabPageCleaning.ShowHelp"))));
            this.m_TabPageCleaning.UseVisualStyleBackColor = true;
            // 
            // my_textBox_removeText
            // 
            resources.ApplyResources(this.my_textBox_removeText, "my_textBox_removeText");
            this.my_textBox_removeText.Name = "my_textBox_removeText";
            this.My_HelpProvider.SetShowHelp(this.my_textBox_removeText, ((bool)(resources.GetObject("my_textBox_removeText.ShowHelp"))));
            // 
            // my_checkBox_UseRegExp
            // 
            resources.ApplyResources(this.my_checkBox_UseRegExp, "my_checkBox_UseRegExp");
            this.my_checkBox_UseRegExp.Checked = true;
            this.my_checkBox_UseRegExp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.my_checkBox_UseRegExp.Name = "my_checkBox_UseRegExp";
            this.My_HelpProvider.SetShowHelp(this.my_checkBox_UseRegExp, ((bool)(resources.GetObject("my_checkBox_UseRegExp.ShowHelp"))));
            this.my_checkBox_UseRegExp.UseVisualStyleBackColor = true;
            // 
            // my_button_ClearComments
            // 
            resources.ApplyResources(this.my_button_ClearComments, "my_button_ClearComments");
            this.my_button_ClearComments.Name = "my_button_ClearComments";
            this.My_HelpProvider.SetShowHelp(this.my_button_ClearComments, ((bool)(resources.GetObject("my_button_ClearComments.ShowHelp"))));
            this.my_button_ClearComments.UseVisualStyleBackColor = true;
            this.my_button_ClearComments.Click += new System.EventHandler(this.Button_ClearComments_Click);
            // 
            // my_button_removeText
            // 
            resources.ApplyResources(this.my_button_removeText, "my_button_removeText");
            this.my_button_removeText.Name = "my_button_removeText";
            this.My_HelpProvider.SetShowHelp(this.my_button_removeText, ((bool)(resources.GetObject("my_button_removeText.ShowHelp"))));
            this.my_button_removeText.UseVisualStyleBackColor = true;
            this.my_button_removeText.Click += new System.EventHandler(this.Button_removeText_Click);
            // 
            // my_button_GetTrackNrFronTitle
            // 
            resources.ApplyResources(this.my_button_GetTrackNrFronTitle, "my_button_GetTrackNrFronTitle");
            this.my_button_GetTrackNrFronTitle.Name = "my_button_GetTrackNrFronTitle";
            this.My_HelpProvider.SetShowHelp(this.my_button_GetTrackNrFronTitle, ((bool)(resources.GetObject("my_button_GetTrackNrFronTitle.ShowHelp"))));
            this.my_button_GetTrackNrFronTitle.UseVisualStyleBackColor = true;
            this.my_button_GetTrackNrFronTitle.Click += new System.EventHandler(this.Button_GetTrackNrFronTitle_Click);
            // 
            // my_textBox_fixTitle
            // 
            this.My_HelpProvider.SetHelpKeyword(this.my_textBox_fixTitle, resources.GetString("my_textBox_fixTitle.HelpKeyword"));
            this.My_HelpProvider.SetHelpNavigator(this.my_textBox_fixTitle, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("my_textBox_fixTitle.HelpNavigator"))));
            this.My_HelpProvider.SetHelpString(this.my_textBox_fixTitle, resources.GetString("my_textBox_fixTitle.HelpString"));
            resources.ApplyResources(this.my_textBox_fixTitle, "my_textBox_fixTitle");
            this.my_textBox_fixTitle.Name = "my_textBox_fixTitle";
            this.My_HelpProvider.SetShowHelp(this.my_textBox_fixTitle, ((bool)(resources.GetObject("my_textBox_fixTitle.ShowHelp"))));
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.My_HelpProvider.SetShowHelp(this.label2, ((bool)(resources.GetObject("label2.ShowHelp"))));
            // 
            // my_button_fixTitle
            // 
            resources.ApplyResources(this.my_button_fixTitle, "my_button_fixTitle");
            this.my_button_fixTitle.Name = "my_button_fixTitle";
            this.My_HelpProvider.SetShowHelp(this.my_button_fixTitle, ((bool)(resources.GetObject("my_button_fixTitle.ShowHelp"))));
            this.my_button_fixTitle.UseVisualStyleBackColor = true;
            this.my_button_fixTitle.Click += new System.EventHandler(this.Button_fixTitle_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.My_HelpProvider.SetShowHelp(this.label1, ((bool)(resources.GetObject("label1.ShowHelp"))));
            // 
            // m_UserControlTrackList
            // 
            resources.ApplyResources(this.m_UserControlTrackList, "m_UserControlTrackList");
            this.m_UserControlTrackList.ID3V1Text = null;
            this.m_UserControlTrackList.ID3V2Text = null;
            this.m_UserControlTrackList.Name = "m_UserControlTrackList";
            this.m_UserControlTrackList.SelectedTracksPath = null;
            this.My_HelpProvider.SetShowHelp(this.m_UserControlTrackList, ((bool)(resources.GetObject("m_UserControlTrackList.ShowHelp"))));
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStripContainer1);
            this.HelpButton = true;
            this.My_HelpProvider.SetHelpKeyword(this, resources.GetString("$this.HelpKeyword"));
            this.My_HelpProvider.SetHelpString(this, resources.GetString("$this.HelpString"));
            this.MainMenuStrip = this.My_MenuStrip;
            this.Name = "MainForm";
            this.My_HelpProvider.SetShowHelp(this, ((bool)(resources.GetObject("$this.ShowHelp"))));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.My_MenuStrip.ResumeLayout(false);
            this.My_MenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.My_UltraID3BindingSource)).EndInit();
            this.y_splitContainer_Main.Panel1.ResumeLayout(false);
            this.y_splitContainer_Main.Panel2.ResumeLayout(false);
            this.y_splitContainer_Main.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.My_TabControl_BatchRen.ResumeLayout(false);
            this.m_TabPageBatch.ResumeLayout(false);
            this.m_TabPageRenaming.ResumeLayout(false);
            this.GroupBox_ExtractFromFName.ResumeLayout(false);
            this.GroupBox_ExtractFromFName.PerformLayout();
            this.m_TabPageCleaning.ResumeLayout(false);
            this.m_TabPageCleaning.PerformLayout();
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

