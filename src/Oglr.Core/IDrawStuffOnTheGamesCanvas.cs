using System;

namespace Oglr.Core
{
	public interface IDrawStuffOnTheGamesCanvas
	{
		void Draw( RendererParams rendererParams ) ;
		void QueueForDebugDraw( Action action ) ;
	}
}