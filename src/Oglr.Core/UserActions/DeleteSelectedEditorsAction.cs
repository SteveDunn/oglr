using System;

namespace Oglr.Core.UserActions
{
	public class DeleteSelectedEditorsAction : IUserAction
	{
		public void Process( )
		{
			IoC.Model.DeleteSelectedItems( );
		}
	}
}