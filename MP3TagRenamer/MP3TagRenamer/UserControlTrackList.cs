using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HundredMilesSoftware.UltraID3Lib;
using System.Collections;
using System.Text.RegularExpressions;
using System.IO;
using System.Diagnostics;

namespace MP3TagRenamer
{
	public partial class UserControlTrackList : UserControl
	{
		public delegate void BatchFieldsInfoHandler(object sender, BatchFieldsInfo bachFieldsInfo);
		public event BatchFieldsInfoHandler BatchFieldsUpdated;
		public event EventHandler TrackListRowEnter;

		public UserControlTrackList()
		{
			InitializeComponent();
			m_DataGridViewTrackList.DataError += new DataGridViewDataErrorEventHandler(DataGridViewTrackList_DataError);
			m_VisitedDirsPaths = new System.Collections.Hashtable();
			m_UserControlFolderSelector.ActualPathCahnged += new ActuelPathChangedHandler(FolderSelector_ActualPathCahnged);
		}


		public string ID3V1Text { get; set; }
		public string ID3V2Text { get; set; }
		public string SelectedTracksPath { get; set; }
        
        public string ActualPath
        {
            get
            {
                if (m_UserControlFolderSelector == null) return "";
                return m_UserControlFolderSelector.ActualPath;
            }
        }

        public string[] VisitedPaths
        {
            get
            {
                if (m_UserControlFolderSelector == null) return new string[] { "" };
                return m_UserControlFolderSelector.Paths;
            }
        }


		public void FixTitle(string title)
		{
			if (title.Length == 0) return;

			Regex _reg_exp = new Regex(title);

			foreach (UltraID3 uid3 in m_BindingSourceUltraID3)
			{
				try
				{
					uid3.Title = _reg_exp.Replace(uid3.Title, "");

					uid3.Write();
				}
				catch { }

			}
			m_DataGridViewTrackList.Refresh();
		}

		public void RemoveText(string text)
		{
			if (text.Length == 0) return;

			foreach (UltraID3 uid3 in m_BindingSourceUltraID3)
			{
				try
				{
					uid3.Comments = uid3.Comments.Replace(text, "");
					uid3.Title = uid3.Title.Replace(text, "");

					uid3.Write();
				}
				catch { }

			}
			m_DataGridViewTrackList.Refresh();
		}


