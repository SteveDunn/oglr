using System;
using System.ComponentModel.Composition;
using Oglr.Core;

namespace Oglr.Plugins
{
	[Export( typeof( IPluginGroup ) )]
	public class PrimitivesPluginGroup : IPluginGroup
	{
		public void Initialise( )
		{
			// add any initialisation here, e.g. adding menu items etc.
		}

		public string Name
		{
			get
			{
				return @"Primitive plugins" ;
			}
		}
	}
}