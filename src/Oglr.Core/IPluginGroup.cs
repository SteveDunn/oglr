using System;

namespace Oglr.Core
{
	public interface IPluginGroup
	{
		void Initialise( ) ;
		
		string Name
		{
			get ;
		}
	}
}