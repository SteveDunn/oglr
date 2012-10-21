using System;

namespace Oglr.Core
{
	public class DraggingTextureEventArgs : EventArgs
	{
		public DragEventType DragEventType
		{
			get ;
			set ;
		}
		
		public string PathToTexture
		{
			get ;
			set ;
		}
	}
}