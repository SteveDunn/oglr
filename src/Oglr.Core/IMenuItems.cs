using System;
using System.Windows.Forms;

namespace Oglr.Core
{
	public interface IMenuItems
	{
		ToolStripMenuItem HelpMenu
		{
			get ;
		}

		ToolStripItem TryGetByName( string name ) ;

		void InsertItemBefore( ToolStripMenuItem menuItem, ToolStripItem thingOnRight ) ;
	}
}