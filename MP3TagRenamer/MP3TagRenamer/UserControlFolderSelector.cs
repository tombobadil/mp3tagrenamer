using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MP3TagRenamer
{
    public delegate void ActuelPathChangedHandler(object obj, string path);

	public partial class UserControlFolderSelector : UserControl
	{
		private System.Collections.Hashtable visited_dirs_paths;

		public event ActuelPathChangedHandler ActualPathCahnged;

		public UserControlFolderSelector()
		{
			InitializeComponent();
			visited_dirs_paths = new System.Collections.Hashtable();
			activPath = "";

			/// 
			/// Load user preferencies
			/// 
			try
			{
				if (global::MP3TagRenamer.Properties.Settings.Default.LastUsedPath != ""
					&& new DirectoryInfo(global::MP3TagRenamer.Properties.Settings.Default.LastUsedPath).Exists)
				{
					this.ActualPath = global::MP3TagRenamer.Properties.Settings.Default.LastUsedPath;
				}

				if (global::MP3TagRenamer.Properties.Settings.Default.VisitedPaths.Count > 0)
				{
					int i = 0;
					string[] _paths = new string[global::MP3TagRenamer.Properties.Settings.Default.VisitedPaths.Count];
					foreach (string _path in global::MP3TagRenamer.Properties.Settings.Default.VisitedPaths)
					{
						_paths[i++] = _path;
					}
					this.Paths = _paths;
				}
			}
			catch { }
		}


		protected void OnActualPathCahnged(string path)
		{
			if (ActualPathCahnged != null)
			{
				ActualPathCahnged(this, path);
			}
		}


		private void ComboBox_Folder_DropDownClosed(object sender, EventArgs e)
		{
			if (my_comboBox_Folder.SelectedIndex > -1
			  && my_comboBox_Folder.SelectedItem.ToString() != activPath)
			{
				ActualPath = my_comboBox_Folder.SelectedItem.ToString();
			}

		}

		private void ComboBox_Folder_TextChanged(object sender, EventArgs e)
		{
			if (System.IO.Directory.Exists(my_comboBox_Folder.Text))
			{


			}
			else
			{


				if (my_comboBox_Folder.Text.LastIndexOf("\\") > 0 &&
					System.IO.Directory.Exists(my_comboBox_Folder.Text.Substring(0, my_comboBox_Folder.Text.LastIndexOf("\\"))))
				{

					string _path = my_comboBox_Folder.Text.Substring(0, my_comboBox_Folder.Text.LastIndexOf("\\"));
					string _written_str = my_comboBox_Folder.Text.Substring(_path.Length);

					/// Remeber selection
					int _sel_start = my_comboBox_Folder.SelectionStart;
					int _sel_len = my_comboBox_Folder.SelectionLength;

					my_comboBox_Folder.Items.Clear();
					my_comboBox_Folder.Items.Add(_path);
					foreach (string _sub_path in Directory.GetDirectories(_path))
					{
						if (_sub_path.Contains(_path + _written_str))
						{
							my_comboBox_Folder.Items.Add(_sub_path);
						}
					}
					my_comboBox_Folder.DroppedDown = true;

					my_comboBox_Folder.SelectionStart = _sel_start;
					my_comboBox_Folder.SelectionLength = _sel_len;
				}

			}
		}

		private void Button_Browse_Click(object sender, EventArgs e)
		{
			if (activPath != null
				&& activPath != ""
				&& new DirectoryInfo(activPath).Exists)
			{
				my_folderBrowserDialog.SelectedPath = activPath;
			}

			if (my_folderBrowserDialog.ShowDialog() == DialogResult.OK)
			{
				my_comboBox_Folder.Text = my_folderBrowserDialog.SelectedPath;
				if (activPath != my_folderBrowserDialog.SelectedPath)
				{
					ActualPath = my_folderBrowserDialog.SelectedPath;
					//this.OnActualPathCahnged(_activ_path);
				}
			}


		}


		private string activPath;

		/// <summary>
		/// Gets or Sets activ path
		/// </summary>
		public string ActualPath
		{
			get { return activPath; }
			set
			{
				try
				{
					if (!Directory.Exists(value)) return;

					activPath = value;
					if (activPath != null
						&& !my_comboBox_Folder.Items.Contains(activPath))
					{
						my_comboBox_Folder.Items.Add(activPath);
					}

					my_comboBox_Folder.SelectedItem = activPath;

					if (activPath != null && !visited_dirs_paths.Contains(activPath))
					{
						visited_dirs_paths.Add(activPath, activPath);
					}

					this.OnActualPathCahnged(activPath);
				}
				catch { }
			}
		}
		
		public bool ActualPathExists
		{
			get 
			{
				return Directory.Exists(ActualPath);
			}
		}

		/// <summary>
		/// Gets list with all used paths in history
		/// </summary>
		public string[] Paths
		{
			get
			{
				try
				{
					if (activPath != null && !visited_dirs_paths.ContainsKey(activPath))
					{
						visited_dirs_paths.Add(activPath, activPath);
					}

					int c = 0;
					string[] _paths = new string[visited_dirs_paths.Count];
					foreach (string _path in visited_dirs_paths.Keys)
					{
						_paths[c++] = _path;
					}
					return _paths;
				}
				catch
				{
					return null;
				}
			}

			set
			{
				try
				{
					string[] _paths = value;
					my_comboBox_Folder.Items.Clear();
					if (_paths == null) return;

					my_comboBox_Folder.Items.AddRange(_paths);

					visited_dirs_paths = new System.Collections.Hashtable();

					for (int i = 0; i < Math.Min(20, _paths.Length); i++)
					{
						if (visited_dirs_paths.ContainsKey(activPath) == false)
						{
							visited_dirs_paths.Add(activPath, activPath);
						}
					}
				}
				catch { }
			}

		}

		private void ComboBoxFolder_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (my_comboBox_Folder.SelectedIndex > -1
			 && my_comboBox_Folder.SelectedItem.ToString() != activPath)
			{
				//ActualPath = my_comboBox_Folder.SelectedItem.ToString();
			}
		}

		private void ComboBoxFolder_KeyDown(object sender, KeyEventArgs e)
		{
			if ((e.KeyCode == Keys.Return) || (e.KeyCode == Keys.Enter))
			{
				ActualPath = my_comboBox_Folder.Text;
				if (ActualPathExists) {
					OnActualPathCahnged(ActualPath);
				}
			}
		}

	}
}
