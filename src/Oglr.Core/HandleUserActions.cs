using System;
using JetBrains.Annotations;
using Oglr.Core.UserActions;

namespace Oglr.Core
{
	[UsedImplicitly]
	public class HandleUserActions : IHandleUserActions
	{
		public void ProcessAction( IUserAction userAction )
		{
			userAction.Process(  );
		}
	}
}