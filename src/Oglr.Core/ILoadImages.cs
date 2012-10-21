using System;
using System.Drawing;
using System.Reflection;

namespace Oglr.Core
{
	public interface ILoadImages
	{
		Image LoadFromResource( Assembly assembly, string resourceName ) ;
	}
}