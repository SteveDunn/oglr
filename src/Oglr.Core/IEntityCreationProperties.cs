using System;

namespace Oglr.Core
{
	public interface IEntityCreationProperties
	{
		UiAction TriggeredBy { get; }
		Type PluginType { get; }
	}
}