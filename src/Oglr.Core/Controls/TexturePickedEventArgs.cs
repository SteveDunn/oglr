using System;

namespace Oglr.Core.Controls
{
	public class TexturePickedEventArgs : EventArgs
	{
		public string Path
		{
			get;
			private set ;
		}

		public TexturePickedEventArgs( string path )
		{
			Path = path ;
		}
	}
}