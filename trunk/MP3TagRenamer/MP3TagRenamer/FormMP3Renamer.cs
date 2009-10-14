using System;
using System.Collections;
using System.Windows.Forms;

namespace MP3TagRenamer
{
    public partial class MainForm : Form
    {
        private UserControlCompareDuplicates my_compare_duplicates;
            
        public MainForm()
        {
            InitializeComponent();
			SetRealRegExpLabel();
			ResetRegExpComboBox();
			m_UserControlBatchRenameFields.UpdateClicked += new EventHandler(Button_UpdateBatch_Click);
			m_UserControlTrackList.BatchFieldsUpdated += new UserControlTrackList.BatchFieldsInfoHandler(UserControlTrackList_BatchFieldsUpdated);
			m_UserControlTrackList.TrackListRowEnter += new EventHandler(UserControlTrackList_TrackListRowEnter);
        }

		private void ResetRegExpComboBox()
		{
			string[] regExps = 
				new string[]{	
					"#artist# - #tracknr# - #album# - #year# - #title#",
					"#artist# - #album# - #year# - #tracknr# - #title#",
					"#artist# - #tracknr# - #album# - #title#",
					"#artist# - #tracknr# - #title#",
					"#artist# - #title#",
					"#title#"};
			this.ComboBox_ExtractTagsFromFNmane.Items.AddRange(regExps);
			if (global::MP3TagRenamer.Properties.Settings.Default.RegExpHistoryList != null
				&& global::MP3TagRenamer.Properties.Settings.Default.RegExpHistoryList.Count > 0) {
					this.ComboBox_ExtractTagsFromFNmane.Items.Clear();
					this.ComboBox_ExtractTagsFromFNmane.Items.AddRange(global::MP3TagRenamer.Properties.Settings.Default.RegExpHistoryList.ToArray());
			}
		}
		

		void UserControlTrackList_TrackListRowEnter(object sender, EventArgs e)
		{
			this.my_label_ID3V1.Text = m_UserControlTrackList.ID3V1Text;
			this.my_label_ID3V2.Text = m_UserControlTrackList.ID3V2Text;
			TextBox_TestPath.Text = m_UserControlTrackList.SelectedTracksPath;
		}

		void UserControlTrackList_BatchFieldsUpdated(object sender, BatchFieldsInfo bachFieldsInfo)
		{
			m_UserControlBatchRenameFields.UpdateFields(bachFieldsInfo);
		}


        private void Button_fixTitle_Click( object sender, EventArgs e )
        {
			m_UserControlTrackList.FixTitle(my_textBox_fixTitle.Text);			
        }

        private void Button_removeText_Click( object sender, EventArgs e )
        {
			m_UserControlTrackList.RemoveText(my_textBox_removeText.Text);			
        }

        /// <summary>
        /// Set track number to all tracks in datagirdview by extracing it from 
        /// title or file name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_GetTrackNrFronTitle_Click( object sender, EventArgs e )
        {
			m_UserControlTrackList.GetTrackNrFronTitle();			
        }

        /// <summary>
        /// Clear all comments in all tracks in datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_ClearComments_Click( object sender, EventArgs e )
        {
			m_UserControlTrackList.ClearComments();			
        }

        private void Button_UpdateBatch_Click( object sender, EventArgs e )
        {
			m_UserControlTrackList.UpdateAllTracks(m_UserControlBatchRenameFields);		    			
        }


        private void About_Click( object sender, EventArgs e )
        {
            new FormAboutBox().ShowDialog(this);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                global::MP3TagRenamer.Properties.Settings.Default.LastUsedPath = m_UserControlTrackList.ActualPath;
                if (global::MP3TagRenamer.Properties.Settings.Default.VisitedPaths == null)
                    global::MP3TagRenamer.Properties.Settings.Default.VisitedPaths = new System.Collections.Specialized.StringCollection();
				global::MP3TagRenamer.Properties.Settings.Default.VisitedPaths.AddRange(m_UserControlTrackList.VisitedPaths);

				ArrayList regExps = new ArrayList();
				//for (int i = 0; i < ComboBox_ExtractTagsFromFNmane.Items.Count; i++)
				//{
					regExps.AddRange(ComboBox_ExtractTagsFromFNmane.Items);
				//}
				global::MP3TagRenamer.Properties.Settings.Default.RegExpHistoryList = new ArrayList();
				global::MP3TagRenamer.Properties.Settings.Default.RegExpHistoryList.AddRange(regExps);

                global::MP3TagRenamer.Properties.Settings.Default.Save();
            }
            catch 
            {
                
            }
        }        

        #region Extracing info from file name    

		private void SetRealRegExpLabel()
		{
			m_LabelRealRexExpression.Text = "Real RegExp:" +  UserControlTrackList.GetRegExpFromInput(ComboBox_ExtractTagsFromFNmane.Text);
		}

		private void Button_ExtracFromFNameTEST_Click(object sender, EventArgs e)
		{
			SetRealRegExpLabel();
			Label_Regextpresult.Text = UserControlTrackList.ExtracFromFName_TEST(ComboBox_ExtractTagsFromFNmane.Text, m_UserControlTrackList.SelectedTracksPath);
		}

        private void Button_ExtractFRomFName_Click( object sender , EventArgs e )
        {
			SetRealRegExpLabel();
			m_UserControlTrackList.ExtractFRomFName(ComboBox_ExtractTagsFromFNmane.Text);
        }

        #endregion


        #region ToolStripMenu Items Click Events
        private void ToolStripMenuItem_FindDuplicates_Click(object sender, EventArgs e)
        {

            this.toolStripContainer1.ContentPanel.Controls.Clear();
            if (my_compare_duplicates == null)
                my_compare_duplicates = new UserControlCompareDuplicates();
            this.toolStripContainer1.ContentPanel.Controls.Add(this.my_compare_duplicates);
            my_compare_duplicates.Dock = DockStyle.Fill;
        }

        private void ToolStripMenuItem_RenamingClick(object sender, EventArgs e)
        {
            this.toolStripContainer1.ContentPanel.Controls.Clear();
            this.toolStripContainer1.ContentPanel.Controls.Add(this.y_splitContainer_Main);
            this.My_TabControl_BatchRen.SelectedTab = m_TabPageRenaming;


        }
        private void BatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.toolStripContainer1.ContentPanel.Controls.Clear();
            this.toolStripContainer1.ContentPanel.Controls.Add(this.y_splitContainer_Main);
            this.My_TabControl_BatchRen.SelectedTab = m_TabPageBatch;

        }
        #endregion ToolStripMenu Items Click Events


		private void Button_regexp_properties_Click(object sender, EventArgs e)
		{
			new MP3TagEditor.TrackInfoExtracingProperties().ShowDialog();
		}

		private void ComboBox_ExtractTagsFromFNmane_TextChanged(object sender, EventArgs e)
		{
			this.SetRealRegExpLabel();
		}

		private void ButtonAddRemovePressets_Click(object sender, EventArgs e)
		{
			FormComposePressets pressets = new FormComposePressets() { Path = this.TextBox_TestPath.Text };
			if (pressets.ShowDialog() == DialogResult.OK) {
				this.ComboBox_ExtractTagsFromFNmane.Items.Add(pressets.RegExp);
				this.ComboBox_ExtractTagsFromFNmane.SelectedItem = pressets.RegExp;
			}
		}

		private void ButtonSuggest_Click(object sender, EventArgs e)
		{

		}

		


	}
}