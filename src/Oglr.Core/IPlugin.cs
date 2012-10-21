using System;

namespace Oglr.Core
{
	public interface IPlugin
	{
		string Name
		{
			get ;
		}

		string CategoryName
		{
			get ;
		}

		ImageProperties Icon
		{
			get;
		}

		IHandleDragDrop CreateDragDropHandler(IEntityCreationProperties entityCreationProperties);
	}
}