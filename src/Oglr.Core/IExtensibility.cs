using System;
using System.Collections.Generic;

namespace Oglr.Core
{
	public interface IExtensibility
	{
		IEnumerable<IEditorPlugin> EditorPlugins
		{
			get ;
		}

		IEnumerable<IBehaviourPlugin> BehaviourPlugins
		{
			get ;
		}

		IEnumerable<IRenderer> Renderers
		{
			get ;
		}

		IEnumerable<IShapeProvider> ShapeProviders
		{
			get ;
		}

		IEditorPlugin FindPluginInstanceForType( Type type ) ;
		
		ItemEditor GetNewEditor(Type pluginType);
	}
}