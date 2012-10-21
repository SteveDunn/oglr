using System;
using System.Drawing;

namespace Oglr.Core
{
	public class ImageProperties
	{
		public ImageProperties( string name, Image picture )
		{
			Name = name ;
			Picture = picture ;
		}

		public string Name
		{
			get;
			set ;
		}

		public Image Picture
		{
			get;
			set ;
		}
	}
}