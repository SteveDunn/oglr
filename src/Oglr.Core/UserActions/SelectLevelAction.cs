using System;

namespace Oglr.Core.UserActions
{
	public class SelectLevelAction : IUserAction
	{
		public SelectLevelAction( )
		{
		}

		public void Process( )
		{
			IoC.Model.SelectLevel( ) ;
		}
	}
}