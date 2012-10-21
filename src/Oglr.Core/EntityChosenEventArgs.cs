using System;

namespace Oglr.Core
{
	public class EntityChosenEventArgs : EventArgs
	{
		public IEntityCreationProperties EntityCreationProperties
		{
			get ;
			set ;
		}
	}
}