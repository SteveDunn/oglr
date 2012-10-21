using System;
using System.IO;

namespace Oglr.Core
{
	public class PathToFile
	{
		public string AbsolutePath
		{
			get ;
			set ;
		}

		public bool Exists
		{
			get
			{
				return File.Exists( AbsolutePath ) ;
			}
		}
	}
}