		/// <summary>
		/// Set track number to all tracks in datagirdview by extracing it from 
		/// title or file name
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		public void GetTrackNrFronTitle()
		{
			foreach (UltraID3 uid3 in m_BindingSourceUltraID3)
			{

				/// TODO: Remove year first
				try
				{
					short _track_nr = -1;

					string _title_val = this.GetTrackNr(uid3.Title);

					if (_title_val == "")
					{
						/// 
						/// Didn't found it in title
						/// try in file name
						/// 
						FileInfo fi = new FileInfo(uid3.FileName);
						string _fname = fi.Name.Replace(".mp3", "").Replace(".MP3", "");

						_title_val = this.GetTrackNr(_fname);
					}


					if (_title_val != "" && short.TryParse(_title_val, out _track_nr))
					{
						if (_track_nr > -1)
						{
							/// Write result to track
							uid3.TrackNum = _track_nr;
							uid3.ID3v1Tag.SetTrackNum(_title_val);
							uid3.ID3v2Tag.SetTrackNum(_title_val);
							uid3.Write();
						}
					}

				}
				catch { }
			}
			m_DataGridViewTrackList.Refresh();
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
		public delegate void EmptyMethodCaller();

		/// <summary>
		/// Clear all comments in all tracks in datagridview
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		public void ClearComments()
		{
			EmptyMethodCaller asyncMethod = new EmptyMethodCaller(ClearCommentsAsync);
			asyncMethod.BeginInvoke(new AsyncCallback(RefreshDataGrid), asyncMethod);
		}
		/// <summary>
		/// Clear all comments in all tracks in datagridview
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ClearCommentsAsync()
		{
            lock(m_BindingSourceUltraID3.SyncRoot)
            {
				foreach (UltraID3 uid3 in m_BindingSourceUltraID3)
				{
					try
					{
						uid3.Comments = "";
						uid3.ID3v1Tag.Comments = "";
						uid3.ID3v2Tag.Comments = "";
						uid3.Write();
					}
					catch { }
				}
			}
		}

		private void RefreshDataGrid(IAsyncResult ar)
		{
			EmptyMethodCaller emptyMethodCaller = (EmptyMethodCaller)ar.AsyncState;
			emptyMethodCaller.EndInvoke(ar);
			SafeRefreshDataGrid();
		}

		private void SafeRefreshDataGrid()
		{
			if (m_DataGridViewTrackList.InvokeRequired)
			{				
				this.Invoke(new EmptyMethodCaller(SafeRefreshDataGrid));
			}
			else
			{
				m_DataGridViewTrackList.Refresh();
			}
		}

		public void UpdateAllTracks(UserControlBatchRenameFields renameFields)
		{
			bool udateAlbum = renameFields.UpdateAlbum;
			string albumText = renameFields.Album;

			bool updateArtist = renameFields.UpdateArtist;
			string artistText = renameFields.Artist;

			bool updateGanre = renameFields.UpdateGanre;
			string ganreText = renameFields.Ganre;

			bool upateYear = renameFields.UpdateYear;
			short? year = renameFields.Year;

			foreach (UltraID3 uid3 in m_BindingSourceUltraID3)
			{
				try
				{
					if (udateAlbum)
					{
						uid3.Album = albumText;
						uid3.ID3v1Tag.Album = albumText;
						uid3.ID3v2Tag.Album = albumText;
					}
					if (updateArtist)
					{
						uid3.Artist = artistText;
						uid3.ID3v1Tag.Artist = artistText;
						uid3.ID3v2Tag.Artist = artistText;
					}

					if (updateGanre)
					{
						 try
                        {
                             uid3.Genre = ganreText;
                        }catch { }
                        try
                        {
                            uid3.ID3v1Tag.SetGenre(ganreText);
                        }catch{}
						 try
                        {
                             uid3.ID3v2Tag.Genre = ganreText;
                        }
                         catch { }
					}

					if (upateYear)
					{
						uid3.Year = year;
						uid3.ID3v1Tag.Year = year;
						uid3.ID3v2Tag.Year = year;
					}

					uid3.Write();
				}
				catch { }

			}

			m_DataGridViewTrackList.Refresh();
		}



		void FolderSelector_ActualPathCahnged(object o, string path)
		{
			this.m_ActivePath = path;
			this.FillDataGrid();
		}


		private void FillDataGrid()
		{
			EmptyMethodCaller asyncMethod = new EmptyMethodCaller(FillDataGridAsync);
			asyncMethod.BeginInvoke(new AsyncCallback(RefreshDataGrid), asyncMethod);
		}
	

		private void FillDataGridAsync()
		{
			if (m_DataGridViewTrackList.InvokeRequired)
			{
				this.Invoke(new EmptyMethodCaller(FillDataGridAsync));
				return;
			}
			
			try
			{
				batchCounting_Artist = new System.Collections.Hashtable();
				batchCounting_Album = new System.Collections.Hashtable();
				batchCounting_Ganre = new System.Collections.Hashtable();
				batchCounting_Year = new System.Collections.Hashtable();

				if (System.IO.Directory.Exists(m_ActivePath))
				{
					lock (m_BindingSourceUltraID3.SyncRoot)
					{


						m_BindingSourceUltraID3.Clear();

						foreach (string mp3file in
								Directory.GetFiles(
								   m_ActivePath,
									"*.mp3",
									SearchOption.AllDirectories))
						{
							try
							{
								UltraID3 uID3 = new UltraID3();
								if (uID3.Size == 0) continue;
								uID3.Read(mp3file);
								m_BindingSourceUltraID3.Add(uID3);

								this.UpdateBestMatch(batchCounting_Album, uID3.Album);
								this.UpdateBestMatch(batchCounting_Artist, uID3.Artist);
								this.UpdateBestMatch(batchCounting_Ganre, uID3.Genre);
								this.UpdateBestMatch(batchCounting_Year, uID3.Year.ToString());

							}
							catch { }
						}

						this.FillBachFields();
					}
				}
			}
			catch { }
		}
		private void UpdateBestMatch(Hashtable batch_counting, string uID3_value)
		{
			try
			{
				/// Update statistics
				/// 
				if (batch_counting.ContainsKey(uID3_value))
				{
					batch_counting[uID3_value] = ((int)batch_counting[uID3_value]) + 1;
				}
				else
				{
					batch_counting.Add(uID3_value, 1);
				}
			}
			catch { }
		}

		private void FillBachFields()
		{
			if (BatchFieldsUpdated != null)
			{
				BatchFieldsInfo info = new BatchFieldsInfo();
				try
				{
					info.Album = this.GetBestMatch(this.batchCounting_Album);
					info.Artist = this.GetBestMatch(this.batchCounting_Artist);
					info.Year = this.GetBestMatch(this.batchCounting_Year);
					info.Ganre = this.GetBestMatch(this.batchCounting_Ganre);
				}
				catch { }
				BatchFieldsUpdated(this, info);
			}
		}


		private string GetBestMatch(Hashtable hash_table)
		{
			int _temp = 0;
			string _best_match = "";
			try
			{
				foreach (string _key in hash_table.Keys)
				{
					if (_key != "" && ((int)hash_table[_key]) > _temp)
					{
						_temp = (int)hash_table[_key];
						_best_match = _key;
					}
				}
			}
			catch { }

			return _best_match;
		}

		private void DataGridView_MP3s_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				UltraID3 uid3 = (UltraID3)m_BindingSourceUltraID3[e.RowIndex];
				string nl = Environment.NewLine;
				ID3V1Text =
					string.Format(@"Title:  {0}
Artist: {1}
Album:  {2} 
Ganre:  {3}
Year:   {4} ",
			 uid3.ID3v1Tag.Title,
			 uid3.ID3v1Tag.Artist,
			 uid3.ID3v1Tag.Album,
			 uid3.ID3v1Tag.GenreName,
			 uid3.ID3v1Tag.Year);


				ID3V2Text =
					string.Format(@"Title:  {0}
Artist: {1}
Album:  {2} 
Ganre:  {3}
Year:   {4} ",
			 uid3.ID3v2Tag.Title,
			 uid3.ID3v2Tag.Artist,
			 uid3.ID3v2Tag.Album,
			 uid3.ID3v2Tag.Genre,
			 uid3.ID3v2Tag.Year);


				string path = (string)m_DataGridViewTrackList.Rows[e.RowIndex].Cells[dataGridViewTextBoxColumn10.Name].Value;

				SelectedTracksPath = path;
				OnTrackListRowEnter();
			}
			catch { }
		}


