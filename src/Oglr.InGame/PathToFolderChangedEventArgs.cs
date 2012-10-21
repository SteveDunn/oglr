using System;

namespace Oglr.InGame
{
	public class PathToFolderChangedEventArgs : EventArgs
	{
		public string ChosenFolder
		{
			get ;
			set ;
		}

		public bool Cancel
		{
			get;
			set ;
		}
	}
}