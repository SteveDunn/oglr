using System;
using Microsoft.Xna.Framework.Graphics;
using Oglr.Core;
using StructureMap;

namespace Oglr
{
    class TextureBrush
    {
		public Texture2D Texture
		{
			get;
			private set ;
		}

        public TextureBrush(string pathToImageFile)
        {
        	var textureStore = ObjectFactory.GetInstance<ITextureStore>( ) ;

        	var game = ObjectFactory.GetInstance<IGame>() ;

			Texture = textureStore.FromFile(game.GraphicsDevice, pathToImageFile);
        }
    }
}
