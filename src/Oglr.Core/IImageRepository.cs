using System;
using System.Windows.Forms;

namespace Oglr.Core
{
	public interface IImageRepository
	{
		void Set(ImageProperties imageProperties) ;
		
		ImageProperties GetByName(string name) ;
		
		bool ContainsImage( string name ) ;
		
		ImageList CreateImageList( ) ;
	}
}