using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using HundredMilesSoftware.UltraID3Lib;
namespace MP3TagRenamer
{
    public partial class MainForm : Form
    {
        private UserControlCompareDuplicates my_compare_duplicates;

        private System.Collections.Hashtable visited_dirs_paths ;
        private string active_path ;
 
        /// Save statistics
            System.Collections.Hashtable batch_counting_Artist;
            System.Collections.Hashtable batch_counting_Album ;
            System.Collections.Hashtable batch_counting_Ganre ;
            System.Collections.Hashtable batch_counting_Year ;

            
        public MainForm()
        {
            InitializeComponent();
            visited_dirs_paths = new System.Collections.Hashtable();
            my_folderSelector.ActualPathCahnged += new ActuelPathChangedHandler(FolderSelector_ActualPathCahnged);

            

        }

        void FolderSelector_ActualPathCahnged(object o, string path)
        {
            this.active_path = path;
            this.FillDataGrid();
        }

        private void FillDataGrid()
        {
            try
            {
                batch_counting_Artist = new System.Collections.Hashtable();
                batch_counting_Album = new System.Collections.Hashtable();
                batch_counting_Ganre = new System.Collections.Hashtable();
                batch_counting_Year = new System.Collections.Hashtable();

                if( System.IO.Directory.Exists( active_path ) )
                {                   
                    My_UltraID3BindingSource.Clear();

                    foreach( string mp3file in
                            Directory.GetFiles(
                               active_path,
                                "*.mp3",
                                SearchOption.AllDirectories ) )
                    {
                        try
                        {
                            UltraID3 uID3 = new UltraID3();
							if (uID3.Size == 0) continue;
                            uID3.Read( mp3file );
                            My_UltraID3BindingSource.Add( uID3 );

                            this.UpdateBestMatch( batch_counting_Album, uID3.Album );
                            this.UpdateBestMatch( batch_counting_Artist, uID3.Artist );
                            this.UpdateBestMatch( batch_counting_Ganre, uID3.Genre );
                            this.UpdateBestMatch( batch_counting_Year, uID3.Year.ToString());

                        } catch { }
                    }
                    
                    this.FillBachFields();

                }
            } catch { }
        }

        private void UpdateBestMatch(Hashtable batch_counting, string uID3_value )
        {
            try
            {
                /// Update statistics
                /// 
                if( batch_counting.ContainsKey( uID3_value ) )
                {
                    batch_counting[uID3_value] = ( (int)batch_counting[uID3_value] ) + 1;
                } else
                {
                    batch_counting.Add( uID3_value, 1 );
                }
            } catch { }
        }




        private void FillBachFields() {
            try
            {
                my_textBox_Album.Text = this.GetBestMatch( this.batch_counting_Album );
                my_textBox_Artist.Text = this.GetBestMatch( this.batch_counting_Artist );
                my_textBox_Year.Text = this.GetBestMatch( this.batch_counting_Year );
                my_comboBox_Ganre.Text = this.GetBestMatch( this.batch_counting_Ganre );
            } catch { }
        }


        private string GetBestMatch( Hashtable hash_table ) {
            int _temp = 0;
            string _best_match = "";
            try
            {
                foreach( string _key in hash_table.Keys )
                {
                    if( _key != "" && ( (int)hash_table[_key] ) > _temp )
                    {
                        _temp = (int)hash_table[_key];
                        _best_match = _key;
                    }
                }
            } catch { }

            return _best_match;
        }


        

        private void DataGridView_MP3s_RowEnter( object sender, DataGridViewCellEventArgs e )
        {            
            try
            {
                UltraID3 uid3 = (UltraID3)My_UltraID3BindingSource[e.RowIndex];
                string nl = Environment.NewLine;
                my_label_ID3V1.Text =
                    string.Format( @"Title:  {0}
Artist: {1}
Album:  {2} 
Ganre:  {3}
Year:   {4} ", 
             uid3.ID3v1Tag.Title, 
             uid3.ID3v1Tag.Artist,
             uid3.ID3v1Tag.Album,
             uid3.ID3v1Tag.GenreName,
             uid3.ID3v1Tag.Year);


                my_label_ID3V2.Text =
                    string.Format( @"Title:  {0}
Artist: {1}
Album:  {2} 
Ganre:  {3}
Year:   {4} ",
             uid3.ID3v2Tag.Title,
             uid3.ID3v2Tag.Artist,
             uid3.ID3v2Tag.Album,
             uid3.ID3v2Tag.Genre,
             uid3.ID3v2Tag.Year );
            } catch { }
        }

