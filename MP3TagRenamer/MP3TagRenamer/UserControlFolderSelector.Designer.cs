namespace MP3TagRenamer
{
    partial class UserControlFolderSelector
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
			this.my_groupBox = new System.Windows.Forms.GroupBox();
			this.my_button_Browse = new System.Windows.Forms.Button();
			this.my_comboBox_Folder = new System.Windows.Forms.ComboBox();
			this.my_folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.my_groupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// my_groupBox
			// 
			this.my_groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.my_groupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.my_groupBox.Controls.Add(this.my_button_Browse);
			this.my_groupBox.Controls.Add(this.my_comboBox_Folder);
			this.my_groupBox.Location = new System.Drawing.Point(3, 3);
			this.my_groupBox.Name = "my_groupBox";
			this.my_groupBox.Size = new System.Drawing.Size(738, 40);
			this.my_groupBox.TabIndex = 7;
			this.my_groupBox.TabStop = false;
			this.my_groupBox.Text = "Folder";
			// 
			// my_button_Browse
			// 
			this.my_button_Browse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.my_button_Browse.Location = new System.Drawing.Point(657, 10);
			this.my_button_Browse.Name = "my_button_Browse";
			this.my_button_Browse.Size = new System.Drawing.Size(75, 23);
			this.my_button_Browse.TabIndex = 4;
			this.my_button_Browse.Text = "&Browse";
			this.my_button_Browse.UseVisualStyleBackColor = true;
			this.my_button_Browse.Click += new System.EventHandler(this.Button_Browse_Click);
			// 
			// my_comboBox_Folder
			// 
			this.my_comboBox_Folder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.my_comboBox_Folder.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.my_comboBox_Folder.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
			this.my_comboBox_Folder.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::MP3TagRenamer.Properties.Settings.Default, "LastUsedPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.my_comboBox_Folder.FormattingEnabled = true;
			this.my_comboBox_Folder.Location = new System.Drawing.Point(6, 11);
			this.my_comboBox_Folder.Name = "my_comboBox_Folder";
			this.my_comboBox_Folder.Size = new System.Drawing.Size(645, 21);
			this.my_comboBox_Folder.TabIndex = 3;
			this.my_comboBox_Folder.Text = global::MP3TagRenamer.Properties.Settings.Default.LastUsedPath;
			this.my_comboBox_Folder.SelectedIndexChanged += new System.EventHandler(this.ComboBoxFolder_SelectedIndexChanged);
			this.my_comboBox_Folder.DropDownClosed += new System.EventHandler(this.ComboBox_Folder_DropDownClosed);
			this.my_comboBox_Folder.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ComboBoxFolder_KeyDown);
			this.my_comboBox_Folder.TextChanged += new System.EventHandler(this.ComboBox_Folder_TextChanged);
			// 
			// UserControlFolderSelector
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.my_groupBox);
			this.Name = "UserControlFolderSelector";
			this.Size = new System.Drawing.Size(744, 47);
			this.my_groupBox.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox my_groupBox;
        private System.Windows.Forms.Button my_button_Browse;
        private System.Windows.Forms.ComboBox my_comboBox_Folder;
        private System.Windows.Forms.FolderBrowserDialog my_folderBrowserDialog;
    }
}
