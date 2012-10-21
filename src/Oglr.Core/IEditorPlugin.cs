using System;
using System.Windows.Forms;

namespace Oglr.Core
{
	public interface IEditorPlugin : IPlugin
	{
		Type EditorType
		{
			get ;
		}

		ImageProperties ToolboxImage
		{
			get ;
		}

		Control ControlForAboutBox
		{
			get ;
		}

		void InitialiseInUi( IMainForm mainForm ) ;
	}
}