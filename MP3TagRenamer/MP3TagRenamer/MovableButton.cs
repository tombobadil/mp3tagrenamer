using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MP3TagRenamer
{
	/// <summary>
	/// This button suport Drag and Drop functionality.
	/// </summary>
	public partial class MovableButton : Button
	{
		private bool StartDragAndDrop;
		public MovableButton()
		{
			InitializeComponent();
		}
		public MovableButton(IContainer container)
		{
			container.Add(this);
			InitializeComponent();
		}

		void MovableButton_MouseDown(object sender, MouseEventArgs e)
		{
			StartDragAndDrop = true;
		}

		void MovableButton_MouseMove(object sender, MouseEventArgs e)
		{
			if (StartDragAndDrop)
			{
				this.DoDragDrop(this, DragDropEffects.All);
			}
		}


		void MovableButton_MouseUp(object sender, MouseEventArgs e)
		{
			StartDragAndDrop = false;
		}


	}
}