        private void Button_fixTitle_Click( object sender, EventArgs e )
        {
            if( my_textBox_fixTitle.Text.Length == 0 ) return;

            Regex _reg_exp = new Regex(my_textBox_fixTitle.Text);

            foreach( UltraID3 uid3 in My_UltraID3BindingSource )
            {
                try
                {     
                    uid3.Title = _reg_exp.Replace( uid3.Title , "");
                    
                    uid3.Write();
                } catch { }

            }
            my_dataGridView_MP3s.Refresh();
        }

        private void Button_removeText_Click( object sender, EventArgs e )
        {
            if(my_textBox_removeText.Text.Length == 0)return;

            foreach( UltraID3 uid3 in My_UltraID3BindingSource )
            {
                try
                {
                    uid3.Comments = uid3.Comments.Replace( my_textBox_removeText.Text, "" );
                    uid3.Title = uid3.Title.Replace( my_textBox_removeText.Text, "" );

                    uid3.Write();
                } catch { }

            }
            my_dataGridView_MP3s.Refresh();
        }

        /// <summary>
        /// Get Track number from input string. 
        /// It takes first string that contains 1 or 2 digits and raturns it.
        /// If nothing is found empty string is returnd
        /// </summary>
        /// <param name="titel_or_fname">Title or File name</param>
        /// <returns>returns first string that contains 1 or 2 digits.
        /// If nothing is found empty string is returnd</returns>
        private string GetTrackNr( string titel_or_fname )
        {

            string _val = "";

            System.Text.RegularExpressions.Regex rx
                       = new System.Text.RegularExpressions.Regex( @"\d{1,4}",
                       System.Text.RegularExpressions.RegexOptions.Singleline );

            MatchCollection _matchs = rx.Matches( titel_or_fname );

            if( _matchs.Count > 0 )
            {

                /// skip year


                if( _matchs.Count > 1 &&
                    _matchs[0].Value.Length > 2 &&
                    _matchs[1].Value.Length < 3 )
                {
                    _val = _matchs[1].Value;

                } else if( ( _matchs.Count == 1 ) ||
                    ( _matchs.Count > 1 &&
                    _matchs[0].Value.Length < 3 &&
                    _matchs[1].Value.Length > 2 ) )
                {
                    _val = _matchs[0].Value;
                }

            }

            return _val;
        }


        /// <summary>
        /// Set track number to all tracks in datagirdview by extracing it from 
        /// title or file name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_GetTrackNrFronTitle_Click( object sender, EventArgs e )
        {
            foreach( UltraID3 uid3 in My_UltraID3BindingSource )
            {

                /// TODO: Remove year first
                try
                {
                    short _track_nr = -1;

                    string _title_val = this.GetTrackNr( uid3.Title );
                    
                    if( _title_val == "" ) {
                        /// 
                        /// Didn't found it in title
                        /// try in file name
                        /// 
                        FileInfo fi = new FileInfo( uid3.FileName );
                        string _fname = fi.Name.Replace( ".mp3", "" ).Replace( ".MP3", "" );

                        _title_val = this.GetTrackNr( _fname );                    
                    }


                    if( _title_val != "" && short.TryParse( _title_val, out _track_nr ) )
                    {
                        if( _track_nr > -1 )
                        {
                            /// Write result to track
                            uid3.TrackNum = _track_nr;
                            uid3.ID3v1Tag.SetTrackNum( _title_val );
                            uid3.ID3v2Tag.SetTrackNum( _title_val );
                            uid3.Write();
                        }
                    }

                } catch { }
            }
            my_dataGridView_MP3s.Refresh();
        }

        /// <summary>
        /// Clear all comments in all tracks in datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_ClearComments_Click( object sender, EventArgs e )
        {
            foreach( UltraID3 uid3 in My_UltraID3BindingSource )
            {
                try
                {
                    uid3.Comments = "";
                    uid3.ID3v1Tag.Comments = "";
                    uid3.ID3v2Tag.Comments = "";                    
                    uid3.Write();
                } catch { }

            }
            my_dataGridView_MP3s.Refresh();
        }