		private void DataGridView_MP3s_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				//string path = (string)m_DataGridViewTrackList.Rows[e.RowIndex].Cells[dataGridViewTextBoxColumn10.Name].Value;
				
				//SelectedTracksPath = path;
				//OnTrackListRowEnter();

				if (m_DataGridViewTrackList.Columns[e.ColumnIndex] == this.dataGridViewImageColumn1)
				{

					Process mp3_player_process = new Process();

					mp3_player_process.StartInfo.FileName = "\"" + SelectedTracksPath + "\"";
					mp3_player_process.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;
					mp3_player_process.StartInfo.UseShellExecute = true;
					mp3_player_process.Start();


				}
				else if (m_DataGridViewTrackList.Columns[e.ColumnIndex] == this.dataGridViewTextBoxColumn10)
				{
					UltraID3 uid = new UltraID3();
					uid.Read(SelectedTracksPath);
					new MP3TagEditor.Mp3TagEditor(uid).ShowDialog();
				}
			}
			catch { }

		}

		private void OnTrackListRowEnter()
		{
			if (TrackListRowEnter != null)
			{
				TrackListRowEnter(this, EventArgs.Empty);
			}
		}


		public void ExtractFRomFName(string userRegExpString)
		{
			string reg_expr = GetRegExpFromInput( userRegExpString);

			foreach (DataGridViewRow dr in m_DataGridViewTrackList.SelectedRows)
			{

				UltraID3 uid3 = (UltraID3)m_BindingSourceUltraID3[dr.Index];
				this.UpdateInfoFromFileName(uid3, reg_expr, userRegExpString);
			}
			m_DataGridViewTrackList.Refresh();
		}


		/// <summary>
		/// Regex alias
		/// </summary>
		public const string RE_ARTIS = "#artist#";
		public const string RE_ALBUM = "#album#";
		public const string RE_YEAR = "#year#";
		public const string RE_TITLE = "#title#";
		public const string RE_TRACKNR = "#tracknr#";

		private void UpdateInfoFromFileName(UltraID3 uid3, string reg_expr, string userRegExpString)
		{
			try
			{
				Regex _trackinfo_regexp = new Regex(reg_expr, RegexOptions.Singleline);				
				///TODO: string _t = ComboBox_ExtractTagsFromFNmane.Text;

				SortedList ht = new SortedList();
				if (userRegExpString.IndexOf(RE_ARTIS) != -1) ht.Add(userRegExpString.IndexOf(RE_ARTIS), RE_ARTIS);
				if (userRegExpString.IndexOf(RE_TRACKNR) != -1) ht.Add(userRegExpString.IndexOf(RE_TRACKNR), RE_TRACKNR);
				if (userRegExpString.IndexOf(RE_ALBUM) != -1) ht.Add(userRegExpString.IndexOf(RE_ALBUM), RE_ALBUM);
				if (userRegExpString.IndexOf(RE_YEAR) != -1) ht.Add(userRegExpString.IndexOf(RE_YEAR), RE_YEAR);
				if (userRegExpString.IndexOf(RE_TITLE) != -1) ht.Add(userRegExpString.IndexOf(RE_TITLE), RE_TITLE);



				foreach (Match m in _trackinfo_regexp.Matches(uid3.FileName))
				{
					IEnumerator en_ht = ht.Keys.GetEnumerator();

					for (int i = 1; i < m.Groups.Count; i++)
					{
						en_ht.MoveNext();
						int key = (int)en_ht.Current;
						Group g = m.Groups[i];
						try
						{
							switch (ht[key].ToString())
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
									uid3.SetTrackNum(g.Value);
									uid3.ID3v1Tag.SetTrackNum(g.Value);
									uid3.ID3v2Tag.SetTrackNum(g.Value);
									break;

								case RE_YEAR:
									uid3.SetYear(g.Value);
									uid3.ID3v1Tag.SetYear(g.Value);
									uid3.ID3v2Tag.SetYear(g.Value);
									break;

							}
						}
						catch { }

					}
				}
				uid3.Write();
			}
			catch { }
		}

		/// <summary>
		/// Gets regular expretion that is used to extract info from file name
		/// </summary>
		/// <returns>Returns string - regular expretion that is used to extract info from file name</returns>
		public static string GetRegExpFromInput(string userRegExpString)
		{
			string reg_exp = "";
			try
			{
				///@"#artist# - #tracknr# - #album# - #year# - #title#"
				///
				///TODO: Label_Regextpresult.Text = "";

				///TODO: string _t = ComboBox_ExtractTagsFromFNmane.Text;

				/// TODO: errorhandling if properties not set
				string _album_rgx = global::MP3TagRenamer.Properties.Settings.Default.regex_album;
				string _artist_rgx = global::MP3TagRenamer.Properties.Settings.Default.regex_artist;
				string _title_rgx = global::MP3TagRenamer.Properties.Settings.Default.regex_titel;
				string _tracknr_rgx = global::MP3TagRenamer.Properties.Settings.Default.regex_tracknr;
				string _year_rgx = global::MP3TagRenamer.Properties.Settings.Default.regex_year;



				/// TODO: upisi redosljed grupa u Match objektu 
				/// 
				string _t2 = userRegExpString;
				if (userRegExpString.Contains(RE_ARTIS))
				{
					_t2 = userRegExpString.Replace(RE_ARTIS, "(" + _artist_rgx + ")");
				}
				if (userRegExpString.Contains(RE_TRACKNR))
				{
					_t2 = _t2.Replace(RE_TRACKNR, "(" + _tracknr_rgx + ")");
				}
				if (userRegExpString.Contains(RE_ALBUM))
				{
					_t2 = _t2.Replace(RE_ALBUM, "(" + _album_rgx + ")");
				}
				if (userRegExpString.Contains(RE_TITLE))
				{
					_t2 = _t2.Replace(RE_TITLE, "(" + _title_rgx + ")");
				}
				if (userRegExpString.Contains(RE_YEAR))
				{
					_t2 = _t2.Replace(RE_YEAR, "(" + _year_rgx + ")");
				}

				reg_exp = _t2;

			}
			catch
			{
				return "";
			}
			return reg_exp;

		}

		public static string ExtracFromFName_TEST(string userRegExpString, string selectedTracksPath)
		{
			string resultString = "";
			try
			{
				//if (m_DataGridViewTrackList.SelectedRows.Count == 0) return "";

				//SelectedTracksPath = m_DataGridViewTrackList.SelectedRows[0].Cells[dataGridViewTextBoxColumn10.Name].Value.ToString();
				//OnTrackListRowEnter();

				string _t2 = GetRegExpFromInput(userRegExpString);
				Regex _trackinfo_regexp = new Regex(_t2, RegexOptions.Singleline);
				//resultString = _t2 + Environment.NewLine;				

				SortedList ht = new SortedList();
				if (userRegExpString.IndexOf(RE_ARTIS) != -1) ht.Add(userRegExpString.IndexOf(RE_ARTIS), RE_ARTIS);
				if (userRegExpString.IndexOf(RE_TRACKNR) != -1) ht.Add(userRegExpString.IndexOf(RE_TRACKNR), RE_TRACKNR);
				if (userRegExpString.IndexOf(RE_ALBUM) != -1) ht.Add(userRegExpString.IndexOf(RE_ALBUM), RE_ALBUM);
				if (userRegExpString.IndexOf(RE_YEAR) != -1) ht.Add(userRegExpString.IndexOf(RE_YEAR), RE_YEAR);
				if (userRegExpString.IndexOf(RE_TITLE) != -1) ht.Add(userRegExpString.IndexOf(RE_TITLE), RE_TITLE);



				foreach (Match m in _trackinfo_regexp.Matches(selectedTracksPath))
				{
					// Label_Regextpresult.Text += m.Value + @"%" + m.Groups.Count + @"|";
					IEnumerator en_ht = ht.Keys.GetEnumerator();

					for (int i = 1; i < m.Groups.Count; i++)
					{
						en_ht.MoveNext();
						int key = (int)en_ht.Current;
						Group g = m.Groups[i];
						resultString += string.Format("{0,-10} : {1}{2}" ,  ht[key] , g.Value , Environment.NewLine);
					}
				}
			}
			catch { }
			return resultString;
		}

		private void BindingSourceUltraID3_DataError(object sender, BindingManagerDataErrorEventArgs e)
		{

		}
		void DataGridViewTrackList_DataError(object sender, DataGridViewDataErrorEventArgs e)
		{

		}

		private void buttonLoad_Click(object sender, EventArgs e)
		{
			m_ActivePath = m_UserControlFolderSelector.ActualPath;
			FillDataGrid();
		}


 

	}
}
