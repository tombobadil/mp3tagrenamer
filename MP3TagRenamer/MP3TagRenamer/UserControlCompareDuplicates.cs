using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO;
using HundredMilesSoftware.UltraID3Lib;
using System.Diagnostics;

namespace MP3TagRenamer
{
    public partial class UserControlCompareDuplicates : UserControl
    {



        public UserControlCompareDuplicates()
        {
            InitializeComponent();
            this.my_folderSelector.ActualPathCahnged += new ActuelPathChangedHandler(FolderSelector_ActualPathCahnged);
            this.my_dataSet.Relations.Add( new DataRelation( "Duplicate filse", my_fileinfo_dc_id, my_id3Info_dc_dupl_id));
        }

        private void FillDataGrid()
        {
            try
            {
                my_dataTable_ID3Info.Clear();
                my_dataTable_FileInfo.Clear();

                foreach( string _dir in this.my_checkedListBox_FolderList.CheckedItems )
                {
                    if( System.IO.Directory.Exists( _dir ) )
                    {
                        SearchOption _so = 
                            ( toolStripButtonIncluedeSubdirectories.Checked) 
                            ? SearchOption.AllDirectories 
                            : SearchOption.TopDirectoryOnly;

                        foreach( string mp3file in
                                Directory.GetFiles(
                                   _dir,
                                    "*.mp3",
                                    _so ) )
                        {
                            try
                            {
                                UltraID3 uID3 = new UltraID3();
                                uID3.Read( mp3file );
                                if( !this.FileExistsInFileInfoDS( uID3 ) )
                                {
                                    DataRow _dr = my_dataTable_FileInfo.NewRow();
                                    _dr[my_fileinfo_dc_name] = uID3.Title;
                                    _dr[my_fileinfo_dc_size] = uID3.Size;
                                    _dr[my_fileinfo_dc_duration] = uID3.Duration;

                                    my_dataTable_FileInfo.Rows.Add( _dr );
                                }

                                try
                                {
                                    int? _d_id;

                                    if( ! this.FileExistsInID3InfoDS( uID3 ) &&
                                        ( _d_id = this.GetDuplicateId( uID3 ) ) != null 
                                        )
                                    {
                                        DataRow _dr_mp3duplicate = my_dataTable_ID3Info.NewRow();
                                        _dr_mp3duplicate[my_id3Info_dc_artist] = uID3.Artist;
                                        _dr_mp3duplicate[my_id3Info_dc_delete] = false;
                                        _dr_mp3duplicate[my_id3Info_dc_dupl_id] = _d_id; // _dr[my_fileinfo_dc_id];
                                        _dr_mp3duplicate[my_id3Info_dc_duration] = uID3.Duration;
                                        _dr_mp3duplicate[my_id3Info_dc_path] = uID3.FileName;
                                        _dr_mp3duplicate[my_id3Info_dc_size] = uID3.Size;
                                        _dr_mp3duplicate[my_id3Info_dc_title] = uID3.Title;

                                        my_dataTable_ID3Info.Rows.Add( _dr_mp3duplicate );
                                    }
                                } catch { }



                            } catch { }
                        }

                    }
                }

                for( int a = my_dataTable_FileInfo.Rows.Count-1; a > -1 ; a-- )
                {
                    DataRow _dr = my_dataTable_FileInfo.Rows[a];
                    int i = (int)my_dataTable_ID3Info.Compute( "COUNT(" + my_id3Info_dc_dupl_id.ColumnName + ")", my_id3Info_dc_dupl_id.ColumnName + " = " + _dr[my_fileinfo_dc_id].ToString() );
                    if(i < 2){                    
                        my_dataTable_FileInfo.Rows[a].Delete();
                    }
                }
                my_dataTable_FileInfo.AcceptChanges();
                my_dataTable_ID3Info.AcceptChanges();
            } catch { }
            my_dataGridView.DataSource = my_dataSet;
            my_dataGridView.DataMember = my_dataTable_FileInfo.TableName;
            my_dataGridView.Refresh();
        }

        private bool FileExistsInFileInfoDS( UltraID3 uID3 )
        {
            foreach( DataRow _row in my_dataTable_FileInfo.Rows )
            {
                if( uID3.Title == _row[my_fileinfo_dc_name].ToString() ||
                    uID3.Duration.Equals( _row[my_fileinfo_dc_duration] ) ||
                    uID3.Size == (long)_row[my_fileinfo_dc_size]
                    )
                {
                    return true;
                }
            }
            return false;
        }

        private bool FileExistsInID3InfoDS( UltraID3 uID3 )
        {
            foreach( DataRow _row in my_dataTable_ID3Info.Rows )
            {
                if( uID3.FileName == _row[my_id3Info_dc_path].ToString() )
                {
                    return true;
                }
            }
            return false;
        }

        
        private int? GetDuplicateId( UltraID3 uID3 ) {
            foreach( DataRow _row in my_dataTable_FileInfo.Rows )
            {
                if ((uID3.Title != "" && uID3.Title == _row[my_fileinfo_dc_name].ToString()) ||
                    uID3.Duration.Equals( _row[my_fileinfo_dc_duration] ) ||
                    uID3.Size == (long)_row[my_fileinfo_dc_size]
                    )
                {
                    return (int)_row[my_fileinfo_dc_id];
                }
            }
            return null;
        }



