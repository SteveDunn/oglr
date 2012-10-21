using System;
using System.Collections.Generic;

namespace Oglr.Core
{
	public class ModelChangedEventArgs : EventArgs
	{
		public ModelChangedEventArgs( ITreeItem item )
		{
			ItemsAffected = new[ ]
				{
					item
				} ;
		}

		public ModelChangedEventArgs( IEnumerable<ITreeItem> items )
		{
			ItemsAffected = items ;
		}

		public IEnumerable<ITreeItem> ItemsAffected
		{
			get;
			set ;
		}
	}
}