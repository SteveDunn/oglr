using System;
using System.Windows.Forms;

namespace Oglr.Core
{
	public interface IBehaviourPlugin : IPlugin
	{
		Control ControlForAboutBox
		{
			get ;
		}

		void InitialiseInUi( IMainForm mainForm ) ;
	}
}