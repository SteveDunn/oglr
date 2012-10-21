using System;

namespace Oglr.Core
{
	public interface IRenderer
	{
		void Render( RendererParams rendererParams, Action<RendererParams> defaultRenderer ) ;
	}
}