        void FolderSelector_ActualPathCahnged(object o, string path)
        {			
            if (this.my_checkedListBox_FolderList.Items.Contains(path))
                return;

            this.my_checkedListBox_FolderList.Items.Add(path, true);
			this.toolStripButtonClearDirectories.Enabled = (this.my_checkedListBox_FolderList.Items.Count > 0);
        }

        private void Button_Clear_Click(object sender, EventArgs e)
        {
            this.my_checkedListBox_FolderList.Items.Clear();
			this.toolStripButtonClearDirectories.Enabled = false;
        }

        private void Button_Compare_Click(object sender, EventArgs e)
        {
            this.FillDataGrid();
        }

        private void DataGridView_Files_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (my_dataGridView.SelectedRows.Count == 0) return;
            try
            {
                string s = my_dataGridView.SelectedRows[0].Cells[this.idDataGridViewTextBoxColumn.Index].Value.ToString();
                DataView dv = new DataView( my_dataTable_ID3Info, my_id3Info_dc_dupl_id.ColumnName + " = " + s, "", DataViewRowState.Unchanged | DataViewRowState.ModifiedCurrent | DataViewRowState.Added );
                my_dataGridView_Duplicates.DataSource = dv;
            } catch { }
            
        }

        private void Play_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string _path;
            try
            {
                if ((_path = this.GetActiveFilePath()) == "") return;
                //new MP3Player(_path).ShowDialog(this);
                Process mp3_player_process = new Process();

                mp3_player_process.StartInfo.FileName = "\"" + _path + "\"";
                mp3_player_process.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;
                mp3_player_process.StartInfo.UseShellExecute = true;
                mp3_player_process.Start();

            }
            catch { }
        }

        private string GetActiveFilePath() {
            if (my_dataGridView_Duplicates.SelectedRows.Count > 0) {
               string path = (string)my_dataGridView_Duplicates.SelectedRows[0].Cells[this.pathDataGridViewTextBoxColumn.Name].Value;
               return path;
            }
            return "";
        }

        private void Delete_ToolStripMenuItem_Click( object sender, EventArgs e )
        {
            string cell = "";
            if( my_dataGridView_Duplicates.SelectedCells.Count > 0 )
            {
                cell = my_dataGridView_Duplicates.SelectedCells[0].Value.ToString();
                cell += " R:" + my_dataGridView_Duplicates.SelectedCells[0].RowIndex;
                cell += " C:" + my_dataGridView_Duplicates.SelectedCells[0].ColumnIndex;
            }
            Console.WriteLine("Delete " + cell);
            try
            {
                if( my_dataGridView_Duplicates.SelectedCells.Count > 0 )
                {
                   int _row_id  = my_dataGridView_Duplicates.SelectedCells[0].RowIndex;
                    my_dataGridView_Duplicates[deleteDataGridViewCheckBoxColumn.Name , _row_id].Value = true;
                    my_dataGridView_Duplicates.EndEdit();
                }
            } catch { }
                
        }

        private void ContextMenuStrip_Duplicates_Opening( object sender, CancelEventArgs e )
        {
            //if(!( sender is DataGridView)) e.Cancel = true;

            my_copyToolStripMenuItem.Enabled = (my_dataGridView_Duplicates.SelectedCells.Count == 1);
            my_pasteToolStripMenuItem.Enabled =  Clipboard.ContainsText() ;
            my_deleteToolStripMenuItem.Enabled = ( my_dataGridView_Duplicates.SelectedCells.Count == 1 ) || ( my_dataGridView_Duplicates.SelectedRows.Count == 1 ); 
            
            
        }

        private void Copy_ToolStripMenuItem_Click( object sender, EventArgs e )
        {
            
            try
            {
                if( my_dataGridView_Duplicates.SelectedCells.Count > 0 )
                {
                    Clipboard.SetText( my_dataGridView_Duplicates.SelectedCells[0].Value.ToString() );
                }
            } catch { }

        }


        private void Button_DeleteSelected_Click( object sender, EventArgs e )
        {
            FormDeleteFileList dfl_dialog = new FormDeleteFileList();
            dfl_dialog.FillList( my_dataTable_ID3Info , my_id3Info_dc_path, my_id3Info_dc_delete);
            dfl_dialog.ShowDialog(this);
        }

        private void DataGridView_Duplicates_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (my_dataGridView_Duplicates.Columns[e.ColumnIndex] != this.Play) return; 
            try
            {
                string path = (string)my_dataGridView_Duplicates.Rows[e.RowIndex].Cells[this.pathDataGridViewTextBoxColumn.Name].Value;
           
                //new MP3Player(path).ShowDialog(this);
                Process mp3_player_process = new Process();

                mp3_player_process.StartInfo.FileName = "\"" + path + "\"";
                mp3_player_process.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;
                mp3_player_process.StartInfo.UseShellExecute = true;
                mp3_player_process.Start();
            }
            catch { }
        }

		
		private void ButtonShowHideDirectoryList_Click(object sender, EventArgs e)
		{
			my_splitContainer.Panel1Collapsed = !my_splitContainer.Panel1Collapsed;

			try
			{
				toolStripButtonShowHideDirectoryList.Text = (my_splitContainer.Panel1Collapsed) ? "Show directory list" : "Hide directory list";
				toolStripButtonShowHideDirectoryList.Text = (my_splitContainer.Panel1Collapsed) ? ResourceTexts.ShowDirectryList : ResourceTexts.HideDirectoryList;
			}
			catch { }
		}

 
       

    }
}
