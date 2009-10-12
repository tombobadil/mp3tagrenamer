namespace MP3TagRenamer
{
    partial class FormDeleteFileList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( FormDeleteFileList ) );
            this.panel1 = new System.Windows.Forms.Panel();
            this.my_checkedListBox_FilesPaths = new System.Windows.Forms.CheckedListBox();
            this.panel_selectButtons = new System.Windows.Forms.Panel();
            this.button_Unselect = new System.Windows.Forms.Button();
            this.button_Select = new System.Windows.Forms.Button();
            this.panel_okcancel = new System.Windows.Forms.Panel();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_OK = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel_selectButtons.SuspendLayout();
            this.panel_okcancel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add( this.my_checkedListBox_FilesPaths );
            this.panel1.Controls.Add( this.panel_selectButtons );
            this.panel1.Controls.Add( this.panel_okcancel );
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point( 0, 0 );
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size( 716, 422 );
            this.panel1.TabIndex = 0;
            // 
            // my_checkedListBox_FilesPaths
            // 
            this.my_checkedListBox_FilesPaths.CheckOnClick = true;
            this.my_checkedListBox_FilesPaths.Dock = System.Windows.Forms.DockStyle.Fill;
            this.my_checkedListBox_FilesPaths.FormattingEnabled = true;
            this.my_checkedListBox_FilesPaths.Location = new System.Drawing.Point( 0, 33 );
            this.my_checkedListBox_FilesPaths.Name = "my_checkedListBox_FilesPaths";
            this.my_checkedListBox_FilesPaths.Size = new System.Drawing.Size( 716, 349 );
            this.my_checkedListBox_FilesPaths.Sorted = true;
            this.my_checkedListBox_FilesPaths.TabIndex = 2;
            // 
            // panel_selectButtons
            // 
            this.panel_selectButtons.Controls.Add( this.button_Unselect );
            this.panel_selectButtons.Controls.Add( this.button_Select );
            this.panel_selectButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_selectButtons.Location = new System.Drawing.Point( 0, 0 );
            this.panel_selectButtons.Name = "panel_selectButtons";
            this.panel_selectButtons.Size = new System.Drawing.Size( 716, 33 );
            this.panel_selectButtons.TabIndex = 1;
            // 
            // button_Unselect
            // 
            this.button_Unselect.Location = new System.Drawing.Point( 98, 3 );
            this.button_Unselect.Name = "button_Unselect";
            this.button_Unselect.Size = new System.Drawing.Size( 75, 23 );
            this.button_Unselect.TabIndex = 1;
            this.button_Unselect.Text = "Unselect all";
            this.button_Unselect.UseVisualStyleBackColor = true;
            // 
            // button_Select
            // 
            this.button_Select.Location = new System.Drawing.Point( 12, 3 );
            this.button_Select.Name = "button_Select";
            this.button_Select.Size = new System.Drawing.Size( 75, 23 );
            this.button_Select.TabIndex = 0;
            this.button_Select.Text = "Select all";
            this.button_Select.UseVisualStyleBackColor = true;
            // 
            // panel_okcancel
            // 
            this.panel_okcancel.Controls.Add( this.button_Cancel );
            this.panel_okcancel.Controls.Add( this.button_OK );
            this.panel_okcancel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_okcancel.Location = new System.Drawing.Point( 0, 384 );
            this.panel_okcancel.Name = "panel_okcancel";
            this.panel_okcancel.Size = new System.Drawing.Size( 716, 38 );
            this.panel_okcancel.TabIndex = 0;
            // 
            // button_Cancel
            // 
            this.button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Cancel.Location = new System.Drawing.Point( 584, 4 );
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size( 75, 23 );
            this.button_Cancel.TabIndex = 1;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            // 
            // button_OK
            // 
            this.button_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_OK.Location = new System.Drawing.Point( 490, 4 );
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size( 75, 23 );
            this.button_OK.TabIndex = 0;
            this.button_OK.Text = "Delete";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler( this.Button_OK_Click );
            // 
            // DeleteFileList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 716, 422 );
            this.Controls.Add( this.panel1 );
            this.Icon = ( (System.Drawing.Icon)( resources.GetObject( "$this.Icon" ) ) );
            this.MinimizeBox = false;
            this.Name = "DeleteFileList";
            this.Text = "Delete selected MP3\'s";
            this.panel1.ResumeLayout( false );
            this.panel_selectButtons.ResumeLayout( false );
            this.panel_okcancel.ResumeLayout( false );
            this.ResumeLayout( false );

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckedListBox my_checkedListBox_FilesPaths;
        private System.Windows.Forms.Panel panel_selectButtons;
        private System.Windows.Forms.Panel panel_okcancel;
        private System.Windows.Forms.Button button_Unselect;
        private System.Windows.Forms.Button button_Select;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_OK;
    }
}