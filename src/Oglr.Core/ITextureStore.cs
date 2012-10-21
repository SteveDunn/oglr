using System;
using Microsoft.Xna.Framework.Graphics;

namespace Oglr.Core
{
	public interface ITextureStore
	{
		Texture2D FromFile(GraphicsDevice gd, string fullPathToFile) ;
		void Clear( ) ;

		Texture2D DummyTexture
		{
			get ;
		}
	}
}