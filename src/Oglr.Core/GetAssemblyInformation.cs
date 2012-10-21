using System;
using System.Reflection;

namespace Oglr.Core
{
	public class GetAssemblyInformation : IGetAssemblyInformation
	{
		public string Version
		{
			get
			{
				return Assembly.GetEntryAssembly( ).GetName( ).Version.ToString( ) ;
			}
		}
	}
}