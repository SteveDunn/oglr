using System;
using System.Windows.Forms;

namespace Oglr.Core
{
	public interface IHandleKeyboardCommands
	{
		void HandleKeyDown(KeyEventArgs args);
	}
}