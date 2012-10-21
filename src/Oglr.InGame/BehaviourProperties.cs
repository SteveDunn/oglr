using System;
using System.Diagnostics;

namespace Oglr.InGame
{
	[DebuggerDisplay( "Name={Name}" )]
	public class BehaviourProperties
	{
		/// <summary>
		/// The name of this item.
		/// </summary>
		public string Name
		{
			get ;
			set ;
		}
	}
}