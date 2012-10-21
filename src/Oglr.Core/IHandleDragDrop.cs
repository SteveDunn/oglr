using System;
using System.Windows.Forms;
using Oglr.Core.Controls;

namespace Oglr.Core
{
	public interface IHandleDragDrop
	{
		void WhenDroppedOntoEditor(ICanvas canvas, DraggingContext context);
		void WhenBeingDraggedOverEditor(ICanvas canvas, DraggingContext draggingContext);
		void WhenEnteringEditor( ICanvas canvas, DraggingContext context) ;
		void WhenLeavingEditor( ICanvas canvas, DraggingContext draggingContext ) ;

		DragDropEffects DragDropEffects
		{
			get ;
		}
	}
}