        private void Button_UpdateBatch_Click( object sender, EventArgs e )
        {
            foreach( UltraID3 uid3 in My_UltraID3BindingSource )
            {
                try
                {
                    if( my_checkBox_Album.Checked )
                    {
                        uid3.Album = my_textBox_Album.Text;
                        uid3.ID3v1Tag.Album = my_textBox_Album.Text;
                        uid3.ID3v2Tag.Album = my_textBox_Album.Text;
                    }
                    if( my_checkBox_artist.Checked )
                    {
                        uid3.Artist = my_textBox_Artist.Text;
                        uid3.ID3v1Tag.Artist = my_textBox_Artist.Text;
                        uid3.ID3v2Tag.Artist = my_textBox_Artist.Text;
                    }
                    
                    if( my_checkBox_Ganre.Checked )
                    {
                        uid3.Genre = my_comboBox_Ganre.Text;
                        uid3.ID3v1Tag.SetGenre( my_comboBox_Ganre.Text);
                        uid3.ID3v2Tag.Genre = my_comboBox_Ganre.Text;
                    }

                    if( my_checkBox_Year.Checked )
                    {
                        short _year = -1;
                        if( short.TryParse( my_textBox_Year.Text,out _year ) )
                        {
                            uid3.Year = _year;
                            uid3.ID3v1Tag.Year = _year;
                            uid3.ID3v2Tag.Year = _year;
                        }
                    }
                    
                    uid3.Write();
                } catch { }

            }
            
            my_dataGridView_MP3s.Refresh();
        }


        private void About_Click( object sender, EventArgs e )
        {
            new FormAboutBox().ShowDialog(this);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                global::MP3TagRenamer.Properties.Settings.Default.LastUsedPath = my_folderSelector.ActualPath;
                if (global::MP3TagRenamer.Properties.Settings.Default.VisitedPaths == null)
                    global::MP3TagRenamer.Properties.Settings.Default.VisitedPaths = new System.Collections.Specialized.StringCollection();
                global::MP3TagRenamer.Properties.Settings.Default.VisitedPaths.AddRange(my_folderSelector.Paths);
                global::MP3TagRenamer.Properties.Settings.Default.Save();

            }
            catch 
            {
                
            }
        }



        


        private void DataGridView_MP3s_CellContentClick( object sender , DataGridViewCellEventArgs e )
        {
            try
            {
                string path = (string) my_dataGridView_MP3s.Rows[e.RowIndex].Cells[fileNameDataGridViewTextBoxColumn.Name].Value;
                TextBox_TestPath.Text = path;

                if ( my_dataGridView_MP3s.Columns[e.ColumnIndex] == this.my_play_datagridcolumn )
                {
                    //new MP3Player( path ).ShowDialog( this );
                    
                    Process mp3_player_process = new Process();
                    
                    mp3_player_process.StartInfo.FileName = "\"" + path + "\"";
                    mp3_player_process.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;
                    mp3_player_process.StartInfo.UseShellExecute = true;
                    mp3_player_process.Start();


                } else if ( my_dataGridView_MP3s.Columns[e.ColumnIndex] == this.fileNameDataGridViewTextBoxColumn )
                {
                    UltraID3 uid = new UltraID3();
                    uid.Read( path );
                    new MP3TagEditor.Mp3TagEditor( uid ).ShowDialog();
                }
            } catch { }

        }


        #region Extracing info from file name 


        /// <summary>
        /// Regex alias
        /// </summary>
        public const string RE_ARTIS = "#artist#";
        public const string RE_ALBUM = "#album#";
        public const string RE_YEAR = "#year#";
        public const string RE_TITLE = "#title#";
        public const string RE_TRACKNR = "#tracknr#";

