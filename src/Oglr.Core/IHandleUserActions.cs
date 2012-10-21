using System;
using Oglr.Core.UserActions;

namespace Oglr.Core
{
	public interface IHandleUserActions
	{
		void ProcessAction( IUserAction userAction ) ;
	}
}