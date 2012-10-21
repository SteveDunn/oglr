using System;
using Oglr.Core.Controls;

namespace Oglr.Core.UserActions
{
	public class RenameInPlaceAction : IUserAction
	{
		public void Process( )
		{
			IMainForm mainForm = IoC.MainForm ;

			LevelExplorerControl uiLevelExplorer = mainForm.LevelExplorer ;
			
			uiLevelExplorer.StartRename( ) ;
		}
	}
}