        private void UpdateInfoFromFileName( UltraID3 uid3, string reg_expr ) {
            try
            {
                Regex _trackinfo_regexp = new Regex( reg_expr , RegexOptions.Singleline );
                Label_Regextpresult.Text = reg_expr + Environment.NewLine;
                string _t = ComboBox_ExtractTagsFromFNmane.Text;

                SortedList ht = new SortedList();
                if ( _t.IndexOf( RE_ARTIS ) != -1 ) ht.Add( _t.IndexOf( RE_ARTIS ) , RE_ARTIS );
                if ( _t.IndexOf( RE_TRACKNR ) != -1 ) ht.Add( _t.IndexOf( RE_TRACKNR ) , RE_TRACKNR );
                if ( _t.IndexOf( RE_ALBUM ) != -1 ) ht.Add( _t.IndexOf( RE_ALBUM ) , RE_ALBUM );
                if ( _t.IndexOf( RE_YEAR ) != -1 ) ht.Add( _t.IndexOf( RE_YEAR ) , RE_YEAR );
                if ( _t.IndexOf( RE_TITLE ) != -1 ) ht.Add( _t.IndexOf( RE_TITLE ) , RE_TITLE );



                foreach ( Match m in _trackinfo_regexp.Matches( uid3.FileName ) )
                {
                    IEnumerator en_ht = ht.Keys.GetEnumerator();

                    for ( int i = 1; i < m.Groups.Count; i++ )
                    {
                        en_ht.MoveNext();
                        int key = (int) en_ht.Current;
                        Group g = m.Groups[i];
                        try
                        {
                            switch ( ht[key].ToString() )
                            {
                                case RE_TITLE:
                                    uid3.Title = g.Value;
                                    uid3.ID3v1Tag.Title = g.Value;
                                    uid3.ID3v2Tag.Title = g.Value;
                                    break;

                                case RE_ARTIS:
                                    uid3.Artist = g.Value;
                                    uid3.ID3v1Tag.Artist = g.Value;
                                    uid3.ID3v2Tag.Artist = g.Value;
                                    break;

                                case RE_ALBUM:
                                    uid3.Album = g.Value;
                                    uid3.ID3v1Tag.Album = g.Value;
                                    uid3.ID3v2Tag.Album = g.Value;
                                    break;

                                case RE_TRACKNR:
                                    uid3.SetTrackNum( g.Value );
                                    uid3.ID3v1Tag.SetTrackNum( g.Value );
                                    uid3.ID3v2Tag.SetTrackNum( g.Value );
                                    break;

                                case RE_YEAR:
                                    uid3.SetYear( g.Value );
                                    uid3.ID3v1Tag.SetYear( g.Value );
                                    uid3.ID3v2Tag.SetYear( g.Value );
                                    break;

                            }
                        } catch { }
                        //Console.WriteLine(ht[key].ToString() + ":" + g.Value + Environment.NewLine);
                        //Label_Regextpresult.Text += ht[key].ToString() + ":" + g.Value + Environment.NewLine;

                    }
                }
                uid3.Write();
            } catch { }
        }

        /// <summary>
        /// Gets regular expretion that is used to extract info from file name
        /// </summary>
        /// <returns>Returns string - regular expretion that is used to extract info from file name</returns>
       private string GetRegExpFromInput() {
            string reg_exp= "";
            try
            {
                ///@"#artist# - #tracknr# - #album# - #year# - #title#"
                ///
                Label_Regextpresult.Text = "";

                string _t = ComboBox_ExtractTagsFromFNmane.Text;

                /// TODO: errorhandling if properties not set
                string _album_rgx = global::MP3TagRenamer.Properties.Settings.Default.regex_album;
                string _artist_rgx = global::MP3TagRenamer.Properties.Settings.Default.regex_artist;
                string _title_rgx = global::MP3TagRenamer.Properties.Settings.Default.regex_titel;
                string _tracknr_rgx = global::MP3TagRenamer.Properties.Settings.Default.regex_tracknr;
                string _year_rgx = global::MP3TagRenamer.Properties.Settings.Default.regex_year;

              

                /// TODO: upisi redosljed grupa u Match objektu 
                /// 
                string _t2 = _t;
                if ( _t.Contains( RE_ARTIS ) )
                {
                    _t2 = _t.Replace( RE_ARTIS , "(" + _artist_rgx + ")" );
                }
                if ( _t.Contains( RE_TRACKNR ) )
                {
                    _t2 = _t2.Replace( RE_TRACKNR , "(" + _tracknr_rgx + ")" );
                }
                if ( _t.Contains( RE_ALBUM ) )
                {
                    _t2 = _t2.Replace( RE_ALBUM , "(" + _album_rgx + ")" );
                }
                if ( _t.Contains( RE_TITLE ) )
                {
                    _t2 = _t2.Replace( RE_TITLE , "(" + _title_rgx + ")" );
                }
                if ( _t.Contains( RE_YEAR ) )
                {
                    _t2 = _t2.Replace( RE_YEAR , "(" + _year_rgx + ")" );
                }

                reg_exp = _t2;
            
            } catch { 
                return "";
            }
            return reg_exp;
        
        }

