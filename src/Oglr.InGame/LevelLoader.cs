using System;
using System.Xml.Linq;

namespace Oglr.InGame
{
	/// <summary>
	/// A utility class to load levels from within the game.
	/// </summary>
// ReSharper disable UnusedMember.Global
	public static class LevelLoader
	{
		public static Level Load(XElement xml)
		{
			TypeLookup.Rehydrate( xml );
			return new Level( xml ) ;
		}
	}
// ReSharper restore UnusedMember.Global
}
