using System;
using System.Windows.Forms;

namespace Oglr.Core.Controls
{
	public class DraggingContext
	{
		readonly DragEventArgs _dragEventArgs;

		public DraggingContext(DragEventArgs dragEventArgs)
		{
			_dragEventArgs = dragEventArgs;
		}

		public DragEventArgs DragEventArgs
		{
			get { return _dragEventArgs; }
		}
	}
}