       private void Button_regexp_properties_Click( object sender , EventArgs e )
        {
            new MP3TagEditor.TrackInfoExtracingProperties().ShowDialog();
        }

        private void Button_ExtracFromFNameTEST_Click( object sender , EventArgs e )
        {
            try
            {
               if(my_dataGridView_MP3s.SelectedRows.Count == 0) return;

                this.TextBox_TestPath.Text = my_dataGridView_MP3s.SelectedRows[0].Cells[fileNameDataGridViewTextBoxColumn.Name].Value.ToString();
                this.TextBox_TestPath.SelectionStart = this.TextBox_TestPath.Text.Length;

                string _t2 = this.GetRegExpFromInput();
                Regex _trackinfo_regexp = new Regex( _t2 , RegexOptions.Singleline );
                Label_Regextpresult.Text = _t2 + Environment.NewLine;
                string _t = ComboBox_ExtractTagsFromFNmane.Text;

                SortedList ht = new SortedList();
                if ( _t.IndexOf( RE_ARTIS ) != -1 ) ht.Add( _t.IndexOf( RE_ARTIS ) , RE_ARTIS );
                if ( _t.IndexOf( RE_TRACKNR ) != -1 ) ht.Add( _t.IndexOf( RE_TRACKNR ) , RE_TRACKNR );
                if ( _t.IndexOf( RE_ALBUM ) != -1 ) ht.Add( _t.IndexOf( RE_ALBUM ) , RE_ALBUM );
                if ( _t.IndexOf( RE_YEAR ) != -1 ) ht.Add( _t.IndexOf( RE_YEAR ) , RE_YEAR );
                if ( _t.IndexOf( RE_TITLE ) != -1 ) ht.Add( _t.IndexOf( RE_TITLE ) , RE_TITLE );

               
                
                foreach ( Match m in _trackinfo_regexp.Matches( TextBox_TestPath.Text ) )
                {
                    // Label_Regextpresult.Text += m.Value + @"%" + m.Groups.Count + @"|";
                    IEnumerator en_ht = ht.Keys.GetEnumerator();

                    for ( int i = 1; i < m.Groups.Count; i++ )
                    {
                        en_ht.MoveNext();
                        int key =  (int)en_ht.Current;
                        Group g = m.Groups[i];
                        Label_Regextpresult.Text += ht[key].ToString() + ":" + g.Value + Environment.NewLine;
                       
                    }
                }


              

            } catch { }

        }


         
 
        private void Button_ExtractFRomFName_Click( object sender , EventArgs e )
        {
            string reg_expr = this.GetRegExpFromInput();

            foreach ( DataGridViewRow dr in my_dataGridView_MP3s.SelectedRows ) { 
                
                UltraID3 uid3 = (UltraID3) My_UltraID3BindingSource[ dr.Index];
                this.UpdateInfoFromFileName( uid3, reg_expr );
            }
            my_dataGridView_MP3s.Refresh();
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
            //this.toolStripContainer1.ContentPanel.Controls.Add(this.y_splitContainer_Main);

        }

        private void ToolStripMenuItem_RenamingClick(object sender, EventArgs e)
        {
            this.toolStripContainer1.ContentPanel.Controls.Clear();
            this.toolStripContainer1.ContentPanel.Controls.Add(this.y_splitContainer_Main);
            this.My_TabControl_BatchRen.SelectedTab = my_tabPage_Renaming;


        }
        private void BatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.toolStripContainer1.ContentPanel.Controls.Clear();
            this.toolStripContainer1.ContentPanel.Controls.Add(this.y_splitContainer_Main);
            this.My_TabControl_BatchRen.SelectedTab = My_TabPage_Batch;

        }
        #endregion ToolStripMenu Items Click Events

        
    }
}